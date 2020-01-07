<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabTagStatus = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnSecondBack = New System.Windows.Forms.Button()
        Me.btnSetTagAvb = New System.Windows.Forms.Button()
        Me.btnAssignNewTag = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblAccessTime = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblEmplFirstName = New System.Windows.Forms.Label()
        Me.grpCredLogin = New System.Windows.Forms.GroupBox()
        Me.PicVector = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnEnterReports = New System.Windows.Forms.Button()
        Me.btnFirstBack = New System.Windows.Forms.Button()
        Me.txtDigitCode = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblEmplLastName = New System.Windows.Forms.Label()
        Me.lblEmplCode = New System.Windows.Forms.Label()
        Me.grpReportedTags = New System.Windows.Forms.GroupBox()
        Me.EzPassDBSystem = New EzPass_Prototype_1.EzPassDBSystem()
        Me.EmployeeAccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeAccountsTableAdapter = New EzPass_Prototype_1.EzPassDBSystemTableAdapters.EmployeeAccountsTableAdapter()
        Me.LostTagsInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LostTagsInfoTableAdapter = New EzPass_Prototype_1.EzPassDBSystemTableAdapters.LostTagsInfoTableAdapter()
        Me.ReturnedTagsInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReturnedTagsInfoTableAdapter = New EzPass_Prototype_1.EzPassDBSystemTableAdapters.ReturnedTagsInfoTableAdapter()
        Me.AccountDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TagDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TagReturnedOnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RemovalReasonDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TagDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TagLostOnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RemovalReasonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabTagStatus.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCredLogin.SuspendLayout()
        CType(Me.PicVector, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpReportedTags.SuspendLayout()
        CType(Me.EzPassDBSystem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeAccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LostTagsInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReturnedTagsInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Turquoise
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(359, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tag Reports"
        '
        'TabTagStatus
        '
        Me.TabTagStatus.Controls.Add(Me.TabPage1)
        Me.TabTagStatus.Controls.Add(Me.TabPage2)
        Me.TabTagStatus.Font = New System.Drawing.Font("Rockwell", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabTagStatus.Location = New System.Drawing.Point(22, 85)
        Me.TabTagStatus.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.TabTagStatus.Name = "TabTagStatus"
        Me.TabTagStatus.SelectedIndex = 0
        Me.TabTagStatus.Size = New System.Drawing.Size(919, 351)
        Me.TabTagStatus.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGridView2)
        Me.TabPage1.Font = New System.Drawing.Font("Rockwell", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 31)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.TabPage1.Size = New System.Drawing.Size(911, 316)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Lost Tags"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AccountDataGridViewTextBoxColumn, Me.TagDataGridViewTextBoxColumn, Me.TagLostOnDataGridViewTextBoxColumn, Me.RemovalReasonDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.LostTagsInfoBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(17, 21)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowTemplate.Height = 28
        Me.DataGridView2.Size = New System.Drawing.Size(865, 277)
        Me.DataGridView2.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DataGridView1)
        Me.TabPage2.Font = New System.Drawing.Font("Rockwell", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 31)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.TabPage2.Size = New System.Drawing.Size(911, 316)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Returned Tags"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AccountDataGridViewTextBoxColumn1, Me.TagDataGridViewTextBoxColumn1, Me.TagReturnedOnDataGridViewTextBoxColumn, Me.RemovalReasonDataGridViewTextBoxColumn1})
        Me.DataGridView1.DataSource = Me.ReturnedTagsInfoBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(17, 21)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(865, 277)
        Me.DataGridView1.TabIndex = 0
        '
        'btnSecondBack
        '
        Me.btnSecondBack.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnSecondBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSecondBack.Font = New System.Drawing.Font("Rockwell", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSecondBack.Location = New System.Drawing.Point(29, 574)
        Me.btnSecondBack.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.btnSecondBack.Name = "btnSecondBack"
        Me.btnSecondBack.Size = New System.Drawing.Size(279, 69)
        Me.btnSecondBack.TabIndex = 1
        Me.btnSecondBack.Text = "Back to Database"
        Me.btnSecondBack.UseVisualStyleBackColor = False
        '
        'btnSetTagAvb
        '
        Me.btnSetTagAvb.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnSetTagAvb.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSetTagAvb.Font = New System.Drawing.Font("Rockwell", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSetTagAvb.Location = New System.Drawing.Point(662, 574)
        Me.btnSetTagAvb.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.btnSetTagAvb.Name = "btnSetTagAvb"
        Me.btnSetTagAvb.Size = New System.Drawing.Size(279, 69)
        Me.btnSetTagAvb.TabIndex = 2
        Me.btnSetTagAvb.Text = "Set Tag Avaliable"
        Me.btnSetTagAvb.UseVisualStyleBackColor = False
        '
        'btnAssignNewTag
        '
        Me.btnAssignNewTag.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnAssignNewTag.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAssignNewTag.Font = New System.Drawing.Font("Rockwell", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAssignNewTag.Location = New System.Drawing.Point(349, 574)
        Me.btnAssignNewTag.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAssignNewTag.Name = "btnAssignNewTag"
        Me.btnAssignNewTag.Size = New System.Drawing.Size(279, 69)
        Me.btnAssignNewTag.TabIndex = 3
        Me.btnAssignNewTag.Text = "Assign New Tag"
        Me.btnAssignNewTag.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.Khaki
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUpdate.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(737, 29)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(200, 66)
        Me.btnUpdate.TabIndex = 4
        Me.btnUpdate.Text = "Update Database"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(103, 460)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(258, 24)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Tag Report Accessed On:"
        '
        'lblAccessTime
        '
        Me.lblAccessTime.AutoSize = True
        Me.lblAccessTime.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccessTime.Location = New System.Drawing.Point(103, 502)
        Me.lblAccessTime.Name = "lblAccessTime"
        Me.lblAccessTime.Size = New System.Drawing.Size(50, 24)
        Me.lblAccessTime.TabIndex = 6
        Me.lblAccessTime.Text = "@@"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(508, 460)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(361, 24)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Report Accessed by Sales Manager:"
        '
        'lblEmplFirstName
        '
        Me.lblEmplFirstName.AutoSize = True
        Me.lblEmplFirstName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeAccountsBindingSource, "First Name", True))
        Me.lblEmplFirstName.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmplFirstName.Location = New System.Drawing.Point(508, 502)
        Me.lblEmplFirstName.Name = "lblEmplFirstName"
        Me.lblEmplFirstName.Size = New System.Drawing.Size(50, 24)
        Me.lblEmplFirstName.TabIndex = 8
        Me.lblEmplFirstName.Text = "@@"
        '
        'grpCredLogin
        '
        Me.grpCredLogin.BackgroundImage = Global.EzPass_Prototype_1.My.Resources.Resources.Ezpass_Registration_Login_Background
        Me.grpCredLogin.Controls.Add(Me.PicVector)
        Me.grpCredLogin.Controls.Add(Me.Label10)
        Me.grpCredLogin.Controls.Add(Me.btnEnterReports)
        Me.grpCredLogin.Controls.Add(Me.btnFirstBack)
        Me.grpCredLogin.Controls.Add(Me.txtDigitCode)
        Me.grpCredLogin.Controls.Add(Me.Label8)
        Me.grpCredLogin.Controls.Add(Me.Label7)
        Me.grpCredLogin.Location = New System.Drawing.Point(11, 10)
        Me.grpCredLogin.Name = "grpCredLogin"
        Me.grpCredLogin.Size = New System.Drawing.Size(977, 651)
        Me.grpCredLogin.TabIndex = 8
        Me.grpCredLogin.TabStop = False
        '
        'PicVector
        '
        Me.PicVector.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicVector.Image = Global.EzPass_Prototype_1.My.Resources.Resources.credentialVector
        Me.PicVector.Location = New System.Drawing.Point(247, 40)
        Me.PicVector.Name = "PicVector"
        Me.PicVector.Size = New System.Drawing.Size(100, 93)
        Me.PicVector.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicVector.TabIndex = 9
        Me.PicVector.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Thistle
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(197, 572)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(574, 25)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Reminder: Your 4-Digit Code was given upon Registration." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnEnterReports
        '
        Me.btnEnterReports.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnEnterReports.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEnterReports.Font = New System.Drawing.Font("Rockwell", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnterReports.Location = New System.Drawing.Point(659, 426)
        Me.btnEnterReports.Name = "btnEnterReports"
        Me.btnEnterReports.Size = New System.Drawing.Size(230, 75)
        Me.btnEnterReports.TabIndex = 7
        Me.btnEnterReports.Text = "Enter Tag Reports"
        Me.btnEnterReports.UseVisualStyleBackColor = False
        '
        'btnFirstBack
        '
        Me.btnFirstBack.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnFirstBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFirstBack.Font = New System.Drawing.Font("Rockwell", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFirstBack.Location = New System.Drawing.Point(83, 426)
        Me.btnFirstBack.Name = "btnFirstBack"
        Me.btnFirstBack.Size = New System.Drawing.Size(230, 75)
        Me.btnFirstBack.TabIndex = 1
        Me.btnFirstBack.Text = "Back to Database"
        Me.btnFirstBack.UseVisualStyleBackColor = False
        '
        'txtDigitCode
        '
        Me.txtDigitCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDigitCode.Location = New System.Drawing.Point(396, 305)
        Me.txtDigitCode.Name = "txtDigitCode"
        Me.txtDigitCode.Size = New System.Drawing.Size(197, 28)
        Me.txtDigitCode.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Font = New System.Drawing.Font("Rockwell", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(365, 238)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(250, 26)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Employee 4-Digit Code :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Thistle
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(374, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(343, 38)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Employee Credentials"
        '
        'lblEmplLastName
        '
        Me.lblEmplLastName.AutoSize = True
        Me.lblEmplLastName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeAccountsBindingSource, "Last Name", True))
        Me.lblEmplLastName.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmplLastName.Location = New System.Drawing.Point(625, 502)
        Me.lblEmplLastName.Name = "lblEmplLastName"
        Me.lblEmplLastName.Size = New System.Drawing.Size(50, 24)
        Me.lblEmplLastName.TabIndex = 9
        Me.lblEmplLastName.Text = "@@"
        '
        'lblEmplCode
        '
        Me.lblEmplCode.AutoSize = True
        Me.lblEmplCode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeAccountsBindingSource, "4-Digit Code", True))
        Me.lblEmplCode.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmplCode.Location = New System.Drawing.Point(819, 502)
        Me.lblEmplCode.Name = "lblEmplCode"
        Me.lblEmplCode.Size = New System.Drawing.Size(50, 24)
        Me.lblEmplCode.TabIndex = 10
        Me.lblEmplCode.Text = "@@"
        '
        'grpReportedTags
        '
        Me.grpReportedTags.Controls.Add(Me.lblEmplCode)
        Me.grpReportedTags.Controls.Add(Me.lblEmplLastName)
        Me.grpReportedTags.Controls.Add(Me.lblAccessTime)
        Me.grpReportedTags.Controls.Add(Me.Label2)
        Me.grpReportedTags.Controls.Add(Me.lblEmplFirstName)
        Me.grpReportedTags.Controls.Add(Me.Label3)
        Me.grpReportedTags.Controls.Add(Me.btnUpdate)
        Me.grpReportedTags.Controls.Add(Me.btnAssignNewTag)
        Me.grpReportedTags.Controls.Add(Me.btnSetTagAvb)
        Me.grpReportedTags.Controls.Add(Me.btnSecondBack)
        Me.grpReportedTags.Controls.Add(Me.TabTagStatus)
        Me.grpReportedTags.Controls.Add(Me.Label1)
        Me.grpReportedTags.Location = New System.Drawing.Point(18, 10)
        Me.grpReportedTags.Name = "grpReportedTags"
        Me.grpReportedTags.Size = New System.Drawing.Size(969, 661)
        Me.grpReportedTags.TabIndex = 11
        Me.grpReportedTags.TabStop = False
        '
        'EzPassDBSystem
        '
        Me.EzPassDBSystem.DataSetName = "EzPassDBSystem"
        Me.EzPassDBSystem.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmployeeAccountsBindingSource
        '
        Me.EmployeeAccountsBindingSource.DataMember = "EmployeeAccounts"
        Me.EmployeeAccountsBindingSource.DataSource = Me.EzPassDBSystem
        '
        'EmployeeAccountsTableAdapter
        '
        Me.EmployeeAccountsTableAdapter.ClearBeforeFill = True
        '
        'LostTagsInfoBindingSource
        '
        Me.LostTagsInfoBindingSource.DataMember = "LostTagsInfo"
        Me.LostTagsInfoBindingSource.DataSource = Me.EzPassDBSystem
        '
        'LostTagsInfoTableAdapter
        '
        Me.LostTagsInfoTableAdapter.ClearBeforeFill = True
        '
        'ReturnedTagsInfoBindingSource
        '
        Me.ReturnedTagsInfoBindingSource.DataMember = "ReturnedTagsInfo"
        Me.ReturnedTagsInfoBindingSource.DataSource = Me.EzPassDBSystem
        '
        'ReturnedTagsInfoTableAdapter
        '
        Me.ReturnedTagsInfoTableAdapter.ClearBeforeFill = True
        '
        'AccountDataGridViewTextBoxColumn1
        '
        Me.AccountDataGridViewTextBoxColumn1.DataPropertyName = "Account #"
        Me.AccountDataGridViewTextBoxColumn1.HeaderText = "Account #"
        Me.AccountDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.AccountDataGridViewTextBoxColumn1.Name = "AccountDataGridViewTextBoxColumn1"
        Me.AccountDataGridViewTextBoxColumn1.Width = 125
        '
        'TagDataGridViewTextBoxColumn1
        '
        Me.TagDataGridViewTextBoxColumn1.DataPropertyName = "Tag #"
        Me.TagDataGridViewTextBoxColumn1.HeaderText = "Tag #"
        Me.TagDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.TagDataGridViewTextBoxColumn1.Name = "TagDataGridViewTextBoxColumn1"
        Me.TagDataGridViewTextBoxColumn1.Width = 125
        '
        'TagReturnedOnDataGridViewTextBoxColumn
        '
        Me.TagReturnedOnDataGridViewTextBoxColumn.DataPropertyName = "Tag Returned On:"
        Me.TagReturnedOnDataGridViewTextBoxColumn.HeaderText = "Tag Returned On:"
        Me.TagReturnedOnDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TagReturnedOnDataGridViewTextBoxColumn.Name = "TagReturnedOnDataGridViewTextBoxColumn"
        Me.TagReturnedOnDataGridViewTextBoxColumn.Width = 125
        '
        'RemovalReasonDataGridViewTextBoxColumn1
        '
        Me.RemovalReasonDataGridViewTextBoxColumn1.DataPropertyName = "Removal Reason"
        Me.RemovalReasonDataGridViewTextBoxColumn1.HeaderText = "Removal Reason"
        Me.RemovalReasonDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.RemovalReasonDataGridViewTextBoxColumn1.Name = "RemovalReasonDataGridViewTextBoxColumn1"
        Me.RemovalReasonDataGridViewTextBoxColumn1.Width = 350
        '
        'AccountDataGridViewTextBoxColumn
        '
        Me.AccountDataGridViewTextBoxColumn.DataPropertyName = "Account #"
        Me.AccountDataGridViewTextBoxColumn.HeaderText = "Account #"
        Me.AccountDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AccountDataGridViewTextBoxColumn.Name = "AccountDataGridViewTextBoxColumn"
        Me.AccountDataGridViewTextBoxColumn.Width = 125
        '
        'TagDataGridViewTextBoxColumn
        '
        Me.TagDataGridViewTextBoxColumn.DataPropertyName = "Tag #"
        Me.TagDataGridViewTextBoxColumn.HeaderText = "Tag #"
        Me.TagDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TagDataGridViewTextBoxColumn.Name = "TagDataGridViewTextBoxColumn"
        Me.TagDataGridViewTextBoxColumn.Width = 125
        '
        'TagLostOnDataGridViewTextBoxColumn
        '
        Me.TagLostOnDataGridViewTextBoxColumn.DataPropertyName = "Tag Lost On:"
        Me.TagLostOnDataGridViewTextBoxColumn.HeaderText = "Tag Lost On:"
        Me.TagLostOnDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TagLostOnDataGridViewTextBoxColumn.Name = "TagLostOnDataGridViewTextBoxColumn"
        Me.TagLostOnDataGridViewTextBoxColumn.Width = 125
        '
        'RemovalReasonDataGridViewTextBoxColumn
        '
        Me.RemovalReasonDataGridViewTextBoxColumn.DataPropertyName = "Removal Reason"
        Me.RemovalReasonDataGridViewTextBoxColumn.HeaderText = "Removal Reason"
        Me.RemovalReasonDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.RemovalReasonDataGridViewTextBoxColumn.Name = "RemovalReasonDataGridViewTextBoxColumn"
        Me.RemovalReasonDataGridViewTextBoxColumn.Width = 350
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1001, 675)
        Me.Controls.Add(Me.grpCredLogin)
        Me.Controls.Add(Me.grpReportedTags)
        Me.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tag Reports"
        Me.TabTagStatus.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCredLogin.ResumeLayout(False)
        Me.grpCredLogin.PerformLayout()
        CType(Me.PicVector, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpReportedTags.ResumeLayout(False)
        Me.grpReportedTags.PerformLayout()
        CType(Me.EzPassDBSystem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeAccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LostTagsInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReturnedTagsInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TabTagStatus As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnSecondBack As Button
    Friend WithEvents btnSetTagAvb As Button
    Friend WithEvents btnAssignNewTag As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lblAccessTime As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblEmplFirstName As Label
    Friend WithEvents grpCredLogin As GroupBox
    Friend WithEvents PicVector As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnEnterReports As Button
    Friend WithEvents btnFirstBack As Button
    Friend WithEvents txtDigitCode As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblEmplLastName As Label
    Friend WithEvents lblEmplCode As Label
    Friend WithEvents grpReportedTags As GroupBox
    Friend WithEvents EzPassDBSystem As EzPassDBSystem
    Friend WithEvents EmployeeAccountsBindingSource As BindingSource
    Friend WithEvents EmployeeAccountsTableAdapter As EzPassDBSystemTableAdapters.EmployeeAccountsTableAdapter
    Friend WithEvents LostTagsInfoBindingSource As BindingSource
    Friend WithEvents LostTagsInfoTableAdapter As EzPassDBSystemTableAdapters.LostTagsInfoTableAdapter
    Friend WithEvents ReturnedTagsInfoBindingSource As BindingSource
    Friend WithEvents ReturnedTagsInfoTableAdapter As EzPassDBSystemTableAdapters.ReturnedTagsInfoTableAdapter
    Friend WithEvents AccountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TagDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TagLostOnDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RemovalReasonDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AccountDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents TagDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents TagReturnedOnDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RemovalReasonDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
End Class
