Imports System.Data.SqlClient

Public Class login
    Dim con As SqlConnection = New SqlConnection("Data Source=RONNEL\SQLEXPRESS; Database=db_point_of_sales; Trusted_Connection =yes;")
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim dr As SqlDataReader
    Dim a As String
   
    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
    End Sub
  

    Private Sub login_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles login_btn.Click
      
        If adm_rbtn.Checked = True Then
            fradm()
            admin_idtxt.Clear()
            pas_admintxt.Clear()
        ElseIf cash_rbtn.Checked = True Then
            Dim OBJ As New cashierpage
            OBJ.StringPass = admin_idtxt.Text
            OBJ.Show()
            Me.Hide()
            frcash()
            admin_idtxt.Clear()
            pas_admintxt.Clear()
           
        End If
       
    End Sub
    Public Sub fradm()
        If admin_idtxt.Text = "" Or pas_admintxt.Text = "" Then
            MsgBox("Enter your ID and Password")
        Else
            con.Close()
            Try
                con.Open()
            Catch myerror As SqlException
                MsgBox("Error Connecting to Database. Please Try again !")
            End Try
            cmd = New SqlCommand("Select * From tbl_admin where username = '" + admin_idtxt.Text + "' and password='" + pas_admintxt.Text + "'", con)
            da = New SqlDataAdapter(cmd)
            ds = New DataSet()
            cmd.Connection = con
            da.SelectCommand = cmd
            Dim mydata As SqlDataReader
            mydata = cmd.ExecuteReader
            If mydata.HasRows = 0 Then
                MsgBox("Invalid login")
            Else
                adminpage.Show()
                Me.Hide()
            End If
        End If
    End Sub
    Public Sub frcash()
        If admin_idtxt.Text = "" Or pas_admintxt.Text = "" Then
            MsgBox("Enter your ID and Password")
        Else
            con.Close()
            Try
                con.Open()
            Catch myerror As SqlException
                MsgBox("Error Connecting to Database. Please Try again !")
            End Try
            cmd = New SqlCommand("Select * From tbl_cashier where fname = '" + admin_idtxt.Text + "' and password='" + pas_admintxt.Text + "'", con)
            da = New SqlDataAdapter(cmd)
            ds = New DataSet()
            cmd.Connection = con
            da.SelectCommand = cmd
            Dim mydata As SqlDataReader
            mydata = cmd.ExecuteReader
            If mydata.HasRows = 0 Then
                MsgBox("Invalid login")
            Else
              
            End If
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        month_cb.Show()
        Me.Hide()
    End Sub

    Private Sub exit_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exit_btn.Click

    End Sub

    Private Sub admin_idtxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles admin_idtxt.TextChanged

    End Sub
End Class
