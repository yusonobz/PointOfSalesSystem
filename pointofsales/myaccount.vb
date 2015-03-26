Public Class myaccount
    Dim a As String
    Private Sub save_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save_btn.Click
        adminpage.Show()
        Me.Hide()

    End Sub

    Private Sub back_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles back_btn.Click
        adminpage.Show()
        Me.Hide()

    End Sub
    Public Sub genc()
        If userrbtn.Checked = True Then
            a = userrbtn.Text
        ElseIf passrbtn.Checked = True Then
            a = passrbtn.Text
        End If
    End Sub
    Private Sub myaccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class