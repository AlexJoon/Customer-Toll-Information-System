<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form11
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
        Me.grpTollsLogin = New System.Windows.Forms.GroupBox()
        Me.lblReminder = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.txtTagSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpTollData = New System.Windows.Forms.GroupBox()
        Me.DatPTolls = New System.Windows.Forms.DataGridView()
        Me.TollCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TollLocationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TagDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TolledDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TolledTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FareDeductedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FareEffectiveDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomersTollBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EzPassDBSystem = New EzPass_Prototype_1.EzPassDBSystem()
        Me.btnSecBack = New System.Windows.Forms.Button()
        Me.btnAddFunds = New System.Windows.Forms.Button()
        Me.lblFundsTitle = New System.Windows.Forms.Label()
        Me.lblCurrentFunds = New System.Windows.Forms.Label()
        Me.CustomersInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CustomersInfoTableAdapter = New EzPass_Prototype_1.EzPassDBSystemTableAdapters.CustomersInfoTableAdapter()
        Me.CustomersTollTableAdapter = New EzPass_Prototype_1.EzPassDBSystemTableAdapters.CustomersTollTableAdapter()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblAcctStatus = New System.Windows.Forms.Label()
        Me.lblFundsReminder = New System.Windows.Forms.Label()
        Me.grpTollsLogin.SuspendLayout()
        Me.grpTollData.SuspendLayout()
        CType(Me.DatPTolls, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersTollBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EzPassDBSystem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpTollsLogin
        '
        Me.grpTollsLogin.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.grpTollsLogin.BackgroundImage = Global.EzPass_Prototype_1.My.Resources.Resources.Ezpass_Registration_Login_Background
        Me.grpTollsLogin.Controls.Add(Me.lblReminder)
        Me.grpTollsLogin.Controls.Add(Me.Label2)
        Me.grpTollsLogin.Controls.Add(Me.btnEnter)
        Me.grpTollsLogin.Controls.Add(Me.btnBack)
        Me.grpTollsLogin.Controls.Add(Me.txtTagSearch)
        Me.grpTollsLogin.Controls.Add(Me.Label1)
        Me.grpTollsLogin.Location = New System.Drawing.Point(12, 11)
        Me.grpTollsLogin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpTollsLogin.Name = "grpTollsLogin"
        Me.grpTollsLogin.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpTollsLogin.Size = New System.Drawing.Size(985, 538)
        Me.grpTollsLogin.TabIndex = 0
        Me.grpTollsLogin.TabStop = False
        '
        'lblReminder
        '
        Me.lblReminder.AutoSize = True
        Me.lblReminder.BackColor = System.Drawing.Color.NavajoWhite
        Me.lblReminder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblReminder.Font = New System.Drawing.Font("Rockwell", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReminder.Location = New System.Drawing.Point(28, 482)
        Me.lblReminder.Name = "lblReminder"
        Me.lblReminder.Size = New System.Drawing.Size(856, 26)
        Me.lblReminder.TabIndex = 5
        Me.lblReminder.Text = "Reminder: Notifications will prompt you to add funds if the Account Balance will " &
    "get below $ 25." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(383, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(202, 26)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Enter Your Plate # :"
        '
        'btnEnter
        '
        Me.btnEnter.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEnter.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter.Location = New System.Drawing.Point(672, 356)
        Me.btnEnter.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(235, 68)
        Me.btnEnter.TabIndex = 3
        Me.btnEnter.Text = "Enter Tolls Information"
        Me.btnEnter.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(73, 356)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(235, 68)
        Me.btnBack.TabIndex = 1
        Me.btnBack.Text = "Back to Update" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'txtTagSearch
        '
        Me.txtTagSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTagSearch.Location = New System.Drawing.Point(313, 222)
        Me.txtTagSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTagSearch.Name = "txtTagSearch"
        Me.txtTagSearch.Size = New System.Drawing.Size(360, 28)
        Me.txtTagSearch.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.NavajoWhite
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 16.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(379, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer Tolls"
        '
        'grpTollData
        '
        Me.grpTollData.Controls.Add(Me.DatPTolls)
        Me.grpTollData.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpTollData.Location = New System.Drawing.Point(21, 84)
        Me.grpTollData.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpTollData.Name = "grpTollData"
        Me.grpTollData.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpTollData.Size = New System.Drawing.Size(962, 236)
        Me.grpTollData.TabIndex = 1
        Me.grpTollData.TabStop = False
        '
        'DatPTolls
        '
        Me.DatPTolls.AutoGenerateColumns = False
        Me.DatPTolls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DatPTolls.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TollCodeDataGridViewTextBoxColumn, Me.TollLocationDataGridViewTextBoxColumn, Me.TagDataGridViewTextBoxColumn, Me.PlateDataGridViewTextBoxColumn, Me.TolledDateDataGridViewTextBoxColumn, Me.TolledTimeDataGridViewTextBoxColumn, Me.FareDeductedDataGridViewTextBoxColumn, Me.FareEffectiveDateDataGridViewTextBoxColumn})
        Me.DatPTolls.DataSource = Me.CustomersTollBindingSource
        Me.DatPTolls.Location = New System.Drawing.Point(21, 18)
        Me.DatPTolls.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DatPTolls.Name = "DatPTolls"
        Me.DatPTolls.RowHeadersWidth = 62
        Me.DatPTolls.RowTemplate.Height = 28
        Me.DatPTolls.Size = New System.Drawing.Size(921, 208)
        Me.DatPTolls.TabIndex = 0
        '
        'TollCodeDataGridViewTextBoxColumn
        '
        Me.TollCodeDataGridViewTextBoxColumn.DataPropertyName = "Toll Code"
        Me.TollCodeDataGridViewTextBoxColumn.HeaderText = "Toll Code"
        Me.TollCodeDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TollCodeDataGridViewTextBoxColumn.Name = "TollCodeDataGridViewTextBoxColumn"
        Me.TollCodeDataGridViewTextBoxColumn.Width = 150
        '
        'TollLocationDataGridViewTextBoxColumn
        '
        Me.TollLocationDataGridViewTextBoxColumn.DataPropertyName = "Toll Location"
        Me.TollLocationDataGridViewTextBoxColumn.HeaderText = "Toll Location"
        Me.TollLocationDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TollLocationDataGridViewTextBoxColumn.Name = "TollLocationDataGridViewTextBoxColumn"
        Me.TollLocationDataGridViewTextBoxColumn.Width = 150
        '
        'TagDataGridViewTextBoxColumn
        '
        Me.TagDataGridViewTextBoxColumn.DataPropertyName = "Tag #"
        Me.TagDataGridViewTextBoxColumn.HeaderText = "Tag #"
        Me.TagDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TagDataGridViewTextBoxColumn.Name = "TagDataGridViewTextBoxColumn"
        Me.TagDataGridViewTextBoxColumn.Width = 150
        '
        'PlateDataGridViewTextBoxColumn
        '
        Me.PlateDataGridViewTextBoxColumn.DataPropertyName = "Plate #"
        Me.PlateDataGridViewTextBoxColumn.HeaderText = "Plate #"
        Me.PlateDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.PlateDataGridViewTextBoxColumn.Name = "PlateDataGridViewTextBoxColumn"
        Me.PlateDataGridViewTextBoxColumn.Width = 150
        '
        'TolledDateDataGridViewTextBoxColumn
        '
        Me.TolledDateDataGridViewTextBoxColumn.DataPropertyName = "Tolled Date"
        Me.TolledDateDataGridViewTextBoxColumn.HeaderText = "Tolled Date"
        Me.TolledDateDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TolledDateDataGridViewTextBoxColumn.Name = "TolledDateDataGridViewTextBoxColumn"
        Me.TolledDateDataGridViewTextBoxColumn.Width = 150
        '
        'TolledTimeDataGridViewTextBoxColumn
        '
        Me.TolledTimeDataGridViewTextBoxColumn.DataPropertyName = "Tolled Time"
        Me.TolledTimeDataGridViewTextBoxColumn.HeaderText = "Tolled Time"
        Me.TolledTimeDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TolledTimeDataGridViewTextBoxColumn.Name = "TolledTimeDataGridViewTextBoxColumn"
        Me.TolledTimeDataGridViewTextBoxColumn.Width = 150
        '
        'FareDeductedDataGridViewTextBoxColumn
        '
        Me.FareDeductedDataGridViewTextBoxColumn.DataPropertyName = "Fare Deducted"
        Me.FareDeductedDataGridViewTextBoxColumn.HeaderText = "Fare Deducted"
        Me.FareDeductedDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.FareDeductedDataGridViewTextBoxColumn.Name = "FareDeductedDataGridViewTextBoxColumn"
        Me.FareDeductedDataGridViewTextBoxColumn.Width = 150
        '
        'FareEffectiveDateDataGridViewTextBoxColumn
        '
        Me.FareEffectiveDateDataGridViewTextBoxColumn.DataPropertyName = "Fare Effective Date"
        Me.FareEffectiveDateDataGridViewTextBoxColumn.HeaderText = "Fare Effective Date"
        Me.FareEffectiveDateDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.FareEffectiveDateDataGridViewTextBoxColumn.Name = "FareEffectiveDateDataGridViewTextBoxColumn"
        Me.FareEffectiveDateDataGridViewTextBoxColumn.Width = 150
        '
        'CustomersTollBindingSource
        '
        Me.CustomersTollBindingSource.DataMember = "CustomersToll"
        Me.CustomersTollBindingSource.DataSource = Me.EzPassDBSystem
        '
        'EzPassDBSystem
        '
        Me.EzPassDBSystem.DataSetName = "EzPassDBSystem"
        Me.EzPassDBSystem.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnSecBack
        '
        Me.btnSecBack.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnSecBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSecBack.Font = New System.Drawing.Font("Rockwell", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSecBack.Location = New System.Drawing.Point(43, 453)
        Me.btnSecBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSecBack.Name = "btnSecBack"
        Me.btnSecBack.Size = New System.Drawing.Size(233, 74)
        Me.btnSecBack.TabIndex = 2
        Me.btnSecBack.Text = "Back to Previous"
        Me.btnSecBack.UseVisualStyleBackColor = False
        '
        'btnAddFunds
        '
        Me.btnAddFunds.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnAddFunds.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddFunds.Font = New System.Drawing.Font("Rockwell", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddFunds.Location = New System.Drawing.Point(729, 453)
        Me.btnAddFunds.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddFunds.Name = "btnAddFunds"
        Me.btnAddFunds.Size = New System.Drawing.Size(233, 74)
        Me.btnAddFunds.TabIndex = 3
        Me.btnAddFunds.Text = "Add More Funds"
        Me.btnAddFunds.UseVisualStyleBackColor = False
        '
        'lblFundsTitle
        '
        Me.lblFundsTitle.AutoSize = True
        Me.lblFundsTitle.Font = New System.Drawing.Font("Rockwell", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFundsTitle.Location = New System.Drawing.Point(407, 342)
        Me.lblFundsTitle.Name = "lblFundsTitle"
        Me.lblFundsTitle.Size = New System.Drawing.Size(162, 24)
        Me.lblFundsTitle.TabIndex = 4
        Me.lblFundsTitle.Text = "Current Funds:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblCurrentFunds
        '
        Me.lblCurrentFunds.AutoSize = True
        Me.lblCurrentFunds.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Account Balance", True))
        Me.lblCurrentFunds.Font = New System.Drawing.Font("Rockwell", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentFunds.Location = New System.Drawing.Point(444, 378)
        Me.lblCurrentFunds.Name = "lblCurrentFunds"
        Me.lblCurrentFunds.Size = New System.Drawing.Size(60, 27)
        Me.lblCurrentFunds.TabIndex = 5
        Me.lblCurrentFunds.Text = "@@"
        '
        'CustomersInfoBindingSource
        '
        Me.CustomersInfoBindingSource.DataMember = "CustomersInfo"
        Me.CustomersInfoBindingSource.DataSource = Me.EzPassDBSystem
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.NavajoWhite
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(355, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(294, 35)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Personal Toll Report" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Rockwell", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(80, 342)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 24)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Trips Taken:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Trips Taken", True))
        Me.Label5.Font = New System.Drawing.Font("Rockwell", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(124, 379)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 27)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "@@"
        '
        'CustomersInfoTableAdapter
        '
        Me.CustomersInfoTableAdapter.ClearBeforeFill = True
        '
        'CustomersTollTableAdapter
        '
        Me.CustomersTollTableAdapter.ClearBeforeFill = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Rockwell", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(734, 342)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(191, 24)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Account Standing:"
        '
        'lblAcctStatus
        '
        Me.lblAcctStatus.AutoSize = True
        Me.lblAcctStatus.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Account Status", True))
        Me.lblAcctStatus.Font = New System.Drawing.Font("Rockwell", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAcctStatus.Location = New System.Drawing.Point(732, 378)
        Me.lblAcctStatus.Name = "lblAcctStatus"
        Me.lblAcctStatus.Size = New System.Drawing.Size(60, 27)
        Me.lblAcctStatus.TabIndex = 10
        Me.lblAcctStatus.Text = "@@"
        '
        'lblFundsReminder
        '
        Me.lblFundsReminder.AutoSize = True
        Me.lblFundsReminder.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFundsReminder.ForeColor = System.Drawing.Color.Black
        Me.lblFundsReminder.Location = New System.Drawing.Point(334, 466)
        Me.lblFundsReminder.Name = "lblFundsReminder"
        Me.lblFundsReminder.Size = New System.Drawing.Size(43, 20)
        Me.lblFundsReminder.TabIndex = 12
        Me.lblFundsReminder.Text = "@@"
        '
        'Form11
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1006, 554)
        Me.Controls.Add(Me.grpTollsLogin)
        Me.Controls.Add(Me.lblFundsReminder)
        Me.Controls.Add(Me.lblAcctStatus)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblCurrentFunds)
        Me.Controls.Add(Me.lblFundsTitle)
        Me.Controls.Add(Me.btnAddFunds)
        Me.Controls.Add(Me.btnSecBack)
        Me.Controls.Add(Me.grpTollData)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form11"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Tolls"
        Me.grpTollsLogin.ResumeLayout(False)
        Me.grpTollsLogin.PerformLayout()
        Me.grpTollData.ResumeLayout(False)
        CType(Me.DatPTolls, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersTollBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EzPassDBSystem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpTollsLogin As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents txtTagSearch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents grpTollData As GroupBox
    Friend WithEvents btnSecBack As Button
    Friend WithEvents btnAddFunds As Button
    Friend WithEvents lblFundsTitle As Label
    Friend WithEvents lblCurrentFunds As Label
    Friend WithEvents EzPassDBSystem As EzPassDBSystem
    Friend WithEvents CustomersInfoBindingSource As BindingSource
    Friend WithEvents CustomersInfoTableAdapter As EzPassDBSystemTableAdapters.CustomersInfoTableAdapter
    Friend WithEvents DatPTolls As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TripsTakenDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomersTollBindingSource As BindingSource
    Friend WithEvents CustomersTollTableAdapter As EzPassDBSystemTableAdapters.CustomersTollTableAdapter
    Friend WithEvents TollCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TollLocationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TagDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PlateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TolledDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TolledTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FareDeductedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FareEffectiveDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label6 As Label
    Friend WithEvents lblAcctStatus As Label
    Friend WithEvents lblReminder As Label
    Friend WithEvents lblFundsReminder As Label
End Class
