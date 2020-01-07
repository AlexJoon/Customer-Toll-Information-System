<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form6
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
        Me.lblAcctVer = New System.Windows.Forms.Label()
        Me.txtAcctSearch = New System.Windows.Forms.TextBox()
        Me.grpLostAssignMoney = New System.Windows.Forms.GroupBox()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblPriceReminder = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnProcess = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.txtAssignNewTag = New System.Windows.Forms.TextBox()
        Me.CustomersInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EzPassDBSystem = New EzPass_Prototype_1.EzPassDBSystem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDeduct = New System.Windows.Forms.Label()
        Me.txtDeduct = New System.Windows.Forms.TextBox()
        Me.btnDeduct = New System.Windows.Forms.Button()
        Me.btnAssignNewTag = New System.Windows.Forms.Button()
        Me.lblNewStatus = New System.Windows.Forms.Label()
        Me.txtNewTagStatus = New System.Windows.Forms.TextBox()
        Me.lblTagDateAssign = New System.Windows.Forms.Label()
        Me.txtTagDateAssign = New System.Windows.Forms.TextBox()
        Me.lblUndoDate = New System.Windows.Forms.Label()
        Me.txtUndoDate = New System.Windows.Forms.TextBox()
        Me.lblUndoReason = New System.Windows.Forms.Label()
        Me.txtUndoReason = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CustomersInfoTableAdapter = New EzPass_Prototype_1.EzPassDBSystemTableAdapters.CustomersInfoTableAdapter()
        Me.grpLostAssignMoney.SuspendLayout()
        CType(Me.CustomersInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EzPassDBSystem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblAcctVer
        '
        Me.lblAcctVer.AutoSize = True
        Me.lblAcctVer.BackColor = System.Drawing.Color.FloralWhite
        Me.lblAcctVer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAcctVer.Font = New System.Drawing.Font("Tahoma", 16.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAcctVer.Location = New System.Drawing.Point(239, 59)
        Me.lblAcctVer.Name = "lblAcctVer"
        Me.lblAcctVer.Size = New System.Drawing.Size(308, 35)
        Me.lblAcctVer.TabIndex = 0
        Me.lblAcctVer.Text = "Lost Tag Assignment:"
        '
        'txtAcctSearch
        '
        Me.txtAcctSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAcctSearch.Location = New System.Drawing.Point(257, 234)
        Me.txtAcctSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAcctSearch.Name = "txtAcctSearch"
        Me.txtAcctSearch.Size = New System.Drawing.Size(288, 28)
        Me.txtAcctSearch.TabIndex = 2
        '
        'grpLostAssignMoney
        '
        Me.grpLostAssignMoney.BackgroundImage = Global.EzPass_Prototype_1.My.Resources.Resources.Ezpass_Registration_Login_Background
        Me.grpLostAssignMoney.Controls.Add(Me.btnPrevious)
        Me.grpLostAssignMoney.Controls.Add(Me.Label4)
        Me.grpLostAssignMoney.Controls.Add(Me.lblPriceReminder)
        Me.grpLostAssignMoney.Controls.Add(Me.btnEnter)
        Me.grpLostAssignMoney.Controls.Add(Me.txtAcctSearch)
        Me.grpLostAssignMoney.Controls.Add(Me.lblAcctVer)
        Me.grpLostAssignMoney.Location = New System.Drawing.Point(10, 8)
        Me.grpLostAssignMoney.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpLostAssignMoney.Name = "grpLostAssignMoney"
        Me.grpLostAssignMoney.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpLostAssignMoney.Size = New System.Drawing.Size(793, 508)
        Me.grpLostAssignMoney.TabIndex = 2
        Me.grpLostAssignMoney.TabStop = False
        '
        'btnPrevious
        '
        Me.btnPrevious.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPrevious.Font = New System.Drawing.Font("Rockwell", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.Location = New System.Drawing.Point(85, 335)
        Me.btnPrevious.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(199, 47)
        Me.btnPrevious.TabIndex = 1
        Me.btnPrevious.Text = "Back to Previous"
        Me.btnPrevious.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Rockwell", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(258, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(282, 25)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Please Re-Verify Account # :"
        '
        'lblPriceReminder
        '
        Me.lblPriceReminder.AutoSize = True
        Me.lblPriceReminder.BackColor = System.Drawing.Color.Snow
        Me.lblPriceReminder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPriceReminder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPriceReminder.Location = New System.Drawing.Point(159, 428)
        Me.lblPriceReminder.Name = "lblPriceReminder"
        Me.lblPriceReminder.Size = New System.Drawing.Size(448, 20)
        Me.lblPriceReminder.TabIndex = 3
        Me.lblPriceReminder.Text = "Reminder: All Lost Tag Replacements cost $25 to replace."
        '
        'btnEnter
        '
        Me.btnEnter.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEnter.Font = New System.Drawing.Font("Rockwell", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter.Location = New System.Drawing.Point(511, 335)
        Me.btnEnter.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(199, 47)
        Me.btnEnter.TabIndex = 2
        Me.btnEnter.Text = "Verify"
        Me.btnEnter.UseVisualStyleBackColor = False
        '
        'btnProcess
        '
        Me.btnProcess.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnProcess.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnProcess.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProcess.Location = New System.Drawing.Point(493, 427)
        Me.btnProcess.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(225, 63)
        Me.btnProcess.TabIndex = 3
        Me.btnProcess.Text = "Process Transaction"
        Me.btnProcess.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(96, 427)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(225, 63)
        Me.btnBack.TabIndex = 4
        Me.btnBack.Text = "Back to Previous"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'txtAssignNewTag
        '
        Me.txtAssignNewTag.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Tag #", True))
        Me.txtAssignNewTag.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAssignNewTag.Location = New System.Drawing.Point(589, 103)
        Me.txtAssignNewTag.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAssignNewTag.Name = "txtAssignNewTag"
        Me.txtAssignNewTag.ReadOnly = True
        Me.txtAssignNewTag.Size = New System.Drawing.Size(115, 28)
        Me.txtAssignNewTag.TabIndex = 5
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(141, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 24)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Assign New Tag:"
        '
        'lblDeduct
        '
        Me.lblDeduct.AutoSize = True
        Me.lblDeduct.Font = New System.Drawing.Font("Rockwell", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeduct.Location = New System.Drawing.Point(108, 182)
        Me.lblDeduct.Name = "lblDeduct"
        Me.lblDeduct.Size = New System.Drawing.Size(252, 24)
        Me.lblDeduct.TabIndex = 7
        Me.lblDeduct.Text = "Deduct Payment ( $ 25 ) :"
        '
        'txtDeduct
        '
        Me.txtDeduct.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Account Balance", True))
        Me.txtDeduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeduct.Location = New System.Drawing.Point(589, 182)
        Me.txtDeduct.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDeduct.Name = "txtDeduct"
        Me.txtDeduct.ReadOnly = True
        Me.txtDeduct.Size = New System.Drawing.Size(115, 28)
        Me.txtDeduct.TabIndex = 8
        '
        'btnDeduct
        '
        Me.btnDeduct.BackColor = System.Drawing.Color.Khaki
        Me.btnDeduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDeduct.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeduct.Location = New System.Drawing.Point(427, 172)
        Me.btnDeduct.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDeduct.Name = "btnDeduct"
        Me.btnDeduct.Size = New System.Drawing.Size(120, 47)
        Me.btnDeduct.TabIndex = 9
        Me.btnDeduct.Text = "Deduct"
        Me.btnDeduct.UseVisualStyleBackColor = False
        '
        'btnAssignNewTag
        '
        Me.btnAssignNewTag.BackColor = System.Drawing.Color.Khaki
        Me.btnAssignNewTag.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAssignNewTag.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAssignNewTag.Location = New System.Drawing.Point(427, 95)
        Me.btnAssignNewTag.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAssignNewTag.Name = "btnAssignNewTag"
        Me.btnAssignNewTag.Size = New System.Drawing.Size(120, 47)
        Me.btnAssignNewTag.TabIndex = 10
        Me.btnAssignNewTag.Text = "Assign New"
        Me.btnAssignNewTag.UseVisualStyleBackColor = False
        '
        'lblNewStatus
        '
        Me.lblNewStatus.AutoSize = True
        Me.lblNewStatus.Font = New System.Drawing.Font("Rockwell", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewStatus.Location = New System.Drawing.Point(143, 255)
        Me.lblNewStatus.Name = "lblNewStatus"
        Me.lblNewStatus.Size = New System.Drawing.Size(169, 24)
        Me.lblNewStatus.TabIndex = 11
        Me.lblNewStatus.Text = "New Tag Status:"
        '
        'txtNewTagStatus
        '
        Me.txtNewTagStatus.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Tag Status", True))
        Me.txtNewTagStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewTagStatus.Location = New System.Drawing.Point(465, 255)
        Me.txtNewTagStatus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNewTagStatus.Name = "txtNewTagStatus"
        Me.txtNewTagStatus.ReadOnly = True
        Me.txtNewTagStatus.Size = New System.Drawing.Size(195, 28)
        Me.txtNewTagStatus.TabIndex = 12
        '
        'lblTagDateAssign
        '
        Me.lblTagDateAssign.AutoSize = True
        Me.lblTagDateAssign.Font = New System.Drawing.Font("Rockwell", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTagDateAssign.Location = New System.Drawing.Point(131, 315)
        Me.lblTagDateAssign.Name = "lblTagDateAssign"
        Me.lblTagDateAssign.Size = New System.Drawing.Size(203, 24)
        Me.lblTagDateAssign.TabIndex = 13
        Me.lblTagDateAssign.Text = "Tag Date Assigned:"
        '
        'txtTagDateAssign
        '
        Me.txtTagDateAssign.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Tag Date Assigned", True))
        Me.txtTagDateAssign.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTagDateAssign.Location = New System.Drawing.Point(465, 314)
        Me.txtTagDateAssign.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTagDateAssign.Name = "txtTagDateAssign"
        Me.txtTagDateAssign.ReadOnly = True
        Me.txtTagDateAssign.Size = New System.Drawing.Size(195, 28)
        Me.txtTagDateAssign.TabIndex = 14
        '
        'lblUndoDate
        '
        Me.lblUndoDate.AutoSize = True
        Me.lblUndoDate.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUndoDate.Location = New System.Drawing.Point(57, 379)
        Me.lblUndoDate.Name = "lblUndoDate"
        Me.lblUndoDate.Size = New System.Drawing.Size(160, 18)
        Me.lblUndoDate.TabIndex = 15
        Me.lblUndoDate.Text = "Undo Removal Date:"
        '
        'txtUndoDate
        '
        Me.txtUndoDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Removal Date", True))
        Me.txtUndoDate.Location = New System.Drawing.Point(240, 378)
        Me.txtUndoDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtUndoDate.Name = "txtUndoDate"
        Me.txtUndoDate.Size = New System.Drawing.Size(89, 22)
        Me.txtUndoDate.TabIndex = 16
        '
        'lblUndoReason
        '
        Me.lblUndoReason.AutoSize = True
        Me.lblUndoReason.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUndoReason.Location = New System.Drawing.Point(412, 382)
        Me.lblUndoReason.Name = "lblUndoReason"
        Me.lblUndoReason.Size = New System.Drawing.Size(180, 18)
        Me.lblUndoReason.TabIndex = 17
        Me.lblUndoReason.Text = "Undo Removal Reason:"
        '
        'txtUndoReason
        '
        Me.txtUndoReason.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Removal Reason", True))
        Me.txtUndoReason.Location = New System.Drawing.Point(615, 380)
        Me.txtUndoReason.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtUndoReason.Name = "txtUndoReason"
        Me.txtUndoReason.Size = New System.Drawing.Size(89, 22)
        Me.txtUndoReason.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FloralWhite
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(284, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(242, 31)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Customer New Tag"
        '
        'CustomersInfoTableAdapter
        '
        Me.CustomersInfoTableAdapter.ClearBeforeFill = True
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(815, 527)
        Me.Controls.Add(Me.grpLostAssignMoney)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtUndoReason)
        Me.Controls.Add(Me.lblUndoReason)
        Me.Controls.Add(Me.txtUndoDate)
        Me.Controls.Add(Me.lblUndoDate)
        Me.Controls.Add(Me.txtTagDateAssign)
        Me.Controls.Add(Me.lblTagDateAssign)
        Me.Controls.Add(Me.txtNewTagStatus)
        Me.Controls.Add(Me.lblNewStatus)
        Me.Controls.Add(Me.btnAssignNewTag)
        Me.Controls.Add(Me.btnDeduct)
        Me.Controls.Add(Me.txtDeduct)
        Me.Controls.Add(Me.lblDeduct)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAssignNewTag)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnProcess)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form6"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lost Tag Assignment"
        Me.grpLostAssignMoney.ResumeLayout(False)
        Me.grpLostAssignMoney.PerformLayout()
        CType(Me.CustomersInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EzPassDBSystem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAcctVer As Label
    Friend WithEvents txtAcctSearch As TextBox
    Friend WithEvents grpLostAssignMoney As GroupBox
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnProcess As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents txtAssignNewTag As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblDeduct As Label
    Friend WithEvents txtDeduct As TextBox
    Friend WithEvents lblPriceReminder As Label
    Friend WithEvents btnDeduct As Button
    Friend WithEvents btnAssignNewTag As Button
    Friend WithEvents lblNewStatus As Label
    Friend WithEvents txtNewTagStatus As TextBox
    Friend WithEvents lblTagDateAssign As Label
    Friend WithEvents txtTagDateAssign As TextBox
    Friend WithEvents lblUndoDate As Label
    Friend WithEvents txtUndoDate As TextBox
    Friend WithEvents lblUndoReason As Label
    Friend WithEvents txtUndoReason As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnPrevious As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents EzPassDBSystem As EzPassDBSystem
    Friend WithEvents CustomersInfoBindingSource As BindingSource
    Friend WithEvents CustomersInfoTableAdapter As EzPassDBSystemTableAdapters.CustomersInfoTableAdapter
End Class
