Public Class UserTypeConstants
    Public Const STAFF As Integer = 0
    Public Const TECHNICAL As Integer = 1
    Public Const MANAGER As Integer = 2

End Class

Public Class RequestStatusConstants
    Public Const PENDING As Integer = 0
    Public Const COMPLETED As Integer = 1
    Public Const INPROGRESS As Integer = 2
End Class

Public Class StoredProcedureNameConstant
    Public Const CREATE_REQUEST_BY_STAFF As String = "proc_CreateRequestByStaff"
    Public Const UPDATE_REQUEST_BY_TECHNICAL_PERSON As String = "proc_UpdateRequestByTechnical"
    Public Const GET_USER_BY_USER_NAME_AND_PASSWORD As String = "proc_GetUserByUserNameAndPassword"
    Public Const GET_REQUEST_BY_CRITERIA As String = "Proc_GetRequestByCriteria"
    Public Const INSERT_REQUEST_BY_STAFF As String = "proc_InsertRequestByStaff"
    Public Const DELETE_REQUEST_BY_ID As String = "proc_DeleteRequestById"
    Public Const UPDATE_REQUEST_BY_STAFF As String = "proc_UpdateRequestByStaff"
    Public Const GET_PENDING_REQUEST_FOR_TECHNICIAN As String = "proc_GetPendingRequestForTechnician"
    Public Const GET_REQUEST_STATISTICS_REPORT As String = "proc_GetRequestStatisticsReport"

End Class

Public Class MessagesConstant
    Public Const LOGIN_INVALID As String = "InValid Login!"
    Public Const REQUEST_SAVED As String = "Request Saved Successfully!"
    Public Const REQUEST_UPDATED As String = "Request Updated Successfully!"
    Public Const REQUEST_FAILED As String = "Request is Failed!"
    Public Const REQUEST_COMPLETED As String = "Request is Completed!"
    Public Const USER_NAME_IS_REQUIRED As String = "UserName is required!"
    Public Const PASSWORD_IS_REQUIRED As String = "Password is required!"
    Public Const MANDATORY_FIELD_CAN_NOT_BE_EMPTY As String = "Madatory Field(s) can not be empty! "
    Public Const FIRST_NAME_REQUIRED As String = "First Name is required!"
    Public Const LAST_NAME_REQUIRED As String = "Last Name is Required!"
    Public Const PHONE_REQUIRED As String = "Phone # is required!"
    Public Const COMMENT_REQUIRED As String = "Comment is required!"
    Public Const SUBJECT_REQUIRED As String = "Subject is required!"
    Public Const DESCRIPTION_REQUIRED As String = "Description is required!"
    Public Const USERTYPE_REQUIRED As String = "UserType is required!"
    Public Const ARE_YOU_SURE_WANT_TO_DELETE As String = "Are you sure you want to delete record (Y/N) ?"
    Public Const YOU_DO_NOT_HAVE_PERMISSION_DELETE As String = "You don't have Proper permission only Manager's can delete records!"
    Public Const YOU_CAN_EDIT_ONLY_PENDING_REQUEST As String = "You can edit only Pending request!"
    Public Const YOU_DO_NOT_HAVE_PERMISSION_HERE_ONLY_STAFF_CAN_EDIT As String = "You don't have permission to edit from here only staff user can edit!"
    Public Const SELECT_RECORD_FIRST_TO_COMPLETE As String = "Select the record first from above grid!"
End Class

Public Class Utilities
    Public Shared Sub ClearAllTextBox(ByVal bv_GroupBox As GroupBox)
        For Each ctrl As Control In bv_GroupBox.Controls
            If TypeOf ctrl Is TextBox Then
                ctrl.Text = String.Empty
            End If
        Next

    End Sub

End Class