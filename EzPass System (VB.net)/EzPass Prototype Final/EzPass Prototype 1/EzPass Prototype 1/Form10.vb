Imports System.ComponentModel

Public Class Form10

    Dim AcctFieldisFull As Boolean = False

    Dim AccountFocus As Boolean = False

    Dim QuitInitiated As Boolean = False

    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'EzPassDBSystem.CustomersInfo' table. You can move, or remove it, as needed.
        Me.CustomersInfoTableAdapter.Fill(Me.EzPassDBSystem.CustomersInfo)

        AccountFocus = False

    End Sub

    Private Sub Form10_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        If QuitInitiated = True Then

            e.Cancel = False

        Else

            e.Cancel = True

        End If

    End Sub

    Sub TextFieldsVerify()

        Dim EmptyFieldsMsg As Integer

        Dim AccountFoundMsg As Integer

        If txtAcctSearch.Text = String.Empty Then

            EmptyFieldsMsg = MessageBox.Show("There are empty fields on the search. Please try again.", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else

            AccountFoundMsg = MessageBox.Show("Thank you! Checking to see if Account exists.", "Account Checking", MessageBoxButtons.OK, MessageBoxIcon.Information)

            AcctFieldisFull = True

        End If

    End Sub

    Sub TextBoxFocusColor()

        If AccountFocus = True Then

            txtAcctSearch.BackColor = Color.LemonChiffon

        Else

            AccountFocus = False
            txtAcctSearch.BackColor = Color.White

        End If

    End Sub

    Sub NoHighlightFocus()

        AccountFocus = False

        txtAcctSearch.BackColor = Color.White
        txtAcctSearch.Clear()

    End Sub

    Private Sub txtAcctSearch_GotFocus(sender As Object, e As EventArgs) Handles txtAcctSearch.GotFocus

        AccountFocus = True
        TextBoxFocusColor()

    End Sub

    Sub AccountNotExist()

        Dim AccountMsg As Integer

        AccountMsg = MessageBox.Show("That account does not exist. Please Try again.", "Account Doesn't Exist", MessageBoxButtons.OK, MessageBoxIcon.Error)

        If AccountMsg = DialogResult.OK Then

            NoHighlightFocus()

        End If

    End Sub

    Sub TagExistChecker()

        Dim NoTagExists As String

        Dim NoTagMsg As Integer

        NoTagExists = "N/A"

        If lblActiveTag.Text = NoTagExists Then

            NoTagMsg = MessageBox.Show("This account does not have a tag! Sorry!", "No Tag", MessageBoxButtons.OK, MessageBoxIcon.Information)

            If NoTagMsg = DialogResult.OK Then

                NoHighlightFocus()

                grpTagHelp.Enabled = True
                grpTagHelp.Visible = True

            End If

        Else

            grpTagHelp.Enabled = False
            grpTagHelp.Visible = False

        End If


    End Sub

    Sub AccountNumericDetect()

        Dim DetectMsg As Integer

        DetectMsg = MessageBox.Show("This field requires only numbers. Please re-enter this field again.", "Numbers Only", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

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

    Sub TollLoginEnabled()

        Form9.NoFocusColor()
        Form9.grpVerifyAcct.Enabled = True

    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        QuitInitiated = True

        TollLoginEnabled()
        Me.Close()

    End Sub

    Private Sub BtnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click

        TextFieldsVerify()

        Dim FindAcct As String

        If AcctFieldisFull = True Then

            FindAcct = txtAcctSearch.Text

            Me.CustomersInfoTableAdapter.FillByAccountNumber(Me.EzPassDBSystem.CustomersInfo, FindAcct)

            If Me.CustomersInfoTableAdapter.FillByAccountNumber(Me.EzPassDBSystem.CustomersInfo, FindAcct) = Nothing Then

                AccountNotExist()

                grpTagHelp.Enabled = True
                grpTagHelp.Visible = True

            Else

                TagExistChecker()

            End If

        End If

    End Sub

    Private Sub BtnSecBack_Click(sender As Object, e As EventArgs) Handles btnSecBack.Click

        QuitInitiated = True

        TollLoginEnabled()
        Me.Close()

    End Sub


End Class