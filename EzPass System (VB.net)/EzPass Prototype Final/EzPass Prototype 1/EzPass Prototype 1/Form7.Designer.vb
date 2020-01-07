<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form7
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTagAssign = New System.Windows.Forms.TextBox()
        Me.CustomersInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EzPassDBSystem = New EzPass_Prototype_1.EzPassDBSystem()
        Me.btnAssign = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNewTagStatus = New System.Windows.Forms.TextBox()
        Me.grpNewTagLogin = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblReminder = New System.Windows.Forms.Label()
        Me.btnBackPrevious = New System.Windows.Forms.Button()
        Me.txtAcctSearch = New System.Windows.Forms.TextBox()
        Me.btnEnterForm = New System.Windows.Forms.Button()
        Me.lblVerifyAcct = New System.Windows.Forms.Label()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.CustomersInfoTableAdapter = New EzPass_Prototype_1.EzPassDBSystemTableAdapters.CustomersInfoTableAdapter()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTagDateAssign = New System.Windows.Forms.TextBox()
        Me.lblUndoDate = New System.Windows.Forms.Label()
        Me.txtUndoDate = New System.Windows.Forms.TextBox()
        Me.lblUndoReason = New System.Windows.Forms.Label()
        Me.txtUndoReason = New System.Windows.Forms.TextBox()
        CType(Me.CustomersInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EzPassDBSystem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpNewTagLogin.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightSalmon
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(286, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(242, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer New Tag"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(93, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(176, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Assign New Tag:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtTagAssign
        '
        Me.txtTagAssign.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Tag #", True))
        Me.txtTagAssign.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTagAssign.Location = New System.Drawing.Point(552, 159)
        Me.txtTagAssign.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTagAssign.Name = "txtTagAssign"
        Me.txtTagAssign.ReadOnly = True
        Me.txtTagAssign.Size = New System.Drawing.Size(165, 28)
        Me.txtTagAssign.TabIndex = 2
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
        'btnAssign
        '
        Me.btnAssign.BackColor = System.Drawing.Color.Khaki
        Me.btnAssign.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAssign.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAssign.Location = New System.Drawing.Point(339, 154)
        Me.btnAssign.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAssign.Name = "btnAssign"
        Me.btnAssign.Size = New System.Drawing.Size(155, 30)
        Me.btnAssign.TabIndex = 3
        Me.btnAssign.Text = "Assign"
        Me.btnAssign.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUpdate.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(486, 401)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(211, 64)
        Me.btnUpdate.TabIndex = 4
        Me.btnUpdate.Text = "Update Account"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(149, 218)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(169, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "New Tag Status:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtNewTagStatus
        '
        Me.txtNewTagStatus.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Tag Status", True))
        Me.txtNewTagStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewTagStatus.Location = New System.Drawing.Point(461, 218)
        Me.txtNewTagStatus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNewTagStatus.Name = "txtNewTagStatus"
        Me.txtNewTagStatus.ReadOnly = True
        Me.txtNewTagStatus.Size = New System.Drawing.Size(172, 28)
        Me.txtNewTagStatus.TabIndex = 6
        '
        'grpNewTagLogin
        '
        Me.grpNewTagLogin.BackgroundImage = Global.EzPass_Prototype_1.My.Resources.Resources.Ezpass_Registration_Login_Background
        Me.grpNewTagLogin.Controls.Add(Me.Label5)
        Me.grpNewTagLogin.Controls.Add(Me.lblReminder)
        Me.grpNewTagLogin.Controls.Add(Me.btnBackPrevious)
        Me.grpNewTagLogin.Controls.Add(Me.txtAcctSearch)
        Me.grpNewTagLogin.Controls.Add(Me.btnEnterForm)
        Me.grpNewTagLogin.Controls.Add(Me.lblVerifyAcct)
        Me.grpNewTagLogin.Location = New System.Drawing.Point(12, 11)
        Me.grpNewTagLogin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpNewTagLogin.Name = "grpNewTagLogin"
        Me.grpNewTagLogin.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpNewTagLogin.Size = New System.Drawing.Size(793, 508)
        Me.grpNewTagLogin.TabIndex = 7
        Me.grpNewTagLogin.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Rockwell", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(259, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(282, 25)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Please Re-Verify Account # :"
        '
        'lblReminder
        '
        Me.lblReminder.AutoSize = True
        Me.lblReminder.BackColor = System.Drawing.Color.LightSalmon
        Me.lblReminder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblReminder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReminder.Location = New System.Drawing.Point(124, 452)
        Me.lblReminder.Name = "lblReminder"
        Me.lblReminder.Size = New System.Drawing.Size(517, 20)
        Me.lblReminder.TabIndex = 4
        Me.lblReminder.Text = "Reminder: Getting a New Tag by returning the old one is at no cost."
        '
        'btnBackPrevious
        '
        Me.btnBackPrevious.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnBackPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBackPrevious.Font = New System.Drawing.Font("Rockwell", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackPrevious.Location = New System.Drawing.Point(113, 321)
        Me.btnBackPrevious.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBackPrevious.Name = "btnBackPrevious"
        Me.btnBackPrevious.Size = New System.Drawing.Size(199, 47)
        Me.btnBackPrevious.TabIndex = 3
        Me.btnBackPrevious.Text = "Back to Previous"
        Me.btnBackPrevious.UseVisualStyleBackColor = False
        '
        'txtAcctSearch
        '
        Me.txtAcctSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAcctSearch.Location = New System.Drawing.Point(243, 219)
        Me.txtAcctSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAcctSearch.Name = "txtAcctSearch"
        Me.txtAcctSearch.Size = New System.Drawing.Size(320, 28)
        Me.txtAcctSearch.TabIndex = 2
        '
        'btnEnterForm
        '
        Me.btnEnterForm.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnEnterForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEnterForm.Font = New System.Drawing.Font("Rockwell", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnterForm.Location = New System.Drawing.Point(500, 321)
        Me.btnEnterForm.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEnterForm.Name = "btnEnterForm"
        Me.btnEnterForm.Size = New System.Drawing.Size(199, 47)
        Me.btnEnterForm.TabIndex = 1
        Me.btnEnterForm.Text = "Verify"
        Me.btnEnterForm.UseVisualStyleBackColor = False
        '
        'lblVerifyAcct
        '
        Me.lblVerifyAcct.AutoSize = True
        Me.lblVerifyAcct.BackColor = System.Drawing.Color.LightSalmon
        Me.lblVerifyAcct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblVerifyAcct.Font = New System.Drawing.Font("Tahoma", 16.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVerifyAcct.Location = New System.Drawing.Point(204, 42)
        Me.lblVerifyAcct.Name = "lblVerifyAcct"
        Me.lblVerifyAcct.Size = New System.Drawing.Size(377, 35)
        Me.lblVerifyAcct.TabIndex = 0
        Me.lblVerifyAcct.Text = "Returned Tag Assignment:"
        '
        'btnPrevious
        '
        Me.btnPrevious.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPrevious.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.Location = New System.Drawing.Point(103, 401)
        Me.btnPrevious.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(211, 64)
        Me.btnPrevious.TabIndex = 9
        Me.btnPrevious.Text = "Back to Previous"
        Me.btnPrevious.UseVisualStyleBackColor = False
        '
        'CustomersInfoTableAdapter
        '
        Me.CustomersInfoTableAdapter.ClearBeforeFill = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Rockwell", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(140, 271)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(203, 24)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Tag Date Assigned:"
        '
        'txtTagDateAssign
        '
        Me.txtTagDateAssign.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Tag Date Assigned", True))
        Me.txtTagDateAssign.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTagDateAssign.Location = New System.Drawing.Point(460, 271)
        Me.txtTagDateAssign.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTagDateAssign.Name = "txtTagDateAssign"
        Me.txtTagDateAssign.ReadOnly = True
        Me.txtTagDateAssign.Size = New System.Drawing.Size(172, 28)
        Me.txtTagDateAssign.TabIndex = 11
        '
        'lblUndoDate
        '
        Me.lblUndoDate.AutoSize = True
        Me.lblUndoDate.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUndoDate.Location = New System.Drawing.Point(64, 328)
        Me.lblUndoDate.Name = "lblUndoDate"
        Me.lblUndoDate.Size = New System.Drawing.Size(160, 18)
        Me.lblUndoDate.TabIndex = 12
        Me.lblUndoDate.Text = "Undo Removal Date:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtUndoDate
        '
        Me.txtUndoDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Removal Date", True))
        Me.txtUndoDate.Location = New System.Drawing.Point(256, 328)
        Me.txtUndoDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtUndoDate.Name = "txtUndoDate"
        Me.txtUndoDate.Size = New System.Drawing.Size(89, 22)
        Me.txtUndoDate.TabIndex = 13
        '
        'lblUndoReason
        '
        Me.lblUndoReason.AutoSize = True
        Me.lblUndoReason.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUndoReason.Location = New System.Drawing.Point(397, 329)
        Me.lblUndoReason.Name = "lblUndoReason"
        Me.lblUndoReason.Size = New System.Drawing.Size(180, 18)
        Me.lblUndoReason.TabIndex = 14
        Me.lblUndoReason.Text = "Undo Removal Reason:"
        '
        'txtUndoReason
        '
        Me.txtUndoReason.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Removal Reason", True))
        Me.txtUndoReason.Location = New System.Drawing.Point(611, 328)
        Me.txtUndoReason.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtUndoReason.Name = "txtUndoReason"
        Me.txtUndoReason.Size = New System.Drawing.Size(89, 22)
        Me.txtUndoReason.TabIndex = 15
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(815, 527)
        Me.Controls.Add(Me.grpNewTagLogin)
        Me.Controls.Add(Me.txtUndoReason)
        Me.Controls.Add(Me.lblUndoReason)
        Me.Controls.Add(Me.txtUndoDate)
        Me.Controls.Add(Me.lblUndoDate)
        Me.Controls.Add(Me.txtTagDateAssign)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.txtNewTagStatus)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAssign)
        Me.Controls.Add(Me.txtTagAssign)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form7"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Tag Assignment"
        CType(Me.CustomersInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EzPassDBSystem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpNewTagLogin.ResumeLayout(False)
        Me.grpNewTagLogin.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTagAssign As TextBox
    Friend WithEvents btnAssign As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNewTagStatus As TextBox
    Friend WithEvents grpNewTagLogin As GroupBox
    Friend WithEvents txtAcctSearch As TextBox
    Friend WithEvents btnEnterForm As Button
    Friend WithEvents lblVerifyAcct As Label
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnBackPrevious As Button
    Friend WithEvents lblReminder As Label
    Friend WithEvents EzPassDBSystem As EzPassDBSystem
    Friend WithEvents CustomersInfoBindingSource As BindingSource
    Friend WithEvents CustomersInfoTableAdapter As EzPassDBSystemTableAdapters.CustomersInfoTableAdapter
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTagDateAssign As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lblUndoDate As Label
    Friend WithEvents txtUndoDate As TextBox
    Friend WithEvents lblUndoReason As Label
    Friend WithEvents txtUndoReason As TextBox
End Class
