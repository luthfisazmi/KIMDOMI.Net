Imports System.Data.SqlClient
Public Class Customer
    Sub Condition()
        TextBox1.Text = ""
        TextBox2.Text = ""
        ComboBox1.Items.Clear()
        ComboBox1.Text = ""
        TextBox3.Text = ""
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        ComboBox1.Enabled = False
        TextBox3.Enabled = False

        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button1.Text = "Insert"
        Button2.Text = "Edit"
        Button3.Text = "Delete"
        Button4.Text = "Close"
        Call Connect()
        Da = New SqlDataAdapter("Select * From customer", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "customer")
        DataGridView1.DataSource = Ds.Tables("customer")
        DataGridView1.ReadOnly = True
    End Sub

    Sub Ready()
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        ComboBox1.Enabled = True
        TextBox3.Enabled = True
        ComboBox1.Items.Add("Male")
        ComboBox1.Items.Add("Female")
    End Sub

    Private Sub Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Connect()
        Call Condition()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "Insert" Then
            Button1.Text = "Save"
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Text = "Cancel"
            Call Ready()
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or ComboBox1.Text = "" Or TextBox3.Text = "" Then
                MsgBox("Data Must Filled!", MsgBoxStyle.Critical, "Check Data")
            Else
                'Call Connect()
                Dim InsertData As String = "Insert into customer values('" & TextBox1.Text & "','" & TextBox2.Text & "', '" & ComboBox1.Text & "', '" & TextBox3.Text & "')"
                Cmd = New SqlCommand(InsertData, Conn)
                Rd.Close()
                Cmd.ExecuteNonQuery()
                MsgBox("Insert Data Succeed!", MsgBoxStyle.Information, "Insert Successful")
                Call Condition()
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Button2.Text = "Edit" Then
            Button2.Text = "Save"
            Button1.Enabled = False
            Button3.Enabled = False
            Button4.Text = "Cancel"
            Call Ready()
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or ComboBox1.Text = "" Or TextBox3.Text = "" Then
                MsgBox("Data Must Filled!", MsgBoxStyle.Critical, "Check Data")
            Else
                'Call Connect()
                Dim UpdateData As String = "Update customer set name='" & TextBox2.Text & "',gender='" & ComboBox1.Text & "',phonenumber='" & TextBox3.Text & "' where customerid='" & TextBox1.Text & "'"
                Cmd = New SqlCommand(UpdateData, Conn)
                Rd.Close()
                Cmd.ExecuteNonQuery()
                MsgBox("Update Data Succeed!", MsgBoxStyle.Information, "Update Succesful")
                Call Condition()
            End If
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Connect()
            Cmd = New SqlCommand("Select * From customer Where CustomerID ='" & TextBox1.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Not Rd.HasRows Then
                MsgBox("Customer ID not available!", MsgBoxStyle.Critical, "Check Data")
            Else
                TextBox1.Text = Rd.Item("CustomerID")
                TextBox2.Text = Rd.Item("Name")
                ComboBox1.Text = Rd.Item("Gender")
                TextBox3.Text = Rd.Item("PhoneNumber")
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Button4.Text = "Close" Then
            Me.Close()
        Else
            Call Condition()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Button3.Text = "Delete" Then
            Button3.Text = "Remove"
            Button1.Enabled = False
            Button2.Enabled = False
            Button4.Text = "Cancel"
            Call Ready()
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or ComboBox1.Text = "" Or TextBox3.Text = "" Then
                MsgBox("Data Must Filled!", MsgBoxStyle.Critical, "Check Data")
            Else
                'Call Connect()
                Dim DeleteData As String = "Delete from customer where CustomerID='" & TextBox1.Text & "'"
                Cmd = New SqlCommand(DeleteData, Conn)
                Rd.Close()
                Cmd.ExecuteNonQuery()
                MsgBox("Delete Data Succeed!", MsgBoxStyle.Information, "Delete Succesful")
                Call Condition()
            End If
        End If
    End Sub
End Class