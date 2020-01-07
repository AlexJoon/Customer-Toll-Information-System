<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form18
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
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnDeleteToll = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TollCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TollNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FaresDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FareEffectiveDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TollTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EntryPointDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EndingPointDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TollCodesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EzPassDBSystem = New EzPass_Prototype_1.EzPassDBSystem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TollCodesTableAdapter = New EzPass_Prototype_1.EzPassDBSystemTableAdapters.TollCodesTableAdapter()
        Me.lblTollCodeTitle = New System.Windows.Forms.Label()
        Me.lblTollCodeSelect = New System.Windows.Forms.Label()
        Me.lblFilterBy = New System.Windows.Forms.Label()
        Me.RadAll = New System.Windows.Forms.RadioButton()
        Me.RadBridges = New System.Windows.Forms.RadioButton()
        Me.RadTunnels = New System.Windows.Forms.RadioButton()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TollCodesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EzPassDBSystem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Font = New System.Drawing.Font("Rockwell", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(72, 565)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(278, 94)
        Me.btnBack.TabIndex = 0
        Me.btnBack.Text = "Back to Monitor"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnDeleteToll
        '
        Me.btnDeleteToll.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnDeleteToll.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDeleteToll.Font = New System.Drawing.Font("Rockwell", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteToll.Location = New System.Drawing.Point(920, 565)
        Me.btnDeleteToll.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnDeleteToll.Name = "btnDeleteToll"
        Me.btnDeleteToll.Size = New System.Drawing.Size(278, 94)
        Me.btnDeleteToll.TabIndex = 1
        Me.btnDeleteToll.Text = "Delete Selected Crossing"
        Me.btnDeleteToll.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Location = New System.Drawing.Point(18, 112)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1234, 360)
        Me.Panel1.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TollCodeDataGridViewTextBoxColumn, Me.TollNameDataGridViewTextBoxColumn, Me.FaresDataGridViewTextBoxColumn, Me.FareEffectiveDateDataGridViewTextBoxColumn, Me.TollTypeDataGridViewTextBoxColumn, Me.EntryPointDataGridViewTextBoxColumn, Me.EndingPointDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TollCodesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(18, 20)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.Size = New System.Drawing.Size(1196, 318)
        Me.DataGridView1.TabIndex = 0
        '
        'TollCodeDataGridViewTextBoxColumn
        '
        Me.TollCodeDataGridViewTextBoxColumn.DataPropertyName = "Toll Code"
        Me.TollCodeDataGridViewTextBoxColumn.HeaderText = "Toll Code"
        Me.TollCodeDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TollCodeDataGridViewTextBoxColumn.Name = "TollCodeDataGridViewTextBoxColumn"
        Me.TollCodeDataGridViewTextBoxColumn.Width = 150
        '
        'TollNameDataGridViewTextBoxColumn
        '
        Me.TollNameDataGridViewTextBoxColumn.DataPropertyName = "Toll Name"
        Me.TollNameDataGridViewTextBoxColumn.HeaderText = "Toll Name"
        Me.TollNameDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TollNameDataGridViewTextBoxColumn.Name = "TollNameDataGridViewTextBoxColumn"
        Me.TollNameDataGridViewTextBoxColumn.Width = 150
        '
        'FaresDataGridViewTextBoxColumn
        '
        Me.FaresDataGridViewTextBoxColumn.DataPropertyName = "Fares"
        Me.FaresDataGridViewTextBoxColumn.HeaderText = "Fares"
        Me.FaresDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.FaresDataGridViewTextBoxColumn.Name = "FaresDataGridViewTextBoxColumn"
        Me.FaresDataGridViewTextBoxColumn.Width = 150
        '
        'FareEffectiveDateDataGridViewTextBoxColumn
        '
        Me.FareEffectiveDateDataGridViewTextBoxColumn.DataPropertyName = "Fare Effective Date"
        Me.FareEffectiveDateDataGridViewTextBoxColumn.HeaderText = "Fare Effective Date"
        Me.FareEffectiveDateDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.FareEffectiveDateDataGridViewTextBoxColumn.Name = "FareEffectiveDateDataGridViewTextBoxColumn"
        Me.FareEffectiveDateDataGridViewTextBoxColumn.Width = 150
        '
        'TollTypeDataGridViewTextBoxColumn
        '
        Me.TollTypeDataGridViewTextBoxColumn.DataPropertyName = "Toll Type"
        Me.TollTypeDataGridViewTextBoxColumn.HeaderText = "Toll Type"
        Me.TollTypeDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TollTypeDataGridViewTextBoxColumn.Name = "TollTypeDataGridViewTextBoxColumn"
        Me.TollTypeDataGridViewTextBoxColumn.Width = 150
        '
        'EntryPointDataGridViewTextBoxColumn
        '
        Me.EntryPointDataGridViewTextBoxColumn.DataPropertyName = "Entry Point"
        Me.EntryPointDataGridViewTextBoxColumn.HeaderText = "Entry Point"
        Me.EntryPointDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.EntryPointDataGridViewTextBoxColumn.Name = "EntryPointDataGridViewTextBoxColumn"
        Me.EntryPointDataGridViewTextBoxColumn.Width = 150
        '
        'EndingPointDataGridViewTextBoxColumn
        '
        Me.EndingPointDataGridViewTextBoxColumn.DataPropertyName = "Ending Point"
        Me.EndingPointDataGridViewTextBoxColumn.HeaderText = "Ending Point"
        Me.EndingPointDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.EndingPointDataGridViewTextBoxColumn.Name = "EndingPointDataGridViewTextBoxColumn"
        Me.EndingPointDataGridViewTextBoxColumn.Width = 150
        '
        'TollCodesBindingSource
        '
        Me.TollCodesBindingSource.DataMember = "TollCodes"
        Me.TollCodesBindingSource.DataSource = Me.EzPassDBSystem
        '
        'EzPassDBSystem
        '
        Me.EzPassDBSystem.DataSetName = "EzPassDBSystem"
        Me.EzPassDBSystem.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightSalmon
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(135, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(292, 41)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "All Toll Crossings"
        '
        'TollCodesTableAdapter
        '
        Me.TollCodesTableAdapter.ClearBeforeFill = True
        '
        'lblTollCodeTitle
        '
        Me.lblTollCodeTitle.AutoSize = True
        Me.lblTollCodeTitle.Font = New System.Drawing.Font("Rockwell", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTollCodeTitle.Location = New System.Drawing.Point(504, 500)
        Me.lblTollCodeTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTollCodeTitle.Name = "lblTollCodeTitle"
        Me.lblTollCodeTitle.Size = New System.Drawing.Size(291, 36)
        Me.lblTollCodeTitle.TabIndex = 4
        Me.lblTollCodeTitle.Text = "Toll Code Selected:"
        '
        'lblTollCodeSelect
        '
        Me.lblTollCodeSelect.AutoSize = True
        Me.lblTollCodeSelect.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TollCodesBindingSource, "Toll Code", True))
        Me.lblTollCodeSelect.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTollCodeSelect.Location = New System.Drawing.Point(592, 565)
        Me.lblTollCodeSelect.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTollCodeSelect.Name = "lblTollCodeSelect"
        Me.lblTollCodeSelect.Size = New System.Drawing.Size(71, 36)
        Me.lblTollCodeSelect.TabIndex = 6
        Me.lblTollCodeSelect.Text = "@@"
        '
        'lblFilterBy
        '
        Me.lblFilterBy.AutoSize = True
        Me.lblFilterBy.Font = New System.Drawing.Font("Rockwell", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFilterBy.Location = New System.Drawing.Point(606, 57)
        Me.lblFilterBy.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFilterBy.Name = "lblFilterBy"
        Me.lblFilterBy.Size = New System.Drawing.Size(124, 29)
        Me.lblFilterBy.TabIndex = 7
        Me.lblFilterBy.Text = "Filter By:"
        '
        'RadAll
        '
        Me.RadAll.AutoSize = True
        Me.RadAll.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadAll.Location = New System.Drawing.Point(784, 55)
        Me.RadAll.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RadAll.Name = "RadAll"
        Me.RadAll.Size = New System.Drawing.Size(69, 32)
        Me.RadAll.TabIndex = 8
        Me.RadAll.TabStop = True
        Me.RadAll.Text = "All"
        Me.RadAll.UseVisualStyleBackColor = True
        '
        'RadBridges
        '
        Me.RadBridges.AutoSize = True
        Me.RadBridges.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadBridges.Location = New System.Drawing.Point(920, 55)
        Me.RadBridges.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RadBridges.Name = "RadBridges"
        Me.RadBridges.Size = New System.Drawing.Size(124, 32)
        Me.RadBridges.TabIndex = 9
        Me.RadBridges.TabStop = True
        Me.RadBridges.Text = "Bridges"
        Me.RadBridges.UseVisualStyleBackColor = True
        '
        'RadTunnels
        '
        Me.RadTunnels.AutoSize = True
        Me.RadTunnels.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTunnels.Location = New System.Drawing.Point(1104, 55)
        Me.RadTunnels.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RadTunnels.Name = "RadTunnels"
        Me.RadTunnels.Size = New System.Drawing.Size(128, 32)
        Me.RadTunnels.TabIndex = 10
        Me.RadTunnels.TabStop = True
        Me.RadTunnels.Text = "Tunnels"
        Me.RadTunnels.UseVisualStyleBackColor = True
        '
        'Form18
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1270, 697)
        Me.Controls.Add(Me.RadTunnels)
        Me.Controls.Add(Me.RadBridges)
        Me.Controls.Add(Me.RadAll)
        Me.Controls.Add(Me.lblFilterBy)
        Me.Controls.Add(Me.lblTollCodeSelect)
        Me.Controls.Add(Me.lblTollCodeTitle)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnDeleteToll)
        Me.Controls.Add(Me.btnBack)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form18"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Toll Description"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TollCodesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EzPassDBSystem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents btnDeleteToll As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents EzPassDBSystem As EzPassDBSystem
    Friend WithEvents TollCodesBindingSource As BindingSource
    Friend WithEvents TollCodesTableAdapter As EzPassDBSystemTableAdapters.TollCodesTableAdapter
    Friend WithEvents TollCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TollNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FaresDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FareEffectiveDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TollTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EntryPointDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EndingPointDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents lblTollCodeTitle As Label
    Friend WithEvents lblTollCodeSelect As Label
    Friend WithEvents lblFilterBy As Label
    Friend WithEvents RadAll As RadioButton
    Friend WithEvents RadBridges As RadioButton
    Friend WithEvents RadTunnels As RadioButton
End Class
