Option Strict Off
Option Explicit On

Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Imports System.Text.RegularExpressions

Module SQL

    Public ADOErrorDesc As String
    Public strCommand() As String = System.Environment.GetCommandLineArgs

    Public strPlantKey As String = strCommand(1) 'Account.ini Key Word


    Public Const SAPClientNo As String = "099"
    Public SAPAlias As String 'SAPR3

    ''#End If
    Public PUCStrBits As String     'StartUp 判斷要Copy 那種版本..用

    Public cn As New Oracle.ManagedDataAccess.Client.OracleConnection(fnGetConnectString)
    Public cnSAP As New Oracle.ManagedDataAccess.Client.OracleConnection(fnGetConnectStringSAP)
    Public cnUpGrade As New Oracle.ManagedDataAccess.Client.OracleConnection(fnGetConnectString_UpGrade)
    Public transaction As Oracle.ManagedDataAccess.Client.OracleTransaction ' SqlTransaction
    Public transactionSAP As Oracle.ManagedDataAccess.Client.OracleTransaction ' SqlTransaction
    'Dim aa As Oracle.ManagedDataAccess.Client.OracleTransaction
    Public Const TransactionRetry As Integer = 3
    Private Const TransactionExec As String = "WMSDB" & "TransactionLock"
    Public Const DefaultQueryTimeOut As Integer = 5 ' 查詢TimeOut 

    Public ctlReconnectTimer As System.Windows.Forms.Timer

    Public Const DBConnectSalt As String = "TsmcOracle"
    Public Const DBConnectPwd As String = "Muratec Connect P@ssw0rd"

    'F12P1
    Public Function ADO_Query(ByRef lonRetErr As Integer, ByVal strQuery As String, ByRef data As DataTable,
                              ByRef strText As String, Optional ByRef booInBeginTran As Boolean = False, Optional ByRef lonCommandTimeOut As Integer = DefaultQueryTimeOut) As Boolean

        Dim strMessage As String

        Using command As Oracle.ManagedDataAccess.Client.OracleCommand = cn.CreateCommand()

            Dim rsTemp As Oracle.ManagedDataAccess.Client.OracleDataReader ' SqlDataReader

            Try

                command.CommandTimeout = lonCommandTimeOut

                ' Must assign both transaction object and connection
                ' to Command object for a pending local transaction.
                command.Connection = cn

                'READ ONLY 所以不用做transaction
                'command.Transaction = transaction
                If booInBeginTran = True Then
                    command.Transaction = transaction
                End If

                command.CommandText = strQuery

                rsTemp = command.ExecuteReader

                data.Load(rsTemp)

            Catch SQLExp As SqlException

                strMessage = SqlExInfo(SQLExp)
                strMessage = strMessage & "程式名稱: " & strText & Environment.NewLine
                strMessage = strMessage & "SQL語法: " & strQuery & Environment.NewLine & Environment.NewLine
                logger.Error(SQLExp, strMessage)

                If Not rsTemp Is Nothing Then
                    rsTemp.Close()
                End If

                If Not data Is Nothing Then
                    data.Clear()
                End If

                lonRetErr = SQLExp.Errors(0).Number + 20000
                ADOErrorDesc = SQLExp.Errors(0).Message
                Return False

            Catch ex As Exception
                logger.Error(ex, ex.Message)

                If Not rsTemp Is Nothing Then
                    rsTemp.Close()
                End If

                If Not data Is Nothing Then
                    data.Clear()
                End If

                lonRetErr = MSGNO.CSpecialError
                Return False
            End Try

        End Using

        Return True

    End Function

    Public Function fnSQLStrSet(ByVal strText As String) As String

        If strText Is Nothing Then
            fnSQLStrSet = "' '"
        Else

            fnSQLStrSet = "'" & strText.Replace("'", "''") & "'"
        End If

    End Function

    Public Function fnSQLStrSet_Like(ByVal strText As String) As String

        strText = strText.Replace("*", "%")
        strText = strText.Replace("?", "_")
        If InStr("%", strText) = 0 AndAlso InStr("_", strText) = 0 Then
            strText = "%" & strText & "%"
        End If
        fnSQLStrSet_Like = "'" & strText & "'"

    End Function
    Public Function fnLINQStrSet_Like(ByVal strText As String) As String

        strText = strText.Replace("%", "*")
        strText = strText.Replace("?", "_")
        If InStr("*", strText) = 0 AndAlso InStr("_", strText) = 0 Then
            strText = "*" & strText & "*"
        ElseIf strText = "" Then
            strText = "*" & strText & "*"
        End If
        fnLINQStrSet_Like = "'" & strText & "'"

    End Function

    Public Sub subReconnectTimerSet(ByRef ctlTimer As System.Windows.Forms.Timer)

        ctlTimer.Enabled = False
        ctlTimer.Interval = 5000
        ctlReconnectTimer = ctlTimer

    End Sub

    Public Function ADO_Connect(ByRef lonRetErr As Integer) As Boolean

        Try

            cn.Open()

            Return True

        Catch SQLExp As SqlException

            logger.Error(SQLExp, SQLExp.Message)

            lonRetErr = SQLExp.Errors(0).Number + 20000
            ADOErrorDesc = SQLExp.Errors(0).Message

            Return False
        Catch ex As Exception
            logger.Error(ex, ex.Message)
            lonRetErr = MsgNo.CNgComplete
            Return False
        End Try

    End Function

    Public Function ADO_SAPConnect(ByRef lonRetErr As Integer) As Boolean

        Try
            cnSAP = New Oracle.ManagedDataAccess.Client.OracleConnection(fnGetConnectStringSAP)

            cnSAP.Open()

            Return True

        Catch SQLExp As SqlException
            logger.Error(SQLExp, SQLExp.Message)
            lonRetErr = SQLExp.Errors(0).Number + 20000
            ADOErrorDesc = SQLExp.Errors(0).Message
            Return False
        Catch ex As Exception
            logger.Error(ex, ex.Message)
            lonRetErr = MsgNo.CNgComplete
            Return False
        End Try

    End Function


    Public Function ADO_Connect_UpGrade(ByRef lonRetErr As Integer) As Boolean

        Try
            cnUpGrade.Open()

            Return True

        Catch SQLExp As SqlException
            logger.Error(SQLExp, SQLExp.Message)
            lonRetErr = SQLExp.Errors(0).Number + 20000
            ADOErrorDesc = SQLExp.Errors(0).Message

            Return False
        Catch ex As Exception
            logger.Error(ex, ex.Message)
            lonRetErr = MsgNo.CNgComplete
            Return False
        End Try

    End Function

