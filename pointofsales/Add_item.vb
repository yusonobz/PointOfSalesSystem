Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class Add_item
    Dim con As SqlConnection = New SqlConnection("Data Source=RONNEL\SQLEXPRESS; Database=db_point_of_sales; Trusted_Connection =yes;")
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim dr As SqlDataReader
    Public Sub view()
        cmd = New SqlCommand("Select * From tbl_items", con)
        da = New SqlDataAdapter(cmd)
        ds = New DataSet()
        da.Fill(ds, "db_point_of_sales")

        con.Open()
        DataGridView1.DataSource = ds.Tables("db_point_of_sales").DefaultView
        con.Close()

    End Sub
    Public Sub add_item()
        cmd = New SqlCommand("Insert Into tbl_items (item_id, item_name, item_desc, item_price) Values ('" + txtbxid.Text + "', '" + Itemnam.Text + "','" + itemdesc.Text + "', '" + itemp.Text + "')", con)
        da = New SqlDataAdapter(cmd)
        ds = New DataSet()
        da.Fill(ds, "db_point_of_sales")
        MsgBox("Saved")
    End Sub
    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles savebtn.Click
        add_item()
        view()
    End Sub
    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles backbtn.Click
        adminpage.Show()
        Me.Hide()

    End Sub

    Private Sub Additem_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        view()
    End Sub


    Private Sub itemp_TextChanged(sender As System.Object, e As System.EventArgs) Handles itemp.TextChanged
        Dim selStart As Integer = itemp.SelectionStart
        Dim selMoveLeft As Integer = 0
        Dim newStr As String = "" 'Build a new string by copying each valid character from the existing string. The new string starts as blank and valid characters are added 1 at a time.

        For i As Integer = 0 To itemp.Text.Length - 1

            If "0123456789".IndexOf(itemp.Text(i)) <> -1 Then 'Characters that are in the allowed set will be added to the new string.
                newStr = newStr & itemp.Text(i)

            ElseIf i < selStart Then 'Characters that are not valid are removed - if these characters are before the cursor, we need to move the cursor left to account for their removal.
                selMoveLeft = selMoveLeft + 1

            End If
        Next

        itemp.Text = newStr 'Place the new text into the textbox.
        itemp.SelectionStart = selStart - selMoveLeft 'Move the cursor to the appropriate location
    End Sub

    Private Sub itemnam_Leave(sender As Object, e As System.EventArgs) Handles Itemnam.Leave
        If Itemnam.Text = " " Or Itemnam.Text = "" Then
            tip_noempty.Show("Item Name is Required", sender, 5000)

        ElseIf Not Regex.Match(Itemnam.Text, "^[a-z]*$", RegexOptions.IgnoreCase).Success Then
            tip_nonum.Show("Invalid input. Numbers, space, hyphen are not allowed", sender, 5000)
            Itemnam.Focus()
        End If
    End Sub

    
End Class