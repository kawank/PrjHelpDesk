Public Class frmLogin

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            If isValid() Then
                Dim clsOperation As New DBOpeartions()
                Dim ds As DataSet
                ds = clsOperation.GetUserByUserNameAndPassword(txtUserName.Text.Trim(), txtPassword.Text.Trim(), lstUserRole.SelectedIndex)
                If (ds Is Nothing OrElse ds.Tables(0).Rows.Count = 0) Then
                    MessageBox.Show(MessagesConstant.LOGIN_INVALID)
                Else
                    Dim intUserId As Integer = ds.Tables(0).Rows(0)("UserId")
                    frmMain.lblUserId.Text = intUserId
                    frmMain.lblUserType.Text = Me.lstUserRole.SelectedIndex
                    Me.Hide()
                    frmMain.ShowDialog()
                    Me.Close()

                End If
            Else
                MessageBox.Show(MessagesConstant.LOGIN_INVALID)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Function isValid() As Boolean
        Dim blnValid As Boolean = True
        If (Me.txtUserName.Text.Trim() = String.Empty) Then
            blnValid = False
            MessageBox.Show(MessagesConstant.USER_NAME_IS_REQUIRED)
        ElseIf (txtPassword.Text.Trim() = String.Empty) Then
            blnValid = False

            MessageBox.Show(MessagesConstant.PASSWORD_IS_REQUIRED)
        ElseIf (lstUserRole.SelectedIndex = -1) Then
            blnValid = False
            MessageBox.Show(MessagesConstant.USERTYPE_REQUIRED)
        End If
        Return blnValid
    End Function
End Class
