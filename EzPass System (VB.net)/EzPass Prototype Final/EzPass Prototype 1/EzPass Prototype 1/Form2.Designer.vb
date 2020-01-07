<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.btnNextRecord = New System.Windows.Forms.Button()
        Me.btnDeleteRecord = New System.Windows.Forms.Button()
        Me.btnExitProgram = New System.Windows.Forms.Button()
        Me.grpEntries = New System.Windows.Forms.GroupBox()
        Me.btnUpdateField = New System.Windows.Forms.Button()
        Me.btnPreviousRecord = New System.Windows.Forms.Button()
        Me.btnClearField = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.CustomersInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EzPassDBSystem = New EzPass_Prototype_1.EzPassDBSystem()
        Me.lblCardonFile = New System.Windows.Forms.Label()
        Me.cmbStanding = New System.Windows.Forms.ComboBox()
        Me.txtAcctBalance = New System.Windows.Forms.TextBox()
        Me.txtTagAcct = New System.Windows.Forms.TextBox()
        Me.lblStanding = New System.Windows.Forms.Label()
        Me.lblTagAccountNbr = New System.Windows.Forms.Label()
        Me.lblAcctBalance = New System.Windows.Forms.Label()
        Me.TabAccounts = New System.Windows.Forms.TabPage()
        Me.grpTagInfo = New System.Windows.Forms.GroupBox()
        Me.cmbTagStatus = New System.Windows.Forms.ComboBox()
        Me.txtTagDateAssign = New System.Windows.Forms.TextBox()
        Me.txtTagNbr = New System.Windows.Forms.TextBox()
        Me.lblTagStatus = New System.Windows.Forms.Label()
        Me.lblTagDateAssign = New System.Windows.Forms.Label()
        Me.lblTagNbr = New System.Windows.Forms.Label()
        Me.TabVehicles = New System.Windows.Forms.TabPage()
        Me.grpAccountInfo = New System.Windows.Forms.GroupBox()
        Me.cmbEmModel = New System.Windows.Forms.ComboBox()
        Me.cmbEmYear = New System.Windows.Forms.ComboBox()
        Me.cmbEmBodyStyle = New System.Windows.Forms.ComboBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.lblRemovalReason = New System.Windows.Forms.Label()
        Me.txtRemovalDate = New System.Windows.Forms.TextBox()
        Me.txtAddDate = New System.Windows.Forms.TextBox()
        Me.lblRemovalDate = New System.Windows.Forms.Label()
        Me.lblAddDate = New System.Windows.Forms.Label()
        Me.txtPlateNbr = New System.Windows.Forms.TextBox()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.lblBodyStyle = New System.Windows.Forms.Label()
        Me.lblPlateNbr = New System.Windows.Forms.Label()
        Me.TabCustomers = New System.Windows.Forms.TabPage()
        Me.grpCustomerInfo = New System.Windows.Forms.GroupBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.txtDOB = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblAcctGiven = New System.Windows.Forms.Label()
        Me.txtSignUp = New System.Windows.Forms.TextBox()
        Me.lblSignUp = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.TabEntries = New System.Windows.Forms.TabControl()
        Me.btnTagMonitor = New System.Windows.Forms.Button()
        Me.grpDatabase = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOfBirthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SignUpDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BodyStyleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VehicleYearDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RemovalDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RemovalReasonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TagDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TagAccountIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TagDateAssignedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TagStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccountBalanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccountStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CardOnFileDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TripsTakenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnTollMonitor = New System.Windows.Forms.Button()
        Me.btnUpdateTolls = New System.Windows.Forms.Button()
        Me.grpLoginScreen = New System.Windows.Forms.GroupBox()
        Me.btnEmployeeReg = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMaskPassword = New System.Windows.Forms.MaskedTextBox()
        Me.EmployeeAccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.btnLoginExit = New System.Windows.Forms.Button()
        Me.btnLoginClear = New System.Windows.Forms.Button()
        Me.btnLoginEnter = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PicVector = New System.Windows.Forms.PictureBox()
        Me.CustomersInfoTableAdapter = New EzPass_Prototype_1.EzPassDBSystemTableAdapters.CustomersInfoTableAdapter()
        Me.EmployeeAccountsTableAdapter = New EzPass_Prototype_1.EzPassDBSystemTableAdapters.EmployeeAccountsTableAdapter()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblEmplFirstName = New System.Windows.Forms.Label()
        Me.lblEmplLastName = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.grpDbLayout = New System.Windows.Forms.GroupBox()
        Me.grpEntries.SuspendLayout()
        CType(Me.CustomersInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EzPassDBSystem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabAccounts.SuspendLayout()
        Me.grpTagInfo.SuspendLayout()
        Me.TabVehicles.SuspendLayout()
        Me.grpAccountInfo.SuspendLayout()
        Me.TabCustomers.SuspendLayout()
        Me.grpCustomerInfo.SuspendLayout()
        Me.TabEntries.SuspendLayout()
        Me.grpDatabase.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLoginScreen.SuspendLayout()
        CType(Me.EmployeeAccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicVector, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.grpDbLayout.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("Tahoma", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.Location = New System.Drawing.Point(206, 44)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(421, 36)
        Me.LblTitle.TabIndex = 0
        Me.LblTitle.Text = "EzPass Customer Database"
        '
        'btnNextRecord
        '
        Me.btnNextRecord.BackColor = System.Drawing.Color.PapayaWhip
        Me.btnNextRecord.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNextRecord.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNextRecord.Location = New System.Drawing.Point(24, 114)
        Me.btnNextRecord.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnNextRecord.Name = "btnNextRecord"
        Me.btnNextRecord.Size = New System.Drawing.Size(132, 39)
        Me.btnNextRecord.TabIndex = 7
        Me.btnNextRecord.Text = "Next Record"
        Me.btnNextRecord.UseVisualStyleBackColor = False
        '
        'btnDeleteRecord
        '
        Me.btnDeleteRecord.BackColor = System.Drawing.Color.PapayaWhip
        Me.btnDeleteRecord.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDeleteRecord.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteRecord.Location = New System.Drawing.Point(192, 108)
        Me.btnDeleteRecord.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDeleteRecord.Name = "btnDeleteRecord"
        Me.btnDeleteRecord.Size = New System.Drawing.Size(132, 48)
        Me.btnDeleteRecord.TabIndex = 8
        Me.btnDeleteRecord.Text = "Delete Account" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnDeleteRecord.UseVisualStyleBackColor = False
        '
        'btnExitProgram
        '
        Me.btnExitProgram.BackColor = System.Drawing.Color.Khaki
        Me.btnExitProgram.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExitProgram.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExitProgram.Location = New System.Drawing.Point(24, 257)
        Me.btnExitProgram.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnExitProgram.Name = "btnExitProgram"
        Me.btnExitProgram.Size = New System.Drawing.Size(300, 53)
        Me.btnExitProgram.TabIndex = 9
        Me.btnExitProgram.Text = "Exit Database"
        Me.btnExitProgram.UseVisualStyleBackColor = False
        '
        'grpEntries
        '
        Me.grpEntries.Controls.Add(Me.btnUpdateField)
        Me.grpEntries.Controls.Add(Me.btnPreviousRecord)
        Me.grpEntries.Controls.Add(Me.btnClearField)
        Me.grpEntries.Controls.Add(Me.btnAdd)
        Me.grpEntries.Controls.Add(Me.btnExitProgram)
        Me.grpEntries.Controls.Add(Me.btnDeleteRecord)
        Me.grpEntries.Controls.Add(Me.btnNextRecord)
        Me.grpEntries.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpEntries.Location = New System.Drawing.Point(26, 540)
        Me.grpEntries.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpEntries.Name = "grpEntries"
        Me.grpEntries.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpEntries.Size = New System.Drawing.Size(361, 343)
        Me.grpEntries.TabIndex = 10
        Me.grpEntries.TabStop = False
        Me.grpEntries.Text = "Entry Navigation"
        '
        'btnUpdateField
        '
        Me.btnUpdateField.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnUpdateField.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUpdateField.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateField.Location = New System.Drawing.Point(192, 178)
        Me.btnUpdateField.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnUpdateField.Name = "btnUpdateField"
        Me.btnUpdateField.Size = New System.Drawing.Size(132, 48)
        Me.btnUpdateField.TabIndex = 23
        Me.btnUpdateField.Text = "Update Database"
        Me.btnUpdateField.UseVisualStyleBackColor = False
        '
        'btnPreviousRecord
        '
        Me.btnPreviousRecord.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnPreviousRecord.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPreviousRecord.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreviousRecord.Location = New System.Drawing.Point(192, 34)
        Me.btnPreviousRecord.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPreviousRecord.Name = "btnPreviousRecord"
        Me.btnPreviousRecord.Size = New System.Drawing.Size(132, 48)
        Me.btnPreviousRecord.TabIndex = 22
        Me.btnPreviousRecord.Text = "Previous Record"
        Me.btnPreviousRecord.UseVisualStyleBackColor = False
        '
        'btnClearField
        '
        Me.btnClearField.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnClearField.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClearField.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearField.Location = New System.Drawing.Point(24, 183)
        Me.btnClearField.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClearField.Name = "btnClearField"
        Me.btnClearField.Size = New System.Drawing.Size(132, 39)
        Me.btnClearField.TabIndex = 11
        Me.btnClearField.Text = "Clear Fields"
        Me.btnClearField.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.PapayaWhip
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(24, 38)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(132, 39)
        Me.btnAdd.TabIndex = 10
        Me.btnAdd.Text = "Add Account"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Card On File", True))
        Me.TextBox2.Location = New System.Drawing.Point(605, 128)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(156, 29)
        Me.TextBox2.TabIndex = 7
        '
        'CustomersInfoBindingSource
        '
        Me.CustomersInfoBindingSource.DataMember = "CustomersInfo"
        Me.CustomersInfoBindingSource.DataSource = Me.EzPassDBSystem
        '
        'EzPassDBSystem
        '
        Me.EzPassDBSystem.DataSetName = "EzPassDBSystem"
        Me.EzPassDBSystem.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblCardonFile
        '
        Me.lblCardonFile.AutoSize = True
        Me.lblCardonFile.Font = New System.Drawing.Font("Rockwell", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCardonFile.Location = New System.Drawing.Point(412, 132)
        Me.lblCardonFile.Name = "lblCardonFile"
        Me.lblCardonFile.Size = New System.Drawing.Size(124, 20)
        Me.lblCardonFile.TabIndex = 6
        Me.lblCardonFile.Text = "Card On File:"
        '
        'cmbStanding
        '
        Me.cmbStanding.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Account Status", True))
        Me.cmbStanding.FormattingEnabled = True
        Me.cmbStanding.Items.AddRange(New Object() {"Select Standing", "Good Standing", "Bad Standing"})
        Me.cmbStanding.Location = New System.Drawing.Point(584, 204)
        Me.cmbStanding.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbStanding.Name = "cmbStanding"
        Me.cmbStanding.Size = New System.Drawing.Size(177, 28)
        Me.cmbStanding.TabIndex = 5
        '
        'txtAcctBalance
        '
        Me.txtAcctBalance.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Account Balance", True))
        Me.txtAcctBalance.Location = New System.Drawing.Point(665, 55)
        Me.txtAcctBalance.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAcctBalance.Name = "txtAcctBalance"
        Me.txtAcctBalance.Size = New System.Drawing.Size(96, 29)
        Me.txtAcctBalance.TabIndex = 4
        '
        'txtTagAcct
        '
        Me.txtTagAcct.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Tag Account ID", True))
        Me.txtTagAcct.Location = New System.Drawing.Point(215, 228)
        Me.txtTagAcct.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTagAcct.Name = "txtTagAcct"
        Me.txtTagAcct.Size = New System.Drawing.Size(96, 29)
        Me.txtTagAcct.TabIndex = 3
        '
        'lblStanding
        '
        Me.lblStanding.AutoSize = True
        Me.lblStanding.Font = New System.Drawing.Font("Rockwell", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStanding.Location = New System.Drawing.Point(391, 206)
        Me.lblStanding.Name = "lblStanding"
        Me.lblStanding.Size = New System.Drawing.Size(164, 20)
        Me.lblStanding.TabIndex = 2
        Me.lblStanding.Text = "Account Standing:"
        '
        'lblTagAccountNbr
        '
        Me.lblTagAccountNbr.AutoSize = True
        Me.lblTagAccountNbr.Font = New System.Drawing.Font("Rockwell", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTagAccountNbr.Location = New System.Drawing.Point(5, 228)
        Me.lblTagAccountNbr.Name = "lblTagAccountNbr"
        Me.lblTagAccountNbr.Size = New System.Drawing.Size(147, 20)
        Me.lblTagAccountNbr.TabIndex = 0
        Me.lblTagAccountNbr.Text = "Tag Account ID:"
        '
        'lblAcctBalance
        '
        Me.lblAcctBalance.AutoSize = True
        Me.lblAcctBalance.Font = New System.Drawing.Font("Rockwell", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAcctBalance.Location = New System.Drawing.Point(412, 58)
        Me.lblAcctBalance.Name = "lblAcctBalance"
        Me.lblAcctBalance.Size = New System.Drawing.Size(196, 20)
        Me.lblAcctBalance.TabIndex = 1
        Me.lblAcctBalance.Text = "Account Balance ( $ ) :"
        '
        'TabAccounts
        '
        Me.TabAccounts.Controls.Add(Me.grpTagInfo)
        Me.TabAccounts.Location = New System.Drawing.Point(4, 31)
        Me.TabAccounts.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabAccounts.Name = "TabAccounts"
        Me.TabAccounts.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabAccounts.Size = New System.Drawing.Size(812, 297)
        Me.TabAccounts.TabIndex = 2
        Me.TabAccounts.Text = "Accounts"
        Me.TabAccounts.UseVisualStyleBackColor = True
        '
        'grpTagInfo
        '
        Me.grpTagInfo.Controls.Add(Me.TextBox2)
        Me.grpTagInfo.Controls.Add(Me.cmbTagStatus)
        Me.grpTagInfo.Controls.Add(Me.lblCardonFile)
        Me.grpTagInfo.Controls.Add(Me.txtTagDateAssign)
        Me.grpTagInfo.Controls.Add(Me.cmbStanding)
        Me.grpTagInfo.Controls.Add(Me.txtTagNbr)
        Me.grpTagInfo.Controls.Add(Me.lblStanding)
        Me.grpTagInfo.Controls.Add(Me.txtAcctBalance)
        Me.grpTagInfo.Controls.Add(Me.lblTagStatus)
        Me.grpTagInfo.Controls.Add(Me.txtTagAcct)
        Me.grpTagInfo.Controls.Add(Me.lblAcctBalance)
        Me.grpTagInfo.Controls.Add(Me.lblTagDateAssign)
        Me.grpTagInfo.Controls.Add(Me.lblTagNbr)
        Me.grpTagInfo.Controls.Add(Me.lblTagAccountNbr)
        Me.grpTagInfo.Font = New System.Drawing.Font("Rockwell", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpTagInfo.Location = New System.Drawing.Point(14, 16)
        Me.grpTagInfo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpTagInfo.Name = "grpTagInfo"
        Me.grpTagInfo.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpTagInfo.Size = New System.Drawing.Size(775, 277)
        Me.grpTagInfo.TabIndex = 0
        Me.grpTagInfo.TabStop = False
        Me.grpTagInfo.Text = "Account Information"
        '
        'cmbTagStatus
        '
        Me.cmbTagStatus.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Tag Status", True))
        Me.cmbTagStatus.FormattingEnabled = True
        Me.cmbTagStatus.Location = New System.Drawing.Point(215, 170)
        Me.cmbTagStatus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbTagStatus.Name = "cmbTagStatus"
        Me.cmbTagStatus.Size = New System.Drawing.Size(143, 28)
        Me.cmbTagStatus.TabIndex = 5
        '
        'txtTagDateAssign
        '
        Me.txtTagDateAssign.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Tag Date Assigned", True))
        Me.txtTagDateAssign.Enabled = False
        Me.txtTagDateAssign.Location = New System.Drawing.Point(215, 110)
        Me.txtTagDateAssign.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTagDateAssign.Name = "txtTagDateAssign"
        Me.txtTagDateAssign.Size = New System.Drawing.Size(143, 29)
        Me.txtTagDateAssign.TabIndex = 4
        '
        'txtTagNbr
        '
        Me.txtTagNbr.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Tag #", True))
        Me.txtTagNbr.Enabled = False
        Me.txtTagNbr.Location = New System.Drawing.Point(215, 53)
        Me.txtTagNbr.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTagNbr.Name = "txtTagNbr"
        Me.txtTagNbr.Size = New System.Drawing.Size(100, 29)
        Me.txtTagNbr.TabIndex = 3
        '
        'lblTagStatus
        '
        Me.lblTagStatus.AutoSize = True
        Me.lblTagStatus.Font = New System.Drawing.Font("Rockwell", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTagStatus.Location = New System.Drawing.Point(27, 176)
        Me.lblTagStatus.Name = "lblTagStatus"
        Me.lblTagStatus.Size = New System.Drawing.Size(103, 20)
        Me.lblTagStatus.TabIndex = 2
        Me.lblTagStatus.Text = "Tag Status:"
        '
        'lblTagDateAssign
        '
        Me.lblTagDateAssign.AutoSize = True
        Me.lblTagDateAssign.Font = New System.Drawing.Font("Rockwell", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTagDateAssign.Location = New System.Drawing.Point(5, 117)
        Me.lblTagDateAssign.Name = "lblTagDateAssign"
        Me.lblTagDateAssign.Size = New System.Drawing.Size(175, 20)
        Me.lblTagDateAssign.TabIndex = 1
        Me.lblTagDateAssign.Text = "Tag Date Assigned:"
        '
        'lblTagNbr
        '
        Me.lblTagNbr.AutoSize = True
        Me.lblTagNbr.Font = New System.Drawing.Font("Rockwell", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTagNbr.Location = New System.Drawing.Point(27, 53)
        Me.lblTagNbr.Name = "lblTagNbr"
        Me.lblTagNbr.Size = New System.Drawing.Size(122, 20)
        Me.lblTagNbr.TabIndex = 0
        Me.lblTagNbr.Text = "Tag Number:"
        '
        'TabVehicles
        '
        Me.TabVehicles.Controls.Add(Me.grpAccountInfo)
        Me.TabVehicles.Location = New System.Drawing.Point(4, 31)
        Me.TabVehicles.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabVehicles.Name = "TabVehicles"
        Me.TabVehicles.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabVehicles.Size = New System.Drawing.Size(812, 297)
        Me.TabVehicles.TabIndex = 1
        Me.TabVehicles.Text = "Vehicles"
        Me.TabVehicles.UseVisualStyleBackColor = True
        '
        'grpAccountInfo
        '
        Me.grpAccountInfo.Controls.Add(Me.cmbEmModel)
        Me.grpAccountInfo.Controls.Add(Me.cmbEmYear)
        Me.grpAccountInfo.Controls.Add(Me.cmbEmBodyStyle)
        Me.grpAccountInfo.Controls.Add(Me.TextBox5)
        Me.grpAccountInfo.Controls.Add(Me.lblRemovalReason)
        Me.grpAccountInfo.Controls.Add(Me.txtRemovalDate)
        Me.grpAccountInfo.Controls.Add(Me.txtAddDate)
        Me.grpAccountInfo.Controls.Add(Me.lblRemovalDate)
        Me.grpAccountInfo.Controls.Add(Me.lblAddDate)
        Me.grpAccountInfo.Controls.Add(Me.txtPlateNbr)
        Me.grpAccountInfo.Controls.Add(Me.lblYear)
        Me.grpAccountInfo.Controls.Add(Me.lblModel)
        Me.grpAccountInfo.Controls.Add(Me.lblBodyStyle)
        Me.grpAccountInfo.Controls.Add(Me.lblPlateNbr)
        Me.grpAccountInfo.Font = New System.Drawing.Font("Rockwell", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpAccountInfo.Location = New System.Drawing.Point(20, 26)
        Me.grpAccountInfo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpAccountInfo.Name = "grpAccountInfo"
        Me.grpAccountInfo.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpAccountInfo.Size = New System.Drawing.Size(766, 262)
        Me.grpAccountInfo.TabIndex = 0
        Me.grpAccountInfo.TabStop = False
        Me.grpAccountInfo.Text = "Vehicle Information"
        '
        'cmbEmModel
        '
        Me.cmbEmModel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Model", True))
        Me.cmbEmModel.DropDownHeight = 85
        Me.cmbEmModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEmModel.FormattingEnabled = True
        Me.cmbEmModel.IntegralHeight = False
        Me.cmbEmModel.ItemHeight = 22
        Me.cmbEmModel.Items.AddRange(New Object() {"Select Model", "Acura", "Alfa Romeo", "Audi", "BMW", "Buick", "Cadillac", "Chevrolet", "Chrysler", "Dodge", "Fiat", "Ford", "GMC", "Honda", "Hyundai", "Infiniti", "Jaguar ", "Jeep", "Kia", "Lexus", "Lincoln", "Maserati", "Mazda", "Mercedes-Benz", "Mitsubishi", "Nissan", "Pontiac", "Porsche", "Subaru", "Toyota", "Tesla", "Volkswagen", "Volvo"})
        Me.cmbEmModel.Location = New System.Drawing.Point(551, 42)
        Me.cmbEmModel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbEmModel.Name = "cmbEmModel"
        Me.cmbEmModel.Size = New System.Drawing.Size(185, 30)
        Me.cmbEmModel.TabIndex = 42
        '
        'cmbEmYear
        '
        Me.cmbEmYear.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Vehicle Year", True))
        Me.cmbEmYear.DropDownHeight = 85
        Me.cmbEmYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEmYear.FormattingEnabled = True
        Me.cmbEmYear.IntegralHeight = False
        Me.cmbEmYear.ItemHeight = 22
        Me.cmbEmYear.Items.AddRange(New Object() {"Enter Vehicle Year", "2019", "2018", "2017", "2016", "2015", "2014", "2013", "2012", "2011", "2010", "2009", "2008", "2007", "2006", "2005", "2004", "2003", "2002", "2001", "2000", "1999", "1998", "1997", "1996", "1995"})
        Me.cmbEmYear.Location = New System.Drawing.Point(551, 102)
        Me.cmbEmYear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbEmYear.Name = "cmbEmYear"
        Me.cmbEmYear.Size = New System.Drawing.Size(134, 30)
        Me.cmbEmYear.TabIndex = 43
        '
        'cmbEmBodyStyle
        '
        Me.cmbEmBodyStyle.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Body Style", True))
        Me.cmbEmBodyStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEmBodyStyle.FormattingEnabled = True
        Me.cmbEmBodyStyle.IntegralHeight = False
        Me.cmbEmBodyStyle.ItemHeight = 22
        Me.cmbEmBodyStyle.Items.AddRange(New Object() {"Select Style", "SUV", "Mini-Van", "Truck", "Sedan"})
        Me.cmbEmBodyStyle.Location = New System.Drawing.Point(152, 122)
        Me.cmbEmBodyStyle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbEmBodyStyle.Name = "cmbEmBodyStyle"
        Me.cmbEmBodyStyle.Size = New System.Drawing.Size(143, 30)
        Me.cmbEmBodyStyle.TabIndex = 41
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Removal Reason", True))
        Me.TextBox5.Location = New System.Drawing.Point(551, 215)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(185, 29)
        Me.TextBox5.TabIndex = 16
        '
        'lblRemovalReason
        '
        Me.lblRemovalReason.AutoSize = True
        Me.lblRemovalReason.Font = New System.Drawing.Font("Rockwell", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemovalReason.Location = New System.Drawing.Point(357, 222)
        Me.lblRemovalReason.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRemovalReason.Name = "lblRemovalReason"
        Me.lblRemovalReason.Size = New System.Drawing.Size(156, 20)
        Me.lblRemovalReason.TabIndex = 15
        Me.lblRemovalReason.Text = "Removal Reason:"
        '
        'txtRemovalDate
        '
        Me.txtRemovalDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Removal Date", True))
        Me.txtRemovalDate.Location = New System.Drawing.Point(551, 162)
        Me.txtRemovalDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtRemovalDate.Name = "txtRemovalDate"
        Me.txtRemovalDate.Size = New System.Drawing.Size(143, 29)
        Me.txtRemovalDate.TabIndex = 13
        '
        'txtAddDate
        '
        Me.txtAddDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Add Date", True))
        Me.txtAddDate.Enabled = False
        Me.txtAddDate.Location = New System.Drawing.Point(152, 198)
        Me.txtAddDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAddDate.Name = "txtAddDate"
        Me.txtAddDate.Size = New System.Drawing.Size(143, 29)
        Me.txtAddDate.TabIndex = 12
        '
        'lblRemovalDate
        '
        Me.lblRemovalDate.AutoSize = True
        Me.lblRemovalDate.Font = New System.Drawing.Font("Rockwell", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemovalDate.Location = New System.Drawing.Point(357, 166)
        Me.lblRemovalDate.Name = "lblRemovalDate"
        Me.lblRemovalDate.Size = New System.Drawing.Size(134, 20)
        Me.lblRemovalDate.TabIndex = 11
        Me.lblRemovalDate.Text = "Removal Date:"
        '
        'lblAddDate
        '
        Me.lblAddDate.AutoSize = True
        Me.lblAddDate.Font = New System.Drawing.Font("Rockwell", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddDate.Location = New System.Drawing.Point(14, 198)
        Me.lblAddDate.Name = "lblAddDate"
        Me.lblAddDate.Size = New System.Drawing.Size(93, 20)
        Me.lblAddDate.TabIndex = 10
        Me.lblAddDate.Text = "Add Date:"
        '
        'txtPlateNbr
        '
        Me.txtPlateNbr.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Plate #", True))
        Me.txtPlateNbr.Location = New System.Drawing.Point(152, 46)
        Me.txtPlateNbr.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPlateNbr.Name = "txtPlateNbr"
        Me.txtPlateNbr.Size = New System.Drawing.Size(143, 29)
        Me.txtPlateNbr.TabIndex = 6
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Font = New System.Drawing.Font("Rockwell", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYear.Location = New System.Drawing.Point(357, 110)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(124, 20)
        Me.lblYear.TabIndex = 4
        Me.lblYear.Text = "Vehicle Year:"
        '
        'lblModel
        '
        Me.lblModel.AutoSize = True
        Me.lblModel.Font = New System.Drawing.Font("Rockwell", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModel.Location = New System.Drawing.Point(381, 46)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(70, 20)
        Me.lblModel.TabIndex = 3
        Me.lblModel.Text = "Model:"
        '
        'lblBodyStyle
        '
        Me.lblBodyStyle.AutoSize = True
        Me.lblBodyStyle.Font = New System.Drawing.Font("Rockwell", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBodyStyle.Location = New System.Drawing.Point(14, 123)
        Me.lblBodyStyle.Name = "lblBodyStyle"
        Me.lblBodyStyle.Size = New System.Drawing.Size(103, 20)
        Me.lblBodyStyle.TabIndex = 2
        Me.lblBodyStyle.Text = "Body Style:"
        '
        'lblPlateNbr
        '
        Me.lblPlateNbr.AutoSize = True
        Me.lblPlateNbr.Font = New System.Drawing.Font("Rockwell", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlateNbr.Location = New System.Drawing.Point(24, 46)
        Me.lblPlateNbr.Name = "lblPlateNbr"
        Me.lblPlateNbr.Size = New System.Drawing.Size(77, 20)
        Me.lblPlateNbr.TabIndex = 1
        Me.lblPlateNbr.Text = "Plate # :"
        '
        'TabCustomers
        '
        Me.TabCustomers.Controls.Add(Me.grpCustomerInfo)
        Me.TabCustomers.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabCustomers.Location = New System.Drawing.Point(4, 31)
        Me.TabCustomers.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabCustomers.Name = "TabCustomers"
        Me.TabCustomers.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabCustomers.Size = New System.Drawing.Size(812, 297)
        Me.TabCustomers.TabIndex = 0
        Me.TabCustomers.Text = "Customers"
        Me.TabCustomers.UseVisualStyleBackColor = True
        '
        'grpCustomerInfo
        '
        Me.grpCustomerInfo.Controls.Add(Me.txtPhone)
        Me.grpCustomerInfo.Controls.Add(Me.lblPhoneNumber)
        Me.grpCustomerInfo.Controls.Add(Me.txtDOB)
        Me.grpCustomerInfo.Controls.Add(Me.Label5)
        Me.grpCustomerInfo.Controls.Add(Me.TextBox1)
        Me.grpCustomerInfo.Controls.Add(Me.lblAcctGiven)
        Me.grpCustomerInfo.Controls.Add(Me.txtSignUp)
        Me.grpCustomerInfo.Controls.Add(Me.lblSignUp)
        Me.grpCustomerInfo.Controls.Add(Me.lblEmail)
        Me.grpCustomerInfo.Controls.Add(Me.lblAddress)
        Me.grpCustomerInfo.Controls.Add(Me.lblLastName)
        Me.grpCustomerInfo.Controls.Add(Me.lblFirstName)
        Me.grpCustomerInfo.Controls.Add(Me.txtEmail)
        Me.grpCustomerInfo.Controls.Add(Me.txtAddress)
        Me.grpCustomerInfo.Controls.Add(Me.txtLastName)
        Me.grpCustomerInfo.Controls.Add(Me.txtFirstName)
        Me.grpCustomerInfo.Font = New System.Drawing.Font("Rockwell", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCustomerInfo.Location = New System.Drawing.Point(23, 18)
        Me.grpCustomerInfo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpCustomerInfo.Name = "grpCustomerInfo"
        Me.grpCustomerInfo.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpCustomerInfo.Size = New System.Drawing.Size(766, 272)
        Me.grpCustomerInfo.TabIndex = 14
        Me.grpCustomerInfo.TabStop = False
        Me.grpCustomerInfo.Text = "Customer Information"
        '
        'txtPhone
        '
        Me.txtPhone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Phone Number", True))
        Me.txtPhone.Location = New System.Drawing.Point(590, 202)
        Me.txtPhone.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(150, 29)
        Me.txtPhone.TabIndex = 27
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.Font = New System.Drawing.Font("Rockwell", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhoneNumber.Location = New System.Drawing.Point(409, 208)
        Me.lblPhoneNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(142, 20)
        Me.lblPhoneNumber.TabIndex = 26
        Me.lblPhoneNumber.Text = "Phone Number:"
        '
        'txtDOB
        '
        Me.txtDOB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Date of Birth", True))
        Me.txtDOB.Location = New System.Drawing.Point(190, 149)
        Me.txtDOB.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDOB.Name = "txtDOB"
        Me.txtDOB.Size = New System.Drawing.Size(152, 29)
        Me.txtDOB.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Rockwell", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 153)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 20)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Date Of Birth"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Account #", True))
        Me.TextBox1.Location = New System.Drawing.Point(590, 146)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(150, 29)
        Me.TextBox1.TabIndex = 23
        '
        'lblAcctGiven
        '
        Me.lblAcctGiven.AutoSize = True
        Me.lblAcctGiven.Font = New System.Drawing.Font("Rockwell", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAcctGiven.Location = New System.Drawing.Point(396, 149)
        Me.lblAcctGiven.Name = "lblAcctGiven"
        Me.lblAcctGiven.Size = New System.Drawing.Size(155, 20)
        Me.lblAcctGiven.TabIndex = 22
        Me.lblAcctGiven.Text = "Account # Given:"
        '
        'txtSignUp
        '
        Me.txtSignUp.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Sign-Up Date", True))
        Me.txtSignUp.Enabled = False
        Me.txtSignUp.Location = New System.Drawing.Point(190, 202)
        Me.txtSignUp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSignUp.Name = "txtSignUp"
        Me.txtSignUp.Size = New System.Drawing.Size(152, 29)
        Me.txtSignUp.TabIndex = 21
        '
        'lblSignUp
        '
        Me.lblSignUp.AutoSize = True
        Me.lblSignUp.Font = New System.Drawing.Font("Rockwell", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSignUp.Location = New System.Drawing.Point(18, 204)
        Me.lblSignUp.Name = "lblSignUp"
        Me.lblSignUp.Size = New System.Drawing.Size(125, 20)
        Me.lblSignUp.TabIndex = 19
        Me.lblSignUp.Text = "Sign-Up Date:"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Rockwell", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(396, 87)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(65, 20)
        Me.lblEmail.TabIndex = 18
        Me.lblEmail.Text = "Email:"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Rockwell", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(396, 42)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(85, 20)
        Me.lblAddress.TabIndex = 17
        Me.lblAddress.Text = "Address:"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Rockwell", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.Location = New System.Drawing.Point(18, 90)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(105, 20)
        Me.lblLastName.TabIndex = 16
        Me.lblLastName.Text = "Last Name:"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Rockwell", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.Location = New System.Drawing.Point(18, 43)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(109, 20)
        Me.lblFirstName.TabIndex = 15
        Me.lblFirstName.Text = "First Name:"
        '
        'txtEmail
        '
        Me.txtEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "E-mail", True))
        Me.txtEmail.Location = New System.Drawing.Point(526, 87)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(214, 29)
        Me.txtEmail.TabIndex = 13
        '
        'txtAddress
        '
        Me.txtAddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Address", True))
        Me.txtAddress.Location = New System.Drawing.Point(526, 42)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(214, 29)
        Me.txtAddress.TabIndex = 12
        '
        'txtLastName
        '
        Me.txtLastName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Last Name", True))
        Me.txtLastName.Location = New System.Drawing.Point(190, 92)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(152, 29)
        Me.txtLastName.TabIndex = 6
        '
        'txtFirstName
        '
        Me.txtFirstName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "First Name", True))
        Me.txtFirstName.Location = New System.Drawing.Point(190, 43)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(152, 29)
        Me.txtFirstName.TabIndex = 5
        '
        'TabEntries
        '
        Me.TabEntries.Controls.Add(Me.TabCustomers)
        Me.TabEntries.Controls.Add(Me.TabVehicles)
        Me.TabEntries.Controls.Add(Me.TabAccounts)
        Me.TabEntries.Font = New System.Drawing.Font("Rockwell", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabEntries.Location = New System.Drawing.Point(471, 560)
        Me.TabEntries.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabEntries.Name = "TabEntries"
        Me.TabEntries.SelectedIndex = 0
        Me.TabEntries.Size = New System.Drawing.Size(820, 332)
        Me.TabEntries.TabIndex = 19
        '
        'btnTagMonitor
        '
        Me.btnTagMonitor.BackColor = System.Drawing.Color.Orange
        Me.btnTagMonitor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnTagMonitor.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTagMonitor.Font = New System.Drawing.Font("Rockwell", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTagMonitor.Location = New System.Drawing.Point(690, 44)
        Me.btnTagMonitor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnTagMonitor.Name = "btnTagMonitor"
        Me.btnTagMonitor.Size = New System.Drawing.Size(210, 54)
        Me.btnTagMonitor.TabIndex = 25
        Me.btnTagMonitor.Text = "Tag Reports"
        Me.btnTagMonitor.UseVisualStyleBackColor = False
        '
        'grpDatabase
        '
        Me.grpDatabase.Controls.Add(Me.DataGridView1)
        Me.grpDatabase.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDatabase.Location = New System.Drawing.Point(24, 126)
        Me.grpDatabase.Margin = New System.Windows.Forms.Padding(4)
        Me.grpDatabase.Name = "grpDatabase"
        Me.grpDatabase.Padding = New System.Windows.Forms.Padding(4)
        Me.grpDatabase.Size = New System.Drawing.Size(1381, 383)
        Me.grpDatabase.TabIndex = 26
        Me.grpDatabase.TabStop = False
        Me.grpDatabase.Text = "Database"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.DateOfBirthDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.PhoneNumberDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.SignUpDateDataGridViewTextBoxColumn, Me.AccountDataGridViewTextBoxColumn, Me.PlateDataGridViewTextBoxColumn, Me.BodyStyleDataGridViewTextBoxColumn, Me.ModelDataGridViewTextBoxColumn, Me.VehicleYearDataGridViewTextBoxColumn, Me.AddDateDataGridViewTextBoxColumn, Me.RemovalDateDataGridViewTextBoxColumn, Me.RemovalReasonDataGridViewTextBoxColumn, Me.TagDataGridViewTextBoxColumn, Me.TagAccountIDDataGridViewTextBoxColumn, Me.TagDateAssignedDataGridViewTextBoxColumn, Me.TagStatusDataGridViewTextBoxColumn, Me.AccountBalanceDataGridViewTextBoxColumn, Me.AccountStatusDataGridViewTextBoxColumn, Me.CardOnFileDataGridViewTextBoxColumn, Me.TripsTakenDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CustomersInfoBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(19, 41)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.Size = New System.Drawing.Size(1349, 334)
        Me.DataGridView1.TabIndex = 0
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        Me.FirstNameDataGridViewTextBoxColumn.Width = 150
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        Me.LastNameDataGridViewTextBoxColumn.Width = 150
        '
        'DateOfBirthDataGridViewTextBoxColumn
        '
        Me.DateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "Date of Birth"
        Me.DateOfBirthDataGridViewTextBoxColumn.HeaderText = "Date of Birth"
        Me.DateOfBirthDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.DateOfBirthDataGridViewTextBoxColumn.Name = "DateOfBirthDataGridViewTextBoxColumn"
        Me.DateOfBirthDataGridViewTextBoxColumn.Width = 150
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        Me.AddressDataGridViewTextBoxColumn.Width = 150
        '
        'PhoneNumberDataGridViewTextBoxColumn
        '
        Me.PhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "Phone Number"
        Me.PhoneNumberDataGridViewTextBoxColumn.HeaderText = "Phone Number"
        Me.PhoneNumberDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.PhoneNumberDataGridViewTextBoxColumn.Name = "PhoneNumberDataGridViewTextBoxColumn"
        Me.PhoneNumberDataGridViewTextBoxColumn.Width = 150
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "E-mail"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "E-mail"
        Me.EmailDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.Width = 150
        '
        'SignUpDateDataGridViewTextBoxColumn
        '
        Me.SignUpDateDataGridViewTextBoxColumn.DataPropertyName = "Sign-Up Date"
        Me.SignUpDateDataGridViewTextBoxColumn.HeaderText = "Sign-Up Date"
        Me.SignUpDateDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.SignUpDateDataGridViewTextBoxColumn.Name = "SignUpDateDataGridViewTextBoxColumn"
        Me.SignUpDateDataGridViewTextBoxColumn.Width = 150
        '
        'AccountDataGridViewTextBoxColumn
        '
        Me.AccountDataGridViewTextBoxColumn.DataPropertyName = "Account #"
        Me.AccountDataGridViewTextBoxColumn.HeaderText = "Account #"
        Me.AccountDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.AccountDataGridViewTextBoxColumn.Name = "AccountDataGridViewTextBoxColumn"
        Me.AccountDataGridViewTextBoxColumn.Width = 150
        '
        'PlateDataGridViewTextBoxColumn
        '
        Me.PlateDataGridViewTextBoxColumn.DataPropertyName = "Plate #"
        Me.PlateDataGridViewTextBoxColumn.HeaderText = "Plate #"
        Me.PlateDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.PlateDataGridViewTextBoxColumn.Name = "PlateDataGridViewTextBoxColumn"
        Me.PlateDataGridViewTextBoxColumn.Width = 150
        '
        'BodyStyleDataGridViewTextBoxColumn
        '
        Me.BodyStyleDataGridViewTextBoxColumn.DataPropertyName = "Body Style"
        Me.BodyStyleDataGridViewTextBoxColumn.HeaderText = "Body Style"
        Me.BodyStyleDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.BodyStyleDataGridViewTextBoxColumn.Name = "BodyStyleDataGridViewTextBoxColumn"
        Me.BodyStyleDataGridViewTextBoxColumn.Width = 150
        '
        'ModelDataGridViewTextBoxColumn
        '
        Me.ModelDataGridViewTextBoxColumn.DataPropertyName = "Model"
        Me.ModelDataGridViewTextBoxColumn.HeaderText = "Model"
        Me.ModelDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ModelDataGridViewTextBoxColumn.Name = "ModelDataGridViewTextBoxColumn"
        Me.ModelDataGridViewTextBoxColumn.Width = 150
        '
        'VehicleYearDataGridViewTextBoxColumn
        '
        Me.VehicleYearDataGridViewTextBoxColumn.DataPropertyName = "Vehicle Year"
        Me.VehicleYearDataGridViewTextBoxColumn.HeaderText = "Vehicle Year"
        Me.VehicleYearDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.VehicleYearDataGridViewTextBoxColumn.Name = "VehicleYearDataGridViewTextBoxColumn"
        Me.VehicleYearDataGridViewTextBoxColumn.Width = 150
        '
        'AddDateDataGridViewTextBoxColumn
        '
        Me.AddDateDataGridViewTextBoxColumn.DataPropertyName = "Add Date"
        Me.AddDateDataGridViewTextBoxColumn.HeaderText = "Add Date"
        Me.AddDateDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.AddDateDataGridViewTextBoxColumn.Name = "AddDateDataGridViewTextBoxColumn"
        Me.AddDateDataGridViewTextBoxColumn.Width = 150
        '
        'RemovalDateDataGridViewTextBoxColumn
        '
        Me.RemovalDateDataGridViewTextBoxColumn.DataPropertyName = "Removal Date"
        Me.RemovalDateDataGridViewTextBoxColumn.HeaderText = "Removal Date"
        Me.RemovalDateDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.RemovalDateDataGridViewTextBoxColumn.Name = "RemovalDateDataGridViewTextBoxColumn"
        Me.RemovalDateDataGridViewTextBoxColumn.Width = 150
        '
        'RemovalReasonDataGridViewTextBoxColumn
        '
        Me.RemovalReasonDataGridViewTextBoxColumn.DataPropertyName = "Removal Reason"
        Me.RemovalReasonDataGridViewTextBoxColumn.HeaderText = "Removal Reason"
        Me.RemovalReasonDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.RemovalReasonDataGridViewTextBoxColumn.Name = "RemovalReasonDataGridViewTextBoxColumn"
        Me.RemovalReasonDataGridViewTextBoxColumn.Width = 150
        '
        'TagDataGridViewTextBoxColumn
        '
        Me.TagDataGridViewTextBoxColumn.DataPropertyName = "Tag #"
        Me.TagDataGridViewTextBoxColumn.HeaderText = "Tag #"
        Me.TagDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TagDataGridViewTextBoxColumn.Name = "TagDataGridViewTextBoxColumn"
        Me.TagDataGridViewTextBoxColumn.Width = 150
        '
        'TagAccountIDDataGridViewTextBoxColumn
        '
        Me.TagAccountIDDataGridViewTextBoxColumn.DataPropertyName = "Tag Account ID"
        Me.TagAccountIDDataGridViewTextBoxColumn.HeaderText = "Tag Account ID"
        Me.TagAccountIDDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TagAccountIDDataGridViewTextBoxColumn.Name = "TagAccountIDDataGridViewTextBoxColumn"
        Me.TagAccountIDDataGridViewTextBoxColumn.Width = 150
        '
        'TagDateAssignedDataGridViewTextBoxColumn
        '
        Me.TagDateAssignedDataGridViewTextBoxColumn.DataPropertyName = "Tag Date Assigned"
        Me.TagDateAssignedDataGridViewTextBoxColumn.HeaderText = "Tag Date Assigned"
        Me.TagDateAssignedDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TagDateAssignedDataGridViewTextBoxColumn.Name = "TagDateAssignedDataGridViewTextBoxColumn"
        Me.TagDateAssignedDataGridViewTextBoxColumn.Width = 150
        '
        'TagStatusDataGridViewTextBoxColumn
        '
        Me.TagStatusDataGridViewTextBoxColumn.DataPropertyName = "Tag Status"
        Me.TagStatusDataGridViewTextBoxColumn.HeaderText = "Tag Status"
        Me.TagStatusDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TagStatusDataGridViewTextBoxColumn.Name = "TagStatusDataGridViewTextBoxColumn"
        Me.TagStatusDataGridViewTextBoxColumn.Width = 150
        '
        'AccountBalanceDataGridViewTextBoxColumn
        '
        Me.AccountBalanceDataGridViewTextBoxColumn.DataPropertyName = "Account Balance"
        Me.AccountBalanceDataGridViewTextBoxColumn.HeaderText = "Account Balance"
        Me.AccountBalanceDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.AccountBalanceDataGridViewTextBoxColumn.Name = "AccountBalanceDataGridViewTextBoxColumn"
        Me.AccountBalanceDataGridViewTextBoxColumn.Width = 150
        '
        'AccountStatusDataGridViewTextBoxColumn
        '
        Me.AccountStatusDataGridViewTextBoxColumn.DataPropertyName = "Account Status"
        Me.AccountStatusDataGridViewTextBoxColumn.HeaderText = "Account Status"
        Me.AccountStatusDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.AccountStatusDataGridViewTextBoxColumn.Name = "AccountStatusDataGridViewTextBoxColumn"
        Me.AccountStatusDataGridViewTextBoxColumn.Width = 150
        '
        'CardOnFileDataGridViewTextBoxColumn
        '
        Me.CardOnFileDataGridViewTextBoxColumn.DataPropertyName = "Card On File"
        Me.CardOnFileDataGridViewTextBoxColumn.HeaderText = "Card On File"
        Me.CardOnFileDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.CardOnFileDataGridViewTextBoxColumn.Name = "CardOnFileDataGridViewTextBoxColumn"
        Me.CardOnFileDataGridViewTextBoxColumn.Width = 150
        '
        'TripsTakenDataGridViewTextBoxColumn
        '
        Me.TripsTakenDataGridViewTextBoxColumn.DataPropertyName = "Trips Taken"
        Me.TripsTakenDataGridViewTextBoxColumn.HeaderText = "Trips Taken"
        Me.TripsTakenDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TripsTakenDataGridViewTextBoxColumn.Name = "TripsTakenDataGridViewTextBoxColumn"
        Me.TripsTakenDataGridViewTextBoxColumn.Width = 150
        '
        'btnTollMonitor
        '
        Me.btnTollMonitor.BackColor = System.Drawing.Color.PeachPuff
        Me.btnTollMonitor.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTollMonitor.Font = New System.Drawing.Font("Rockwell", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTollMonitor.Location = New System.Drawing.Point(1183, 44)
        Me.btnTollMonitor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnTollMonitor.Name = "btnTollMonitor"
        Me.btnTollMonitor.Size = New System.Drawing.Size(210, 54)
        Me.btnTollMonitor.TabIndex = 27
        Me.btnTollMonitor.Text = "Toll Reports"
        Me.btnTollMonitor.UseVisualStyleBackColor = False
        '
        'btnUpdateTolls
        '
        Me.btnUpdateTolls.BackColor = System.Drawing.Color.PeachPuff
        Me.btnUpdateTolls.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUpdateTolls.Font = New System.Drawing.Font("Rockwell", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateTolls.Location = New System.Drawing.Point(936, 44)
        Me.btnUpdateTolls.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnUpdateTolls.Name = "btnUpdateTolls"
        Me.btnUpdateTolls.Size = New System.Drawing.Size(210, 54)
        Me.btnUpdateTolls.TabIndex = 28
        Me.btnUpdateTolls.Text = "Toll Information"
        Me.btnUpdateTolls.UseVisualStyleBackColor = False
        '
        'grpLoginScreen
        '
        Me.grpLoginScreen.BackColor = System.Drawing.Color.Transparent
        Me.grpLoginScreen.BackgroundImage = Global.EzPass_Prototype_1.My.Resources.Resources.Ezpass_Registration_Login_Background
        Me.grpLoginScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.grpLoginScreen.Controls.Add(Me.btnEmployeeReg)
        Me.grpLoginScreen.Controls.Add(Me.Label6)
        Me.grpLoginScreen.Controls.Add(Me.txtMaskPassword)
        Me.grpLoginScreen.Controls.Add(Me.PictureBox1)
        Me.grpLoginScreen.Controls.Add(Me.Label4)
        Me.grpLoginScreen.Controls.Add(Me.txtUsername)
        Me.grpLoginScreen.Controls.Add(Me.btnLoginExit)
        Me.grpLoginScreen.Controls.Add(Me.btnLoginClear)
        Me.grpLoginScreen.Controls.Add(Me.btnLoginEnter)
        Me.grpLoginScreen.Controls.Add(Me.Label3)
        Me.grpLoginScreen.Controls.Add(Me.Label2)
        Me.grpLoginScreen.Controls.Add(Me.Label1)
        Me.grpLoginScreen.Location = New System.Drawing.Point(12, 11)
        Me.grpLoginScreen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpLoginScreen.Name = "grpLoginScreen"
        Me.grpLoginScreen.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpLoginScreen.Size = New System.Drawing.Size(1428, 914)
        Me.grpLoginScreen.TabIndex = 1
        Me.grpLoginScreen.TabStop = False
        '
        'btnEmployeeReg
        '
        Me.btnEmployeeReg.BackColor = System.Drawing.Color.Khaki
        Me.btnEmployeeReg.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEmployeeReg.Font = New System.Drawing.Font("Rockwell", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmployeeReg.Location = New System.Drawing.Point(600, 677)
        Me.btnEmployeeReg.Name = "btnEmployeeReg"
        Me.btnEmployeeReg.Size = New System.Drawing.Size(247, 74)
        Me.btnEmployeeReg.TabIndex = 13
        Me.btnEmployeeReg.Text = "Employee Registration"
        Me.btnEmployeeReg.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(516, 618)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(415, 24)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "(Click Here to make Employee Account) "
        '
        'txtMaskPassword
        '
        Me.txtMaskPassword.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeAccountsBindingSource, "Password", True))
        Me.txtMaskPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaskPassword.Location = New System.Drawing.Point(665, 347)
        Me.txtMaskPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMaskPassword.Name = "txtMaskPassword"
        Me.txtMaskPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtMaskPassword.Size = New System.Drawing.Size(221, 28)
        Me.txtMaskPassword.TabIndex = 11
        '
        'EmployeeAccountsBindingSource
        '
        Me.EmployeeAccountsBindingSource.DataMember = "EmployeeAccounts"
        Me.EmployeeAccountsBindingSource.DataSource = Me.EzPassDBSystem
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.EzPass_Prototype_1.My.Resources.Resources.Database_Vector1
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(391, 47)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(107, 104)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Rockwell", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(492, 834)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(450, 24)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Reminder: Username and Password are case-sensitive."
        '
        'txtUsername
        '
        Me.txtUsername.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeAccountsBindingSource, "Username", True))
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(665, 264)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(221, 28)
        Me.txtUsername.TabIndex = 7
        '
        'btnLoginExit
        '
        Me.btnLoginExit.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnLoginExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLoginExit.Font = New System.Drawing.Font("Rockwell", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoginExit.Location = New System.Drawing.Point(152, 464)
        Me.btnLoginExit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLoginExit.Name = "btnLoginExit"
        Me.btnLoginExit.Size = New System.Drawing.Size(247, 74)
        Me.btnLoginExit.TabIndex = 6
        Me.btnLoginExit.Text = "Back to Main Menu"
        Me.btnLoginExit.UseVisualStyleBackColor = False
        '
        'btnLoginClear
        '
        Me.btnLoginClear.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnLoginClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLoginClear.Font = New System.Drawing.Font("Rockwell", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoginClear.Location = New System.Drawing.Point(600, 464)
        Me.btnLoginClear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLoginClear.Name = "btnLoginClear"
        Me.btnLoginClear.Size = New System.Drawing.Size(247, 74)
        Me.btnLoginClear.TabIndex = 5
        Me.btnLoginClear.Text = "Clear Fields"
        Me.btnLoginClear.UseVisualStyleBackColor = False
        '
        'btnLoginEnter
        '
        Me.btnLoginEnter.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnLoginEnter.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLoginEnter.Font = New System.Drawing.Font("Rockwell", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoginEnter.Location = New System.Drawing.Point(1022, 464)
        Me.btnLoginEnter.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLoginEnter.Name = "btnLoginEnter"
        Me.btnLoginEnter.Size = New System.Drawing.Size(247, 74)
        Me.btnLoginEnter.TabIndex = 4
        Me.btnLoginEnter.Text = "Enter Database"
        Me.btnLoginEnter.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(356, 347)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(213, 26)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Employee Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(356, 264)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(218, 26)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Employee Username"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(547, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(442, 43)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "EzPass Database System"
        '
        'PicVector
        '
        Me.PicVector.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicVector.Image = Global.EzPass_Prototype_1.My.Resources.Resources.EzPass_Vector
        Me.PicVector.Location = New System.Drawing.Point(30, 12)
        Me.PicVector.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PicVector.Name = "PicVector"
        Me.PicVector.Size = New System.Drawing.Size(134, 96)
        Me.PicVector.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicVector.TabIndex = 20
        Me.PicVector.TabStop = False
        '
        'CustomersInfoTableAdapter
        '
        Me.CustomersInfoTableAdapter.ClearBeforeFill = True
        '
        'EmployeeAccountsTableAdapter
        '
        Me.EmployeeAccountsTableAdapter.ClearBeforeFill = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Rockwell", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(25, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(228, 23)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Database Accessed By:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblEmplFirstName
        '
        Me.lblEmplFirstName.AutoSize = True
        Me.lblEmplFirstName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeAccountsBindingSource, "First Name", True))
        Me.lblEmplFirstName.Font = New System.Drawing.Font("Rockwell", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmplFirstName.Location = New System.Drawing.Point(276, 18)
        Me.lblEmplFirstName.Name = "lblEmplFirstName"
        Me.lblEmplFirstName.Size = New System.Drawing.Size(48, 23)
        Me.lblEmplFirstName.TabIndex = 30
        Me.lblEmplFirstName.Text = "@@"
        '
        'lblEmplLastName
        '
        Me.lblEmplLastName.AutoSize = True
        Me.lblEmplLastName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeAccountsBindingSource, "Last Name", True))
        Me.lblEmplLastName.Font = New System.Drawing.Font("Rockwell", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmplLastName.Location = New System.Drawing.Point(374, 18)
        Me.lblEmplLastName.Name = "lblEmplLastName"
        Me.lblEmplLastName.Size = New System.Drawing.Size(48, 23)
        Me.lblEmplLastName.TabIndex = 31
        Me.lblEmplLastName.Text = "@@"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Bisque
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.lblEmplFirstName)
        Me.Panel1.Controls.Add(Me.lblEmplLastName)
        Me.Panel1.Location = New System.Drawing.Point(848, 516)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(544, 55)
        Me.Panel1.TabIndex = 1
        '
        'grpDbLayout
        '
        Me.grpDbLayout.Controls.Add(Me.Panel1)
        Me.grpDbLayout.Controls.Add(Me.TabEntries)
        Me.grpDbLayout.Controls.Add(Me.btnUpdateTolls)
        Me.grpDbLayout.Controls.Add(Me.grpDatabase)
        Me.grpDbLayout.Controls.Add(Me.grpEntries)
        Me.grpDbLayout.Controls.Add(Me.btnTollMonitor)
        Me.grpDbLayout.Controls.Add(Me.btnTagMonitor)
        Me.grpDbLayout.Controls.Add(Me.PicVector)
        Me.grpDbLayout.Controls.Add(Me.LblTitle)
        Me.grpDbLayout.Location = New System.Drawing.Point(25, 4)
        Me.grpDbLayout.Name = "grpDbLayout"
        Me.grpDbLayout.Size = New System.Drawing.Size(1404, 913)
        Me.grpDbLayout.TabIndex = 29
        Me.grpDbLayout.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1452, 928)
        Me.Controls.Add(Me.grpLoginScreen)
        Me.Controls.Add(Me.grpDbLayout)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EzPass Database"
        Me.grpEntries.ResumeLayout(False)
        CType(Me.CustomersInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EzPassDBSystem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabAccounts.ResumeLayout(False)
        Me.grpTagInfo.ResumeLayout(False)
        Me.grpTagInfo.PerformLayout()
        Me.TabVehicles.ResumeLayout(False)
        Me.grpAccountInfo.ResumeLayout(False)
        Me.grpAccountInfo.PerformLayout()
        Me.TabCustomers.ResumeLayout(False)
        Me.grpCustomerInfo.ResumeLayout(False)
        Me.grpCustomerInfo.PerformLayout()
        Me.TabEntries.ResumeLayout(False)
        Me.grpDatabase.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLoginScreen.ResumeLayout(False)
        Me.grpLoginScreen.PerformLayout()
        CType(Me.EmployeeAccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicVector, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.grpDbLayout.ResumeLayout(False)
        Me.grpDbLayout.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LblTitle As Label
    Friend WithEvents btnNextRecord As Button
    Friend WithEvents btnDeleteRecord As Button
    Friend WithEvents btnExitProgram As Button
    Friend WithEvents grpEntries As GroupBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents PicVector As PictureBox
    Friend WithEvents btnClearField As Button
    Friend WithEvents cmbStanding As ComboBox
    Friend WithEvents txtAcctBalance As TextBox
    Friend WithEvents txtTagAcct As TextBox
    Friend WithEvents lblStanding As Label
    Friend WithEvents lblTagAccountNbr As Label
    Friend WithEvents lblAcctBalance As Label
    Friend WithEvents TabAccounts As TabPage
    Friend WithEvents grpTagInfo As GroupBox
    Friend WithEvents cmbTagStatus As ComboBox
    Friend WithEvents txtTagDateAssign As TextBox
    Friend WithEvents txtTagNbr As TextBox
    Friend WithEvents lblTagStatus As Label
    Friend WithEvents lblTagDateAssign As Label
    Friend WithEvents lblTagNbr As Label
    Friend WithEvents TabVehicles As TabPage
    Friend WithEvents grpAccountInfo As GroupBox
    Friend WithEvents txtRemovalDate As TextBox
    Friend WithEvents txtAddDate As TextBox
    Friend WithEvents lblRemovalDate As Label
    Friend WithEvents lblAddDate As Label
    Friend WithEvents txtPlateNbr As TextBox
    Friend WithEvents lblYear As Label
    Friend WithEvents lblModel As Label
    Friend WithEvents lblBodyStyle As Label
    Friend WithEvents lblPlateNbr As Label
    Friend WithEvents TabCustomers As TabPage
    Friend WithEvents grpCustomerInfo As GroupBox
    Friend WithEvents txtSignUp As TextBox
    Friend WithEvents lblSignUp As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents TabEntries As TabControl
    Friend WithEvents btnPreviousRecord As Button
    Friend WithEvents grpLoginScreen As GroupBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents btnLoginExit As Button
    Friend WithEvents btnLoginClear As Button
    Friend WithEvents btnLoginEnter As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblAcctGiven As Label
    Friend WithEvents btnUpdateField As Button
    Friend WithEvents btnTagMonitor As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents lblCardonFile As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents lblRemovalReason As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents txtDOB As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents grpDatabase As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents EzPassDBSystem As EzPassDBSystem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtMaskPassword As MaskedTextBox
    Friend WithEvents cmbEmModel As ComboBox
    Friend WithEvents cmbEmYear As ComboBox
    Friend WithEvents cmbEmBodyStyle As ComboBox
    Friend WithEvents btnTollMonitor As Button
    Friend WithEvents CustomersInfoBindingSource As BindingSource
    Friend WithEvents CustomersInfoTableAdapter As EzPassDBSystemTableAdapters.CustomersInfoTableAdapter
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateOfBirthDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhoneNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SignUpDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AccountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PlateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BodyStyleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ModelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VehicleYearDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RemovalDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RemovalReasonDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TagDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TagAccountIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TagDateAssignedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TagStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AccountBalanceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AccountStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CardOnFileDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TripsTakenDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnUpdateTolls As Button
    Friend WithEvents btnEmployeeReg As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents EmployeeAccountsBindingSource As BindingSource
    Friend WithEvents EmployeeAccountsTableAdapter As EzPassDBSystemTableAdapters.EmployeeAccountsTableAdapter
    Friend WithEvents Label7 As Label
    Friend WithEvents lblEmplFirstName As Label
    Friend WithEvents lblEmplLastName As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents grpDbLayout As GroupBox
End Class
