Imports System.ComponentModel

Public Class Form4

    ''Beginning of Comments for Form 4 of EzPass Database System Project''
    ''Aleksey Przhevalskiy''

    ''
    Public FromEmployeeAssign As Boolean = False

    Dim AcctFieldisFull = False

    Dim DigitCodeFocus As Boolean = False

    Dim QuitInitiated As Boolean = False

    Sub ReportAccessedTime()

        Dim AccessedTime As Date = Date.Now()

        lblAccessTime.Text = AccessedTime

    End Sub

    'Preloads the ReturnedTagsInfo & LostTagsInfo Data tables from Access to the VB Program when Form 4 is loaded.
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'EzPassDBSystem.ReturnedTagsInfo' table. You can move, or remove it, as needed.
        Me.ReturnedTagsInfoTableAdapter.Fill(Me.EzPassDBSystem.ReturnedTagsInfo)

        'TODO: This line of code loads data into the 'EzPassDBSystem.LostTagsInfo' table. You can move, or remove it, as needed.
        Me.LostTagsInfoTableAdapter.Fill(Me.EzPassDBSystem.LostTagsInfo)

        'TODO: This line of code loads data into the 'EzPassDBSystem.EmployeeAccounts' table. You can move, or remove it, as needed.
        Me.EmployeeAccountsTableAdapter.Fill(Me.EzPassDBSystem.EmployeeAccounts)


        ''
        ReportAccessedTime()

        '' When the form is loaded, the tab pages are at 0, so the 'Set Avaliable' button is not visible or enabled.
        btnSetTagAvb.Enabled = False
        btnSetTagAvb.Visible = False

    End Sub

    Private Sub Form4_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        If QuitInitiated = True Then

            e.Cancel = False

        Else

            e.Cancel = True

        End If

    End Sub

    ''
    Private Sub btnFirstBack_Click(sender As Object, e As EventArgs) Handles btnFirstBack.Click

        QuitInitiated = True

        Form2.grpDbLayout.Enabled = True

        Me.Close()

    End Sub

    ''
    Sub CheckForEmptyAccountField()

        Dim EmptyAccountFieldMsg As Integer

        ''If the Account Search textbox is empty, AcctFieldisFull Boolean is false and prevents the user to retrieve any records.
        If txtDigitCode.Text = String.Empty Then

            AcctFieldisFull = False
            EmptyAccountFieldMsg = MessageBox.Show("You have not entered any Digit Codes! Please try again.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Hand)

            '' If the Account Search textbox is filled with an Account #, AcctFieldisFull Boolean becomes true and user goes to next page.
        Else

            AcctFieldisFull = True

        End If

    End Sub

    Sub AccountNumericDetect()

        Dim DetectMsg As Integer

        DetectMsg = MessageBox.Show("This field requires only numbers. Please try again!", "Numbers Only", MessageBoxButtons.OK, MessageBoxIcon.Information)

        If DetectMsg = DialogResult.OK Then

            txtDigitCode.Clear()

        End If

    End Sub

    Private Sub txtDigitCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDigitCode.KeyPress


        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = ChrW(Keys.Back) Then

            e.Handled = True
            AccountNumericDetect()

        End If

    End Sub

    'Subroutine that was made to display a dialog box to the user if the account they are trying to reach, does not exist.
    'This subroutine is to be used inside the Search Button Click Event.
    Sub AccountNotExist()

        Dim AccountMsg As Integer

        AccountMsg = MessageBox.Show("That account does not exist! Please Try again.", "Account Doesn't Exist", MessageBoxButtons.OK, MessageBoxIcon.Error)

        If AccountMsg = DialogResult.OK Then

            txtDigitCode.Clear()

        End If

    End Sub

    Sub TextFocusColor()

        If DigitCodeFocus = True Then

            txtDigitCode.BackColor = Color.LemonChiffon

        Else

            DigitCodeFocus = False
            txtDigitCode.BackColor = Color.White

        End If

    End Sub

    Private Sub txtDigitCode_GotFocus(sender As Object, e As EventArgs) Handles txtDigitCode.GotFocus

        DigitCodeFocus = True
        TextFocusColor()

    End Sub

    Private Sub btnEnterReports_Click(sender As Object, e As EventArgs) Handles btnEnterReports.Click

        CheckForEmptyAccountField() ' Subroutine that checks for empty text box fields.

        'The Account field contents are assigned to a Variable that is used for the SQL Query Search.
        Dim SearchDigitRecord As String

        If AcctFieldisFull = True Then

            SearchDigitRecord = txtDigitCode.Text

            ' SQL Query Search for that Account that was entered into the txtAcctSearch text field box.
            Me.EmployeeAccountsTableAdapter.FillByDigitCode(Me.EzPassDBSystem.EmployeeAccounts, SearchDigitRecord)

            '' If the Account doesnt exist, the user does not get to go onto the next page of the form. 
            '' They will get prompted with an Error Message saying that they have entered a wrong Account #.
            If Me.EmployeeAccountsTableAdapter.FillByDigitCode(Me.EzPassDBSystem.EmployeeAccounts, SearchDigitRecord) = Nothing Then

                grpCredLogin.Enabled = True
                grpCredLogin.Visible = True

                AccountNotExist()

            Else

                grpCredLogin.Enabled = False
                grpCredLogin.Visible = False

                FromEmployeeAssign = False

            End If

        End If

    End Sub

    'Button Click Event that closes this 'Tag Monitoring' Form and gives the User focus back to the EzPass
    ' Employee Database.
    Private Sub btnSecondBack_Click(sender As Object, e As EventArgs) Handles btnSecondBack.Click

        QuitInitiated = True

        Form2.grpDbLayout.Enabled = True

        Me.Close()

    End Sub

    'This Private Sub was added for a design feature of the Form 4. If The Tab Page box index is 0, the Button
    ' That lets the Employee add a new tag to an account (for a $ 25 deduction fee) will become enabled and visible.
    ' If the Tab Page box index is 1, the Button that sets Returned Tags avaliable for others to use, becomes enabled and visible.
    Private Sub TabTagStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabTagStatus.SelectedIndexChanged

        If TabTagStatus.SelectedIndex = 0 Then

            btnSetTagAvb.Enabled = False
            btnSetTagAvb.Visible = False

            btnAssignNewTag.Enabled = True
            btnAssignNewTag.Visible = True

        End If

        If TabTagStatus.SelectedIndex = 1 Then

            btnAssignNewTag.Enabled = False
            btnAssignNewTag.Visible = False

            btnSetTagAvb.Enabled = True
            btnSetTagAvb.Visible = True


        End If

    End Sub

    'Subroutine made for a dialog box to prompt to the user that the Database was saved correctly and there are no errors.
    Sub SaveDatabaseMsg()

        Dim DatabaseMsg As Integer

        DatabaseMsg = MessageBox.Show("The Database has been successfully saved.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub


    'Subroutine made for a dialog box to prompt to the user that the Database was not saved correctly and there is a error.
    Sub DatabaseNotSavedMsg()

        Dim NotSavedMsg As Integer

        NotSavedMsg = MessageBox.Show("The Database was not saved correctly. There is an error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

    End Sub

    'Subroutine made in relation to the Tab Page Box Indexes. If the Selected Index is 0, it will save and update the 
    ' information (Lost Tags) in the Datagrid to the Database in the Access File. If the Selected Index is 1,
    ' it will save and update the information (Returned Tags) in the Datagrid to the Database in the Access File.
    Sub SaveDataTabs()

        If TabTagStatus.SelectedIndex = 0 Then

            Me.Validate()
            Me.LostTagsInfoBindingSource.EndEdit()
            Me.LostTagsInfoTableAdapter.Update(Me.EzPassDBSystem)

            Try

                SaveDatabaseMsg() 'Subroutine that holds the dialog box stating that the Account was correctly Saved.

            Catch ex As Exception

                DatabaseNotSavedMsg() 'Subroutine that holds the dialog box stating that the Account was not Saved.

            End Try

        End If

        If TabTagStatus.SelectedIndex = 1 Then

            Me.Validate()
            Me.ReturnedTagsInfoBindingSource.EndEdit()
            Me.ReturnedTagsInfoTableAdapter.Update(Me.EzPassDBSystem)

            Try

                SaveDatabaseMsg() 'Subroutine that holds the dialog box stating that the Account was correctly Saved.

            Catch ex As Exception

                DatabaseNotSavedMsg() 'Subroutine that holds the dialog box stating that the Account was not Saved.

            End Try

        End If

    End Sub

    'Subroutine made to prompt a dialog box to the EzPass Employee that the tag has been successfully returned,
    ' for other customer accounts to use that tag.
    Sub TagReturned()

        Dim TagReturnedMsg As Integer

        TagReturnedMsg = MessageBox.Show("The tag has been successfully returned for customers to use.", "Returned Tag", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    'Subroutine made to prompt the Employee if they would like to assign that Returned Tag account, a new tag.
    'If the Employee clicks Yes in the dialog box, Form 7 will appear where they can assign the Tag to the Account,
    ' at a No Cost Fee, since they had not lost the tag prior.
    Sub ClientAssignNewTag()

        Dim NewTagMsg As Integer

        NewTagMsg = MessageBox.Show("Would you like to assign that account a new tag?", "New Tag", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If NewTagMsg = DialogResult.Yes Then

            Form7.Show()

        End If

    End Sub

    'Button Click event that opens up Form 6 where the Customer and Employee can assign a new Tag if that Account
    ' had lost the tag. (For a $ 25 Deduction Fee)
    Private Sub BtnAssignNewTag_Click(sender As Object, e As EventArgs) Handles btnAssignNewTag.Click

        FromEmployeeAssign = True

        If FromEmployeeAssign = True Then

            grpReportedTags.Enabled = False
            Form6.Show()

        End If

    End Sub

    'Button Click Event that removes the entry of a Returned Tag in the Datatable and then prompting the Employee
    'whether they want to add a new tag to that account. (Returned Tags from Customers come at No Cost Fee since
    ' they did not lose the tag).
    Private Sub BtnSetTagAvb_Click(sender As Object, e As EventArgs) Handles btnSetTagAvb.Click

        TagReturned() 'Subroutine Dialog box stating that the Tag was successfully returned.

        ''Removing the Entry of the Returned Tag and Acct # and placing the Tag back avaliable for other customers to be assigned.
        ReturnedTagsInfoBindingSource.RemoveCurrent()

        ClientAssignNewTag() 'Subroutine Dialog box that prompts the user if they want to add a new Tag to the Account

    End Sub

    'Button Click Event that saves and updates the Tag Monitoring Table of the Access Database file.
    'All new information about Lost & Returned Tags entered will be carried over to the Database.
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        SaveDataTabs()

    End Sub

    ''End of Comments for Form 4 Of EzPass Database System Project.''

End Class