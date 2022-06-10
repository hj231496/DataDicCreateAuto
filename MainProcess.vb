Public Class MainProcess
    Dim booSearch As Boolean = False
    Private Sub MainProcess_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'Log初始設定
            RLOG.InitConfig("C:\Muratec\log", 1, "DataDicCreateAuto", 1)
            RLOG_FILE.InitProcessFile()
            RLOG_FORM.InitProcessBox(Me.Name, RichTextBox1.Name)
            RLOG_FILE.InitTransFile()

            DataBaseDetail.ShowDialog()

            If DataBase_Oracle.cn.State = ConnectionState.Open Then
                Me.Text &= "- For TSMC_Oracle || " & DataBase_Oracle.cn.ConnectionString
            ElseIf DataBase_SQL.cn.State = ConnectionState.Open Then
                Me.Text &= "- For SQL || " & DataBase_SQL.cn.ConnectionString
            Else
                Exit Sub
            End If

            subGetAllTableName()

        Catch ex As Exception
            logger.Error(ex.Message)
        End Try
    End Sub

    Private Sub B_DataDicPath_Click(sender As Object, e As EventArgs) Handles B_DataDicPath.Click
        Try

            FolderBrowserDialog1.ShowDialog()

            If FolderBrowserDialog1.SelectedPath.ToString <> "" Then
                L_FilePath.AutoSize = True
                L_FilePath.Text = FolderBrowserDialog1.SelectedPath.ToString
            End If



        Catch ex As Exception
            logger.Error(ex.Message)
            L_FilePath.Text = "C:\XXX\DataDic.vb"
        End Try


    End Sub

    Private Sub subGetAllTableName()
        Dim strFName As String = System.Reflection.MethodBase.GetCurrentMethod.Name
        Dim strSQL As String
        Dim booRet As Boolean
        Dim lonRetErr As Long
        Dim strMessage As String
        Try

            Using dt As New DataTable
                If DataBaseDetail.booOracle Then
                    strSQL = "SELECT OBJECT_NAME AS NAME FROM USER_OBJECTS WHERE OBJECT_TYPE = 'TABLE'"
                    booRet = DataBase_Oracle.ADO_Query(lonRetErr, strSQL, dt, strFName)
                End If

                If DataBaseDetail.booSQL Then
                    strSQL = "SELECT TABLE_NAME AS NAME FROM INFORMATION_SCHEMA.TABLES"
                    booRet = DataBase_SQL.ADO_Query(strMessage, strSQL, dt, strFName)
                End If

                If Not booRet Then
                    logger.Error("取得所有資料表失敗。")
                    logger.Error("SQL語法:{0} " & strSQL)
                End If

                If dt.Rows.Count = 0 Then
                    logger.Warn("找不到任何資料表。")
                    logger.Warn("SQL語法:{0} " & strSQL)
                End If

                CheckedListBox1.Items.Clear()

                For Each row As DataRow In dt.Rows
                    CheckedListBox1.Items.Add(row.Item("NAME"))
                Next

                CheckedListBox1.SelectedIndex = 0

            End Using


        Catch ex As Exception
            logger.Error(ex.Message)
        End Try


    End Sub

    Private Sub B_Convert_Click(sender As Object, e As EventArgs) Handles B_Convert.Click
        Dim strFName As String = System.Reflection.MethodBase.GetCurrentMethod.Name

        Dim strDefaultSQL As String

        If DataBaseDetail.booOracle Then
            strDefaultSQL = "Select COLUMN_NAME From USER_TAB_COLUMNS Where TABLE_NAME ="
        End If

        If DataBaseDetail.booSQL Then
            strDefaultSQL = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME ="
        End If

        Dim strSQL As String
        Dim booRet As Boolean
        Dim lonRetErr As Long
        Dim strValue(0) As String
        Dim strName(0) As String
        Dim intCount As Integer
        Dim wr As System.IO.StreamWriter
        Dim booExist As Boolean
        Dim strDefalutCodeHead As String = "Option Strict Off" & vbCrLf & "Option Explicit On" & vbCrLf & vbCrLf & "Module DataDic" & vbCrLf
        Dim strDefalutCodeEnd As String = vbCrLf & "End Module"
        Dim booWrite As Boolean
        Dim strTmp As String
        Dim booDash As Boolean
        Dim intTmp As Integer
        Dim strMessage As String

        Try
            If FolderBrowserDialog1.SelectedPath <> "" Then
                For i As Integer = 0 To CheckedListBox1.CheckedItems.Count - 1

                    strSQL = strDefaultSQL & DataBase_Oracle.fnSQLStrSet(CheckedListBox1.CheckedItems.Item(i).ToString)
                    Using dt As New DataTable
                        If DataBaseDetail.booOracle Then
                            booRet = DataBase_Oracle.ADO_Query(lonRetErr, strSQL, dt, strFName)
                        End If
                        If DataBaseDetail.booSQL Then
                            booRet = DataBase_SQL.ADO_Query(strMessage, strSQL, dt, strFName)
                        End If
                        If Not booRet Then
                            logger.Error("取得所有欄位失敗!!")
                            logger.Error("SQL語法:{0} " & strSQL)
                            Exit Sub
                        End If

                        If dt.Rows.Count = 0 Then
                            logger.Warn("找不到任何欄位!!")
                            logger.Warn("SQL語法:{0} " & strSQL)
                            Exit Sub
                        End If

                        logger.Info(CheckedListBox1.CheckedItems.Item(i).ToString & " 處理中...")
                        ReDim Preserve strValue(strValue.Length + dt.Rows.Count + 2)
                        ReDim Preserve strName(strValue.Length + dt.Rows.Count + 2)
                        '註解
                        strValue(intCount) = "    '"
                        strValue(intCount) = strValue(intCount).PadRight(20, "*")
                        strValue(intCount) &= CheckedListBox1.CheckedItems.Item(i).ToString
                        strValue(intCount) = strValue(intCount).PadRight(60, "*")

                        intCount += 1

                        booWrite = False
                        For Each row As DataRow In dt.Rows
                            '應該先判斷 有沒有這個東西
                            booExist = False
                            For intChcek As Integer = 0 To intCount - 1
                                If strValue(intChcek) = row.Item("COLUMN_NAME") Then
                                    booExist = True
                                    Exit For
                                End If
                            Next

                            If Not booExist Then

                                strTmp = row.Item("COLUMN_NAME")
                                booExist = False
                                booDash = False

                                If strTmp.ToString.Contains("_") Then
                                    booDash = True
                                    strTmp = strTmp.ToString.Replace("_", "")
                                End If


                                For intChcek As Integer = 0 To intCount - 1 '有槓找沒槓
                                    If strName(intChcek) = strTmp Then
                                        intTmp = intChcek
                                        booExist = True
                                        Exit For
                                    End If
                                Next

                                If booExist Then
                                    If Not booDash Then
                                        strTmp &= "_H"
                                    Else
                                        strName(intTmp) &= "_H"
                                    End If

                                End If

                                booWrite = True

                                'Oracle只會有$、#、_這三種符號
                                '因此只須對這三種做處理
                                If strTmp.IndexOf("#") <> -1 Then
                                    strTmp = strTmp.Replace("#", "")
                                End If

                                If strTmp.IndexOf("$") <> -1 Then
                                    strTmp = strTmp.Replace("$", "")
                                End If


                                strName(intCount) = strTmp
                                strValue(intCount) = row.Item("COLUMN_NAME")
                                intCount += 1
                            End If
                        Next

                        '註解
                        strValue(intCount) = "    '"
                        strValue(intCount) = strValue(intCount).PadRight(60, "*") & vbCrLf

                        intCount += 1

                        If booWrite = False Then
                            strValue(intCount - 2) = ""
                            strValue(intCount - 1) = ""
                            intCount -= 2
                        End If
                    End Using


                Next

                wr = New System.IO.StreamWriter(FolderBrowserDialog1.SelectedPath & "/DataDic.vb")
                wr.WriteLine(strDefalutCodeHead)

                For intNum As Integer = 0 To intCount - 1

                    If strValue(intNum).Contains("*") Then
                        wr.WriteLine(strValue(intNum))
                    Else
                        wr.WriteLine("    Public Const G" & strName(intNum) & " As String = " & Chr(34) & strValue(intNum) & Chr(34))
                    End If

                Next

                wr.WriteLine(strDefalutCodeEnd)

                wr.Close()

                logger.Info("產生 DataDic.vb 成功~~")
            Else
                logger.Warn("請指定欲儲存之DataDic.vb位置。")
            End If



        Catch ex As Exception
            wr.Close()
            logger.Error(ex.Message)
        End Try



    End Sub
    Private Sub T_Search_KeyDown(sender As Object, e As KeyEventArgs) Handles T_Search.KeyDown

        Try
            If e.KeyCode = Keys.Return Then


                For i As Integer = CheckedListBox1.SelectedIndex + 1 To CheckedListBox1.Items.Count
                    If i = CheckedListBox1.Items.Count And booSearch = True Then
                        i = 0
                    ElseIf i = CheckedListBox1.Items.Count And booSearch = False Then
                        Exit For
                    End If

                    If CheckedListBox1.Items(i).ToString.Contains(T_Search.Text.Trim) Then
                        booSearch = True
                        CheckedListBox1.SelectedIndex = i
                        Exit For
                    End If
                Next
            End If
        Catch ex As Exception
            logger.Error(ex.Message)
        End Try

    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Try
            If CheckBox1.Checked = True Then
                For i As Integer = 0 To CheckedListBox1.Items.Count - 1
                    CheckedListBox1.SetItemChecked(i, True)
                Next
            Else
                For i As Integer = 0 To CheckedListBox1.Items.Count - 1
                    CheckedListBox1.SetItemChecked(i, False)
                Next
            End If

        Catch ex As Exception
            logger.Error(ex.Message)
        End Try
    End Sub

    Private Sub T_Search_TextChanged(sender As Object, e As EventArgs) Handles T_Search.TextChanged
        booSearch = False
    End Sub

    Private Sub Btn_DataBaseSet_Click(sender As Object, e As EventArgs) Handles Btn_DataBaseSet.Click
        Try
            Me.Text = "DataDicCreateAuto"
            DataBaseDetail.ShowDialog()

            If DataBase_Oracle.cn.State = ConnectionState.Open Then
                Me.Text &= "- For TSMC_Oracle || " & DataBase_Oracle.cn.ConnectionString
            ElseIf DataBase_SQL.cn.State = ConnectionState.Open Then
                Me.Text &= "- For SQL || " & DataBase_SQL.cn.ConnectionString
            Else
                Exit Sub
            End If

            subGetAllTableName()
        Catch ex As Exception
            logger.Error(ex.Message)
        End Try


    End Sub
End Class
