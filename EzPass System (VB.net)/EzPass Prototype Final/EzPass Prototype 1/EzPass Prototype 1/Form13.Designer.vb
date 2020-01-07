<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form13
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
        Me.lblToll = New System.Windows.Forms.Label()
        Me.lblTrip = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.PicCar = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ProBarTrip = New System.Windows.Forms.ProgressBar()
        Me.lblDeduct = New System.Windows.Forms.Label()
        Me.lblLeftKeyTitle = New System.Windows.Forms.Label()
        Me.lblRightKeyTitle = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.PicCar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblToll
        '
        Me.lblToll.AutoSize = True
        Me.lblToll.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblToll.Location = New System.Drawing.Point(76, 31)
        Me.lblToll.Name = "lblToll"
        Me.lblToll.Size = New System.Drawing.Size(299, 34)
        Me.lblToll.TabIndex = 1
        Me.lblToll.Text = "Toll Being Crossed..."
        '
        'lblTrip
        '
        Me.lblTrip.AutoSize = True
        Me.lblTrip.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrip.Location = New System.Drawing.Point(652, 143)
        Me.lblTrip.Name = "lblTrip"
        Me.lblTrip.Size = New System.Drawing.Size(313, 34)
        Me.lblTrip.TabIndex = 2
        Me.lblTrip.Text = "Trip Has Been Taken!"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Rockwell", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(44, 598)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(242, 83)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'PicCar
        '
        Me.PicCar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.PicCar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PicCar.Image = Global.EzPass_Prototype_1.My.Resources.Resources.SportsCar2
        Me.PicCar.Location = New System.Drawing.Point(26, 388)
        Me.PicCar.Name = "PicCar"
        Me.PicCar.Size = New System.Drawing.Size(166, 76)
        Me.PicCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicCar.TabIndex = 5
        Me.PicCar.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(434, 318)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 29)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Toll Crossing"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(801, 318)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(204, 29)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Trip Destination"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 318)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(172, 29)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Starting Point"
        '
        'ProBarTrip
        '
        Me.ProBarTrip.Location = New System.Drawing.Point(262, 232)
        Me.ProBarTrip.Name = "ProBarTrip"
        Me.ProBarTrip.Size = New System.Drawing.Size(488, 35)
        Me.ProBarTrip.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProBarTrip.TabIndex = 9
        '
        'lblDeduct
        '
        Me.lblDeduct.AutoSize = True
        Me.lblDeduct.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeduct.Location = New System.Drawing.Point(348, 85)
        Me.lblDeduct.Name = "lblDeduct"
        Me.lblDeduct.Size = New System.Drawing.Size(327, 34)
        Me.lblDeduct.TabIndex = 0
        Me.lblDeduct.Text = "Fare Being Deducted.."
        '
        'lblLeftKeyTitle
        '
        Me.lblLeftKeyTitle.AutoSize = True
        Me.lblLeftKeyTitle.BackColor = System.Drawing.Color.LemonChiffon
        Me.lblLeftKeyTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLeftKeyTitle.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLeftKeyTitle.Location = New System.Drawing.Point(502, 572)
        Me.lblLeftKeyTitle.Name = "lblLeftKeyTitle"
        Me.lblLeftKeyTitle.Size = New System.Drawing.Size(143, 31)
        Me.lblLeftKeyTitle.TabIndex = 10
        Me.lblLeftKeyTitle.Text = "Move Left:"
        '
        'lblRightKeyTitle
        '
        Me.lblRightKeyTitle.AutoSize = True
        Me.lblRightKeyTitle.BackColor = System.Drawing.Color.LemonChiffon
        Me.lblRightKeyTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRightKeyTitle.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRightKeyTitle.Location = New System.Drawing.Point(740, 572)
        Me.lblRightKeyTitle.Name = "lblRightKeyTitle"
        Me.lblRightKeyTitle.Size = New System.Drawing.Size(161, 31)
        Me.lblRightKeyTitle.TabIndex = 11
        Me.lblRightKeyTitle.Text = "Move Right:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(532, 623)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 27)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "'A' Key"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(777, 625)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 27)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "'D' Key"
        '
        'Form13
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1024, 729)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblRightKeyTitle)
        Me.Controls.Add(Me.lblLeftKeyTitle)
        Me.Controls.Add(Me.ProBarTrip)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PicCar)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblTrip)
        Me.Controls.Add(Me.lblToll)
        Me.Controls.Add(Me.lblDeduct)
        Me.Name = "Form13"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Toll Simulation"
        CType(Me.PicCar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblToll As Label
    Friend WithEvents lblTrip As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents PicCar As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ProBarTrip As ProgressBar
    Friend WithEvents lblDeduct As Label
    Friend WithEvents lblLeftKeyTitle As Label
    Friend WithEvents lblRightKeyTitle As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
