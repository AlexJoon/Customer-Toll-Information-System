<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form15
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
        Me.lblFareTitle = New System.Windows.Forms.Label()
        Me.btnIncrease = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnProcess = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblEffectiveDate = New System.Windows.Forms.Label()
        Me.EzPassDBSystem = New EzPass_Prototype_1.EzPassDBSystem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TollCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FaresDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TollCodesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TollCodesTableAdapter = New EzPass_Prototype_1.EzPassDBSystemTableAdapters.TollCodesTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblSelectedCode = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTollFare = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnDecrease = New System.Windows.Forms.Button()
        CType(Me.EzPassDBSystem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TollCodesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFareTitle
        '
        Me.lblFareTitle.AutoSize = True
        Me.lblFareTitle.BackColor = System.Drawing.Color.LemonChiffon
        Me.lblFareTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFareTitle.Font = New System.Drawing.Font("Tahoma", 16.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFareTitle.Location = New System.Drawing.Point(322, 23)
        Me.lblFareTitle.Name = "lblFareTitle"
        Me.lblFareTitle.Size = New System.Drawing.Size(272, 35)
        Me.lblFareTitle.TabIndex = 0
        Me.lblFareTitle.Text = "Update Fare Prices"
        '
        'btnIncrease
        '
        Me.btnIncrease.BackColor = System.Drawing.Color.Khaki
        Me.btnIncrease.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnIncrease.Font = New System.Drawing.Font("Rockwell", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIncrease.Location = New System.Drawing.Point(689, 320)
        Me.btnIncrease.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnIncrease.Name = "btnIncrease"
        Me.btnIncrease.Size = New System.Drawing.Size(188, 57)
        Me.btnIncrease.TabIndex = 14
        Me.btnIncrease.Text = "Increase Fares"
        Me.btnIncrease.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Font = New System.Drawing.Font("Rockwell", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(129, 456)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(220, 60)
        Me.btnBack.TabIndex = 15
        Me.btnBack.Text = "Back to Monitor"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnProcess
        '
        Me.btnProcess.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnProcess.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnProcess.Font = New System.Drawing.Font("Rockwell", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProcess.Location = New System.Drawing.Point(563, 456)
        Me.btnProcess.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(220, 60)
        Me.btnProcess.TabIndex = 16
        Me.btnProcess.Text = "Update Information" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnProcess.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Rockwell", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(419, 151)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(251, 48)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "New Fare Effective Date:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblEffectiveDate
        '
        Me.lblEffectiveDate.AutoSize = True
        Me.lblEffectiveDate.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEffectiveDate.Location = New System.Drawing.Point(739, 151)
        Me.lblEffectiveDate.Name = "lblEffectiveDate"
        Me.lblEffectiveDate.Size = New System.Drawing.Size(50, 24)
        Me.lblEffectiveDate.TabIndex = 18
        Me.lblEffectiveDate.Text = "@@"
        '
        'EzPassDBSystem
        '
        Me.EzPassDBSystem.DataSetName = "EzPassDBSystem"
        Me.EzPassDBSystem.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TollCodeDataGridViewTextBoxColumn, Me.FaresDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TollCodesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(40, 138)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.Size = New System.Drawing.Size(333, 264)
        Me.DataGridView1.TabIndex = 0
        '
        'TollCodeDataGridViewTextBoxColumn
        '
        Me.TollCodeDataGridViewTextBoxColumn.DataPropertyName = "Toll Code"
        Me.TollCodeDataGridViewTextBoxColumn.HeaderText = "Toll Code"
        Me.TollCodeDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TollCodeDataGridViewTextBoxColumn.Name = "TollCodeDataGridViewTextBoxColumn"
        Me.TollCodeDataGridViewTextBoxColumn.Width = 125
        '
        'FaresDataGridViewTextBoxColumn
        '
        Me.FaresDataGridViewTextBoxColumn.DataPropertyName = "Fares"
        Me.FaresDataGridViewTextBoxColumn.HeaderText = "Fares"
        Me.FaresDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.FaresDataGridViewTextBoxColumn.Name = "FaresDataGridViewTextBoxColumn"
        Me.FaresDataGridViewTextBoxColumn.Width = 125
        '
        'TollCodesBindingSource
        '
        Me.TollCodesBindingSource.DataMember = "TollCodes"
        Me.TollCodesBindingSource.DataSource = Me.EzPassDBSystem
        '
        'TollCodesTableAdapter
        '
        Me.TollCodesTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(439, 200)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 24)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Toll Code Selected:"
        '
        'lblSelectedCode
        '
        Me.lblSelectedCode.AutoSize = True
        Me.lblSelectedCode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TollCodesBindingSource, "Toll Code", True))
        Me.lblSelectedCode.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectedCode.Location = New System.Drawing.Point(739, 200)
        Me.lblSelectedCode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSelectedCode.Name = "lblSelectedCode"
        Me.lblSelectedCode.Size = New System.Drawing.Size(50, 24)
        Me.lblSelectedCode.TabIndex = 49
        Me.lblSelectedCode.Text = "@@"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(492, 247)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 24)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Toll Fare:"
        '
        'lblTollFare
        '
        Me.lblTollFare.AutoSize = True
        Me.lblTollFare.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TollCodesBindingSource, "Fares", True))
        Me.lblTollFare.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTollFare.Location = New System.Drawing.Point(739, 247)
        Me.lblTollFare.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTollFare.Name = "lblTollFare"
        Me.lblTollFare.Size = New System.Drawing.Size(50, 24)
        Me.lblTollFare.TabIndex = 51
        Me.lblTollFare.Text = "@@"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Rockwell", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(56, 95)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(281, 24)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Select Toll Below to Update:"
        '
        'btnDecrease
        '
        Me.btnDecrease.BackColor = System.Drawing.Color.Khaki
        Me.btnDecrease.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDecrease.Font = New System.Drawing.Font("Rockwell", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDecrease.Location = New System.Drawing.Point(408, 322)
        Me.btnDecrease.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDecrease.Name = "btnDecrease"
        Me.btnDecrease.Size = New System.Drawing.Size(188, 57)
        Me.btnDecrease.TabIndex = 53
        Me.btnDecrease.Text = "Decrease Fares"
        Me.btnDecrease.UseVisualStyleBackColor = False
        '
        'Form15
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(914, 552)
        Me.Controls.Add(Me.btnDecrease)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lblTollFare)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblSelectedCode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblEffectiveDate)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnProcess)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnIncrease)
        Me.Controls.Add(Me.lblFareTitle)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form15"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fare Information"
        CType(Me.EzPassDBSystem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TollCodesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFareTitle As Label
    Friend WithEvents btnIncrease As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnProcess As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents lblEffectiveDate As Label
    Friend WithEvents EzPassDBSystem As EzPassDBSystem
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TollCodesBindingSource As BindingSource
    Friend WithEvents TollCodesTableAdapter As EzPassDBSystemTableAdapters.TollCodesTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents lblSelectedCode As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTollFare As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnDecrease As Button
    Friend WithEvents TollCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FaresDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
