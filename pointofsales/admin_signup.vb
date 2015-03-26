Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class month_cb
    Dim con As SqlConnection = New SqlConnection("Data Source=RONNEL\SQLEXPRESS; Database=db_point_of_sales; Trusted_Connection =yes;")
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim dr As SqlDataReader
    Dim a As String
    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lnametx.TextChanged

    End Sub
    Public Sub add_admin()
        cmd = New SqlCommand("Insert Into tbl_admin Values ('" + adid.Text + "','" + usern.Text + "','" + pass.Text + "', '" + fnametx.Text + "', '" + mnametx.Text + "', '" + lnametx.Text + "', '" + mot_cb.Text + "', '" + day_cb.Text + "', '" + year_cb.Text + "', '" + a + "','" + emailtx.Text + "', '" + baranggay.Text + "', '" + street.Text + "', '" + city.Text + "')", con)
        da = New SqlDataAdapter(cmd)
        ds = New DataSet()
        da.Fill(ds, "db_point_of_sales")

    End Sub
    Public Sub ge()
        usern.Clear()
        pass.Clear()
        fnametx.Clear()
        mnametx.Clear()
        lnametx.Clear()
        baranggay.Clear()
        pass.Clear()
        street.Clear()
        city.Clear()
        emailtx.Clear()
        confipass.Clear()
    End Sub
    Public Sub view()
        cmd = New SqlCommand("Select * From tbl_admin", con)
        da = New SqlDataAdapter(cmd)
        ds = New DataSet()
        da.Fill(ds, "db_point_of_sales")

        con.Open()
        DataGridView1.DataSource = ds.Tables("db_point_of_sales").DefaultView
        con.Close()

    End Sub
    Public Sub genc()
        If malerbtn.Checked = True Then
            a = malerbtn.Text
        ElseIf femalerbtn.Checked = True Then
            a = femalerbtn.Text
        End If
    End Sub
    Public Sub passcon()
        Dim same As Boolean = False

        If pass.Text = confipass.Text Then
            same = True
            ge()
        Else
            MsgBox("Password Incorrect! Please retype your password")
        End If
    End Sub

    Private Sub Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save.Click
        genc()
        add_admin()
        view()
        passcon()

    End Sub

    Private Sub backbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles backbtn.Click
        login.Show()
        Me.Hide()

    End Sub

    Private Sub admin_signup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        view()
    End Sub
End Class