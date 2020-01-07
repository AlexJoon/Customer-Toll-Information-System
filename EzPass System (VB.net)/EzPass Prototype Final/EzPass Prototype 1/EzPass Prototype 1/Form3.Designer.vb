<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Me.btnUpdateBack = New System.Windows.Forms.Button()
        Me.btnSaveChanges = New System.Windows.Forms.Button()
        Me.lblUpdateFields = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtUpdateFirstNm = New System.Windows.Forms.TextBox()
        Me.CustomersInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EzPassDBSystem = New EzPass_Prototype_1.EzPassDBSystem()
        Me.txtUpdateLastNm = New System.Windows.Forms.TextBox()
        Me.txtUpdateAddress = New System.Windows.Forms.TextBox()
        Me.txtUpdateEmail = New System.Windows.Forms.TextBox()
        Me.txtUpdateAcctBal = New System.Windows.Forms.TextBox()
        Me.txtUpdatePlate = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.grpUpdateFieldsForm = New System.Windows.Forms.GroupBox()
        Me.lblAcctStatus = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnTolls = New System.Windows.Forms.Button()
        Me.cmbUpYear = New System.Windows.Forms.ComboBox()
        Me.cmbUpModel = New System.Windows.Forms.ComboBox()
        Me.cmbUpBodyStyle = New System.Windows.Forms.ComboBox()
        Me.RadNegativeAmt = New System.Windows.Forms.RadioButton()
        Me.RadPositiveAmt = New System.Windows.Forms.RadioButton()
        Me.txtUpdatePhone = New System.Windows.Forms.TextBox()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.btnAdd200 = New System.Windows.Forms.Button()
        Me.btnAdd100 = New System.Windows.Forms.Button()
        Me.btnAdd50 = New System.Windows.Forms.Button()
        Me.btnAdd25 = New System.Windows.Forms.Button()
        Me.btnReportTag = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblAccessedDate = New System.Windows.Forms.Label()
        Me.txtUpdateCard = New System.Windows.Forms.TextBox()
        Me.lblUpdateCard = New System.Windows.Forms.Label()
        Me.DatUpdateOverview = New System.Windows.Forms.DataGridView()
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
        Me.CustomersInfoTableAdapter = New EzPass_Prototype_1.EzPassDBSystemTableAdapters.CustomersInfoTableAdapter()
        Me.grpUpdateAcct = New System.Windows.Forms.GroupBox()
        Me.btnFindAcct = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnUpdateBackLogin = New System.Windows.Forms.Button()
        Me.lblAcctQuestion = New System.Windows.Forms.Label()
        Me.txtAcctSearch = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblUpdateUserInfo = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        CType(Me.CustomersInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EzPassDBSystem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpUpdateFieldsForm.SuspendLayout()
        CType(Me.DatUpdateOverview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpUpdateAcct.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnUpdateBack
        '
        Me.btnUpdateBack.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnUpdateBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUpdateBack.Font = New System.Drawing.Font("Rockwell", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateBack.Location = New System.Drawing.Point(217, 709)
        Me.btnUpdateBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnUpdateBack.Name = "btnUpdateBack"
        Me.btnUpdateBack.Size = New System.Drawing.Size(215, 78)
        Me.btnUpdateBack.TabIndex = 0
        Me.btnUpdateBack.Text = "Back to Account Login"
        Me.btnUpdateBack.UseVisualStyleBackColor = False
        '
        'btnSaveChanges
        '
        Me.btnSaveChanges.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSaveChanges.Font = New System.Drawing.Font("Rockwell", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveChanges.Location = New System.Drawing.Point(696, 709)
        Me.btnSaveChanges.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSaveChanges.Name = "btnSaveChanges"
        Me.btnSaveChanges.Size = New System.Drawing.Size(215, 78)
        Me.btnSaveChanges.TabIndex = 1
        Me.btnSaveChanges.Text = "Save Changes"
        Me.btnSaveChanges.UseVisualStyleBackColor = False
        '
        'lblUpdateFields
        '
        Me.lblUpdateFields.AutoSize = True
        Me.lblUpdateFields.BackColor = System.Drawing.Color.PaleGreen
        Me.lblUpdateFields.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblUpdateFields.Font = New System.Drawing.Font("Tahoma", 16.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUpdateFields.Location = New System.Drawing.Point(448, 18)
        Me.lblUpdateFields.Name = "lblUpdateFields"
        Me.lblUpdateFields.Size = New System.Drawing.Size(201, 35)
        Me.lblUpdateFields.TabIndex = 2
        Me.lblUpdateFields.Text = "Update Fields"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Update First Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 182)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(189, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Update Last Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 234)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(165, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Update Address:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Rockwell", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(30, 342)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(160, 23)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Update Plate # :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Rockwell", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(30, 393)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(149, 23)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Update Model:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Rockwell", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(563, 132)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(209, 23)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Update Vehicle Year:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Rockwell", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(564, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(186, 23)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Update Body Style:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Rockwell", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(28, 438)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(246, 23)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Update Account Balance:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Rockwell", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(34, 290)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(145, 23)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Update Email:"
        '
        'txtUpdateFirstNm
        '
        Me.txtUpdateFirstNm.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "First Name", True))
        Me.txtUpdateFirstNm.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUpdateFirstNm.Location = New System.Drawing.Point(309, 126)
        Me.txtUpdateFirstNm.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtUpdateFirstNm.Name = "txtUpdateFirstNm"
        Me.txtUpdateFirstNm.Size = New System.Drawing.Size(203, 28)
        Me.txtUpdateFirstNm.TabIndex = 1
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
        'txtUpdateLastNm
        '
        Me.txtUpdateLastNm.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Last Name", True))
        Me.txtUpdateLastNm.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUpdateLastNm.Location = New System.Drawing.Point(309, 180)
        Me.txtUpdateLastNm.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtUpdateLastNm.Name = "txtUpdateLastNm"
        Me.txtUpdateLastNm.Size = New System.Drawing.Size(203, 28)
        Me.txtUpdateLastNm.TabIndex = 13
        '
        'txtUpdateAddress
        '
        Me.txtUpdateAddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Address", True))
        Me.txtUpdateAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUpdateAddress.Location = New System.Drawing.Point(309, 233)
        Me.txtUpdateAddress.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtUpdateAddress.Name = "txtUpdateAddress"
        Me.txtUpdateAddress.Size = New System.Drawing.Size(203, 28)
        Me.txtUpdateAddress.TabIndex = 14
        '
        'txtUpdateEmail
        '
        Me.txtUpdateEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "E-mail", True))
        Me.txtUpdateEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUpdateEmail.Location = New System.Drawing.Point(309, 290)
        Me.txtUpdateEmail.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtUpdateEmail.Name = "txtUpdateEmail"
        Me.txtUpdateEmail.Size = New System.Drawing.Size(203, 28)
        Me.txtUpdateEmail.TabIndex = 15
        '
        'txtUpdateAcctBal
        '
        Me.txtUpdateAcctBal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Account Balance", True))
        Me.txtUpdateAcctBal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUpdateAcctBal.Location = New System.Drawing.Point(344, 438)
        Me.txtUpdateAcctBal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtUpdateAcctBal.Name = "txtUpdateAcctBal"
        Me.txtUpdateAcctBal.ReadOnly = True
        Me.txtUpdateAcctBal.Size = New System.Drawing.Size(134, 28)
        Me.txtUpdateAcctBal.TabIndex = 16
        '
        'txtUpdatePlate
        '
        Me.txtUpdatePlate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Plate #", True))
        Me.txtUpdatePlate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUpdatePlate.Location = New System.Drawing.Point(309, 340)
        Me.txtUpdatePlate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtUpdatePlate.Name = "txtUpdatePlate"
        Me.txtUpdatePlate.Size = New System.Drawing.Size(203, 28)
        Me.txtUpdatePlate.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 13.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(700, 482)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(222, 27)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Account Overview:"
        '
        'grpUpdateFieldsForm
        '
        Me.grpUpdateFieldsForm.Controls.Add(Me.grpUpdateAcct)
        Me.grpUpdateFieldsForm.Controls.Add(Me.lblAcctStatus)
        Me.grpUpdateFieldsForm.Controls.Add(Me.Label14)
        Me.grpUpdateFieldsForm.Controls.Add(Me.Label13)
        Me.grpUpdateFieldsForm.Controls.Add(Me.btnTolls)
        Me.grpUpdateFieldsForm.Controls.Add(Me.cmbUpYear)
        Me.grpUpdateFieldsForm.Controls.Add(Me.cmbUpModel)
        Me.grpUpdateFieldsForm.Controls.Add(Me.cmbUpBodyStyle)
        Me.grpUpdateFieldsForm.Controls.Add(Me.RadNegativeAmt)
        Me.grpUpdateFieldsForm.Controls.Add(Me.RadPositiveAmt)
        Me.grpUpdateFieldsForm.Controls.Add(Me.txtUpdatePhone)
        Me.grpUpdateFieldsForm.Controls.Add(Me.lblPhone)
        Me.grpUpdateFieldsForm.Controls.Add(Me.btnAdd200)
        Me.grpUpdateFieldsForm.Controls.Add(Me.btnAdd100)
        Me.grpUpdateFieldsForm.Controls.Add(Me.btnAdd50)
        Me.grpUpdateFieldsForm.Controls.Add(Me.btnAdd25)
        Me.grpUpdateFieldsForm.Controls.Add(Me.btnReportTag)
        Me.grpUpdateFieldsForm.Controls.Add(Me.Label11)
        Me.grpUpdateFieldsForm.Controls.Add(Me.lblAccessedDate)
        Me.grpUpdateFieldsForm.Controls.Add(Me.txtUpdateCard)
        Me.grpUpdateFieldsForm.Controls.Add(Me.lblUpdateCard)
        Me.grpUpdateFieldsForm.Controls.Add(Me.DatUpdateOverview)
        Me.grpUpdateFieldsForm.Controls.Add(Me.Label10)
        Me.grpUpdateFieldsForm.Controls.Add(Me.txtUpdatePlate)
        Me.grpUpdateFieldsForm.Controls.Add(Me.txtUpdateAcctBal)
        Me.grpUpdateFieldsForm.Controls.Add(Me.txtUpdateEmail)
        Me.grpUpdateFieldsForm.Controls.Add(Me.txtUpdateAddress)
        Me.grpUpdateFieldsForm.Controls.Add(Me.txtUpdateLastNm)
        Me.grpUpdateFieldsForm.Controls.Add(Me.txtUpdateFirstNm)
        Me.grpUpdateFieldsForm.Controls.Add(Me.Label9)
        Me.grpUpdateFieldsForm.Controls.Add(Me.Label8)
        Me.grpUpdateFieldsForm.Controls.Add(Me.Label7)
        Me.grpUpdateFieldsForm.Controls.Add(Me.Label6)
        Me.grpUpdateFieldsForm.Controls.Add(Me.Label5)
        Me.grpUpdateFieldsForm.Controls.Add(Me.Label4)
        Me.grpUpdateFieldsForm.Controls.Add(Me.Label3)
        Me.grpUpdateFieldsForm.Controls.Add(Me.Label2)
        Me.grpUpdateFieldsForm.Controls.Add(Me.Label1)
        Me.grpUpdateFieldsForm.Controls.Add(Me.lblUpdateFields)
        Me.grpUpdateFieldsForm.Controls.Add(Me.btnSaveChanges)
        Me.grpUpdateFieldsForm.Controls.Add(Me.btnUpdateBack)
        Me.grpUpdateFieldsForm.Location = New System.Drawing.Point(12, 9)
        Me.grpUpdateFieldsForm.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpUpdateFieldsForm.Name = "grpUpdateFieldsForm"
        Me.grpUpdateFieldsForm.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpUpdateFieldsForm.Size = New System.Drawing.Size(1122, 814)
        Me.grpUpdateFieldsForm.TabIndex = 23
        Me.grpUpdateFieldsForm.TabStop = False
        '
        'lblAcctStatus
        '
        Me.lblAcctStatus.AutoSize = True
        Me.lblAcctStatus.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Account Status", True))
        Me.lblAcctStatus.Font = New System.Drawing.Font("Rockwell", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAcctStatus.Location = New System.Drawing.Point(308, 78)
        Me.lblAcctStatus.Name = "lblAcctStatus"
        Me.lblAcctStatus.Size = New System.Drawing.Size(61, 29)
        Me.lblAcctStatus.TabIndex = 47
        Me.lblAcctStatus.Text = "@@"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.PaleGreen
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(34, 76)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(234, 25)
        Me.Label14.TabIndex = 46
        Me.Label14.Text = "Current Account Status"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.SandyBrown
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(921, 302)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(118, 25)
        Me.Label13.TabIndex = 45
        Me.Label13.Text = "Toll Portal:"
        '
        'btnTolls
        '
        Me.btnTolls.BackColor = System.Drawing.Color.Khaki
        Me.btnTolls.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTolls.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTolls.Location = New System.Drawing.Point(887, 358)
        Me.btnTolls.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnTolls.Name = "btnTolls"
        Me.btnTolls.Size = New System.Drawing.Size(188, 78)
        Me.btnTolls.TabIndex = 44
        Me.btnTolls.Text = "See Tolls"
        Me.btnTolls.UseVisualStyleBackColor = False
        '
        'cmbUpYear
        '
        Me.cmbUpYear.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Vehicle Year", True))
        Me.cmbUpYear.DropDownHeight = 85
        Me.cmbUpYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUpYear.FormattingEnabled = True
        Me.cmbUpYear.IntegralHeight = False
        Me.cmbUpYear.ItemHeight = 22
        Me.cmbUpYear.Items.AddRange(New Object() {"Enter Vehicle Year", "2019", "2018", "2017", "2016", "2015", "2014", "2013", "2012", "2011", "2010", "2009", "2008", "2007", "2006", "2005", "2004", "2003", "2002", "2001", "2000", "1999", "1998", "1997", "1996", "1995"})
        Me.cmbUpYear.Location = New System.Drawing.Point(852, 132)
        Me.cmbUpYear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbUpYear.Name = "cmbUpYear"
        Me.cmbUpYear.Size = New System.Drawing.Size(203, 30)
        Me.cmbUpYear.TabIndex = 43
        '
        'cmbUpModel
        '
        Me.cmbUpModel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Model", True))
        Me.cmbUpModel.DropDownHeight = 85
        Me.cmbUpModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUpModel.FormattingEnabled = True
        Me.cmbUpModel.IntegralHeight = False
        Me.cmbUpModel.ItemHeight = 22
        Me.cmbUpModel.Items.AddRange(New Object() {"Select Model", "Acura", "Alfa Romeo", "Audi", "BMW", "Buick", "Cadillac", "Chevrolet", "Chrysler", "Dodge", "Fiat", "Ford", "GMC", "Honda", "Hyundai", "Infiniti", "Jaguar ", "Jeep", "Kia", "Lexus", "Lincoln", "Maserati", "Mazda", "Mercedes-Benz", "Mitsubishi", "Nissan", "Pontiac", "Porsche", "Subaru", "Toyota", "Tesla", "Volkswagen", "Volvo"})
        Me.cmbUpModel.Location = New System.Drawing.Point(309, 389)
        Me.cmbUpModel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbUpModel.Name = "cmbUpModel"
        Me.cmbUpModel.Size = New System.Drawing.Size(203, 30)
        Me.cmbUpModel.TabIndex = 42
        '
        'cmbUpBodyStyle
        '
        Me.cmbUpBodyStyle.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Body Style", True))
        Me.cmbUpBodyStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUpBodyStyle.FormattingEnabled = True
        Me.cmbUpBodyStyle.IntegralHeight = False
        Me.cmbUpBodyStyle.ItemHeight = 22
        Me.cmbUpBodyStyle.Items.AddRange(New Object() {"Select Style", "SUV", "Mini-Van", "Truck", "Sedan"})
        Me.cmbUpBodyStyle.Location = New System.Drawing.Point(852, 76)
        Me.cmbUpBodyStyle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbUpBodyStyle.Name = "cmbUpBodyStyle"
        Me.cmbUpBodyStyle.Size = New System.Drawing.Size(203, 30)
        Me.cmbUpBodyStyle.TabIndex = 41
        '
        'RadNegativeAmt
        '
        Me.RadNegativeAmt.AutoSize = True
        Me.RadNegativeAmt.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadNegativeAmt.Location = New System.Drawing.Point(500, 482)
        Me.RadNegativeAmt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadNegativeAmt.Name = "RadNegativeAmt"
        Me.RadNegativeAmt.Size = New System.Drawing.Size(43, 33)
        Me.RadNegativeAmt.TabIndex = 39
        Me.RadNegativeAmt.TabStop = True
        Me.RadNegativeAmt.Text = "-"
        Me.RadNegativeAmt.UseVisualStyleBackColor = True
        '
        'RadPositiveAmt
        '
        Me.RadPositiveAmt.AutoSize = True
        Me.RadPositiveAmt.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadPositiveAmt.Location = New System.Drawing.Point(500, 444)
        Me.RadPositiveAmt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadPositiveAmt.Name = "RadPositiveAmt"
        Me.RadPositiveAmt.Size = New System.Drawing.Size(51, 33)
        Me.RadPositiveAmt.TabIndex = 38
        Me.RadPositiveAmt.TabStop = True
        Me.RadPositiveAmt.Text = "+"
        Me.RadPositiveAmt.UseVisualStyleBackColor = True
        '
        'txtUpdatePhone
        '
        Me.txtUpdatePhone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Phone Number", True))
        Me.txtUpdatePhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUpdatePhone.Location = New System.Drawing.Point(852, 246)
        Me.txtUpdatePhone.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUpdatePhone.Name = "txtUpdatePhone"
        Me.txtUpdatePhone.Size = New System.Drawing.Size(203, 29)
        Me.txtUpdatePhone.TabIndex = 36
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Font = New System.Drawing.Font("Rockwell", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhone.Location = New System.Drawing.Point(564, 246)
        Me.lblPhone.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(230, 23)
        Me.lblPhone.TabIndex = 35
        Me.lblPhone.Text = "Update Phone Number:"
        '
        'btnAdd200
        '
        Me.btnAdd200.BackColor = System.Drawing.Color.Khaki
        Me.btnAdd200.Font = New System.Drawing.Font("Rockwell", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd200.Location = New System.Drawing.Point(365, 492)
        Me.btnAdd200.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAdd200.Name = "btnAdd200"
        Me.btnAdd200.Size = New System.Drawing.Size(83, 36)
        Me.btnAdd200.TabIndex = 34
        Me.btnAdd200.Text = "$ 200"
        Me.btnAdd200.UseVisualStyleBackColor = False
        '
        'btnAdd100
        '
        Me.btnAdd100.BackColor = System.Drawing.Color.Khaki
        Me.btnAdd100.Font = New System.Drawing.Font("Rockwell", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd100.Location = New System.Drawing.Point(256, 492)
        Me.btnAdd100.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAdd100.Name = "btnAdd100"
        Me.btnAdd100.Size = New System.Drawing.Size(83, 36)
        Me.btnAdd100.TabIndex = 33
        Me.btnAdd100.Text = "$ 100"
        Me.btnAdd100.UseVisualStyleBackColor = False
        '
        'btnAdd50
        '
        Me.btnAdd50.BackColor = System.Drawing.Color.Khaki
        Me.btnAdd50.Font = New System.Drawing.Font("Rockwell", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd50.Location = New System.Drawing.Point(142, 492)
        Me.btnAdd50.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAdd50.Name = "btnAdd50"
        Me.btnAdd50.Size = New System.Drawing.Size(83, 36)
        Me.btnAdd50.TabIndex = 32
        Me.btnAdd50.Text = "$ 50"
        Me.btnAdd50.UseVisualStyleBackColor = False
        '
        'btnAdd25
        '
        Me.btnAdd25.BackColor = System.Drawing.Color.Khaki
        Me.btnAdd25.Font = New System.Drawing.Font("Rockwell", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd25.Location = New System.Drawing.Point(30, 492)
        Me.btnAdd25.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAdd25.Name = "btnAdd25"
        Me.btnAdd25.Size = New System.Drawing.Size(83, 36)
        Me.btnAdd25.TabIndex = 31
        Me.btnAdd25.Text = "$ 25"
        Me.btnAdd25.UseVisualStyleBackColor = False
        '
        'btnReportTag
        '
        Me.btnReportTag.BackColor = System.Drawing.Color.Khaki
        Me.btnReportTag.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReportTag.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReportTag.Location = New System.Drawing.Point(616, 358)
        Me.btnReportTag.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnReportTag.Name = "btnReportTag"
        Me.btnReportTag.Size = New System.Drawing.Size(188, 78)
        Me.btnReportTag.TabIndex = 23
        Me.btnReportTag.Text = "Report Tag Status"
        Me.btnReportTag.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.SandyBrown
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(606, 302)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(197, 26)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Report Tag Portal:"
        '
        'lblAccessedDate
        '
        Me.lblAccessedDate.AutoSize = True
        Me.lblAccessedDate.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccessedDate.Location = New System.Drawing.Point(585, 526)
        Me.lblAccessedDate.Name = "lblAccessedDate"
        Me.lblAccessedDate.Size = New System.Drawing.Size(144, 20)
        Me.lblAccessedDate.TabIndex = 30
        Me.lblAccessedDate.Text = "Date Placeholder"
        '
        'txtUpdateCard
        '
        Me.txtUpdateCard.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Card On File", True))
        Me.txtUpdateCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUpdateCard.Location = New System.Drawing.Point(852, 186)
        Me.txtUpdateCard.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtUpdateCard.Name = "txtUpdateCard"
        Me.txtUpdateCard.Size = New System.Drawing.Size(203, 28)
        Me.txtUpdateCard.TabIndex = 29
        '
        'lblUpdateCard
        '
        Me.lblUpdateCard.AutoSize = True
        Me.lblUpdateCard.Font = New System.Drawing.Font("Rockwell", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUpdateCard.Location = New System.Drawing.Point(564, 185)
        Me.lblUpdateCard.Name = "lblUpdateCard"
        Me.lblUpdateCard.Size = New System.Drawing.Size(210, 23)
        Me.lblUpdateCard.TabIndex = 28
        Me.lblUpdateCard.Text = "Update Card On File:"
        '
        'DatUpdateOverview
        '
        Me.DatUpdateOverview.AutoGenerateColumns = False
        Me.DatUpdateOverview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DatUpdateOverview.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.DateOfBirthDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.PhoneNumberDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.SignUpDateDataGridViewTextBoxColumn, Me.AccountDataGridViewTextBoxColumn, Me.PlateDataGridViewTextBoxColumn, Me.BodyStyleDataGridViewTextBoxColumn, Me.ModelDataGridViewTextBoxColumn, Me.VehicleYearDataGridViewTextBoxColumn, Me.AddDateDataGridViewTextBoxColumn, Me.RemovalDateDataGridViewTextBoxColumn, Me.RemovalReasonDataGridViewTextBoxColumn, Me.TagDataGridViewTextBoxColumn, Me.TagAccountIDDataGridViewTextBoxColumn, Me.TagDateAssignedDataGridViewTextBoxColumn, Me.TagStatusDataGridViewTextBoxColumn, Me.AccountBalanceDataGridViewTextBoxColumn, Me.AccountStatusDataGridViewTextBoxColumn, Me.CardOnFileDataGridViewTextBoxColumn, Me.TripsTakenDataGridViewTextBoxColumn})
        Me.DatUpdateOverview.DataSource = Me.CustomersInfoBindingSource
        Me.DatUpdateOverview.Location = New System.Drawing.Point(34, 564)
        Me.DatUpdateOverview.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DatUpdateOverview.Name = "DatUpdateOverview"
        Me.DatUpdateOverview.RowHeadersWidth = 51
        Me.DatUpdateOverview.RowTemplate.Height = 28
        Me.DatUpdateOverview.Size = New System.Drawing.Size(1042, 108)
        Me.DatUpdateOverview.TabIndex = 27
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
        'CustomersInfoTableAdapter
        '
        Me.CustomersInfoTableAdapter.ClearBeforeFill = True
        '
        'grpUpdateAcct
        '
        Me.grpUpdateAcct.BackgroundImage = Global.EzPass_Prototype_1.My.Resources.Resources.Ezpass_Registration_Login_Background
        Me.grpUpdateAcct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.grpUpdateAcct.Controls.Add(Me.btnFindAcct)
        Me.grpUpdateAcct.Controls.Add(Me.Label12)
        Me.grpUpdateAcct.Controls.Add(Me.btnUpdateBackLogin)
        Me.grpUpdateAcct.Controls.Add(Me.lblAcctQuestion)
        Me.grpUpdateAcct.Controls.Add(Me.txtAcctSearch)
        Me.grpUpdateAcct.Controls.Add(Me.PictureBox1)
        Me.grpUpdateAcct.Controls.Add(Me.lblUpdateUserInfo)
        Me.grpUpdateAcct.Controls.Add(Me.btnSearch)
        Me.grpUpdateAcct.Location = New System.Drawing.Point(0, 0)
        Me.grpUpdateAcct.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpUpdateAcct.Name = "grpUpdateAcct"
        Me.grpUpdateAcct.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpUpdateAcct.Size = New System.Drawing.Size(1118, 807)
        Me.grpUpdateAcct.TabIndex = 24
        Me.grpUpdateAcct.TabStop = False
        '
        'btnFindAcct
        '
        Me.btnFindAcct.BackColor = System.Drawing.Color.Khaki
        Me.btnFindAcct.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFindAcct.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFindAcct.Location = New System.Drawing.Point(476, 492)
        Me.btnFindAcct.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnFindAcct.Name = "btnFindAcct"
        Me.btnFindAcct.Size = New System.Drawing.Size(172, 42)
        Me.btnFindAcct.TabIndex = 7
        Me.btnFindAcct.Text = "Find Account"
        Me.btnFindAcct.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(316, 444)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(471, 22)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Have you forgotten your Account Number? Click here."
        '
        'btnUpdateBackLogin
        '
        Me.btnUpdateBackLogin.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnUpdateBackLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUpdateBackLogin.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateBackLogin.Location = New System.Drawing.Point(194, 624)
        Me.btnUpdateBackLogin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnUpdateBackLogin.Name = "btnUpdateBackLogin"
        Me.btnUpdateBackLogin.Size = New System.Drawing.Size(215, 78)
        Me.btnUpdateBackLogin.TabIndex = 5
        Me.btnUpdateBackLogin.Text = "Back to Main Menu"
        Me.btnUpdateBackLogin.UseVisualStyleBackColor = False
        '
        'lblAcctQuestion
        '
        Me.lblAcctQuestion.AutoSize = True
        Me.lblAcctQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAcctQuestion.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAcctQuestion.Location = New System.Drawing.Point(391, 284)
        Me.lblAcctQuestion.Name = "lblAcctQuestion"
        Me.lblAcctQuestion.Size = New System.Drawing.Size(318, 26)
        Me.lblAcctQuestion.TabIndex = 4
        Me.lblAcctQuestion.Text = "What is your Account Number?"
        '
        'txtAcctSearch
        '
        Me.txtAcctSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAcctSearch.Location = New System.Drawing.Point(377, 346)
        Me.txtAcctSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAcctSearch.Name = "txtAcctSearch"
        Me.txtAcctSearch.Size = New System.Drawing.Size(368, 28)
        Me.txtAcctSearch.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.EzPass_Prototype_1.My.Resources.Resources.EzPass_update_vector
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(258, 82)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(94, 96)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'lblUpdateUserInfo
        '
        Me.lblUpdateUserInfo.AutoSize = True
        Me.lblUpdateUserInfo.BackColor = System.Drawing.Color.PaleGreen
        Me.lblUpdateUserInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblUpdateUserInfo.Font = New System.Drawing.Font("Tahoma", 16.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUpdateUserInfo.Location = New System.Drawing.Point(389, 112)
        Me.lblUpdateUserInfo.Name = "lblUpdateUserInfo"
        Me.lblUpdateUserInfo.Size = New System.Drawing.Size(356, 35)
        Me.lblUpdateUserInfo.TabIndex = 1
        Me.lblUpdateUserInfo.Text = "Update User Information"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(744, 624)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(215, 78)
        Me.btnSearch.TabIndex = 0
        Me.btnSearch.Text = "Search Records"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1141, 820)
        Me.Controls.Add(Me.grpUpdateFieldsForm)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Account"
        CType(Me.CustomersInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EzPassDBSystem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpUpdateFieldsForm.ResumeLayout(False)
        Me.grpUpdateFieldsForm.PerformLayout()
        CType(Me.DatUpdateOverview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpUpdateAcct.ResumeLayout(False)
        Me.grpUpdateAcct.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnUpdateBack As Button
    Friend WithEvents btnSaveChanges As Button
    Friend WithEvents lblUpdateFields As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtUpdateFirstNm As TextBox
    Friend WithEvents txtUpdateLastNm As TextBox
    Friend WithEvents txtUpdateAddress As TextBox
    Friend WithEvents txtUpdateEmail As TextBox
    Friend WithEvents txtUpdateAcctBal As TextBox
    Friend WithEvents txtUpdatePlate As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents grpUpdateFieldsForm As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btnReportTag As Button
    Friend WithEvents DatUpdateOverview As DataGridView
    Friend WithEvents grpUpdateAcct As GroupBox
    Friend WithEvents lblAcctQuestion As Label
    Friend WithEvents txtAcctSearch As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblUpdateUserInfo As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnUpdateBackLogin As Button
    Friend WithEvents txtUpdateCard As TextBox
    Friend WithEvents lblUpdateCard As Label
    Friend WithEvents lblAccessedDate As Label
    Friend WithEvents btnAdd200 As Button
    Friend WithEvents btnAdd100 As Button
    Friend WithEvents btnAdd50 As Button
    Friend WithEvents btnAdd25 As Button
    Friend WithEvents btnFindAcct As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents txtUpdatePhone As TextBox
    Friend WithEvents lblPhone As Label
    Friend WithEvents EzPassDBSystem As EzPassDBSystem
    Friend WithEvents RadNegativeAmt As RadioButton
    Friend WithEvents RadPositiveAmt As RadioButton
    Friend WithEvents cmbUpYear As ComboBox
    Friend WithEvents cmbUpModel As ComboBox
    Friend WithEvents cmbUpBodyStyle As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents btnTolls As Button
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
    Friend WithEvents Label14 As Label
    Friend WithEvents lblAcctStatus As Label
End Class
