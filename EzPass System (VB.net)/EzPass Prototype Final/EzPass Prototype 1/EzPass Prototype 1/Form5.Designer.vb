<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form5
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
        Me.grpReportLost = New System.Windows.Forms.GroupBox()
        Me.cmbLostReason = New System.Windows.Forms.ComboBox()
        Me.CustomersInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EzPassDBSystem = New EzPass_Prototype_1.EzPassDBSystem()
        Me.lblLostReason = New System.Windows.Forms.Label()
        Me.grpLostDetails = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblRetrieveAccount = New System.Windows.Forms.Label()
        Me.lblRetrieveFirst = New System.Windows.Forms.Label()
        Me.lblRetrieveTag = New System.Windows.Forms.Label()
        Me.lblRetrieveLast = New System.Windows.Forms.Label()
        Me.txtLostTagStatus = New System.Windows.Forms.TextBox()
        Me.lblLostTagStatus = New System.Windows.Forms.Label()
        Me.txtReportLostDate = New System.Windows.Forms.TextBox()
        Me.LostTagsInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtReportAcct = New System.Windows.Forms.TextBox()
        Me.txtReportLostTag = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnReportLost = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblReportLostTag = New System.Windows.Forms.Label()
        Me.btnBackStatus = New System.Windows.Forms.Button()
        Me.grpReportReturn = New System.Windows.Forms.GroupBox()
        Me.cmbReturnReason = New System.Windows.Forms.ComboBox()
        Me.lblReturnReason = New System.Windows.Forms.Label()
        Me.grpReturnDetails = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblRetrieveAccount2 = New System.Windows.Forms.Label()
        Me.lblRetrieveFirst2 = New System.Windows.Forms.Label()
        Me.lblRetrieveTag2 = New System.Windows.Forms.Label()
        Me.lblRetrieveLast2 = New System.Windows.Forms.Label()
        Me.txtReturnTagStatus = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTagReturnDate = New System.Windows.Forms.TextBox()
        Me.ReturnedTagsInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtReturnAcct = New System.Windows.Forms.TextBox()
        Me.txtReturnTag = New System.Windows.Forms.TextBox()
        Me.btnReportReturn = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblReportReturnTag = New System.Windows.Forms.Label()
        Me.grpTagStatusLogin = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnAssignTag = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnBuyTag = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnTagLoginBack = New System.Windows.Forms.Button()
        Me.btnLoginTagReturn = New System.Windows.Forms.Button()
        Me.btnLoginTagLost = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblLostTagPlace = New System.Windows.Forms.Label()
        Me.txtLostTagPlace = New System.Windows.Forms.TextBox()
        Me.lblReturnTagPlace = New System.Windows.Forms.Label()
        Me.txtReturnTagPlace = New System.Windows.Forms.TextBox()
        Me.lblLostRemovalDatePlace = New System.Windows.Forms.Label()
        Me.txtLostRemovalDatePlace = New System.Windows.Forms.TextBox()
        Me.txtReturnRemovalDatePlace = New System.Windows.Forms.TextBox()
        Me.lblReturnRemovalDatePlace = New System.Windows.Forms.Label()
        Me.lblLostReasonPlaceholder = New System.Windows.Forms.Label()
        Me.txtLostReasonPlaceholder = New System.Windows.Forms.TextBox()
        Me.txtReturnReasonPlaceholder = New System.Windows.Forms.TextBox()
        Me.lblReturnReasonPlaceholder = New System.Windows.Forms.Label()
        Me.CustomersInfoTableAdapter = New EzPass_Prototype_1.EzPassDBSystemTableAdapters.CustomersInfoTableAdapter()
        Me.LostTagsInfoTableAdapter = New EzPass_Prototype_1.EzPassDBSystemTableAdapters.LostTagsInfoTableAdapter()
        Me.ReturnedTagsInfoTableAdapter = New EzPass_Prototype_1.EzPassDBSystemTableAdapters.ReturnedTagsInfoTableAdapter()
        Me.grpReportLost.SuspendLayout()
        CType(Me.CustomersInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EzPassDBSystem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLostDetails.SuspendLayout()
        CType(Me.LostTagsInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpReportReturn.SuspendLayout()
        Me.grpReturnDetails.SuspendLayout()
        CType(Me.ReturnedTagsInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTagStatusLogin.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpReportLost
        '
        Me.grpReportLost.Controls.Add(Me.cmbLostReason)
        Me.grpReportLost.Controls.Add(Me.lblLostReason)
        Me.grpReportLost.Controls.Add(Me.grpLostDetails)
        Me.grpReportLost.Controls.Add(Me.txtLostTagStatus)
        Me.grpReportLost.Controls.Add(Me.lblLostTagStatus)
        Me.grpReportLost.Controls.Add(Me.txtReportLostDate)
        Me.grpReportLost.Controls.Add(Me.txtReportAcct)
        Me.grpReportLost.Controls.Add(Me.txtReportLostTag)
        Me.grpReportLost.Controls.Add(Me.Label4)
        Me.grpReportLost.Controls.Add(Me.btnReportLost)
        Me.grpReportLost.Controls.Add(Me.Label3)
        Me.grpReportLost.Controls.Add(Me.Label2)
        Me.grpReportLost.Controls.Add(Me.lblReportLostTag)
        Me.grpReportLost.Location = New System.Drawing.Point(31, 10)
        Me.grpReportLost.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpReportLost.Name = "grpReportLost"
        Me.grpReportLost.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpReportLost.Size = New System.Drawing.Size(524, 654)
        Me.grpReportLost.TabIndex = 0
        Me.grpReportLost.TabStop = False
        '
        'cmbLostReason
        '
        Me.cmbLostReason.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Removal Reason", True))
        Me.cmbLostReason.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLostReason.FormattingEnabled = True
        Me.cmbLostReason.Items.AddRange(New Object() {"Select Reason:", "Lost My Tag and Cannot Find It", "Tag was Damaged or Destroyed", "Tag was Stolen"})
        Me.cmbLostReason.Location = New System.Drawing.Point(71, 463)
        Me.cmbLostReason.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbLostReason.Name = "cmbLostReason"
        Me.cmbLostReason.Size = New System.Drawing.Size(357, 30)
        Me.cmbLostReason.TabIndex = 13
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
        'lblLostReason
        '
        Me.lblLostReason.AutoSize = True
        Me.lblLostReason.Font = New System.Drawing.Font("Rockwell", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLostReason.Location = New System.Drawing.Point(161, 427)
        Me.lblLostReason.Name = "lblLostReason"
        Me.lblLostReason.Size = New System.Drawing.Size(175, 23)
        Me.lblLostReason.TabIndex = 12
        Me.lblLostReason.Text = "Removal Reason:"
        '
        'grpLostDetails
        '
        Me.grpLostDetails.BackColor = System.Drawing.SystemColors.Info
        Me.grpLostDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.grpLostDetails.Controls.Add(Me.Label17)
        Me.grpLostDetails.Controls.Add(Me.lblRetrieveAccount)
        Me.grpLostDetails.Controls.Add(Me.lblRetrieveFirst)
        Me.grpLostDetails.Controls.Add(Me.lblRetrieveTag)
        Me.grpLostDetails.Controls.Add(Me.lblRetrieveLast)
        Me.grpLostDetails.Location = New System.Drawing.Point(89, 87)
        Me.grpLostDetails.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpLostDetails.Name = "grpLostDetails"
        Me.grpLostDetails.Size = New System.Drawing.Size(329, 96)
        Me.grpLostDetails.TabIndex = 11
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(4, 37)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(288, 18)
        Me.Label17.TabIndex = 15
        Me.Label17.Text = "Your Account # and current Tag # are:"
        '
        'lblRetrieveAccount
        '
        Me.lblRetrieveAccount.AutoSize = True
        Me.lblRetrieveAccount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Account #", True))
        Me.lblRetrieveAccount.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRetrieveAccount.Location = New System.Drawing.Point(39, 68)
        Me.lblRetrieveAccount.Name = "lblRetrieveAccount"
        Me.lblRetrieveAccount.Size = New System.Drawing.Size(43, 20)
        Me.lblRetrieveAccount.TabIndex = 14
        Me.lblRetrieveAccount.Text = "@@"
        '
        'lblRetrieveFirst
        '
        Me.lblRetrieveFirst.AutoSize = True
        Me.lblRetrieveFirst.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "First Name", True))
        Me.lblRetrieveFirst.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRetrieveFirst.Location = New System.Drawing.Point(4, 9)
        Me.lblRetrieveFirst.Name = "lblRetrieveFirst"
        Me.lblRetrieveFirst.Size = New System.Drawing.Size(43, 20)
        Me.lblRetrieveFirst.TabIndex = 11
        Me.lblRetrieveFirst.Text = "@@"
        '
        'lblRetrieveTag
        '
        Me.lblRetrieveTag.AutoSize = True
        Me.lblRetrieveTag.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Tag #", True))
        Me.lblRetrieveTag.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRetrieveTag.Location = New System.Drawing.Point(188, 68)
        Me.lblRetrieveTag.Name = "lblRetrieveTag"
        Me.lblRetrieveTag.Size = New System.Drawing.Size(43, 20)
        Me.lblRetrieveTag.TabIndex = 13
        Me.lblRetrieveTag.Text = "@@"
        '
        'lblRetrieveLast
        '
        Me.lblRetrieveLast.AutoSize = True
        Me.lblRetrieveLast.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Last Name", True))
        Me.lblRetrieveLast.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRetrieveLast.Location = New System.Drawing.Point(153, 9)
        Me.lblRetrieveLast.Name = "lblRetrieveLast"
        Me.lblRetrieveLast.Size = New System.Drawing.Size(43, 20)
        Me.lblRetrieveLast.TabIndex = 12
        Me.lblRetrieveLast.Text = "@@"
        '
        'txtLostTagStatus
        '
        Me.txtLostTagStatus.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Tag Status", True))
        Me.txtLostTagStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLostTagStatus.Location = New System.Drawing.Point(273, 361)
        Me.txtLostTagStatus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtLostTagStatus.Name = "txtLostTagStatus"
        Me.txtLostTagStatus.Size = New System.Drawing.Size(185, 28)
        Me.txtLostTagStatus.TabIndex = 10
        '
        'lblLostTagStatus
        '
        Me.lblLostTagStatus.AutoSize = True
        Me.lblLostTagStatus.Font = New System.Drawing.Font("Rockwell", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLostTagStatus.Location = New System.Drawing.Point(65, 363)
        Me.lblLostTagStatus.Name = "lblLostTagStatus"
        Me.lblLostTagStatus.Size = New System.Drawing.Size(161, 23)
        Me.lblLostTagStatus.TabIndex = 9
        Me.lblLostTagStatus.Text = "New Tag Status:"
        '
        'txtReportLostDate
        '
        Me.txtReportLostDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LostTagsInfoBindingSource, "Tag Lost On:", True))
        Me.txtReportLostDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReportLostDate.Location = New System.Drawing.Point(273, 315)
        Me.txtReportLostDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtReportLostDate.Name = "txtReportLostDate"
        Me.txtReportLostDate.Size = New System.Drawing.Size(185, 28)
        Me.txtReportLostDate.TabIndex = 8
        '
        'LostTagsInfoBindingSource
        '
        Me.LostTagsInfoBindingSource.DataMember = "LostTagsInfo"
        Me.LostTagsInfoBindingSource.DataSource = Me.EzPassDBSystem
        '
        'txtReportAcct
        '
        Me.txtReportAcct.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LostTagsInfoBindingSource, "Account #", True))
        Me.txtReportAcct.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReportAcct.Location = New System.Drawing.Point(273, 230)
        Me.txtReportAcct.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtReportAcct.Name = "txtReportAcct"
        Me.txtReportAcct.Size = New System.Drawing.Size(185, 28)
        Me.txtReportAcct.TabIndex = 7
        '
        'txtReportLostTag
        '
        Me.txtReportLostTag.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LostTagsInfoBindingSource, "Tag #", True))
        Me.txtReportLostTag.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReportLostTag.Location = New System.Drawing.Point(273, 273)
        Me.txtReportLostTag.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtReportLostTag.Name = "txtReportLostTag"
        Me.txtReportLostTag.Size = New System.Drawing.Size(185, 28)
        Me.txtReportLostTag.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Rockwell", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(73, 319)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 23)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Tag Lost On:"
        '
        'btnReportLost
        '
        Me.btnReportLost.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnReportLost.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReportLost.Font = New System.Drawing.Font("Rockwell", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReportLost.Location = New System.Drawing.Point(133, 540)
        Me.btnReportLost.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnReportLost.Name = "btnReportLost"
        Me.btnReportLost.Size = New System.Drawing.Size(245, 84)
        Me.btnReportLost.TabIndex = 1
        Me.btnReportLost.Text = "Report Lost"
        Me.btnReportLost.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(65, 230)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(167, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Your Account # :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(85, 273)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Lost Tag # :"
        '
        'lblReportLostTag
        '
        Me.lblReportLostTag.AutoSize = True
        Me.lblReportLostTag.BackColor = System.Drawing.Color.Plum
        Me.lblReportLostTag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblReportLostTag.Font = New System.Drawing.Font("Tahoma", 16.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReportLostTag.Location = New System.Drawing.Point(137, 28)
        Me.lblReportLostTag.Name = "lblReportLostTag"
        Me.lblReportLostTag.Size = New System.Drawing.Size(233, 35)
        Me.lblReportLostTag.TabIndex = 2
        Me.lblReportLostTag.Text = "Report Lost Tag"
        '
        'btnBackStatus
        '
        Me.btnBackStatus.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnBackStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBackStatus.Font = New System.Drawing.Font("Rockwell", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackStatus.Location = New System.Drawing.Point(479, 700)
        Me.btnBackStatus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBackStatus.Name = "btnBackStatus"
        Me.btnBackStatus.Size = New System.Drawing.Size(245, 95)
        Me.btnBackStatus.TabIndex = 0
        Me.btnBackStatus.Text = "Back to Tag Status Page"
        Me.btnBackStatus.UseVisualStyleBackColor = False
        '
        'grpReportReturn
        '
        Me.grpReportReturn.Controls.Add(Me.cmbReturnReason)
        Me.grpReportReturn.Controls.Add(Me.lblReturnReason)
        Me.grpReportReturn.Controls.Add(Me.grpReturnDetails)
        Me.grpReportReturn.Controls.Add(Me.txtReturnTagStatus)
        Me.grpReportReturn.Controls.Add(Me.Label10)
        Me.grpReportReturn.Controls.Add(Me.txtTagReturnDate)
        Me.grpReportReturn.Controls.Add(Me.txtReturnAcct)
        Me.grpReportReturn.Controls.Add(Me.txtReturnTag)
        Me.grpReportReturn.Controls.Add(Me.btnReportReturn)
        Me.grpReportReturn.Controls.Add(Me.Label6)
        Me.grpReportReturn.Controls.Add(Me.Label5)
        Me.grpReportReturn.Controls.Add(Me.Label1)
        Me.grpReportReturn.Controls.Add(Me.lblReportReturnTag)
        Me.grpReportReturn.Location = New System.Drawing.Point(616, 10)
        Me.grpReportReturn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpReportReturn.Name = "grpReportReturn"
        Me.grpReportReturn.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpReportReturn.Size = New System.Drawing.Size(524, 654)
        Me.grpReportReturn.TabIndex = 1
        Me.grpReportReturn.TabStop = False
        '
        'cmbReturnReason
        '
        Me.cmbReturnReason.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Removal Reason", True))
        Me.cmbReturnReason.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbReturnReason.FormattingEnabled = True
        Me.cmbReturnReason.Items.AddRange(New Object() {"Select Reason:", "Don't Want a Tag", "Will Assign a New Tag Later", "Not Enough Funds to Continue Service ", "Not Using Account Actively"})
        Me.cmbReturnReason.Location = New System.Drawing.Point(99, 463)
        Me.cmbReturnReason.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbReturnReason.Name = "cmbReturnReason"
        Me.cmbReturnReason.Size = New System.Drawing.Size(357, 30)
        Me.cmbReturnReason.TabIndex = 17
        '
        'lblReturnReason
        '
        Me.lblReturnReason.AutoSize = True
        Me.lblReturnReason.Font = New System.Drawing.Font("Rockwell", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReturnReason.Location = New System.Drawing.Point(193, 427)
        Me.lblReturnReason.Name = "lblReturnReason"
        Me.lblReturnReason.Size = New System.Drawing.Size(175, 23)
        Me.lblReturnReason.TabIndex = 16
        Me.lblReturnReason.Text = "Removal Reason:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'grpReturnDetails
        '
        Me.grpReturnDetails.BackColor = System.Drawing.SystemColors.Info
        Me.grpReturnDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.grpReturnDetails.Controls.Add(Me.Label13)
        Me.grpReturnDetails.Controls.Add(Me.lblRetrieveAccount2)
        Me.grpReturnDetails.Controls.Add(Me.lblRetrieveFirst2)
        Me.grpReturnDetails.Controls.Add(Me.lblRetrieveTag2)
        Me.grpReturnDetails.Controls.Add(Me.lblRetrieveLast2)
        Me.grpReturnDetails.Location = New System.Drawing.Point(107, 87)
        Me.grpReturnDetails.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpReturnDetails.Name = "grpReturnDetails"
        Me.grpReturnDetails.Size = New System.Drawing.Size(329, 96)
        Me.grpReturnDetails.TabIndex = 15
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(3, 37)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(288, 18)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Your Account # and current Tag # are:"
        '
        'lblRetrieveAccount2
        '
        Me.lblRetrieveAccount2.AutoSize = True
        Me.lblRetrieveAccount2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Tag #", True))
        Me.lblRetrieveAccount2.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRetrieveAccount2.Location = New System.Drawing.Point(183, 68)
        Me.lblRetrieveAccount2.Name = "lblRetrieveAccount2"
        Me.lblRetrieveAccount2.Size = New System.Drawing.Size(43, 20)
        Me.lblRetrieveAccount2.TabIndex = 14
        Me.lblRetrieveAccount2.Text = "@@"
        '
        'lblRetrieveFirst2
        '
        Me.lblRetrieveFirst2.AutoSize = True
        Me.lblRetrieveFirst2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "First Name", True))
        Me.lblRetrieveFirst2.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRetrieveFirst2.Location = New System.Drawing.Point(12, 9)
        Me.lblRetrieveFirst2.Name = "lblRetrieveFirst2"
        Me.lblRetrieveFirst2.Size = New System.Drawing.Size(43, 20)
        Me.lblRetrieveFirst2.TabIndex = 11
        Me.lblRetrieveFirst2.Text = "@@"
        '
        'lblRetrieveTag2
        '
        Me.lblRetrieveTag2.AutoSize = True
        Me.lblRetrieveTag2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Account #", True))
        Me.lblRetrieveTag2.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRetrieveTag2.Location = New System.Drawing.Point(55, 68)
        Me.lblRetrieveTag2.Name = "lblRetrieveTag2"
        Me.lblRetrieveTag2.Size = New System.Drawing.Size(43, 20)
        Me.lblRetrieveTag2.TabIndex = 13
        Me.lblRetrieveTag2.Text = "@@"
        '
        'lblRetrieveLast2
        '
        Me.lblRetrieveLast2.AutoSize = True
        Me.lblRetrieveLast2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Last Name", True))
        Me.lblRetrieveLast2.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRetrieveLast2.Location = New System.Drawing.Point(156, 9)
        Me.lblRetrieveLast2.Name = "lblRetrieveLast2"
        Me.lblRetrieveLast2.Size = New System.Drawing.Size(43, 20)
        Me.lblRetrieveLast2.TabIndex = 12
        Me.lblRetrieveLast2.Text = "@@"
        '
        'txtReturnTagStatus
        '
        Me.txtReturnTagStatus.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Tag Status", True))
        Me.txtReturnTagStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReturnTagStatus.Location = New System.Drawing.Point(293, 361)
        Me.txtReturnTagStatus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtReturnTagStatus.Name = "txtReturnTagStatus"
        Me.txtReturnTagStatus.Size = New System.Drawing.Size(185, 28)
        Me.txtReturnTagStatus.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Rockwell", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(71, 363)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(161, 23)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "New Tag Status:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtTagReturnDate
        '
        Me.txtTagReturnDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReturnedTagsInfoBindingSource, "Tag Returned On:", True))
        Me.txtTagReturnDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTagReturnDate.Location = New System.Drawing.Point(293, 316)
        Me.txtTagReturnDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTagReturnDate.Name = "txtTagReturnDate"
        Me.txtTagReturnDate.Size = New System.Drawing.Size(185, 28)
        Me.txtTagReturnDate.TabIndex = 7
        '
        'ReturnedTagsInfoBindingSource
        '
        Me.ReturnedTagsInfoBindingSource.DataMember = "ReturnedTagsInfo"
        Me.ReturnedTagsInfoBindingSource.DataSource = Me.EzPassDBSystem
        '
        'txtReturnAcct
        '
        Me.txtReturnAcct.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReturnedTagsInfoBindingSource, "Account #", True))
        Me.txtReturnAcct.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReturnAcct.Location = New System.Drawing.Point(295, 230)
        Me.txtReturnAcct.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtReturnAcct.Name = "txtReturnAcct"
        Me.txtReturnAcct.Size = New System.Drawing.Size(185, 28)
        Me.txtReturnAcct.TabIndex = 6
        '
        'txtReturnTag
        '
        Me.txtReturnTag.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReturnedTagsInfoBindingSource, "Tag #", True))
        Me.txtReturnTag.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReturnTag.Location = New System.Drawing.Point(295, 273)
        Me.txtReturnTag.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtReturnTag.Name = "txtReturnTag"
        Me.txtReturnTag.Size = New System.Drawing.Size(185, 28)
        Me.txtReturnTag.TabIndex = 5
        '
        'btnReportReturn
        '
        Me.btnReportReturn.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnReportReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReportReturn.Font = New System.Drawing.Font("Rockwell", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReportReturn.Location = New System.Drawing.Point(167, 540)
        Me.btnReportReturn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnReportReturn.Name = "btnReportReturn"
        Me.btnReportReturn.Size = New System.Drawing.Size(245, 84)
        Me.btnReportReturn.TabIndex = 4
        Me.btnReportReturn.Text = "Report Return"
        Me.btnReportReturn.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Rockwell", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(65, 319)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(179, 23)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Tag Returned On:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Rockwell", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(67, 230)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(167, 23)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Your Account # :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(71, 273)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Return Tag # :"
        '
        'lblReportReturnTag
        '
        Me.lblReportReturnTag.AutoSize = True
        Me.lblReportReturnTag.BackColor = System.Drawing.Color.Plum
        Me.lblReportReturnTag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblReportReturnTag.Font = New System.Drawing.Font("Tahoma", 16.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReportReturnTag.Location = New System.Drawing.Point(185, 28)
        Me.lblReportReturnTag.Name = "lblReportReturnTag"
        Me.lblReportReturnTag.Size = New System.Drawing.Size(168, 35)
        Me.lblReportReturnTag.TabIndex = 0
        Me.lblReportReturnTag.Text = "Return Tag"
        '
        'grpTagStatusLogin
        '
        Me.grpTagStatusLogin.BackgroundImage = Global.EzPass_Prototype_1.My.Resources.Resources.Ezpass_Registration_Login_Background
        Me.grpTagStatusLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.grpTagStatusLogin.Controls.Add(Me.Label12)
        Me.grpTagStatusLogin.Controls.Add(Me.btnAssignTag)
        Me.grpTagStatusLogin.Controls.Add(Me.Label11)
        Me.grpTagStatusLogin.Controls.Add(Me.btnBuyTag)
        Me.grpTagStatusLogin.Controls.Add(Me.PictureBox1)
        Me.grpTagStatusLogin.Controls.Add(Me.Label9)
        Me.grpTagStatusLogin.Controls.Add(Me.Label8)
        Me.grpTagStatusLogin.Controls.Add(Me.btnTagLoginBack)
        Me.grpTagStatusLogin.Controls.Add(Me.btnLoginTagReturn)
        Me.grpTagStatusLogin.Controls.Add(Me.btnLoginTagLost)
        Me.grpTagStatusLogin.Controls.Add(Me.Label7)
        Me.grpTagStatusLogin.Location = New System.Drawing.Point(9, 8)
        Me.grpTagStatusLogin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpTagStatusLogin.Name = "grpTagStatusLogin"
        Me.grpTagStatusLogin.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpTagStatusLogin.Size = New System.Drawing.Size(1151, 801)
        Me.grpTagStatusLogin.TabIndex = 2
        Me.grpTagStatusLogin.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.MistyRose
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(781, 234)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(117, 26)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Assigning:"
        '
        'btnAssignTag
        '
        Me.btnAssignTag.BackColor = System.Drawing.Color.Khaki
        Me.btnAssignTag.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAssignTag.Font = New System.Drawing.Font("Rockwell", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAssignTag.Location = New System.Drawing.Point(735, 407)
        Me.btnAssignTag.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAssignTag.Name = "btnAssignTag"
        Me.btnAssignTag.Size = New System.Drawing.Size(211, 60)
        Me.btnAssignTag.TabIndex = 9
        Me.btnAssignTag.Text = "Assign Tag"
        Me.btnAssignTag.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.MistyRose
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(296, 234)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(120, 26)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Reporting:"
        '
        'btnBuyTag
        '
        Me.btnBuyTag.BackColor = System.Drawing.Color.Khaki
        Me.btnBuyTag.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBuyTag.Font = New System.Drawing.Font("Rockwell", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuyTag.Location = New System.Drawing.Point(735, 298)
        Me.btnBuyTag.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBuyTag.Name = "btnBuyTag"
        Me.btnBuyTag.Size = New System.Drawing.Size(211, 60)
        Me.btnBuyTag.TabIndex = 7
        Me.btnBuyTag.Text = "Buy Tag"
        Me.btnBuyTag.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.EzPass_Prototype_1.My.Resources.Resources.Tag_Status_Vector
        Me.PictureBox1.Location = New System.Drawing.Point(348, 90)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(86, 81)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.MistyRose
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Font = New System.Drawing.Font("Rockwell", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(237, 705)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(677, 24)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Reminder: The Account # and Tag # will be displayed after verification of Account" &
    "." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(331, 689)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 17)
        Me.Label8.TabIndex = 4
        '
        'btnTagLoginBack
        '
        Me.btnTagLoginBack.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnTagLoginBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTagLoginBack.Font = New System.Drawing.Font("Rockwell", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTagLoginBack.Location = New System.Drawing.Point(493, 566)
        Me.btnTagLoginBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnTagLoginBack.Name = "btnTagLoginBack"
        Me.btnTagLoginBack.Size = New System.Drawing.Size(211, 84)
        Me.btnTagLoginBack.TabIndex = 3
        Me.btnTagLoginBack.Text = "Back to Update Page"
        Me.btnTagLoginBack.UseVisualStyleBackColor = False
        '
        'btnLoginTagReturn
        '
        Me.btnLoginTagReturn.BackColor = System.Drawing.Color.Khaki
        Me.btnLoginTagReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLoginTagReturn.Font = New System.Drawing.Font("Rockwell", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoginTagReturn.Location = New System.Drawing.Point(253, 407)
        Me.btnLoginTagReturn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLoginTagReturn.Name = "btnLoginTagReturn"
        Me.btnLoginTagReturn.Size = New System.Drawing.Size(211, 60)
        Me.btnLoginTagReturn.TabIndex = 2
        Me.btnLoginTagReturn.Text = "Return Tag"
        Me.btnLoginTagReturn.UseVisualStyleBackColor = False
        '
        'btnLoginTagLost
        '
        Me.btnLoginTagLost.BackColor = System.Drawing.Color.Khaki
        Me.btnLoginTagLost.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLoginTagLost.Font = New System.Drawing.Font("Rockwell", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoginTagLost.Location = New System.Drawing.Point(253, 298)
        Me.btnLoginTagLost.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLoginTagLost.Name = "btnLoginTagLost"
        Me.btnLoginTagLost.Size = New System.Drawing.Size(211, 60)
        Me.btnLoginTagLost.TabIndex = 1
        Me.btnLoginTagLost.Text = "Report Lost Tag"
        Me.btnLoginTagLost.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.MistyRose
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 16.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(453, 113)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(356, 35)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "What is your Tag Status?"
        '
        'lblLostTagPlace
        '
        Me.lblLostTagPlace.AutoSize = True
        Me.lblLostTagPlace.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLostTagPlace.Location = New System.Drawing.Point(48, 698)
        Me.lblLostTagPlace.Name = "lblLostTagPlace"
        Me.lblLostTagPlace.Size = New System.Drawing.Size(189, 20)
        Me.lblLostTagPlace.TabIndex = 11
        Me.lblLostTagPlace.Text = "Lost Tag Placeholder"
        '
        'txtLostTagPlace
        '
        Me.txtLostTagPlace.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Tag #", True))
        Me.txtLostTagPlace.Location = New System.Drawing.Point(322, 698)
        Me.txtLostTagPlace.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtLostTagPlace.Name = "txtLostTagPlace"
        Me.txtLostTagPlace.Size = New System.Drawing.Size(85, 22)
        Me.txtLostTagPlace.TabIndex = 12
        '
        'lblReturnTagPlace
        '
        Me.lblReturnTagPlace.AutoSize = True
        Me.lblReturnTagPlace.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReturnTagPlace.Location = New System.Drawing.Point(787, 696)
        Me.lblReturnTagPlace.Name = "lblReturnTagPlace"
        Me.lblReturnTagPlace.Size = New System.Drawing.Size(211, 20)
        Me.lblReturnTagPlace.TabIndex = 13
        Me.lblReturnTagPlace.Text = "Return Tag Placeholder"
        '
        'txtReturnTagPlace
        '
        Me.txtReturnTagPlace.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Tag #", True))
        Me.txtReturnTagPlace.Location = New System.Drawing.Point(1047, 695)
        Me.txtReturnTagPlace.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtReturnTagPlace.Name = "txtReturnTagPlace"
        Me.txtReturnTagPlace.Size = New System.Drawing.Size(85, 22)
        Me.txtReturnTagPlace.TabIndex = 14
        '
        'lblLostRemovalDatePlace
        '
        Me.lblLostRemovalDatePlace.AutoSize = True
        Me.lblLostRemovalDatePlace.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLostRemovalDatePlace.Location = New System.Drawing.Point(28, 737)
        Me.lblLostRemovalDatePlace.Name = "lblLostRemovalDatePlace"
        Me.lblLostRemovalDatePlace.Size = New System.Drawing.Size(235, 20)
        Me.lblLostRemovalDatePlace.TabIndex = 15
        Me.lblLostRemovalDatePlace.Text = "Removal Date Placeholder"
        '
        'txtLostRemovalDatePlace
        '
        Me.txtLostRemovalDatePlace.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Removal Date", True))
        Me.txtLostRemovalDatePlace.Location = New System.Drawing.Point(313, 737)
        Me.txtLostRemovalDatePlace.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtLostRemovalDatePlace.Name = "txtLostRemovalDatePlace"
        Me.txtLostRemovalDatePlace.Size = New System.Drawing.Size(100, 22)
        Me.txtLostRemovalDatePlace.TabIndex = 16
        '
        'txtReturnRemovalDatePlace
        '
        Me.txtReturnRemovalDatePlace.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Removal Date", True))
        Me.txtReturnRemovalDatePlace.Location = New System.Drawing.Point(1039, 739)
        Me.txtReturnRemovalDatePlace.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtReturnRemovalDatePlace.Name = "txtReturnRemovalDatePlace"
        Me.txtReturnRemovalDatePlace.Size = New System.Drawing.Size(100, 22)
        Me.txtReturnRemovalDatePlace.TabIndex = 17
        '
        'lblReturnRemovalDatePlace
        '
        Me.lblReturnRemovalDatePlace.AutoSize = True
        Me.lblReturnRemovalDatePlace.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReturnRemovalDatePlace.Location = New System.Drawing.Point(779, 739)
        Me.lblReturnRemovalDatePlace.Name = "lblReturnRemovalDatePlace"
        Me.lblReturnRemovalDatePlace.Size = New System.Drawing.Size(235, 20)
        Me.lblReturnRemovalDatePlace.TabIndex = 18
        Me.lblReturnRemovalDatePlace.Text = "Removal Date Placeholder"
        '
        'lblLostReasonPlaceholder
        '
        Me.lblLostReasonPlaceholder.AutoSize = True
        Me.lblLostReasonPlaceholder.Font = New System.Drawing.Font("Rockwell", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLostReasonPlaceholder.Location = New System.Drawing.Point(12, 775)
        Me.lblLostReasonPlaceholder.Name = "lblLostReasonPlaceholder"
        Me.lblLostReasonPlaceholder.Size = New System.Drawing.Size(257, 20)
        Me.lblLostReasonPlaceholder.TabIndex = 19
        Me.lblLostReasonPlaceholder.Text = "Removal Reason Placeholder"
        '
        'txtLostReasonPlaceholder
        '
        Me.txtLostReasonPlaceholder.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LostTagsInfoBindingSource, "Removal Reason", True))
        Me.txtLostReasonPlaceholder.Location = New System.Drawing.Point(313, 775)
        Me.txtLostReasonPlaceholder.Name = "txtLostReasonPlaceholder"
        Me.txtLostReasonPlaceholder.Size = New System.Drawing.Size(100, 22)
        Me.txtLostReasonPlaceholder.TabIndex = 20
        '
        'txtReturnReasonPlaceholder
        '
        Me.txtReturnReasonPlaceholder.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReturnedTagsInfoBindingSource, "Removal Reason", True))
        Me.txtReturnReasonPlaceholder.Location = New System.Drawing.Point(1040, 777)
        Me.txtReturnReasonPlaceholder.Name = "txtReturnReasonPlaceholder"
        Me.txtReturnReasonPlaceholder.Size = New System.Drawing.Size(100, 22)
        Me.txtReturnReasonPlaceholder.TabIndex = 21
        '
        'lblReturnReasonPlaceholder
        '
        Me.lblReturnReasonPlaceholder.AutoSize = True
        Me.lblReturnReasonPlaceholder.Font = New System.Drawing.Font("Rockwell", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReturnReasonPlaceholder.Location = New System.Drawing.Point(771, 777)
        Me.lblReturnReasonPlaceholder.Name = "lblReturnReasonPlaceholder"
        Me.lblReturnReasonPlaceholder.Size = New System.Drawing.Size(257, 20)
        Me.lblReturnReasonPlaceholder.TabIndex = 22
        Me.lblReturnReasonPlaceholder.Text = "Removal Reason Placeholder"
        '
        'CustomersInfoTableAdapter
        '
        Me.CustomersInfoTableAdapter.ClearBeforeFill = True
        '
        'LostTagsInfoTableAdapter
        '
        Me.LostTagsInfoTableAdapter.ClearBeforeFill = True
        '
        'ReturnedTagsInfoTableAdapter
        '
        Me.ReturnedTagsInfoTableAdapter.ClearBeforeFill = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1172, 820)
        Me.Controls.Add(Me.grpTagStatusLogin)
        Me.Controls.Add(Me.lblReturnReasonPlaceholder)
        Me.Controls.Add(Me.txtReturnReasonPlaceholder)
        Me.Controls.Add(Me.txtLostReasonPlaceholder)
        Me.Controls.Add(Me.lblLostReasonPlaceholder)
        Me.Controls.Add(Me.lblReturnRemovalDatePlace)
        Me.Controls.Add(Me.txtReturnRemovalDatePlace)
        Me.Controls.Add(Me.txtLostRemovalDatePlace)
        Me.Controls.Add(Me.lblLostRemovalDatePlace)
        Me.Controls.Add(Me.txtReturnTagPlace)
        Me.Controls.Add(Me.lblReturnTagPlace)
        Me.Controls.Add(Me.txtLostTagPlace)
        Me.Controls.Add(Me.btnBackStatus)
        Me.Controls.Add(Me.lblLostTagPlace)
        Me.Controls.Add(Me.grpReportReturn)
        Me.Controls.Add(Me.grpReportLost)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EzPass Tag Status"
        Me.grpReportLost.ResumeLayout(False)
        Me.grpReportLost.PerformLayout()
        CType(Me.CustomersInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EzPassDBSystem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLostDetails.ResumeLayout(False)
        Me.grpLostDetails.PerformLayout()
        CType(Me.LostTagsInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpReportReturn.ResumeLayout(False)
        Me.grpReportReturn.PerformLayout()
        Me.grpReturnDetails.ResumeLayout(False)
        Me.grpReturnDetails.PerformLayout()
        CType(Me.ReturnedTagsInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTagStatusLogin.ResumeLayout(False)
        Me.grpTagStatusLogin.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpReportLost As GroupBox
    Friend WithEvents btnReportLost As Button
    Friend WithEvents btnBackStatus As Button
    Friend WithEvents lblReportLostTag As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtReportLostDate As TextBox
    Friend WithEvents txtReportAcct As TextBox
    Friend WithEvents txtReportLostTag As TextBox
    Friend WithEvents grpReportReturn As GroupBox
    Friend WithEvents lblReportReturnTag As Label
    Friend WithEvents txtTagReturnDate As TextBox
    Friend WithEvents txtReturnAcct As TextBox
    Friend WithEvents txtReturnTag As TextBox
    Friend WithEvents btnReportReturn As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents grpTagStatusLogin As GroupBox
    Friend WithEvents btnLoginTagReturn As Button
    Friend WithEvents btnLoginTagLost As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents btnTagLoginBack As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtLostTagStatus As TextBox
    Friend WithEvents lblLostTagStatus As Label
    Friend WithEvents txtReturnTagStatus As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents lblLostTagPlace As Label
    Friend WithEvents txtLostTagPlace As TextBox
    Friend WithEvents lblReturnTagPlace As Label
    Friend WithEvents txtReturnTagPlace As TextBox
    Friend WithEvents btnBuyTag As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents btnAssignTag As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents lblRetrieveAccount As Label
    Friend WithEvents lblRetrieveTag As Label
    Friend WithEvents lblRetrieveLast As Label
    Friend WithEvents lblRetrieveFirst As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblRetrieveAccount2 As Label
    Friend WithEvents lblRetrieveTag2 As Label
    Friend WithEvents lblRetrieveLast2 As Label
    Friend WithEvents lblRetrieveFirst2 As Label
    Friend WithEvents grpLostDetails As Panel
    Friend WithEvents grpReturnDetails As Panel
    Friend WithEvents cmbLostReason As ComboBox
    Friend WithEvents lblLostReason As Label
    Friend WithEvents cmbReturnReason As ComboBox
    Friend WithEvents lblReturnReason As Label
    Friend WithEvents lblLostRemovalDatePlace As Label
    Friend WithEvents txtLostRemovalDatePlace As TextBox
    Friend WithEvents txtReturnRemovalDatePlace As TextBox
    Friend WithEvents lblReturnRemovalDatePlace As Label
    Friend WithEvents lblLostReasonPlaceholder As Label
    Friend WithEvents txtLostReasonPlaceholder As TextBox
    Friend WithEvents txtReturnReasonPlaceholder As TextBox
    Friend WithEvents lblReturnReasonPlaceholder As Label
    Friend WithEvents EzPassDBSystem As EzPassDBSystem
    Friend WithEvents CustomersInfoBindingSource As BindingSource
    Friend WithEvents CustomersInfoTableAdapter As EzPassDBSystemTableAdapters.CustomersInfoTableAdapter
    Friend WithEvents LostTagsInfoBindingSource As BindingSource
    Friend WithEvents LostTagsInfoTableAdapter As EzPassDBSystemTableAdapters.LostTagsInfoTableAdapter
    Friend WithEvents ReturnedTagsInfoBindingSource As BindingSource
    Friend WithEvents ReturnedTagsInfoTableAdapter As EzPassDBSystemTableAdapters.ReturnedTagsInfoTableAdapter
End Class
