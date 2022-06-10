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
    Public GHostTestMode As Integer = 0 '0:�Ͳ����� 
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
    Public GHostTestMode As Integer = 1 '0:TEST���� 
    Public GHostASKMR As Integer = 11

    Public GSystemPath As String = "C:\MURATEC\"
    Public GTestMode As Boolean = True
    Public GDefPointFlag As Boolean = False

#End If

    '�޼ƶ}�e����
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

    '------------20211223�s�W-----------------------
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
    'Global Const GNSKubun = "NSKUBUN"       '�J�X�w�ԲӰϤ�
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

    '20170124 �s�W
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
                Return "�ɮ� " & strIniFile & " ���s�b�A�нT�{���|���ɮצW�٬O�_���T�C"
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
                Return "�L���w " & strSection & " ���ȡC"
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
    ''' �]�wNLog�ܼƸ�T,������Call Def.VB
    ''' </summary>
    ''' <param name="strArgument"></param>
    ''' <param name="strDeviceType"></param>
    ''' <param name="strDeviceId"></param>
    Public Sub SetLogInfo(ByRef strLogPath As String, strArgument As String, strDeviceType As String, strDeviceId As String)
        Try
            'NLog.config���w�q���ܼ�
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
        CInvalidComputerName = 1 '�q���W�٤����T
        CNgComplete = 2 'Operation incomplete.    �B�z����
        CClose = 3 '�T�w�n�����{����?
        CNotNormalData = 4 'Invalid data.  ��Ƥ����T
        CSetComplete = 5 'Operation successfully completed. �]�w����
        CSelectFunctionKey = 6 'Select Function Key.    �п�ܥ\����
        CDataNotFound = 7 'No corresponding data found.   �䤣����
        CAlreadyData = 8 'Duplicate data. ��Ƥw�s�b
        CDispComplete = 9 'Data has been displayed successfully.    ��ܧ���
        CSetCompleteTime = 10 'Under processing, please wait.    �B�z��, �еy��.....
        CSelectData = 11 'Please select data.   ���Ŀ���
        CPrintend = 12 'Print completed.    �C�L����
        CSystemOnline = 13 'Available in online mode only. �Ч�t�μҦ�������Online
        CSystemOffline = 14 'Available in offline mode only.   �Ч�t�μҦ�������Offline
        CCraneDisable = 15 'The corresponding crane is disabled.   Crane�T�
        CInvalidPassword = 16 'Invalid password.   �K�X�����T
        CASRSLotout = 17 '�T�w�n�n�XAS/RS System��?
        CInvalidNewPassword = 18 '�s�K�X�P�T�{�K�X���@�P
        CInputUser = 19 '�п�J�ϥΪ�
        CInputPassword = 20 '�п�J�K�X
        CSaveComplete = 21 '�s�ɧ���
        CNotLoad = 22 'No load on station. �S������
        CDataNull = 23 'No data entered.   �o����줣�i�ٲ�
        CClearCount = 24    '�T�w�n�M���[�ʦ��Ƥέ��s�p��w��ƶ�?
        CSocketError = 25  'Socket�s������
        CPortOpenError = 26    'Open Port����
        CResetPort = 27 '�T�w�nReset Port��?
        CNoCommandLineArgument = 28 '�L�R�O�C�޼�!
        CCommandLineArgumentError = 29  '�R�O�C�޼ƭӼƿ��~!
        CInvalidCommandLineArgument = 30 '�R�O�C�޼Ƥ��O�Ʀr!
        CStartOperation = 31  'Start Operation  �}�l�@�~.....
        CEndOperation = 32 'End Operation   .....�����@�~
        CPLCReceiveDataError = 33    'Receive Data Error    �����쪺��ƿ��~!
        CReadSpreadError = 34    'Ū��Spread��楢��!
        CReLogin = 35    '�]�w����, �������{���᭫�s�n�J���]�w�ȥͮ�!
        CInvalidLocation = 36 'Invalid location No.    �w��s�������T
        CNoEmptyLocation = 37 'No empty location.  �S���Ůw��
        CNotEmptyLocation = 38 'Specify empty location. �Ы��w�Ůw��
        CNotZaikoLocation = 39 'Specify occupied location.  �Ы��w�b�w�w��
        CPalletNotInST = 40 '���e��{0}�L�k���হ���O{1}
        CAlreadyChangeZone = 41 '�~��Zone�w�ܧ�, �Э��s�]�w
        CAlreadyChangeMaterialName = 42 '�~���~�W�w�ܧ�, �Э��s�]�w
        CPLCBlockError = 43 'Block���O�۰�
        CPLCVehicleError = 44 '�x�����쥿�T��m
        CPLCStoreINOUTModeError = 45 '�J�X�w�Ҧ������T
        CPalletDataInStock = 46 '���e���w���w�s
        CPalletDataInTransfer = 47 '���e���w���h�e���
        CNotEnoughZoneLocation = 48 'Zone�w�줣��
        CPointMultipleDataForbid = 49 '��@Point���i�إߦh���J�w�w�����
        CPLCRouteError = 51 '�h�e���|Block���O�۰�
        CCantBeTheSameStation = 50 '�_�l���O�P�ت����O���i�ۦP
        CPLCNotSizeCheck = 52 '�LSizeCheck
        CPLCSizeNG = 53 'SizeCheck NG
        CPLCLoadHighLowError = 54 '���C�����`
        CPLCLoadHighNotStoreIn = 55 '�����L�k�J�w
        CPLCNotLoadHighLow = 56 '�L���C��
        CPLCConfirmButtonError = 57 '���ݫ��U�J�X�w�T�{�s
        CNotEnoughZaiko = 58 '�w�s����
        CInvalidInpute = 59 '��J�Ȥ����T
        CPLCInOutSetError = 60 '�J�X�w�i�T�������T
        CPLCInOutTypeError = 61 '�J�X�w�Ϥ������T
        CLoad = 62 '������
        CAlreadyChangeData = 63 '��Ƥw�ܧ�A�Э��s�d��
        CPLCExeScreenNameS03 = 64 '�Х�����߮ƤJ�w�]�w
        CBarcodeError = 65 '���X���`
        CPLCNotSerial = 66 '�Ǹ������T
        CPortCloseError = 67 'Close Port����
        CCraneSentDataError = 68 '����VCrane�o�e���
        CNormalEnd = 69 'Process has been ended normally.    ���`�B�z����
        CCraneWaiting = 70 'Crane�ݾ���
        CCraneOffline = 71 'Crane���u��
        CCraneBusy = 72 'Crane�B�椤
        CCraneError = 73 'Crane���A���`
        CCraneHaveTransfer = 74 '���h�e���
        CCraneDataSend = 75 '�w�VCrane�o�e���
        CCraneUpdateError = 76 '�����s�J�X�w���
        CCraneInit = 77 '�T�w�n��l�ƶ�?
        CDataNothing = 78 'No data. �S���J�X�w���
        CAutoRecoveryOccupied = 79 '���J�~�۰ʴ_�k��
        CNotAllowedEmptyPallet = 80 '�����\�Ůe��
        CSelectSpread = 81 '���������A���w�ܧ󪺸��
        CNotEmptyPallet = 82 '�Ы��w�Ůe��
        CNotStockPallet = 83 '�Ы��w��e��
        CLocMatZoneDifferent = 84 '�~��Zone�����P�w��Zone�������P
        CCraneWaitingHome = 85 'Crane���I����
        CEptStkPalletDifferent = 86 '�Ůe���P��e�����i�V��
        CZaikoMaster = 87 '���i�ק�ΧR���w�s�b��w�s�ηh�e��ƪ��~���D��
        CCustCodeMix = 88 '�P�@����Ƥ��i�إߦh���Ȥ�N�X
        CPLCExeScreenNameS04 = 89 '�Х�����L�I�J�w�]�w
        CDestnPLCBlockError = 90 '�ت���mBlock���O�۰�
        CInZaikoLocation = 91 '�b�w�w�줣�i����
        CDestnHaveTransfer = 92 '�ت��a���h�e���
        CDestnStartTransfer = 93 '�_�l�����h�e���
        CDestnPLCStoreINOUTModeError = 94 '�ت��a�x���J�X�w�Ҧ������T
        CDestnPLCInOutSetError = 95 '�ت��a�x���J�X�w�i�T�������T
        CBridgeHaveData = 96 '�s���I�x���w���䥦��ƹw���ʧ@
        CBridgePLCBlockError = 97 '�s���I�x��Block���O�۰�
        CBridgeLoad = 98 '�s���I�x��������
        CBridgeHaveTransfer = 99 '�s���I�x�����h�e���
        CBridgePLCVehicleError = 100 '�s���I�x�����쥿�T��m
        CBridgePLCStoreINOUTModeError = 101 '�s���I�x���J�X�w�Ҧ������T
        CBridgePLCInOutSetError = 102 '�s���I�x���J�X�w�i�T�������T
        CTrayDataInStock = 103 '���e���w���w�s
        CBinNoDuplicate = 104 'BinNo���i����
        CZeroOutQty = 105 '�X�w�ƶq���i��0
        CSTNotEnoughZaiko = 106 '�ҿ�ܯ����w�s�Ƥ���
        COverOrderQty = 107 '��J�ƶq�W�L�ݨD�ƶq
        CAlreadyLocation = 108 '�w���w���w��
        CErrorStationSelect = 109 '�п�ܦ��e����X�w����
        CWrongLowHighLocation = 110 '���C�w�줣���T
        CMaterialNo = 111 '�~���D�ɸ̨S�����~��
        CZeroInQty = 112 '�J�w�ƶq���i��0
        CNewPassWordSameOrigin = 113 '�s�K�X���i�M�±K�X�@��
        CTimeOut = 114 '�q�T�O�ɲ��`
        COrderLocationOutError = 115 '����O�O�J�w��
        COrderLocationInError = 116 '����O�O�X�w��
        CAssignOverKeyIn = 117 '���w�X�w�`�ƶW�L�X�w�ƶq
        CMaxlen = 126 '���׹L��
        CWaferError = 127 '���PWafer���i�V��
        CRequestInsert = 148 'Please enter data. �п�J���T���
        CCancel = 149 'Process has been canceled.  �B�z�w�Q����
        CPermissionErr = 150 'Permission Error'�v�������A�Ь��t�κ޲z��
        CMaxofData = 151 'Exceed maximun number of data. �z�ҿ�J���ȶW�L�̤j��
        CStationDisable = 152 'The corresponding station is disabled.
        CRequestUpdate = 153 'Please modify data.
        CLocNoDelete = 154 '���w�줣�i�s�W�R��
        CDeleteCheck = 155 '���ʧ@�|�s�w�s�Ψ�����s��Ƥ@�_�R��
        CCheckMatNo = 156 '�~���n�@��,���i���ۦP
        CCNotDisplayNo = 157 '�w���@�~�A���ݧ@�~�����A�A�~��i��
        CDataInStock = 159 '�w�s�w�����
        CNoResvQty = 172 '�X�w�w���ƶq=0�A���i���X
        CHaveResvQty = 173 '�X�w�w���ƶq<>0�A�бN���~���X�A����
        CNoMatAndRemark = 174 '�Ƹ��M�Ƶ����i�P�ɪť�
        CNoThisMatInPallet = 175 '�e�����S��������ơA�L�k���X
        COutQtyError = 176 '���X�ƶq�����T
        COverStockQty = 177 '�W�X�w�s�ƶq

        '20191007  1�}�Y:�d��,���@ 2�}�Y:�J�w,�X�w 3�}�Y:DLG,MDIMain,FNC,CRT 4�}�Y:PTS 5�}�Y:Display
        CNoPalletNo = 118 '�䤣��e��
        COnlyPAandWaitCanChange = 1032 '�u��PA��B�����ݪ��A�~�i�H�󴫮e��!!
        COnlyPKCanRebalance = 1033 '�u��PK��i�H���s��b!!
        CInventoryCannotCancle = 1034 '�L�I�椣�i����!!
        CNoDatafile = 1001 '�L�����
        CNoPictureFile = 1002 '�������,�L����
        CNoDetailFile = 1003 '�������,�L������
        CAtleastOneCondition = 1004 '�Цܤֿ�J�@�d�߱���
        CNoDeviceNo = 1005 '�d�L���]�ƽs��
        CPalletDataHasChanged = 1006 '�e�� :{0}��Ƥw�ܧ�Э��s�d��
        CLocationUpdateError = 1007 '�w��: {0} ��s����
        CPalletNotSix = 1008 '�п�J����Ƥ��e�����X
        CAlreadyWaferNoEmpty = 1009 '���e���w��Wafer ���i�ܧ󬰪Ůe�� �Х��R��STOCK��ƦA�s�W
        CRightBinNo = 1010 '�п�J���TBin No  �`�N:�P�@�e�����i��J�ۦPBin No
        CEnterBinNo = 1011 '�п�J���
        CEnterStockQty = 1012 '�п�J�w�s�ƶq	
        CEnterResvQty = 1013 '�п�J�w���ƶq
        CEnterPickingQty = 1014 '�п�J�ˮƼƶq
        CEnterGroupQty = 1015 '�п�JGroup Qty
        CEnterStorageQty = 1016 '�п�J�w�w���ƶq
        CNoTrayNo = 1017 '�e���D�ɵL�e�����X: {0}
        CPalletAlreadyInLoc = 1018 '���e��: {0} �w�b�䥦�w��: {1}
        CNotFindLoc = 1019 '�d�L���w�츹�X
        CNoVendorNo = 1020 '�d�L���t�ӽs��
        CRightRange = 1021 '�п�J���T�d��
        COutRange = 1022 '�W�X�d��
        CNotRetrieveNoModify = 1023 '�D�X�w�w����� ���i�ϥέק�\��
        CNotRightPalletNo = 1024 '�e�����X�����T
        CPalletStatusChanged = 1025 '�e���W���R�����e�����A�w���ܧ� �Ы�[F5]���s�d�߫�A����
        CNoStationNo = 1026 '�d�L�����D��
        CNoReason = 1027 '�z�Ѥ��i���ťաI
        CEnterBigTray = 1028 '�п�J�j�e��{0} 
        CAlreadyWrongTransfer = 1029 '�w�����~Transfer Data
        CNoMaterialNo = 1030 '�d�L�Ƹ��D��
        CGetSAPStockErr = 1031 '�L�k���o SAP �w�s,�гq���t�ΤH���K


        CNotEmployee = 2001 '�i�ê��n�J�̡A�нT�{
        CNoSuitableTray = 2002 '�S���X�A���e���A�Э��s��J�ƶq
        CReChooseStation = 2003 '�Э��s�s��ܯ��O
        CMustStation = 2004 '���O���i�ٲ�
        CPtsBarcodeQtyErr = 2005 'PTS ���X�ƶq�����T
        CManualGroupingOnebyone = 2006 '���~!���Grouping�A��ƥu��Ŀ�@��
        CRightBarcodePicking = 2007 '�б��˥��T���X�A�B�߮Ƽƶq���i��0
        CGroupingErrRetry = 2008 '�t�e��Ʋ��`�A�ЦA����J
        CScanPickingBarcode = 2009 '�б��˾߮Ƥ��Ƹ����X
        CStorageEmptyTray = 2010 '�ХΪŮe���J�w
        CStockCheckReturn = 2011 '�ХνL�I�A�J�w�A�]�w�J�w
        CInspectionReturnSetting = 2012 '�Х�����A�J�w�A�]�w�J�w
        CPalletUnPacking = 2013 '�|��{0}���e���|���߮�
        CScanMatNo = 2014 '�Х�����Ƹ�
        CQtyNotEnough = 2015 '�ƶq����
        CNoInspector = 2016 '�S����ƤH
        CNoCostcenter = 2017 '�S���񦨥�����
        CPalletCannotTransfer = 2018 '�L�k�ϥΦ��e���t�e
        CCannotGetSTType = 2019 '���o���O���A���� �Э��s����
        CMustSameInspector = 2020 '�����P�@��ƤH�~�i�H��P�e��
        CSelectStatus = 2021 '�п�ܪ��A
        CReselect = 2022 '�Э��s���
        CWrongTrayOrLocation = 2023 '��J���e�����x�즳�~
        CRightHyboxBarcode = 2024 '�п�J���THyBox���X
        CRightHyboxPalletBarcode = 2025 '�п�J���T�K�̪O���X!!!
        CHyboxPalletBound = 2026 '���̪O�w���j�w!!!!
        COutOfQTY = 2027 '�нT�{�O�_�w�W�L�ƶq{0}
        CPalletCannotStorage = 2028 '�e�����వ�J�w�]�w
        CStorageQtyMoreThanSAP = 2029 '�J�w�`�q�j��sap��ڼƶq!!
        CHyboxHasStock = 2030 '��HYBOX�w���w�s!!!
        CNoDataNoScanPTS = 2031 '�L���,�L�ݱ���PTS���X
        CDifferentTypeRestore = 2032 'TYPE���@�P, �Э��s���f
        CDifferentMatNoRestore = 2033 '�Ƹ����@�P, �Э��s���f
        CDifferentBatchNoRestore = 2034 '�帹���@�P, �Э��s���f
        CPalletHasStock = 2035 '���e���w���w�s
        COverPalletMaximum = 2036 '�Ŀ�ƶq�W�L�e���̤j�e�Ǽ�
        CTwoWaferDifferentMatNo = 2037 '�ⵧWafer�Ƹ����P�A�нT�{
        CNoSelectCapa = 2038 '�]�J�w��Ѿl�Ŷ�����ӵL�k����A�п�ܫ᭫�s����
        CMaintenanceProductCostcenter = 2039 '�п�J���׫~�����A���i�H�ONA
        CUseEmptyStore = 2040 '�Ρu�Ůe���J�w�v�e�����]�w
        CGetPalletErr = 2041 '���o�e����T����
        CStationErr = 2042 '���O���~�Э��s��J
        CLocationAndEnter = 2043 '�п�J�w��s��,�ë��UEnter
        CASRAComputerErr = 2044 '�T��󦹹q������ASRS�w��
        CMatNoEnter = 2045 '�Х���J�Ƹ�
        CVendorNameEnter = 2046 '�t�ӥN�X���i�ٲ�
        CRemarkEnter = 2047 '�Ƶ����i�ٲ�
        CEnterQty = 2048 '�ƶq����g�I
        CMatNoOrMatName = 2049 '�Ƹ��ٲ����ܡA�~�W���i�ٲ�
        CEnterDataErrColAndRow = 2050 '�нT�{��J��ƬO�_���~ , Col ={0} , Row ={1}
        CHyboxPalletNoStToSt = 2051 '���K�̪O���௸�ﯸ
        CPalletIsErrTray = 2052 '{0}���e�������`�e��
        CEnterSmallTray = 2053 '�п�J�p�e��{0}
        CTrayCannotTransfer = 2054 '�e���L�k����
        CBigTraySmaller = 2055 '�j�e��{0}���i��b�p�e��{1}
        CTrayLengthWrong = 2056 '�e�� : {0} ���פ���
        CPalletWrong = 2057 '{0} �e������ ; �Э��s��J
        CWrongValue = 2058 '{0} ��J�Ȥ����T
        CEnterHiroLoc = 2059 '�п�J���m�ܮw��s��
        CHiroLocNoTray = 2060 '�ӥ��m�ܤ��L�e���A�Ы��w�e��
        CHiroLocPluralTrays = 2061 '�ӥ��m�ܤ����ƼƮe���A�Ы��w�e��
        CChangeHiroLocToTray = 2062 '�w�ഫ�����m�ܤ����e��
        CNoPalletOrHiroLoc = 2063 '�d�L���e���Υ��m�ܮw��
        CPTSCodeRepeat = 2064 'PTS���X���ƿ�J
        CErrFosbId = 2065 'Fosb ID ���~
        CFosbIdRepeat = 2066 'Fosb ID ����
        CAlreadySpreadData = 2067 'Spread�w���������
        CSpreadVendorDifferent = 2068 '������Ƽt�ӻP�ثe�ҿ�t�Ӥ��ۦP�A�нT�{
        CUseBcrStartWith6 = 2069 '���椤�����D25������ơA�Ш�6�}�Y�����X

        CMainStatusErr = 3001 '�D���A���� :{0}
        CExecutestStatusErr = 3002 'Executest���A���� :{0}
        CNoTransfer = 3003 '�w�L�h�e���
        CChooseAgvDevice = 3004 '�Х����AGV�x��
        CLocProhibitDataErr = 3005 '�w��T���ƿ��~
        CCannotGetUserInfo = 3006 '�L�k�s�u���o�ϥΪ̸�T,�гs���t�ά����H��
        CCannotGetDB = 3007 '��Ʈw�L�kŪ��,�гs���t�ά����H��
        CAccountLocked = 3008 '�ثe�b���w�Q��w�A���p���w�ФH������
        CNoAccount = 3009 '�L���b��,�гs���t�ά����H��
        CSumNotEqualResv = 3010 '�`�ƻP�w���ƶq���X
        CResvQtyWrong = 3011 '�w���X�w�ƶq����A�ЦA�T�{�I
        CDifferentStationType = 3012 '{0} �P�e�@�ӯ��O {1}��{2}���@�P
        CBarcodeAlreadyInDB = 3013 '�����X�w�s�b��DB,�нT�{�O�_���Ш�
        CModifyErr = 3014 '�קﲧ�`,���p���t�κ޲z��
        CQtyNotEqualGrouping = 3015 '�ƶq�PGrouping Table ����,���p���t�κ޲z��
        CPtsBarcodeErr = 3016 'PTS ���X�����D
        CSelectNotifyPerson = 3017 '�ФĿ�q���H��
        CEnterPtsBarcode = 3018 '�п�JPTS ���X!!!
        CCannotGetUserInfoWait = 3019 '�L�k�s�u���o�ϥΪ̸�T,�ϥβz�U�H���t�εn�J....�еy��
        CLogOut = 3020 '�n�X�t��
        CWrongCardId = 3021 '�d�������D
        CGetPointNoArrayErr = 3022 'Point_No Array ���o����	
        CGetStationArrayErr = 3023 'Station Array ���o����
        CExpireDateForm = 3024 '�����榡�� MM/DD/YYYY {0}
        CExpireDateOverTomorrow = 3025 '����饲�ݤj�����
        CStorageDateForm = 3026 '�J�w����榡�� MM/DD/YYYY HH:MM : SS {0}


        CWebServiceConnectErr = 4001 'Web Service ��T����,���p���t�ά����H��
        CMRNotThisPlant = 4002 '����ګD�����t�ϳ��
        CMRAlreadyType = 4003 '��MR��w��J
        CGetStationErr = 4004 '���o���O����
        CCostcenterDifferent = 4005 '�������ߤ��@�P
        CCapaNoInput = 4006 '�Х��]�w �Ѿl�i�ΪŶ� ��A���s����

        CStationmultipleTransfer = 5001 '����TRANSFER�h��@��
        CNoOperationData = 5002 '�L�@�~���





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
        CVendorNotTheSame = 160  '�нT�{�O�_�P�t��!!!
        CVendorInput = 161  '�L�t�ӽs��,�п�J�t�ӽs��!!

        CTrnErr = 199 'Cannot Start Begin Transaction
        CSystemFileError = 201 'File error, execute File Check.
        CPrinterError = 202 'Printer error.
        CStationInquiry = 203 'Available in inquiry retrieval mode only.
        CStationProduction = 204 'Available in production retrieval mode only.
        CHostConnect = 205 'Available in Connect mode only.
        CHostDisConnect = 206 'Available in DisConnect mode only.
        CSQLConnect = 207 'SQLConnect
        CTimeOver = 208 'TimeOver
        CUnitTypeNG = 211                         '���e�������L�k�󦹯��J�w
        CLocDisable = 212                         '�z�ҫ��w���w�쬰�T��w��
        CSelectEmptyPallet = 213                  '�Ы��w�Ůe��
        CASRSLocation = 214                       '�����۰ʭܮw��A�Э��s��J
        CNGTransfer = 215                         '�e�����b���ʤ�....�еy��B�z


        CNgSelectType = 401                       'PPAP �X�w�п�ܳ�@Type

        'F12P1.VB6��.NET�s�W===================================================

        'CNoCommandLineArgument = 216 '�L�R�O�C�޼�!
        'CCommandLineArgumentError = 217  '�R�O�C�޼ƭӼƿ��~!
        'CInvalidCommandLineArgument = 218 '�R�O�C�޼Ƥ��O�Ʀr!
        'CClose = 219 '�T�w�n�����{����?
        'CPortCloseError = 220 'Close Port����
        'CPortOpenError = 221    'Open Port����
        'CResetPort = 222 '�T�w�nReset Port��?.
        'CStartOperation = 223  'Start Operation  �}�l�@�~....
        'CEndOperation = 224 'End Operation   .....�����@�~
        ConReConnectDBSuccess = 225 '���s�s����Ʈw���\
        ConReConnectDBError = 226 '���s�s����Ʈw����
        'F12P1.VB6��.NET�s�W===================================================
        ' CReadSpreadError = 227    'Ū��Spread��楢��!

        CUnitTypeError = 228
        CVenderErr = 229                         '�t�ӦW�٤��i���ť�
        CBarCodeErr = 230                         '�п�J���X
        CTrayNoErr = 231                         '�L���e�����X
        '0981101 BY �����w


        CWebServiceRequestStop = 9992
        CSpecialError = 999

    End Enum

End Module
