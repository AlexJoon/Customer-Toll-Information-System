<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form19
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnSecondBack = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblGrandClientRevenue = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DatClientRevenue = New System.Windows.Forms.DataGridView()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SignUpDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalClientRevenueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomersInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EzPassDBSystem = New EzPass_Prototype_1.EzPassDBSystem()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblGrandTollRevenue = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DatTollRevenue = New System.Windows.Forms.DataGridView()
        Me.TollCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TollNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FaresDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalTollRevenueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TollCodesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.EmployeeAccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblAccessedTime = New System.Windows.Forms.Label()
        Me.grpCredLogin = New System.Windows.Forms.GroupBox()
        Me.PicVector = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnEnterReports = New System.Windows.Forms.Button()
        Me.btnFirstBack = New System.Windows.Forms.Button()
        Me.txtDigitCode = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblEmplCode = New System.Windows.Forms.Label()
        Me.EmployeeAccountsTableAdapter = New EzPass_Prototype_1.EzPassDBSystemTableAdapters.EmployeeAccountsTableAdapter()
        Me.CustomersInfoTableAdapter = New EzPass_Prototype_1.EzPassDBSystemTableAdapters.CustomersInfoTableAdapter()
        Me.TollCodesTableAdapter = New EzPass_Prototype_1.EzPassDBSystemTableAdapters.TollCodesTableAdapter()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DatClientRevenue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EzPassDBSystem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DatTollRevenue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TollCodesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeAccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCredLogin.SuspendLayout()
        CType(Me.PicVector, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSecondBack
        '
        Me.btnSecondBack.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnSecondBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSecondBack.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSecondBack.Location = New System.Drawing.Point(126, 561)
        Me.btnSecondBack.Name = "btnSecondBack"
        Me.btnSecondBack.Size = New System.Drawing.Size(243, 75)
        Me.btnSecondBack.TabIndex = 0
        Me.btnSecondBack.Text = "Back to Transactions"
        Me.btnSecondBack.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Thistle
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(159, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(275, 38)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Revenue Reports"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(49, 131)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(995, 383)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.DatClientRevenue)
        Me.TabPage1.Location = New System.Drawing.Point(4, 33)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(987, 346)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Client Revenue"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Bisque
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblGrandClientRevenue)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(184, 269)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(604, 52)
        Me.Panel1.TabIndex = 3
        '
        'lblGrandClientRevenue
        '
        Me.lblGrandClientRevenue.AutoSize = True
        Me.lblGrandClientRevenue.Font = New System.Drawing.Font("Rockwell", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrandClientRevenue.Location = New System.Drawing.Point(478, 12)
        Me.lblGrandClientRevenue.Name = "lblGrandClientRevenue"
        Me.lblGrandClientRevenue.Size = New System.Drawing.Size(61, 29)
        Me.lblGrandClientRevenue.TabIndex = 2
        Me.lblGrandClientRevenue.Text = "@@"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(385, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Grand Total of Client Revenue :"
        '
        'DatClientRevenue
        '
        Me.DatClientRevenue.AutoGenerateColumns = False
        Me.DatClientRevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DatClientRevenue.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.SignUpDateDataGridViewTextBoxColumn, Me.AccountDataGridViewTextBoxColumn, Me.TotalClientRevenueDataGridViewTextBoxColumn})
        Me.DatClientRevenue.DataSource = Me.CustomersInfoBindingSource
        Me.DatClientRevenue.Location = New System.Drawing.Point(32, 18)
        Me.DatClientRevenue.Name = "DatClientRevenue"
        Me.DatClientRevenue.RowHeadersWidth = 51
        Me.DatClientRevenue.RowTemplate.Height = 24
        Me.DatClientRevenue.Size = New System.Drawing.Size(919, 226)
        Me.DatClientRevenue.TabIndex = 0
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        Me.FirstNameDataGridViewTextBoxColumn.Width = 125
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        Me.LastNameDataGridViewTextBoxColumn.Width = 125
        '
        'SignUpDateDataGridViewTextBoxColumn
        '
        Me.SignUpDateDataGridViewTextBoxColumn.DataPropertyName = "Sign-Up Date"
        Me.SignUpDateDataGridViewTextBoxColumn.HeaderText = "Sign-Up Date"
        Me.SignUpDateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SignUpDateDataGridViewTextBoxColumn.Name = "SignUpDateDataGridViewTextBoxColumn"
        Me.SignUpDateDataGridViewTextBoxColumn.Width = 125
        '
        'AccountDataGridViewTextBoxColumn
        '
        Me.AccountDataGridViewTextBoxColumn.DataPropertyName = "Account #"
        Me.AccountDataGridViewTextBoxColumn.HeaderText = "Account #"
        Me.AccountDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AccountDataGridViewTextBoxColumn.Name = "AccountDataGridViewTextBoxColumn"
        Me.AccountDataGridViewTextBoxColumn.Width = 125
        '
        'TotalClientRevenueDataGridViewTextBoxColumn
        '
        Me.TotalClientRevenueDataGridViewTextBoxColumn.DataPropertyName = "Total Client Revenue"
        Me.TotalClientRevenueDataGridViewTextBoxColumn.HeaderText = "Total Client Revenue"
        Me.TotalClientRevenueDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TotalClientRevenueDataGridViewTextBoxColumn.Name = "TotalClientRevenueDataGridViewTextBoxColumn"
        Me.TotalClientRevenueDataGridViewTextBoxColumn.Width = 125
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
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Panel2)
        Me.TabPage2.Controls.Add(Me.DatTollRevenue)
        Me.TabPage2.Location = New System.Drawing.Point(4, 33)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(987, 346)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Toll Revenue"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Bisque
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lblGrandTollRevenue)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Location = New System.Drawing.Point(184, 269)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(604, 52)
        Me.Panel2.TabIndex = 3
        '
        'lblGrandTollRevenue
        '
        Me.lblGrandTollRevenue.AutoSize = True
        Me.lblGrandTollRevenue.Font = New System.Drawing.Font("Rockwell", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrandTollRevenue.Location = New System.Drawing.Point(478, 12)
        Me.lblGrandTollRevenue.Name = "lblGrandTollRevenue"
        Me.lblGrandTollRevenue.Size = New System.Drawing.Size(61, 29)
        Me.lblGrandTollRevenue.TabIndex = 1
        Me.lblGrandTollRevenue.Text = "@@"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Rockwell", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(30, 12)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(353, 29)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Grand Total of Toll Revenue:"
        '
        'DatTollRevenue
        '
        Me.DatTollRevenue.AutoGenerateColumns = False
        Me.DatTollRevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DatTollRevenue.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TollCodeDataGridViewTextBoxColumn, Me.TollNameDataGridViewTextBoxColumn, Me.FaresDataGridViewTextBoxColumn, Me.TotalTollRevenueDataGridViewTextBoxColumn})
        Me.DatTollRevenue.DataSource = Me.TollCodesBindingSource
        Me.DatTollRevenue.Location = New System.Drawing.Point(32, 18)
        Me.DatTollRevenue.Name = "DatTollRevenue"
        Me.DatTollRevenue.RowHeadersWidth = 51
        Me.DatTollRevenue.RowTemplate.Height = 24
        Me.DatTollRevenue.Size = New System.Drawing.Size(919, 226)
        Me.DatTollRevenue.TabIndex = 2
        '
        'TollCodeDataGridViewTextBoxColumn
        '
        Me.TollCodeDataGridViewTextBoxColumn.DataPropertyName = "Toll Code"
        Me.TollCodeDataGridViewTextBoxColumn.HeaderText = "Toll Code"
        Me.TollCodeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TollCodeDataGridViewTextBoxColumn.Name = "TollCodeDataGridViewTextBoxColumn"
        Me.TollCodeDataGridViewTextBoxColumn.Width = 125
        '
        'TollNameDataGridViewTextBoxColumn
        '
        Me.TollNameDataGridViewTextBoxColumn.DataPropertyName = "Toll Name"
        Me.TollNameDataGridViewTextBoxColumn.HeaderText = "Toll Name"
        Me.TollNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TollNameDataGridViewTextBoxColumn.Name = "TollNameDataGridViewTextBoxColumn"
        Me.TollNameDataGridViewTextBoxColumn.Width = 125
        '
        'FaresDataGridViewTextBoxColumn
        '
        Me.FaresDataGridViewTextBoxColumn.DataPropertyName = "Fares"
        Me.FaresDataGridViewTextBoxColumn.HeaderText = "Fares"
        Me.FaresDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FaresDataGridViewTextBoxColumn.Name = "FaresDataGridViewTextBoxColumn"
        Me.FaresDataGridViewTextBoxColumn.Width = 125
        '
        'TotalTollRevenueDataGridViewTextBoxColumn
        '
        Me.TotalTollRevenueDataGridViewTextBoxColumn.DataPropertyName = "Total Toll Revenue"
        Me.TotalTollRevenueDataGridViewTextBoxColumn.HeaderText = "Total Toll Revenue"
        Me.TotalTollRevenueDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TotalTollRevenueDataGridViewTextBoxColumn.Name = "TotalTollRevenueDataGridViewTextBoxColumn"
        Me.TotalTollRevenueDataGridViewTextBoxColumn.Width = 125
        '
        'TollCodesBindingSource
        '
        Me.TollCodesBindingSource.DataMember = "TollCodes"
        Me.TollCodesBindingSource.DataSource = Me.EzPassDBSystem
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(612, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(366, 24)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Report Accessed by Sales Manager: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Rockwell", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(612, 559)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(230, 24)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Report Date Accessed:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeAccountsBindingSource, "First Name", True))
        Me.Label5.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(612, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 24)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "@@"
        '
        'EmployeeAccountsBindingSource
        '
        Me.EmployeeAccountsBindingSource.DataMember = "EmployeeAccounts"
        Me.EmployeeAccountsBindingSource.DataSource = Me.EzPassDBSystem
        '
        'lblAccessedTime
        '
        Me.lblAccessedTime.AutoSize = True
        Me.lblAccessedTime.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccessedTime.Location = New System.Drawing.Point(611, 607)
        Me.lblAccessedTime.Name = "lblAccessedTime"
        Me.lblAccessedTime.Size = New System.Drawing.Size(50, 24)
        Me.lblAccessedTime.TabIndex = 6
        Me.lblAccessedTime.Text = "@@"
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
        Me.grpCredLogin.Location = New System.Drawing.Point(12, 12)
        Me.grpCredLogin.Name = "grpCredLogin"
        Me.grpCredLogin.Size = New System.Drawing.Size(1070, 662)
        Me.grpCredLogin.TabIndex = 7
        Me.grpCredLogin.TabStop = False
        '
        'PicVector
        '
        Me.PicVector.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicVector.Image = Global.EzPass_Prototype_1.My.Resources.Resources.credentialVector
        Me.PicVector.Location = New System.Drawing.Point(285, 21)
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
        Me.Label10.Location = New System.Drawing.Point(204, 614)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(647, 25)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Reminder: Your credentials are the SAME as your Employee Login!"
        '
        'btnEnterReports
        '
        Me.btnEnterReports.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnEnterReports.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEnterReports.Font = New System.Drawing.Font("Rockwell", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnterReports.Location = New System.Drawing.Point(707, 468)
        Me.btnEnterReports.Name = "btnEnterReports"
        Me.btnEnterReports.Size = New System.Drawing.Size(230, 75)
        Me.btnEnterReports.TabIndex = 7
        Me.btnEnterReports.Text = "Enter Revenue Reports"
        Me.btnEnterReports.UseVisualStyleBackColor = False
        '
        'btnFirstBack
        '
        Me.btnFirstBack.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnFirstBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFirstBack.Font = New System.Drawing.Font("Rockwell", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFirstBack.Location = New System.Drawing.Point(131, 468)
        Me.btnFirstBack.Name = "btnFirstBack"
        Me.btnFirstBack.Size = New System.Drawing.Size(230, 75)
        Me.btnFirstBack.TabIndex = 5
        Me.btnFirstBack.Text = "Back to Transactions"
        Me.btnFirstBack.UseVisualStyleBackColor = False
        '
        'txtDigitCode
        '
        Me.txtDigitCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDigitCode.Location = New System.Drawing.Point(442, 311)
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
        Me.Label8.Location = New System.Drawing.Point(408, 248)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(250, 26)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Employee 4-Digit Code :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Thistle
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(412, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(343, 38)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Employee Credentials"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeAccountsBindingSource, "Last Name", True))
        Me.lblLastName.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.Location = New System.Drawing.Point(740, 99)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(50, 24)
        Me.lblLastName.TabIndex = 8
        Me.lblLastName.Text = "@@"
        '
        'lblEmplCode
        '
        Me.lblEmplCode.AutoSize = True
        Me.lblEmplCode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeAccountsBindingSource, "4-Digit Code", True))
        Me.lblEmplCode.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmplCode.Location = New System.Drawing.Point(912, 99)
        Me.lblEmplCode.Name = "lblEmplCode"
        Me.lblEmplCode.Size = New System.Drawing.Size(50, 24)
        Me.lblEmplCode.TabIndex = 9
        Me.lblEmplCode.Text = "@@"
        '
        'EmployeeAccountsTableAdapter
        '
        Me.EmployeeAccountsTableAdapter.ClearBeforeFill = True
        '
        'CustomersInfoTableAdapter
        '
        Me.CustomersInfoTableAdapter.ClearBeforeFill = True
        '
        'TollCodesTableAdapter
        '
        Me.TollCodesTableAdapter.ClearBeforeFill = True
        '
        'Form19
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1094, 686)
        Me.Controls.Add(Me.grpCredLogin)
        Me.Controls.Add(Me.lblEmplCode)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblAccessedTime)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSecondBack)
        Me.Name = "Form19"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Revenue Reports"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DatClientRevenue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EzPassDBSystem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DatTollRevenue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TollCodesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeAccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCredLogin.ResumeLayout(False)
        Me.grpCredLogin.PerformLayout()
        CType(Me.PicVector, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSecondBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents lblGrandClientRevenue As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DatClientRevenue As DataGridView
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblAccessedTime As Label
    Friend WithEvents grpCredLogin As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnEnterReports As Button
    Friend WithEvents btnFirstBack As Button
    Friend WithEvents txtDigitCode As TextBox
    Friend WithEvents PicVector As PictureBox
    Friend WithEvents DatTollRevenue As DataGridView
    Friend WithEvents lblGrandTollRevenue As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents EzPassDBSystem As EzPassDBSystem
    Friend WithEvents EmployeeAccountsBindingSource As BindingSource
    Friend WithEvents EmployeeAccountsTableAdapter As EzPassDBSystemTableAdapters.EmployeeAccountsTableAdapter
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblEmplCode As Label
    Friend WithEvents CustomersInfoBindingSource As BindingSource
    Friend WithEvents CustomersInfoTableAdapter As EzPassDBSystemTableAdapters.CustomersInfoTableAdapter
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SignUpDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AccountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalClientRevenueDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TollCodesBindingSource As BindingSource
    Friend WithEvents TollCodesTableAdapter As EzPassDBSystemTableAdapters.TollCodesTableAdapter
    Friend WithEvents TollCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TollNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FaresDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalTollRevenueDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class
