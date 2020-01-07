Imports System.ComponentModel

Public Class Form13

    Dim StepMovingRight As Integer = 2

    Dim StepMovingLeft As Integer = -2

    Dim CarMovingSpeed As Integer = 10

    Dim CarStopped As Integer = 0

    Dim CarReachDestination As Boolean = False

    Private Sub Form13_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        btnExit.Enabled = False

        lblDeduct.Enabled = False
        lblDeduct.Visible = False

        lblTrip.Enabled = False
        lblTrip.Visible = False

        KeyPreview = True

    End Sub

    Private Sub Form13_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        If CarReachDestination = False Then

            e.Cancel = True

        Else

            e.Cancel = False

        End If

    End Sub

    Private Sub Form13_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.A Then

            PicCar.Left -= CarMovingSpeed
            ProBarTrip.Step = StepMovingLeft
            ProBarTrip.PerformStep()

        End If

        If e.KeyCode = Keys.D Then

            PicCar.Left += CarMovingSpeed
            ProBarTrip.Step = StepMovingRight
            ProBarTrip.PerformStep()

        End If

    End Sub

    Private Sub PicCar_Move(sender As Object, e As EventArgs) Handles PicCar.Move

        If PicCar.Location.X > 285 Then

            lblDeduct.Enabled = True
            lblDeduct.Visible = True

        End If

        If PicCar.Location.X > 540 Then

            CarMovingSpeed = CarStopped
            lblTrip.Enabled = True
            lblTrip.Visible = True

            btnExit.Enabled = True
            btnExit.BackColor = Color.LightGreen

        End If

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        CarReachDestination = True

        Form9.NoFocusColor()

        Form9.grpVerifyAcct.Enabled = True
        Form9.grpVerifyAcct.Visible = True

        Form9.txtAcctSearch.Clear()
        Form9.txtTagSearch.Clear()

        Form9.Validate()

        Form9.CustomersInfoBindingSource.EndEdit()
        Form9.CustomersInfoTableAdapter.Update(Form9.EzPassDBSystem)

        Form9.CustomersTollBindingSource.EndEdit()
        Form9.CustomersTollTableAdapter.Update(Form9.EzPassDBSystem)

        Form9.TollCodesBindingSource.EndEdit()
        Form9.TollCodesTableAdapter.Update(Form9.EzPassDBSystem)

        Me.Close()

    End Sub


End Class