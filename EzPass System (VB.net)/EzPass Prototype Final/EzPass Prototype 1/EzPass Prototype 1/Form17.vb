Imports System.ComponentModel

Public Class Form17

    Dim QuitInitiated As Boolean = False

    Private Sub Form17_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        If QuitInitiated = True Then

            e.Cancel = False

        Else

            e.Cancel = True

        End If

    End Sub

    Private Sub btnGoNewToll_Click(sender As Object, e As EventArgs) Handles btnGoNewToll.Click

        QuitInitiated = True

        Form16.Show()
        Me.Close()

    End Sub

    Private Sub btnGoUpdateToll_Click(sender As Object, e As EventArgs) Handles btnGoUpdateToll.Click

        QuitInitiated = True

        Form15.Show()
        Me.Close()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        QuitInitiated = True

        Form2.grpDbLayout.Enabled = True

        Me.Close()

    End Sub

    Private Sub btnGoTollDescription_Click(sender As Object, e As EventArgs) Handles btnGoTollDescription.Click

        QuitInitiated = True

        Form18.Show()
        Me.Close()

    End Sub



End Class