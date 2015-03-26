Imports System.Data.SqlClient
Public Class editcashier
    Dim con As SqlConnection = New SqlConnection("Data Source=RONNEL\SQLEXPRESS; Database=db_point_of_sales; Trusted_Connection =yes;")
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim dr As SqlDataReader
    Friend ID As Integer

    Private Sub savebtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles saveadd_btn.Click
        cmd = New SqlCommand("Update tbl_cashier set baranggay = '" + barrang_txt.Text + "', street = '" + st_txt.Text + "', city = '" + city_txt.Text + "' Where employeeid = '" & cashier_id.Text & "'", con)

        da = New SqlDataAdapter(cmd)
        ds = New DataSet()
        da.Fill(ds, "db_point_of_sales")
      

    End Sub
    Public Sub view1()
        cmd = New SqlCommand("Select employeeid, baranggay, street, city  From tbl_cashier", con)
        da = New SqlDataAdapter(cmd)
        ds = New DataSet()
        da.Fill(ds, "db_point_of_sales")
    End Sub
    Public Sub edit()
        Dim str As String = "Select employeeid, baranggay, street, city From tbl_cashiers"
        Dim cmd As New SqlCommand
        Dim da As New SqlDataAdapter
        Dim TABLE As New DataTable
        Dim i As Integer

        With cmd
            .CommandText = str
            .Connection = con
        End With

        With da
            .SelectCommand = cmd
            .Fill(TABLE)
        End With

        ListView1.Items.Clear()

        For i = 0 To TABLE.Rows.Count - 1
            With ListView1
                .Items.Add(TABLE.Rows(i)("employee_id"))
                With .Items(.Items.Count - 1).SubItems
                    'Respondent Profile
                    .Add(TABLE.Rows(i)("Barranggay"))
                    .Add(TABLE.Rows(i)("Street"))
                    .Add(TABLE.Rows(i)("City"))

                End With
            End With
        Next


    End Sub
    Private Sub ListView1_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles ListView1.MouseClick
        ID = ListView1.SelectedItems(0).Text
    End Sub

    Private Sub backbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles backbtn.Click
        adminpage.Show()
        Me.Hide()

    End Sub

    Private Sub posi_btn_Click(sender As System.Object, e As System.EventArgs) Handles posi_btn.Click
        editpos.Show()
        Me.Hide()
    End Sub

    Private Sub pass_btn_Click(sender As System.Object, e As System.EventArgs) Handles pass_btn.Click
        editpassadm.Show()
        Me.Hide()
    End Sub
    Public Sub lol()
        barrang_txt.Text = ListView1.SelectedItems.Item(0).SubItems(7).Text
        st_txt.Text = ListView1.SelectedItems.Item(0).SubItems(8).Text
        city_txt.Text = ListView1.SelectedItems.Item(0).SubItems(9).Text

    End Sub
    Private Sub editcashier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cashier_id_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cashier_id.TextChanged
        Dim conn As SqlConnection
        Dim itemcoll(100) As String

        ListView1.Clear()
        ListView1.View = View.Details
        conn = New SqlConnection("Data Source=RONNEL\SQLEXPRESS; Database=db_point_of_sales; Trusted_Connection = Yes")

        Dim strQ As String = String.Empty
        'strQ = "SELECT * FROM tblInfo"
        strQ = "SELECT * FROM tbl_cashier where employeeid LIKE '" & cashier_id.Text & "%'"
        cmd = New SqlCommand(strQ, conn)
        da = New SqlDataAdapter(cmd)
        ds = New DataSet
        da.Fill(ds, "Tables")
        Dim i As Integer = 0
        Dim j As Integer = 0
        ' adding the columns in ListView
        For i = 0 To ds.Tables(0).Columns.Count - 1
            Me.ListView1.Columns.Add(ds.Tables(0).Columns(i).ColumnName.ToString())
        Next
        'Now adding the Items in Listview
        For i = 0 To ds.Tables(0).Rows.Count - 1
            For j = 0 To ds.Tables(0).Columns.Count - 1
                itemcoll(j) = ds.Tables(0).Rows(i)(j).ToString()
            Next
            Dim lvi As New ListViewItem(itemcoll)
            Me.ListView1.Items.Add(lvi)
        Next

        con.Close()

    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        view1()
        lol()
    End Sub

    Private Sub refbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles refbtn.Click

        lol()
        cashier_id.Clear()
        barrang_txt.Clear()
        st_txt.Clear()
        city_txt.Clear()
    End Sub
End Class