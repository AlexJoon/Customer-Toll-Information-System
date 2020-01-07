Imports System.ComponentModel

Public Class Form18

    Dim SearchTollType As String

    Dim QuitInitiated As Boolean = False

    Private Sub Form18_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'EzPassDBSystem.TollCodes' table. You can move, or remove it, as needed.
        Me.TollCodesTableAdapter.Fill(Me.EzPassDBSystem.TollCodes)

        RadAll.Checked = True

    End Sub

    Private Sub Form18_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        If QuitInitiated = True Then

            e.Cancel = False

        Else

            e.Cancel = True

        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        QuitInitiated = True

        Form17.Show()
        Me.Close()

    End Sub

    Private Sub RadAll_CheckedChanged(sender As Object, e As EventArgs) Handles RadAll.CheckedChanged

        Me.TollCodesTableAdapter.Fill(Me.EzPassDBSystem.TollCodes)

    End Sub

    Private Sub RadBridges_CheckedChanged(sender As Object, e As EventArgs) Handles RadBridges.CheckedChanged

        SearchTollType = "Bridge"

        Me.TollCodesTableAdapter.FillByTollType(Me.EzPassDBSystem.TollCodes, SearchTollType)

    End Sub


    Private Sub RadTunnels_CheckedChanged(sender As Object, e As EventArgs) Handles RadTunnels.CheckedChanged

        SearchTollType = "Tunnel"

        Me.TollCodesTableAdapter.FillByTollType(Me.EzPassDBSystem.TollCodes, SearchTollType)


    End Sub

    Sub DeletionPrompt()

        Dim DeletionMsg As Integer

        Dim DeletionComplete As Integer

        DeletionMsg = MessageBox.Show("Are you sure you want to delete this toll?", "Toll Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Stop)

        If DeletionMsg = DialogResult.Yes Then

            DeletionComplete = MessageBox.Show("Toll successfully deleted.", "Deleted Toll", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.Validate()
            TollCodesBindingSource.RemoveCurrent()

            TollCodesBindingSource.EndEdit()
            TollCodesTableAdapter.Update(Me.EzPassDBSystem)

        End If

    End Sub

    Private Sub btnDeleteToll_Click(sender As Object, e As EventArgs) Handles btnDeleteToll.Click

        DeletionPrompt()

    End Sub


End Class