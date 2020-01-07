<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form16
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
        Me.txtAddTollCode = New System.Windows.Forms.TextBox()
        Me.TollCodesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EzPassDBSystem = New EzPass_Prototype_1.EzPassDBSystem()
        Me.txtFirstEntryPoint = New System.Windows.Forms.TextBox()
        Me.txtAddTollName = New System.Windows.Forms.TextBox()
        Me.txtAddTollFare = New System.Windows.Forms.TextBox()
        Me.txtSecondEntryPoint = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblCurrentDate = New System.Windows.Forms.Label()
        Me.cmbTollType = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnAddNewToll = New System.Windows.Forms.Button()
        Me.btnClearFields = New System.Windows.Forms.Button()
        Me.TollCodesTableAdapter = New EzPass_Prototype_1.EzPassDBSystemTableAdapters.TollCodesTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTollRevenue = New System.Windows.Forms.TextBox()
        CType(Me.TollCodesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EzPassDBSystem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DarkSalmon
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(208, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(221, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Add Toll Crossing"
        '
        'txtAddTollCode
        '
        Me.txtAddTollCode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TollCodesBindingSource, "Toll Code", True))
        Me.txtAddTollCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddTollCode.Location = New System.Drawing.Point(98, 62)
        Me.txtAddTollCode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAddTollCode.Name = "txtAddTollCode"
        Me.txtAddTollCode.Size = New System.Drawing.Size(160, 29)
        Me.txtAddTollCode.TabIndex = 1
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
        'txtFirstEntryPoint
        '
        Me.txtFirstEntryPoint.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TollCodesBindingSource, "Entry Point", True))
        Me.txtFirstEntryPoint.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstEntryPoint.Location = New System.Drawing.Point(444, 62)
        Me.txtFirstEntryPoint.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFirstEntryPoint.Name = "txtFirstEntryPoint"
        Me.txtFirstEntryPoint.Size = New System.Drawing.Size(160, 29)
        Me.txtFirstEntryPoint.TabIndex = 2
        '
        'txtAddTollName
        '
        Me.txtAddTollName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TollCodesBindingSource, "Toll Name", True))
        Me.txtAddTollName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddTollName.Location = New System.Drawing.Point(98, 158)
        Me.txtAddTollName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAddTollName.Name = "txtAddTollName"
        Me.txtAddTollName.Size = New System.Drawing.Size(160, 29)
        Me.txtAddTollName.TabIndex = 3
        '
        'txtAddTollFare
        '
        Me.txtAddTollFare.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TollCodesBindingSource, "Fares", True))
        Me.txtAddTollFare.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddTollFare.Location = New System.Drawing.Point(98, 250)
        Me.txtAddTollFare.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAddTollFare.Name = "txtAddTollFare"
        Me.txtAddTollFare.Size = New System.Drawing.Size(160, 29)
        Me.txtAddTollFare.TabIndex = 4
        '
        'txtSecondEntryPoint
        '
        Me.txtSecondEntryPoint.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TollCodesBindingSource, "Ending Point", True))
        Me.txtSecondEntryPoint.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSecondEntryPoint.Location = New System.Drawing.Point(444, 158)
        Me.txtSecondEntryPoint.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSecondEntryPoint.Name = "txtSecondEntryPoint"
        Me.txtSecondEntryPoint.Size = New System.Drawing.Size(160, 29)
        Me.txtSecondEntryPoint.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(123, 24)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 23)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Toll Code:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(123, 131)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 23)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Toll Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Rockwell", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(128, 223)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 23)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Toll Fare:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Rockwell", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(620, 31)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(199, 23)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Fare Effective Date:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Rockwell", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(452, 24)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(150, 23)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Entry Point # 1"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Rockwell", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(452, 132)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(150, 23)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Entry Point # 2"
        '
        'lblCurrentDate
        '
        Me.lblCurrentDate.AutoSize = True
        Me.lblCurrentDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TollCodesBindingSource, "Fare Effective Date", True))
        Me.lblCurrentDate.Font = New System.Drawing.Font("Rockwell", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentDate.Location = New System.Drawing.Point(662, 65)
        Me.lblCurrentDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCurrentDate.Name = "lblCurrentDate"
        Me.lblCurrentDate.Size = New System.Drawing.Size(61, 29)
        Me.lblCurrentDate.TabIndex = 17
        Me.lblCurrentDate.Text = "@@"
        '
        'cmbTollType
        '
        Me.cmbTollType.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TollCodesBindingSource, "Toll Type", True))
        Me.cmbTollType.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTollType.FormattingEnabled = True
        Me.cmbTollType.Items.AddRange(New Object() {"Select Type", "Bridge", "Tunnel"})
        Me.cmbTollType.Location = New System.Drawing.Point(444, 250)
        Me.cmbTollType.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbTollType.Name = "cmbTollType"
        Me.cmbTollType.Size = New System.Drawing.Size(160, 32)
        Me.cmbTollType.TabIndex = 18
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Rockwell", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(412, 223)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(233, 23)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Choose Bridge/Tunnel:"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(48, 464)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(206, 62)
        Me.btnBack.TabIndex = 20
        Me.btnBack.Text = "Back to Monitor"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnAddNewToll
        '
        Me.btnAddNewToll.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnAddNewToll.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddNewToll.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNewToll.Location = New System.Drawing.Point(777, 464)
        Me.btnAddNewToll.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddNewToll.Name = "btnAddNewToll"
        Me.btnAddNewToll.Size = New System.Drawing.Size(206, 62)
        Me.btnAddNewToll.TabIndex = 21
        Me.btnAddNewToll.Text = "Add New Toll Crossing"
        Me.btnAddNewToll.UseVisualStyleBackColor = False
        '
        'btnClearFields
        '
        Me.btnClearFields.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnClearFields.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClearFields.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearFields.Location = New System.Drawing.Point(414, 464)
        Me.btnClearFields.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClearFields.Name = "btnClearFields"
        Me.btnClearFields.Size = New System.Drawing.Size(206, 62)
        Me.btnClearFields.TabIndex = 22
        Me.btnClearFields.Text = "Clear Fields"
        Me.btnClearFields.UseVisualStyleBackColor = False
        '
        'TollCodesTableAdapter
        '
        Me.TollCodesTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MistyRose
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.cmbTollType)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtSecondEntryPoint)
        Me.Panel1.Controls.Add(Me.txtAddTollFare)
        Me.Panel1.Controls.Add(Me.txtAddTollName)
        Me.Panel1.Controls.Add(Me.txtFirstEntryPoint)
        Me.Panel1.Controls.Add(Me.txtAddTollCode)
        Me.Panel1.Location = New System.Drawing.Point(142, 104)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(705, 315)
        Me.Panel1.TabIndex = 23
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(419, 225)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 17)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Base Toll Revenue"
        '
        'txtTollRevenue
        '
        Me.txtTollRevenue.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TollCodesBindingSource, "Total Toll Revenue", True))
        Me.txtTollRevenue.Location = New System.Drawing.Point(433, 259)
        Me.txtTollRevenue.Name = "txtTollRevenue"
        Me.txtTollRevenue.Size = New System.Drawing.Size(100, 22)
        Me.txtTollRevenue.TabIndex = 25
        '
        'Form16
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1017, 554)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtTollRevenue)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnClearFields)
        Me.Controls.Add(Me.btnAddNewToll)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblCurrentDate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form16"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Tolls"
        CType(Me.TollCodesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EzPassDBSystem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtAddTollCode As TextBox
    Friend WithEvents txtFirstEntryPoint As TextBox
    Friend WithEvents txtAddTollName As TextBox
    Friend WithEvents txtAddTollFare As TextBox
    Friend WithEvents txtSecondEntryPoint As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblCurrentDate As Label
    Friend WithEvents cmbTollType As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents btnAddNewToll As Button
    Friend WithEvents btnClearFields As Button
    Friend WithEvents EzPassDBSystem As EzPassDBSystem
    Friend WithEvents TollCodesBindingSource As BindingSource
    Friend WithEvents TollCodesTableAdapter As EzPassDBSystemTableAdapters.TollCodesTableAdapter
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents txtTollRevenue As TextBox
End Class
