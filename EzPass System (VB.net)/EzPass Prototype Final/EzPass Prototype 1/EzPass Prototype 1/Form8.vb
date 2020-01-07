Imports System.ComponentModel

Public Class Form8

    ''Beginning of Comments for Form 8 of EzPass Database System Project.''

    'Class-Level Variable used for all Sub-routines on this Form.
    Dim AcctFieldisFull As Boolean = False

    Dim FirstNameWriting As Boolean = False

    Dim LastNameWriting As Boolean = False

    ''
    Dim FirstNameFocus As Boolean = False

    Dim LastNameFocus As Boolean = False

    ''
    Dim QuitInitiated As Boolean = False


    'Preloads the CustomersInfo Datatable from the Access Database to this Form 8 when the form is loaded/executed.
    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'EzPassDBSystem.CustomersInfo' table. You can move, or remove it, as needed.
        Me.CustomersInfoTableAdapter.Fill(Me.EzPassDBSystem.CustomersInfo)

    End Sub

    Private Sub Form8_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        If QuitInitiated = True Then

            e.Cancel = False

        Else

            e.Cancel = True

        End If

    End Sub

    Sub UpdateLoginEnabled()

        Form3.NoHighlightedFocus()
        Form3.grpUpdateAcct.Enabled = True

    End Sub

    'Button Click Event, that if clicked, focuses the user back to the previous form and closes this Form 8.
    Private Sub btnBacktoUser_Click(sender As Object, e As EventArgs) Handles btnBacktoUser.Click

        QuitInitiated = True

        UpdateLoginEnabled()
        Me.Close()

    End Sub

    Sub LoginFocusReset()

        FirstNameFocus = False
        LastNameFocus = False

        txtFirstName.BackColor = Color.White
        txtLastName.BackColor = Color.White

        txtFirstName.Clear()
        txtLastName.Clear()

    End Sub

    Sub TextOnlyDetect()

        Dim NameMsg As Integer

        NameMsg = MessageBox.Show("This field only accepts text! No Numbers.", "No Numbers", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        If NameMsg = DialogResult.OK And FirstNameWriting = True Then

            txtFirstName.Clear()

        End If

        If NameMsg = DialogResult.OK And LastNameWriting = True Then

            txtLastName.Clear()

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

    End Sub

    Private Sub txtFirstName_GotFocus(sender As Object, e As EventArgs) Handles txtFirstName.GotFocus

        FirstNameFocus = True
        LastNameFocus = False

        TextFocusColor()

    End Sub

    Private Sub txtLastName_GotFocus(sender As Object, e As EventArgs) Handles txtLastName.GotFocus

        FirstNameFocus = False
        LastNameFocus = True

        TextFocusColor()

    End Sub

    Private Sub txtFirstName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFirstName.KeyPress

        FirstNameWriting = True
        LastNameWriting = False

        If Char.IsNumber(e.KeyChar) And Not e.KeyChar = ChrW(Keys.Back) Then

            e.Handled = True
            TextOnlyDetect()

        End If

    End Sub

    Private Sub txtLastName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLastName.KeyPress

        FirstNameWriting = False
        LastNameWriting = True

        If Char.IsNumber(e.KeyChar) And Not e.KeyChar = ChrW(Keys.Back) Then

            e.Handled = True
            TextOnlyDetect()

        End If

    End Sub

    'Subroutine made to check if the First Name OR Last Name fields are empty. If they are, the user will be
    'displayed a dialog box stating that there are empty fields on the Form and prompting them to re-enter a valid name.
    ' If the Fields are full, The AcctFieldisFull Boolean will return true which will be used to verify the Account.
    Sub TextFieldsVerify()

        Dim EmptyFieldsMsg As Integer

        Dim AccountFoundMsg As Integer

        'If either the First Name OR Last Name contains No strings. This 'If/Else' Statement happens.
        If txtFirstName.Text = String.Empty Or txtLastName.Text = String.Empty Then

            EmptyFieldsMsg = MessageBox.Show("There are empty fields! Please try again.", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            AcctFieldisFull = False

        Else

            AccountFoundMsg = MessageBox.Show("Thank you! Checking to see if Account exists. ", "Account Checking", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'Boolean used later to verify if that First & Last Name belongs to any of the Accounts via SQL Query.
            AcctFieldisFull = True

        End If

    End Sub

    'Subroutine made to display to the user that the Account they are trying to reach does not exist and that
    ' they should try adding a valid Account Number into the Account text field.
    Sub AccountNotExist()

        Dim AccountMsg As Integer

        AccountMsg = MessageBox.Show("That account does not exist. Please Try again.", "Account Doesn't Exist", MessageBoxButtons.OK, MessageBoxIcon.Error)

        If AccountMsg = DialogResult.OK Then

            LoginFocusReset()

        End If

    End Sub

    'Button Click Event, that if clicked, checks to see if the Text Fields are full via TextFieldsVerify() Subroutine,
    ' If they are full, this Button Event takes that First & Last Name and checks to see if that Name belongs to

    ' any of the Accounts inside the Database by an SQL Query Search. If there is a match, it will display the Account
    ' Number of this person on this Form 8 after the Login Screen.
    Private Sub btnFindAcct_Click(sender As Object, e As EventArgs) Handles btnFindAcct.Click

        TextFieldsVerify() 'Subroutine that is checking for empty Account Field.

        Dim FindAcct As String

        If AcctFieldisFull = True Then

            'The Account field contents are assigned to a Variable that is used for the SQL Query Search.
            FindAcct = txtLastName.Text

            'SQL Query Search for Specific Customer Accounts.
            Me.CustomersInfoTableAdapter.FillByName(Me.EzPassDBSystem.CustomersInfo, FindAcct)

            'If the Account does not exist when the program tries to run the SQL Query Search, this 'If' statement happens.
            If Me.CustomersInfoTableAdapter.FillByName(Me.EzPassDBSystem.CustomersInfo, FindAcct) = Nothing Then

                AccountNotExist() 'subroutine dialog box that displays to the user that this account doesn't exist.

                'The user stays on the login page without accessing the next part of the form due to the fact that
                ' they havent found a valid Account.
                grpFindAcctBox.Enabled = True
                grpFindAcctBox.Visible = True

                'This else happens when the account exists in the database. User is taken to next screen after login verification.
            Else

                grpFindAcctBox.Enabled = False
                grpFindAcctBox.Visible = False

            End If

        End If

    End Sub

    'Button Click Event, that if clicked, returns the user back to the previous Form and closes this Form 8.
    ' This button is located on the next page of the Form 8, where the User/Employee finds what their Account # was.
    Private Sub btnSecondBack_Click(sender As Object, e As EventArgs) Handles btnSecondBack.Click

        QuitInitiated = True

        UpdateLoginEnabled()
        Me.Close()

    End Sub



    ''End of Comments for Form 8 of EzPass Database System Project.''

End Class