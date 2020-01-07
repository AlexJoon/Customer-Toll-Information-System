<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form8
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
        Me.grpFindAcctBox = New System.Windows.Forms.GroupBox()
        Me.btnBacktoUser = New System.Windows.Forms.Button()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.btnFindAcct = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.CustomersInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EzPassDBSystem = New EzPass_Prototype_1.EzPassDBSystem()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSecondBack = New System.Windows.Forms.Button()
        Me.CustomersInfoTableAdapter = New EzPass_Prototype_1.EzPassDBSystemTableAdapters.CustomersInfoTableAdapter()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.grpFindAcctBox.SuspendLayout()
        CType(Me.CustomersInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EzPassDBSystem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpFindAcctBox
        '
        Me.grpFindAcctBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.grpFindAcctBox.BackgroundImage = Global.EzPass_Prototype_1.My.Resources.Resources.Ezpass_Registration_Login_Background
        Me.grpFindAcctBox.Controls.Add(Me.btnBacktoUser)
        Me.grpFindAcctBox.Controls.Add(Me.txtLastName)
        Me.grpFindAcctBox.Controls.Add(Me.txtFirstName)
        Me.grpFindAcctBox.Controls.Add(Me.btnFindAcct)
        Me.grpFindAcctBox.Controls.Add(Me.Label2)
        Me.grpFindAcctBox.Controls.Add(Me.Label1)
        Me.grpFindAcctBox.Location = New System.Drawing.Point(9, 10)
        Me.grpFindAcctBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpFindAcctBox.Name = "grpFindAcctBox"
        Me.grpFindAcctBox.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpFindAcctBox.Size = New System.Drawing.Size(609, 376)
        Me.grpFindAcctBox.TabIndex = 0
        Me.grpFindAcctBox.TabStop = False
        '
        'btnBacktoUser
        '
        Me.btnBacktoUser.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnBacktoUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBacktoUser.Font = New System.Drawing.Font("Rockwell", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBacktoUser.Location = New System.Drawing.Point(27, 294)
        Me.btnBacktoUser.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBacktoUser.Name = "btnBacktoUser"
        Me.btnBacktoUser.Size = New System.Drawing.Size(208, 67)
        Me.btnBacktoUser.TabIndex = 5
        Me.btnBacktoUser.Text = "Back to Previous" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnBacktoUser.UseVisualStyleBackColor = False
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(233, 204)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(152, 28)
        Me.txtLastName.TabIndex = 4
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(233, 94)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(155, 28)
        Me.txtFirstName.TabIndex = 3
        '
        'btnFindAcct
        '
        Me.btnFindAcct.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnFindAcct.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFindAcct.Font = New System.Drawing.Font("Rockwell", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFindAcct.Location = New System.Drawing.Point(368, 294)
        Me.btnFindAcct.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnFindAcct.Name = "btnFindAcct"
        Me.btnFindAcct.Size = New System.Drawing.Size(208, 67)
        Me.btnFindAcct.TabIndex = 2
        Me.btnFindAcct.Text = "Find Account" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnFindAcct.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.PaleGreen
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(193, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(235, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "What is the Last Name?"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.PaleGreen
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(185, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(253, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "What is your First Name?"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(158, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 29)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Hello,"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "First Name", True))
        Me.lblFirstName.Font = New System.Drawing.Font("Rockwell", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.Location = New System.Drawing.Point(254, 32)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(61, 29)
        Me.lblFirstName.TabIndex = 2
        Me.lblFirstName.Text = "@@"
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
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Last Name", True))
        Me.lblLastName.Font = New System.Drawing.Font("Rockwell", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.Location = New System.Drawing.Point(339, 32)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(61, 29)
        Me.lblLastName.TabIndex = 3
        Me.lblLastName.Text = "@@"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Rockwell", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(98, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(210, 27)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Your Account # is,"
        '
        'btnSecondBack
        '
        Me.btnSecondBack.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnSecondBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSecondBack.Font = New System.Drawing.Font("Rockwell", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSecondBack.Location = New System.Drawing.Point(188, 301)
        Me.btnSecondBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSecondBack.Name = "btnSecondBack"
        Me.btnSecondBack.Size = New System.Drawing.Size(270, 69)
        Me.btnSecondBack.TabIndex = 6
        Me.btnSecondBack.Text = "Back to Update Login" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnSecondBack.UseVisualStyleBackColor = False
        '
        'CustomersInfoTableAdapter
        '
        Me.CustomersInfoTableAdapter.ClearBeforeFill = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Account #", True))
        Me.Label4.Font = New System.Drawing.Font("Rockwell", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(159, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 33)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "@@"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Bisque
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(122, 105)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(397, 129)
        Me.Panel1.TabIndex = 8
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(625, 396)
        Me.Controls.Add(Me.grpFindAcctBox)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnSecondBack)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.Label3)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form8"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Account Retrieval"
        Me.grpFindAcctBox.ResumeLayout(False)
        Me.grpFindAcctBox.PerformLayout()
        CType(Me.CustomersInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EzPassDBSystem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpFindAcctBox As GroupBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents btnFindAcct As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBacktoUser As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnSecondBack As Button
    Friend WithEvents EzPassDBSystem As EzPassDBSystem
    Friend WithEvents CustomersInfoBindingSource As BindingSource
    Friend WithEvents CustomersInfoTableAdapter As EzPassDBSystemTableAdapters.CustomersInfoTableAdapter
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
End Class
