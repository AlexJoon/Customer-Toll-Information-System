<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form12
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
        Me.EzPassDBSystem = New EzPass_Prototype_1.EzPassDBSystem()
        Me.lblTollsTitle = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnRefund = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CustomersTollBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FareEffectiveDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FareDeductedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TolledTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TolledDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TagDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TollLocationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TollCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblTollTitle = New System.Windows.Forms.Label()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TollCodeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TollLocationDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TagDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlateDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TolledDateDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TolledTimeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FareDeductedDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FareEffectiveDateDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTagSearch = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnTagSearch = New System.Windows.Forms.Button()
        Me.CustomersTollTableAdapter = New EzPass_Prototype_1.EzPassDBSystemTableAdapters.CustomersTollTableAdapter()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnDeleteTransaction = New System.Windows.Forms.Button()
        Me.RadDateToll = New System.Windows.Forms.RadioButton()
        Me.RadAll = New System.Windows.Forms.RadioButton()
        Me.RadTollCode = New System.Windows.Forms.RadioButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnRevenue = New System.Windows.Forms.Button()
        Me.PicTollsVector = New System.Windows.Forms.PictureBox()
        CType(Me.EzPassDBSystem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersTollBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PicTollsVector, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EzPassDBSystem
        '
        Me.EzPassDBSystem.DataSetName = "EzPassDBSystem"
        Me.EzPassDBSystem.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblTollsTitle
        '
        Me.lblTollsTitle.AutoSize = True
        Me.lblTollsTitle.BackColor = System.Drawing.Color.Thistle
        Me.lblTollsTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTollsTitle.Font = New System.Drawing.Font("Tahoma", 16.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTollsTitle.Location = New System.Drawing.Point(681, 40)
        Me.lblTollsTitle.Name = "lblTollsTitle"
        Me.lblTollsTitle.Size = New System.Drawing.Size(363, 35)
        Me.lblTollsTitle.TabIndex = 3
        Me.lblTollsTitle.Text = "Tolls Transaction Reports" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Font = New System.Drawing.Font("Rockwell", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(30, 433)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(232, 66)
        Me.btnBack.TabIndex = 4
        Me.btnBack.Text = "Back to Database"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnRefund
        '
        Me.btnRefund.BackColor = System.Drawing.Color.Khaki
        Me.btnRefund.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRefund.Font = New System.Drawing.Font("Rockwell", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefund.Location = New System.Drawing.Point(52, 64)
        Me.btnRefund.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRefund.Name = "btnRefund"
        Me.btnRefund.Size = New System.Drawing.Size(192, 49)
        Me.btnRefund.TabIndex = 11
        Me.btnRefund.Text = "Refund Account"
        Me.btnRefund.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(870, 226)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 33)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Current Tag:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersTollBindingSource, "Tag #", True))
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1090, 224)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 33)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "@@"
        '
        'CustomersTollBindingSource
        '
        Me.CustomersTollBindingSource.DataMember = "CustomersToll"
        Me.CustomersTollBindingSource.DataSource = Me.EzPassDBSystem
        '
        'FareEffectiveDateDataGridViewTextBoxColumn
        '
        Me.FareEffectiveDateDataGridViewTextBoxColumn.DataPropertyName = "Fare Effective Date"
        Me.FareEffectiveDateDataGridViewTextBoxColumn.HeaderText = "Fare Effective Date"
        Me.FareEffectiveDateDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.FareEffectiveDateDataGridViewTextBoxColumn.Name = "FareEffectiveDateDataGridViewTextBoxColumn"
        Me.FareEffectiveDateDataGridViewTextBoxColumn.Width = 150
        '
        'FareDeductedDataGridViewTextBoxColumn
        '
        Me.FareDeductedDataGridViewTextBoxColumn.DataPropertyName = "Fare Deducted"
        Me.FareDeductedDataGridViewTextBoxColumn.HeaderText = "Fare Deducted"
        Me.FareDeductedDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.FareDeductedDataGridViewTextBoxColumn.Name = "FareDeductedDataGridViewTextBoxColumn"
        Me.FareDeductedDataGridViewTextBoxColumn.Width = 150
        '
        'TolledTimeDataGridViewTextBoxColumn
        '
        Me.TolledTimeDataGridViewTextBoxColumn.DataPropertyName = "Tolled Time"
        Me.TolledTimeDataGridViewTextBoxColumn.HeaderText = "Tolled Time"
        Me.TolledTimeDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TolledTimeDataGridViewTextBoxColumn.Name = "TolledTimeDataGridViewTextBoxColumn"
        Me.TolledTimeDataGridViewTextBoxColumn.Width = 150
        '
        'TolledDateDataGridViewTextBoxColumn
        '
        Me.TolledDateDataGridViewTextBoxColumn.DataPropertyName = "Tolled Date"
        Me.TolledDateDataGridViewTextBoxColumn.HeaderText = "Tolled Date"
        Me.TolledDateDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TolledDateDataGridViewTextBoxColumn.Name = "TolledDateDataGridViewTextBoxColumn"
        Me.TolledDateDataGridViewTextBoxColumn.Width = 150
        '
        'PlateDataGridViewTextBoxColumn
        '
        Me.PlateDataGridViewTextBoxColumn.DataPropertyName = "Plate #"
        Me.PlateDataGridViewTextBoxColumn.HeaderText = "Plate #"
        Me.PlateDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.PlateDataGridViewTextBoxColumn.Name = "PlateDataGridViewTextBoxColumn"
        Me.PlateDataGridViewTextBoxColumn.Width = 150
        '
        'TagDataGridViewTextBoxColumn
        '
        Me.TagDataGridViewTextBoxColumn.DataPropertyName = "Tag #"
        Me.TagDataGridViewTextBoxColumn.HeaderText = "Tag #"
        Me.TagDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TagDataGridViewTextBoxColumn.Name = "TagDataGridViewTextBoxColumn"
        Me.TagDataGridViewTextBoxColumn.Width = 150
        '
        'TollLocationDataGridViewTextBoxColumn
        '
        Me.TollLocationDataGridViewTextBoxColumn.DataPropertyName = "Toll Location"
        Me.TollLocationDataGridViewTextBoxColumn.HeaderText = "Toll Location"
        Me.TollLocationDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TollLocationDataGridViewTextBoxColumn.Name = "TollLocationDataGridViewTextBoxColumn"
        Me.TollLocationDataGridViewTextBoxColumn.Width = 150
        '
        'TollCodeDataGridViewTextBoxColumn
        '
        Me.TollCodeDataGridViewTextBoxColumn.DataPropertyName = "Toll Code"
        Me.TollCodeDataGridViewTextBoxColumn.HeaderText = "Toll Code"
        Me.TollCodeDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TollCodeDataGridViewTextBoxColumn.Name = "TollCodeDataGridViewTextBoxColumn"
        Me.TollCodeDataGridViewTextBoxColumn.Width = 150
        '
        'lblTollTitle
        '
        Me.lblTollTitle.AutoSize = True
        Me.lblTollTitle.Font = New System.Drawing.Font("Rockwell", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTollTitle.Location = New System.Drawing.Point(389, 226)
        Me.lblTollTitle.Name = "lblTollTitle"
        Me.lblTollTitle.Size = New System.Drawing.Size(189, 33)
        Me.lblTollTitle.TabIndex = 17
        Me.lblTollTitle.Text = "Current Toll:"
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersTollBindingSource, "Toll Code", True))
        Me.lblLocation.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocation.Location = New System.Drawing.Point(608, 226)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(65, 33)
        Me.lblLocation.TabIndex = 18
        Me.lblLocation.Text = "@@"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TollCodeDataGridViewTextBoxColumn1, Me.TollLocationDataGridViewTextBoxColumn1, Me.TagDataGridViewTextBoxColumn1, Me.PlateDataGridViewTextBoxColumn1, Me.TolledDateDataGridViewTextBoxColumn1, Me.TolledTimeDataGridViewTextBoxColumn1, Me.FareDeductedDataGridViewTextBoxColumn1, Me.FareEffectiveDateDataGridViewTextBoxColumn1})
        Me.DataGridView1.DataSource = Me.CustomersTollBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(56, 11)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.Size = New System.Drawing.Size(760, 299)
        Me.DataGridView1.TabIndex = 0
        '
        'TollCodeDataGridViewTextBoxColumn1
        '
        Me.TollCodeDataGridViewTextBoxColumn1.DataPropertyName = "Toll Code"
        Me.TollCodeDataGridViewTextBoxColumn1.HeaderText = "Toll Code"
        Me.TollCodeDataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.TollCodeDataGridViewTextBoxColumn1.Name = "TollCodeDataGridViewTextBoxColumn1"
        Me.TollCodeDataGridViewTextBoxColumn1.Width = 150
        '
        'TollLocationDataGridViewTextBoxColumn1
        '
        Me.TollLocationDataGridViewTextBoxColumn1.DataPropertyName = "Toll Location"
        Me.TollLocationDataGridViewTextBoxColumn1.HeaderText = "Toll Location"
        Me.TollLocationDataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.TollLocationDataGridViewTextBoxColumn1.Name = "TollLocationDataGridViewTextBoxColumn1"
        Me.TollLocationDataGridViewTextBoxColumn1.Width = 150
        '
        'TagDataGridViewTextBoxColumn1
        '
        Me.TagDataGridViewTextBoxColumn1.DataPropertyName = "Tag #"
        Me.TagDataGridViewTextBoxColumn1.HeaderText = "Tag #"
        Me.TagDataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.TagDataGridViewTextBoxColumn1.Name = "TagDataGridViewTextBoxColumn1"
        Me.TagDataGridViewTextBoxColumn1.Width = 150
        '
        'PlateDataGridViewTextBoxColumn1
        '
        Me.PlateDataGridViewTextBoxColumn1.DataPropertyName = "Plate #"
        Me.PlateDataGridViewTextBoxColumn1.HeaderText = "Plate #"
        Me.PlateDataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.PlateDataGridViewTextBoxColumn1.Name = "PlateDataGridViewTextBoxColumn1"
        Me.PlateDataGridViewTextBoxColumn1.Width = 150
        '
        'TolledDateDataGridViewTextBoxColumn1
        '
        Me.TolledDateDataGridViewTextBoxColumn1.DataPropertyName = "Tolled Date"
        Me.TolledDateDataGridViewTextBoxColumn1.HeaderText = "Tolled Date"
        Me.TolledDateDataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.TolledDateDataGridViewTextBoxColumn1.Name = "TolledDateDataGridViewTextBoxColumn1"
        Me.TolledDateDataGridViewTextBoxColumn1.Width = 150
        '
        'TolledTimeDataGridViewTextBoxColumn1
        '
        Me.TolledTimeDataGridViewTextBoxColumn1.DataPropertyName = "Tolled Time"
        Me.TolledTimeDataGridViewTextBoxColumn1.HeaderText = "Tolled Time"
        Me.TolledTimeDataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.TolledTimeDataGridViewTextBoxColumn1.Name = "TolledTimeDataGridViewTextBoxColumn1"
        Me.TolledTimeDataGridViewTextBoxColumn1.Width = 150
        '
        'FareDeductedDataGridViewTextBoxColumn1
        '
        Me.FareDeductedDataGridViewTextBoxColumn1.DataPropertyName = "Fare Deducted"
        Me.FareDeductedDataGridViewTextBoxColumn1.HeaderText = "Fare Deducted"
        Me.FareDeductedDataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.FareDeductedDataGridViewTextBoxColumn1.Name = "FareDeductedDataGridViewTextBoxColumn1"
        Me.FareDeductedDataGridViewTextBoxColumn1.Width = 150
        '
        'FareEffectiveDateDataGridViewTextBoxColumn1
        '
        Me.FareEffectiveDateDataGridViewTextBoxColumn1.DataPropertyName = "Fare Effective Date"
        Me.FareEffectiveDateDataGridViewTextBoxColumn1.HeaderText = "Fare Effective Date"
        Me.FareEffectiveDateDataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.FareEffectiveDateDataGridViewTextBoxColumn1.Name = "FareEffectiveDateDataGridViewTextBoxColumn1"
        Me.FareEffectiveDateDataGridViewTextBoxColumn1.Width = 150
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(508, 158)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 29)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Filter By:"
        '
        'txtTagSearch
        '
        Me.txtTagSearch.Location = New System.Drawing.Point(64, 302)
        Me.txtTagSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTagSearch.Name = "txtTagSearch"
        Me.txtTagSearch.Size = New System.Drawing.Size(170, 22)
        Me.txtTagSearch.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Rockwell", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(39, 262)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(211, 24)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Search Specific Tag:"
        '
        'btnTagSearch
        '
        Me.btnTagSearch.BackColor = System.Drawing.Color.Khaki
        Me.btnTagSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTagSearch.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTagSearch.Location = New System.Drawing.Point(52, 339)
        Me.btnTagSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTagSearch.Name = "btnTagSearch"
        Me.btnTagSearch.Size = New System.Drawing.Size(192, 49)
        Me.btnTagSearch.TabIndex = 25
        Me.btnTagSearch.Text = "Search Tag"
        Me.btnTagSearch.UseVisualStyleBackColor = False
        '
        'CustomersTollTableAdapter
        '
        Me.CustomersTollTableAdapter.ClearBeforeFill = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Rockwell", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(767, 227)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 33)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "&&&&"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Rockwell", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(18, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(257, 24)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Refund Toll Transaction:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MistyRose
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.btnDeleteTransaction)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.btnRefund)
        Me.Panel1.Controls.Add(Me.btnTagSearch)
        Me.Panel1.Controls.Add(Me.txtTagSearch)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.btnBack)
        Me.Panel1.Location = New System.Drawing.Point(20, 130)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(295, 527)
        Me.Panel1.TabIndex = 29
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Rockwell", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(39, 141)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(204, 24)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Delete Transaction:"
        '
        'btnDeleteTransaction
        '
        Me.btnDeleteTransaction.BackColor = System.Drawing.Color.Khaki
        Me.btnDeleteTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDeleteTransaction.Font = New System.Drawing.Font("Rockwell", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteTransaction.Location = New System.Drawing.Point(52, 181)
        Me.btnDeleteTransaction.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDeleteTransaction.Name = "btnDeleteTransaction"
        Me.btnDeleteTransaction.Size = New System.Drawing.Size(192, 49)
        Me.btnDeleteTransaction.TabIndex = 29
        Me.btnDeleteTransaction.Text = "Delete"
        Me.btnDeleteTransaction.UseVisualStyleBackColor = False
        '
        'RadDateToll
        '
        Me.RadDateToll.AutoSize = True
        Me.RadDateToll.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadDateToll.Location = New System.Drawing.Point(936, 160)
        Me.RadDateToll.Margin = New System.Windows.Forms.Padding(4)
        Me.RadDateToll.Name = "RadDateToll"
        Me.RadDateToll.Size = New System.Drawing.Size(141, 27)
        Me.RadDateToll.TabIndex = 24
        Me.RadDateToll.TabStop = True
        Me.RadDateToll.Text = "Date of Toll"
        Me.RadDateToll.UseVisualStyleBackColor = True
        '
        'RadAll
        '
        Me.RadAll.AutoSize = True
        Me.RadAll.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadAll.Location = New System.Drawing.Point(670, 160)
        Me.RadAll.Margin = New System.Windows.Forms.Padding(4)
        Me.RadAll.Name = "RadAll"
        Me.RadAll.Size = New System.Drawing.Size(58, 27)
        Me.RadAll.TabIndex = 20
        Me.RadAll.TabStop = True
        Me.RadAll.Text = "All"
        Me.RadAll.UseVisualStyleBackColor = True
        '
        'RadTollCode
        '
        Me.RadTollCode.AutoSize = True
        Me.RadTollCode.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTollCode.Location = New System.Drawing.Point(773, 161)
        Me.RadTollCode.Margin = New System.Windows.Forms.Padding(4)
        Me.RadTollCode.Name = "RadTollCode"
        Me.RadTollCode.Size = New System.Drawing.Size(123, 27)
        Me.RadTollCode.TabIndex = 21
        Me.RadTollCode.TabStop = True
        Me.RadTollCode.Text = "Toll Code"
        Me.RadTollCode.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Location = New System.Drawing.Point(339, 311)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(866, 331)
        Me.Panel2.TabIndex = 30
        '
        'btnRevenue
        '
        Me.btnRevenue.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnRevenue.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRevenue.Font = New System.Drawing.Font("Rockwell", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRevenue.Location = New System.Drawing.Point(48, 29)
        Me.btnRevenue.Name = "btnRevenue"
        Me.btnRevenue.Size = New System.Drawing.Size(243, 69)
        Me.btnRevenue.TabIndex = 31
        Me.btnRevenue.Text = "Revenue Reports"
        Me.btnRevenue.UseVisualStyleBackColor = False
        '
        'PicTollsVector
        '
        Me.PicTollsVector.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicTollsVector.Image = Global.EzPass_Prototype_1.My.Resources.Resources.Database_Vector1
        Me.PicTollsVector.Location = New System.Drawing.Point(541, 10)
        Me.PicTollsVector.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PicTollsVector.Name = "PicTollsVector"
        Me.PicTollsVector.Size = New System.Drawing.Size(94, 88)
        Me.PicTollsVector.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicTollsVector.TabIndex = 2
        Me.PicTollsVector.TabStop = False
        '
        'Form12
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1217, 668)
        Me.Controls.Add(Me.btnRevenue)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.RadDateToll)
        Me.Controls.Add(Me.RadTollCode)
        Me.Controls.Add(Me.RadAll)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblLocation)
        Me.Controls.Add(Me.lblTollTitle)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTollsTitle)
        Me.Controls.Add(Me.PicTollsVector)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form12"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EzPass Tolls"
        CType(Me.EzPassDBSystem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersTollBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PicTollsVector, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EzPassDBSystem As EzPassDBSystem
    Friend WithEvents PicTollsVector As PictureBox
    Friend WithEvents lblTollsTitle As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents btnRefund As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents FareEffectiveDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FareDeductedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TolledTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TolledDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PlateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TagDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TollLocationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TollCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents lblTollTitle As Label
    Friend WithEvents lblLocation As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTagSearch As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnTagSearch As Button
    Friend WithEvents CustomersTollBindingSource As BindingSource
    Friend WithEvents CustomersTollTableAdapter As EzPassDBSystemTableAdapters.CustomersTollTableAdapter
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RadDateToll As RadioButton
    Friend WithEvents RadAll As RadioButton
    Friend WithEvents RadTollCode As RadioButton
    Friend WithEvents TollCodeDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents TollLocationDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents TagDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PlateDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents TolledDateDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents TolledTimeDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents FareDeductedDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents FareEffectiveDateDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents btnDeleteTransaction As Button
    Friend WithEvents btnRevenue As Button
End Class
