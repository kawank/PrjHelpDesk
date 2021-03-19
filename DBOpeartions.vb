Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks
Imports Microsoft.ApplicationBlocks.Data
Imports System.Configuration

Public Class DBOpeartions
    Private _ConnectionString As String
    Sub New()
        _ConnectionString = ConfigurationManager.ConnectionStrings("ConString").ConnectionString
    End Sub

    Public Function GetUserByUserNameAndPassword(ByVal bv_UserName As String, ByVal bv_Password As String, ByVal bv_UserType As Byte) As DataSet
        Dim ds As New DataSet()
        Try

            SqlHelper.FillDataset(_ConnectionString, StoredProcedureNameConstant.GET_USER_BY_USER_NAME_AND_PASSWORD, ds, New String() {"UserLogin"},
                                  New SqlParameter() {New SqlParameter("@UserName", bv_UserName), New SqlParameter("@Password", bv_Password), New SqlParameter("@userType", bv_UserType)})

            Return ds
        Catch ex As Exception
            Throw (ex)
        End Try
    End Function

    Public Function GetRequestByCriteria(ByVal bv_RequestStatus As Byte, ByVal bv_UserType As Byte, ByVal bv_RequesterUserId As Integer, ByVal bv_RequestFName As String, ByVal bv_RequestLName As String, ByVal bv_RequestId As Integer) As DataSet
        Try
            Dim ds As New DataSet()

            SqlHelper.FillDataset(_ConnectionString, StoredProcedureNameConstant.GET_REQUEST_BY_CRITERIA, ds, New String() {"Request"})
            'New SqlParameter() {New SqlParameter("@RequestStatus", bv_RequestStatus), New SqlParameter("@UserType", bv_UserType),
            'New SqlParameter("@RequesterUserId", bv_RequesterUserId),
            'New SqlParameter("@RequestFName", bv_RequestFName),
            'New SqlParameter("@RequestLName", bv_RequestLName),
            'New SqlParameter("@RequestId", bv_RequestId)
            '})
            Return ds

        Catch ex As Exception
            Throw (ex)
        End Try
    End Function

    Public Sub UpdateRequestByTechnical(ByVal bv_RequestId As Integer, ByVal bv_StatusId As Integer, ByVal bv_FName As String, ByVal bv_LName As String, ByVal Phone As String, ByVal comment As String)
        Try


            SqlHelper.ExecuteNonQuery(_ConnectionString, StoredProcedureNameConstant.UPDATE_REQUEST_BY_TECHNICAL_PERSON, New SqlParameter() {New SqlParameter("@RequestId", bv_RequestId),
New SqlParameter("@StatusId", bv_StatusId),
New SqlParameter("@TechnicalFName", bv_FName),
New SqlParameter("@TechnicalLName", bv_LName),
New SqlParameter("@TechnicalComment", comment),
New SqlParameter("@TechnicalPhone", Phone)})
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub InsertRequestByStaff(ByVal bv_RequestUserId As Integer, ByVal bv_Fname As String, ByVal bv_LName As String, ByVal bv_Phone As String, ByVal bv_Subject As String, ByVal bv_description As String)
        Try
            SqlHelper.ExecuteNonQuery(_ConnectionString, StoredProcedureNameConstant.INSERT_REQUEST_BY_STAFF, New SqlParameter() {New SqlParameter("@RequestserId", bv_RequestUserId), New SqlParameter("@RequestFName", bv_Fname), New SqlParameter("@RequestLName", bv_LName), New SqlParameter("@Phone", bv_Phone), New SqlParameter("@RequestSubject", bv_Subject), New SqlParameter("@RequestDescription", bv_description)})
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub DeleteRequest(ByVal bv_RequestId As Integer)
        Try
            SqlHelper.ExecuteNonQuery(_ConnectionString, StoredProcedureNameConstant.DELETE_REQUEST_BY_ID, New SqlParameter() {New SqlParameter("@RequestId", bv_RequestId)})

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub UpdateRequestByStaff(ByVal bv_RequestUserId As Integer, ByVal bv_Fname As String, ByVal bv_LName As String, ByVal bv_Phone As String, ByVal bv_Subject As String, ByVal bv_description As String, ByVal bv_RequestId As Integer)
        Try
            SqlHelper.ExecuteNonQuery(_ConnectionString, StoredProcedureNameConstant.UPDATE_REQUEST_BY_STAFF, New SqlParameter() {New SqlParameter("@RequestserId", bv_RequestUserId), New SqlParameter("@RequestFName", bv_Fname), New SqlParameter("@RequestLName", bv_LName), New SqlParameter("@Phone", bv_Phone), New SqlParameter("@RequestSubject", bv_Subject), New SqlParameter("@RequestDescription", bv_description), New SqlParameter("@RequestId", bv_RequestId)})
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Function GetPendingRequestForTechnician() As DataSet
        Try
            Dim ds As New DataSet()

            SqlHelper.FillDataset(_ConnectionString, StoredProcedureNameConstant.GET_PENDING_REQUEST_FOR_TECHNICIAN, ds, New String() {"Request"})
            Return ds

        Catch ex As Exception
            Throw (ex)
        End Try
    End Function

    Public Function GetRequestStatistics() As DataSet
        Try
            Dim ds As New DataSet()

            SqlHelper.FillDataset(_ConnectionString, StoredProcedureNameConstant.GET_REQUEST_STATISTICS_REPORT, ds, New String() {"Request"})
            Return ds

        Catch ex As Exception
            Throw (ex)
        End Try
    End Function
End Class
