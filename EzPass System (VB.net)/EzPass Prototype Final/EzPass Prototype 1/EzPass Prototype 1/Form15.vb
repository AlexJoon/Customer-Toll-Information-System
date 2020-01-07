Imports System.ComponentModel

Public Class Form15

    ''
    Dim FareInputBox As String

    Dim DefaultValueSpace As String = " "

    Dim Cancelling As String = ""

    ''
    Dim QuitInitiated As Boolean = False


    Sub NewEffectiveDateTime()

        Dim NewDateTime As Date = Date.Today.ToString("MM/dd/yyyy")

        lblEffectiveDate.Text = NewDateTime

    End Sub

    Private Sub Form15_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EzPassDBSystem.TollCodes' table. You can move, or remove it, as needed.
        Me.TollCodesTableAdapter.Fill(Me.EzPassDBSystem.TollCodes)

        NewEffectiveDateTime()

        btnProcess.Enabled = False

    End Sub

    ''
    Private Sub Form15_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        If QuitInitiated = True Then

            e.Cancel = False

        Else

            e.Cancel = True

        End If

    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        QuitInitiated = True

        Form17.Show()
        Me.Close()

    End Sub

    Sub EmptyInputField()

        Dim EmptyFieldMsg As Integer

        EmptyFieldMsg = MessageBox.Show("The Fare field is empty!", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Error)


    End Sub

    Sub FareDecrease()

        Dim FareDecrease As Double

        Dim TollFareParsed As Double

        FareInputBox = InputBox("How much do you want to decrease the Fare?", "Fare Decrease", DefaultValueSpace)

        If FareInputBox = DefaultValueSpace Then

            EmptyInputField()
            btnProcess.Enabled = False

        ElseIf FareInputBox = Cancelling Then

            Exit Sub

        Else

            btnProcess.Enabled = True
            btnIncrease.Enabled = False

        End If

        Double.TryParse(lblTollFare.Text, TollFareParsed)

        Double.TryParse(FareInputBox, FareDecrease)

        TollFareParsed -= FareDecrease

        lblTollFare.Text = TollFareParsed


    End Sub

    Sub FareIncrease()

        Dim FareIncrease As Double

        Dim TollFareParsed As Double

        FareInputBox = InputBox("How much do you want to increase the Fare?", "Fare Increase", DefaultValueSpace)

        If FareInputBox = DefaultValueSpace Then

            EmptyInputField()
            btnProcess.Enabled = False

        ElseIf FareInputBox = Cancelling Then

            Exit Sub

        Else

            btnProcess.Enabled = True
            btnIncrease.Enabled = False

        End If

        Double.TryParse(lblTollFare.Text, TollFareParsed)

        Double.TryParse(FareInputBox, FareIncrease)

        TollFareParsed += FareIncrease

        lblTollFare.Text = TollFareParsed

    End Sub

    Private Sub btnDecrease_Click(sender As Object, e As EventArgs) Handles btnDecrease.Click

        FareDecrease()

    End Sub

    Private Sub BtnIncrease_Click(sender As Object, e As EventArgs) Handles btnIncrease.Click

        FareIncrease()

    End Sub

    Sub IncreaseFareSuccess()

        Dim SuccessMsg As Integer

        SuccessMsg = MessageBox.Show("The fares have been successfully updated. Closing window now.", "Updated Fares", MessageBoxButtons.OK, MessageBoxIcon.Information)

        If SuccessMsg = DialogResult.OK Then

            Me.Validate()
            Me.TollCodesBindingSource.EndEdit()
            Me.TollCodesTableAdapter.Update(Me.EzPassDBSystem)

            QuitInitiated = True

            Me.Close()
            Form17.Show()

        End If

    End Sub

    Private Sub BtnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click

        IncreaseFareSuccess()

    End Sub


End Class