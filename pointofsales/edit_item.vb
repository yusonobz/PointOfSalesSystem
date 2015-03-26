Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class edit_item
    Dim con As SqlConnection = New SqlConnection("Data Source=RONNEL\SQLEXPRESS; Database=db_point_of_sales; Trusted_Connection =yes;")
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim dr As SqlDataReader
    Private Sub edit_item_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        
        
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles save.Click
        cmd = New SqlCommand("Update tbl_items set price = '" + price.Text + "' Where item_name = '" & searchtxt.Text & "'", con)

        da = New SqlDataAdapter(cmd)
        ds = New DataSet()
        da.Fill(ds, "db_point_of_sales")
        MsgBox("Saved")
    End Sub

    Private Sub Update_Item()
        Dim pricej As String


        pricej = price.Text


        'cmd = New SqlCommand("Update tblItem Set Quantity='" & TotalQty & "' Where Item_ID='" & LabelI_ID.Text & "'", con)
        cmd = New SqlCommand("Update tbl_items set item_price  = '" & price.Text & "' Where item_price = '" & price.Text & "'", con)

        da = New SqlDataAdapter(cmd)
        ds = New DataSet()
        da.Fill(ds, "db_point_of_sales")
        'view_Item()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim cmd1 As String = "select * from tbl_items where item_name = '" + searchtxt.Text + "'"
        da = New SqlDataAdapter(cmd1, con)
        ds = New DataSet()
        da.Fill(ds, "db_point_of_sales")
        price.Text = cmd1



    End Sub

    Private Sub price_TextChanged(sender As System.Object, e As System.EventArgs) Handles price.TextChanged
        If price.Text = " " Or price.Text = "" Then
            tip_noempty.Show("New Price of the item is Required", sender, 5000)

        Else
            Dim selStart As Integer = price.SelectionStart
            Dim selMoveLeft As Integer = 0
            Dim newStr As String = "" 'Build a new string by copying each valid character from the existing string. The new string starts as blank and valid characters are added 1 at a time.

            For i As Integer = 0 To price.Text.Length - 1

                If "0123456789".IndexOf(price.Text(i)) <> -1 Then 'Characters that are in the allowed set will be added to the new string.
                    newStr = newStr & price.Text(i)

                ElseIf i < selStart Then 'Characters that are not valid are removed - if these characters are before the cursor, we need to move the cursor left to account for their removal.
                    selMoveLeft = selMoveLeft + 1

                End If
            Next

            price.Text = newStr 'Place the new text into the textbox.
            price.SelectionStart = selStart - selMoveLeft 'Move the cursor to the appropriate location Then
            tip_nonum.Show("Invalid input.Space, letters,hyphen", sender, 5000)
            price.Focus()
        End If

    End Sub

   

    Private Sub back_Click(sender As System.Object, e As System.EventArgs) Handles back.Click
        adminpage.Show()
        Me.Hide()
    End Sub

    Private Sub searchtxt_TextChanged(sender As System.Object, e As System.EventArgs) Handles searchtxt.TextChanged
        Dim conn As SqlConnection
        Dim itemcoll(100) As String

        ListView1.Clear()
        ListView1.View = View.Details
        conn = New SqlConnection("Data Source=RONNEL\SQLEXPRESS; Database=db_point_of_sales; Trusted_Connection = Yes")
        
        Dim strQ As String = String.Empty
        'strQ = "SELECT * FROM tblInfo"
        strQ = "SELECT * FROM tbl_items where item_name LIKE '" & searchtxt.Text & "%'"
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

    Private Sub ListView1_Click(sender As Object, e As System.EventArgs) Handles ListView1.Click
        price.Text = ListView1.SelectedItems.Item(0).SubItems(3).Text
    End Sub
End Class