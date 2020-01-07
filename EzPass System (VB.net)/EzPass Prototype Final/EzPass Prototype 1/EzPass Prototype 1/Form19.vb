Imports System.ComponentModel

Public Class Form19

    Dim AcctFieldisFull As Boolean = False

    Dim DigitCodeFocus As Boolean = False

    ''
    Dim QuitInitiated As Boolean = False



    Private Sub Form19_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'EzPassDBSystem.CustomersInfo' table. You can move, or remove it, as needed.
        Me.CustomersInfoTableAdapter.Fill(Me.EzPassDBSystem.CustomersInfo)

        'TODO: This line of code loads data into the 'EzPassDBSystem.TollCodes' table. You can move, or remove it, as needed.
        Me.TollCodesTableAdapter.Fill(Me.EzPassDBSystem.TollCodes)

        'TODO: This line of code loads data into the 'EzPassDBSystem.EmployeeAccounts' table. You can move, or remove it, as needed.
        Me.EmployeeAccountsTableAdapter.Fill(Me.EzPassDBSystem.EmployeeAccounts)

    End Sub

    Private Sub Form19_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        If QuitInitiated = True Then

            e.Cancel = False

        Else

            e.Cancel = True

        End If

    End Sub

    Sub ReportAccessedTime()

        Dim AccessedTime As Date = Date.Now()

        lblAccessedTime.Text = AccessedTime

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

    Sub AccountNotExist()

        Dim AccountMsg As Integer

        AccountMsg = MessageBox.Show("That account does not exist! Please Try again.", "Account Doesn't Exist", MessageBoxButtons.OK, MessageBoxIcon.Error)

        If AccountMsg = DialogResult.OK Then

            txtDigitCode.Clear()

        End If

    End Sub

    Private Sub btnFirstBack_Click(sender As Object, e As EventArgs) Handles btnFirstBack.Click

        QuitInitiated = True

        Form12.Show()
        Me.Close()

    End Sub

    'Sub with a for-loop that has the running grand total for all clients.
    Sub GrandTotalClients()

        Dim ClientGrandSum As Double = 0

        For k As Integer = 0 To DatClientRevenue.Rows.Count - 1 Step +1

            ClientGrandSum = ClientGrandSum + DatClientRevenue.Rows(k).Cells(4).Value

        Next k

        lblGrandClientRevenue.Text = ClientGrandSum.ToString()

    End Sub

    'Sub with a for-loop that has the running grand total for all tolls.
    Sub GrandTotalTolls()

        Dim TollGrandSum As Double = 0

        For j As Integer = 0 To DatTollRevenue.Rows.Count - 1 Step +1

            TollGrandSum = TollGrandSum + DatTollRevenue.Rows(j).Cells(3).Value

        Next j

        lblGrandTollRevenue.Text = TollGrandSum.ToString()

    End Sub

    Private Sub btnEnterReports_Click(sender As Object, e As EventArgs) Handles btnEnterReports.Click

        CheckForEmptyAccountField() ' Subroutine that checks for empty text box fields.

        'The Account field contents are assigned to a Variable that is used for the SQL Query Search.
        Dim SearchDigitRecord As String

        If AcctFieldisFull = True Then

            ReportAccessedTime()

            SearchDigitRecord = txtDigitCode.Text

            ' SQL Query Search for that Account that was entered into the txtAcctSearch text field box.
            Me.EmployeeAccountsTableAdapter.FillByDigitCode(Me.EzPassDBSystem.EmployeeAccounts, SearchDigitRecord)

            GrandTotalClients()
            GrandTotalTolls()

            '' If the Account doesnt exist, the user does not get to go onto the next page of the form. 
            '' They will get prompted with an Error Message saying that they have entered a wrong Account #.
            If Me.EmployeeAccountsTableAdapter.FillByDigitCode(Me.EzPassDBSystem.EmployeeAccounts, SearchDigitRecord) = Nothing Then

                grpCredLogin.Enabled = True
                grpCredLogin.Visible = True

                AccountNotExist()

            Else

                grpCredLogin.Enabled = False
                grpCredLogin.Visible = False

            End If

        End If

    End Sub

    Private Sub btnSecondBack_Click(sender As Object, e As EventArgs) Handles btnSecondBack.Click

        QuitInitiated = True

        Form12.Show()
        Me.Close()

    End Sub

End Class