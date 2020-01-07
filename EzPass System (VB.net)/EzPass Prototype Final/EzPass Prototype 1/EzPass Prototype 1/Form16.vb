Imports System.ComponentModel

Public Class Form16

    Dim AccountValidationBoolean As Boolean = False

    Dim TollNameFocus As Boolean = False

    Dim TollFareFocus As Boolean = False

    Dim TollCodeFocus As Boolean = False

    Dim FirstEntryFocus As Boolean = False

    Dim SecondEntryFocus As Boolean = False

    ''
    Dim QuitInitiated As Boolean = False


    Sub FareEffectiveDate()

        Dim CurrentDate As String = Date.Today.ToString("MM/dd/yyyy")

        lblCurrentDate.Text = CurrentDate

    End Sub

    Sub RevenueDefaultValue()

        Dim RevDefault As Double

        RevDefault = 0

        txtTollRevenue.Text = RevDefault.ToString()

    End Sub

    Private Sub Form16_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'EzPassDBSystem.TollCodes' table. You can move, or remove it, as needed.
        Me.TollCodesTableAdapter.Fill(Me.EzPassDBSystem.TollCodes)

        Me.TollCodesBindingSource.AddNew()

        FareEffectiveDate()
        RevenueDefaultValue()

        cmbTollType.SelectedIndex = 0

        TollCodeFocus = True
        TextFocusColor()

    End Sub

    Private Sub Form16_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        If QuitInitiated = True Then

            e.Cancel = False

        Else

            e.Cancel = True


        End If

    End Sub

    Sub ResettingFields()

        txtAddTollCode.Clear()
        txtAddTollFare.Clear()
        txtAddTollName.Clear()
        txtFirstEntryPoint.Clear()
        txtSecondEntryPoint.Clear()
        cmbTollType.SelectedIndex = 0


        txtAddTollCode.BackColor = Color.White
        txtAddTollFare.BackColor = Color.White
        txtAddTollName.BackColor = Color.White
        txtFirstEntryPoint.BackColor = Color.White
        txtSecondEntryPoint.BackColor = Color.White

    End Sub

    Sub TextFocusColor()

        If TollFareFocus = True Then

            txtAddTollFare.BackColor = Color.LemonChiffon

        Else

            TollFareFocus = False
            txtAddTollFare.BackColor = Color.White

        End If

        If TollNameFocus = True Then

            txtAddTollName.BackColor = Color.LemonChiffon

        Else

            TollNameFocus = False
            txtAddTollName.BackColor = Color.White

        End If

        If TollCodeFocus = True Then

            txtAddTollCode.BackColor = Color.LemonChiffon

        Else

            TollCodeFocus = False
            txtAddTollCode.BackColor = Color.White


        End If

        If FirstEntryFocus = True Then

            txtFirstEntryPoint.BackColor = Color.LemonChiffon

        Else

            FirstEntryFocus = False
            txtFirstEntryPoint.BackColor = Color.White

        End If


        If SecondEntryFocus = True Then

            txtSecondEntryPoint.BackColor = Color.LemonChiffon

        Else

            SecondEntryFocus = False
            txtSecondEntryPoint.BackColor = Color.White

        End If

    End Sub

    Sub NoHighlightFocus()

        TollFareFocus = False
        TollNameFocus = False
        TollCodeFocus = False
        FirstEntryFocus = False
        SecondEntryFocus = False

    End Sub

    Private Sub txtAddTollFare_GotFocus(sender As Object, e As EventArgs) Handles txtAddTollFare.GotFocus

        TollFareFocus = True
        TollNameFocus = False
        TollCodeFocus = False
        FirstEntryFocus = False
        SecondEntryFocus = False

        TextFocusColor()

    End Sub

    Private Sub txtAddTollName_GotFocus(sender As Object, e As EventArgs) Handles txtAddTollName.GotFocus

        TollFareFocus = False
        TollNameFocus = True
        TollCodeFocus = False
        FirstEntryFocus = False
        SecondEntryFocus = False

        TextFocusColor()

    End Sub

    Private Sub txtAddTollCode_GotFocus(sender As Object, e As EventArgs) Handles txtAddTollCode.GotFocus

        TollFareFocus = False
        TollNameFocus = False
        TollCodeFocus = True
        FirstEntryFocus = False
        SecondEntryFocus = False

        TextFocusColor()

    End Sub

    Private Sub txtFirstEntryPoint_GotFocus(sender As Object, e As EventArgs) Handles txtFirstEntryPoint.GotFocus

        TollFareFocus = False
        TollNameFocus = False
        TollCodeFocus = False
        FirstEntryFocus = True
        SecondEntryFocus = False

        TextFocusColor()

    End Sub

    Private Sub txtSecondEntryPoint_GotFocus(sender As Object, e As EventArgs) Handles txtSecondEntryPoint.GotFocus

        TollFareFocus = False
        TollNameFocus = False
        TollCodeFocus = False
        FirstEntryFocus = False
        SecondEntryFocus = True

        TextFocusColor()

    End Sub

    Private Sub cmbTollType_GotFocus(sender As Object, e As EventArgs) Handles cmbTollType.GotFocus

        NoHighlightFocus()
        TextFocusColor()

    End Sub


    Private Sub btnClearFields_Click(sender As Object, e As EventArgs) Handles btnClearFields.Click

        ResettingFields()
        NoHighlightFocus()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        QuitInitiated = True

        Form17.Show()
        Me.Close()

    End Sub

    Sub NullFieldTextChecker()

        Dim NullTextMsgBox As Integer

        Dim ComboUnselectedIndex As Integer = 0

        If txtAddTollCode.Text = String.Empty Or txtAddTollFare.Text = String.Empty Or txtAddTollName.Text = String.Empty Or txtFirstEntryPoint.Text = String.Empty Or txtSecondEntryPoint.Text = String.Empty Or cmbTollType.SelectedIndex = ComboUnselectedIndex Then

            NullTextMsgBox = MessageBox.Show("There are Empty Fields in the Form.", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            AccountValidationBoolean = False

        Else

            AccountValidationBoolean = True

        End If

    End Sub

    Sub NewTollCreatedMsg()

        Dim NewTollCreatedMsg As Integer

        NewTollCreatedMsg = MessageBox.Show("New Toll created successfully.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

    End Sub

    Sub NewTollCreationError()

        Dim AccountError As Integer

        AccountError = MessageBox.Show("There has been an error creating that Toll. Try again.", "Creation Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)

    End Sub

    Private Sub btnAddNewToll_Click(sender As Object, e As EventArgs) Handles btnAddNewToll.Click

        NullFieldTextChecker()

        If AccountValidationBoolean = True Then

            Try

                Me.Validate()
                Me.TollCodesBindingSource.EndEdit()
                Me.TollCodesTableAdapter.Update(Me.EzPassDBSystem)

                NewTollCreatedMsg()

                QuitInitiated = True

                Form17.Show()
                Me.Close()

            Catch ex As Exception

                NewTollCreationError()

            End Try


        End If


    End Sub


End Class