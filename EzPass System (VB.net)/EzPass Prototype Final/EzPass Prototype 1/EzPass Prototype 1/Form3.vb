Imports System.ComponentModel

Public Class Form3

    ''Beginning of Comments for Form 3 of EzPass Database System Project.''
    ''Aleksey Przhevalskiy''


    'Class level variables that all private sub and sub-routines can use.
    Dim AcctFieldisFull As Boolean = True

    Dim CurrentAccountBalance As Double = 0 ' Integer that will add to the Account balance text field box.

    Dim MaximumBalanceAllowed As Double = 500 ' Maximum Dollar amount allowed on each account.

    'Having a zero balance Amount inside the Amount Balance of the Registration form.
    Dim NoBalanceAccount As Double = 0


    'Class-Level Variables for the Currency Dollar Amount to be added or subtracted from Customer Balance.
    Dim Add25 As Double = 25

    Dim Add50 As Double = 50

    Dim Add100 As Double = 100

    Dim Add200 As Double = 200

    'Variable that changes the Currency variables (when MULTIPLIED) from positive to negative and vice versa.
    Dim CurrencyRateChanger As Double = -1
    ''

    Dim NoBalanceLeft As Boolean = False

    'Textbox Focus Color Booleans. Explain here more.
    Dim FirstNameFocus As Boolean = False
    Dim LastNameFocus As Boolean = False
    Dim AddressFocus As Boolean = False
    Dim EmailFocus As Boolean = False
    Dim PlateFocus As Boolean = False
    Dim CardFocus As Boolean = False
    Dim PhoneFocus As Boolean = False
    Dim LoginFocus As Boolean = False

    ''
    Dim QuitInitiated As Boolean = False

    'Preloads the Customer Information from the Access Database into Form 3 when Form 3 is loaded and shown into the program.
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EzPassDBSystem.CustomersInfo' table. You can move, or remove it, as needed.
        Me.CustomersInfoTableAdapter.Fill(Me.EzPassDBSystem.CustomersInfo)
        'TODO: This line of code loads data into the 'EzPassDBSystem.CustomersInfo' table. You can move, or remove it, as needed.
        Me.CustomersInfoTableAdapter.Fill(Me.EzPassDBSystem.CustomersInfo)

        'Setting the font of the DataGrid for Updates and Font Style of the DataGrid.
        Me.DatUpdateOverview.Font = New Font("Rockwell", 9)

        'The positive amount radio button is automatically checked first by default upon the form load.
        RadPositiveAmt.Checked = True

    End Sub

    Private Sub Form3_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        If QuitInitiated = True Then

            e.Cancel = False

        Else

            e.Cancel = True

        End If

    End Sub


    'Button Click Event that takes the user back to the Form 1 Portal Login Page and closes the Form3 Update Account Page.
    Private Sub BtnUpdateBackLogin_Click(sender As Object, e As EventArgs) Handles btnUpdateBackLogin.Click

        QuitInitiated = True

        Form1.Show()
        Me.Close()

    End Sub

    'Resetting all textbox focus color booleans.
    Sub NoHighlightedFocus()

        FirstNameFocus = False
        LastNameFocus = False
        AddressFocus = False
        EmailFocus = False
        CardFocus = False
        PhoneFocus = False
        PlateFocus = False
        LoginFocus = False

        txtAcctSearch.Clear()

        txtUpdateFirstNm.BackColor = Color.White
        txtUpdateLastNm.BackColor = Color.White
        txtUpdateAddress.BackColor = Color.White
        txtUpdateEmail.BackColor = Color.White
        txtUpdateCard.BackColor = Color.White
        txtUpdatePhone.BackColor = Color.White
        txtUpdatePlate.BackColor = Color.White
        txtAcctSearch.BackColor = Color.White

    End Sub

    'Button Click Event that takes the user back to the Account Search part of Form3 so the User can enter other Accounts
    ' to display their information and to update their information.
    Private Sub btnUpdateBack_Click(sender As Object, e As EventArgs) Handles btnUpdateBack.Click

        grpUpdateAcct.Enabled = True
        grpUpdateAcct.Visible = True

        txtAcctSearch.Clear()
        NoHighlightedFocus()

    End Sub

    'Subroutine that was made for when the user enters the Account Update information part of the Form, it will be displayed
    ' the real date and real time of when the user accessed their updateable information.
    Sub CurrentDateChanger()

        Dim CurrentDate As Date = Date.Now()

        Dim ReportTagDate As String = CurrentDate

        Dim AccountAccessedDate As String = "Your Account was Accessed On:  " & CurrentDate.ToString()

        lblAccessedDate.Text = AccountAccessedDate

        ''txtReportDate.Text = ReportTagDate

    End Sub

    'Subroutine that was made to check if the Account Search textfield is empty or not. If it is empty,
    ' The user will be prompted with a dialog box stating that it is empty and the AcctFieldisFull Boolean will stay false.
    ' The AcctFieldisFull Boolean is true if the Text field box is fulled with an Account Number.
    Sub CheckForEmptyAccountField()

        Dim EmptyAccountFieldMsg As Integer

        ''If the Account Search textbox is empty, AcctFieldisFull Boolean is false and prevents the user to retrieve any records.
        If txtAcctSearch.Text = String.Empty Then

            AcctFieldisFull = False
            EmptyAccountFieldMsg = MessageBox.Show("You have not entered any Account # . Please try again.", "No Account", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            NoHighlightedFocus()

            '' If the Account Search textbox is filled with an Account #, AcctFieldisFull Boolean becomes true and user goes to next page.
        Else

            AcctFieldisFull = True

        End If

    End Sub

    Sub LoginFocusReset()

        LoginFocus = False
        txtAcctSearch.BackColor = Color.White
        txtAcctSearch.Clear()

    End Sub

    'Subroutine that was made to display a dialog box to the user if the account they are trying to reach, does not exist.
    'This subroutine is to be used inside the Search Button Click Event.
    Sub AccountNotExist()

        Dim AccountMsg As Integer

        AccountMsg = MessageBox.Show("That account does not exist! Please Try again.", "Account Doesn't Exist", MessageBoxButtons.OK, MessageBoxIcon.Error)

        If AccountMsg = DialogResult.OK Then

            LoginFocusReset()

        End If

    End Sub

    Sub AccountNumericDetect()

        Dim DetectMsg As Integer

        DetectMsg = MessageBox.Show("This field requires only numbers. Please try again!", "Numbers Only", MessageBoxButtons.OK, MessageBoxIcon.Information)

        If DetectMsg = DialogResult.OK Then

            txtAcctSearch.Clear()

        End If

    End Sub

    Private Sub txtAcctSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAcctSearch.KeyPress

        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = ChrW(Keys.Back) Then

            e.Handled = True
            AccountNumericDetect()

        End If

    End Sub

    ''
    Sub AcctStatusCheck()

        Dim BalanceChecker As Double

        Dim LowBalanceThreshold As Double = 25

        Dim LowBalanceMsg As Integer

        Dim GoodBalanceStatus As String = "Good Standing"

        Dim LowBalanceStatus As String = "Bad Standing"

        Double.TryParse(txtUpdateAcctBal.Text, BalanceChecker)

        If LowBalanceThreshold >= BalanceChecker Then

            lblAcctStatus.ForeColor = Color.Red
            lblAcctStatus.Text = LowBalanceStatus
            LowBalanceMsg = MessageBox.Show("Account Funds are too low. Account Status has changed. Please add more Funds.", "More Funds", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If

        If BalanceChecker > LowBalanceThreshold Then

            lblAcctStatus.ForeColor = Color.Green
            lblAcctStatus.Text = GoodBalanceStatus

        End If

    End Sub

    ' Button Click event that first checks to see if the text field box is either empty, or if the Account exists. 
    ' If the Account exists AND the text field box is not empty, there is a SQL query in place to search for that 
    ' Account and it is then displayed into the text boxes on the next page for the user to Update that information.
    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        CheckForEmptyAccountField() ' Subroutine that checks for empty text box fields.

        'The Account field contents are assigned to a Variable that is used for the SQL Query Search.
        Dim SearchAccountRecord As String

        If AcctFieldisFull = True Then

            SearchAccountRecord = txtAcctSearch.Text

            ' SQL Query Search for that Account that was entered into the txtAcctSearch text field box.
            Me.CustomersInfoTableAdapter.FillByAccountNumber(Me.EzPassDBSystem.CustomersInfo, SearchAccountRecord)

            CurrentDateChanger()

            '' If the Account doesnt exist, the user does not get to go onto the next page of the form. 
            '' They will get prompted with an Error Message saying that they have entered a wrong Account #.
            If Me.CustomersInfoTableAdapter.FillByAccountNumber(Me.EzPassDBSystem.CustomersInfo, SearchAccountRecord) = Nothing Then

                grpUpdateAcct.Enabled = True
                grpUpdateAcct.Visible = True

                AccountNotExist()

            Else

                grpUpdateAcct.Enabled = False
                grpUpdateAcct.Visible = False
                AcctStatusCheck()

                FirstNameFocus = True
                TextBoxFocusColor()

            End If

        End If

    End Sub

    Sub TextBoxFocusColor()

        If FirstNameFocus = True Then

            txtUpdateFirstNm.BackColor = Color.LemonChiffon

        Else

            FirstNameFocus = False
            txtUpdateFirstNm.BackColor = Color.White

        End If


        If LastNameFocus = True Then

            txtUpdateLastNm.BackColor = Color.LemonChiffon

        Else

            LastNameFocus = False
            txtUpdateLastNm.BackColor = Color.White

        End If


        If AddressFocus = True Then

            txtUpdateAddress.BackColor = Color.LemonChiffon

        Else

            AddressFocus = False
            txtUpdateAddress.BackColor = Color.White

        End If


        If EmailFocus = True Then

            txtUpdateEmail.BackColor = Color.LemonChiffon

        Else

            EmailFocus = False
            txtUpdateEmail.BackColor = Color.White

        End If

        If PlateFocus = True Then

            txtUpdatePlate.BackColor = Color.LemonChiffon

        Else

            PlateFocus = False
            txtUpdatePlate.BackColor = Color.White

        End If


        If CardFocus = True Then

            txtUpdateCard.BackColor = Color.LemonChiffon

        Else

            CardFocus = False
            txtUpdateCard.BackColor = Color.White

        End If

        If PhoneFocus = True Then

            txtUpdatePhone.BackColor = Color.LemonChiffon

        Else

            PhoneFocus = False
            txtUpdatePhone.BackColor = Color.White

        End If

        If LoginFocus = True Then

            txtAcctSearch.BackColor = Color.LemonChiffon

        Else

            LoginFocus = False
            txtAcctSearch.BackColor = Color.White


        End If

    End Sub

    Private Sub txtUpdateFirstNm_GotFocus(sender As Object, e As EventArgs) Handles txtUpdateFirstNm.GotFocus

        FirstNameFocus = True
        LastNameFocus = False
        AddressFocus = False
        EmailFocus = False
        CardFocus = False
        PhoneFocus = False
        PlateFocus = False
        LoginFocus = False

        TextBoxFocusColor()

    End Sub

    Private Sub txtUpdateLastNm_GotFocus(sender As Object, e As EventArgs) Handles txtUpdateLastNm.GotFocus

        FirstNameFocus = False
        LastNameFocus = True
        AddressFocus = False
        EmailFocus = False
        CardFocus = False
        PhoneFocus = False
        PlateFocus = False
        LoginFocus = False

        TextBoxFocusColor()

    End Sub

    Private Sub txtUpdateAddress_GotFocus(sender As Object, e As EventArgs) Handles txtUpdateAddress.GotFocus

        FirstNameFocus = False
        LastNameFocus = False
        EmailFocus = False
        CardFocus = False
        PhoneFocus = False
        AddressFocus = True
        PlateFocus = False
        LoginFocus = False

        TextBoxFocusColor()

    End Sub

    Private Sub txtUpdateEmail_GotFocus(sender As Object, e As EventArgs) Handles txtUpdateEmail.GotFocus

        FirstNameFocus = False
        LastNameFocus = False
        EmailFocus = True
        CardFocus = False
        PhoneFocus = False
        AddressFocus = False
        PlateFocus = False
        LoginFocus = False

        TextBoxFocusColor()

    End Sub

    Private Sub txtUpdatePlate_GotFocus(sender As Object, e As EventArgs) Handles txtUpdatePlate.GotFocus

        FirstNameFocus = False
        LastNameFocus = False
        EmailFocus = False
        CardFocus = False
        PhoneFocus = False
        AddressFocus = False
        PlateFocus = True
        LoginFocus = False

        TextBoxFocusColor()

    End Sub

    Private Sub txtUpdateCard_GotFocus(sender As Object, e As EventArgs) Handles txtUpdateCard.GotFocus

        FirstNameFocus = False
        LastNameFocus = False
        EmailFocus = False
        CardFocus = True
        PhoneFocus = False
        AddressFocus = False
        PlateFocus = False
        LoginFocus = False

        TextBoxFocusColor()

    End Sub

    Private Sub txtUpdatePhone_GotFocus(sender As Object, e As EventArgs) Handles txtUpdatePhone.GotFocus

        FirstNameFocus = False
        LastNameFocus = False
        EmailFocus = False
        CardFocus = False
        PhoneFocus = True
        AddressFocus = False
        PlateFocus = False
        LoginFocus = False

        TextBoxFocusColor()

    End Sub

    Private Sub txtAcctSearch_GotFocus(sender As Object, e As EventArgs) Handles txtAcctSearch.GotFocus

        FirstNameFocus = False
        LastNameFocus = False
        EmailFocus = False
        CardFocus = False
        PhoneFocus = False
        AddressFocus = False
        PlateFocus = False
        LoginFocus = True

        TextBoxFocusColor()

    End Sub

    Private Sub txtUpdateAcctBal_GotFocus(sender As Object, e As EventArgs) Handles txtUpdateAcctBal.GotFocus

        NoHighlightedFocus()
        TextBoxFocusColor()

    End Sub

    Private Sub cmbUpModel_GotFocus(sender As Object, e As EventArgs) Handles cmbUpModel.GotFocus

        NoHighlightedFocus()
        TextBoxFocusColor()

    End Sub

    Private Sub cmbUpBodyStyle_GotFocus(sender As Object, e As EventArgs) Handles cmbUpBodyStyle.GotFocus

        NoHighlightedFocus()
        TextBoxFocusColor()

    End Sub

    Private Sub cmbUpYear_GotFocus(sender As Object, e As EventArgs) Handles cmbUpYear.GotFocus

        NoHighlightedFocus()
        TextBoxFocusColor()

    End Sub



    'Subroutine that was made to display a Dialog Box stating to the user that their account was successfully changed.
    ' And there were no errors with the connection of the Access Database and VB Program.
    Sub AccountChangeSuccessful()

        Dim AccountChangeMsg As Integer

        AccountChangeMsg = MessageBox.Show("You have successfully changed your account.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

    End Sub

    'Subroutine that was made to display a Dialog Box stating to the user that their account was not successfully changed.
    ' And there were some type of error with the connection of the Access Database and VB Program.
    Sub AccountNotProperlyChanged()

        Dim AccountNotChangedMsg As Integer

        AccountNotChangedMsg = MessageBox.Show("There was an error when trying to save your account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

    End Sub


    'Button click event that handles the updating of the Database if any changes were made by the user to their 
    ' respective customer information. A Try/Catch was used here because if the updating of the database was successful,
    ' the program would execute the Try. If there was an error when updating, The Try will go instantly to the Catch.
    Private Sub btnSaveChanges_Click(sender As Object, e As EventArgs) Handles btnSaveChanges.Click

        Try

            Me.Validate()
            Me.CustomersInfoBindingSource.EndEdit()
            Me.CustomersInfoTableAdapter.Update(Me.EzPassDBSystem)

            AccountChangeSuccessful() ' Subroutine w/ a Dialog Box that states that the account was successfully changed & updated.

        Catch ex As Exception

            AccountNotProperlyChanged() ' Subroutine w/ a Dialog Box that states that the account was not successfully changed.

        End Try

    End Sub

    'Button Click Event that if clicked, displays Form 5, which is the Page for the user to report whether they
    ' want to return their tag and be requested with a new one, OR if they had lost their tag and want to a new one,
    ' they will have to pay a deduction fee of $ 25 Dollars on their Account Balance. More of this will be explained
    ' on the Form 5 Code Page.
    Private Sub BtnReportTag_Click(sender As Object, e As EventArgs) Handles btnReportTag.Click

        QuitInitiated = True

        Form5.Show()
        Me.Close()


    End Sub

    'Button Click Event that takes the user to a Form that helps them find their Account # if they had forgotten it.
    ' If they are present on this form, they will requested with their First & Last Name. There is a SQL Query Search
    ' in place that searches the Access Database records for that person and returns their Account Number to the Text box on this form.
    Private Sub btnFindAcct_Click(sender As Object, e As EventArgs) Handles btnFindAcct.Click

        grpUpdateAcct.Enabled = False
        Form8.Show()

    End Sub


    'Subroutine made in place to notify the user with a dialog box that the user cannot go over $ 500 Dollars when depositing
    ' into their account when they are first making the Account.
    Sub MaximumBalanceReached()

        Dim MaxBalanceMsg As Integer

        MaxBalanceMsg = MessageBox.Show("An Account cannot go over $ 500 Dollars.", "Maximum Reached", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    'Subroutine made in place to notify the user with a dialog box that the user cannot go under $ 0 Dollars when depositing
    ' into their account when they are first making the Account.
    Sub NegativeBalanceReached()

        Dim NegativeBalanceMsg As Integer

        NegativeBalanceMsg = MessageBox.Show("You cannot go into a negative balance on an Account.", "Negative Balance", MessageBoxButtons.OK, MessageBoxIcon.Stop)

    End Sub


    'Radio Button Check event, if clicked, all of the Currency amounts change from positive amounts (which add)
    ' to negative amounts(which subtract). This is done to give the user free reign of adding and subtracting
    ' how much they want to put into their account balance if they felt they added too much.
    Private Sub RadNegativeAmt_Checked(sender As Object, e As EventArgs) Handles RadNegativeAmt.CheckedChanged

        Add25 *= CurrencyRateChanger
        Add50 *= CurrencyRateChanger
        Add100 *= CurrencyRateChanger
        Add200 *= CurrencyRateChanger

    End Sub

    Private Sub TxtUpdateAcctBal_TextChanged(sender As Object, e As EventArgs) Handles txtUpdateAcctBal.TextChanged

        Dim NoBalanceLeft As Double = 0

        Dim MaximumBalanceAllowed As Double = 500

        Dim BalanceCutOff As Double

        Double.TryParse(txtUpdateAcctBal.Text, BalanceCutOff)


        If BalanceCutOff > MaximumBalanceAllowed Then

            txtUpdateAcctBal.Text = MaximumBalanceAllowed
            MaximumBalanceReached()

        End If

        If NoBalanceLeft > BalanceCutOff Then

            txtUpdateAcctBal.Text = NoBalanceLeft
            NegativeBalanceReached()

        End If

    End Sub

    'Button Click event subroutine that adds $ 25 Dollars into the Account Balance of the user on the Update Account Form.
    ' Also checks to see if the user is going over the maximum amount allowed, if the user is, the user will be prompted
    ' with a dialog box stating that they cannot go over 500, and will stay at $ 500 and wont go anymore up.
    Private Sub btnAdd25_Click(sender As Object, e As EventArgs) Handles btnAdd25.Click

        Double.TryParse(txtUpdateAcctBal.Text, CurrentAccountBalance)

        txtUpdateAcctBal.Text = CurrentAccountBalance + Add25

        AcctStatusCheck()

    End Sub


    'Button Click Event subroutine that adds $ 50 Dollars into the Account Balance of the user on the Update Account Form.
    ' Also checks to see if the user is going over the maximum amount allowed, if the user is, the user will be prompted
    ' with a dialog box stating that they cannot go over 500, and will stay at $ 500 and wont go anymore up.
    Private Sub BtnAdd50_Click(sender As Object, e As EventArgs) Handles btnAdd50.Click

        Double.TryParse(txtUpdateAcctBal.Text, CurrentAccountBalance)

        txtUpdateAcctBal.Text = CurrentAccountBalance + Add50

        AcctStatusCheck()

    End Sub

    'Button Click Event subroutine that adds $ 100 Dollars into the Account Balance of the user on the Update Account Form.
    ' Also checks to see if the user is going over the maximum amount allowed, if the user is, the user will be promped
    ' with a dialog box stating that they cannot go over 500, and will stay at $ 50 and wont go anymore up.
    Private Sub BtnAdd100_Click(sender As Object, e As EventArgs) Handles btnAdd100.Click

        Double.TryParse(txtUpdateAcctBal.Text, CurrentAccountBalance)

        txtUpdateAcctBal.Text = CurrentAccountBalance + Add100

        AcctStatusCheck()

    End Sub

    'Button Click Event subroutine that adds $ 200 Dollars into the Account balance of the user on the Update Account Form.
    ' Also checks to see if the user is going over the maximum amount allowed, if the user is, the user will be prompted
    ' with a dialog box stating that they cannot go over 50, and will stay at $ 200 and wont go anymore up.
    Private Sub BtnAdd200_Click(sender As Object, e As EventArgs) Handles btnAdd200.Click

        Double.TryParse(txtUpdateAcctBal.Text, CurrentAccountBalance)

        txtUpdateAcctBal.Text = CurrentAccountBalance + Add200

        AcctStatusCheck()

    End Sub

    Private Sub btnTolls_Click(sender As Object, e As EventArgs) Handles btnTolls.Click

        QuitInitiated = True

        Form11.Show()
        Me.Close()

    End Sub



    '' End of Comments for Form 3 of EzPass Database System Project. ''

End Class