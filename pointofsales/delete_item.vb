Imports System.Data.SqlClient
Public Class delete_item
    Dim con As SqlConnection = New SqlConnection("Data Source=RONNEL\SQLEXPRESS; Database=db_point_of_sales; Trusted_Connection =yes;")
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim dr As SqlDataReader
    Friend ID As Integer

    Public Sub remove()
        Dim str As String = "Select * From tbl_items"
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
                .Items.Add(TABLE.Rows(i)("item_id"))

                With .Items(.Items.Count - 1).SubItems
                    'Respondent Profile
                    .Add(TABLE.Rows(i)("item_name"))
                    .Add(TABLE.Rows(i)("item_desc"))
                    .Add(TABLE.Rows(i)("item_price"))

                End With
            End With
        Next


    End Sub
    Private Sub ListView1_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles ListView1.MouseClick
        ID = ListView1.SelectedItems(0).Text
    End Sub

    Private Sub delete_item_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try

            con.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        remove()
    End Sub

    Private Sub removebtn_Click(sender As System.Object, e As System.EventArgs) Handles removebtn.Click
        If ID = Nothing Then
            MsgBox("Please choose a record to delete.", MsgBoxStyle.Exclamation)
        Else
            Dim result As Integer = MessageBox.Show("Do you want to delete this table with ID#" + ListView1.SelectedItems(0).Text + "?", "caption", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then

                Try

                    Dim str As String = "DELETE from tbl_items where item_id = '" + ListView1.SelectedItems(0).Text + "'"
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

    Private Sub backbtn_Click(sender As System.Object, e As System.EventArgs) Handles backbtn.Click
        adminpage.Show()
        Me.Hide()
    End Sub
End Class