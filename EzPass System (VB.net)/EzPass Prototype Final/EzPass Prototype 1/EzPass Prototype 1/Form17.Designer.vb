<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form17
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
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnGoNewToll = New System.Windows.Forms.Button()
        Me.btnGoUpdateToll = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnGoTollDescription = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(325, 280)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(153, 48)
        Me.btnBack.TabIndex = 0
        Me.btnBack.Text = "Back to Database"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnGoNewToll
        '
        Me.btnGoNewToll.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnGoNewToll.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGoNewToll.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGoNewToll.Location = New System.Drawing.Point(62, 171)
        Me.btnGoNewToll.Name = "btnGoNewToll"
        Me.btnGoNewToll.Size = New System.Drawing.Size(142, 44)
        Me.btnGoNewToll.TabIndex = 1
        Me.btnGoNewToll.Text = "Go"
        Me.btnGoNewToll.UseVisualStyleBackColor = False
        '
        'btnGoUpdateToll
        '
        Me.btnGoUpdateToll.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnGoUpdateToll.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGoUpdateToll.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGoUpdateToll.Location = New System.Drawing.Point(585, 171)
        Me.btnGoUpdateToll.Name = "btnGoUpdateToll"
        Me.btnGoUpdateToll.Size = New System.Drawing.Size(142, 44)
        Me.btnGoUpdateToll.TabIndex = 2
        Me.btnGoUpdateToll.Text = "Go"
        Me.btnGoUpdateToll.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightSalmon
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(275, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(254, 27)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Update Toll Monitoring"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(198, 21)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Add New Toll Crossing:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(581, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 21)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Update Toll Fares:"
        '
        'btnGoTollDescription
        '
        Me.btnGoTollDescription.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnGoTollDescription.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGoTollDescription.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGoTollDescription.Location = New System.Drawing.Point(325, 171)
        Me.btnGoTollDescription.Name = "btnGoTollDescription"
        Me.btnGoTollDescription.Size = New System.Drawing.Size(142, 44)
        Me.btnGoTollDescription.TabIndex = 6
        Me.btnGoTollDescription.Text = "Go"
        Me.btnGoTollDescription.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(325, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 21)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Toll Description:"
        '
        'Form17
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.EzPass_Prototype_1.My.Resources.Resources.Ezpass_Registration_Login_Background
        Me.ClientSize = New System.Drawing.Size(791, 351)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnGoTollDescription)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnGoUpdateToll)
        Me.Controls.Add(Me.btnGoNewToll)
        Me.Controls.Add(Me.btnBack)
        Me.Name = "Form17"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Toll Monitoring"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents btnGoNewToll As Button
    Friend WithEvents btnGoUpdateToll As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnGoTollDescription As Button
    Friend WithEvents Label4 As Label
End Class
