<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.lblLoginFirstNm = New System.Windows.Forms.Label()
        Me.lblLastNm = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtRegFirstName = New System.Windows.Forms.TextBox()
        Me.CustomersInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EzPassDBSystem = New EzPass_Prototype_1.EzPassDBSystem()
        Me.txtRegLastName = New System.Windows.Forms.TextBox()
        Me.txtRegAddress = New System.Windows.Forms.TextBox()
        Me.txtRegEmail = New System.Windows.Forms.TextBox()
        Me.txtRegSignUp = New System.Windows.Forms.TextBox()
        Me.txtRegAccountNbr = New System.Windows.Forms.TextBox()
        Me.BtnBackLogin = New System.Windows.Forms.Button()
        Me.btnCreateAccount = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtRegPlateNbr = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtRegTagNbr = New System.Windows.Forms.TextBox()
        Me.txtRegTagAccountID = New System.Windows.Forms.TextBox()
        Me.txtRegAcctBal = New System.Windows.Forms.TextBox()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.grpRegPerInfo = New System.Windows.Forms.GroupBox()
        Me.txtRegPhone = New System.Windows.Forms.TextBox()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.txtBirthDate = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAcctDate = New System.Windows.Forms.TextBox()
        Me.lblAcctDate = New System.Windows.Forms.Label()
        Me.txtRegCardFile = New System.Windows.Forms.TextBox()
        Me.lblRegCardFile = New System.Windows.Forms.Label()
        Me.grpRegVehInfo = New System.Windows.Forms.GroupBox()
        Me.cmbRegYear = New System.Windows.Forms.ComboBox()
        Me.cmbRegModel = New System.Windows.Forms.ComboBox()
        Me.cmbRegBodyStyle = New System.Windows.Forms.ComboBox()
        Me.grpRegTagInfo = New System.Windows.Forms.GroupBox()
        Me.RadPositiveAmt = New System.Windows.Forms.RadioButton()
        Me.RadNegativeAmt = New System.Windows.Forms.RadioButton()
        Me.btnAdd200 = New System.Windows.Forms.Button()
        Me.btnAdd100 = New System.Windows.Forms.Button()
        Me.btnAdd50 = New System.Windows.Forms.Button()
        Me.btnAdd25 = New System.Windows.Forms.Button()
        Me.txtRegTagStatus = New System.Windows.Forms.TextBox()
        Me.lblTagStatus = New System.Windows.Forms.Label()
        Me.txtAcctStatus = New System.Windows.Forms.TextBox()
        Me.lblAcctStatus = New System.Windows.Forms.Label()
        Me.txtRegTagDate = New System.Windows.Forms.TextBox()
        Me.lblRegTagDate = New System.Windows.Forms.Label()
        Me.CustomersInfoTableAdapter = New EzPass_Prototype_1.EzPassDBSystemTableAdapters.CustomersInfoTableAdapter()
        Me.btnClearFields = New System.Windows.Forms.Button()
        Me.grpInitialLogin = New System.Windows.Forms.GroupBox()
        Me.PicTollVector = New System.Windows.Forms.PictureBox()
        Me.lblTollTitle = New System.Windows.Forms.Label()
        Me.btnToll = New System.Windows.Forms.Button()
        Me.PicExitVector = New System.Windows.Forms.PictureBox()
        Me.PicReturnVector = New System.Windows.Forms.PictureBox()
        Me.lblReturnUsers = New System.Windows.Forms.Label()
        Me.btnUpdateAccount = New System.Windows.Forms.Button()
        Me.btnLoginQuit = New System.Windows.Forms.Button()
        Me.PicDbVector = New System.Windows.Forms.PictureBox()
        Me.btnEnterDb = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PicRegVector = New System.Windows.Forms.PictureBox()
        Me.btnEnterReg = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtClientRevenue = New System.Windows.Forms.TextBox()
        CType(Me.CustomersInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EzPassDBSystem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpRegPerInfo.SuspendLayout()
        Me.grpRegVehInfo.SuspendLayout()
        Me.grpRegTagInfo.SuspendLayout()
        Me.grpInitialLogin.SuspendLayout()
        CType(Me.PicTollVector, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicExitVector, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicReturnVector, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicDbVector, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicRegVector, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblLoginFirstNm
        '
        Me.lblLoginFirstNm.AutoSize = True
        Me.lblLoginFirstNm.Font = New System.Drawing.Font("Rockwell", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoginFirstNm.Location = New System.Drawing.Point(14, 25)
        Me.lblLoginFirstNm.Name = "lblLoginFirstNm"
        Me.lblLoginFirstNm.Size = New System.Drawing.Size(123, 23)
        Me.lblLoginFirstNm.TabIndex = 1
        Me.lblLoginFirstNm.Text = "First Name:"
        '
        'lblLastNm
        '
        Me.lblLastNm.AutoSize = True
        Me.lblLastNm.Font = New System.Drawing.Font("Rockwell", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastNm.Location = New System.Drawing.Point(14, 74)
        Me.lblLastNm.Name = "lblLastNm"
        Me.lblLastNm.Size = New System.Drawing.Size(118, 23)
        Me.lblLastNm.TabIndex = 2
        Me.lblLastNm.Text = "Last Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Rockwell", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 188)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 23)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Address:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Rockwell", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(44, 315)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 23)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Email:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Rockwell", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(14, 373)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(139, 23)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Sign-Up Date:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Rockwell", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(5, 430)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(174, 23)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Account # Given:"
        '
        'txtRegFirstName
        '
        Me.txtRegFirstName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "First Name", True))
        Me.txtRegFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegFirstName.Location = New System.Drawing.Point(217, 25)
        Me.txtRegFirstName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtRegFirstName.Name = "txtRegFirstName"
        Me.txtRegFirstName.Size = New System.Drawing.Size(198, 28)
        Me.txtRegFirstName.TabIndex = 2
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
        'txtRegLastName
        '
        Me.txtRegLastName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Last Name", True))
        Me.txtRegLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegLastName.Location = New System.Drawing.Point(217, 75)
        Me.txtRegLastName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtRegLastName.Name = "txtRegLastName"
        Me.txtRegLastName.Size = New System.Drawing.Size(198, 28)
        Me.txtRegLastName.TabIndex = 9
        '
        'txtRegAddress
        '
        Me.txtRegAddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Address", True))
        Me.txtRegAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegAddress.Location = New System.Drawing.Point(217, 190)
        Me.txtRegAddress.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtRegAddress.Name = "txtRegAddress"
        Me.txtRegAddress.Size = New System.Drawing.Size(198, 28)
        Me.txtRegAddress.TabIndex = 10
        '
        'txtRegEmail
        '
        Me.txtRegEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "E-mail", True))
        Me.txtRegEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegEmail.Location = New System.Drawing.Point(220, 310)
        Me.txtRegEmail.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtRegEmail.Name = "txtRegEmail"
        Me.txtRegEmail.Size = New System.Drawing.Size(198, 28)
        Me.txtRegEmail.TabIndex = 11
        '
        'txtRegSignUp
        '
        Me.txtRegSignUp.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Sign-Up Date", True))
        Me.txtRegSignUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegSignUp.Location = New System.Drawing.Point(248, 373)
        Me.txtRegSignUp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtRegSignUp.Name = "txtRegSignUp"
        Me.txtRegSignUp.ReadOnly = True
        Me.txtRegSignUp.Size = New System.Drawing.Size(144, 28)
        Me.txtRegSignUp.TabIndex = 13
        '
        'txtRegAccountNbr
        '
        Me.txtRegAccountNbr.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Account #", True))
        Me.txtRegAccountNbr.Enabled = False
        Me.txtRegAccountNbr.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegAccountNbr.Location = New System.Drawing.Point(276, 430)
        Me.txtRegAccountNbr.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtRegAccountNbr.Name = "txtRegAccountNbr"
        Me.txtRegAccountNbr.Size = New System.Drawing.Size(88, 28)
        Me.txtRegAccountNbr.TabIndex = 14
        '
        'BtnBackLogin
        '
        Me.BtnBackLogin.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BtnBackLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnBackLogin.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBackLogin.Location = New System.Drawing.Point(169, 732)
        Me.BtnBackLogin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnBackLogin.Name = "BtnBackLogin"
        Me.BtnBackLogin.Size = New System.Drawing.Size(215, 78)
        Me.BtnBackLogin.TabIndex = 0
        Me.BtnBackLogin.Text = "Back to Login Page"
        Me.BtnBackLogin.UseVisualStyleBackColor = False
        '
        'btnCreateAccount
        '
        Me.btnCreateAccount.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCreateAccount.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateAccount.Location = New System.Drawing.Point(777, 732)
        Me.btnCreateAccount.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCreateAccount.Name = "btnCreateAccount"
        Me.btnCreateAccount.Size = New System.Drawing.Size(215, 78)
        Me.btnCreateAccount.TabIndex = 16
        Me.btnCreateAccount.Text = "Create Your Account"
        Me.btnCreateAccount.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 23)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Plate # :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Rockwell", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 23)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Body Style:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Rockwell", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(11, 183)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(138, 23)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Vehicle Year:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Rockwell", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(83, 110)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(133, 23)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Tag # Given:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Rockwell", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(5, 265)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(311, 23)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Account Balance Deposited ($) :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Rockwell", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(68, 150)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(162, 23)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Tag Account ID:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(103, 18)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(270, 31)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "Personal Information"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(672, 18)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(253, 31)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "Vehicle Information"
        '
        'txtRegPlateNbr
        '
        Me.txtRegPlateNbr.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Plate #", True))
        Me.txtRegPlateNbr.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegPlateNbr.Location = New System.Drawing.Point(226, 22)
        Me.txtRegPlateNbr.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtRegPlateNbr.Name = "txtRegPlateNbr"
        Me.txtRegPlateNbr.Size = New System.Drawing.Size(198, 28)
        Me.txtRegPlateNbr.TabIndex = 25
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(672, 290)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(211, 31)
        Me.Label16.TabIndex = 28
        Me.Label16.Text = "Tag Information"
        '
        'txtRegTagNbr
        '
        Me.txtRegTagNbr.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Tag #", True))
        Me.txtRegTagNbr.Enabled = False
        Me.txtRegTagNbr.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegTagNbr.Location = New System.Drawing.Point(376, 110)
        Me.txtRegTagNbr.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtRegTagNbr.Name = "txtRegTagNbr"
        Me.txtRegTagNbr.Size = New System.Drawing.Size(91, 28)
        Me.txtRegTagNbr.TabIndex = 29
        '
        'txtRegTagAccountID
        '
        Me.txtRegTagAccountID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Tag Account ID", True))
        Me.txtRegTagAccountID.Enabled = False
        Me.txtRegTagAccountID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegTagAccountID.Location = New System.Drawing.Point(376, 151)
        Me.txtRegTagAccountID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtRegTagAccountID.Name = "txtRegTagAccountID"
        Me.txtRegTagAccountID.Size = New System.Drawing.Size(91, 28)
        Me.txtRegTagAccountID.TabIndex = 30
        '
        'txtRegAcctBal
        '
        Me.txtRegAcctBal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Account Balance", True))
        Me.txtRegAcctBal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegAcctBal.Location = New System.Drawing.Point(350, 265)
        Me.txtRegAcctBal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtRegAcctBal.Name = "txtRegAcctBal"
        Me.txtRegAcctBal.ReadOnly = True
        Me.txtRegAcctBal.Size = New System.Drawing.Size(144, 28)
        Me.txtRegAcctBal.TabIndex = 31
        '
        'lblModel
        '
        Me.lblModel.AutoSize = True
        Me.lblModel.Font = New System.Drawing.Font("Rockwell", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModel.Location = New System.Drawing.Point(18, 78)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(78, 23)
        Me.lblModel.TabIndex = 33
        Me.lblModel.Text = "Model:"
        '
        'grpRegPerInfo
        '
        Me.grpRegPerInfo.Controls.Add(Me.txtRegPhone)
        Me.grpRegPerInfo.Controls.Add(Me.lblPhone)
        Me.grpRegPerInfo.Controls.Add(Me.txtBirthDate)
        Me.grpRegPerInfo.Controls.Add(Me.Label7)
        Me.grpRegPerInfo.Controls.Add(Me.txtAcctDate)
        Me.grpRegPerInfo.Controls.Add(Me.lblAcctDate)
        Me.grpRegPerInfo.Controls.Add(Me.txtRegCardFile)
        Me.grpRegPerInfo.Controls.Add(Me.lblRegCardFile)
        Me.grpRegPerInfo.Controls.Add(Me.txtRegAccountNbr)
        Me.grpRegPerInfo.Controls.Add(Me.txtRegSignUp)
        Me.grpRegPerInfo.Controls.Add(Me.txtRegEmail)
        Me.grpRegPerInfo.Controls.Add(Me.txtRegAddress)
        Me.grpRegPerInfo.Controls.Add(Me.txtRegLastName)
        Me.grpRegPerInfo.Controls.Add(Me.txtRegFirstName)
        Me.grpRegPerInfo.Controls.Add(Me.Label8)
        Me.grpRegPerInfo.Controls.Add(Me.Label6)
        Me.grpRegPerInfo.Controls.Add(Me.Label5)
        Me.grpRegPerInfo.Controls.Add(Me.lblLastNm)
        Me.grpRegPerInfo.Controls.Add(Me.lblLoginFirstNm)
        Me.grpRegPerInfo.Controls.Add(Me.Label9)
        Me.grpRegPerInfo.Location = New System.Drawing.Point(25, 57)
        Me.grpRegPerInfo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpRegPerInfo.Name = "grpRegPerInfo"
        Me.grpRegPerInfo.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpRegPerInfo.Size = New System.Drawing.Size(441, 617)
        Me.grpRegPerInfo.TabIndex = 35
        Me.grpRegPerInfo.TabStop = False
        '
        'txtRegPhone
        '
        Me.txtRegPhone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Phone Number", True))
        Me.txtRegPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegPhone.Location = New System.Drawing.Point(220, 252)
        Me.txtRegPhone.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRegPhone.Name = "txtRegPhone"
        Me.txtRegPhone.Size = New System.Drawing.Size(198, 29)
        Me.txtRegPhone.TabIndex = 22
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Font = New System.Drawing.Font("Rockwell", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhone.Location = New System.Drawing.Point(7, 252)
        Me.lblPhone.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(159, 23)
        Me.lblPhone.TabIndex = 21
        Me.lblPhone.Text = "Phone Number:"
        '
        'txtBirthDate
        '
        Me.txtBirthDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Date of Birth", True))
        Me.txtBirthDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBirthDate.Location = New System.Drawing.Point(217, 132)
        Me.txtBirthDate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBirthDate.Name = "txtBirthDate"
        Me.txtBirthDate.Size = New System.Drawing.Size(198, 29)
        Me.txtBirthDate.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Rockwell", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(14, 130)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(142, 23)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Date Of Birth:"
        '
        'txtAcctDate
        '
        Me.txtAcctDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Add Date", True))
        Me.txtAcctDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAcctDate.Location = New System.Drawing.Point(244, 556)
        Me.txtAcctDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAcctDate.Name = "txtAcctDate"
        Me.txtAcctDate.ReadOnly = True
        Me.txtAcctDate.Size = New System.Drawing.Size(144, 28)
        Me.txtAcctDate.TabIndex = 18
        '
        'lblAcctDate
        '
        Me.lblAcctDate.AutoSize = True
        Me.lblAcctDate.Font = New System.Drawing.Font("Rockwell", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAcctDate.Location = New System.Drawing.Point(-4, 556)
        Me.lblAcctDate.Name = "lblAcctDate"
        Me.lblAcctDate.Size = New System.Drawing.Size(185, 23)
        Me.lblAcctDate.TabIndex = 17
        Me.lblAcctDate.Text = "Account Add Date:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtRegCardFile
        '
        Me.txtRegCardFile.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Card On File", True))
        Me.txtRegCardFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegCardFile.Location = New System.Drawing.Point(217, 494)
        Me.txtRegCardFile.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtRegCardFile.Name = "txtRegCardFile"
        Me.txtRegCardFile.Size = New System.Drawing.Size(198, 28)
        Me.txtRegCardFile.TabIndex = 16
        '
        'lblRegCardFile
        '
        Me.lblRegCardFile.AutoSize = True
        Me.lblRegCardFile.Font = New System.Drawing.Font("Rockwell", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegCardFile.Location = New System.Drawing.Point(13, 494)
        Me.lblRegCardFile.Name = "lblRegCardFile"
        Me.lblRegCardFile.Size = New System.Drawing.Size(139, 23)
        Me.lblRegCardFile.TabIndex = 15
        Me.lblRegCardFile.Text = "Card On File:"
        '
        'grpRegVehInfo
        '
        Me.grpRegVehInfo.Controls.Add(Me.cmbRegYear)
        Me.grpRegVehInfo.Controls.Add(Me.cmbRegModel)
        Me.grpRegVehInfo.Controls.Add(Me.cmbRegBodyStyle)
        Me.grpRegVehInfo.Controls.Add(Me.lblModel)
        Me.grpRegVehInfo.Controls.Add(Me.txtRegPlateNbr)
        Me.grpRegVehInfo.Controls.Add(Me.Label10)
        Me.grpRegVehInfo.Controls.Add(Me.Label3)
        Me.grpRegVehInfo.Controls.Add(Me.Label4)
        Me.grpRegVehInfo.Location = New System.Drawing.Point(579, 57)
        Me.grpRegVehInfo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpRegVehInfo.Name = "grpRegVehInfo"
        Me.grpRegVehInfo.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpRegVehInfo.Size = New System.Drawing.Size(456, 220)
        Me.grpRegVehInfo.TabIndex = 36
        Me.grpRegVehInfo.TabStop = False
        '
        'cmbRegYear
        '
        Me.cmbRegYear.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Vehicle Year", True))
        Me.cmbRegYear.DropDownHeight = 85
        Me.cmbRegYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRegYear.FormattingEnabled = True
        Me.cmbRegYear.IntegralHeight = False
        Me.cmbRegYear.ItemHeight = 22
        Me.cmbRegYear.Items.AddRange(New Object() {"Enter Vehicle Year", "2019", "2018", "2017", "2016", "2015", "2014", "2013", "2012", "2011", "2010", "2009", "2008", "2007", "2006", "2005", "2004", "2003", "2002", "2001", "2000", "1999", "1998", "1997", "1996", "1995"})
        Me.cmbRegYear.Location = New System.Drawing.Point(226, 182)
        Me.cmbRegYear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbRegYear.Name = "cmbRegYear"
        Me.cmbRegYear.Size = New System.Drawing.Size(198, 30)
        Me.cmbRegYear.TabIndex = 40
        '
        'cmbRegModel
        '
        Me.cmbRegModel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Model", True))
        Me.cmbRegModel.DropDownHeight = 85
        Me.cmbRegModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRegModel.FormattingEnabled = True
        Me.cmbRegModel.IntegralHeight = False
        Me.cmbRegModel.ItemHeight = 22
        Me.cmbRegModel.Items.AddRange(New Object() {"Select Model", "Acura", "Alfa Romeo", "Audi", "BMW", "Buick", "Cadillac", "Chevrolet", "Chrysler", "Dodge", "Fiat", "Ford", "GMC", "Honda", "Hyundai", "Infiniti", "Jaguar ", "Jeep", "Kia", "Lexus", "Lincoln", "Maserati", "Mazda", "Mercedes-Benz", "Mitsubishi", "Nissan", "Pontiac", "Porsche", "Subaru", "Toyota", "Tesla", "Volkswagen", "Volvo"})
        Me.cmbRegModel.Location = New System.Drawing.Point(226, 75)
        Me.cmbRegModel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbRegModel.Name = "cmbRegModel"
        Me.cmbRegModel.Size = New System.Drawing.Size(198, 30)
        Me.cmbRegModel.TabIndex = 40
        '
        'cmbRegBodyStyle
        '
        Me.cmbRegBodyStyle.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Body Style", True))
        Me.cmbRegBodyStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRegBodyStyle.FormattingEnabled = True
        Me.cmbRegBodyStyle.IntegralHeight = False
        Me.cmbRegBodyStyle.ItemHeight = 22
        Me.cmbRegBodyStyle.Items.AddRange(New Object() {"Select Style", "SUV", "Mini-Van", "Truck", "Sedan"})
        Me.cmbRegBodyStyle.Location = New System.Drawing.Point(226, 130)
        Me.cmbRegBodyStyle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbRegBodyStyle.Name = "cmbRegBodyStyle"
        Me.cmbRegBodyStyle.Size = New System.Drawing.Size(198, 30)
        Me.cmbRegBodyStyle.TabIndex = 38
        '
        'grpRegTagInfo
        '
        Me.grpRegTagInfo.Controls.Add(Me.RadPositiveAmt)
        Me.grpRegTagInfo.Controls.Add(Me.RadNegativeAmt)
        Me.grpRegTagInfo.Controls.Add(Me.btnAdd200)
        Me.grpRegTagInfo.Controls.Add(Me.btnAdd100)
        Me.grpRegTagInfo.Controls.Add(Me.btnAdd50)
        Me.grpRegTagInfo.Controls.Add(Me.btnAdd25)
        Me.grpRegTagInfo.Controls.Add(Me.txtRegTagStatus)
        Me.grpRegTagInfo.Controls.Add(Me.lblTagStatus)
        Me.grpRegTagInfo.Controls.Add(Me.txtAcctStatus)
        Me.grpRegTagInfo.Controls.Add(Me.lblAcctStatus)
        Me.grpRegTagInfo.Controls.Add(Me.txtRegTagDate)
        Me.grpRegTagInfo.Controls.Add(Me.lblRegTagDate)
        Me.grpRegTagInfo.Controls.Add(Me.txtRegAcctBal)
        Me.grpRegTagInfo.Controls.Add(Me.txtRegTagAccountID)
        Me.grpRegTagInfo.Controls.Add(Me.txtRegTagNbr)
        Me.grpRegTagInfo.Controls.Add(Me.Label12)
        Me.grpRegTagInfo.Controls.Add(Me.Label13)
        Me.grpRegTagInfo.Controls.Add(Me.Label11)
        Me.grpRegTagInfo.Location = New System.Drawing.Point(501, 337)
        Me.grpRegTagInfo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpRegTagInfo.Name = "grpRegTagInfo"
        Me.grpRegTagInfo.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpRegTagInfo.Size = New System.Drawing.Size(603, 370)
        Me.grpRegTagInfo.TabIndex = 37
        Me.grpRegTagInfo.TabStop = False
        '
        'RadPositiveAmt
        '
        Me.RadPositiveAmt.AutoSize = True
        Me.RadPositiveAmt.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadPositiveAmt.Location = New System.Drawing.Point(544, 258)
        Me.RadPositiveAmt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadPositiveAmt.Name = "RadPositiveAmt"
        Me.RadPositiveAmt.Size = New System.Drawing.Size(51, 33)
        Me.RadPositiveAmt.TabIndex = 42
        Me.RadPositiveAmt.TabStop = True
        Me.RadPositiveAmt.Text = "+"
        Me.RadPositiveAmt.UseVisualStyleBackColor = True
        '
        'RadNegativeAmt
        '
        Me.RadNegativeAmt.AutoSize = True
        Me.RadNegativeAmt.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadNegativeAmt.Location = New System.Drawing.Point(544, 309)
        Me.RadNegativeAmt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadNegativeAmt.Name = "RadNegativeAmt"
        Me.RadNegativeAmt.Size = New System.Drawing.Size(43, 33)
        Me.RadNegativeAmt.TabIndex = 43
        Me.RadNegativeAmt.TabStop = True
        Me.RadNegativeAmt.Text = "-"
        Me.RadNegativeAmt.UseVisualStyleBackColor = True
        '
        'btnAdd200
        '
        Me.btnAdd200.BackColor = System.Drawing.Color.Khaki
        Me.btnAdd200.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd200.Font = New System.Drawing.Font("Rockwell", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd200.Location = New System.Drawing.Point(424, 318)
        Me.btnAdd200.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAdd200.Name = "btnAdd200"
        Me.btnAdd200.Size = New System.Drawing.Size(92, 36)
        Me.btnAdd200.TabIndex = 41
        Me.btnAdd200.Text = "$ 200"
        Me.btnAdd200.UseVisualStyleBackColor = False
        '
        'btnAdd100
        '
        Me.btnAdd100.BackColor = System.Drawing.Color.Khaki
        Me.btnAdd100.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd100.Font = New System.Drawing.Font("Rockwell", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd100.Location = New System.Drawing.Point(293, 318)
        Me.btnAdd100.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAdd100.Name = "btnAdd100"
        Me.btnAdd100.Size = New System.Drawing.Size(92, 36)
        Me.btnAdd100.TabIndex = 40
        Me.btnAdd100.Text = "$ 100"
        Me.btnAdd100.UseVisualStyleBackColor = False
        '
        'btnAdd50
        '
        Me.btnAdd50.BackColor = System.Drawing.Color.Khaki
        Me.btnAdd50.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd50.Font = New System.Drawing.Font("Rockwell", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd50.Location = New System.Drawing.Point(153, 318)
        Me.btnAdd50.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAdd50.Name = "btnAdd50"
        Me.btnAdd50.Size = New System.Drawing.Size(92, 36)
        Me.btnAdd50.TabIndex = 39
        Me.btnAdd50.Text = "$ 50"
        Me.btnAdd50.UseVisualStyleBackColor = False
        '
        'btnAdd25
        '
        Me.btnAdd25.BackColor = System.Drawing.Color.Khaki
        Me.btnAdd25.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd25.Font = New System.Drawing.Font("Rockwell", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd25.Location = New System.Drawing.Point(20, 318)
        Me.btnAdd25.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAdd25.Name = "btnAdd25"
        Me.btnAdd25.Size = New System.Drawing.Size(92, 36)
        Me.btnAdd25.TabIndex = 38
        Me.btnAdd25.Text = "$ 25"
        Me.btnAdd25.UseVisualStyleBackColor = False
        '
        'txtRegTagStatus
        '
        Me.txtRegTagStatus.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Tag Status", True))
        Me.txtRegTagStatus.Enabled = False
        Me.txtRegTagStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegTagStatus.Location = New System.Drawing.Point(327, 26)
        Me.txtRegTagStatus.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtRegTagStatus.Name = "txtRegTagStatus"
        Me.txtRegTagStatus.Size = New System.Drawing.Size(188, 28)
        Me.txtRegTagStatus.TabIndex = 37
        '
        'lblTagStatus
        '
        Me.lblTagStatus.AutoSize = True
        Me.lblTagStatus.Font = New System.Drawing.Font("Rockwell", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTagStatus.Location = New System.Drawing.Point(88, 28)
        Me.lblTagStatus.Name = "lblTagStatus"
        Me.lblTagStatus.Size = New System.Drawing.Size(115, 23)
        Me.lblTagStatus.TabIndex = 36
        Me.lblTagStatus.Text = "Tag Status:"
        '
        'txtAcctStatus
        '
        Me.txtAcctStatus.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Account Status", True))
        Me.txtAcctStatus.Enabled = False
        Me.txtAcctStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAcctStatus.Location = New System.Drawing.Point(327, 206)
        Me.txtAcctStatus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAcctStatus.Name = "txtAcctStatus"
        Me.txtAcctStatus.Size = New System.Drawing.Size(188, 28)
        Me.txtAcctStatus.TabIndex = 35
        '
        'lblAcctStatus
        '
        Me.lblAcctStatus.AutoSize = True
        Me.lblAcctStatus.Font = New System.Drawing.Font("Rockwell", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAcctStatus.Location = New System.Drawing.Point(57, 206)
        Me.lblAcctStatus.Name = "lblAcctStatus"
        Me.lblAcctStatus.Size = New System.Drawing.Size(182, 23)
        Me.lblAcctStatus.TabIndex = 34
        Me.lblAcctStatus.Text = "Account Standing:"
        '
        'txtRegTagDate
        '
        Me.txtRegTagDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Tag Date Assigned", True))
        Me.txtRegTagDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegTagDate.Location = New System.Drawing.Point(350, 70)
        Me.txtRegTagDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtRegTagDate.Name = "txtRegTagDate"
        Me.txtRegTagDate.ReadOnly = True
        Me.txtRegTagDate.Size = New System.Drawing.Size(144, 28)
        Me.txtRegTagDate.TabIndex = 33
        '
        'lblRegTagDate
        '
        Me.lblRegTagDate.AutoSize = True
        Me.lblRegTagDate.Font = New System.Drawing.Font("Rockwell", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegTagDate.Location = New System.Drawing.Point(68, 70)
        Me.lblRegTagDate.Name = "lblRegTagDate"
        Me.lblRegTagDate.Size = New System.Drawing.Size(171, 23)
        Me.lblRegTagDate.TabIndex = 32
        Me.lblRegTagDate.Text = "Tag Assign Date:"
        '
        'CustomersInfoTableAdapter
        '
        Me.CustomersInfoTableAdapter.ClearBeforeFill = True
        '
        'btnClearFields
        '
        Me.btnClearFields.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnClearFields.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClearFields.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearFields.Location = New System.Drawing.Point(471, 732)
        Me.btnClearFields.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClearFields.Name = "btnClearFields"
        Me.btnClearFields.Size = New System.Drawing.Size(215, 78)
        Me.btnClearFields.TabIndex = 39
        Me.btnClearFields.Text = "Clear Fields"
        Me.btnClearFields.UseVisualStyleBackColor = False
        '
        'grpInitialLogin
        '
        Me.grpInitialLogin.BackgroundImage = Global.EzPass_Prototype_1.My.Resources.Resources.Ezpass_Registration_Login_Background
        Me.grpInitialLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.grpInitialLogin.Controls.Add(Me.PicTollVector)
        Me.grpInitialLogin.Controls.Add(Me.lblTollTitle)
        Me.grpInitialLogin.Controls.Add(Me.btnToll)
        Me.grpInitialLogin.Controls.Add(Me.PicExitVector)
        Me.grpInitialLogin.Controls.Add(Me.PicReturnVector)
        Me.grpInitialLogin.Controls.Add(Me.lblReturnUsers)
        Me.grpInitialLogin.Controls.Add(Me.btnUpdateAccount)
        Me.grpInitialLogin.Controls.Add(Me.btnLoginQuit)
        Me.grpInitialLogin.Controls.Add(Me.PicDbVector)
        Me.grpInitialLogin.Controls.Add(Me.btnEnterDb)
        Me.grpInitialLogin.Controls.Add(Me.Label2)
        Me.grpInitialLogin.Controls.Add(Me.PicRegVector)
        Me.grpInitialLogin.Controls.Add(Me.btnEnterReg)
        Me.grpInitialLogin.Controls.Add(Me.Label1)
        Me.grpInitialLogin.Location = New System.Drawing.Point(7, 11)
        Me.grpInitialLogin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpInitialLogin.Name = "grpInitialLogin"
        Me.grpInitialLogin.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpInitialLogin.Size = New System.Drawing.Size(1122, 838)
        Me.grpInitialLogin.TabIndex = 32
        Me.grpInitialLogin.TabStop = False
        '
        'PicTollVector
        '
        Me.PicTollVector.BackgroundImage = Global.EzPass_Prototype_1.My.Resources.Resources.Toll_Vector
        Me.PicTollVector.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicTollVector.Location = New System.Drawing.Point(569, 326)
        Me.PicTollVector.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PicTollVector.Name = "PicTollVector"
        Me.PicTollVector.Size = New System.Drawing.Size(110, 93)
        Me.PicTollVector.TabIndex = 13
        Me.PicTollVector.TabStop = False
        '
        'lblTollTitle
        '
        Me.lblTollTitle.AutoSize = True
        Me.lblTollTitle.BackColor = System.Drawing.Color.LightCoral
        Me.lblTollTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTollTitle.Font = New System.Drawing.Font("Tahoma", 16.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTollTitle.Location = New System.Drawing.Point(727, 363)
        Me.lblTollTitle.Name = "lblTollTitle"
        Me.lblTollTitle.Size = New System.Drawing.Size(293, 35)
        Me.lblTollTitle.TabIndex = 12
        Me.lblTollTitle.Text = "EzPass Toll Crossing"
        '
        'btnToll
        '
        Me.btnToll.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnToll.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnToll.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnToll.Location = New System.Drawing.Point(761, 454)
        Me.btnToll.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnToll.Name = "btnToll"
        Me.btnToll.Size = New System.Drawing.Size(220, 73)
        Me.btnToll.TabIndex = 11
        Me.btnToll.Text = "Enter Toll"
        Me.btnToll.UseVisualStyleBackColor = False
        '
        'PicExitVector
        '
        Me.PicExitVector.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicExitVector.Image = Global.EzPass_Prototype_1.My.Resources.Resources._Exit
        Me.PicExitVector.Location = New System.Drawing.Point(517, 578)
        Me.PicExitVector.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PicExitVector.Name = "PicExitVector"
        Me.PicExitVector.Size = New System.Drawing.Size(102, 87)
        Me.PicExitVector.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicExitVector.TabIndex = 10
        Me.PicExitVector.TabStop = False
        '
        'PicReturnVector
        '
        Me.PicReturnVector.BackgroundImage = Global.EzPass_Prototype_1.My.Resources.Resources.ReturnUsers_Vector
        Me.PicReturnVector.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicReturnVector.Location = New System.Drawing.Point(14, 326)
        Me.PicReturnVector.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PicReturnVector.Name = "PicReturnVector"
        Me.PicReturnVector.Size = New System.Drawing.Size(110, 93)
        Me.PicReturnVector.TabIndex = 9
        Me.PicReturnVector.TabStop = False
        '
        'lblReturnUsers
        '
        Me.lblReturnUsers.AutoSize = True
        Me.lblReturnUsers.BackColor = System.Drawing.Color.BurlyWood
        Me.lblReturnUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblReturnUsers.Font = New System.Drawing.Font("Tahoma", 16.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReturnUsers.Location = New System.Drawing.Point(149, 363)
        Me.lblReturnUsers.Name = "lblReturnUsers"
        Me.lblReturnUsers.Size = New System.Drawing.Size(236, 35)
        Me.lblReturnUsers.TabIndex = 8
        Me.lblReturnUsers.Text = "Returning Users"
        '
        'btnUpdateAccount
        '
        Me.btnUpdateAccount.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnUpdateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUpdateAccount.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateAccount.Location = New System.Drawing.Point(149, 454)
        Me.btnUpdateAccount.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnUpdateAccount.Name = "btnUpdateAccount"
        Me.btnUpdateAccount.Size = New System.Drawing.Size(220, 73)
        Me.btnUpdateAccount.TabIndex = 7
        Me.btnUpdateAccount.Text = "Update Account"
        Me.btnUpdateAccount.UseVisualStyleBackColor = False
        '
        'btnLoginQuit
        '
        Me.btnLoginQuit.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnLoginQuit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLoginQuit.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoginQuit.Location = New System.Drawing.Point(455, 690)
        Me.btnLoginQuit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLoginQuit.Name = "btnLoginQuit"
        Me.btnLoginQuit.Size = New System.Drawing.Size(220, 73)
        Me.btnLoginQuit.TabIndex = 3
        Me.btnLoginQuit.Text = "Quit Application"
        Me.btnLoginQuit.UseVisualStyleBackColor = False
        '
        'PicDbVector
        '
        Me.PicDbVector.BackgroundImage = Global.EzPass_Prototype_1.My.Resources.Resources.Database_Vector1
        Me.PicDbVector.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicDbVector.Location = New System.Drawing.Point(569, 73)
        Me.PicDbVector.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PicDbVector.Name = "PicDbVector"
        Me.PicDbVector.Size = New System.Drawing.Size(105, 105)
        Me.PicDbVector.TabIndex = 6
        Me.PicDbVector.TabStop = False
        '
        'btnEnterDb
        '
        Me.btnEnterDb.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnEnterDb.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEnterDb.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnterDb.Location = New System.Drawing.Point(761, 196)
        Me.btnEnterDb.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEnterDb.Name = "btnEnterDb"
        Me.btnEnterDb.Size = New System.Drawing.Size(220, 73)
        Me.btnEnterDb.TabIndex = 2
        Me.btnEnterDb.Text = "Enter Database"
        Me.btnEnterDb.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 16.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(711, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(341, 35)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "EzPass Employee Portal"
        '
        'PicRegVector
        '
        Me.PicRegVector.BackgroundImage = Global.EzPass_Prototype_1.My.Resources.Resources.EzPass_Registration_Vector1
        Me.PicRegVector.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicRegVector.Location = New System.Drawing.Point(14, 73)
        Me.PicRegVector.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PicRegVector.Name = "PicRegVector"
        Me.PicRegVector.Size = New System.Drawing.Size(98, 105)
        Me.PicRegVector.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PicRegVector.TabIndex = 5
        Me.PicRegVector.TabStop = False
        '
        'btnEnterReg
        '
        Me.btnEnterReg.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnEnterReg.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEnterReg.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnterReg.Location = New System.Drawing.Point(158, 196)
        Me.btnEnterReg.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEnterReg.Name = "btnEnterReg"
        Me.btnEnterReg.Size = New System.Drawing.Size(220, 73)
        Me.btnEnterReg.TabIndex = 4
        Me.btnEnterReg.Text = "Enter Registration Form"
        Me.btnEnterReg.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 16.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(135, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(285, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "EzPass Registration"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(735, 486)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(104, 17)
        Me.Label17.TabIndex = 40
        Me.Label17.Text = "Client Revenue"
        '
        'txtClientRevenue
        '
        Me.txtClientRevenue.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Total Client Revenue", True))
        Me.txtClientRevenue.Location = New System.Drawing.Point(738, 521)
        Me.txtClientRevenue.Name = "txtClientRevenue"
        Me.txtClientRevenue.Size = New System.Drawing.Size(100, 22)
        Me.txtClientRevenue.TabIndex = 41
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1141, 844)
        Me.Controls.Add(Me.grpInitialLogin)
        Me.Controls.Add(Me.grpRegTagInfo)
        Me.Controls.Add(Me.txtClientRevenue)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.btnClearFields)
        Me.Controls.Add(Me.grpRegVehInfo)
        Me.Controls.Add(Me.grpRegPerInfo)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.btnCreateAccount)
        Me.Controls.Add(Me.BtnBackLogin)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximumSize = New System.Drawing.Size(1332, 957)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EzPass Login"
        CType(Me.CustomersInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EzPassDBSystem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpRegPerInfo.ResumeLayout(False)
        Me.grpRegPerInfo.PerformLayout()
        Me.grpRegVehInfo.ResumeLayout(False)
        Me.grpRegVehInfo.PerformLayout()
        Me.grpRegTagInfo.ResumeLayout(False)
        Me.grpRegTagInfo.PerformLayout()
        Me.grpInitialLogin.ResumeLayout(False)
        Me.grpInitialLogin.PerformLayout()
        CType(Me.PicTollVector, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicExitVector, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicReturnVector, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicDbVector, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicRegVector, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblLoginFirstNm As Label
    Friend WithEvents lblLastNm As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtRegFirstName As TextBox
    Friend WithEvents txtRegLastName As TextBox
    Friend WithEvents txtRegAddress As TextBox
    Friend WithEvents txtRegEmail As TextBox
    Friend WithEvents txtRegSignUp As TextBox
    Friend WithEvents txtRegAccountNbr As TextBox
    Friend WithEvents BtnBackLogin As Button
    Friend WithEvents btnCreateAccount As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtRegPlateNbr As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtRegTagNbr As TextBox
    Friend WithEvents txtRegTagAccountID As TextBox
    Friend WithEvents txtRegAcctBal As TextBox
    Friend WithEvents lblModel As Label
    Friend WithEvents grpInitialLogin As GroupBox
    Friend WithEvents PicReturnVector As PictureBox
    Friend WithEvents lblReturnUsers As Label
    Friend WithEvents btnUpdateAccount As Button
    Friend WithEvents btnLoginQuit As Button
    Friend WithEvents PicDbVector As PictureBox
    Friend WithEvents btnEnterDb As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents PicRegVector As PictureBox
    Friend WithEvents btnEnterReg As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents grpRegPerInfo As GroupBox
    Friend WithEvents grpRegVehInfo As GroupBox
    Friend WithEvents grpRegTagInfo As GroupBox
    Friend WithEvents txtRegCardFile As TextBox
    Friend WithEvents lblRegCardFile As Label
    Friend WithEvents txtAcctStatus As TextBox
    Friend WithEvents lblAcctStatus As Label
    Friend WithEvents txtRegTagDate As TextBox
    Friend WithEvents lblRegTagDate As Label
    Friend WithEvents txtAcctDate As TextBox
    Friend WithEvents lblAcctDate As Label
    Friend WithEvents txtRegTagStatus As TextBox
    Friend WithEvents lblTagStatus As Label
    Friend WithEvents PicExitVector As PictureBox
    Friend WithEvents btnAdd200 As Button
    Friend WithEvents btnAdd100 As Button
    Friend WithEvents btnAdd50 As Button
    Friend WithEvents btnAdd25 As Button
    Friend WithEvents txtBirthDate As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtRegPhone As TextBox
    Friend WithEvents lblPhone As Label
    Friend WithEvents EzPassDBSystem As EzPassDBSystem
    Friend WithEvents CustomersInfoBindingSource As BindingSource
    Friend WithEvents CustomersInfoTableAdapter As EzPassDBSystemTableAdapters.CustomersInfoTableAdapter
    Friend WithEvents RadPositiveAmt As RadioButton
    Friend WithEvents RadNegativeAmt As RadioButton
    Friend WithEvents cmbRegBodyStyle As ComboBox
    Friend WithEvents btnClearFields As Button
    Friend WithEvents cmbRegModel As ComboBox
    Friend WithEvents cmbRegYear As ComboBox
    Friend WithEvents lblTollTitle As Label
    Friend WithEvents btnToll As Button
    Friend WithEvents PicTollVector As PictureBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtClientRevenue As TextBox
End Class
