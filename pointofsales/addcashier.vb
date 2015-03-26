Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class addcashier
    Dim con As SqlConnection = New SqlConnection("Data Source=RONNEL\SQLEXPRESS; Database=db_point_of_sales; Trusted_Connection =yes;")
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim dr As SqlDataReader
    Dim a As String

    Private Sub addcashier_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        view()
    End Sub


    Public Sub view()
        cmd = New SqlCommand("Select employeeid, fname, lname, mname, gender, email, baranggay, street, city, position From tbl_cashier", con)
        da = New SqlDataAdapter(cmd)
        ds = New DataSet()
        da.Fill(ds, "db_point_of_sales")

        con.Open()
        DataGridView1.DataSource = ds.Tables("db_point_of_sales").DefaultView
        con.Close()

    End Sub


    Public Sub add_cashier()
        cmd = New SqlCommand("Insert Into tbl_cashier (employeeid, fname, mname, lname, gender, email, baranggay, street, city, position, password) Values ('" + txtid.Text + "', '" + fname.Text + "', '" + mname.Text + "', '" + lname.Text + "', '" + a + "','" + emailadd.Text + "', '" + baranggay.Text + "', '" + street.Text + "', '" + city.Text + "', '" + position.Text + "', '" + pass.Text + "')", con)
        da = New SqlDataAdapter(cmd)
        ds = New DataSet()
        da.Fill(ds, "db_point_of_sales")
        view()
        ge()
    End Sub
  

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles save_btn.Click

        genc()
        passcon()

    End Sub


    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles back_btn.Click
        adminpage.Show()
        Me.Hide()

    End Sub
    Public Sub ge()
        fname.Clear()
        mname.Clear()
        lname.Clear()
        baranggay.Clear()
        position.Clear()
        pass.Clear()
        street.Clear()
        city.Clear()
        emailadd.Clear()
        confipass_txtbx.Clear()
    End Sub

    Private Sub fname_Leave(sender As Object, e As System.EventArgs) Handles fname.Leave
        If fname.Text = " " Or fname.Text = "" Then
            tip_noempty.Show("First Name is Required", sender, 5000)

        ElseIf Not Regex.Match(fname.Text, "^[a-z]*$", RegexOptions.IgnoreCase).Success Then
            tip_nonum.Show("Invalid input. Numbers, space, hyphen are not allowed", sender, 5000)
            fname.Focus()
        End If
    End Sub

    Private Sub lname_Leave(sender As Object, e As System.EventArgs) Handles lname.Leave
        If lname.Text = " " Or lname.Text = "" Then
            tip_noempty.Show("Last Name is Required", sender, 5000)

        ElseIf Not Regex.Match(fname.Text, "^[a-z]*$", RegexOptions.IgnoreCase).Success Then
            tip_nonum.Show("Invalid input. Numbers, space, hyphen are not allowed", sender, 5000)
            lname.Focus()
        End If
    End Sub
    Private Sub emailadd_Leave(sender As Object, e As System.EventArgs) Handles lname.Leave
        If emailadd.Text = " " Or emailadd.Text = "" Then
            tip_noempty.Show("Email Address is Required", sender, 5000)

        ElseIf Not Regex.Match(fname.Text, ".^[a-z]*$@", RegexOptions.IgnoreCase).Success Then
            tip_nonum.Show("Invalid input.Space, hyphen are not allowed", sender, 5000)
            emailadd.Focus()
        End If
    End Sub

    Private Sub confipass_txtbx_TextChanged(sender As System.Object, e As System.EventArgs) Handles confipass_txtbx.TextChanged
        If confipass_txtbx.Text = " " Or confipass_txtbx.Text = "" Then
            tip_noempty.Show("Email Address is Required", sender, 5000)

        ElseIf Not Regex.Match(confipass_txtbx.Text, ".^[a-z]*$@", RegexOptions.IgnoreCase).Success Then
            tip_nonum.Show("Invalid input.Space, hyphen are not allowed", sender, 5000)
            confipass_txtbx.Focus()
        End If

    End Sub

    Public Sub passcon()
        Dim same As Boolean = False

        If pass.Text = confipass_txtbx.Text Then
            same = True
            add_cashier()
        Else
            MsgBox("Password Incorrect! Please retype your password")
            confipass_txtbx.Clear()
        End If
    End Sub

    Private Sub street_TextChanged(sender As System.Object, e As System.EventArgs) Handles street.TextChanged
        If street.Text = " " Or street.Text = "" Then
            tip_noempty.Show("New Price of the item is Required", sender, 5000)

        Else
            Dim selStart As Integer = street.SelectionStart
            Dim selMoveLeft As Integer = 0
            Dim newStr As String = "" 'Build a new string by copying each valid character from the existing string. The new string starts as blank and valid characters are added 1 at a time.

            For i As Integer = 0 To street.Text.Length - 1

                If "0123456789".IndexOf(street.Text(i)) <> -1 Then 'Characters that are in the allowed set will be added to the new string.
                    newStr = newStr & street.Text(i)

                ElseIf i < selStart Then 'Characters that are not valid are removed - if these characters are before the cursor, we need to move the cursor left to account for their removal.
                    selMoveLeft = selMoveLeft + 1

                End If
            Next

            street.Text = newStr 'Place the new text into the textbox.
            street.SelectionStart = selStart - selMoveLeft 'Move the cursor to the appropriate location Then
            tip_nonum.Show("Invalid input.Space, letters,hyphen", sender, 5000)
            street.Focus()
        End If
    End Sub


    Public Sub genc()
        If malerbtn.Checked = True Then
            a = malerbtn.Text
        ElseIf femalerbtn.Checked = True Then
            a = femalerbtn.Text
        End If
    End Sub

    Private Sub txtid_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtid.TextChanged

    End Sub

    Private Sub malerbtn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles malerbtn.CheckedChanged

    End Sub
End Class