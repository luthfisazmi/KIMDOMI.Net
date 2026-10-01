Public Class ReportTrans
    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        AxCrystalReport1.SelectionFormula = "totext({sell.SaleDate})='" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
        AxCrystalReport1.ReportFileName = "report.rpt"
        AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
        AxCrystalReport1.RetrieveDataFiles()
        AxCrystalReport1.Action = 1
    End Sub
End Class