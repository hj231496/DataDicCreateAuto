Public Class DataBaseDetail
    Public Const PUCDefaultPlantKey As String = "TSMCF99P1"
    Public Const PUCDefaultLoginName As String = "user"
    Public Const PUCDefaulLoginPass As String = "muratec"
    Public Const PUCDefaultDataBaseName As String = "Master"
    Public Const PUCDefaultServerName As String = "192.168.0.1"

    Public booOracle As Boolean = False
    Public booSQL As Boolean = False
    Private Sub DataBaseDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            KeyPreview = True
            '預設字元
            T_LoginName.Text = PUCDefaultLoginName
            T_LoginPassWord.Text = PUCDefaulLoginPass
            T_DataBaseName.Text = PUCDefaultDataBaseName
            T_ServerName.Text = PUCDefaultServerName
            T_OraclePlantKey.Text = PUCDefaultPlantKey
            booOracle = False
            booSQL = False

            'todo is nothing??
            If DataBase_Oracle.cn.State = ConnectionState.Open Then
                DataBase_Oracle.ADO_DisConnect()
                logger.Warn("資料庫已斷開。")
            End If
            If DataBase_SQL.cn.State = ConnectionState.Open Then
                DataBase_SQL.ADO_DisConnect()
                logger.Warn("資料庫已斷開。")
            End If

        Catch ex As Exception
            logger.Error(ex.Message)
        End Try



    End Sub
    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        Dim lonRetErr As Long
        Dim booRet As Boolean


        '進行連線
        Try
            If RB_Oracle.Checked = True And GB_ForOracle.Visible = True Then
                DataBase_Oracle.cn.ConnectionString = fnGetConnectStringForOracle()
                booRet = DataBase_Oracle.ADO_Connect(lonRetErr)
                If Not booRet Then
                    logger.Warn("Oracle連線失敗。")
                Else
                    logger.Info("Oracle連線成功。")
                    booOracle = True
                End If

            ElseIf RB_SQL.Checked = True And GB_ForSQL.Visible = True Then
                DataBase_SQL.cn.ConnectionString = fnGetConnectString()
                DataBase_SQL.ADO_Connect()
                If DataBase_SQL.cn.State = Data.ConnectionState.Open Then
                    logger.Info("連線成功。")
                    booSQL = True
                End If
            End If

        Catch ex As Exception
            logger.Error(ex.Message)
        End Try

        Me.Close()


    End Sub
    Private Sub RB_SQL_CheckedChanged(sender As Object, e As EventArgs) Handles RB_SQL.CheckedChanged

        '預設字元
        T_LoginName.Text = PUCDefaultLoginName
        T_LoginPassWord.Text = PUCDefaulLoginPass
        T_DataBaseName.Text = PUCDefaultDataBaseName
        T_ServerName.Text = PUCDefaultServerName

        GB_ForOracle.Visible = False
        GB_ForSQL.Visible = True
    End Sub
    Private Sub RB_Oracle_CheckedChanged(sender As Object, e As EventArgs) Handles RB_Oracle.CheckedChanged
        '預設字元
        T_OraclePlantKey.Text = PUCDefaultPlantKey

        GB_ForOracle.Visible = True
        GB_ForSQL.Visible = False
    End Sub
    Private Sub T_OraclePlantKey_Click(sender As Object, e As EventArgs) Handles T_OraclePlantKey.Click
        T_OraclePlantKey.Text = ""
    End Sub
    Private Sub T_LoginName_Click(sender As Object, e As EventArgs) Handles T_LoginName.Click
        T_LoginName.Text = ""
    End Sub
    Private Sub T_LoginPassWord_Click(sender As Object, e As EventArgs) Handles T_LoginPassWord.Click
        T_LoginPassWord.Text = ""
    End Sub
    Private Sub T_ServerName_Click(sender As Object, e As EventArgs) Handles T_ServerName.Click
        T_ServerName.Text = ""
    End Sub
    Private Sub T_DataBaseName_Click(sender As Object, e As EventArgs) Handles T_DataBaseName.Click
        T_DataBaseName.Text = ""
    End Sub
    Private Sub TextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles T_OraclePlantKey.KeyDown, T_DataBaseName.KeyDown
        Select Case e.KeyCode
            Case Keys.Return
                Btn_Close_Click(Btn_Close, New EventArgs())
        End Select

    End Sub
End Class