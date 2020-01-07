Imports System.ComponentModel

Public Class Form20

    Dim FirstNameFocus As Boolean = False

    Dim LastNameFocus As Boolean = False

    Dim UsernameFocus As Boolean = False

    Dim PasswordFocus As Boolean = False

    ''
    Dim QuitInitiated As Boolean = False

    Sub PassCodeGenerator()

        Dim RndGenerator As New Random()

        Dim RndMinValue As Integer = 1000

        Dim RndFinalValue As Integer = 1999

        lblPassCode.Text = RndGenerator.Next(RndMinValue, RndFinalValue)

    End Sub

    Sub TextFieldClearing()

        txtFirstName.Clear()
        txtLastName.Clear()
        txtUsername.Clear()
        txtPassword.Clear()

    End Sub

    Private Sub Form20_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'EzPassDBSystem.EmployeeAccounts' table. You can move, or remove it, as needed.
        Me.EmployeeAccountsTableAdapter.Fill(Me.EzPassDBSystem.EmployeeAccounts)

        TextFieldClearing()
        PassCodeGenerator()

    End Sub

    Private Sub Form20_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        If QuitInitiated = True Then

            e.Cancel = False

        Else

            e.Cancel = True

        End If

    End Sub

    Sub TextFocusColor()

        If FirstNameFocus = True Then

            txtFirstName.BackColor = Color.LemonChiffon

        Else

            FirstNameFocus = False
            txtFirstName.BackColor = Color.White

        End If

        If LastNameFocus = True Then

            txtLastName.BackColor = Color.LemonChiffon

        Else

            LastNameFocus = False
            txtLastName.BackColor = Color.White

        End If

        If UsernameFocus = True Then

            txtUsername.BackColor = Color.LemonChiffon

        Else

            UsernameFocus = False
            txtUsername.BackColor = Color.White

        End If

        If PasswordFocus = True Then

            txtPassword.BackColor = Color.LemonChiffon

        Else

            PasswordFocus = False
            txtPassword.BackColor = Color.White

        End If

    End Sub

    Private Sub txtFirstName_GotFocus(sender As Object, e As EventArgs) Handles txtFirstName.GotFocus

        FirstNameFocus = True
        LastNameFocus = False
        UsernameFocus = False
        PasswordFocus = False

        TextFocusColor()

    End Sub

    Private Sub txtLastName_GotFocus(sender As Object, e As EventArgs) Handles txtLastName.GotFocus

        FirstNameFocus = False
        LastNameFocus = True
        UsernameFocus = False
        PasswordFocus = False

        TextFocusColor()

    End Sub

    Private Sub txtUsername_GotFocus(sender As Object, e As EventArgs) Handles txtUsername.GotFocus

        FirstNameFocus = False
        LastNameFocus = False
        UsernameFocus = True
        PasswordFocus = False

        TextFocusColor()

    End Sub

    Private Sub txtPassword_GotFocus(sender As Object, e As EventArgs) Handles txtPassword.GotFocus

        FirstNameFocus = False
        LastNameFocus = False
        UsernameFocus = False
        PasswordFocus = True

        TextFocusColor()

    End Sub

    Sub RegistrationExit()

        QuitInitiated = True

        Form2.grpLoginScreen.Enabled = True
        Me.Close()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        RegistrationExit()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        TextFieldClearing()

    End Sub

    Sub FieldsCreationCheck()

        Dim EmptyFieldMsg As Integer

        Dim AcctCreationMsg As Integer

        If txtFirstName.Text = String.Empty Or txtLastName.Text = String.Empty Or txtUsername.Text = String.Empty Or txtPassword.Text = String.Empty Then

            EmptyFieldMsg = MessageBox.Show("There are empty fields on the form! Please fill out the rest.", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        Else

            AcctCreationMsg = MessageBox.Show("Your Employee Account has been created successfully!", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information)

            If AcctCreationMsg = DialogResult.OK Then

                Me.Validate()
                Me.EmployeeAccountsBindingSource.EndEdit()
                Me.EmployeeAccountsTableAdapter.Update(Me.EzPassDBSystem)

            End If

        End If

    End Sub

    Private Sub btnCreateAcct_Click(sender As Object, e As EventArgs) Handles btnCreateAcct.Click

        FieldsCreationCheck()

    End Sub


End Class