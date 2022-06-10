<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataBaseDetail
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Btn_Close = New System.Windows.Forms.Button()
        Me.RB_Oracle = New System.Windows.Forms.RadioButton()
        Me.RB_SQL = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GB_ForOracle = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.T_OraclePlantKey = New System.Windows.Forms.TextBox()
        Me.GB_ForSQL = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.T_DataBaseName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.T_ServerName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.T_LoginPassWord = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.T_LoginName = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1.SuspendLayout()
        Me.GB_ForOracle.SuspendLayout()
        Me.GB_ForSQL.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btn_Close
        '
        Me.Btn_Close.Font = New System.Drawing.Font("微軟正黑體", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Close.Location = New System.Drawing.Point(362, 247)
        Me.Btn_Close.Name = "Btn_Close"
        Me.Btn_Close.Size = New System.Drawing.Size(105, 43)
        Me.Btn_Close.TabIndex = 6
        Me.Btn_Close.Text = "完成設定"
        Me.Btn_Close.UseVisualStyleBackColor = True
        '
        'RB_Oracle
        '
        Me.RB_Oracle.Checked = True
        Me.RB_Oracle.Location = New System.Drawing.Point(6, 20)
        Me.RB_Oracle.Name = "RB_Oracle"
        Me.RB_Oracle.Size = New System.Drawing.Size(121, 36)
        Me.RB_Oracle.TabIndex = 7
        Me.RB_Oracle.TabStop = True
        Me.RB_Oracle.Text = "Oracle(TSMC)"
        Me.RB_Oracle.UseVisualStyleBackColor = True
        '
        'RB_SQL
        '
        Me.RB_SQL.Location = New System.Drawing.Point(121, 20)
        Me.RB_SQL.Name = "RB_SQL"
        Me.RB_SQL.Size = New System.Drawing.Size(54, 36)
        Me.RB_SQL.TabIndex = 8
        Me.RB_SQL.Text = "SQL"
        Me.RB_SQL.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RB_SQL)
        Me.GroupBox1.Controls.Add(Me.RB_Oracle)
        Me.GroupBox1.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(185, 59)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "資料庫類型"
        '
        'GB_ForOracle
        '
        Me.GB_ForOracle.Controls.Add(Me.Label2)
        Me.GB_ForOracle.Controls.Add(Me.Label1)
        Me.GB_ForOracle.Controls.Add(Me.T_OraclePlantKey)
        Me.GB_ForOracle.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GB_ForOracle.Location = New System.Drawing.Point(12, 77)
        Me.GB_ForOracle.Name = "GB_ForOracle"
        Me.GB_ForOracle.Size = New System.Drawing.Size(455, 164)
        Me.GB_ForOracle.TabIndex = 10
        Me.GB_ForOracle.TabStop = False
        Me.GB_ForOracle.Text = "OracleForTSMC"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(21, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(248, 42)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "請將Account.INI檔案放至" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "C:/Muratec底下"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "PlantKey:"
        '
        'T_OraclePlantKey
        '
        Me.T_OraclePlantKey.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.T_OraclePlantKey.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.T_OraclePlantKey.Location = New System.Drawing.Point(92, 24)
        Me.T_OraclePlantKey.Name = "T_OraclePlantKey"
        Me.T_OraclePlantKey.Size = New System.Drawing.Size(136, 25)
        Me.T_OraclePlantKey.TabIndex = 0
        Me.T_OraclePlantKey.Text = "TSMCF99P1"
        '
        'GB_ForSQL
        '
        Me.GB_ForSQL.Controls.Add(Me.Label6)
        Me.GB_ForSQL.Controls.Add(Me.T_DataBaseName)
        Me.GB_ForSQL.Controls.Add(Me.Label5)
        Me.GB_ForSQL.Controls.Add(Me.T_ServerName)
        Me.GB_ForSQL.Controls.Add(Me.Label4)
        Me.GB_ForSQL.Controls.Add(Me.T_LoginPassWord)
        Me.GB_ForSQL.Controls.Add(Me.Label3)
        Me.GB_ForSQL.Controls.Add(Me.T_LoginName)
        Me.GB_ForSQL.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GB_ForSQL.Location = New System.Drawing.Point(12, 77)
        Me.GB_ForSQL.Name = "GB_ForSQL"
        Me.GB_ForSQL.Size = New System.Drawing.Size(455, 164)
        Me.GB_ForSQL.TabIndex = 11
        Me.GB_ForSQL.TabStop = False
        Me.GB_ForSQL.Text = "SQL"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 17)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "DataBaseName:"
        '
        'T_DataBaseName
        '
        Me.T_DataBaseName.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.T_DataBaseName.Location = New System.Drawing.Point(128, 117)
        Me.T_DataBaseName.Name = "T_DataBaseName"
        Me.T_DataBaseName.Size = New System.Drawing.Size(252, 25)
        Me.T_DataBaseName.TabIndex = 6
        Me.T_DataBaseName.Text = "Master"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "ServerName:"
        '
        'T_ServerName
        '
        Me.T_ServerName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.T_ServerName.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.T_ServerName.Location = New System.Drawing.Point(128, 86)
        Me.T_ServerName.Name = "T_ServerName"
        Me.T_ServerName.Size = New System.Drawing.Size(252, 25)
        Me.T_ServerName.TabIndex = 4
        Me.T_ServerName.Text = "192.168.0.1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "LoginPassWord:"
        '
        'T_LoginPassWord
        '
        Me.T_LoginPassWord.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.T_LoginPassWord.Location = New System.Drawing.Point(128, 55)
        Me.T_LoginPassWord.Name = "T_LoginPassWord"
        Me.T_LoginPassWord.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.T_LoginPassWord.Size = New System.Drawing.Size(252, 25)
        Me.T_LoginPassWord.TabIndex = 2
        Me.T_LoginPassWord.Text = "password"
        Me.T_LoginPassWord.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "LoginName:"
        '
        'T_LoginName
        '
        Me.T_LoginName.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.T_LoginName.Location = New System.Drawing.Point(128, 24)
        Me.T_LoginName.Name = "T_LoginName"
        Me.T_LoginName.Size = New System.Drawing.Size(252, 25)
        Me.T_LoginName.TabIndex = 0
        Me.T_LoginName.Text = "user"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'DataBaseDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 302)
        Me.Controls.Add(Me.GB_ForSQL)
        Me.Controls.Add(Me.GB_ForOracle)
        Me.Controls.Add(Me.Btn_Close)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DataBaseDetail"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "資料庫設定-DataDicCreateAuto"
        Me.GroupBox1.ResumeLayout(False)
        Me.GB_ForOracle.ResumeLayout(False)
        Me.GB_ForOracle.PerformLayout()
        Me.GB_ForSQL.ResumeLayout(False)
        Me.GB_ForSQL.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btn_Close As Button
    Friend WithEvents RB_Oracle As RadioButton
    Friend WithEvents RB_SQL As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GB_ForOracle As GroupBox
    Friend WithEvents GB_ForSQL As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents T_OraclePlantKey As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label3 As Label
    Friend WithEvents T_LoginName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents T_LoginPassWord As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents T_ServerName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents T_DataBaseName As TextBox
End Class
