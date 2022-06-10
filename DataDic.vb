Option Strict Off
Option Explicit On

Imports System.Collections.Generic
Imports System.Linq
Imports System.Configuration

Module DataDic

#If False Then
    Public GHostDocData As Integer = 0
    Public GHostGRPost As Integer = 1
    Public GHostPAData As Integer = 2
    Public GHostPAPost As Integer = 3 
    Public GHostMRUpdate As Integer = 4
    Public GHostTestMode As Integer = 0 '0:生產環境 
    Public GHostASKMR As Integer = 10
    Public GSystemPath As String = "C:\MURATEC\"

    Public GTestMode As Boolean = False
    Public GDefPointFlag As Boolean = False
#Else
    Public GHostDocData As Integer = 5
    Public GHostGRPost As Integer = 6
    Public GHostPAData As Integer = 7
    Public GHostPAPost As Integer = 8
    Public GHostMRUpdate As Integer = 9
    Public GHostTestMode As Integer = 1 '0:TEST環境 
    Public GHostASKMR As Integer = 11

    Public GSystemPath As String = "C:\MURATEC\"
    Public GTestMode As Boolean = True
    Public GDefPointFlag As Boolean = False

#End If

    '引數開畫面用
    Public strIDKey As String = ""
    Public strScreenNOKey As String = ""

    Public Const GArrayNo As String = "ARRAY_NO"



    'ALIVE
    Public Const ConDeviceCrane As Integer = 0
    Public Const ConDeviceLocal As Integer = 1
    Public Const ConDeviceBCR As Integer = 2
    Public Const ConDeviceGUI As Integer = 3
    Public Const ConDeviceRTN As Integer = 4
    Public Const ConDeviceSchedule As Integer = 5
    Public Const ConDeviceRFID As Integer = 6
    Public Const ConDeviceWebService As Integer = 7
    Public Const ConDeviceUtility As Integer = 8
    Public Const ConDeviceDisplay As Integer = 9
    Public Const ConDeviceOther As Integer = 99

    Public Const ConDeviceNoGUI As Integer = 1


    '********************System Table****************************
    Public Const GSection As String = "SECTION"
    Public Const GStat As String = "STAT"
    Public Const GMemo As String = "MEMO"

    '**********************DEVICE********************************
    Public Const GDeviceNo As String = "DEVICE_NO"
    Public Const GProhibit As String = "PROHIBIT"
    Public Const GErrCode As String = "ERR_CODE"
    Public Const GOneBeforeFrom As String = "ONE_BEFORE_FROM"
    Public Const GOneBeforeTo As String = "ONE_BEFORE_TO"
    Public Const GJustNowFrom As String = "JUST_NOW_FROM"
    Public Const GJustNowTo As String = "JUST_NOW_TO"
    Public Const GStoreInCount As String = "STOREIN_COUNT"
    Public Const GStoreOutCount As String = "STOREOUT_COUNT"
    Public Const GEmptyLocation As String = "EMPTY_LOCATION"
    Public Const GStockLocation As String = "STOCK_LOCATION"
    Public Const GPalletLocation As String = "PALLET_LOCATION"

    ' ****************** Material No Master **********************
    Public Const GMatNo As String = "MAT_NO"

    Public Const GMatDesc As String = "MAT_DESC"
    Public Const GImageDat As String = "IMAGE_DAT"
    Public Const GBinType As String = "BIN_TYPE"
    Public Const GLPMax As String = "LPMAX"
    Public Const GBaseUnit As String = "BASE_UNIT"
    Public Const GIssueUnit As String = "ISSUE_UNIT"
    Public Const GIssueUnitQty As String = "ISSUE_UNIT_QTY"
    Public Const GBaseUnitQty As String = "BASE_UNIT_QTY"
    Public Const GValidPeriod As String = "VALID_PERIOD"
    Public Const GWafer As String = "WAFER"

    ' ****************** Stock **********************
    Public Const GStorageLocation As String = "STORAGE_LOCATION"
    Public Const GPalletNo As String = "PALLET_NO"
    Public Const GBinNo As String = "BIN_NO"
    Public Const GPlant As String = "PLANT"
    Public Const GInsStat As String = "INS_STAT"
    Public Const GConStat As String = "CON_STAT"
    Public Const GInspector As String = "INSPECTOR"
    Public Const GStockDate As String = "STOCK_DATE"
    Public Const GStockQty As String = "STOCK_QTY"
    Public Const GIQCQty As String = "IQC_QTY"
    Public Const GResvQty As String = "RESV_QTY"
    Public Const GStorageQty As String = "STORAGE_QTY"
    Public Const GExpirationDate As String = "EXPIRATION_DATE"
    Public Const GSFStat As String = "SF_STAT"
    Public Const GVendorCode As String = "VENDOR_CODE"
    Public Const GVendorMatNo As String = "VENDOR_MAT_NO"
    Public Const GUserName As String = "USER_NAME"
    Public Const GMvType As String = "MV_TYPE"
    Public Const GGroupQty As String = "GROUP_QTY"
    Public Const GErrorFlag As String = "Error_Flag"
    Public Const GStockType As String = "STOCK_TYPE"
    Public Const GRemark As String = "REMARK"
    Public Const GEmployeeID As String = "EmployeeID"
    Public Const GMaterialDocItem As String = "MaterialDocItem"
    Public Const GFinalcycleDate As String = "FINALCYCLE_DATE"
    Public Const GGrossWeight As String = "GROSS_WEIGHT"
    Public Const GNetWeight As String = "NET_WEIGHT"
    Public Const GRpartsPts As String = "RPARTS_PTS"
    Public Const GWeight As String = "WEIGHT"
    Public Const GPhace As String = "PHASE"
    Public Const GScanflag As String = "SCANFLAG"
    Public Const GWareHouseNo As String = "WAREHOUSE_NO"
    Public Const GMainPallet As String = "MAIN_PALLET"
    Public Const GMainBin As String = "MAIN_BIN"
    Public Const GPalletType As String = "PALLET_TYPE"

    '------------20211223新增-----------------------
    Public Const GPADATA_TO As String = "PADATA_TO"
    Public Const GPADATA_TOITEM As String = "PADATA_TOITEM"
    Public Const GPKDATA_TO As String = "PKDATA_TO"
    Public Const GPKDATA_TOITEM As String = "PKDATA_TOITEM"
    Public Const GHybox As String = "HYBOX"
    '***************ProFile*************************
    Public Const GQty As String = "QTY"
    Public Const GCostCenter As String = "COST_CENTER"
    Public Const GGroupNo As String = "GROUP_NO"


    '********************** History **********************
    Public Const GGRNo As String = "GR_No"
    Public Const GPONo As String = "PO_No"
    Public Const GPOItem As String = "PO_ITEM"
    Public Const GPlanner As String = "PLANNER"
    Public Const GSLocation As String = "STORAGE_LOCATION"
    Public Const GReason As String = "REASON"

    Public Const GLocation As String = "LOCATION"

    '******************Unit_Transfer**********************8
    Public Const GTotalQty As String = "TOTAL_QTY"
    Public Const GMeasure As String = "MEASURE"
    Public Const GLocQty As String = "LOC_QTY"


    '*****************Loc_Stat**********************
    Public Const GUnitType As String = "UNIT_TYPE"
    Public Const GCrnNo As String = "CRN_NO"
    Public Const GLocStat As String = " Loc_Stat"
    Public Const GStorageSEQ As String = "STORAGE_SEQ"
    Public Const GCapa As String = "Capa"
    Public Const GStorageType As String = "STORAGE_TYPE"
    Public Const GStorageSection As String = "STORAGE_SECTION"
    Public Const GDescription As String = "DESCRIPTION"
    Public Const GStorageCond As String = "STORAGE_COND"
    Public Const GCondition As String = "CONDITION"
    Public Const GProperty As String = "PROPERTY"
    Public Const GHeight As String = " HEIGHT"
    Public Const GDisPlayNo As String = "DISPLAY_NO"
    Public Const GPinkFlag As String = "PINK_FLAG"
    Public Const GStockReason As String = "STOCK_REASON"

    Public Const GSRCPoint As String = "SRC_POINT"
    Public Const GDestPoint As String = "DEST_POINT"
    Public Const GReadEventID As String = "READ_EVENT_ID"

    Public Const GPackageID As String = "PACKAGEID"
    Public Const GIssueQty As String = "ISSUE_QTY"

    '********************EMPLOYEE*********************
    Public Const GFullName As String = "FULL_NAME"
    Public Const GEM_No As String = "EM_NO"
    Public Const GPlannere As String = "PLANNERE"
    Public Const GAddr As String = "ADDR"
    Public Const GMagrId1 As String = "MAGR_ID1"
    Public Const GMagrid2 As String = "MAGR_ID2"
    Public Const GMagrAddr1 As String = "MAGR_ADDR1"
    Public Const GMagrAddr2 As String = "MAGR_ADDR2"
    Public Const GSecrId As String = "SECR_ID"
    Public Const GSecrAddr As String = "SECR_ADDR"
    Public Const GPassword As String = "PASSWORD"
    Public Const GTelNo As String = "TEL_NO"
    Public Const GCardID As String = "CARDID"
    Public Const GSapLogin As String = "SAP_LOGIN"
    Public Const GPrivilege As String = "Privilege"
    Public Const GLockFlag As String = "LOCKFLAG"

    '*************PRIVILEGE***********************
    Public Const GRank As String = "RANK"
    Public Const GScreenNo As String = "SCREEN_NO"
    '*************PALLET***************************
    Public Const GPLStat As String = "PL_STAT"
    Public Const GProhibitStat As String = "PROHIBIT_STAT"
    Public Const GItems As String = "ITEMS"
    Public Const GLocalNo As String = "LOCAL_NO"
    Public Const GCraneNo As String = "CRANENO"
    Public Const GType As String = "TYPE"
    Public Const GCreateDate As String = "CREATE_DATE"
    Public Const GUpdateDate As String = "UPDATE_DATE"

    '"***************** Transfer NO *************************
    Public Const GPointNo As String = "POINT_NO" 'Trasport NO
    Public Const GActive As String = "ACTIVE" 'Transfer
    Public Const GDevice As String = "DEVICE" 'Transfer Device
    Public Const GPriority As String = "PRIORITY" 'Priority
    Public Const GFPoint As String = "F_POINT" 'From Point
    Public Const GTPoint As String = "T_POINT" 'To Point
    Public Const GSTGroup As String = "ST_GROUP" 'Station Group
    Public Const GSerialNo As String = "SERIAL_NO"
    Public Const GSerialTime As String = "SERIAL_TIME"
    Public Const GReasonCode As String = "REASON_CODE"
    'Global Const GNSKubun = "NSKUBUN"       '入出庫詳細區分
    Public Const GSelectedFlag As String = "SELECTEDFLAG"
    Public Const GDI As String = "DI"
    Public Const GDO As String = "DO"
    Public Const GREADDATA As String = "READ_DATA"
    'Public Const GSRCPoint As String = "SRC_POINT"
    'Public Const GDESTPoint As String = "DEST_POINT"
    Public Const GThroughPoint As String = "THROUGH_POINT"

    '*****************TR_DETAIL***********************
    Public Const GRecvQty As String = "RECV_QTY"
    Public Const GExpiryDate As String = "EXPIRY_DATE"
    Public Const GSelfStat As String = "SELF_STAT"
    Public Const GErrStat As String = "ERR_STAT"
    Public Const GTimeStamp As String = "TIME_STAMP"
    Public Const GPgmNo As String = "PGM_NO"
    Public Const GNsDivision As String = "NSDIVISION"

    '***************** Bapi ***********************
    Public Const GDocDate As String = "DOCUMENT_DATE"
    Public Const GPostDate As String = "POSTING_DATE"
    Public Const GInvoiceNo As String = "INVOICE_NO"
    Public Const GINNo As String = "IN_NO"
    Public Const GBatchNo As String = "BATCH_NO"
    Public Const GGRDocNo As String = "GR_DOC_NO"
    Public Const GGRDocYear As String = "GR_DOC_YEAR"
    Public Const GEntryQty As String = "ENTRY_QTY"
    Public Const GErrDesc As String = "ERR_DESC"

    '***************** PARAMATER ***********************
    Public Const GResvTimeup1 As String = "RESV_TIMEUP1"
    Public Const GResvTimeup2 As String = "RESV_TIMEUP2"
    Public Const GResvTimeup3 As String = "RESV_TIMEUP3"
    Public Const GBeginStoreOut1 As String = "BEGINNING_STOREOUT1"
    Public Const GBeginStoreOut2 As String = "BEGINNING_STOREOUT2"
    Public Const GBeginStoreOut3 As String = "BEGINNING_STOREOUT3"
    Public Const GBeginShipment1 As String = "BEGINNING_SHIPMENT1"
    Public Const GBeginShipment2 As String = "BEGINNING_SHIPMENT2"
    Public Const GBeginShipment3 As String = "BEGINNING_SHIPMENT3"
    Public Const GHistoryLifeDates As String = "HISTORY_LIFE_DATES"

    '***************** Grouping ***********************
    Public Const GBinQty As String = "BIN_QTY"

    '****************OPE_LOG*******************************
    Public Const GManage As String = "MANAGE"
    Public Const GMachineName As String = "MACHINENAME"

    '******************* Utility Define *******************
    Public Const GCountDays As String = "COUNT_DAYS"
    Public Const GHistoryDays As String = "HISTORY_DAYS"
    Public Const GMaxLocation As String = "MAX_LOCATION"

    '******************* Error Count*******************
    Public Const GHistoryDate As String = "HISTORY_DATE"

    '******************* Crane*******************
    Public Const GOneBeforeSt1 As String = "ONE_BEFORE_ST1"
    Public Const GOneBeforeSt2 As String = "ONE_BEFORE_ST2"
    Public Const GOneBeforeLocation1 As String = "ONE_BEFORE_LOCATION1"
    Public Const GOneBeforeLocation2 As String = "ONE_BEFORE_LOCATION2"
    Public Const GJustNowSt1 As String = "JUST_NOW_ST1"
    Public Const GJustNowSt2 As String = "JUST_NOW_ST2"
    Public Const GJustNowLocation1 As String = "JUST_NOW_LOCATION1"
    Public Const GJustNowLocation2 As String = "JUST_NOW_LOCATION2"

    '****************************************************
    '               SAP VIEW
    '****************************************************
    '***************** IN *******************************
    Public Const GINDate As String = "INDATE"
    Public Const GINType As String = "INTYPE"
    Public Const GBroker As String = "BROKER"
    Public Const GForwarder As String = "FORWARDER"
    Public Const GOrgPO As String = "ORGPO"
    Public Const GPOrg As String = "POrg"
    Public Const GIncharge As String = "INCHARGE"
    Public Const GItemCode As String = "ITEMCODE"
    Public Const GInvDate As String = "INV_DATE"
    Public Const GUnitPrice As String = "UNITPRICE"
    Public Const GNetPrice As String = "NETPRICE"
    Public Const GOUN As String = "OUN"
    Public Const GCurrentKey As String = "CURRENTKEY"

    '******************** MR **************************
    Public Const GMRNo As String = "MR_NO"

    '******************* Inspection *******************
    Public Const GMatDocNo As String = "MAT_DOC_NO"
    Public Const GINSDate As String = "INS_DATE" 'Inspection Release Date
    Public Const GINSTime As String = "INS_TIME" 'Inspection Release TIME

    '********************* ERR_CODE *******************
    Public Const GDeviceName As String = "DEVICE_NAME"
    Public Const GErrorID As String = "ERR_ID"
    Public Const GMethod As String = "METHOD"

    '********************* ALIVE *******************
    Public Const GLocal As String = "LOCAL"
    Public Const GLastDT As String = "LASTDATETIME"
    Public Const GEndFlag As String = "ENDFLAG"
    Public Const GData As String = "DATA"
    Public Const GPID As String = "PID"
    Public Const GControlName As String = "CONTROLNAME"
    Public Const GPstatus As String = "PSTATUS"
    Public Const GStartDT As String = "STARTDATETIME"
    Public Const GAutoStartFlag As String = "AUTOSTARTFLAG"

    '********************Error Table*******************************'
    Public Const GErrId As String = "ERR_ID"
    Public Const GCT2 As String = "CT2"
    Public Const GEmail As String = "E_MAIL"
    Public Const GOccurDate As String = "OCCUR_DATE"
    Public Const GEndDate As String = "END_DATE"
    Public Const GSuggestion As String = "SUGGESTION"

    '
    Public Const GPLCNo As String = "PLCNO"
    Public Const GPortNo As String = "PORTNO"
    Public Const GSetting As String = "SETTING"
    Public Const GBaudrate As String = "BAUDRATE"
    Public Const GParity As String = "PARITY"
    Public Const GDatabits As String = "DATABITS"
    Public Const GStopBits As String = "STOPBITS"
    Public Const GDebugFlag As String = "DEBUGFLAG"

    Public Const GPickingQty As String = "PICKING_QTY"
    Public Const GQuant As String = "QUANT"
    Public Const GCYLINDERNO As String = "CYLINDER_NO"
    Public Const GQuantity As String = "QUANTITY"
    Public Const GSumQty As String = "SUM_QTY"
    'Public Const GDocNumber As String = "DOCNUMBER"

    Public Const GErrTime As String = "ERR_TIME"
    Public Const GRecoveryTime As String = "RECOVERY_TIME"

    'Web Service Use
    Public Const GSTtype As String = "STType"
    Public Const GSysAccount As String = "SYSACCOUNT"
    Public Const GWHCode As String = "WHCODE" '20190723
    Public Const GTOCreate As String = "TOCREATE" '20190723
    Public Const GToNumber As String = "TONUMBER"
    Public Const GToItem As String = "TOITEM"
    Public Const GMaterialNumber As String = "MaterialNumber"
    Public Const GDocType As String = "DOCTYPE"
    Public Const GDocnumber As String = "DOCNUMBER"
    Public Const GReQuestType As String = "REQUESTTYPE"
    Public Const GReQuestAction As String = "REQUESTACTION"
    Public Const GStockKeep As String = "STOCKKEEP"
    Public Const GReturnCode As String = "RETURNCODE"
    Public Const GReturnMessage As String = "RETURNMESSAGE"
    Public Const GMessageSequenCYID As String = "MESSAGESEQUENCYID"
    Public Const GVendorName As String = "VENDORNAME"
    Public Const GCostCenter_H As String = "COSTCENTER"
    Public Const GReceivePlant As String = "RECEIVEPLANT"
    Public Const GReceiveSLocation As String = "RECEIVESLOCATION"
    Public Const GReceiveUser As String = "RECEIVEUSER"
    Public Const GMaterialGroup As String = "MATERIALGROUP"
    Public Const GRatio As String = "RATIO"
    Public Const GStatus As String = "STATUS"
    Public Const GPTSMaterialFlag As String = "PTSMATERIALFLAG"
    Public Const GMaterialCheckNo As String = "MATERIALCHECKNO"
    Public Const GStorageBin As String = "STORAGEBIN"
    Public Const GBatch As String = "BATCH"
    Public Const GWareHouseCode As String = "WAREHOUSECODE"
    Public Const GUnitOfMensure As String = "UNITOFMENSURE"
    Public Const GStorageSection_H As String = "STORAGESECTION"
    Public Const GRecipient As String = "RECIPIENT"
    Public Const GReceiveStorageLocation As String = "RECEIVESTORAGELOCATION"
    Public Const GToCreateDateTime As String = "TOCREATEDATETIME"
    Public Const GStorageLocation_H As String = "STORAGELOCATION"
    Public Const GStockType_H As String = "STOCKTYPE"
    Public Const GSpecialStock As String = "SPECIALSTOCK"
    Public Const GCounter As String = "COUNTER"
    Public Const GBarcodeNo As String = "BARCODE_NO"
    Public Const GDataDesc As String = "DATA_DESC"
    Public Const GUserGroup As String = "USERGROUP"
    Public Const GIndexNo As String = "INDEXNO"
    Public Const GItemNo As String = "ITEMNO"
    Public Const GForksuu As String = "FORKSUU"
    Public Const GMachine_Name As String = "MACHINE_NAME"
    Public Const GReal_QTY As String = "Real_QTY"

    '********************* AGV_LOG********************************* '20191017
    Public Const GFunction As String = "FUNCTION"
    Public Const GPtsBarcode As String = "PTS_BARCODE"
    Public Const GAgvBoxNo As String = "AGVBOXNO"
    Public Const GMovementType As String = "MOVEMENTTYPE"
    Public Const GDestination As String = "DESTINATION"
    Public Const GDeliveryTime As String = "DELIVERYTIME"

    '********************* CTL_ST_SCH****************************** '20191021
    Public Const GStno As String = "STNO"
    Public Const GPgmDesc As String = "PGM_DESC"
    Public Const GStstem As String = "SYSTEM"

    'Tally SSS Use
    Public Const GMaterialDoc As String = "MATERIALDOC"
    Public Const GMRNO_H As String = "MRNO"

    '**************** Logistics ymwms001***************************
    Public Const GPackage As String = "PACKAGE"
    Public Const GAction As String = "ACTION"
    Public Const GReafNumber As String = "REAFNUMBER"
    Public Const GInNumber As String = "INNUMBER"



    Public Const GReQuestorID As String = "REQUESTORID"


    '**************** Logistics ymwms002***************************
    Public Const GReceivingPlant As String = "RECEIVINGPLANT"
    Public Const GVendorCode_H As String = "VENDORCODE"
    Public Const GGRPost As String = "GRPOST"
    Public Const GGRTime As String = "GRTIME"

    '**************** Logistics ymwms003***************************
    Public Const GDocItem As String = "DOCITEM"
    Public Const GMaterialDesc As String = "MATERIALDESC"
    Public Const GPONumber As String = "PONUMBER"
    Public Const GPOItem_H As String = "POITEM"
    Public Const GUNITOFMEASURE As String = "UNITOFMEASURE"
    Public Const GUNIT As String = "UNIT"
    Public Const GSLocation_H As String = "SLOCATION"
    Public Const GSSection As String = "SSECTION"
    Public Const GExpirationDate_H As String = "EXPIRATIONDATE"
    Public Const GScheno As String = "SCHENO"
    Public Const GAutoGI As String = "AUTOGI"
    Public Const GMRRequester As String = "MRREQUESTER"
    Public Const GMRTelnr As String = "MRTELNR"     'MR TEL No
    Public Const GMRBADAT As String = "MRBADAT"
    Public Const GMRKOSTL As String = "MRKOSTL"
    Public Const GMRDEPT As String = "MRDEPT"
    Public Const GMRURFLAG As String = "MRURFLAG"
    Public Const GMRCDFLAG As String = "MRCDFLAG"
    Public Const GINXXCODE As String = "INXXCODE"
    Public Const GPQFLAG As String = "PQFLAG"
    Public Const GPQSYSTEM As String = "PQSYSTEM"
    Public Const GPQRESULT As String = "PQRESULT"
    Public Const GPTSFlag As String = "PTSFLAG"
    Public Const GCHECKNO As String = "CHECKNO"

    '20170124 新增
    Public Const GMRDSPDATE As String = "MRDSPDATE"
    Public Const GMRDSPTIME As String = "MRDSPTIME"
    Public Const GMRDSPDEST As String = "MRDSPDEST"
    Public Const GMRCODFLAG As String = "MRCODFLAG"
    Public Const GMREARLY As String = "MREARLY"

    Public Const GSAPPLANT As String = "SAPPLANT"
    Public Const GSAPLOCATION As String = "SAPLOCATION"

    '20210126 For Hybox staion mode
    Public Const GValue As String = "VALUE"




    Public Function ReadINI(ByVal strIniFile As String, ByVal strSection As String) As String
        Dim strFName As String = System.Reflection.MethodBase.GetCurrentMethod.Name

        Try


            If Not System.IO.File.Exists(strIniFile) Then
                Return "檔案 " & strIniFile & " 不存在，請確認路徑或檔案名稱是否正確。"
                Return False
            End If

            Dim objINIRead As New System.IO.StreamReader(strIniFile)
            Dim strTheINI As String = objINIRead.ReadToEnd

            Dim i As Integer
            Dim intLine As Integer
            Dim blnNoSection As Boolean = False
            Dim strGetValue As String = ""
            Dim strLineStream As Object

            strLineStream = strTheINI.Split(Chr(13))
            intLine = UBound(strLineStream)

            For i = 0 To intLine
                If strLineStream(i).indexof("=") > 0 Then
                    If strLineStream(i).split("=")(0).trim() = strSection Then
                        blnNoSection = True
                        strGetValue = strLineStream(i).split("=")(1).trim()
                        Exit For
                    End If
                End If
            Next i

            objINIRead.Close()

            If blnNoSection = True Then
                Return strGetValue
            Else
                Return "無指定 " & strSection & " 之值。"
            End If

        Catch ex As Exception
            logger.Error(ex, ex.Message)
            Return "Catch"
        End Try
    End Function


    Public Function GetConfigString(key As String) As String

        Dim InitFileMap As ExeConfigurationFileMap
        Dim Init As System.Configuration.Configuration
        Dim InitKeyValue As KeyValueConfigurationElement

        InitFileMap = New ExeConfigurationFileMap
        InitFileMap.ExeConfigFilename = "C:\Muratec\app.config" 'FNC.PUCDbConfigFile
        Init = ConfigurationManager.OpenMappedExeConfiguration(InitFileMap, ConfigurationUserLevel.None)

        InitKeyValue = Init.AppSettings.Settings(key)
        Return InitKeyValue.Value


    End Function


    Public Function fnGetConnectString() As String
        Dim lonRetErr As Integer
        Dim booRet As Boolean
        Dim account As TSMCBASE64.Account
        Dim strFName As String = System.Reflection.MethodBase.GetCurrentMethod.Name

        Try
            ''SQL.strPlantKey = "F18P4Wafer"

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

            '/*
            '/*     NLOG Info
            '/*
            'Try
            '    NLog.LogManager.Configuration.Variables.Item("dbConnHost") = account.HostIp
            '    NLog.LogManager.Configuration.Variables.Item("dbConnServiceName") = account.ServiceName
            '    NLog.LogManager.Configuration.Variables.Item("dbConnUserID") = account.UsrID
            '    NLog.LogManager.Configuration.Variables.Item("dbConnPassword") = account.Pass
            'Catch ex As Exception

            'End Try



            Return "Data Source=(DESCRIPTION =(ADDRESS_LIST =(ADDRESS = (PROTOCOL = TCP)(HOST =" & account.HostIp &
                 ")(PORT = 1521)))(CONNECT_DATA =(SERVER=DEDICATED)(SERVICE_NAME = " & account.ServiceName & " )));" &
                 "User ID=" & account.UsrID & " ;Password= " & account.Pass

        Catch ex As Exception
            logger.Error(ex, ex.Message)
            Return " "
        End Try

        Return True
    End Function



    ''' <summary>
    ''' 設定NLog變數資訊,必須先Call Def.VB
    ''' </summary>
    ''' <param name="strArgument"></param>
    ''' <param name="strDeviceType"></param>
    ''' <param name="strDeviceId"></param>
    Public Sub SetLogInfo(ByRef strLogPath As String, strArgument As String, strDeviceType As String, strDeviceId As String)
        Try
            'NLog.config內定義的變數
            NLog.LogManager.Configuration.Variables.Item("mylogdir") = strLogPath
            NLog.LogManager.Configuration.Variables.Item("myargument") = strArgument
            NLog.LogManager.Configuration.Variables.Item("mydevicetype") = strDeviceType
            NLog.LogManager.Configuration.Variables.Item("mydeviceid") = strDeviceId

        Catch ex As Exception
            Call Threading.Thread.Sleep(1)
        End Try
    End Sub

    Public Function fnGetConnectStringSAP() As String
        Dim lonRetErr As Integer
        Dim booRet As Boolean
        Dim account As TSMCBASE64.Account
        Dim strFName As String = System.Reflection.MethodBase.GetCurrentMethod.Name

        Dim strFileName As String = GSystemPath & "Account.INI"

        Try
            'Use Base64 Account Information
            booRet = TSMCBASE64.B64FileRead("P01", strFileName, account, lonRetErr)
            If booRet = False Then

                'Dim strFileName As String = GSystemPath & "SAP.INI"
                Dim strDataSource As String = ReadINI(strFileName, "DsSvrnm")
                Dim strUserName As String = ReadINI(strFileName, "UsrID")
                Dim strPassword As String = ReadINI(strFileName, "Pass")
                Dim strHost As String = ReadINI(strFileName, "SIP")
                Dim strServiceName As String = ReadINI(strFileName, "SID")

                Return "Data Source=(DESCRIPTION =(ADDRESS_LIST =(ADDRESS = (PROTOCOL = TCP)(HOST =" & strHost &
                 ")(PORT = 1521)))(CONNECT_DATA =(SERVER=DEDICATED)(SERVICE_NAME = " & strServiceName & " )));" &
                 "User ID=" & strUserName & " ;Password= " & strPassword
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


    Public Enum MsgNo
        'F12P1
        'CSystemOnline = 102 'Available in online mode only.
        'CDataNull = 130 'No data entered.
        CInvalidComputerName = 1 '電腦名稱不正確
        CNgComplete = 2 'Operation incomplete.    處理失敗
        CClose = 3 '確定要關閉程式嗎?
        CNotNormalData = 4 'Invalid data.  資料不正確
        CSetComplete = 5 'Operation successfully completed. 設定完成
        CSelectFunctionKey = 6 'Select Function Key.    請選擇功能鍵
        CDataNotFound = 7 'No corresponding data found.   找不到資料
        CAlreadyData = 8 'Duplicate data. 資料已存在
        CDispComplete = 9 'Data has been displayed successfully.    顯示完成
        CSetCompleteTime = 10 'Under processing, please wait.    處理中, 請稍候.....
        CSelectData = 11 'Please select data.   未勾選資料
        CPrintend = 12 'Print completed.    列印完成
        CSystemOnline = 13 'Available in online mode only. 請把系統模式切換為Online
        CSystemOffline = 14 'Available in offline mode only.   請把系統模式切換為Offline
        CCraneDisable = 15 'The corresponding crane is disabled.   Crane禁止中
        CInvalidPassword = 16 'Invalid password.   密碼不正確
        CASRSLotout = 17 '確定要登出AS/RS System嗎?
        CInvalidNewPassword = 18 '新密碼與確認密碼不一致
        CInputUser = 19 '請輸入使用者
        CInputPassword = 20 '請輸入密碼
        CSaveComplete = 21 '存檔完成
        CNotLoad = 22 'No load on station. 沒有載荷
        CDataNull = 23 'No data entered.   這個欄位不可省略
        CClearCount = 24    '確定要清除稼動次數及重新計算庫位數嗎?
        CSocketError = 25  'Socket連接失敗
        CPortOpenError = 26    'Open Port失敗
        CResetPort = 27 '確定要Reset Port嗎?
        CNoCommandLineArgument = 28 '無命令列引數!
        CCommandLineArgumentError = 29  '命令列引數個數錯誤!
        CInvalidCommandLineArgument = 30 '命令列引數不是數字!
        CStartOperation = 31  'Start Operation  開始作業.....
        CEndOperation = 32 'End Operation   .....結束作業
        CPLCReceiveDataError = 33    'Receive Data Error    接收到的資料錯誤!
        CReadSpreadError = 34    '讀取Spread表格失敗!
        CReLogin = 35    '設定完成, 請關閉程式後重新登入讓設定值生效!
        CInvalidLocation = 36 'Invalid location No.    庫位編號不正確
        CNoEmptyLocation = 37 'No empty location.  沒有空庫位
        CNotEmptyLocation = 38 'Specify empty location. 請指定空庫位
        CNotZaikoLocation = 39 'Specify occupied location.  請指定在庫庫位
        CPalletNotInST = 40 '此容器{0}無法移轉此站別{1}
        CAlreadyChangeZone = 41 '品號Zone已變更, 請重新設定
        CAlreadyChangeMaterialName = 42 '品號品名已變更, 請重新設定
        CPLCBlockError = 43 'Block不是自動
        CPLCVehicleError = 44 '台車未到正確位置
        CPLCStoreINOUTModeError = 45 '入出庫模式不正確
        CPalletDataInStock = 46 '此容器已有庫存
        CPalletDataInTransfer = 47 '此容器已有搬送資料
        CNotEnoughZoneLocation = 48 'Zone庫位不足
        CPointMultipleDataForbid = 49 '單一Point不可建立多筆入庫預約資料
        CPLCRouteError = 51 '搬送路徑Block不是自動
        CCantBeTheSameStation = 50 '起始站別與目的站別不可相同
        CPLCNotSizeCheck = 52 '無SizeCheck
        CPLCSizeNG = 53 'SizeCheck NG
        CPLCLoadHighLowError = 54 '高低荷異常
        CPLCLoadHighNotStoreIn = 55 '高荷無法入庫
        CPLCNotLoadHighLow = 56 '無高低荷
        CPLCConfirmButtonError = 57 '等待按下入出庫確認鈕
        CNotEnoughZaiko = 58 '庫存不足
        CInvalidInpute = 59 '輸入值不正確
        CPLCInOutSetError = 60 '入出庫可訊號不正確
        CPLCInOutTypeError = 61 '入出庫區分不正確
        CLoad = 62 '有載荷
        CAlreadyChangeData = 63 '資料已變更，請重新查詢
        CPLCExeScreenNameS03 = 64 '請先執行撿料入庫設定
        CBarcodeError = 65 '條碼異常
        CPLCNotSerial = 66 '序號不正確
        CPortCloseError = 67 'Close Port失敗
        CCraneSentDataError = 68 '不能向Crane發送資料
        CNormalEnd = 69 'Process has been ended normally.    正常處理結束
        CCraneWaiting = 70 'Crane待機中
        CCraneOffline = 71 'Crane離線中
        CCraneBusy = 72 'Crane運行中
        CCraneError = 73 'Crane狀態異常
        CCraneHaveTransfer = 74 '有搬送資料
        CCraneDataSend = 75 '已向Crane發送資料
        CCraneUpdateError = 76 '不能更新入出庫資料
        CCraneInit = 77 '確定要初始化嗎?
        CDataNothing = 78 'No data. 沒有入出庫資料
        CAutoRecoveryOccupied = 79 '先入品自動復歸中
        CNotAllowedEmptyPallet = 80 '不允許空容器
        CSelectSpread = 81 '請雙擊表單，指定變更的資料
        CNotEmptyPallet = 82 '請指定空容器
        CNotStockPallet = 83 '請指定實容器
        CLocMatZoneDifferent = 84 '品號Zone類型與庫位Zone類型不同
        CCraneWaitingHome = 85 'Crane原點等待
        CEptStkPalletDifferent = 86 '空容器與實容器不可混載
        CZaikoMaster = 87 '不可修改或刪除已存在於庫存或搬送資料的品號主檔
        CCustCodeMix = 88 '同一筆資料不可建立多筆客戶代碼
        CPLCExeScreenNameS04 = 89 '請先執行盤點入庫設定
        CDestnPLCBlockError = 90 '目的位置Block不是自動
        CInZaikoLocation = 91 '在庫庫位不可移轉
        CDestnHaveTransfer = 92 '目的地有搬送資料
        CDestnStartTransfer = 93 '起始站有搬送資料
        CDestnPLCStoreINOUTModeError = 94 '目的地台車入出庫模式不正確
        CDestnPLCInOutSetError = 95 '目的地台車入出庫可訊號不正確
        CBridgeHaveData = 96 '連結點台車已有其它資料預約動作
        CBridgePLCBlockError = 97 '連結點台車Block不是自動
        CBridgeLoad = 98 '連結點台車有載荷
        CBridgeHaveTransfer = 99 '連結點台車有搬送資料
        CBridgePLCVehicleError = 100 '連結點台車未到正確位置
        CBridgePLCStoreINOUTModeError = 101 '連結點台車入出庫模式不正確
        CBridgePLCInOutSetError = 102 '連結點台車入出庫可訊號不正確
        CTrayDataInStock = 103 '此容器已有庫存
        CBinNoDuplicate = 104 'BinNo不可重複
        CZeroOutQty = 105 '出庫數量不可為0
        CSTNotEnoughZaiko = 106 '所選擇站號庫存數不足
        COverOrderQty = 107 '輸入數量超過需求數量
        CAlreadyLocation = 108 '已有預約庫位
        CErrorStationSelect = 109 '請選擇此容器原出庫站號
        CWrongLowHighLocation = 110 '高低庫位不正確
        CMaterialNo = 111 '品號主檔裡沒有此品號
        CZeroInQty = 112 '入庫數量不可為0
        CNewPassWordSameOrigin = 113 '新密碼不可和舊密碼一樣
        CTimeOut = 114 '通訊逾時異常
        COrderLocationOutError = 115 '此單別是入庫單
        COrderLocationInError = 116 '此單別是出庫單
        CAssignOverKeyIn = 117 '指定出庫總數超過出庫數量
        CMaxlen = 126 '長度過長
        CWaferError = 127 '不同Wafer不可混載
        CRequestInsert = 148 'Please enter data. 請輸入正確資料
        CCancel = 149 'Process has been canceled.  處理已被取消
        CPermissionErr = 150 'Permission Error'權限不足，請洽系統管理者
        CMaxofData = 151 'Exceed maximun number of data. 您所輸入的值超過最大值
        CStationDisable = 152 'The corresponding station is disabled.
        CRequestUpdate = 153 'Please modify data.
        CLocNoDelete = 154 '此庫位不可新增刪除
        CDeleteCheck = 155 '此動作會連庫存及其相關連資料一起刪除
        CCheckMatNo = 156 '品號要一樣,不可不相同
        CCNotDisplayNo = 157 '已有作業，等待作業完成，再繼續進行
        CDataInStock = 159 '庫存已有資料
        CNoResvQty = 172 '出庫預約數量=0，不可取出
        CHaveResvQty = 173 '出庫預約數量<>0，請將物品取出再執行
        CNoMatAndRemark = 174 '料號和備註不可同時空白
        CNoThisMatInPallet = 175 '容器內沒有此筆資料，無法取出
        COutQtyError = 176 '取出數量不正確
        COverStockQty = 177 '超出庫存數量

        '20191007  1開頭:查詢,維護 2開頭:入庫,出庫 3開頭:DLG,MDIMain,FNC,CRT 4開頭:PTS 5開頭:Display
        CNoPalletNo = 118 '找不到容器
        COnlyPAandWaitCanChange = 1032 '只有PA單且為等待狀態才可以更換容器!!
        COnlyPKCanRebalance = 1033 '只有PK單可以重新對帳!!
        CInventoryCannotCancle = 1034 '盤點單不可取消!!
        CNoDatafile = 1001 '無資料檔
        CNoPictureFile = 1002 '此筆資料,無圖檔
        CNoDetailFile = 1003 '此筆資料,無明細檔
        CAtleastOneCondition = 1004 '請至少輸入一查詢條件
        CNoDeviceNo = 1005 '查無此設備編號
        CPalletDataHasChanged = 1006 '容器 :{0}資料已變更請重新查詢
        CLocationUpdateError = 1007 '庫位: {0} 更新失敗
        CPalletNotSix = 1008 '請輸入六位數之容器號碼
        CAlreadyWaferNoEmpty = 1009 '此容器已有Wafer 不可變更為空容器 請先刪除STOCK資料再新增
        CRightBinNo = 1010 '請輸入正確Bin No  注意:同一容器不可輸入相同Bin No
        CEnterBinNo = 1011 '請輸入格位
        CEnterStockQty = 1012 '請輸入庫存數量	
        CEnterResvQty = 1013 '請輸入預約數量
        CEnterPickingQty = 1014 '請輸入檢料數量
        CEnterGroupQty = 1015 '請輸入Group Qty
        CEnterStorageQty = 1016 '請輸入庫預約數量
        CNoTrayNo = 1017 '容器主檔無容器號碼: {0}
        CPalletAlreadyInLoc = 1018 '此容器: {0} 已在其它庫位: {1}
        CNotFindLoc = 1019 '查無此庫位號碼
        CNoVendorNo = 1020 '查無此廠商編號
        CRightRange = 1021 '請輸入正確範圍
        COutRange = 1022 '超出範圍
        CNotRetrieveNoModify = 1023 '非出庫預約資料 不可使用修改功能
        CNotRightPalletNo = 1024 '容器號碼不正確
        CPalletStatusChanged = 1025 '畫面上欲刪除之容器狀態已有變更 請按[F5]重新查詢後再執行
        CNoStationNo = 1026 '查無站號主檔
        CNoReason = 1027 '理由不可為空白！
        CEnterBigTray = 1028 '請輸入大容器{0} 
        CAlreadyWrongTransfer = 1029 '已有錯誤Transfer Data
        CNoMaterialNo = 1030 '查無料號主檔
        CGetSAPStockErr = 1031 '無法取得 SAP 庫存,請通知系統人員…


        CNotEmployee = 2001 '可疑的登入者，請確認
        CNoSuitableTray = 2002 '沒有合適的容器，請重新輸入數量
        CReChooseStation = 2003 '請重新新選擇站別
        CMustStation = 2004 '站別不可省略
        CPtsBarcodeQtyErr = 2005 'PTS 條碼數量不正確
        CManualGroupingOnebyone = 2006 '錯誤!手動Grouping，資料只能勾選一筆
        CRightBarcodePicking = 2007 '請掃瞄正確條碼，且撿料數量不可為0
        CGroupingErrRetry = 2008 '配送資料異常，請再次輸入
        CScanPickingBarcode = 2009 '請掃瞄撿料之料號條碼
        CStorageEmptyTray = 2010 '請用空容器入庫
        CStockCheckReturn = 2011 '請用盤點再入庫，設定入庫
        CInspectionReturnSetting = 2012 '請用檢驗再入庫，設定入庫
        CPalletUnPacking = 2013 '尚有{0}的容器尚未撿料
        CScanMatNo = 2014 '請先刷取料號
        CQtyNotEnough = 2015 '數量不足
        CNoInspector = 2016 '沒有領料人
        CNoCostcenter = 2017 '沒有填成本中心
        CPalletCannotTransfer = 2018 '無法使用此容器配送
        CCannotGetSTType = 2019 '取得站別型態失敗 請重新執行
        CMustSameInspector = 2020 '必須同一領料人才可以放同容器
        CSelectStatus = 2021 '請選擇狀態
        CReselect = 2022 '請重新選擇
        CWrongTrayOrLocation = 2023 '輸入的容器或儲位有誤
        CRightHyboxBarcode = 2024 '請輸入正確HyBox條碼
        CRightHyboxPalletBarcode = 2025 '請輸入正確鐵棧板條碼!!!
        CHyboxPalletBound = 2026 '此棧板已有綁定!!!!
        COutOfQTY = 2027 '請確認是否已超過數量{0}
        CPalletCannotStorage = 2028 '容器不能做入庫設定
        CStorageQtyMoreThanSAP = 2029 '入庫總量大於sap單據數量!!
        CHyboxHasStock = 2030 '此HYBOX已有庫存!!!
        CNoDataNoScanPTS = 2031 '無資料,無需掃瞄PTS條碼
        CDifferentTypeRestore = 2032 'TYPE不一致, 請重新收貨
        CDifferentMatNoRestore = 2033 '料號不一致, 請重新收貨
        CDifferentBatchNoRestore = 2034 '批號不一致, 請重新收貨
        CPalletHasStock = 2035 '此容器已有庫存
        COverPalletMaximum = 2036 '勾選數量超過容器最大容納數
        CTwoWaferDifferentMatNo = 2037 '兩筆Wafer料號不同，請確認
        CNoSelectCapa = 2038 '因入庫後剩餘空間未選而無法執行，請選擇後重新執行
        CMaintenanceProductCostcenter = 2039 '請輸入維修品部門，不可以是NA
        CUseEmptyStore = 2040 '用「空容器入庫」畫面做設定
        CGetPalletErr = 2041 '取得容器資訊失敗
        CStationErr = 2042 '站別錯誤請重新輸入
        CLocationAndEnter = 2043 '請輸入庫位編號,並按下Enter
        CASRAComputerErr = 2044 '禁止於此電腦執行ASRS庫位
        CMatNoEnter = 2045 '請先輸入料號
        CVendorNameEnter = 2046 '廠商代碼不可省略
        CRemarkEnter = 2047 '備註不可省略
        CEnterQty = 2048 '數量未填寫！
        CMatNoOrMatName = 2049 '料號省略的話，品名不可省略
        CEnterDataErrColAndRow = 2050 '請確認輸入資料是否有誤 , Col ={0} , Row ={1}
        CHyboxPalletNoStToSt = 2051 '此鐵棧板不能站對站
        CPalletIsErrTray = 2052 '{0}此容器為異常容器
        CEnterSmallTray = 2053 '請輸入小容器{0}
        CTrayCannotTransfer = 2054 '容器無法移轉
        CBigTraySmaller = 2055 '大容器{0}不可放在小容器{1}
        CTrayLengthWrong = 2056 '容器 : {0} 長度不對
        CPalletWrong = 2057 '{0} 容器不對 ; 請重新輸入
        CWrongValue = 2058 '{0} 輸入值不正確
        CEnterHiroLoc = 2059 '請輸入平置倉庫位編號
        CHiroLocNoTray = 2060 '該平置倉內無容器，請指定容器
        CHiroLocPluralTrays = 2061 '該平置倉內有複數容器，請指定容器
        CChangeHiroLocToTray = 2062 '已轉換為平置倉內之容器
        CNoPalletOrHiroLoc = 2063 '查無此容器或平置倉庫位
        CPTSCodeRepeat = 2064 'PTS條碼重複輸入
        CErrFosbId = 2065 'Fosb ID 錯誤
        CFosbIdRepeat = 2066 'Fosb ID 重複
        CAlreadySpreadData = 2067 'Spread已有此筆資料
        CSpreadVendorDifferent = 2068 '此筆資料廠商與目前所選廠商不相同，請確認
        CUseBcrStartWith6 = 2069 '此單中有單位非25片的資料，請刷6開頭之條碼

        CMainStatusErr = 3001 '主狀態不對 :{0}
        CExecutestStatusErr = 3002 'Executest狀態不對 :{0}
        CNoTransfer = 3003 '已無搬送資料
        CChooseAgvDevice = 3004 '請先選擇AGV台車
        CLocProhibitDataErr = 3005 '庫位禁止資料錯誤
        CCannotGetUserInfo = 3006 '無法連線取得使用者資訊,請連絡系統相關人員
        CCannotGetDB = 3007 '資料庫無法讀取,請連絡系統相關人員
        CAccountLocked = 3008 '目前帳號已被鎖定，請聯絡庫房人員解鎖
        CNoAccount = 3009 '無此帳號,請連絡系統相關人員
        CSumNotEqualResv = 3010 '總數與預約數量不合
        CResvQtyWrong = 3011 '預約出庫數量不對，請再確認！
        CDifferentStationType = 3012 '{0} 與前一個站別 {1}的{2}不一致
        CBarcodeAlreadyInDB = 3013 '此條碼已存在於DB,請確認是否重覆刷
        CModifyErr = 3014 '修改異常,請聯絡系統管理者
        CQtyNotEqualGrouping = 3015 '數量與Grouping Table 不符,請聯絡系統管理者
        CPtsBarcodeErr = 3016 'PTS 條碼有問題
        CSelectNotifyPerson = 3017 '請勾選通知人員
        CEnterPtsBarcode = 3018 '請輸入PTS 條碼!!!
        CCannotGetUserInfoWait = 3019 '無法連線取得使用者資訊,使用理貸人員系統登入....請稍待
        CLogOut = 3020 '登出系統
        CWrongCardId = 3021 '卡號有問題
        CGetPointNoArrayErr = 3022 'Point_No Array 取得失敗	
        CGetStationArrayErr = 3023 'Station Array 取得失敗
        CExpireDateForm = 3024 '到期日格式為 MM/DD/YYYY {0}
        CExpireDateOverTomorrow = 3025 '到期日必需大於明日
        CStorageDateForm = 3026 '入庫日期格式為 MM/DD/YYYY HH:MM : SS {0}


        CWebServiceConnectErr = 4001 'Web Service 交訊失敗,請聯絡系統相關人員
        CMRNotThisPlant = 4002 '此單據非為本廠區單據
        CMRAlreadyType = 4003 '此MR單已輸入
        CGetStationErr = 4004 '取得站別失敗
        CCostcenterDifferent = 4005 '成本中心不一致
        CCapaNoInput = 4006 '請先設定 剩餘可用空間 後再重新執行

        CStationmultipleTransfer = 5001 '此站TRANSFER多於一筆
        CNoOperationData = 5002 '無作業資料





        'F12P1_VBNET
        'CDataNotFound = 132 'No corresponding data found.
        'CAlreadyData = 133 'Duplicate data.
        CAlreadyHinbanLot = 134 'Duplicate item No. and lot.
        CRenewalData = 135 'Data already updated.
        CAvailableNyuuko = 136 'There is data exist on this station.
        CAvailableSaiNyuuko = 137 'There is data exist for Re-cahrgein.
        CAvailableSyukko = 138 'There is data exist for Retrieval.
        CNotChangeMode = 139 'There is data exist, can't change a station mode.
        'CNoEmptyLocation = 140 'No empty location.
        'CNotEmptyLocation = 141 'Specify empty location.
        'CNotZaikoLocation = 142 'Specify occupied location.
        CNotSyukkoYoyaku = 143 'Specify reserved location for retrieval.
        CNotEmptyZaikoDisable = 144 'Specify empty, occupied or disabled location.
        CKetsuLocation = 145 'This is an inhibited location.
        CAvailableData = 146 'Because there is related data exist, so the data has not bee
        CNoZaiko = 147 'No corresponding inventry data.
        'CNotEnoughZaiko = 148 'There are not enough stock in the system.
        CLocationFull = 149 'Location full.
        CCheckCraneLocal = 150 'Check the condition and status of local equipments.
        CCheckStation = 151 'Put a load properly.
        'CInvalidPassword = 152 'Invalid password.
        CEmptyPallet = 153 'Empty PALLET cannot be modified and delete.
        CEmptyPalletKonsai = 154 'No mixed palletizing available.
        CAlreadyDataComplete = 155 'Data entry is done already.
        CNyuuSyukkoTime = 156 'Under strage and retrieval processing, no setting available.
        CInvalidValue = 157 'Data is out of range.
        CInvalidStation = 158 'Invalid station No.
        ' CInvalidLocation = 159 'Invalid location No.
        CDataInvalidValue = 160 'Invalid data.
        CMaxKonsai = 161 'Exceed the standard product number.
        CInvalidEndValue = 162 'Initial value is over max value.
        CInvalidGouki = 163 'Invalid crane No.
        CInvalidNitakasa = 164 'Invalid contour check.
        CAlreadyInsert = 165 'Data already registered.
        'CNotLoad = 166 'No load on station.
        CNoSelectWork = 167 'Select process.
        CEmptyLocation = 168 'Empty location.
        CTimeInvalidValue = 169 'Invalid time.
        CCannotDataIn = 170 'Cannot enter data here.
        CErrorFull = 171 'Number of error is over the specified value by file Check.
        CSetDriveMO = 180 'Insert Magneto-Optical disk correctly.
        CSetDriveFPD = 181 'Insert floppy disk correctly.
        CDiskOverFlow = 182 'Disk full.
        CDiskWriteError = 183 'Cannot write to disk, disk may corrupt.
        CNoFormatDisk = 184 'Format disk.
        CNoZaikoTanaZaiko = 185 'No inventory data found by time specified retrieval.
        'CZaikoMaster = 186 'Cannot modify master file when inventory data exist.
        'CNotEmptyPallet = 187 'Speicfy empty pallet.
        'F12P1_VBNET
        ' CNgComplete = 200 'Operation incomplete.
        CVendorNotTheSame = 160  '請確認是否同廠商!!!
        CVendorInput = 161  '無廠商編號,請輸入廠商編號!!

        CTrnErr = 199 'Cannot Start Begin Transaction
        CSystemFileError = 201 'File error, execute File Check.
        CPrinterError = 202 'Printer error.
        CStationInquiry = 203 'Available in inquiry retrieval mode only.
        CStationProduction = 204 'Available in production retrieval mode only.
        CHostConnect = 205 'Available in Connect mode only.
        CHostDisConnect = 206 'Available in DisConnect mode only.
        CSQLConnect = 207 'SQLConnect
        CTimeOver = 208 'TimeOver
        CUnitTypeNG = 211                         '此容器類型無法於此站入庫
        CLocDisable = 212                         '您所指定的庫位為禁止庫位
        CSelectEmptyPallet = 213                  '請指定空容器
        CASRSLocation = 214                       '此為自動倉庫位，請重新輸入
        CNGTransfer = 215                         '容器正在移動中....請稍後處理


        CNgSelectType = 401                       'PPAP 出庫請選擇單一Type

        'F12P1.VB6轉.NET新增===================================================

        'CNoCommandLineArgument = 216 '無命令列引數!
        'CCommandLineArgumentError = 217  '命令列引數個數錯誤!
        'CInvalidCommandLineArgument = 218 '命令列引數不是數字!
        'CClose = 219 '確定要關閉程式嗎?
        'CPortCloseError = 220 'Close Port失敗
        'CPortOpenError = 221    'Open Port失敗
        'CResetPort = 222 '確定要Reset Port嗎?.
        'CStartOperation = 223  'Start Operation  開始作業....
        'CEndOperation = 224 'End Operation   .....結束作業
        ConReConnectDBSuccess = 225 '重新連結資料庫成功
        ConReConnectDBError = 226 '重新連結資料庫失敗
        'F12P1.VB6轉.NET新增===================================================
        ' CReadSpreadError = 227    '讀取Spread表格失敗!

        CUnitTypeError = 228
        CVenderErr = 229                         '廠商名稱不可為空白
        CBarCodeErr = 230                         '請輸入條碼
        CTrayNoErr = 231                         '無此容器號碼
        '0981101 BY 邑遠洲


        CWebServiceRequestStop = 9992
        CSpecialError = 999

    End Enum

End Module
