Imports System.Data.SqlClient
Public Class Homepage
    Sub Locked()
        LoginToolStripMenuItem.Enabled = True
        LogoutToolStripMenuItem.Enabled = False
        MasterToolStripMenuItem.Enabled = False
        TransactionToolStripMenuItem.Enabled = False
        ReportToolStripMenuItem.Enabled = False
        STLabel2.Text = ""
        STLabel4.Text = ""
    End Sub
    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        Login.ShowDialog()
    End Sub
    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Call Locked()
    End Sub
    Private Sub AdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminToolStripMenuItem.Click
        Admin.ShowDialog()
    End Sub
    Private Sub CustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerToolStripMenuItem.Click
        Customer.ShowDialog()
    End Sub
    Private Sub ProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductToolStripMenuItem.Click
        Product.ShowDialog()
    End Sub
    Private Sub Homepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Locked()
        STLabel8.Text = Today
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        STLabel6.Text = TimeOfDay
    End Sub

    Private Sub SalesReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalesReportToolStripMenuItem.Click
        ReportTrans.ShowDialog()
    End Sub

    Private Sub SalesTransactionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalesTransactionToolStripMenuItem.Click
        SalesTrans.ShowDialog()
    End Sub

    Private Sub StockReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockReportToolStripMenuItem.Click
        StockReport.ShowDialog()
    End Sub
End Class
