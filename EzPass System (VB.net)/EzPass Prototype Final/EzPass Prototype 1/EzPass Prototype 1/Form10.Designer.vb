<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form10
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
        Me.grpTagHelp = New System.Windows.Forms.GroupBox()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.txtAcctSearch = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CustomersInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EzPassDBSystem = New EzPass_Prototype_1.EzPassDBSystem()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSecBack = New System.Windows.Forms.Button()
        Me.CustomersInfoTableAdapter = New EzPass_Prototype_1.EzPassDBSystemTableAdapters.CustomersInfoTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblActiveTag = New System.Windows.Forms.Label()
        Me.grpTagHelp.SuspendLayout()
        CType(Me.CustomersInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EzPassDBSystem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpTagHelp
        '
        Me.grpTagHelp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.grpTagHelp.BackgroundImage = Global.EzPass_Prototype_1.My.Resources.Resources.Ezpass_Registration_Login_Background
        Me.grpTagHelp.Controls.Add(Me.btnFind)
        Me.grpTagHelp.Controls.Add(Me.btnBack)
        Me.grpTagHelp.Controls.Add(Me.txtAcctSearch)
        Me.grpTagHelp.Controls.Add(Me.Label2)
        Me.grpTagHelp.Controls.Add(Me.Label1)
        Me.grpTagHelp.Location = New System.Drawing.Point(12, 11)
        Me.grpTagHelp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpTagHelp.Name = "grpTagHelp"
        Me.grpTagHelp.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpTagHelp.Size = New System.Drawing.Size(601, 374)
        Me.grpTagHelp.TabIndex = 0
        Me.grpTagHelp.TabStop = False
        '
        'btnFind
        '
        Me.btnFind.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFind.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFind.Location = New System.Drawing.Point(377, 287)
        Me.btnFind.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(198, 68)
        Me.btnFind.TabIndex = 3
        Me.btnFind.Text = "Find Tag"
        Me.btnFind.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(33, 287)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(198, 68)
        Me.btnBack.TabIndex = 1
        Me.btnBack.Text = "Back to Verification"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'txtAcctSearch
        '
        Me.txtAcctSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAcctSearch.Location = New System.Drawing.Point(200, 185)
        Me.txtAcctSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAcctSearch.Name = "txtAcctSearch"
        Me.txtAcctSearch.Size = New System.Drawing.Size(211, 28)
        Me.txtAcctSearch.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(154, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(307, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "What is your Account Number?"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightCoral
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(219, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tag Helper"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(134, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 29)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Hello,"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "First Name", True))
        Me.Label4.Font = New System.Drawing.Font("Rockwell", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(237, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 29)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "@@"
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Last Name", True))
        Me.Label5.Font = New System.Drawing.Font("Rockwell", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(339, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 29)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "@@"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(128, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(148, 24)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Your Tag # is:"
        '
        'btnSecBack
        '
        Me.btnSecBack.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnSecBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSecBack.Font = New System.Drawing.Font("Rockwell", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSecBack.Location = New System.Drawing.Point(205, 303)
        Me.btnSecBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSecBack.Name = "btnSecBack"
        Me.btnSecBack.Size = New System.Drawing.Size(241, 66)
        Me.btnSecBack.TabIndex = 5
        Me.btnSecBack.Text = "Exit Tag Help"
        Me.btnSecBack.UseVisualStyleBackColor = False
        '
        'CustomersInfoTableAdapter
        '
        Me.CustomersInfoTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Bisque
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblActiveTag)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(123, 116)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(397, 129)
        Me.Panel1.TabIndex = 7
        '
        'lblActiveTag
        '
        Me.lblActiveTag.AutoSize = True
        Me.lblActiveTag.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Tag #", True))
        Me.lblActiveTag.Font = New System.Drawing.Font("Rockwell", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActiveTag.Location = New System.Drawing.Point(171, 72)
        Me.lblActiveTag.Name = "lblActiveTag"
        Me.lblActiveTag.Size = New System.Drawing.Size(69, 33)
        Me.lblActiveTag.TabIndex = 5
        Me.lblActiveTag.Text = "@@"
        '
        'Form10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(625, 396)
        Me.Controls.Add(Me.grpTagHelp)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnSecBack)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form10"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tag Helper"
        Me.grpTagHelp.ResumeLayout(False)
        Me.grpTagHelp.PerformLayout()
        CType(Me.CustomersInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EzPassDBSystem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpTagHelp As GroupBox
    Friend WithEvents btnFind As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents txtAcctSearch As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnSecBack As Button
    Friend WithEvents EzPassDBSystem As EzPassDBSystem
    Friend WithEvents CustomersInfoBindingSource As BindingSource
    Friend WithEvents CustomersInfoTableAdapter As EzPassDBSystemTableAdapters.CustomersInfoTableAdapter
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblActiveTag As Label
End Class
