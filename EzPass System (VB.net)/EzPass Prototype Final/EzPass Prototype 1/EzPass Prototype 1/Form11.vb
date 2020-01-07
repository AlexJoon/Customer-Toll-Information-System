Public Class Form11

    Dim AcctFieldisFull As Boolean = False

    Dim TagFocus As Boolean = False

    ''
    Dim QuitInitiated As Boolean = False

    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'EzPassDBSystem.CustomersToll' table. You can move, or remove it, as needed.
        Me.CustomersTollTableAdapter.Fill(Me.EzPassDBSystem.CustomersToll)

        'TODO: This line of code loads data into the 'EzPassDBSystem.CustomersInfo' table. You can move, or remove it, as needed.
        Me.CustomersInfoTableAdapter.Fill(Me.EzPassDBSystem.CustomersInfo)

    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        Form3.grpUpdateAcct.Enabled = True
        Form3.grpUpdateAcct.Visible = True
        Form3.txtAcctSearch.Clear()

        QuitInitiated = True

        Form3.Show()
        Me.Close()

    End Sub

    Private Sub Form11_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If QuitInitiated = True Then

            e.Cancel = False

        Else

            e.Cancel = True

        End If



    End Sub

    Sub TextFocusColor()

        If TagFocus = True Then

            txtTagSearch.BackColor = Color.LemonChiffon

        Else

            txtTagSearch.BackColor = Color.White

        End If

    End Sub

    Sub NoHighlightFocus()

        TagFocus = False

        txtTagSearch.BackColor = Color.White

    End Sub

    Private Sub txtTagSearch_GotFocus(sender As Object, e As EventArgs) Handles txtTagSearch.GotFocus

        TagFocus = True

        TextFocusColor()

    End Sub

    Sub CheckforEmptyField()

        Dim EmptyFieldMsg As Integer

        If txtTagSearch.Text = String.Empty Then


            AcctFieldisFull = False
            EmptyFieldMsg = MessageBox.Show("The Tag Search Field is empty. Try again.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            NoHighlightFocus()

        Else

            AcctFieldisFull = True

        End If

    End Sub

    'Subroutine that displays a dialog box to the Customer/Employee that the account they are trying to reach,
    'does not exist. And that they should try again with a valid Account Number.
    Sub PlateNotExist()

        Dim AccountMsg As Integer

        AccountMsg = MessageBox.Show("That Plate # does not exist! Please try again.", "Account Doesn't Exist", MessageBoxButtons.OK, MessageBoxIcon.Error)

        If AccountMsg = DialogResult.OK Then

            NoHighlightFocus()
            txtTagSearch.Clear()

        End If

    End Sub

    Sub AccountBalanceReminder()

        Dim GoodAcctStatus As String = "Good Standing"

        Dim BadAcctStatus As String = "Bad Standing"

        Dim GoodAccountBalance As String

        Dim BalanceChecker As Double

        Dim BadAccountBalance As String

        Dim BalanceThreshold As Double

        BalanceThreshold = 25

        GoodAccountBalance = "Your Account Balance is doing good." & vbCrLf & "You do not have to add more funds" & vbCrLf & "at this moment."

        BadAccountBalance = "Your Account Balance is getting low." & vbCrLf & " Please add more Funds."

        Double.TryParse(lblCurrentFunds.Text, BalanceChecker)

        If BalanceChecker > BalanceThreshold Then

            lblFundsReminder.Text = GoodAccountBalance
            lblAcctStatus.Text = GoodAcctStatus
            lblFundsReminder.ForeColor = Color.Green
            lblAcctStatus.ForeColor = Color.Green

        End If

        If BalanceThreshold > BalanceChecker Then

            lblFundsReminder.Text = BadAccountBalance
            lblAcctStatus.Text = BadAcctStatus
            lblFundsReminder.ForeColor = Color.Red
            lblAcctStatus.ForeColor = Color.Red

        End If

    End Sub

    Private Sub BtnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        CheckforEmptyField()

        btnAddFunds.BackColor = Color.AntiqueWhite

        Dim SearchTollRecord As String

        If AcctFieldisFull = True Then

            SearchTollRecord = txtTagSearch.Text

            'SQL Query Search for Specific Customer Accounts.
            Me.CustomersInfoTableAdapter.FillByPlateNumber(Me.EzPassDBSystem.CustomersInfo, SearchTollRecord)

            Me.CustomersTollTableAdapter.FillByPlateNumber(Me.EzPassDBSystem.CustomersToll, SearchTollRecord)

            If Me.CustomersTollTableAdapter.FillByPlateNumber(Me.EzPassDBSystem.CustomersToll, SearchTollRecord) = Nothing Then

                'The user stays on the login page without accessing the next part of the form due to the fact that
                ' they havent found a valid Account.
                grpTollsLogin.Enabled = True
                grpTollsLogin.Visible = True

                PlateNotExist()

            Else

                grpTollsLogin.Enabled = False
                grpTollsLogin.Visible = False

            End If

        End If

        AccountBalanceReminder()

    End Sub

    Sub BackToLoginReset()

        txtTagSearch.Clear()

        NoHighlightFocus()

        grpTollsLogin.Enabled = True
        grpTollsLogin.Visible = True

    End Sub
    Sub EmptyInputField()

        Dim EmptyFieldMsg As Integer

        EmptyFieldMsg = MessageBox.Show("The Funds field is empty!", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Error)

    End Sub

    Sub AddFunds()

        Dim FundsInputBox As String

        Dim AddedFunds As Double

        Dim DefaultValueSpace As String = " "

        Dim Cancelling As String = ""

        Dim CurrentFunds As Double

        Dim SuccessfulFund As Double

        FundsInputBox = InputBox("How much do you want to add to your Account Funds?", "Funding", DefaultValueSpace)

        Double.TryParse(lblCurrentFunds.Text, CurrentFunds)

        Double.TryParse(FundsInputBox, AddedFunds)

        If FundsInputBox = DefaultValueSpace Then

            EmptyInputField()

        ElseIf FundsInputBox = Cancelling Then

            Exit Sub

        Else

            CurrentFunds += AddedFunds

            SuccessfulFund = MessageBox.Show("Your Account has been funded successfully. Thank you!", "Funding", MessageBoxButtons.OK, MessageBoxIcon.Information)

            If SuccessfulFund = DialogResult.OK Then

                btnAddFunds.Enabled = False
                btnAddFunds.BackColor = Color.LightGray

                lblCurrentFunds.Text = CurrentFunds

                Me.Validate()
                Me.CustomersInfoBindingSource.EndEdit()
                Me.CustomersInfoTableAdapter.Update(Me.EzPassDBSystem)

            End If

        End If


    End Sub

    Private Sub BtnSecBack_Click(sender As Object, e As EventArgs) Handles btnSecBack.Click

        BackToLoginReset()

    End Sub

    Private Sub btnAddFunds_Click(sender As Object, e As EventArgs) Handles btnAddFunds.Click

        AddFunds()

    End Sub

End Class