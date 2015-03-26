Imports System.Data.SqlClient
Public Class editpos
    Dim con As SqlConnection = New SqlConnection("Data Source=RONNEL\SQLEXPRESS; Database=db_point_of_sales; Trusted_Connection =yes;")
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim dr As SqlDataReader
    Friend ID As Integer

    Private Sub savepos_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles savepos_btn.Click
        cmd = New SqlCommand("Update tbl_cashier set position = '" + npos_txt.Text + "' Where employeeid = '" & cashier_id.Text & "'", con)

        da = New SqlDataAdapter(cmd)
        ds = New DataSet
        da.Fill(ds, "db_point_of_sales")

    End Sub
    Private Sub list_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles list.MouseClick
        ID = list.SelectedItems(0).Text
    End Sub
    Public Sub view1()
        cmd = New SqlCommand("Select employeeid ,position From tbl_cashier", con)
        da = New SqlDataAdapter(cmd)
        ds = New DataSet()
        da.Fill(ds, "db_point_of_sales")
    End Sub

    Private Sub backbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles backbtn.Click
        adminpage.Show()
        Me.Hide()

    End Sub
    Public Sub lol()
        npos_txt.Text = list.SelectedItems.Item(0).SubItems(11).Text
    End Sub

    Private Sub editpos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim str As String = "Select employeeid, position From tbl_cashier"
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

        list.Items.Clear()

        For i = 0 To TABLE.Rows.Count - 1
            With list
                .Items.Add(TABLE.Rows(i)("employeeid"))
                With .Items(.Items.Count - 1).SubItems
                    'Respondent Profile
                    .Add(TABLE.Rows(i)("position"))


                End With
            End With
        Next


    End Sub

    Private Sub cashier_id_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cashier_id.TextChanged
        Dim conn As SqlConnection
        Dim itemcoll(100) As String

        list.Clear()
        list.View = View.Details
        conn = New SqlConnection("Data Source=RONNEL\SQLEXPRESS; Database=db_point_of_sales; Trusted_Connection = Yes")

        Dim strQ As String = String.Empty
        'strQ = "SELECT * FROM tblInfo"
        strQ = "SELECT employeeid, position FROM tbl_cashier where employeeid LIKE '" & cashier_id.Text & "%'"
        cmd = New SqlCommand(strQ, conn)
        da = New SqlDataAdapter(cmd)
        ds = New DataSet
        da.Fill(ds, "Tables")
        Dim i As Integer = 0
        Dim j As Integer = 0
        ' adding the columns in ListView
        For i = 0 To ds.Tables(0).Columns.Count - 1
            Me.list.Columns.Add(ds.Tables(0).Columns(i).ColumnName.ToString())
        Next
        'Now adding the Items in Listview
        For i = 0 To ds.Tables(0).Rows.Count - 1
            For j = 0 To ds.Tables(0).Columns.Count - 1
                itemcoll(j) = ds.Tables(0).Rows(i)(j).ToString()
            Next
            Dim lvi As New ListViewItem(itemcoll)
            Me.list.Items.Add(lvi)
        Next

        con.Close()
    End Sub
End Class