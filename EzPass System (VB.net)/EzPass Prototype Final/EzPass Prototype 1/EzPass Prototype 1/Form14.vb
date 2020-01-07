Imports System.ComponentModel

Public Class Form14

    'Fare Prices that were deducted to Accounts and the Current Account Balance.

    Dim CurrentBalance As Double

    Dim EzPassRefund As Double

    'Tag text field checker boolean.
    Dim AcctFieldIsFull As Boolean = False

    Dim YesSelected As Boolean = False

    Dim TagFocus As Boolean = False

    Dim QuitInitiated As Boolean = False

    Private Sub Form14_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EzPassDBSystem.TollCodes' table. You can move, or remove it, as needed.
        Me.TollCodesTableAdapter.Fill(Me.EzPassDBSystem.TollCodes)

        'TODO: This line of code loads data into the 'EzPassDBSystem.CustomersInfo' table. You can move, or remove it, as needed.
        Me.CustomersInfoTableAdapter.Fill(Me.EzPassDBSystem.CustomersInfo)

        lblAcctBal.Enabled = False
        lblAcctBal.Visible = False

        txtAcctBal.Enabled = False
        txtAcctBal.Visible = False

        btnProcess.Enabled = False
        btnProcess.BackColor = Color.LightGray

    End Sub

    Private Sub Form14_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

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

            TagFocus = False
            txtTagSearch.BackColor = Color.White

        End If

    End Sub

    Sub LoginFocusReset()

        TagFocus = False

        txtTagSearch.BackColor = Color.White

        txtTagSearch.Clear()

    End Sub

    Private Sub txtTagSearch_GotFocus(sender As Object, e As EventArgs) Handles txtTagSearch.GotFocus

        TagFocus = True
        TextFocusColor()

    End Sub

    Sub EmptyTagField()

        Dim EmptyAcctFieldMsg As Integer

        If txtTagSearch.Text = String.Empty Then

            AcctFieldIsFull = False
            EmptyAcctFieldMsg = MessageBox.Show("The Tag field is empty. Try again.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoginFocusReset()

        Else

            AcctFieldIsFull = True

        End If

    End Sub

    Sub TagNotExist()

        Dim TagNotExistMsg As Integer

        TagNotExistMsg = MessageBox.Show("That Tag does not exist. Try Again.", "Tag Doesn't Exist", MessageBoxButtons.OK, MessageBoxIcon.Error)

        If TagNotExistMsg = DialogResult.OK Then

            LoginFocusReset()

        End If

    End Sub

    Sub TagNumericDetect()

        Dim DetectMsg As Integer

        DetectMsg = MessageBox.Show("This field requires only numbers. Please try again!", "Numbers Only", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

        If DetectMsg = DialogResult.OK Then

            txtTagSearch.Clear()

        End If

    End Sub

    Private Sub txtTagSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTagSearch.KeyPress

        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = ChrW(Keys.Back) Then

            e.Handled = True
            TagNumericDetect()

        End If

    End Sub

    Private Sub BtnEnterRefund_Click(sender As Object, e As EventArgs) Handles btnEnterRefund.Click

        EmptyTagField()

        Dim SearchTagAccount As String

        If AcctFieldIsFull = True Then

            SearchTagAccount = txtTagSearch.Text

            Me.CustomersInfoTableAdapter.FillByTagNumber(Me.EzPassDBSystem.CustomersInfo, SearchTagAccount)

            If Me.CustomersInfoTableAdapter.FillByTagNumber(Me.EzPassDBSystem.CustomersInfo, SearchTagAccount) = Nothing Then

                grpRefundLogin.Enabled = True
                grpRefundLogin.Visible = True

                TagNotExist() 'subroutine dialog box that displays to the user that this account doesn't exist.

            Else

                grpRefundLogin.Enabled = False
                grpRefundLogin.Visible = False

            End If

        End If

    End Sub

    Private Sub BtnFirstBack_Click(sender As Object, e As EventArgs) Handles btnFirstBack.Click

        QuitInitiated = True

        Form12.Show()
        Me.Close()

    End Sub

    Private Sub btnSecondBack_Click(sender As Object, e As EventArgs) Handles btnSecondBack.Click

        QuitInitiated = True

        Form12.Show()
        Me.Close()

    End Sub

    Sub FareDiscount()

        Dim TollFare As Double

        Dim EzPassDiscount As Double

        Dim EzPassDifference

        EzPassDiscount = 32 / 100

        Double.TryParse(txtFareDeduct.Text, TollFare)

        EzPassDifference = TollFare * EzPassDiscount

        txtFareDiscounted.Text = TollFare - EzPassDifference

    End Sub

    Sub AccountRefundedSuccessfully()

        Dim RefundSuccessMsg As Integer

        RefundSuccessMsg = MessageBox.Show("The Account has been refunded. Closing window now.", "Account Refunded", MessageBoxButtons.OK, MessageBoxIcon.Information)

        If RefundSuccessMsg = DialogResult.OK Then

            QuitInitiated = True

            Form2.grpDbLayout.Enabled = True

            Me.Close()

        End If

    End Sub

    Sub AccountBalanceDisplay()

        lblAcctBal.Enabled = True
        lblAcctBal.Visible = True

        txtAcctBal.Enabled = True
        txtAcctBal.Visible = True

        Double.TryParse(txtAcctBal.Text, CurrentBalance)

        Double.TryParse(txtFareDiscounted.Text, EzPassRefund)

        If YesSelected = False Then

            txtAcctBal.Text = CurrentBalance + EzPassRefund
            YesSelected = True

        End If

    End Sub

    Private Sub txtFareDeduct_TextChanged(sender As Object, e As EventArgs) Handles txtFareDeduct.TextChanged

        FareDiscount()

    End Sub

    Sub NoSelected()

        lblAcctBal.Enabled = False
        lblAcctBal.Visible = False

        txtAcctBal.Enabled = False
        txtAcctBal.Visible = False

        btnProcess.BackColor = Color.LightGray
        btnProcess.Enabled = False

    End Sub

    Private Sub DatTollFares_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DatTollFares.CellClick

        RadYes.Checked = False
        RadNo.Checked = False

        NoSelected()

    End Sub

    Private Sub RadYes_CheckedChanged(sender As Object, e As EventArgs) Handles RadYes.CheckedChanged

        AccountBalanceDisplay()

        btnProcess.Enabled = True
        btnProcess.BackColor = Color.LightGreen

    End Sub

    Private Sub RadNo_CheckedChanged(sender As Object, e As EventArgs) Handles RadNo.CheckedChanged

        NoSelected()

    End Sub

    Private Sub btnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click

        If RadYes.Checked = True Then

            Me.Validate()
            Me.CustomersInfoBindingSource.EndEdit()
            Me.CustomersInfoTableAdapter.Update(Me.EzPassDBSystem)

            AccountRefundedSuccessfully()

        End If

    End Sub

End Class