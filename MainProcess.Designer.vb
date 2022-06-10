<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainProcess
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainProcess))
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.B_Convert = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.B_DataDicPath = New System.Windows.Forms.Button()
        Me.L_DataDic = New System.Windows.Forms.Label()
        Me.L_FilePath = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.T_Search = New System.Windows.Forms.TextBox()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Btn_DataBaseSet = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 465)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(776, 96)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'B_Convert
        '
        Me.B_Convert.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.B_Convert.Location = New System.Drawing.Point(602, 102)
        Me.B_Convert.Name = "B_Convert"
        Me.B_Convert.Size = New System.Drawing.Size(147, 45)
        Me.B_Convert.TabIndex = 1
        Me.B_Convert.Text = "產生DataDic"
        Me.B_Convert.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(547, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(261, 50)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "可選擇欲轉換之資料表" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "將其所有欄位名稱產生至DataDic.vb"
        '
        'B_DataDicPath
        '
        Me.B_DataDicPath.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.B_DataDicPath.Location = New System.Drawing.Point(12, 36)
        Me.B_DataDicPath.Name = "B_DataDicPath"
        Me.B_DataDicPath.Size = New System.Drawing.Size(182, 23)
        Me.B_DataDicPath.TabIndex = 3
        Me.B_DataDicPath.Text = "請指定儲存位置"
        Me.B_DataDicPath.UseVisualStyleBackColor = True
        '
        'L_DataDic
        '
        Me.L_DataDic.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.L_DataDic.Location = New System.Drawing.Point(8, 62)
        Me.L_DataDic.Name = "L_DataDic"
        Me.L_DataDic.Size = New System.Drawing.Size(162, 21)
        Me.L_DataDic.TabIndex = 4
        Me.L_DataDic.Text = "DataDic.vb將儲存至: "
        '
        'L_FilePath
        '
        Me.L_FilePath.Font = New System.Drawing.Font("微軟正黑體", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.L_FilePath.Location = New System.Drawing.Point(159, 62)
        Me.L_FilePath.Name = "L_FilePath"
        Me.L_FilePath.Size = New System.Drawing.Size(186, 21)
        Me.L_FilePath.TabIndex = 5
        Me.L_FilePath.Text = "C:\XXX\DataDic.vb"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.T_Search)
        Me.GroupBox1.Controls.Add(Me.CheckedListBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 89)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(572, 370)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "可轉換之資料表"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(21, 34)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(73, 30)
        Me.CheckBox1.TabIndex = 8
        Me.CheckBox1.Text = "全選"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(374, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 21)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "搜尋:"
        '
        'T_Search
        '
        Me.T_Search.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.T_Search.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.T_Search.Location = New System.Drawing.Point(436, 23)
        Me.T_Search.Name = "T_Search"
        Me.T_Search.Size = New System.Drawing.Size(120, 29)
        Me.T_Search.TabIndex = 1
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.CheckOnClick = True
        Me.CheckedListBox1.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Items.AddRange(New Object() {"STOCK", "LOCATION", "TRANSFER", "PALLET"})
        Me.CheckedListBox1.Location = New System.Drawing.Point(21, 91)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.ScrollAlwaysVisible = True
        Me.CheckedListBox1.Size = New System.Drawing.Size(533, 268)
        Me.CheckedListBox1.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Btn_DataBaseSet})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 25)
        Me.ToolStrip1.TabIndex = 7
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Btn_DataBaseSet
        '
        Me.Btn_DataBaseSet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Btn_DataBaseSet.Image = CType(resources.GetObject("Btn_DataBaseSet.Image"), System.Drawing.Image)
        Me.Btn_DataBaseSet.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btn_DataBaseSet.Name = "Btn_DataBaseSet"
        Me.Btn_DataBaseSet.Size = New System.Drawing.Size(71, 22)
        Me.Btn_DataBaseSet.Text = "資料庫設定"
        '
        'MainProcess
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(800, 573)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.L_FilePath)
        Me.Controls.Add(Me.L_DataDic)
        Me.Controls.Add(Me.B_DataDicPath)
        Me.Controls.Add(Me.B_Convert)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainProcess"
        Me.ShowIcon = False
        Me.Text = "DataDicCreateAuto"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents B_Convert As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents B_DataDicPath As Button
    Friend WithEvents L_DataDic As Label
    Friend WithEvents L_FilePath As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents T_Search As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents Btn_DataBaseSet As ToolStripButton
End Class
