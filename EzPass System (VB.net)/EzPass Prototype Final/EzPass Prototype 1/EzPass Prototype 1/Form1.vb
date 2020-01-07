Imports System.ComponentModel

Public Class Form1

    ''Beginning of Comments for Form 1 EzPass Database System Project.''
    ''Aleksey Przhevalskiy''

    'Class Level variables for all sub-routines to use.
    Dim AccountValidationBoolean As Boolean = False

    'Default Balance for every New Registration of an account.
    Dim CurrentAccountBalance As Integer = 0

    ' Maximum amount of money a customer can have in their account. $ 500 dollars.
    Dim MaximumBalanceAllowed As Integer = 500

    'Having a zero balance Amount inside the Amount Balance of the Registration form.
    Dim NoBalanceAccount As Integer = 0

    'Textbox Highlight Booleans.
    Dim FirstNameFocus As Boolean = False

    Dim LastNameFocus As Boolean = False

    Dim BirthFocus As Boolean = False

    Dim AddressFocus As Boolean = False

    Dim PhoneFocus As Boolean = False

    Dim EmailFocus As Boolean = False

    Dim CardFocus As Boolean = False

    Dim PlateFocus As Boolean = False

    'Class-Level Variables for the Currency Dollar Amount to be added or subtracted from Customer Balance.
    Dim Add25 As Integer = 25

    Dim Add50 As Integer = 50

    Dim Add100 As Integer = 100

    Dim Add200 As Integer = 200

    'Variable that changes the Currency variables (when MULTIPLIED) from positive to negative and vice versa.
    Dim CurrencyRateChanger As Integer = -1

    Const TagArrayLength As Integer = 100

    ''
    Dim QuitInitiated As Boolean = False


    'Button used to enter Form 2. Form 2 is the Employee Portal Database that holds the customer info.
    Private Sub btnEnterDb_Click(sender As Object, e As EventArgs) Handles btnEnterDb.Click

        Form2.Show()
        Me.Hide()

    End Sub

    'Prevents the user from clicking the red 'x' button. They have to quit the application via 'Quit Application' button.
    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        If QuitInitiated = True Then

            e.Cancel = False

        Else

            e.Cancel = True

        End If

    End Sub


    'Button to exit the program. User gets prompted if they realy want to exit, they will click yes if yes.
    Private Sub BtnLoginQuit_Click(sender As Object, e As EventArgs) Handles btnLoginQuit.Click

        Dim QuitSelected As Integer

        QuitSelected = MessageBox.Show("Are you sure you want to exit?", "Exiting...", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If QuitSelected = DialogResult.Yes Then

            QuitInitiated = True
            Me.Close()

        End If

    End Sub

    'Subroutine that clears all the text fields on the Registration form, so the user can enter new information.
    Private Sub btnClearFields_Click(sender As Object, e As EventArgs) Handles btnClearFields.Click

        'Personal Information Clearing.
        txtRegFirstName.Clear()
        txtRegLastName.Clear()
        txtBirthDate.Clear()
        txtRegAddress.Clear()
        txtRegPhone.Clear()
        txtRegEmail.Clear()
        txtRegCardFile.Clear()
        ''

        'Vehicle Information Clearing.
        txtRegPlateNbr.Clear()
        cmbRegBodyStyle.SelectedIndex = 0
        cmbRegModel.SelectedIndex = 0
        cmbRegYear.SelectedIndex = 0
        '

        'Account Information Clearing.
        txtRegAcctBal.Clear()
        '

        NoHighlightedFocus()

    End Sub


    'Subroutine used to create the current date of the month that the user clicks the New Registration Form button.
    Sub FormDates()

        Dim CurrentDate As String = Date.Today.ToString("MM/dd/yyyy")

        txtAcctDate.Text = CurrentDate

        txtRegTagDate.Text = CurrentDate

        txtRegSignUp.Text = CurrentDate

    End Sub

    'Subroutine made to create the various account numbers. They are all randomly generated numbers and 
    ' then assigned to their respective textboxes on the New Registration Form. The randomly generated numbers are
    ' in a range between 1-300. 300 being the Max value that the random number can reach.
    Sub IDVariableGeneration()

        Dim RndGenerator As New Random()

        Dim RndFinalValue As Integer = 300

        Dim CustomerIDFinalValue = 100

        Dim DefaultAccountStanding As String = "Good Standing"

        Dim DefaultTagStatus As String = "Assigned"

        Dim TagArray(TagArrayLength) As Integer

        TagArray(TagArrayLength) = RndGenerator.Next(0, RndFinalValue)

        ''''

        txtRegAccountNbr.Text = RndGenerator.Next(0, RndFinalValue)

        txtRegTagAccountID.Text = RndGenerator.Next(0, RndFinalValue)

        txtRegTagNbr.Text = RndGenerator.Next(0, RndFinalValue)

        ''''

        txtAcctStatus.Text = DefaultAccountStanding

        txtRegTagStatus.Text = DefaultTagStatus

    End Sub

    'Subroutine to set the Body style, Model and Vehicle Year combo boxes to their initial index upon the User
    'entering the Registration Form.
    Sub DefaultBodyAndModel()

        cmbRegBodyStyle.SelectedIndex = 0
        cmbRegModel.SelectedIndex = 0
        cmbRegYear.SelectedIndex = 0

    End Sub

    Sub RevenueDefaultValue()

        Dim RevenueDefault As Double

        RevenueDefault = 0

        txtClientRevenue.Text = RevenueDefault.ToString()

    End Sub


    'Button made to enter the New Registration form. The FormDates & IDVariableGeneration subroutines are returned here
    ' along with the program creating a new entry into the Access database for the customer to register their account.
    Private Sub btnEnterReg_Click(sender As Object, e As EventArgs) Handles btnEnterReg.Click

        Me.CustomersInfoBindingSource.AddNew()

        grpInitialLogin.Visible = False
        grpInitialLogin.Enabled = False

        IDVariableGeneration()
        FormDates()
        DefaultBodyAndModel()
        RevenueDefaultValue()

    End Sub


    Sub TextBoxFocusHighlight()

        If FirstNameFocus = True Then

            txtRegFirstName.BackColor = Color.LemonChiffon

        Else

            FirstNameFocus = False
            txtRegFirstName.BackColor = Color.White

        End If


        If LastNameFocus = True Then

            txtRegLastName.BackColor = Color.LemonChiffon

        Else

            LastNameFocus = False
            txtRegLastName.BackColor = Color.White

        End If

        If BirthFocus = True Then

            txtBirthDate.BackColor = Color.LemonChiffon

        Else

            BirthFocus = False
            txtBirthDate.BackColor = Color.White

        End If


        If AddressFocus = True Then

            txtRegAddress.BackColor = Color.LemonChiffon

        Else

            AddressFocus = False
            txtRegAddress.BackColor = Color.White

        End If


        If EmailFocus = True Then

            txtRegEmail.BackColor = Color.LemonChiffon

        Else

            EmailFocus = False
            txtRegEmail.BackColor = Color.White

        End If

        If PlateFocus = True Then

            txtRegPlateNbr.BackColor = Color.LemonChiffon

        Else

            PlateFocus = False
            txtRegPlateNbr.BackColor = Color.White

        End If


        If CardFocus = True Then

            txtRegCardFile.BackColor = Color.LemonChiffon

        Else

            CardFocus = False
            txtRegCardFile.BackColor = Color.White

        End If

        If PhoneFocus = True Then

            txtRegPhone.BackColor = Color.LemonChiffon

        Else

            PhoneFocus = False
            txtRegPhone.BackColor = Color.White

        End If

    End Sub

    Sub NoHighlightedFocus()

        FirstNameFocus = False
        LastNameFocus = False
        BirthFocus = False
        AddressFocus = False
        PhoneFocus = False
        EmailFocus = False
        CardFocus = False
        PlateFocus = False

        txtRegFirstName.BackColor = Color.White
        txtRegLastName.BackColor = Color.White
        txtBirthDate.BackColor = Color.White
        txtRegAddress.BackColor = Color.White
        txtRegPhone.BackColor = Color.White
        txtRegEmail.BackColor = Color.White
        txtRegCardFile.BackColor = Color.White
        txtRegPlateNbr.BackColor = Color.White


    End Sub

    Private Sub txtRegFirstName_GotFocus(sender As Object, e As EventArgs) Handles txtRegFirstName.GotFocus

        FirstNameFocus = True
        LastNameFocus = False
        BirthFocus = False
        AddressFocus = False
        PhoneFocus = False
        EmailFocus = False
        CardFocus = False
        PlateFocus = False

        TextBoxFocusHighlight()

    End Sub

    Private Sub txtRegLastName_GotFocus(sender As Object, e As EventArgs) Handles txtRegLastName.GotFocus

        FirstNameFocus = False
        LastNameFocus = True
        BirthFocus = False
        AddressFocus = False
        PhoneFocus = False
        EmailFocus = False
        CardFocus = False
        PlateFocus = False

        TextBoxFocusHighlight()


    End Sub

    Private Sub txtBirthDate_GotFocus(sender As Object, e As EventArgs) Handles txtBirthDate.GotFocus

        FirstNameFocus = False
        LastNameFocus = False
        BirthFocus = True
        AddressFocus = False
        PhoneFocus = False
        EmailFocus = False
        CardFocus = False
        PlateFocus = False

        TextBoxFocusHighlight()

    End Sub

    Private Sub txtRegAddress_GotFocus(sender As Object, e As EventArgs) Handles txtRegAddress.GotFocus

        FirstNameFocus = False
        LastNameFocus = False
        BirthFocus = False
        AddressFocus = True
        PhoneFocus = False
        EmailFocus = False
        CardFocus = False
        PlateFocus = False

        TextBoxFocusHighlight()

    End Sub

    Private Sub txtRegEmail_GotFocus(sender As Object, e As EventArgs) Handles txtRegEmail.GotFocus

        FirstNameFocus = False
        LastNameFocus = False
        BirthFocus = False
        AddressFocus = False
        PhoneFocus = False
        EmailFocus = True
        CardFocus = False
        PlateFocus = False

        TextBoxFocusHighlight()

    End Sub

    Private Sub txtRegPhone_GotFocus(sender As Object, e As EventArgs) Handles txtRegPhone.GotFocus

        FirstNameFocus = False
        LastNameFocus = False
        BirthFocus = False
        AddressFocus = False
        PhoneFocus = True
        EmailFocus = False
        CardFocus = False
        PlateFocus = False

        TextBoxFocusHighlight()

    End Sub

    Private Sub txtRegCardFile_GotFocus(sender As Object, e As EventArgs) Handles txtRegCardFile.GotFocus

        FirstNameFocus = False
        LastNameFocus = False
        BirthFocus = False
        AddressFocus = False
        PhoneFocus = False
        EmailFocus = False
        CardFocus = True
        PlateFocus = False

        TextBoxFocusHighlight()

    End Sub

    Private Sub txtRegPlateNbr_GotFocus(sender As Object, e As EventArgs) Handles txtRegPlateNbr.GotFocus

        FirstNameFocus = False
        LastNameFocus = False
        BirthFocus = False
        AddressFocus = False
        PhoneFocus = False
        EmailFocus = False
        CardFocus = False
        PlateFocus = True

        TextBoxFocusHighlight()

    End Sub

    Private Sub txtRegSignUp_GotFocus(sender As Object, e As EventArgs) Handles txtRegSignUp.GotFocus

        NoHighlightedFocus()
        TextBoxFocusHighlight()

    End Sub

    Private Sub txtAcctDate_GotFocus(sender As Object, e As EventArgs) Handles txtAcctDate.GotFocus

        NoHighlightedFocus()
        TextBoxFocusHighlight()

    End Sub

    Private Sub txtRegTagDate_GotFocus(sender As Object, e As EventArgs) Handles txtRegTagDate.GotFocus

        NoHighlightedFocus()
        TextBoxFocusHighlight()

    End Sub

    Private Sub txtRegAcctBal_GotFocus(sender As Object, e As EventArgs) Handles txtRegAcctBal.GotFocus

        NoHighlightedFocus()
        TextBoxFocusHighlight()

    End Sub

    Private Sub cmbRegModel_GotFocus(sender As Object, e As EventArgs) Handles cmbRegModel.GotFocus

        NoHighlightedFocus()
        TextBoxFocusHighlight()

    End Sub

    Private Sub cmbRegYear_GotFocus(sender As Object, e As EventArgs) Handles cmbRegYear.GotFocus

        NoHighlightedFocus()
        TextBoxFocusHighlight()

    End Sub

    Private Sub cmbRegBodyStyle_GotFocus(sender As Object, e As EventArgs) Handles cmbRegBodyStyle.GotFocus

        NoHighlightedFocus()
        TextBoxFocusHighlight()

    End Sub


    ' Subroutine made to check and monitor if there are any empty text box fields inside the New Registration Form.
    ' If there are, the user will be prompted when they back out of the New Registration Form if they truly want to exit
    ' and delete their current request to make an account.
    Sub DeleteRecordPrompt()

        Dim DeleteRecordPromptMsg As Integer

        If txtRegFirstName.Text = String.Empty Or txtRegLastName.Text = String.Empty Or txtRegAddress.Text = String.Empty Or txtRegEmail.Text = String.Empty Or txtRegSignUp.Text = String.Empty Then

            DeleteRecordPromptMsg = MessageBox.Show("Going back deletes your current Sign-Up. Do you wish to proceed?", "User Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If DeleteRecordPromptMsg = DialogResult.Yes Then

                Me.CustomersInfoBindingSource.RemoveCurrent()

                grpInitialLogin.Visible = True
                grpInitialLogin.Enabled = True

            End If

        End If

        If txtRegPlateNbr.Text = String.Empty Or cmbRegYear.Text = String.Empty Then

            DeleteRecordPromptMsg = MessageBox.Show("Going back Deletes your current Sign-Up. Do you wish to Proceed?", "User Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If DeleteRecordPromptMsg = DialogResult.Yes Then

                Me.CustomersInfoBindingSource.RemoveCurrent()

                grpInitialLogin.Visible = True
                grpInitialLogin.Enabled = True

            End If

        End If


        If txtRegAcctBal.Text = String.Empty Then

            DeleteRecordPromptMsg = MessageBox.Show("Going back Deletes your current Sign-Up. Do you wish to Proceed?", "User Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If DeleteRecordPromptMsg = DialogResult.Yes Then

                Me.CustomersInfoBindingSource.RemoveCurrent()

                grpInitialLogin.Visible = True
                grpInitialLogin.Enabled = True

            End If


        End If

    End Sub

    Sub PhoneNumericDetect()

        Dim DetectMsg As Integer

        DetectMsg = MessageBox.Show("This field requires only numbers. Please re-enter the field again.", "Numbers Only", MessageBoxButtons.OK, MessageBoxIcon.Information)

        If DetectMsg = DialogResult.OK Then

            txtRegPhone.Clear()

        End If

    End Sub

    Private Sub txtRegPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRegPhone.KeyPress

        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = ChrW(Keys.Back) Then

            e.Handled = True
            PhoneNumericDetect()

        End If

    End Sub

    ' The button that executes the subroutine (DeleteRecordPrompt) for backing out of the New Registration Form.
    Private Sub btnBackLogin_Click(sender As Object, e As EventArgs) Handles BtnBackLogin.Click

        DeleteRecordPrompt()

    End Sub

    ' Button that opens the Form3, which is where the customer (not the client) can go to update their various account information.
    Private Sub BtnUpdateAccount_Click(sender As Object, e As EventArgs) Handles btnUpdateAccount.Click

        Form3.Show()
        Me.Hide()

    End Sub

    'Button that opens the Form 9, which is where the customer processes a toll through their choice of which
    ' toll code they are using. Each toll code has a different fare that will be deducted from the Account.
    ' More on this will be explained on the Form 9 for Tolls.
    Private Sub BtnToll_Click(sender As Object, e As EventArgs) Handles btnToll.Click

        Form9.Show()
        Me.Hide()

    End Sub

    'Preloading the Access Database into Form1 to be used to register accounts if the user clicks the New Registration Button.
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'EzPassDBSystem.CustomersInfo' table. You can move, or remove it, as needed.
        Me.CustomersInfoTableAdapter.Fill(Me.EzPassDBSystem.CustomersInfo)

        'The positive amount radio button is automatically checked first by default upon the form load.
        RadPositiveAmt.Checked = True

    End Sub

    'Subroutine made to check if their are empty text box fields within the New Registration Form. 
    ' If there are, the user will be prompted with a dialog box saying there are empty fields and they will not be able
    ' to create an account until all of the text boxes are filled.
    Sub NullFieldTextChecker()

        Dim NullTextMsgBox As Integer

        If txtRegFirstName.Text = String.Empty Or txtRegLastName.Text = String.Empty Or txtRegAddress.Text = String.Empty Or txtRegEmail.Text = String.Empty Or txtRegSignUp.Text = String.Empty Then

            NullTextMsgBox = MessageBox.Show("There are Empty Fields in the Registration.", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            AccountValidationBoolean = False

        Else

            AccountValidationBoolean = True

        End If

        If txtRegPlateNbr.Text = String.Empty Or cmbRegYear.Text = String.Empty Or cmbRegModel.SelectedIndex = 0 Or cmbRegBodyStyle.SelectedIndex = 0 Then

            NullTextMsgBox = MessageBox.Show("There are Empty Fields in the Registration.", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            AccountValidationBoolean = False

        Else

            AccountValidationBoolean = True

        End If


        If txtRegAcctBal.Text = String.Empty Then

            NullTextMsgBox = MessageBox.Show("There are Empty Fields in the Registration.", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            AccountValidationBoolean = False

        Else

            AccountValidationBoolean = True

        End If


    End Sub

    ' Subroutine made for a dialog box that will appear for the user when the Account is created successfully.
    Sub AccountCreatedMsg()

        Dim AccountCreatedMsg As Integer

        AccountCreatedMsg = MessageBox.Show("Account created successfully! Thank you!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

    End Sub

    Sub AccountCreationError()

        Dim AccountError As Integer

        AccountError = MessageBox.Show("There has been an error creating your account. Try checking the text fields.", "Creation Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)

    End Sub


    'The Create Account Button used to create an account for the user. Since there would not be any empty text fields,
    ' the AccountValidationBoolean will return true and if it is true, it will save the data and update it to the Database.
    ' and the user will be prompted with a dialog box that states the Account was made successfully.
    Private Sub btnCreateAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click

        NullFieldTextChecker()

        If AccountValidationBoolean = True Then

            Try

                Me.Validate()
                Me.CustomersInfoBindingSource.EndEdit()
                Me.CustomersInfoTableAdapter.Update(Me.EzPassDBSystem)

                NoHighlightedFocus()

                AccountCreatedMsg()

                'Setting the User back to the Form 1 Login after they create an account.
                grpInitialLogin.Enabled = True
                grpInitialLogin.Visible = True

            Catch ex As Exception

                AccountCreationError()

            End Try


        End If

    End Sub

    'Subroutine made in place to notify the user with a dialog box that the user cannot go over $ 500 Dollars when depositing
    ' into their account when they are first making the Account.
    Sub MaximumBalanceReached()

        Dim MaxBalanceMsg As Integer

        MaxBalanceMsg = MessageBox.Show("A New Account cannot go over $ 500 Dollars.", "Maximum Reached", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    'Subroutine made in place to notify the user with a dialog box that the user cannot go under $ 0 Dollars when depositing
    ' into their account when they are first making the Account.
    Sub NegativeBalanceReached()

        Dim NegativeBalanceMsg As Integer

        NegativeBalanceMsg = MessageBox.Show("You cannot go into a negative balance on an Account.", "Negative Balance", MessageBoxButtons.OK, MessageBoxIcon.Stop)

    End Sub

    'Radio Button Check event, if clicked, all of the Currency amounts change from negative amounts (which subtract)
    ' to positive amounts(which add). This is done to give the user free reign of adding and subtracting
    ' how much they want to put into their account balance if they felt they added too much.
    Private Sub RadNegativeAmt_CheckedChanged(sender As Object, e As EventArgs) Handles RadNegativeAmt.CheckedChanged

        Add25 *= CurrencyRateChanger
        Add50 *= CurrencyRateChanger
        Add100 *= CurrencyRateChanger
        Add200 *= CurrencyRateChanger

    End Sub

    Private Sub TxtRegAcctBal_TextChanged(sender As Object, e As EventArgs) Handles txtRegAcctBal.TextChanged

        Dim NoBalanceLeft As Double = 0

        Dim MaximumBalanceAllowed As Double = 500

        Dim BalanceCutOff As Double

        Integer.TryParse(txtRegAcctBal.Text, BalanceCutOff)


        If BalanceCutOff > MaximumBalanceAllowed Then

            txtRegAcctBal.Text = MaximumBalanceAllowed
            MaximumBalanceReached()

        End If

        If NoBalanceLeft > BalanceCutOff Then

            txtRegAcctBal.Text = NoBalanceLeft
            NegativeBalanceReached()

        End If

    End Sub

    'Button Click event subroutine that adds $ 25 Dollars into the Account Balance of the user on the Registration Form.
    ' Also checks to see if the user is going over the maximum amount allowed, if the user is, the user will be prompted
    ' with a dialog box stating that they cannot go over 500, and will stay at $ 500 and wont go anymore up.
    Private Sub btnAdd25_Click(sender As Object, e As EventArgs) Handles btnAdd25.Click

        Integer.TryParse(txtRegAcctBal.Text, CurrentAccountBalance)

        txtRegAcctBal.Text = CurrentAccountBalance + Add25

    End Sub

    'Button Click event subroutine that adds $ 50 Dollars into the Account Balance of the user on the Registration Form.
    ' Also checks to see if the user is going over the maximum amount allowed, if the user is, the user will be prompted
    ' with a dialog box stating that they cannot go over 50, and will stay at $ 500 and wont go anymore up.
    Private Sub BtnAdd50_Click(sender As Object, e As EventArgs) Handles btnAdd50.Click

        Integer.TryParse(txtRegAcctBal.Text, CurrentAccountBalance)

        txtRegAcctBal.Text = CurrentAccountBalance + Add50

    End Sub

    'Button Click event subroutine that adds $ 100 dollars into the Account Balance of the user on the Registration Form.
    ' Also checks to see if the user is going over the maximum amount allowed, if the user is, the user will be prompted
    ' with a dialog box stating that they cannot go over 500, and will stay at $ 500 and wont go anymore up.
    Private Sub BtnAdd100_Click(sender As Object, e As EventArgs) Handles btnAdd100.Click

        Integer.TryParse(txtRegAcctBal.Text, CurrentAccountBalance)

        txtRegAcctBal.Text = CurrentAccountBalance + Add100

    End Sub

    'Button Click event subroutine that adds $ 200 dollars into the Account Balance of the user on the Registration Form.
    ' Also checks to see if the user is going over the maximum amount allowed, if the user is, the user will be prompted
    ' with a dialog box stating that they cannot go over 500, and will stay at $ 500 and wont go anymore up.
    Private Sub BtnAdd200_Click(sender As Object, e As EventArgs) Handles btnAdd200.Click

        Integer.TryParse(txtRegAcctBal.Text, CurrentAccountBalance)

        txtRegAcctBal.Text = CurrentAccountBalance + Add200

    End Sub



    '' End of Comments for Form 1 of the EzPass Database System Project'' 

End Class