
Public Class adminpage

    Private Sub exit_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exit_btn.Click
        login.Show()
        Me.Hide()

    End Sub

    Private Sub accountadmin_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles accountadmin_btn.Click
        myaccount.Show()
        Me.Hide()

    End Sub

    Private Sub addcashier_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addcashier_btn.Click
        addcashier.Show()
        Me.Hide()

     
    End Sub

    Private Sub editcashier_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editcashier_btn.Click
        editcashier.Show()
        Me.Hide()
    End Sub

    Private Sub deletecashier_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deletecashier_btn.Click
        deletecashier.Show()
        Me.Hide()

    End Sub

    Private Sub report_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles report_btn.Click
        salesreport.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Add_item.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        edit_item.Show()
        Me.Hide()

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        delete_item.Show()
        Me.Hide()
    End Sub
End Class