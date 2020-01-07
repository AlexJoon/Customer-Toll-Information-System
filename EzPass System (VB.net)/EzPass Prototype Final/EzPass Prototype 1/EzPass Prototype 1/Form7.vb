Public Class Form7

    ''Beginning of Comments for Form 7 of EzPass Database System Project.''
    ''Aleksey Przhevalskiy''

    'Class-Level Variable used for all Subroutines.
    Dim AcctFieldisFull As Boolean = False

    Dim AssignButtonPress As Boolean = False

    ''
    Dim QuitInitiated As Boolean = False

    Dim LoginFocus As Boolean = False

    'Subroutine.
    Sub UpdateButtonReset()

        btnUpdate.Enabled = False
        btnUpdate.BackColor = Color.AntiqueWhite

    End Sub

    'Subroutine.
    Sub UpdateButtonValidated()

        btnUpdate.Enabled = True
        btnUpdate.BackColor = Color.LightGreen

    End Sub

    Sub UndoInvisible()

        lblUndoDate.Enabled = False

        lblUndoDate.Visible = False

        ''
        lblUndoReason.Enabled = False

        lblUndoReason.Visible = False

        ''
        txtUndoDate.Enabled = False

        txtUndoDate.Visible = False

        ''
        txtUndoReason.Enabled = False

        txtUndoReason.Visible = False

    End Sub

    'Preloads the CustomersInfo Datatable From the Access Database into the Form 7 when the Form 7 is loaded.
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'EzPassDBSystem.CustomersInfo' table. You can move, or remove it, as needed.
        Me.CustomersInfoTableAdapter.Fill(Me.EzPassDBSystem.CustomersInfo)

        UpdateButtonReset()

        UndoInvisible()

    End Sub

    ''
    Private Sub txtAcctSearch_GotFocus(sender As Object, e As EventArgs) Handles txtAcctSearch.GotFocus

        LoginFocus = True

        If LoginFocus = True Then

            txtAcctSearch.BackColor = Color.LemonChiffon

        Else

            txtAcctSearch.BackColor = Color.White

        End If

    End Sub

    Sub FocusReset()

        LoginFocus = False

        txtAcctSearch.BackColor = Color.White

        txtAcctSearch.Clear()

    End Sub

    ''
    Private Sub Form7_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If QuitInitiated = True Then

            e.Cancel = False

        Else

            e.Cancel = True

        End If

    End Sub


    'Subroutine made to randomly generate a number that is to be assigned as the New Tag for the Customer's Account.
    ' The randomly generated numbers are in a range between 1-300. 300 being the Max value that the random number can reach.
    Sub NewTagAssignment()

        Dim RndNewTag As New Random()

        Dim RndFinalValue As Integer = 300

        txtTagAssign.Text = RndNewTag.Next(0, RndFinalValue)

        UpdateButtonValidated()

    End Sub

    'Subroutine that checks to see if the Tag Status of an Account is not lost and if the Tag # is N/A.
    ' This subroutine is for checking if the user has an 'Lost' status on their Tag Status.
    Sub TagNullChecker()

        Dim LostTagStatus As String

        LostTagStatus = "Lost"

        Dim NullTagStatusMsg As Integer

        If txtNewTagStatus.Text = LostTagStatus Then

            NullTagStatusMsg = MessageBox.Show("This Account has lost their previous tag. Please go buy a new one.", "Buy Tag", MessageBoxButtons.OK, MessageBoxIcon.Stop)

            If NullTagStatusMsg = DialogResult.OK Then

                AcctFieldisFull = False

                QuitInitiated = True

                Form5.grpTagStatusLogin.Enabled = True

                Me.Close()

            End If

        End If

    End Sub

    'Subroutine that checks to see if the Account already has a tag assigned to it. This is so that the
    ' Account wont be assigned a new tag or the User buys a new tag if they already have a tag tied to 
    ' their account.
    Sub TagAssignedChecker()

        Dim AssignedTagStatus As String

        AssignedTagStatus = "Assigned"

        Dim NullTagNbrMsg As Integer

        If txtNewTagStatus.Text = AssignedTagStatus Then

            NullTagNbrMsg = MessageBox.Show("This Account already has a Tag. Exiting window now.", "Tag Assigned", MessageBoxButtons.OK, MessageBoxIcon.Stop)

            If NullTagNbrMsg = DialogResult.OK Then

                QuitInitiated = True

                AcctFieldisFull = False

                Form5.grpTagStatusLogin.Enabled = True

                Me.Close()

            End If

        End If

    End Sub

    'Subroutine to display to the User that the new tag has been successfully added to their account.
    Sub TagAssignMsg()

        Dim TagMsg As Integer

        TagMsg = MessageBox.Show("You have successfully added that Tag to the account. Enjoy!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        If TagMsg = DialogResult.OK Then

            QuitInitiated = True

            Form5.QuitInitiated = True

            Form3.Show()

            Form5.Close()
            Me.Close()

        End If

    End Sub

    'Button Click event, that if clicked, Assigns the new Tag number to the Customer Account by the NewTagAssignment
    ' subroutine and Assigns the new Tag Status of 'Assigned' to the Tag Status Field Text Box.
    Private Sub BtnAssign_Click(sender As Object, e As EventArgs) Handles btnAssign.Click

        Dim NewTagStatus As String

        NewTagStatus = "Assigned"

        txtNewTagStatus.Text = NewTagStatus

        AssignButtonPress = True

        NewTagAssignment()

        ''
        UndoFunctionality()

    End Sub

    'Subroutine made to check for an Empty Account Field. If it is Full, the AcctFieldisFull Boolean will flip to true,
    ' Which is used for accessing the next page of the Form. If the Account Text field box is empty, the user will
    ' be displayed a dialog box stating that the Account Field is empty and the AcctFieldisFull Boolean will stay false.
    Sub CheckForEmptyAccountField()

        Dim EmptyAccountFieldMsg As Integer

        ''If the Account Search textbox is empty, AcctFieldisFull Boolean is false and prevents the user to retrieve any records.
        If txtAcctSearch.Text = String.Empty Then

            AcctFieldisFull = False
            EmptyAccountFieldMsg = MessageBox.Show("You have not entered any Account # . Please try again.", "No Account", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            FocusReset()

            '' If the Account Search textbox is filled with an Account #, AcctFieldisFull Boolean becomes true and user goes to next page.
        Else

            AcctFieldisFull = True

        End If

    End Sub

    'Button Click Event, that if clicked, returns the user back to the previous Form and closes this Form 7.
    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click

        QuitInitiated = True

        Form5.grpTagStatusLogin.Enabled = True

        Me.Close()

    End Sub

    'Button Click Event, that if clicked, returns the user back to the previous Form and closes this Form 7.
    ' This button is located on the next page of the Form 7, where the User/Employee assigns a New Tag Status and Tag.
    Private Sub BtnBackPrevious_Click(sender As Object, e As EventArgs) Handles btnBackPrevious.Click

        QuitInitiated = True

        Form5.grpTagStatusLogin.Enabled = True

        Me.Close()

    End Sub

    'Subroutine that displays a dialog box to the Customer/Employee that the account they are trying to reach,
    'does not exist. And that they should try again with a valid Account Number.
    Sub AccountNotExist()

        Dim AccountMsg As Integer

        AccountMsg = MessageBox.Show("That account does not exist. Please Try again.", "Account Doesn't Exist", MessageBoxButtons.OK, MessageBoxIcon.Error)

        If AccountMsg = DialogResult.OK Then

            AcctFieldisFull = False
            FocusReset()

        End If

    End Sub

    ''
    Sub FormDates()

        Dim CurrentDate As String = Date.Today.ToString("MM/dd/yyyy")

        txtTagDateAssign.Clear()

        txtTagDateAssign.Text = CurrentDate

    End Sub

    ''
    Sub AccountNumericDetect()

        Dim DetectMsg As Integer

        DetectMsg = MessageBox.Show("This field requires only numbers. Please try again!", "Numbers Only", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

        If DetectMsg = DialogResult.OK Then

            FocusReset()

        End If

    End Sub

    ''
    Private Sub txtAcctSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAcctSearch.KeyPress

        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = ChrW(Keys.Back) Then

            e.Handled = True
            AccountNumericDetect()

        End If

    End Sub

    ''
    Sub UndoFunctionality()

        Dim UndoMsg As String

        UndoMsg = "N/A"

        ''
        txtUndoDate.Text = UndoMsg

        txtUndoReason.Text = UndoMsg
        '

    End Sub

    'Button Click Event, that if pressed, AND if the Account Number that was typed into the textbox was valid along
    ' with the fact that the field text box is now full, will connect that Account & display information about that Account to this Form by a SQL Query Search.
    ' Since the account is now connected, when pressing the Update Button, it will update to only that Account that was searched for.
    Private Sub BtnEnterForm_Click(sender As Object, e As EventArgs) Handles btnEnterForm.Click

        'Subroutine that is checking for empty Account Field.
        CheckForEmptyAccountField()

        'The Account field contents are assigned to a Variable that is used for the SQL Query Search.
        Dim SearchAccountRecord As String

        If AcctFieldisFull = True Then

            'The Account field contents are assigned to a Variable that is used for the SQL Query Search.
            SearchAccountRecord = txtAcctSearch.Text

            'SQL Query Search for Specific Customer Accounts.
            Me.CustomersInfoTableAdapter.FillByAccountNumber(Me.EzPassDBSystem.CustomersInfo, SearchAccountRecord)

            'Subroutine that checks to see if the Tag Status is not lost or if the Tag # is N/A.
            TagNullChecker()

            'Subroutine that checks to see if the Account already has a tag assigned to it. This is so that the
            ' Account wont be assigned a new tag or the User buys a new tag if they already have a tag tied to 
            ' their account.
            TagAssignedChecker()

            'Moves the user to the next page after validating if the proper account is entering this form to buy
            ' a new tag for their account. Proper Account meaning that a lost tag cannot go to assigning a new tag
            ' at the no cost fee thats meant for the Accounts that have only returned tags.
            grpNewTagLogin.Visible = False
            grpNewTagLogin.Enabled = False

            'If the Account does not exist when the program tries to run the SQL Query Search, this 'If' statement happens.
            If Me.CustomersInfoTableAdapter.FillByAccountNumber(Me.EzPassDBSystem.CustomersInfo, SearchAccountRecord) = Nothing Then

                'The user stays on the login page without accessing the next part of the form due to the fact that
                ' they havent found a valid Account.
                grpNewTagLogin.Enabled = True
                grpNewTagLogin.Visible = True

                AccountNotExist() 'subroutine dialog box that displays to the user that this account doesn't exist.

            End If

        End If

        'Subroutine that assigns the Current Date to the Tag Date Assign text field on the Form 6.
        FormDates()

    End Sub

    'Button Click Event, that if clicked AND if the Assign Button has been pressed and its Boolean = true,
    'the Form 7 will save and update the new information to the Access Database and it will be reflected on the
    ' Datagrids inside the VB Program.
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If AssignButtonPress = True Then

            Me.Validate()
            Me.CustomersInfoBindingSource.EndEdit()
            Me.CustomersInfoTableAdapter.Update(Me.EzPassDBSystem)

            TagAssignMsg()

        End If

    End Sub


    ''End of Comments for Form 7 of EzPass Database System Project.''

End Class