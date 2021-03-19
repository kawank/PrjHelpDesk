Public Class frmComplete

    Private Enum GridColumIndex
        RequestId = 0
        RequestUserId
        Requester
        Phone
        RequestDate
        RequestSubject
        RequestDescription
        Status
      

    End Enum


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Try

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub btnCompleted_Click(sender As Object, e As EventArgs) Handles btnCompleted.Click
        Try
            If (IsValid()) Then
                If (SaveData()) Then

                    MessageBox.Show(MessagesConstant.REQUEST_COMPLETED)
                    FillData()
                    Utilities.ClearAllTextBox(grpRequestDetail)
                    Utilities.ClearAllTextBox(grpTechnical)
                    Me.lblRequestId.Text = String.Empty
                Else
                    MessageBox.Show(MessagesConstant.REQUEST_FAILED)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Function IsValid() As Boolean
        Try
            Dim blnValid As Boolean = True
            If (Me.lblRequestId.Text.Trim() = String.Empty) Then
                blnValid = False
                MessageBox.Show(MessagesConstant.SELECT_RECORD_FIRST_TO_COMPLETE)
                Me.dgview.Focus()
            End If
            If (Me.txtFName.Text.Trim() = String.Empty) Then
                blnValid = False
                Me.txtFName.Focus()
                MessageBox.Show(MessagesConstant.FIRST_NAME_REQUIRED)
            ElseIf (Me.TxtLName.Text.Trim() = String.Empty) Then
                blnValid = False
                Me.TxtLName.Focus()
                MessageBox.Show(MessagesConstant.LAST_NAME_REQUIRED)

            ElseIf (Me.txtPhone.Text.Trim() = String.Empty) Then
                blnValid = False
                Me.txtPhone.Focus()
                MessageBox.Show(MessagesConstant.PHONE_REQUIRED)
            ElseIf (Me.TxtComments.Text.Trim() = String.Empty) Then
                blnValid = False
                Me.TxtComments.Focus()
                MessageBox.Show(MessagesConstant.COMMENT_REQUIRED)
            End If

            Return blnValid
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

    Private Function SaveData() As Boolean
        Try
            Dim dbc As New DBOpeartions()
            dbc.UpdateRequestByTechnical(lblRequestId.Text, 1, Me.txtFName.Text, Me.TxtLName.Text.Trim, Me.txtPhone.Text.Trim, Me.TxtComments.Text.Trim())

            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

    Private Sub FillData()
        Try


            Dim ColEditlink As DataGridViewLinkColumn = New DataGridViewLinkColumn()
            ColEditlink.UseColumnTextForLinkValue = True
            ColEditlink.HeaderText = "SELECT"
            ColEditlink.DataPropertyName = "RequestId"
            ColEditlink.LinkBehavior = LinkBehavior.SystemDefault
            ColEditlink.Text = "SELECT"
            dgview.Columns.Add(ColEditlink)

            dgview.AutoGenerateColumns = False
            Dim dbobj As New DBOpeartions()
            Dim Ds As DataSet
            Ds = dbobj.GetPendingRequestForTechnician()
            dgview.DataSource = Ds.Tables(0)


        Catch ex As Exception
            Throw
        End Try
        

    End Sub

    Private Sub frmComplete_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            FillData()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub dgview_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgview.CellContentClick
        Dim actionName As String = CType(sender, System.Windows.Forms.DataGridView).Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString()
        Dim RequestId As String = CType(sender, System.Windows.Forms.DataGridView).Rows(e.RowIndex).Cells(GridColumIndex.RequestId).Value.ToString()
        Dim status As String = CType(sender, System.Windows.Forms.DataGridView).Rows(e.RowIndex).Cells(GridColumIndex.Status).Value.ToString.Trim()
        Dim Requester As String = CType(sender, System.Windows.Forms.DataGridView).Rows(e.RowIndex).Cells(GridColumIndex.Requester).Value.ToString.Trim()
        Dim RequestSubject As String = CType(sender, System.Windows.Forms.DataGridView).Rows(e.RowIndex).Cells(GridColumIndex.RequestSubject).Value.ToString.Trim()
        Dim RequestDescription As String = CType(sender, System.Windows.Forms.DataGridView).Rows(e.RowIndex).Cells(GridColumIndex.RequestDescription).Value.ToString.Trim()
        Dim RequestPhone As String = CType(sender, System.Windows.Forms.DataGridView).Rows(e.RowIndex).Cells(GridColumIndex.Phone).Value.ToString.Trim()
        Dim RequestDate As String = CType(sender, System.Windows.Forms.DataGridView).Rows(e.RowIndex).Cells(GridColumIndex.RequestDate).Value.ToString.Trim()

        If actionName.Trim().ToUpper() = "SELECT" Then
            Me.lblRequestId.Text = RequestId
            Me.txtRequestDate.Text = RequestDate
            Me.txtSubject.Text = RequestSubject
            Me.txtDescription.Text = RequestDescription
        End If


    End Sub
End Class