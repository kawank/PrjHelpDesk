Public Class frmAddRequest


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Utilities.ClearAllTextBox(GroupBox1)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If (IsValid()) Then
                If (Save()) Then
                    If (btnSave.Text.Trim().ToUpper() = "SAVE") Then
                        MessageBox.Show(MessagesConstant.REQUEST_SAVED)
                    Else
                        MessageBox.Show(MessagesConstant.REQUEST_UPDATED)
                        lblRequestId.Text = 0
                    End If
                    Utilities.ClearAllTextBox(GroupBox1)

                Else
                    MessageBox.Show(MessagesConstant.REQUEST_FAILED)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(MessagesConstant.REQUEST_FAILED)
        End Try

    End Sub

    Public Function Save() As Boolean
        Try
            Dim db As New DBOpeartions()
            If (btnSave.Text.Trim().ToUpper() = "SAVE") Then
                db.InsertRequestByStaff(Me.lblRequestUserId.Text, Me.txtFname.Text.Trim(), Me.txtLName.Text.Trim(), Me.txtPhone.Text.Trim(), Me.txtSubject.Text.Trim(), Me.txtDescription.Text.Trim())
            Else
                db.UpdateRequestByStaff(Me.lblRequestUserId.Text, Me.txtFname.Text.Trim(), Me.txtLName.Text.Trim(), Me.txtPhone.Text.Trim(), Me.txtSubject.Text.Trim(), Me.txtDescription.Text.Trim(), Me.lblRequestId.Text)
            End If
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try

    End Function


    Private Function IsValid() As Boolean
        Try
            Dim blnIsValid As Boolean = True
            If (Me.txtFname.Text.Trim() = String.Empty) Then
                blnIsValid = False
                Me.txtFname.Focus()
                MessageBox.Show(MessagesConstant.FIRST_NAME_REQUIRED)
            ElseIf (Me.txtLName.Text.Trim() = String.Empty) Then
                blnIsValid = False
                Me.txtLName.Focus()
                MessageBox.Show(MessagesConstant.LAST_NAME_REQUIRED)
            ElseIf (Me.txtPhone.Text.Trim() = String.Empty) Then
                blnIsValid = False
                Me.txtPhone.Focus()
                MessageBox.Show(MessagesConstant.PHONE_REQUIRED)
            ElseIf (Me.txtSubject.Text.Trim() = String.Empty) Then
                blnIsValid = False
                Me.txtSubject.Focus()
                MessageBox.Show(MessagesConstant.SUBJECT_REQUIRED)
            ElseIf (Me.txtDescription.Text.Trim() = String.Empty) Then
                blnIsValid = False
                Me.txtDescription.Focus()
                MessageBox.Show(MessagesConstant.DESCRIPTION_REQUIRED)
            End If
            Return blnIsValid
        Catch ex As Exception
            Return False
        End Try

    End Function

    Private Sub frmAddRequest_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
End Class