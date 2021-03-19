Public Class frmViewRequest
    Private Enum GridColumIndex
        RequestId = 0
        RequestUserId
        Requester
        Phone
        RequestDate
        RequestSubject
        RequestDescription
        Status
        Technician
        TechnicianPhone
        CompletionDate
        TEchnicalComment

    End Enum

    Private Sub frmViewRequest_Load(sender As Object, e As EventArgs) Handles Me.Load
        FillGrid()
    End Sub

    Private Sub FillGrid()
        Try
            dgview.AutoGenerateColumns = False
            Dim dbobj As New DBOpeartions()
            Dim Ds As DataSet
            Ds = dbobj.GetRequestByCriteria(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            dgview.DataSource = Ds.Tables(0)

            'Add two columns

            Dim ColEditlink As DataGridViewLinkColumn = New DataGridViewLinkColumn()
            ColEditlink.UseColumnTextForLinkValue = True
            ColEditlink.HeaderText = "Edit"
            ColEditlink.DataPropertyName = "RequestId"
            ColEditlink.LinkBehavior = LinkBehavior.SystemDefault
            ColEditlink.Text = "Edit"
            dgview.Columns.Add(ColEditlink)

            Dim ColDeletelink As DataGridViewLinkColumn = New DataGridViewLinkColumn()

            ColDeletelink.UseColumnTextForLinkValue = True
            ColDeletelink.HeaderText = "delete"
            ColDeletelink.DataPropertyName = "RequestId"
            ColDeletelink.LinkBehavior = LinkBehavior.SystemDefault
            ColDeletelink.Text = "Delete"
            dgview.Columns.Add(ColDeletelink)

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub dgview_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgview.CellContentClick
        Try


            Dim actionName As String = CType(sender, System.Windows.Forms.DataGridView).Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString()
            Dim RequestId As String = CType(sender, System.Windows.Forms.DataGridView).Rows(e.RowIndex).Cells(GridColumIndex.RequestId).Value.ToString()
            Dim status As String = CType(sender, System.Windows.Forms.DataGridView).Rows(e.RowIndex).Cells(GridColumIndex.Status).Value.ToString.Trim()
            Dim Requester As String = CType(sender, System.Windows.Forms.DataGridView).Rows(e.RowIndex).Cells(GridColumIndex.Requester).Value.ToString.Trim()
            Dim RequestSubject As String = CType(sender, System.Windows.Forms.DataGridView).Rows(e.RowIndex).Cells(GridColumIndex.RequestSubject).Value.ToString.Trim()
            Dim RequestDescription As String = CType(sender, System.Windows.Forms.DataGridView).Rows(e.RowIndex).Cells(GridColumIndex.RequestDescription).Value.ToString.Trim()
            Dim RequestPhone As String = CType(sender, System.Windows.Forms.DataGridView).Rows(e.RowIndex).Cells(GridColumIndex.Phone).Value.ToString.Trim()

            If actionName.Trim().ToUpper() = "EDIT" Then
                If lblUserType.Text.Trim() = UserTypeConstants.STAFF.ToString() Then
                    If status.Trim().ToUpper() = "PENDING" Then
                        Dim frmStaff As New frmAddRequest()
                        frmStaff.lblRequestUserId.Text = CType(Me.MdiParent, frmMain).lblUserId.Text.Trim()
                        frmStaff.txtFname.Text = Requester.Split(",").GetValue(0)
                        frmStaff.txtLName.Text = Requester.Split(",").GetValue(1)
                        frmStaff.txtPhone.Text = RequestPhone.Trim()
                        frmStaff.txtDescription.Text = RequestDescription
                        frmStaff.txtSubject.Text = RequestSubject
                        frmStaff.btnSave.Text = "UPDATE"
                        frmStaff.lblRequestId.Text = RequestId
                        frmStaff.MdiParent = Me.MdiParent
                        frmStaff.Show()
                        Me.Hide()
                    Else
                        MessageBox.Show(MessagesConstant.YOU_CAN_EDIT_ONLY_PENDING_REQUEST)
                    End If

                Else
                    MessageBox.Show(MessagesConstant.YOU_DO_NOT_HAVE_PERMISSION_HERE_ONLY_STAFF_CAN_EDIT)

                End If
            ElseIf actionName.Trim().ToUpper() = "DELETE" Then
                If (lblUserType.Text.Trim() = UserTypeConstants.MANAGER) Then
                    If (MessageBox.Show(MessagesConstant.ARE_YOU_SURE_WANT_TO_DELETE, "HelpDesk", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes) Then
                        If (DeleteRecord(RequestId)) Then
                        End If
                    End If
                Else
                    MessageBox.Show(MessagesConstant.YOU_DO_NOT_HAVE_PERMISSION_DELETE)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Function DeleteRecord(ByVal bv_RequestId As Integer) As Boolean
        Try
            Dim blnDelete As Boolean = True
            Dim objDB As New DBOpeartions()
            objDB.DeleteRequest(bv_RequestId)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try


    End Function
End Class
