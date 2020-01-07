Imports System.ComponentModel

Public Class Form2

    ''Beginning of Comments for Form 2 EzPass Database System Project''
    ''Aleksey Przhevalskiy''

    Dim AcctFieldisFull As Boolean = False

    Dim UserNameFocus As Boolean = False

    Dim PasswordFocus As Boolean = False

    ''
    Dim QuitInitiated As Boolean = False

    Sub AccountFieldsClear()

        txtUsername.Clear()
        txtMaskPassword.Clear()

    End Sub

    'Preloads the Customer Information from the Access Database into Form 2 when Form 2 is loaded into the program.
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'EzPassDBSystem.EmployeeAccounts' table. You can move, or remove it, as needed.
        Me.EmployeeAccountsTableAdapter.Fill(Me.EzPassDBSystem.EmployeeAccounts)
        'TODO: This line of code loads data into the 'EzPassDBSystem.CustomersInfo' table. You can move, or remove it, as needed.
        Me.CustomersInfoTableAdapter.Fill(Me.EzPassDBSystem.CustomersInfo)

        'TODO: This line of code loads data into the 'EzPassDBSystem.CustomersInfo' table. You can move, or remove it, as needed.
        Me.CustomersInfoTableAdapter.Fill(Me.EzPassDBSystem.CustomersInfo)

        AccountFieldsClear()

    End Sub

    'Prevents the user from exiting via the red 'x' button. User has to quit application via Main Menu.
    Private Sub Form2_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        If QuitInitiated = True Then

            e.Cancel = False

        Else

            e.Cancel = True

        End If

    End Sub

    Sub LoginFocusReset()

        txtUsername.Clear()
        txtMaskPassword.Clear()

        txtUsername.BackColor = Color.White
        txtMaskPassword.BackColor = Color.White

        UserNameFocus = False
        PasswordFocus = False

    End Sub

    'Subroutine that displays a dialog box to the Customer/Employee that the account they are trying to reach,
    'does not exist. And that they should try again with a valid Account Number.
    Sub AccountNotExist()

        Dim AccountMsg As Integer

        AccountMsg = MessageBox.Show("That Employee Account does not Exist! Please try again.", "Account Doesn't Exist", MessageBoxButtons.OK, MessageBoxIcon.Error)

        If AccountMsg = DialogResult.OK Then

            LoginFocusReset()

        End If

    End Sub

    Sub TextFocusColor()

        If UserNameFocus = True Then

            txtUsername.BackColor = Color.LemonChiffon

        Else

            UserNameFocus = False
            txtUsername.BackColor = Color.White

        End If

        If PasswordFocus = True Then


            txtMaskPassword.BackColor = Color.LemonChiffon

        Else

            PasswordFocus = False
            txtMaskPassword.BackColor = Color.White

        End If

    End Sub

    Private Sub txtUsername_GotFocus(sender As Object, e As EventArgs) Handles txtUsername.GotFocus

        UserNameFocus = True
        PasswordFocus = False

        TextFocusColor()

    End Sub

    Private Sub txtMaskPassword_GotFocus(sender As Object, e As EventArgs) Handles txtMaskPassword.GotFocus

        UsernameFocus = False
        PasswordFocus = True

        TextFocusColor()

    End Sub

    Sub EmployeeFieldFullValue()

        Dim EmptyFieldMsg As Integer

        If txtUsername.Text = String.Empty Or txtMaskPassword.Text = String.Empty Then

            EmptyFieldMsg = MessageBox.Show("There are empty fields! Fill them in.", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Information)
            AcctFieldisFull = False

            LoginFocusReset()

        Else

            AcctFieldisFull = True

        End If

    End Sub

    'Subroutine made for Employee Login Credentials (Me), to add a small level of security before entering the Entire Database
    ' inside the VB Program. If the Username AND OR password are incorrect, the Employee will be prompted with a dialog box
    ' stating that there is incorrect Login Credentials inside the text fields.
    Sub LoginUserAndPassCredentials()

        Dim SearchUsername As String

        Dim SearchPassword As String

        EmployeeFieldFullValue()

        If AcctFieldisFull = True Then

            SearchUsername = txtUsername.Text

            SearchPassword = txtMaskPassword.Text

            Me.EmployeeAccountsTableAdapter.FillByUsername(Me.EzPassDBSystem.EmployeeAccounts, SearchUsername)

            Me.EmployeeAccountsTableAdapter.FillByPassword(Me.EzPassDBSystem.EmployeeAccounts, SearchPassword)

            If Me.EmployeeAccountsTableAdapter.FillByUsername(Me.EzPassDBSystem.EmployeeAccounts, SearchUsername) = Nothing Or Me.EmployeeAccountsTableAdapter.FillByPassword(Me.EzPassDBSystem.EmployeeAccounts, SearchPassword) = Nothing Then

                AccountNotExist()

                grpLoginScreen.Enabled = True
                grpLoginScreen.Visible = True

                AcctFieldisFull = False

            Else

                grpLoginScreen.Enabled = False
                grpLoginScreen.Visible = False

            End If

        End If

    End Sub

    'Button Click event, if this Login Button is clicked, the LoginUserAndPassCredentials Subroutine will execute.
    ' If the Login credentials (LoginUsername & LoginPassword) are correct, the Program will take the Employee to the 
    ' EzPass Database datagrid.
    Private Sub btnLoginEnter_Click(sender As Object, e As EventArgs) Handles btnLoginEnter.Click

        LoginUserAndPassCredentials()

    End Sub

    'This Private Sub Button Click event handles the clearing of the text boxes on the Form 2 Employee Login Screen.
    Private Sub btnLoginClear_Click(sender As Object, e As EventArgs) Handles btnLoginClear.Click

        LoginFocusReset()

    End Sub

    Private Sub btnEmployeeReg_Click(sender As Object, e As EventArgs) Handles btnEmployeeReg.Click

        LoginFocusReset()

        Form20.Show()
        grpLoginScreen.Enabled = False

    End Sub

    'Handles the exiting of the EzPass Program via the Exit button. Prompts the User with a dialog box if they want to close.
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExitProgram.Click

        QuitInitiated = True

        Dim ExitSelected As Integer

        ExitSelected = MessageBox.Show("Are you sure you want to exit?", "Exiting...", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If ExitSelected = DialogResult.Yes Then

            Form1.Show()
            Me.Close()

        End If

    End Sub

    'Button that handles the clearing of the various text fields inside the TabEntries Tab Page Box. 
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClearField.Click

        'If the Tab Index = 0 (Customers Tab is open).
        If TabEntries.SelectedIndex = 0 Then

            'Clearing the Fields for the Customers Tab Page.
            txtFirstName.Clear()
            txtLastName.Clear()
            txtEmail.Clear()
            txtAddress.Clear()
            txtDOB.Clear()
            txtPhone.Clear()
            txtSignUp.Clear()
            ''
        End If

        'If The Tab Index = 1 (Accounts Tab is open).
        If TabEntries.SelectedIndex = 1 Then

            'Clearing the Fields for the Accounts Tab Page.
            txtPlateNbr.Clear()
            cmbEmBodyStyle.SelectedIndex = 0
            cmbEmModel.SelectedIndex = 0
            cmbEmYear.SelectedIndex = 0
            txtAddDate.Clear()
            txtRemovalDate.Clear()
            ''
        End If

        'If the Tab Index = 2 (Tags Tab is open).
        If TabEntries.SelectedIndex = 2 Then

            'Clearing The Fields for the Tags Tab Page.
            txtTagNbr.Clear()
            txtTagDateAssign.Clear()
            cmbTagStatus.SelectedIndex = 0
            ''

        End If

        'If the Tab Index = 3 (Account Tags Tab is open).
        If TabEntries.SelectedIndex = 3 Then

            'Clearing the Fields for the Account Tags Tab Page.
            txtTagAcct.Clear()
            txtAcctBalance.Clear()
            cmbStanding.SelectedIndex = 0
            ''

        End If

    End Sub

    '' Adds the information from the text box fields in each respective Tab Page.
    '' For example, when customers tab page is open, fill out the fields and it press add, 
    '' it will add that data to the data table and to the access database at the same moment.
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        CustomersInfoBindingSource.AddNew()

    End Sub

    ' Button Event that if this button is clicked, the current Position of the datagrid will move to the 
    ' Next record(moving descending order).
    Private Sub BtnNextRecord_Click(sender As Object, e As EventArgs) Handles btnNextRecord.Click

        CustomersInfoBindingSource.MoveNext()

    End Sub

    'Button Event that if this button is clicked, the current Position of the record in the datagrid will remove that 
    ' current record from the Datagrid on the VB Program and in the Access Database.
    Private Sub BtnDeleteRecord_Click(sender As Object, e As EventArgs) Handles btnDeleteRecord.Click

        CustomersInfoBindingSource.RemoveCurrent()

    End Sub

    'Button Event that if this button is clicked, the current Position of the record in the datagrid will move up to the 
    ' previous record in Ascending Order.
    Private Sub BtnPreviousRecord_Click(sender As Object, e As EventArgs) Handles btnPreviousRecord.Click

        CustomersInfoBindingSource.MovePrevious()

    End Sub

    'Button Click event that if this button is pressed, the user will be prompted with a dialog box asking if they want to
    ' exit this form and go back to the Form 1 Portal Login, if yes, then this Form2 will close.
    Private Sub btnLoginExit_Click(sender As Object, e As EventArgs) Handles btnLoginExit.Click

        QuitInitiated = True

        Form1.Show()
        Me.Close()

    End Sub

    ''
    Sub BalanceNumericDetect()

        Dim DetectMsg As Integer

        DetectMsg = MessageBox.Show("This field requires only numbers. Please re-enter the field again.", "Numbers Only", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    ''
    Private Sub txtAcctBalance_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAcctBalance.KeyPress

        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = ChrW(Keys.Back) Then

            e.Handled = True
            BalanceNumericDetect()

        End If

    End Sub


    'Subroutine made for a dialog box to prompt to the user that the Database was not saved correctly and there is a error.
    Sub DatabaseNotProperlySaved()

        Dim DatabaseNotSavedMsg As Integer
        DatabaseNotSavedMsg = MessageBox.Show("The Database was not correctly saved.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

    End Sub

    ' Subroutine made for a dialog box to prompt to the user that the Database was correctly updated and there aren't any errors.
    Sub DatabaseSavedSuccessful()

        Dim DatabaseSavedSuccessMsg As Integer
        DatabaseSavedSuccessMsg = MessageBox.Show("Update Successful.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.None)

    End Sub

    'Button click event that handles the updating of the Database if any changes were made by the Employee to the 
    ' customer information. A Try/Catch was used here because if the updating of the database was successful,
    ' the program would execute the Try. If there was an error when updating, The Try will go instantly to the Catch.
    Private Sub BtnUpdateField_Click(sender As Object, e As EventArgs) Handles btnUpdateField.Click

        Try

            ' Validates the connection of the Vb program and the Access Database then proceeds to update the new info into the database.
            Me.Validate()
            CustomersInfoBindingSource.EndEdit()
            CustomersInfoTableAdapter.Update(Me.EzPassDBSystem)
            '

            DatabaseSavedSuccessful() ' Dialog Box stating that the information was correctly updated.

        Catch

            DatabaseNotProperlySaved() ' Dialog Box stating that the Information was not correctly updated.

        End Try

    End Sub

    ' Button Click Event that will take the Employee into the Form 4. The Form 4 is where the Employee can see 
    ' which Accounts have been returning their tags back and which Accounts have lost their tag. More will be explained
    ' on the Form 4 code page.
    Private Sub BtnTagMonitor_Click(sender As Object, e As EventArgs) Handles btnTagMonitor.Click

        grpDbLayout.Enabled = False

        Form4.Show()

    End Sub

    Private Sub BtnTollMonitor_Click(sender As Object, e As EventArgs) Handles btnTollMonitor.Click

        grpDbLayout.Enabled = False

        Form12.Show()

    End Sub

    Private Sub BtnUpdateTolls_Click(sender As Object, e As EventArgs) Handles btnUpdateTolls.Click

        grpDbLayout.Enabled = False

        Form17.Show()

    End Sub

    ''End of Comments for Form 2 EzPass Database System Project.''

End Class
