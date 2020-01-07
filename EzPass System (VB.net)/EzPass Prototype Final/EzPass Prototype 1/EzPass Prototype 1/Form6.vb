Imports System.ComponentModel

Public Class Form6

    ''Beginning of Comments for Form 6 of EzPass Database System Project.''
    ''Aleksey Przhevalskiy''

    'Class-Level Variables for all Sub-routines to use them.
    Dim AcctFieldIsFull As Boolean = True

    Dim AssignButtonPress As Boolean = False

    Dim DeductButtonPress As Boolean = False
    '

    Dim QuitInitiated As Boolean = False

    Dim LoginFocus As Boolean = False

    'Subroutine.
    Sub ProcessButtonReset()

        btnProcess.Enabled = False
        btnProcess.BackColor = Color.AntiqueWhite

    End Sub

    Sub ProcessButtonValidated()

        btnProcess.Enabled = True
        btnProcess.BackColor = Color.LightGreen

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

    'Preloads the CustomerInfos Datatable information into Form 6 & Datagrid when the Form is loaded and executed.
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'EzPassDBSystem.CustomersInfo' table. You can move, or remove it, as needed.
        Me.CustomersInfoTableAdapter.Fill(Me.EzPassDBSystem.CustomersInfo)

        ProcessButtonReset()

        txtNewTagStatus.Text = txtNewTagStatus.Text

        UndoInvisible()

    End Sub



    ''
    Private Sub Form6_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        If QuitInitiated = True Then

            e.Cancel = False

        Else

            e.Cancel = True

        End If

    End Sub

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

    'Subroutine made to check if the Account Field text box is empty or not. If it is Empty, AcctFieldIsFull Boolean
    ' will return false and a dialog box will display to the user stating that the Account field is empty. If the
    ' field is full, then it will return the AcctFieldisFull boolean to true which will be used for later.
    Sub EmptyAcctField()

        Dim EmptyAcctFieldMsg As Integer

        If txtAcctSearch.Text = String.Empty Then

            AcctFieldIsFull = False
            EmptyAcctFieldMsg = MessageBox.Show("The Account field is empty. Please try again.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Information)
            FocusReset()

        Else

            AcctFieldIsFull = True

        End If

    End Sub

    ''Subroutine that checks to see if the Tag Status of an Account is not assigned and if the Tag # is N/A.
    ' This subroutine is for checking if the user has an 'Unassigned' status on their Tag Status.
    Sub TagNullChecker()

        Dim UnassignedTagStatus As String

        UnassignedTagStatus = "Unassigned"

        Dim NullTagStatusMsg As Integer

        If txtNewTagStatus.Text = UnassignedTagStatus Then

            NullTagStatusMsg = MessageBox.Show("This Account has NOT lost their last tag. Please go assign a new one.", "Assign Tag", MessageBoxButtons.OK, MessageBoxIcon.Stop)

            If NullTagStatusMsg = DialogResult.OK And Form4.FromEmployeeAssign = False Then

                QuitInitiated = True

                AcctFieldIsFull = False

                Form5.grpTagStatusLogin.Enabled = True

                Me.Close()

            Else

                QuitInitiated = True

                Form4.grpReportedTags.Enabled = True

                Me.Close()

            End If

        End If

    End Sub

    'Subroutine that checks to see if the Account already has a tag assigned to it. This is so that the
    ' Account wont be assigned a new tag or the User buys a new tag if they already have a tag tied to 
    ' their account.
    Sub TagAssignedChecker()

        txtNewTagStatus.Text = txtNewTagStatus.Text

        Dim AssignedTagStatus As String

        AssignedTagStatus = "Assigned"

        Dim NullTagNbrMsg As Integer

        If txtNewTagStatus.Text = AssignedTagStatus Then

            NullTagNbrMsg = MessageBox.Show("This Account already has a Tag. Exiting window now.", "Tag Assigned", MessageBoxButtons.OK, MessageBoxIcon.Stop)

            If NullTagNbrMsg = DialogResult.OK And Form4.FromEmployeeAssign = False Then


                QuitInitiated = True

                AcctFieldIsFull = False

                Form5.grpTagStatusLogin.Enabled = True

                Me.Close()

            Else

                QuitInitiated = True

                Form4.grpReportedTags.Enabled = True

                Me.Close()


            End If

        End If

    End Sub

    'Subroutine made to display a dialog box to the user that the Account they are trying to reach does not exist.
    'And that they should try again with a different account number to check if it is a valid Account.
    Sub AccountNotExist()

        Dim AccountNotExistMsg As Integer

        AccountNotExistMsg = MessageBox.Show("That Account does not exist. Please try again.", "Account Doesn't Exist", MessageBoxButtons.OK, MessageBoxIcon.Error)

        If AccountNotExistMsg = DialogResult.OK Then

            AcctFieldIsFull = False
            FocusReset()

        End If

    End Sub

    ''
    Sub FormDates()

        Dim CurrentDate As String = Date.Today.ToString("MM/dd/yyyy")

        txtTagDateAssign.Clear()

        txtTagDateAssign.Text = CurrentDate

    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click

        If Form4.FromEmployeeAssign = True Then

            QuitInitiated = True
            Form4.grpReportedTags.Enabled = True

            Me.Close()

        Else

            QuitInitiated = True
            Form5.grpTagStatusLogin.Enabled = True

            Me.Close()

        End If

    End Sub

    '
    Sub UndoFunctionality()

        Dim UndoMsg As String

        UndoMsg = "N/A"

        ''


        ''
        txtUndoDate.Text = UndoMsg

        txtUndoReason.Text = UndoMsg
        '

    End Sub

    'Button Click Event, if this button is clicked and the Account Field is Full (Boolean = true), it will take the User,
    ' to the next part of the form where it will SQL Query Search the specific account the user is trying to access
    ' based on the Account Number they had entered in the Login part of the Form.
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        EmptyAcctField() 'Subroutine that is checking for empty Account Field.



        'The Account field contents are assigned to a Variable that is used for the SQL Query Search.
        Dim SearchTagAccount As String

        If AcctFieldIsFull = True Then

            'The Account field contents are assigned to a Variable that is used for the SQL Query Search.
            SearchTagAccount = txtAcctSearch.Text

            'SQL Query Search for Specific Customer Accounts.
            Me.CustomersInfoTableAdapter.FillByAccountNumber(Me.EzPassDBSystem.CustomersInfo, SearchTagAccount)

            'Subroutine that checks to see if the Tag Status is not lost or if the Tag # is N/A.
            TagNullChecker()

            'Subroutine that checks to see if the Account already has a tag assigned to it. This is so that the
            ' Account wont be assigned a new tag or the User buys a new tag if they already have a tag tied to 
            ' their account.
            TagAssignedChecker()

            'Moves the user to the next page after validating if the proper account is entering this form to buy
            ' a new tag for their account. Proper Account meaning that a lost tag cannot go to assigning a new tag
            ' at the no cost fee thats meant for the Accounts that have only returned tags.
            grpLostAssignMoney.Enabled = False
            grpLostAssignMoney.Visible = False


            'If the Account does not exist when the program tries to run the SQL Query Search, this 'If' statement happens.
            If Me.CustomersInfoTableAdapter.FillByAccountNumber(Me.EzPassDBSystem.CustomersInfo, SearchTagAccount) = Nothing Then

                'The user stays on the login page without accessing the next part of the form due to the fact that
                ' they havent found a valid Account.
                grpLostAssignMoney.Enabled = True
                grpLostAssignMoney.Visible = True

                AccountNotExist() 'subroutine dialog box that displays to the user that this account doesn't exist.

            End If

        End If

        'Subroutine that assigns the Current Date to the Tag Date Assign text field on the Form 6.
        FormDates()

    End Sub

    Sub AccountNumericDetect()

        Dim DetectMsg As Integer

        DetectMsg = MessageBox.Show("This field requires only numbers. Please try again!", "Numbers Only", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

        If DetectMsg = DialogResult.OK Then

            FocusReset()

        End If

    End Sub

    Private Sub txtAcctSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAcctSearch.KeyPress

        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = ChrW(Keys.Back) Then

            e.Handled = True
            AccountNumericDetect()

        End If

    End Sub

    'Button Click Event, that if clicked, sends the user back to the previous Form before they had opened up this form
    ' to assign a Lost Tag.
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click


        QuitInitiated = True

        Form5.grpTagStatusLogin.Enabled = True

        Me.Close()

    End Sub

    'Subroutine made to randomly generate a number that is to be assigned as the New Tag for the Customer's Account.
    ' The randomly generated numbers are in a range between 1-300. 300 being the Max value that the random number can reach.
    Sub NewTagAssignment()

        Dim RandomTagGeneration As New Random()

        Dim RndFinalValue As Integer = 300

        txtAssignNewTag.Text = RandomTagGeneration.Next(0, RndFinalValue)

    End Sub

    'Subroutine made to display to the user that the Account they are trying to deduct a fee from, no longer has any funds
    ' to buy a new Tag after they had lost the previous one. The dialog box will explain to them that the tag can't be applied.
    Sub AcctFundsGone()

        Dim AcctFundsMsg As Integer

        AcctFundsMsg = MessageBox.Show("There is no more funds left on this account. Tag cannot be applied.", "No funds", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

    End Sub

    'Subroutine made to deduct the fee of $ 25 Dollars to replace the Tag that the customer had lost. This subroutine
    ' was made specifically to deduct 25 from any other form of number. This subroutine will only deduct payments if 
    'the account they are accessed o has funds To pay For the New Tag. Otherwise, it wont be able To deduct money.
    Sub DeductPayment()

        'Variable that stores the Deduction Fee.
        Dim LostTagPay As Double = 25

        'Variable that represents the Customers current balance.
        Dim CurrentAcctAmount As Double

        'TryParsing the Customer's Account Balance into an Integer from the SQL Query Search that was placed
        ' into this textbox 'txtDeduct.Text'
        Double.TryParse(txtDeduct.Text, CurrentAcctAmount)

        Dim BelowZeroDraft As Integer

        BelowZeroDraft = 0

        'If the Current Account Balance is greater than 0. (BelowZeroDraft = 0),
        ' The deduction of $ 25 for a New Tag can be applied to the account.
        If CurrentAcctAmount >= BelowZeroDraft Then

            txtDeduct.Text = CurrentAcctAmount - LostTagPay

        End If

        'If the Current Account Balance will reach less than 0, a dialog box will display itself to the user saying 
        ' that they are no more funds to the account and cannot be applied a deduction fee and buy a New Tag.

        ' The Account Balance textbox will not be able to go under 0 into a negative number because once the balance is 0,
        ' it will stay at 0 in the textbox no matter how many times the User presses the Deduct Button.
        If BelowZeroDraft >= CurrentAcctAmount Then

            AcctFundsGone()

            CurrentAcctAmount = BelowZeroDraft

            txtDeduct.Text = CurrentAcctAmount

        End If

    End Sub

    'Button Click event, that if clicked, returns the NewTagAssignment Subroutine and assigns a New Tag to the
    ' Tag textbox and flips the AssignButtonPress Boolean to true.
    Private Sub btnAssignNewTag_Click(sender As Object, e As EventArgs) Handles btnAssignNewTag.Click

        AssignButtonPress = True

        NewTagAssignment()

        If AssignButtonPress = True And DeductButtonPress = True Then

            ProcessButtonValidated()

            UndoFunctionality()

        End If

    End Sub

    'Button Click event, that if clicked, returns the DeductPayment Subroutine and deducts a $ 25 Deduction Fee to the
    ' Account Balance textbox and flips the DeductButtonPress Boolean to true.
    Private Sub BtnDeduct_Click(sender As Object, e As EventArgs) Handles btnDeduct.Click

        DeductButtonPress = True

        DeductPayment()

        If AssignButtonPress = True And DeductButtonPress = True Then

            ProcessButtonValidated()

        End If

    End Sub

    'Subroutine that displays a dialog box to the User stating that the Account has been charged the deduction fee and
    ' that they have been assigned a brand new Tag. If the User clicks OK, the form closes and the tag will be shown
    ' in the customers information inside the Access Database.
    Sub AccountChangeSuccessful()

        Dim AccountChangeMsg As Integer

        AccountChangeMsg = MessageBox.Show("The account has been successfully charged. Thank you!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        If AccountChangeMsg = DialogResult.OK Then

            QuitInitiated = True

            Form5.QuitInitiated = True

            Form3.Show()

            Form5.Close()
            Me.Close()

        End If

    End Sub

    'Subroutine that was made to display a dialog boxto the user that there was an error trying to save their account 
    'And that the transaction cannot go through and assign the Customer a new Tag.
    Sub AccountNotProperlyChanged()

        Dim AccountNotChangedMsg As Integer

        AccountNotChangedMsg = MessageBox.Show("There was an error when trying to save the account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

    End Sub

    'Subroutine made to display a dialog box that not all the buttons were pressed so the Program can conduct the 
    ' transaction. If this dialog box is displayed, BOTH buttons (Assign & Deduct) will reset their Pressed Booleans.
    Sub NotAllButtonsPressed()

        Dim ButtonsMsg As Integer

        ButtonsMsg = MessageBox.Show("Not all buttons were pressed. Please try again.", "Press Buttons", MessageBoxButtons.OK, MessageBoxIcon.Error)

        If ButtonsMsg = DialogResult.OK Then

            AssignButtonPress = False
            DeductButtonPress = False

        End If

    End Sub

    'Button Click event that processes the Transaction to deduct the Tag fee and assign the Customer a new Tag.
    ' Along with assigning the Tag Status to that Customer's Account back to 'Assigned' rather than 'Lost'. 
    ' It will then be saved and updated to the Access Database and reflected inside the VB Datagrids for Employee & Customer.
    Private Sub BtnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click

        'If the Buttons have both been pressed to Assign a tag and deduct the fee, the Employee/Customer will be able to
        ' process the transaction now.
        If AssignButtonPress = True And DeductButtonPress = True Then

            'The New Tag Status of the Customer's Account after the transaction has been processed.
            Dim NewTagStatus As String = "Assigned"

            txtNewTagStatus.Text = NewTagStatus

            'Saving and Updating to the CustomersInfo Database.
            Me.Validate()
            Me.CustomersInfoBindingSource.EndEdit()
            Me.CustomersInfoTableAdapter.Update(Me.EzPassDBSystem)

            Try

                AccountChangeSuccessful() 'If the Transaction is able to go through and update the Account, this dialog box will be displayed.

            Catch ex As Exception

                AccountNotProperlyChanged() 'If the Account is not able to update to the Database, this dialog box will be displayed.

            End Try

        End If

        'If either the Assign Button OR Deduct Button have not been pressed, User will be displayed a dialog box stating
        ' that they have not pressed both buttons to conduct the final transaction.
        If AssignButtonPress = False Or DeductButtonPress = False Then

            NotAllButtonsPressed()

        End If

    End Sub

    ''End of Comments for Form 6 of EzPass Database System Project.''

End Class