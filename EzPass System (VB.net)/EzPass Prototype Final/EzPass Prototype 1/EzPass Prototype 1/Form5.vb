Imports System.ComponentModel

Public Class Form5

    ''Beginning of Comments for Form 5 of EzPass System Project.''
    ''Aleksey Przhevalskiy''

    'Class-Level Variables for all sub-routines to use them.
    Dim TagStatusEmptyFields As Boolean = False

    Dim LostTagReport As Boolean = False

    Dim ReturnTagReport As Boolean = False

    Dim AcctFieldisFull As Boolean = False

    Dim NoTagAssigned As String = "N/A"

    ''
    Public QuitInitiated As Boolean = False
    '

    ''
    Dim ReportAccountFocus As Boolean = False
    Dim ReportLostTagFocus As Boolean = False
    Dim ReturnAccountFocus As Boolean = False
    Dim ReturnTagFocus As Boolean = False
    ''

    'Preloads the ReturnedTagsInfo & LostTagsInfo & CustomersInfo Tables from the Database Access File to Form 5 when it loads.
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'EzPassDBSystem.ReturnedTagsInfo' table. You can move, or remove it, as needed.
        Me.ReturnedTagsInfoTableAdapter.Fill(Me.EzPassDBSystem.ReturnedTagsInfo)

        'TODO: This line of code loads data into the 'EzPassDBSystem.LostTagsInfo' table. You can move, or remove it, as needed.
        Me.LostTagsInfoTableAdapter.Fill(Me.EzPassDBSystem.LostTagsInfo)

        'TODO: This line of code loads data into the 'EzPassDBSystem.CustomersInfo' table. You can move, or remove it, as needed.
        Me.CustomersInfoTableAdapter.Fill(Me.EzPassDBSystem.CustomersInfo)

    End Sub

    Private Sub Form5_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        If QuitInitiated = True Then

            e.Cancel = False

        Else

            e.Cancel = True

        End If

    End Sub


    'Subroutine made to check if any of the Lost Tag Text Fields are empty. If they are, the User will be prompted
    ' with a dialog box stating that there are empty fields and the TagStatusEmptyFields boolean stays true.
    ' If the text field boxes are full, the TagStatusEmptyFields will return false, which will be used for later.
    Sub ReportLostMsgSuccessful()

        Dim ReportLostMsg As Integer

        Dim LostEmptyFieldsMsg As Integer

        If txtReportLostTag.Text = String.Empty Or txtReportAcct.Text = String.Empty Or txtReportLostDate.Text = String.Empty Or cmbLostReason.SelectedIndex = 0 Then

            TagStatusEmptyFields = True
            LostEmptyFieldsMsg = MessageBox.Show("There are empty fields in the form.", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        Else

            TagStatusEmptyFields = False
            ReportLostMsg = MessageBox.Show("The Tag was successfully reported lost.", "Reported Lost", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

    'Subroutine made to check if any of the Returned Tag Text Fields are empty. If they are, the User will be prompted
    ' with a dialog box stating that there are empty fields and the TagStatusEmptyFields boolean stays true.
    ' If the text field boxes are full, the TagStatusEmptyFields will return false, which will be used for later.
    Sub ReturnTagMsgSuccessful()

        Dim ReportReturnMsg As Integer

        Dim ReturnEmptyFieldMsg As Integer

        If txtReturnAcct.Text = String.Empty Or txtReturnTag.Text = String.Empty Or txtTagReturnDate.Text = String.Empty Or cmbReturnReason.SelectedIndex = 0 Then

            TagStatusEmptyFields = True
            ReturnEmptyFieldMsg = MessageBox.Show("There are empty fields in the form.", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        Else

            TagStatusEmptyFields = False
            ReportReturnMsg = MessageBox.Show("The Tag was successfully returned.", "Tag Returned", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

    'Subroutine made to get the real-time date and assign it to the Report Lost Date text field to represent
    ' which day that the User had lost the tag.
    Sub LostTagDateChanged()

        Dim LostTagDateChange As String = Date.Today.ToString("MM/dd/yyyy")

        txtReportLostDate.Text = LostTagDateChange
        txtReportLostDate.Enabled = False


    End Sub

    'Subroutine made to get the real-time date and assign it to the Report Return Date text field to represent
    ' which day that the User had returned their current tag.
    Sub ReturnTagDateChanged()

        Dim ReturnTagDateChange As String = Date.Today.ToString("MM/dd/yyyy")

        txtTagReturnDate.Text = ReturnTagDateChange
        txtTagReturnDate.Enabled = False


    End Sub

    'Subroutine made to prompt a dialog box to the User stating that the Input Box field is empty and that
    ' they should try to re-enter data into the input box.
    Sub EmptyInputBoxFields()

        Dim EmptyFieldMsg As Integer

        EmptyFieldMsg = MessageBox.Show("The Input Box field is empty. Please Try again", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

    End Sub

    'Subroutine made to prompt a dialog box to the User stating that the Account they are trying to reach,
    ' does not exist and that they should try to enter another Account Number.
    Sub AccountNotExist()

        Dim AccountMsg As Integer

        AccountMsg = MessageBox.Show("That account does not exist. Please Try again.", "Account Doesn't Exist", MessageBoxButtons.OK, MessageBoxIcon.Error)

    End Sub

    Sub NoTagExistsChecker()

        Dim NoTagCheck As String

        NoTagCheck = "N/A"

        Dim NoTagMsg As Integer

        If lblRetrieveTag.Text = NoTagCheck And AcctFieldisFull = True Then

            NoTagMsg = MessageBox.Show("This account has no Tags to report. Sorry!", "No Tag", MessageBoxButtons.OK, MessageBoxIcon.Information)

            AcctFieldisFull = False

        End If

    End Sub


    'Subroutine that prompts the User with an Input Box to re-verify the Account they are trying to reach,
    ' if that Account exists, the VB Program will do an SQL Query Search and find that Account and use link the 
    ' information from that Account to the Current Form 5 to be used to assign new tags or deduct fees.
    Sub EnterAccountInputBox()

        'Variable for assigning the Input Box.
        Dim AccountInputBox As String

        Dim CustomerFilled As String

        Dim DefaultValueSpace As String

        Dim Cancelling As String

        DefaultValueSpace = " "

        Cancelling = ""

        'Input Box used to verify the Account Number to an Account inside the Access Database.
        AccountInputBox = InputBox("Please re-enter your Account #.", "Verification", DefaultValueSpace)


        If AccountInputBox = DefaultValueSpace Then

            'The user stays on the login page without accessing the next part of the form due to the fact that
            ' they havent found a valid Account.
            grpTagStatusLogin.Enabled = True
            grpTagStatusLogin.Visible = True

            AcctFieldisFull = False

            EmptyInputBoxFields() 'Subroutine that displays the dialog box stating that the Input Box is empty.

        ElseIf AccountInputBox = Cancelling Then

            Exit Sub

        Else

            AcctFieldisFull = True

            CustomerFilled = AccountInputBox

            'SQL Query Search for Specific Customer Accounts.
            Me.CustomersInfoTableAdapter.FillByAccountNumber(Me.EzPassDBSystem.CustomersInfo, CustomerFilled)

            'If the Account does not exist when the program tries to run the SQL Query Search, this 'If' statement happens.
            If Me.CustomersInfoTableAdapter.FillByAccountNumber(Me.EzPassDBSystem.CustomersInfo, CustomerFilled) = Nothing Then

                AccountNotExist() 'subroutine dialog box that displays to the user that this account doesn't exist.

                AcctFieldisFull = False

            End If

        End If

    End Sub

    'Subroutine that prompts the User with an Input Box asking if they would like to buy a new Tag and add it 
    ' to their account. (If they had lost their tag). If the User clicks yes, this Form will close and Form 6 
    ' will open where the User can enter their account information and buy a new tag.
    Sub AssignNewLostTag()

        Dim NewTagFromLostMsg As Integer

        NewTagFromLostMsg = MessageBox.Show("Would you like to buy a new Tag and add it to your Account?", "New Tag", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If NewTagFromLostMsg = DialogResult.Yes Then

            Form6.Show()

            grpTagStatusLogin.Enabled = False
            grpTagStatusLogin.Visible = True

        Else

            QuitInitiated = True

            Form3.Show()
            Me.Close()

        End If

    End Sub

    Sub TextFocusColor()

        If ReportAccountFocus = True Then

            txtReportAcct.BackColor = Color.LemonChiffon

        Else

            ReportAccountFocus = False
            txtReportAcct.BackColor = Color.White

        End If

        If ReportLostTagFocus = True Then

            txtReportLostTag.BackColor = Color.LemonChiffon

        Else

            ReportLostTagFocus = False
            txtReportLostTag.BackColor = Color.White

        End If

        If ReturnAccountFocus = True Then

            txtReturnAcct.BackColor = Color.LemonChiffon

        Else

            ReturnAccountFocus = False
            txtReturnAcct.BackColor = Color.White

        End If

        If ReturnTagFocus = True Then

            txtReturnTag.BackColor = Color.LemonChiffon

        Else

            ReturnTagFocus = False
            txtReturnTag.BackColor = Color.White

        End If

    End Sub

    Sub NoHighlightFocus()

        ReportAccountFocus = True
        ReportLostTagFocus = False
        ReturnAccountFocus = False
        ReturnTagFocus = False

        txtReportAcct.BackColor = Color.White
        txtReportLostTag.BackColor = Color.White
        txtReturnAcct.BackColor = Color.White
        txtReturnTag.BackColor = Color.White

    End Sub

    Private Sub txtReportAcct_GotFocus(sender As Object, e As EventArgs) Handles txtReportAcct.GotFocus

        ReportAccountFocus = True
        ReportLostTagFocus = False
        ReturnAccountFocus = False
        ReturnTagFocus = False

        TextFocusColor()

    End Sub

    Private Sub txtReportLostTag_GotFocus(sender As Object, e As EventArgs) Handles txtReportLostTag.GotFocus

        ReportAccountFocus = False
        ReportLostTagFocus = True
        ReturnAccountFocus = False
        ReturnTagFocus = False

        TextFocusColor()

    End Sub

    Private Sub txtReturnAcct_GotFocus(sender As Object, e As EventArgs) Handles txtReturnAcct.GotFocus

        ReportAccountFocus = False
        ReportLostTagFocus = False
        ReturnAccountFocus = True
        ReturnTagFocus = False

        TextFocusColor()

    End Sub

    Private Sub txtReturnTag_GotFocus(sender As Object, e As EventArgs) Handles txtReturnTag.GotFocus

        ReportAccountFocus = False
        ReportLostTagFocus = False
        ReturnAccountFocus = False
        ReturnTagFocus = True

        TextFocusColor()

    End Sub

    Private Sub txtReportLostDate_GotFocus(sender As Object, e As EventArgs) Handles txtReportLostDate.GotFocus

        TextFocusColor()
        NoHighlightFocus()

    End Sub

    Private Sub txtLostTagStatus_GotFocus(sender As Object, e As EventArgs) Handles txtLostTagStatus.GotFocus

        TextFocusColor()
        NoHighlightFocus()

    End Sub

    Private Sub txtTagReturnDate_GotFocus(sender As Object, e As EventArgs) Handles txtTagReturnDate.GotFocus

        TextFocusColor()
        NoHighlightFocus()

    End Sub

    Private Sub txtReturnTagStatus_GotFocus(sender As Object, e As EventArgs) Handles txtReturnTagStatus.GotFocus

        TextFocusColor()
        NoHighlightFocus()

    End Sub

    Private Sub cmbLostReason_GotFocus(sender As Object, e As EventArgs) Handles cmbLostReason.GotFocus

        TextFocusColor()
        NoHighlightFocus()

    End Sub

    Private Sub cmbReturnReason_GotFocus(sender As Object, e As EventArgs) Handles cmbReturnReason.GotFocus

        TextFocusColor()
        NoHighlightFocus()

    End Sub

    Sub RemovalReasonAssigner()

        If cmbLostReason.SelectedIndex = 1 Then

            txtLostReasonPlaceholder.Text = cmbLostReason.Text

        End If

        If cmbLostReason.SelectedIndex = 2 Then

            txtLostReasonPlaceholder.Text = cmbLostReason.Text

        End If

        If cmbLostReason.SelectedIndex = 3 Then

            txtLostReasonPlaceholder.Text = cmbLostReason.Text

        End If

        If cmbReturnReason.SelectedIndex = 1 Then

            txtReturnReasonPlaceholder.Text = cmbReturnReason.Text

        End If

        If cmbReturnReason.SelectedIndex = 2 Then

            txtReturnReasonPlaceholder.Text = cmbReturnReason.Text

        End If

        If cmbReturnReason.SelectedIndex = 3 Then

            txtReturnReasonPlaceholder.Text = cmbReturnReason.Text

        End If

    End Sub

    Private Sub cmbLostReason_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLostReason.SelectedIndexChanged

        RemovalReasonAssigner()

    End Sub

    Private Sub cmbReturnReason_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbReturnReason.SelectedIndexChanged

        RemovalReasonAssigner()

    End Sub

    'Button Click Event, that if clicked AND there are no Empty Lost Tag Text Fields, will save and update 
    ' the database and send the information of the Lost Tag # and the Account that lost it, to the LostTagsInfo
    ' Data Table, which can be seen and monitored in Form 4 (Tag Monitor).
    Private Sub btnReportLost_Click(sender As Object, e As EventArgs) Handles btnReportLost.Click

        ReportLostMsgSuccessful()

        If TagStatusEmptyFields = False Then

            Me.Validate()
            Me.LostTagsInfoBindingSource.EndEdit()
            Me.LostTagsInfoTableAdapter.Update(Me.EzPassDBSystem)

            Me.CustomersInfoBindingSource.EndEdit()
            Me.CustomersInfoTableAdapter.Update(Me.EzPassDBSystem)

            AssignNewLostTag()

        End If

    End Sub

    'Subroutine made to prompt the Employee or Customer if they would like to assign that Returned Tag account, a new tag.
    'If the Employee or Customer clicks Yes in the dialog box, Form 7 will appear where they can assign the Tag to the Account,
    ' at a No Cost Fee, since they had not lost the tag prior.
    Sub AssignNewTagPrompt()

        Dim NewTagPromptMsg As Integer

        NewTagPromptMsg = MessageBox.Show("Would you like to be assigned a New Tag to your Account?", "New Tag", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If NewTagPromptMsg = DialogResult.Yes Then

            Form7.Show()

            grpTagStatusLogin.Enabled = False
            grpTagStatusLogin.Visible = True

        Else

            QuitInitiated = True

            Form3.Show()
            Me.Close()

        End If

    End Sub

    ''
    Sub ReportNumericDetect()

        Dim DetectMsg As Integer

        DetectMsg = MessageBox.Show("This field requires only numbers. Please re-enter the field again.", "Numbers Only", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    ''
    Private Sub txtReportLostTag_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtReportLostTag.KeyPress

        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = ChrW(Keys.Back) Then

            e.Handled = True
            ReportNumericDetect()

        End If

    End Sub

    ''
    Private Sub txtReportAcct_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtReportAcct.KeyPress

        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = ChrW(Keys.Back) Then

            e.Handled = True
            ReportNumericDetect()

        End If

    End Sub

    ''
    Private Sub txtReturnTag_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtReturnTag.KeyPress

        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = ChrW(Keys.Back) Then

            e.Handled = True
            ReportNumericDetect()

        End If

    End Sub

    ''
    Private Sub txtReturnAcct_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtReturnAcct.KeyPress

        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = ChrW(Keys.Back) Then

            e.Handled = True
            ReportNumericDetect()

        End If

    End Sub

    'Button Click Event, that if clicked, AND there are no Empty Returned Tag Text Fields, will save and update
    ' the database and send the information of the Returned Tag # and the Account that returned it, to the ReturnedTagsInfo
    ' Data Table, which can be seen and monitored in Form 4 (Tag Monitor).
    Private Sub BtnReportReturn_Click(sender As Object, e As EventArgs) Handles btnReportReturn.Click

        ReturnTagMsgSuccessful()

        If TagStatusEmptyFields = False Then

            Me.Validate()
            Me.ReturnedTagsInfoBindingSource.EndEdit()
            Me.ReturnedTagsInfoTableAdapter.Update(Me.EzPassDBSystem)

            Me.CustomersInfoBindingSource.EndEdit()
            Me.CustomersInfoTableAdapter.Update(Me.EzPassDBSystem)

            AssignNewTagPrompt()

        End If

    End Sub

    ''
    Sub PlaceholderFunctionality()

        ' Design features to display certain parts of the Lost Tags information and seperate the Returned
        ' Tags Information because they both reside on the same Form 5. They are just utilized differently
        ' based on whether the User wants to return their current tag, or report their lost tag and buy a new one.
        lblLostTagPlace.Visible = False
        lblLostTagPlace.Enabled = False

        lblReturnTagPlace.Visible = False
        lblReturnTagPlace.Enabled = False

        txtLostTagPlace.Visible = False
        txtLostTagPlace.Enabled = False

        txtReturnTagPlace.Visible = False
        txtReturnTagPlace.Enabled = False

        lblReturnRemovalDatePlace.Enabled = False
        lblReturnRemovalDatePlace.Visible = False

        lblLostRemovalDatePlace.Enabled = False
        lblLostRemovalDatePlace.Visible = False

        txtReturnRemovalDatePlace.Enabled = False
        txtReturnRemovalDatePlace.Visible = False

        txtLostRemovalDatePlace.Enabled = False
        txtLostRemovalDatePlace.Visible = False

        txtLostTagPlace.Text = NoTagAssigned
        txtReturnTagPlace.Text = NoTagAssigned

        txtLostRemovalDatePlace.Text = txtReportLostDate.Text
        ''

        lblLostReasonPlaceholder.Enabled = False
        lblLostReasonPlaceholder.Visible = False

        txtLostReasonPlaceholder.Enabled = False
        txtLostReasonPlaceholder.Visible = False

        ''

        lblReturnReasonPlaceholder.Enabled = False
        lblReturnReasonPlaceholder.Visible = False

        txtReturnReasonPlaceholder.Enabled = False
        txtReturnReasonPlaceholder.Visible = False

        ''

    End Sub


    'Button Click Event that if clicked, logs the Customer/User into the Lost Tag Page where they can fill
    ' out their Lost Tag #, which Account # they are, and have a program-generated date of which they lost the tag.
    ' When those fields are full, the User/Customer can then send off his Lost Tag Report and it will also update his Account too.
    Private Sub btnLoginTagLost_Click(sender As Object, e As EventArgs) Handles btnLoginTagLost.Click

        'Subroutine that re-verifies the Account Number of the Customer that the user is trying to reach.
        EnterAccountInputBox()

        'Checking to see if there is a tag assigned or not. If no tag exists, the user cant use this page because its for reporting tags
        ' that exists along with the user wants to return it or report it lost.
        NoTagExistsChecker()

        'If the Account Field is full on the login and a real Account Number, 
        ' the program generates the form where the User can send their lost Tag Report.
        If AcctFieldisFull = True Then

            Dim LostTagStatusAssign As String = "Lost"

            LostTagReport = True

            'Adds a New Entry into the LostTagsInfo Data Table.
            Me.LostTagsInfoBindingSource.AddNew()

            'Subroutine that generates the real-time date of which the User lost their tag.
            LostTagDateChanged()

            'Disables the visibility of the Login page once the VB Program verifies that the account field is full
            ' and the Account Number is real.
            grpTagStatusLogin.Enabled = False
            grpTagStatusLogin.Visible = False

            grpReportReturn.Enabled = False
            grpReportReturn.Visible = False

            grpReturnDetails.Enabled = False
            grpReturnDetails.Visible = False
            '

            'Group box thats displaying the Tag information and Account information of the accessed account.
            txtLostTagStatus.Text = LostTagStatusAssign
            txtLostTagStatus.ReadOnly = True


            'Setting the initial index for the Removal Reason.
            cmbLostReason.SelectedIndex = 0
            '

            PlaceholderFunctionality()

        End If

    End Sub

    'Button Click Event that if clicked, logs the Customer/User into the Returned Tag Page where they can fill
    ' out their Returned Tag #, which Account # they are, and have a program-generated date of which they lost the tag.
    ' When those fields are full, the User/Customer can then send off his Returned Tag Report and it will also update his Account too.
    Private Sub btnLoginTagReturn_Click(sender As Object, e As EventArgs) Handles btnLoginTagReturn.Click


        'Subroutine that re-verifies the Account Number of the Customer that the user is trying to reach.
        EnterAccountInputBox()

        'Checking to see if there is a tag assigned or not. If no tag exists, the user cant use this page because its for reporting tags
        ' that exists along with the user wants to return it or report it lost.
        NoTagExistsChecker()

        'If the Account Field is full on the login and a real Account Number, 
        ' the program generates the form where the User can send their lost Tag Report.
        If AcctFieldisFull = True Then

            Dim ReturnTagStatusAssign As String = "Unassigned"

            ReturnTagReport = True

            'Adds a New Entry into the ReturnedTagsInfo Data Table.
            Me.ReturnedTagsInfoBindingSource.AddNew()

            'Subroutine that generates the real-time date of which the User returned their tag.
            ReturnTagDateChanged()

            'Disables the visibility of the Login page once the VB Program verifies that the account field is full
            ' and the Account Number is real.
            grpTagStatusLogin.Enabled = False
            grpTagStatusLogin.Visible = False

            grpReportLost.Enabled = False
            grpReportLost.Visible = False

            'Group box thats displaying the Tag information and Account information of the accessed account.
            grpLostDetails.Enabled = False
            grpLostDetails.Visible = False

            txtReturnTagStatus.Text = ReturnTagStatusAssign
            txtReturnTagStatus.ReadOnly = True
            '

            'Setting the initial index for the Removal Reason.
            cmbReturnReason.SelectedIndex = 0
            '

            PlaceholderFunctionality()

        End If

    End Sub

    'Button Click event that if clicked, the user wants to try to exit the Form where they can return their tag, OR
    ' report their lost tag. They are prompted with a dialog box asking if they want to delete their request on the Page.

    ' If the user is on the Lost Tags portion of the Form and he hits the Back Button, they will delete their entry from 
    ' the LostTagsInfo Datatable. If the user is on the Returned Tags portion of the Form and he hits the Back Button,
    ' they will delete their entry fro the ReturnedTagsInfo Datatable.
    Private Sub btnBackStatus_Click(sender As Object, e As EventArgs) Handles btnBackStatus.Click

        Dim GoingBackMsg As Integer

        GoingBackMsg = MessageBox.Show("Going back deletes your current request. Do you wish to proceed?", "Going Back", MessageBoxButtons.OK, MessageBoxIcon.Question)


        If LostTagReport = True And GoingBackMsg = DialogResult.OK Then

            'Removes the Current Record from LostTagsInfo Datatable.
            LostTagsInfoBindingSource.RemoveCurrent()
            LostTagReport = False

        End If

        If ReturnTagReport = True And GoingBackMsg = DialogResult.OK Then

            'Removes the Current Record from the ReturnedTagsInfo Datatable.
            ReturnedTagsInfoBindingSource.RemoveCurrent()
            ReturnTagReport = False

        End If

        'Setting back the functions of the three group boxes for Lost and Return back to all true.
        grpTagStatusLogin.Enabled = True
        grpTagStatusLogin.Visible = True

        grpReportReturn.Enabled = True
        grpReportReturn.Visible = True

        grpReportLost.Enabled = True
        grpReportLost.Visible = True

        grpLostDetails.Enabled = True
        grpLostDetails.Visible = True

        grpReturnDetails.Enabled = True
        grpReturnDetails.Visible = True
        ''

    End Sub

    'Button Click Event, that if clicked, takes the User back to the Update Account Form.
    Private Sub BtnTagLoginBack_Click(sender As Object, e As EventArgs) Handles btnTagLoginBack.Click

        QuitInitiated = True

        Form3.Show()
        Me.Close()

    End Sub

    'Button Click Event, that if clicked, closes the current Form 5 (Tag Status) and opens up the Form where the
    ' user can now buy a new tag, if they have previously lost it, and decided to decline on the option of buying it
    ' when they first reported their tag had been lost.
    Private Sub BtnBuyTag_Click(sender As Object, e As EventArgs) Handles btnBuyTag.Click

        grpTagStatusLogin.Enabled = False

        Form6.Show()

    End Sub

    ''
    Private Sub BtnAssignTag_Click(sender As Object, e As EventArgs) Handles btnAssignTag.Click

        grpTagStatusLogin.Enabled = False

        Form7.Show()

    End Sub




    ''End of Comments for Form 5 of EzPass Database System Project''

End Class