#Region "---------------RsRelease  尚未完成---------------"
    '   *********************************************
    '   *   ADO_RsRelease                  *
    '   *********************************************
    '   ADD By CHUNYI 2016/2/1
    Public Sub ADO_RsRelease(Optional ByRef dt As DataTable = Nothing, Optional ByRef dt2 As DataTable = Nothing, Optional ByRef dt3 As DataTable = Nothing)

        Try
            If dt Is Nothing Then
            Else
                dt.Reset()
                dt.Dispose()
            End If

            If dt2 Is Nothing Then
            Else
                dt2.Reset()
                dt2.Dispose()
            End If

            If dt3 Is Nothing Then
            Else
                dt3.Reset()
                dt3.Dispose()
            End If

        Catch ex As Exception
            logger.Error(ex, ex.Message)
        End Try

    End Sub
#End Region



    '   *********************************************
    '   *   QUERY                                   *
    '   *********************************************
    Public Function ADO_QueryUpGRADE(ByRef lonRetErr As Integer, ByVal strQuery As String, ByRef dataUpGrade As DataTable,
                              ByRef strText As String, Optional ByRef booInBeginTran As Boolean = False, Optional ByRef lonCommandTimeOut As Integer = DefaultQueryTimeOut) As Boolean

        Dim strMessage As String

        ADO_QueryUpGRADE = False

        Using command As Oracle.ManagedDataAccess.Client.OracleCommand = cnUpGrade.CreateCommand()

            Dim rsTemp As Oracle.ManagedDataAccess.Client.OracleDataReader

            Try

                command.CommandTimeout = lonCommandTimeOut

                ' Must assign both transaction object and connection
                ' to Command object for a pending local transaction.
                command.Connection = cnUpGrade

                'READ ONLY 所以不用做transaction
                'command.Transaction = transaction
                'If booInBeginTran = True Then
                '    command.Transaction = transactionSAP
                'End If

                command.CommandText = strQuery

                rsTemp = command.ExecuteReader

                dataUpGrade.Load(rsTemp)

            Catch SQLExp As SqlException

                strMessage = SqlExInfo(SQLExp)
                strMessage = strMessage & "程式名稱: " & strText & Environment.NewLine
                strMessage = strMessage & "SQL語法: " & strQuery & Environment.NewLine & Environment.NewLine
                logger.Error(SQLExp, strMessage)

                rsTemp.Close()
                dataUpGrade.Clear()

                lonRetErr = SQLExp.Errors(0).Number + 20000
                ADOErrorDesc = SQLExp.Errors(0).Message
                Return False
            Catch ex As Exception
                logger.Error(ex, ex.Message)

                rsTemp.Close()
                dataUpGrade.Clear()
                lonRetErr = MSGNO.CSpecialError
                Return False
            End Try

        End Using

        Return True

    End Function


    '   *********************************************
    '   *   QUERY                                   *
    '   *********************************************
    Public Function ADO_QuerySAP(ByRef lonRetErr As Integer, ByVal strQuery As String, ByRef dataSAP As DataTable,
                              ByRef strText As String, Optional ByRef booInBeginTran As Boolean = False, Optional ByRef lonCommandTimeOut As Integer = DefaultQueryTimeOut) As Boolean

        Dim strMessage As String

        ADO_QuerySAP = False

        Using command As Oracle.ManagedDataAccess.Client.OracleCommand = cnSAP.CreateCommand()

            Dim rsTemp As Oracle.ManagedDataAccess.Client.OracleDataReader ' SqlDataReader

            Try

                command.CommandTimeout = lonCommandTimeOut

                ' Must assign both transaction object and connection
                ' to Command object for a pending local transaction.
                command.Connection = cnSAP

                'READ ONLY 所以不用做transaction
                'command.Transaction = transaction
                If booInBeginTran = True Then
                    command.Transaction = transactionSAP
                End If

                command.CommandText = strQuery

                rsTemp = command.ExecuteReader

                dataSAP.Load(rsTemp)

            Catch SQLExp As SqlException

                strMessage = SqlExInfo(SQLExp)
                strMessage = strMessage & "程式名稱: " & strText & Environment.NewLine
                strMessage = strMessage & "SQL語法: " & strQuery & Environment.NewLine & Environment.NewLine
                logger.Error(SQLExp, strMessage)

                rsTemp.Close()
                dataSAP.Clear()

                lonRetErr = SQLExp.Errors(0).Number + 20000
                ADOErrorDesc = SQLExp.Errors(0).Message
                Return False
            Catch ex As Exception
                logger.Error(ex, ex.Message)
                rsTemp.Close()
                dataSAP.Clear()
                lonRetErr = MSGNO.CSpecialError
                Return False
            End Try

        End Using

        Return True

    End Function

    '   *********************************************
    '   *   BEGIN TRANSACTION                       *
    '   *********************************************
    Public Function ADO_BeginTrn(ByRef lonRetErr As Integer) As Boolean

        Try
            ' Start a local transaction
            'transaction = cn.BeginTransaction(BeginName)
            transaction = cn.BeginTransaction()
            'transaction = cn.BeginTransaction(IsolationLevel.Serializable)

            Return True

        Catch SQLExp As SqlException
            logger.Error(SQLExp, SQLExp.Message)
            lonRetErr = SQLExp.Errors(0).Number + 20000
            ADOErrorDesc = SQLExp.Errors(0).Message
            Return False
        Catch ex As Exception
            logger.Error(ex, ex.Message)
            lonRetErr = MSGNO.CNgComplete
            Return False
        End Try

    End Function

    '   *********************************************
    '   *   BEGIN TRANSACTION                       *
    '   *********************************************
    Public Function ADO_BeginTrnSAP(ByRef lonRetErr As Integer, Optional ByVal BeginName As String = TransactionExec) As Boolean

        Try

            ' Start a local transaction
            'transaction = cn.BeginTransaction(BeginName)

            transactionSAP = cnSAP.BeginTransaction(IsolationLevel.Serializable)

            Return True

        Catch SQLExp As SqlException
            logger.Error(SQLExp, SQLExp.Message)
            lonRetErr = SQLExp.Errors(0).Number + 20000
            ADOErrorDesc = SQLExp.Errors(0).Message
            Return False
        Catch ex As Exception
            logger.Error(ex, ex.Message)
            lonRetErr = MsgNo.CNgComplete
            Return False
        End Try

    End Function

    '   *********************************************
    '   *   COMMIT TRANSACTION                      *
    '   *********************************************
    Public Function ADO_Commit(ByRef lonRetErr As Integer) As Boolean

        Try
            transaction.Commit()

            Return True

        Catch SQLExp As SqlException
            logger.Error(SQLExp, SQLExp.Message)
            lonRetErr = SQLExp.Errors(0).Number + 20000
            ADOErrorDesc = SQLExp.Errors(0).Message
            Return False
        Catch ex As Exception
            logger.Error(ex, ex.Message)
            lonRetErr = MSGNO.CNgComplete
            Return False
        End Try

    End Function

    '   *********************************************
    '   *   COMMIT TRANSACTION                      *
    '   *********************************************
    Public Function ADO_CommitSAP(ByRef lonRetErr As Integer) As Boolean

        Try
            transactionSAP.Commit()

            Return True

        Catch SQLExp As SqlException
            logger.Error(SQLExp, SQLExp.Message)
            lonRetErr = SQLExp.Errors(0).Number + 20000
            ADOErrorDesc = SQLExp.Errors(0).Message
            Return False
        Catch ex As Exception
            logger.Error(ex, ex.Message)
            lonRetErr = MsgNo.CNgComplete
            Return False
        End Try

    End Function

    '   *********************************************
    '   *   QUERY                                   *
    '   *********************************************
    Public Function ADO_Exec(ByRef lonRetErr As Integer, ByVal strQuery As String, ByRef lonRetRecordCount As Long,
                            ByRef strText As String,
                            Optional ByRef shoCommandTimeOut As Integer = DefaultQueryTimeOut) As Boolean
        Dim strMessage As String

        ADO_Exec = False

        Using command As Oracle.ManagedDataAccess.Client.OracleCommand = cn.CreateCommand()

            Try

                command.CommandTimeout = shoCommandTimeOut

                ' Must assign both transaction object and connection
                ' to Command object for a pending local transaction.
                command.Connection = cn

                command.Transaction = transaction

                command.CommandText = strQuery

                lonRetRecordCount = command.ExecuteNonQuery()

            Catch SQLExp As SqlException
                logger.Error(SQLExp, strMessage)
                lonRetErr = SQLExp.Errors(0).Number + 20000
                ADOErrorDesc = SQLExp.Errors(0).Message
                Return False
            Catch ex As Exception
                logger.Error(ex, ex.Message)
                lonRetErr = MSGNO.CSpecialError
                Return False
            End Try

        End Using

        Return True

    End Function

    Public Function ADO_ExecSAP(ByRef lonRetErr As Integer, ByVal strQuery As String, ByRef lonRetRecordCount As Long,
                           ByRef strText As String,
                           Optional ByRef shoCommandTimeOut As Integer = DefaultQueryTimeOut) As Boolean
        Dim strMessage As String

        ADO_ExecSAP = False

        Using command As Oracle.ManagedDataAccess.Client.OracleCommand = cnSAP.CreateCommand()

            Try

                command.CommandTimeout = shoCommandTimeOut
                ' Must assign both transaction object and connection
                ' to Command object for a pending local transaction.
                command.Connection = cnSAP

                command.Transaction = transactionSAP

                command.CommandText = strQuery

                lonRetRecordCount = command.ExecuteNonQuery()

            Catch SQLExp As SqlException
                strMessage = SqlExInfo(SQLExp)
                strMessage = strMessage & "程式名稱: " & strText & Environment.NewLine
                strMessage = strMessage & "SQL語法: " & strQuery & Environment.NewLine & Environment.NewLine
                logger.Error(SQLExp, strMessage)

                lonRetErr = SQLExp.Errors(0).Number + 20000
                ADOErrorDesc = SQLExp.Errors(0).Message
                Return False
            Catch ex As Exception
                logger.Error(ex, ex.Message)
                lonRetErr = MSGNO.CSpecialError
                Return False
            End Try

        End Using

        Return True

    End Function

    '   *********************************************
    '   *   ABORT TRANSACTION                       *
    '   *********************************************
    Public Sub ADO_Rollback(Optional ByRef lonRetErr As Integer = 0)

        Try
            transaction.Rollback()

        Catch SQLExp As SqlException
            logger.Error(SQLExp, SQLExp.Message)
            lonRetErr = SQLExp.Errors(0).Number + 20000
            ADOErrorDesc = SQLExp.Errors(0).Message
        Catch ex As Exception
            logger.Error(ex, ex.Message)
        End Try

    End Sub

    Public Sub ADO_RollbackSAP(Optional ByRef lonRetErr As Integer = 0)

        Try
            transactionSAP.Rollback()

        Catch SQLExp As SqlException
            logger.Error(SQLExp, SQLExp.Message)
            lonRetErr = SQLExp.Errors(0).Number + 20000
            ADOErrorDesc = SQLExp.Errors(0).Message
        Catch ex As Exception
            logger.Error(ex, ex.Message)
        End Try

    End Sub

    Public Function SqlExInfo(ByVal ex As SqlException) As String
        Dim ErrInfo As String = ""
        For i As Integer = 0 To ex.Errors.Count - 1
            ErrInfo = "索引: " & i.ToString
            ErrInfo &= Environment.NewLine
            ErrInfo &= "錯誤說明: " & ex.Errors(i).Message
            ErrInfo &= Environment.NewLine
            ErrInfo &= "資料庫錯誤: " & ex.Errors(i).State
            ErrInfo &= Environment.NewLine
            ErrInfo &= "使用者名稱: " & ex.Errors(i).Source
            ErrInfo &= Environment.NewLine
            ErrInfo &= "錯誤代碼: " & ex.Errors(i).Number

            ErrInfo &= Environment.NewLine

        Next i

        Return ErrInfo

    End Function


    Public Function fnGetConnectString_UpGrade() As String
        Dim lonRetErr As Integer
        Dim booRet As Boolean
        Dim account As TSMCBASE64.Account
        Dim strFName As String = System.Reflection.MethodBase.GetCurrentMethod.Name

        Try

            Dim strFileName As String = GSystemPath & "Account.INI"


            PUCStrBits = ReadINI(strFileName, "ORAVER")


            'Use Base64 Account Information
            booRet = TSMCBASE64.B64FileRead(strPlantKey, strFileName, account, lonRetErr)
            If booRet = False Then
                Dim strDataSource As String = ReadINI(strFileName, "DsSvrnm")
                Dim strUserName As String = ReadINI(strFileName, "UsrID")
                Dim strPassword As String = ReadINI(strFileName, "Pass")
                Dim strHost As String = ReadINI(strFileName, "SIP")
                Dim strServiceName As String = ReadINI(strFileName, "SID")


                Return "Data Source=(DESCRIPTION =(ADDRESS_LIST =(ADDRESS = (PROTOCOL = TCP)(HOST =" & strHost &
                 ")(PORT = 1521)))(CONNECT_DATA =(SERVER=DEDICATED)(SERVICE_NAME = " & strServiceName & " )));" &
                 "User ID=" & strUserName & " ;Password= " & strPassword
            Else
                PUCStrBits = account.OraVer
            End If

            Return "Data Source=(DESCRIPTION =(ADDRESS_LIST =(ADDRESS = (PROTOCOL = TCP)(HOST =" & account.HostIp &
                 ")(PORT = 1521)))(CONNECT_DATA =(SERVER=DEDICATED)(SERVICE_NAME = " & account.ServiceName & " )));" &
                 "User ID=" & account.UsrID & " ;Password= " & account.Pass

        Catch ex As Exception
            logger.Error(ex, ex.Message)
            Return " "
        End Try

        Return True
    End Function


    Public Sub ADO_DisConnect()

        Try
            If cn.State <> System.Data.ConnectionState.Closed Then
                cn.Close()
            End If

            '設成Nothing 後..就無法Reconnect 囉  Mark by CHUNYI
            'cn = Nothing

        Catch ex As Exception
            logger.Error(ex, ex.Message)
        End Try

    End Sub

    Public Sub ADO_DisConnectSAP()

        Try
            If cnSAP.State <> System.Data.ConnectionState.Closed Then
                cnSAP.Close()
            End If

            cnSAP = Nothing

        Catch ex As Exception
            logger.Error(ex, ex.Message)
        End Try

    End Sub

    Public Sub ADO_DisConnectUpGrade()

        Try
            If cnUpGrade.State <> System.Data.ConnectionState.Closed Then
                cnUpGrade.Close()
            End If

            cnUpGrade = Nothing

        Catch ex As Exception
            logger.Error(ex, ex.Message)
        End Try

    End Sub

    'Friend Sub ADO_RsRelease(dt As DataTable)
    '    Throw New NotImplementedException()
    'End Sub
End Module


