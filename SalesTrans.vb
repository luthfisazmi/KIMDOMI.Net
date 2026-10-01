Imports System.Data.SqlClient
Public Class SalesTrans
    Dim DateMySQL As String
    Sub FirstCon()
        LCustName.Text = ""
        LPhone.Text = ""
        ComboBox1.Items.Clear()
        ComboBox1.Text = ""
        LDate.Text = Today
        LAdmin.Text = Homepage.STLabel4.Text
        LChange.Text = ""
        TextBox2.Text = ""
        LProdName.Text = ""
        LBrand.Text = ""
        LPrice.Text = ""
        TextBox3.Text = ""
        TextBox3.Enabled = False
        LItem.Text = ""
        Call CustID()
        Call Otomatic()
        Call Column()
        Label9.Text = "0"
        TextBox1.Text = ""
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LHours.Text = TimeOfDay
    End Sub

    Private Sub SalesTrans_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call FirstCon()
    End Sub

    Sub CustID()
        Call Connect()
        ComboBox1.Items.Clear()
        Cmd = New SqlCommand("Select * from customer", Conn)
        Rd = Cmd.ExecuteReader
        Do While Rd.Read
            ComboBox1.Items.Add(Rd.Item(0))
        Loop
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Call Connect()
        Cmd = New SqlCommand("Select * from customer where CustomerID='" & ComboBox1.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            LCustName.Text = Rd!Name
            LPhone.Text = Rd!PhoneNumber
        End If
    End Sub
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              
    Sub Otomatic()
        Call Connect()
        Cmd = New SqlCommand("Select * from sell where SellNumber in (select max(SellNumber) from sell)", Conn)
        Dim UrutanKode As String
        Dim Hitung As Long
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            UrutanKode = "S" + Format(Now, "yyMMdd") + "001"
        Else
            Hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 9) + 1
            UrutanKode = "S" + Format(Now, "yyMMdd") + Microsoft.VisualBasic.Right("000" & Hitung, 3)
        End If
        LSellNum.Text = UrutanKode
    End Sub
    Sub Column()
        DataGridView1.Columns.Clear()
        DataGridView1.Columns.Add("Product ID", "Product ID")
        DataGridView1.Columns.Add("Name", "Product Name")
        DataGridView1.Columns.Add("Brand", "Product Brand")
        DataGridView1.Columns.Add("Price", "Price")
        DataGridView1.Columns.Add("Amount", "Amount")
        DataGridView1.Columns.Add("SubTotal", "SubTotal")
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Connect()
            Cmd = New SqlCommand("Select * From product Where ProductID ='" & TextBox2.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Not Rd.HasRows Then
                MsgBox("Name not available!", MsgBoxStyle.Critical, "Check Data")
            Else
                TextBox2.Text = Rd.Item("ProductID")
                LProdName.Text = Rd.Item("ProductName")
                LBrand.Text = Rd.Item("ProductBrand")
                LPrice.Text = Rd.Item("Price")
                'TextBox3.Text = Rd.Item("Amount")
                TextBox3.Enabled = True
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If LProdName.Text = "" Or TextBox3.Text = "" Then
            MsgBox("Insert ProductID and Press ENTER!", MsgBoxStyle.Critical, "Check Data")
        Else
            DataGridView1.Rows.Add(New String() {TextBox2.Text, LProdName.Text, LBrand.Text, LPrice.Text, TextBox3.Text, Val(LPrice.Text) * Val(TextBox3.Text)})
            Call Total()
            TextBox2.Text = ""
            LProdName.Text = ""
            LBrand.Text = ""
            LPrice.Text = ""
            TextBox3.Text = ""
            TextBox3.Enabled = False
            Call FindItem()
        End If
    End Sub

    Sub Total()
        Dim count As Integer = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            count = count + DataGridView1.Rows(i).Cells(5).Value
            Label9.Text = count
        Next
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            If Val(TextBox1.Text) < Val(Label9.Text) Then
                MsgBox("Payment Invalid!", MsgBoxStyle.Critical, "Check Cash")
            ElseIf Val(TextBox1.Text) = Val(Label9.Text) Then
                LChange.Text = 0
            ElseIf Val(TextBox1.Text) > Val(Label9.Text) Then
                LChange.Text = Val(TextBox1.Text) - Val(Label9.Text)
                Button1.Focus()
            End If
        End If
    End Sub

    Sub FindItem()
        Dim CountItem As Integer = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            CountItem = CountItem + DataGridView1.Rows(i).Cells(4).Value
            LItem.Text = CountItem
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If LChange.Text = "" Or LCustName.Text = "" Or Label9.Text = "" Then
            MsgBox("Transaction Invalid!", MsgBoxStyle.Critical, "Check Data")
        Else
            DateMySQL = Format(Today, "yyyy-MM-dd")
            Dim SaveSell As String = "Insert into sell values ('" & LSellNum.Text & "', '" & DateMySQL & "', '" & LHours.Text & "', '" & LItem.Text & "', '" & Label9.Text & "', '" & TextBox1.Text & "', '" & LChange.Text & "', '" & ComboBox1.Text & "', '" & Homepage.STLabel2.Text & "')"
            Cmd = New SqlCommand(SaveSell, Conn)
            Rd.Close()
            Cmd.ExecuteNonQuery()

            For Row As Integer = 0 To DataGridView1.Rows.Count - 2
                Dim SaveDetails As String = "Insert into selldetails values ('" & LSellNum.Text & "', '" & DataGridView1.Rows(Row).Cells(0).Value & "', '" & DataGridView1.Rows(Row).Cells(1).Value & "', '" & DataGridView1.Rows(Row).Cells(2).Value & "' , '" & DataGridView1.Rows(Row).Cells(3).Value & "', '" & DataGridView1.Rows(Row).Cells(4).Value & "', '" & DataGridView1.Rows(Row).Cells(5).Value & "')"
                Cmd = New SqlCommand(SaveDetails, Conn)
                Cmd.ExecuteNonQuery()

                Cmd = New SqlCommand("select * from product where ProductID='" & DataGridView1.Rows(Row).Cells(0).Value & "'", Conn)
                Rd = Cmd.ExecuteReader
                Rd.Read()
                Dim ReduceStock As String = "update product set Stock='" & Rd.Item("Stock") - DataGridView1.Rows(Row).Cells(4).Value & "' where ProductID='" & DataGridView1.Rows(Row).Cells(0).Value & "'"
                Cmd = New SqlCommand(ReduceStock, Conn)
                Rd.Close()
                Cmd.ExecuteNonQuery()
            Next
            If MessageBox.Show("Print Invoice?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                AxCrystalReport1.SelectionFormula = "totext({sell.SellNumber})='" & LSellNum.Text & "'"
                AxCrystalReport1.ReportFileName = "last.rpt"
                AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
                AxCrystalReport1.RetrieveDataFiles()
                AxCrystalReport1.Action = 1
                Call FirstCon()
            Else
                Call FirstCon()
                MsgBox("The Transaction Has Been Saved", MsgBoxStyle.Information, "Transaction Succesful")
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call FirstCon()
    End Sub

End Class