Public Class frmReport

    Private Sub frmReport_Load(sender As Object, e As EventArgs) Handles Me.Load
        FillGrid()
    End Sub

    Private Sub FillGrid()
        Try
            dgview.AutoGenerateColumns = False
            Dim dbobj As New DBOpeartions()
            Dim Ds As DataSet
            Ds = dbobj.GetRequestStatistics()
            dgview.DataSource = Ds.Tables(0)


        Catch ex As Exception
            Throw
        End Try
    End Sub
End Class