Public Class frmMain

    Private Sub RequestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RequestToolStripMenuItem.Click
        frmAddRequest.MdiParent = Me
        frmAddRequest.lblRequestUserId.Text = Me.lblUserId.Text
        frmAddRequest.Show()
    End Sub

    Private Sub ViewRequestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewRequestToolStripMenuItem.Click

        frmViewRequest.MdiParent = Me
        frmViewRequest.lblUserType.Text = Me.lblUserType.Text
        frmViewRequest.Show()
    End Sub

    Private Sub UpdateRequestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateRequestToolStripMenuItem.Click
        frmComplete.MdiParent = Me
        frmComplete.Show()
    End Sub

    Private Sub ReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportToolStripMenuItem.Click
        frmReport.MdiParent = Me
        frmReport.Show()
    End Sub

  
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        If lblUserType.Text.Trim() = UserTypeConstants.STAFF Then
            UpdateRequestToolStripMenuItem.Enabled = False
        ElseIf lblUserType.Text.Trim() = UserTypeConstants.TECHNICAL Then
            ReportToolStripMenuItem.Enabled = False
        ElseIf lblUserType.Text.Trim() = UserTypeConstants.MANAGER Then
            ReportToolStripMenuItem.Enabled = False
            UpdateRequestToolStripMenuItem.Enabled = False
        End If
    End Sub
End Class