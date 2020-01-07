Imports System.ComponentModel

Public Class Form12

    Dim SearchTollType As String

    Dim FilterTollInputBox As String

    Dim FilterDateInputBox As String

    Dim DefaultValueSpace As String = " "

    Dim Cancelling As String = ""

    Dim RadTollCodeSelected As Boolean = False

    Dim RadDateSelected As Boolean = False

    Dim TagFieldisFull = False

    Dim TagSearcher As String

    ''
    Dim TagFocus As Boolean = False

    ''
    Dim QuitInitiated As Boolean = False

    Private Sub Form12_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'EzPassDBSystem.CustomersToll' table. You can move, or remove it, as needed.
        Me.CustomersTollTableAdapter.Fill(Me.EzPassDBSystem.CustomersToll)

        RadAll.Checked = True
        RadDateToll.Checked = False
        RadTollCode.Checked = False

    End Sub

    Private Sub Form12_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        If QuitInitiated = True Then

            e.Cancel = False

        Else

            e.Cancel = True

        End If

    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        QuitInitiated = True

        Form2.grpDbLayout.Enabled = True

        Me.Close()

    End Sub

    Private Sub BtnRefund_Click(sender As Object, e As EventArgs) Handles btnRefund.Click

        QuitInitiated = True

        Form14.Show()
        Me.Close()

    End Sub

    Private Sub btnRevenue_Click(sender As Object, e As EventArgs) Handles btnRevenue.Click

        QuitInitiated = True

        Form19.Show()
        Me.Close()

    End Sub

    Sub TextFocusColor()

        If TagFocus = True Then

            txtTagSearch.BackColor = Color.LemonChiffon

        Else

            TagFocus = False
            txtTagSearch.BackColor = Color.White

        End If

    End Sub


    Sub NoHighlightFocus()

        TagFocus = False
        txtTagSearch.Clear()
        txtTagSearch.BackColor = Color.White

    End Sub


    Private Sub txtTagSearch_GotFocus(sender As Object, e As EventArgs) Handles txtTagSearch.GotFocus

        TagFocus = True

        TextFocusColor()

    End Sub

    Sub CheckForEmptyTagSearchField()

        Dim EmptyAccountFieldMsg As Integer

        ''If the Account Search textbox is empty, AcctFieldisFull Boolean is false and prevents the user to retrieve any records.
        If txtTagSearch.Text = String.Empty Then

            TagFieldisFull = False
            EmptyAccountFieldMsg = MessageBox.Show("You have not entered any Tags. Please try again.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Hand)


            RadAll.Checked = True

            '' If the Account Search textbox is filled with an Account #, AcctFieldisFull Boolean becomes true and user goes to next page.
        Else

            TagFieldisFull = True

        End If

    End Sub

    Sub TagNotExist()

        Dim TagMsg As Integer

        TagMsg = MessageBox.Show("That Tag does not exist. Please Try again.", "Tag Doesn't Exist", MessageBoxButtons.OK, MessageBoxIcon.Error)

        If TagMsg = DialogResult.OK Then

            Me.CustomersTollTableAdapter.Fill(Me.EzPassDBSystem.CustomersToll)
            NoHighlightFocus()
            RadAll.Checked = True

        End If

    End Sub

    Sub TagNumericDetect()

        Dim DetectMsg As Integer

        DetectMsg = MessageBox.Show("This field requires only numbers. Please re-enter the field again.", "Numbers Only", MessageBoxButtons.OK, MessageBoxIcon.Information)

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

    Private Sub btnTagSearch_Click(sender As Object, e As EventArgs) Handles btnTagSearch.Click

        CheckForEmptyTagSearchField()

        Dim TagCheckerMsg As Integer

        If TagFieldisFull = True Then

            TagCheckerMsg = MessageBox.Show("Checking for Tag..", "Tag Checking", MessageBoxButtons.OK, MessageBoxIcon.Information)

            If TagCheckerMsg = DialogResult.OK Then

                TagSearcher = txtTagSearch.Text

                Me.CustomersTollTableAdapter.FillByTagNumber(Me.EzPassDBSystem.CustomersToll, TagSearcher)

                NoHighlightFocus()

            End If

            If Me.CustomersTollTableAdapter.FillByTagNumber(Me.EzPassDBSystem.CustomersToll, TagSearcher) = Nothing Then

                TagNotExist()

            End If

        End If

    End Sub

    Private Sub RadAll_CheckedChanged(sender As Object, e As EventArgs) Handles RadAll.CheckedChanged

        Me.CustomersTollTableAdapter.Fill(Me.EzPassDBSystem.CustomersToll)

    End Sub

    Sub EmptyInputField()

        Dim EmptyFieldMsg As Integer

        EmptyFieldMsg = MessageBox.Show("That Search Field is Empty!", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Error)

    End Sub

    Sub DeleteAssurance()

        Dim DeleteMsg As Integer

        Dim DeleteSuccessMsg As Integer

        DeleteMsg = MessageBox.Show("Are you sure you want to delete this transaction from the records?", "Delete Transaction", MessageBoxButtons.YesNo, MessageBoxIcon.Stop)

        If DeleteMsg = DialogResult.Yes Then

            Me.Validate()

            CustomersTollBindingSource.RemoveCurrent()

            CustomersTollBindingSource.EndEdit()
            CustomersTollTableAdapter.Update(Me.EzPassDBSystem)

            DeleteSuccessMsg = MessageBox.Show("Transaction successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

    Private Sub btnDeleteTransaction_Click(sender As Object, e As EventArgs) Handles btnDeleteTransaction.Click

        DeleteAssurance()

    End Sub

    Private Sub RadDateToll_Click(sender As Object, e As EventArgs) Handles RadDateToll.Click

        RadDateSelected = True
        RadTollCodeSelected = False

        Dim DateNotExistMsg As Integer

        If RadDateSelected = True Then

            FilterDateInputBox = InputBox("What Date do you want to see?", "Tolled Date", DefaultValueSpace)

            If FilterDateInputBox = DefaultValueSpace Then

                EmptyInputField()

            ElseIf FilterDateInputBox = Cancelling Then

                RadDateSelected = False
                RadTollCodeSelected = False
                RadAll.Checked = True
                Exit Sub

            Else

                If Me.CustomersTollTableAdapter.FillByTolledDate(Me.EzPassDBSystem.CustomersToll, FilterDateInputBox) = Nothing Then

                    DateNotExistMsg = MessageBox.Show("That date isn't in the system! Please try again.", "No Date", MessageBoxButtons.OK, MessageBoxIcon.Stop)

                    If DateNotExistMsg = DialogResult.OK Then

                        Me.CustomersTollTableAdapter.Fill(Me.EzPassDBSystem.CustomersToll)
                        RadAll.Checked = True


                    End If

                Else

                    Me.CustomersTollTableAdapter.FillByTolledDate(Me.EzPassDBSystem.CustomersToll, FilterDateInputBox)


                End If

            End If

        End If

    End Sub

    Private Sub RadTollCode_Click(sender As Object, e As EventArgs) Handles RadTollCode.Click

        RadDateSelected = False
        RadTollCodeSelected = True

        Dim TollNotExistMsg As Integer

        If RadTollCodeSelected = True Then

            FilterTollInputBox = InputBox("What Toll Code do you want to see?", "Toll Code", DefaultValueSpace)

            If FilterTollInputBox = DefaultValueSpace Then

                EmptyInputField()

            ElseIf FilterTollInputBox = Cancelling Then

                RadDateSelected = False
                RadTollCodeSelected = False
                RadAll.Checked = True
                Exit Sub

            Else

                If Me.CustomersTollTableAdapter.FillByTollCode(Me.EzPassDBSystem.CustomersToll, FilterTollInputBox) = Nothing Then

                    TollNotExistMsg = MessageBox.Show("That Toll Code isn't in the system! Please try again.", "No Toll", MessageBoxButtons.OK, MessageBoxIcon.Stop)

                    If TollNotExistMsg = DialogResult.OK Then

                        Me.CustomersTollTableAdapter.Fill(Me.EzPassDBSystem.CustomersToll)
                        RadAll.Checked = True

                    End If

                Else

                    Me.CustomersTollTableAdapter.FillByTollCode(Me.EzPassDBSystem.CustomersToll, FilterTollInputBox)

                End If

            End If

        End If

    End Sub


End Class