<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form14
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnProcess = New System.Windows.Forms.Button()
        Me.btnSecondBack = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblAcctBal = New System.Windows.Forms.Label()
        Me.lblAcctTitle = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CustomersInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EzPassDBSystem = New EzPass_Prototype_1.EzPassDBSystem()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAccount = New System.Windows.Forms.TextBox()
        Me.txtFareDeduct = New System.Windows.Forms.TextBox()
        Me.TollCodesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtAcctBal = New System.Windows.Forms.TextBox()
        Me.CustomersInfoTableAdapter = New EzPass_Prototype_1.EzPassDBSystemTableAdapters.CustomersInfoTableAdapter()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DatTollFares = New System.Windows.Forms.DataGridView()
        Me.TollCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FaresDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtTollUsed = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFareDiscounted = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RadYes = New System.Windows.Forms.RadioButton()
        Me.RadNo = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblFareCurrentDate = New System.Windows.Forms.Label()
        Me.lblFareDateTitle = New System.Windows.Forms.Label()
        Me.TollCodesTableAdapter = New EzPass_Prototype_1.EzPassDBSystemTableAdapters.TollCodesTableAdapter()
        Me.grpRefundLogin = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblRemind = New System.Windows.Forms.Label()
        Me.txtTagSearch = New System.Windows.Forms.TextBox()
        Me.lblTagQuestion = New System.Windows.Forms.Label()
        Me.lblRefundTitle = New System.Windows.Forms.Label()
        Me.btnEnterRefund = New System.Windows.Forms.Button()
        Me.btnFirstBack = New System.Windows.Forms.Button()
        CType(Me.CustomersInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EzPassDBSystem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TollCodesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.DatTollFares, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpRefundLogin.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(523, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Account # :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(478, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(196, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Toll that was Used:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnProcess
        '
        Me.btnProcess.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnProcess.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnProcess.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProcess.Location = New System.Drawing.Point(619, 528)
        Me.btnProcess.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(253, 74)
        Me.btnProcess.TabIndex = 3
        Me.btnProcess.Text = "Process Refund"
        Me.btnProcess.UseVisualStyleBackColor = False
        '
        'btnSecondBack
        '
        Me.btnSecondBack.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnSecondBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSecondBack.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSecondBack.Location = New System.Drawing.Point(136, 528)
        Me.btnSecondBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSecondBack.Name = "btnSecondBack"
        Me.btnSecondBack.Size = New System.Drawing.Size(253, 74)
        Me.btnSecondBack.TabIndex = 4
        Me.btnSecondBack.Text = "Back to Toll Reports"
        Me.btnSecondBack.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(523, 217)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Toll Fare:"
        '
        'lblAcctBal
        '
        Me.lblAcctBal.AutoSize = True
        Me.lblAcctBal.Font = New System.Drawing.Font("Rockwell", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAcctBal.Location = New System.Drawing.Point(579, 398)
        Me.lblAcctBal.Name = "lblAcctBal"
        Me.lblAcctBal.Size = New System.Drawing.Size(280, 29)
        Me.lblAcctBal.TabIndex = 6
        Me.lblAcctBal.Text = "New Account Balance:"
        '
        'lblAcctTitle
        '
        Me.lblAcctTitle.AutoSize = True
        Me.lblAcctTitle.BackColor = System.Drawing.Color.LightSkyBlue
        Me.lblAcctTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAcctTitle.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAcctTitle.Location = New System.Drawing.Point(286, 32)
        Me.lblAcctTitle.Name = "lblAcctTitle"
        Me.lblAcctTitle.Size = New System.Drawing.Size(234, 35)
        Me.lblAcctTitle.TabIndex = 7
        Me.lblAcctTitle.Text = "Account Holder:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "First Name", True))
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(568, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 33)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "@@"
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Last Name", True))
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(693, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 33)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "@@"
        '
        'txtAccount
        '
        Me.txtAccount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Account #", True))
        Me.txtAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccount.Location = New System.Drawing.Point(797, 110)
        Me.txtAccount.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAccount.Name = "txtAccount"
        Me.txtAccount.ReadOnly = True
        Me.txtAccount.Size = New System.Drawing.Size(177, 28)
        Me.txtAccount.TabIndex = 10
        '
        'txtFareDeduct
        '
        Me.txtFareDeduct.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TollCodesBindingSource, "Fares", True))
        Me.txtFareDeduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFareDeduct.Location = New System.Drawing.Point(797, 213)
        Me.txtFareDeduct.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFareDeduct.Name = "txtFareDeduct"
        Me.txtFareDeduct.ReadOnly = True
        Me.txtFareDeduct.Size = New System.Drawing.Size(177, 28)
        Me.txtFareDeduct.TabIndex = 12
        '
        'TollCodesBindingSource
        '
        Me.TollCodesBindingSource.DataMember = "TollCodes"
        Me.TollCodesBindingSource.DataSource = Me.EzPassDBSystem
        '
        'txtAcctBal
        '
        Me.txtAcctBal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Account Balance", True))
        Me.txtAcctBal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAcctBal.Location = New System.Drawing.Point(635, 450)
        Me.txtAcctBal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAcctBal.Name = "txtAcctBal"
        Me.txtAcctBal.ReadOnly = True
        Me.txtAcctBal.Size = New System.Drawing.Size(177, 34)
        Me.txtAcctBal.TabIndex = 13
        '
        'CustomersInfoTableAdapter
        '
        Me.CustomersInfoTableAdapter.ClearBeforeFill = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel2.Controls.Add(Me.DatTollFares)
        Me.Panel2.Location = New System.Drawing.Point(16, 153)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(371, 288)
        Me.Panel2.TabIndex = 29
        '
        'DatTollFares
        '
        Me.DatTollFares.AutoGenerateColumns = False
        Me.DatTollFares.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical
        Me.DatTollFares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DatTollFares.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TollCodeDataGridViewTextBoxColumn, Me.FaresDataGridViewTextBoxColumn})
        Me.DatTollFares.DataSource = Me.TollCodesBindingSource
        Me.DatTollFares.GridColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DatTollFares.Location = New System.Drawing.Point(13, 4)
        Me.DatTollFares.Margin = New System.Windows.Forms.Padding(4)
        Me.DatTollFares.Name = "DatTollFares"
        Me.DatTollFares.RowHeadersWidth = 62
        Me.DatTollFares.Size = New System.Drawing.Size(349, 278)
        Me.DatTollFares.TabIndex = 0
        '
        'TollCodeDataGridViewTextBoxColumn
        '
        Me.TollCodeDataGridViewTextBoxColumn.DataPropertyName = "Toll Code"
        Me.TollCodeDataGridViewTextBoxColumn.HeaderText = "Toll Code"
        Me.TollCodeDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TollCodeDataGridViewTextBoxColumn.Name = "TollCodeDataGridViewTextBoxColumn"
        Me.TollCodeDataGridViewTextBoxColumn.Width = 150
        '
        'FaresDataGridViewTextBoxColumn
        '
        Me.FaresDataGridViewTextBoxColumn.DataPropertyName = "Fares"
        Me.FaresDataGridViewTextBoxColumn.HeaderText = "Fares"
        Me.FaresDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.FaresDataGridViewTextBoxColumn.Name = "FaresDataGridViewTextBoxColumn"
        Me.FaresDataGridViewTextBoxColumn.Width = 150
        '
        'txtTollUsed
        '
        Me.txtTollUsed.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TollCodesBindingSource, "Toll Code", True))
        Me.txtTollUsed.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTollUsed.Location = New System.Drawing.Point(797, 162)
        Me.txtTollUsed.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTollUsed.Name = "txtTollUsed"
        Me.txtTollUsed.ReadOnly = True
        Me.txtTollUsed.Size = New System.Drawing.Size(177, 29)
        Me.txtTollUsed.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Rockwell", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(462, 276)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(236, 24)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "EzPass Fare Deducted:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtFareDiscounted
        '
        Me.txtFareDiscounted.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFareDiscounted.Location = New System.Drawing.Point(797, 270)
        Me.txtFareDiscounted.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFareDiscounted.Name = "txtFareDiscounted"
        Me.txtFareDiscounted.ReadOnly = True
        Me.txtFareDiscounted.Size = New System.Drawing.Size(177, 29)
        Me.txtFareDiscounted.TabIndex = 32
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Rockwell", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(71, 114)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(255, 24)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Current Toll Fare Prices:"
        '
        'RadYes
        '
        Me.RadYes.AutoSize = True
        Me.RadYes.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadYes.Location = New System.Drawing.Point(766, 340)
        Me.RadYes.Margin = New System.Windows.Forms.Padding(4)
        Me.RadYes.Name = "RadYes"
        Me.RadYes.Size = New System.Drawing.Size(65, 27)
        Me.RadYes.TabIndex = 34
        Me.RadYes.TabStop = True
        Me.RadYes.Text = "Yes"
        Me.RadYes.UseVisualStyleBackColor = True
        '
        'RadNo
        '
        Me.RadNo.AutoSize = True
        Me.RadNo.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadNo.Location = New System.Drawing.Point(845, 340)
        Me.RadNo.Margin = New System.Windows.Forms.Padding(4)
        Me.RadNo.Name = "RadNo"
        Me.RadNo.Size = New System.Drawing.Size(57, 27)
        Me.RadNo.TabIndex = 35
        Me.RadNo.TabStop = True
        Me.RadNo.Text = "No"
        Me.RadNo.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Rockwell", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(520, 341)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(179, 24)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Refund this Toll?"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(760, 218)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(18, 20)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "$"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(760, 277)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(18, 20)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "$"
        '
        'lblFareCurrentDate
        '
        Me.lblFareCurrentDate.AutoSize = True
        Me.lblFareCurrentDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TollCodesBindingSource, "Fare Effective Date", True))
        Me.lblFareCurrentDate.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFareCurrentDate.Location = New System.Drawing.Point(202, 458)
        Me.lblFareCurrentDate.Name = "lblFareCurrentDate"
        Me.lblFareCurrentDate.Size = New System.Drawing.Size(50, 24)
        Me.lblFareCurrentDate.TabIndex = 39
        Me.lblFareCurrentDate.Text = "@@"
        '
        'lblFareDateTitle
        '
        Me.lblFareDateTitle.AutoSize = True
        Me.lblFareDateTitle.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFareDateTitle.Location = New System.Drawing.Point(123, 458)
        Me.lblFareDateTitle.Name = "lblFareDateTitle"
        Me.lblFareDateTitle.Size = New System.Drawing.Size(75, 24)
        Me.lblFareDateTitle.TabIndex = 40
        Me.lblFareDateTitle.Text = "As Of :"
        '
        'TollCodesTableAdapter
        '
        Me.TollCodesTableAdapter.ClearBeforeFill = True
        '
        'grpRefundLogin
        '
        Me.grpRefundLogin.AutoSize = True
        Me.grpRefundLogin.BackgroundImage = Global.EzPass_Prototype_1.My.Resources.Resources.Ezpass_Registration_Login_Background
        Me.grpRefundLogin.Controls.Add(Me.PictureBox1)
        Me.grpRefundLogin.Controls.Add(Me.lblRemind)
        Me.grpRefundLogin.Controls.Add(Me.txtTagSearch)
        Me.grpRefundLogin.Controls.Add(Me.lblTagQuestion)
        Me.grpRefundLogin.Controls.Add(Me.lblRefundTitle)
        Me.grpRefundLogin.Controls.Add(Me.btnEnterRefund)
        Me.grpRefundLogin.Controls.Add(Me.btnFirstBack)
        Me.grpRefundLogin.Location = New System.Drawing.Point(12, 11)
        Me.grpRefundLogin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpRefundLogin.Name = "grpRefundLogin"
        Me.grpRefundLogin.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpRefundLogin.Size = New System.Drawing.Size(1008, 610)
        Me.grpRefundLogin.TabIndex = 0
        Me.grpRefundLogin.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.EzPass_Prototype_1.My.Resources.Resources.Toll_Refund_Vector
        Me.PictureBox1.Location = New System.Drawing.Point(318, 34)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(110, 88)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'lblRemind
        '
        Me.lblRemind.AutoSize = True
        Me.lblRemind.BackColor = System.Drawing.Color.LightSkyBlue
        Me.lblRemind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRemind.Font = New System.Drawing.Font("Rockwell", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemind.Location = New System.Drawing.Point(120, 549)
        Me.lblRemind.Name = "lblRemind"
        Me.lblRemind.Size = New System.Drawing.Size(751, 25)
        Me.lblRemind.TabIndex = 5
        Me.lblRemind.Text = "Reminder: New Account Balance will be displayed after choosing a Toll Code."
        '
        'txtTagSearch
        '
        Me.txtTagSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTagSearch.Location = New System.Drawing.Point(386, 286)
        Me.txtTagSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTagSearch.Name = "txtTagSearch"
        Me.txtTagSearch.Size = New System.Drawing.Size(257, 28)
        Me.txtTagSearch.TabIndex = 4
        '
        'lblTagQuestion
        '
        Me.lblTagQuestion.AutoSize = True
        Me.lblTagQuestion.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.lblTagQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTagQuestion.Font = New System.Drawing.Font("Rockwell", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTagQuestion.Location = New System.Drawing.Point(407, 209)
        Me.lblTagQuestion.Name = "lblTagQuestion"
        Me.lblTagQuestion.Size = New System.Drawing.Size(200, 26)
        Me.lblTagQuestion.TabIndex = 3
        Me.lblTagQuestion.Text = "What is the Tag # ?"
        '
        'lblRefundTitle
        '
        Me.lblRefundTitle.AutoSize = True
        Me.lblRefundTitle.BackColor = System.Drawing.Color.LightSkyBlue
        Me.lblRefundTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRefundTitle.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRefundTitle.Location = New System.Drawing.Point(448, 57)
        Me.lblRefundTitle.Name = "lblRefundTitle"
        Me.lblRefundTitle.Size = New System.Drawing.Size(172, 35)
        Me.lblRefundTitle.TabIndex = 2
        Me.lblRefundTitle.Text = "Toll Refund"
        '
        'btnEnterRefund
        '
        Me.btnEnterRefund.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnEnterRefund.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEnterRefund.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnterRefund.Location = New System.Drawing.Point(671, 414)
        Me.btnEnterRefund.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEnterRefund.Name = "btnEnterRefund"
        Me.btnEnterRefund.Size = New System.Drawing.Size(253, 74)
        Me.btnEnterRefund.TabIndex = 1
        Me.btnEnterRefund.Text = "Enter Refund"
        Me.btnEnterRefund.UseVisualStyleBackColor = False
        '
        'btnFirstBack
        '
        Me.btnFirstBack.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnFirstBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFirstBack.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFirstBack.Location = New System.Drawing.Point(67, 414)
        Me.btnFirstBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnFirstBack.Name = "btnFirstBack"
        Me.btnFirstBack.Size = New System.Drawing.Size(253, 74)
        Me.btnFirstBack.TabIndex = 0
        Me.btnFirstBack.Text = "Back to Previous"
        Me.btnFirstBack.UseVisualStyleBackColor = False
        '
        'Form14
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1026, 626)
        Me.Controls.Add(Me.grpRefundLogin)
        Me.Controls.Add(Me.lblFareDateTitle)
        Me.Controls.Add(Me.lblFareCurrentDate)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.RadNo)
        Me.Controls.Add(Me.RadYes)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtFareDiscounted)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTollUsed)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txtAcctBal)
        Me.Controls.Add(Me.txtFareDeduct)
        Me.Controls.Add(Me.txtAccount)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblAcctTitle)
        Me.Controls.Add(Me.lblAcctBal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnSecondBack)
        Me.Controls.Add(Me.btnProcess)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form14"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Toll Refund"
        CType(Me.CustomersInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EzPassDBSystem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TollCodesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DatTollFares, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpRefundLogin.ResumeLayout(False)
        Me.grpRefundLogin.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpRefundLogin As GroupBox
    Friend WithEvents txtTagSearch As TextBox
    Friend WithEvents lblTagQuestion As Label
    Friend WithEvents lblRefundTitle As Label
    Friend WithEvents btnEnterRefund As Button
    Friend WithEvents btnFirstBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnProcess As Button
    Friend WithEvents btnSecondBack As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lblAcctBal As Label
    Friend WithEvents lblAcctTitle As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtAccount As TextBox
    Friend WithEvents txtFareDeduct As TextBox
    Friend WithEvents txtAcctBal As TextBox
    Friend WithEvents EzPassDBSystem As EzPassDBSystem
    Friend WithEvents CustomersInfoBindingSource As BindingSource
    Friend WithEvents CustomersInfoTableAdapter As EzPassDBSystemTableAdapters.CustomersInfoTableAdapter
    Friend WithEvents lblRemind As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DatTollFares As DataGridView
    Friend WithEvents txtTollUsed As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtFareDiscounted As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents RadYes As RadioButton
    Friend WithEvents RadNo As RadioButton
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblFareCurrentDate As Label
    Friend WithEvents lblFareDateTitle As Label
    Friend WithEvents TollCodesBindingSource As BindingSource
    Friend WithEvents TollCodesTableAdapter As EzPassDBSystemTableAdapters.TollCodesTableAdapter
    Friend WithEvents TollCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FaresDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As PictureBox
End Class
