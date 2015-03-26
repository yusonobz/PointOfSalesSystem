Imports System.Data.SqlClient
Public Class cashierpage
    Public Property StringPass As String

    Dim con As SqlConnection = New SqlConnection("Data Source=RONNEL\SQLEXPRESS; Database=db_point_of_sales; Trusted_Connection =yes;")
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim dr As SqlDataReader
    Dim item1, item2 As String
    Dim quantity1, quantity2, price1, price2 As String
    Friend ID As Integer

    Private Sub backbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles backbtn.Click
        cashierlogin.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        login.Show()
        Me.Hide()
    End Sub

    Private Sub combotxt_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combotxt.SelectedIndexChanged
        con = New SqlConnection
        con.ConnectionString = "Data Source=RONNEL\SQLEXPRESS; Database=db_point_of_sales; Trusted_Connection = Yes"
        Dim reader As SqlDataReader
        Try
            con.Open()
            Dim query As String

            query = "Select * from tbl_items where name '" & combotxt.Text & "'"
            cmd = New SqlCommand(query, con)
            reader = cmd.ExecuteReader
            While reader.Read
                itm.Text = reader.GetString("item_name")
                itm_price.Text = reader.GetInt32("item_price")
                item_desc.Text = reader.GetString("item_desc")

            End While

        Catch ex As Exception

        End Try
    End Sub
    Public Sub remove()
        Dim str As String = "Select * From tbl_trans"
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

        items.Items.Clear()

        For i = 0 To TABLE.Rows.Count - 1
            With items
                .Items.Add(TABLE.Rows(i)("transaction_id"))

                With .Items(.Items.Count - 1).SubItems
                    'Respondent Profile
                    .Add(TABLE.Rows(i)("item_name"))
                    .Add(TABLE.Rows(i)("quantity"))
                    .Add(TABLE.Rows(i)("sales"))

                End With
            End With
        Next


    End Sub
   

    Private Sub cashierpage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        empname.Text = StringPass
    End Sub

    Private Sub item_num_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
   
    Private Sub item_num_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        con = New SqlConnection
        con.ConnectionString = "Data Source=RONNEL\SQLEXPRESS; Database=db_point_of_sales; Trusted_Connection = Yes"
        Dim reader As SqlDataReader
        Try
            con.Open()
            Dim query As String

            query = "Select * from tbl_items where item_id '" & item_num.Text & "'"
            cmd = New SqlCommand(query, con)
            reader = cmd.ExecuteReader
            While reader.Read
                item_num.Text = reader.GetInt32("item_id")

            End While

        Catch ex As Exception

        End Try
    End Sub
    Public Sub POS()

        Dim str As String = "Select * From tbl_trans ORDER BY transaction_id DESC"
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

        items.Items.Clear()

        For i = 0 To TABLE.Rows.Count - 1
            With items
                .Items.Add(TABLE.Rows(i)("transaction_id"))
                With .Items(.Items.Count - 1).SubItems
                    'Respondent Profile
                    .Add(TABLE.Rows(i)("item_name"))
                    .Add(TABLE.Rows(i)("quantity"))
                    .Add(TABLE.Rows(i)("sales"))
                End With
            End With
        Next
    End Sub
    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles itemlist.SelectedIndexChanged
        itm.Text = itemlist.SelectedItems.Item(0).SubItems(1).Text
        item_desc.Text = itemlist.SelectedItems.Item(0).SubItems(2).Text
        itm_price.Text = itemlist.SelectedItems.Item(0).SubItems(3).Text
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles item_num.TextChanged
        Dim conn As SqlConnection
        Dim itemcoll(100) As String

        itemlist.Clear()
        itemlist.View = view.Details
        conn = New SqlConnection("Data Source=RONNEL\SQLEXPRESS; Database=db_point_of_sales; Trusted_Connection = Yes")

        Dim strQ As String = String.Empty
        'strQ = "SELECT * FROM tblInfo"
        strQ = "SELECT * FROM tbl_items where item_name LIKE '" & item_num.Text & "%'"
        cmd = New SqlCommand(strQ, conn)
        da = New SqlDataAdapter(cmd)
        ds = New DataSet
        da.Fill(ds, "Tables")
        Dim i As Integer = 0
        Dim j As Integer = 0
        ' adding the columns in ListView
        For i = 0 To ds.Tables(0).Columns.Count - 1
            Me.itemlist.Columns.Add(ds.Tables(0).Columns(i).ColumnName.ToString())
        Next
        'Now adding the Items in Listview
        For i = 0 To ds.Tables(0).Rows.Count - 1
            For j = 0 To ds.Tables(0).Columns.Count - 1
                itemcoll(j) = ds.Tables(0).Rows(i)(j).ToString()
            Next
            Dim lvi As New ListViewItem(itemcoll)
            Me.itemlist.Items.Add(lvi)
        Next

        con.Close()

    End Sub

   
    Private Sub addbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addbtn.Click
        item1 = itm.Text
        item2 = item1 + ", " + item2
        price1 = Val(itm_price.Text) * Val(quan.Text)
        price2 = Val(price2) + Val(price1)
        quantity1 = Val(quan.Text)
        quantity2 = Val(quantity1) + Val(quantity2)
        Try
            Dim str1 As String = "Insert Into tbl_trans (transaction_id, item_name, quantity, sales) Values ('" + transtxt.Text + "','" + item1 + "' , '" + quan.Text + "' , '" + price1 + "')"
            Dim da As New SqlDataAdapter(str1, con)
            Dim ds As New DataSet
            da.Fill(ds)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        POS()
    End Sub

    Private Sub items_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles items.SelectedIndexChanged
        ID = items.SelectedItems(0).Text
        total.Text = items.SelectedItems.Item(0).SubItems(4).Text
    End Sub

    Private Sub process_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles process_btn.Click
        If item2.Length <> 0 Then
            item2 = item2.Substring(0, item2.Length - 2)
        End If
        Try
            Dim str As String = "Insert Into tbl_trans (transaction_id, item_name, quantity, sales) Values ('" + transtxt.Text + "','" + item1 + "' , '" + quan.Text + "' , '" + price1 + "')"
            Dim da As New SqlDataAdapter(str, con)
            Dim ds As New DataSet
            da.Fill(ds)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        PointS()
    End Sub
    Public Sub PointS()

        Dim str1 As String = "Select * From tbl_trans ORDER BY transaction_id DESC"
        Dim cmd As New SqlCommand
        Dim da As New SqlDataAdapter
        Dim tbl As New DataTable
        Dim i As Integer

        With cmd
            .CommandText = str1
            .Connection = con
        End With

        With da
            .SelectCommand = cmd
            .Fill(tbl)
        End With

        items.Items.Clear()

        For i = 0 To tbl.Rows.Count - 1
            With items
                .Items.Add(tbl.Rows(i)("transaction_id"))
                With .Items(.Items.Count - 1).SubItems
                    'Respondent Profile
                    .Add(tbl.Rows(i)("item_name"))
                    .Add(tbl.Rows(i)("quantity"))
                    .Add(tbl.Rows(i)("sales"))
                End With
            End With
        Next
    End Sub

    Private Sub cancelbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancelbtn.Click
        If ID = Nothing Then
            MsgBox("Please choose a record to delete.", MsgBoxStyle.Exclamation)
        Else
            Dim result As Integer = MessageBox.Show("Do you want to delete this table with ID#" + items.SelectedItems(0).Text + "?", "caption", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then

                Try

                    Dim str As String = "DELETE from tbl_trans where transaction_id = '" + items.SelectedItems(0).Text + "'"
                    Dim da As New SqlDataAdapter(str, con)
                    Dim ds As New DataSet
                    da.Fill(ds, "db_point_of_sales")
                Catch ex As Exception
                    MsgBox(ex.Message)

                End Try
            End If
            MsgBox("Information Deleted!")

            remove()

        End If
    End Sub
End Class