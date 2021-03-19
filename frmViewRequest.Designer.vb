<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewRequest
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgview = New System.Windows.Forms.DataGridView()
        Me.RequestId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RequesterFName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Requester = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Phone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RequestDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RequestSubject = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RequestDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TechnicianFName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TechnicianPhone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RequestCompletedDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TechnicianComment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblUserType = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.dgview)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 5)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(1195, 476)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'dgview
        '
        Me.dgview.AllowUserToAddRows = False
        Me.dgview.AllowUserToDeleteRows = False
        Me.dgview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgview.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RequestId, Me.RequesterFName, Me.Requester, Me.Phone, Me.RequestDate, Me.RequestSubject, Me.RequestDescription, Me.Status, Me.TechnicianFName, Me.TechnicianPhone, Me.RequestCompletedDate, Me.TechnicianComment})
        Me.dgview.Location = New System.Drawing.Point(7, 21)
        Me.dgview.Name = "dgview"
        Me.dgview.ReadOnly = True
        Me.dgview.Size = New System.Drawing.Size(1155, 438)
        Me.dgview.TabIndex = 1
        '
        'RequestId
        '
        Me.RequestId.DataPropertyName = "RequestId"
        Me.RequestId.HeaderText = "RequestId"
        Me.RequestId.Name = "RequestId"
        Me.RequestId.ReadOnly = True
        Me.RequestId.Visible = False
        '
        'RequesterFName
        '
        Me.RequesterFName.DataPropertyName = "RequestUserId"
        Me.RequesterFName.HeaderText = "RequestUserId"
        Me.RequesterFName.Name = "RequesterFName"
        Me.RequesterFName.ReadOnly = True
        Me.RequesterFName.Visible = False
        '
        'Requester
        '
        Me.Requester.DataPropertyName = "Requester"
        Me.Requester.HeaderText = "Requester"
        Me.Requester.Name = "Requester"
        Me.Requester.ReadOnly = True
        '
        'Phone
        '
        Me.Phone.DataPropertyName = "Phone"
        Me.Phone.HeaderText = "Phone"
        Me.Phone.Name = "Phone"
        Me.Phone.ReadOnly = True
        '
        'RequestDate
        '
        Me.RequestDate.DataPropertyName = "RequestDateTime"
        Me.RequestDate.HeaderText = "RequestDate"
        Me.RequestDate.Name = "RequestDate"
        Me.RequestDate.ReadOnly = True
        '
        'RequestSubject
        '
        Me.RequestSubject.DataPropertyName = "RequestSubject"
        Me.RequestSubject.HeaderText = "RequestSubject"
        Me.RequestSubject.Name = "RequestSubject"
        Me.RequestSubject.ReadOnly = True
        '
        'RequestDescription
        '
        Me.RequestDescription.DataPropertyName = "RequestDescription"
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.RequestDescription.DefaultCellStyle = DataGridViewCellStyle1
        Me.RequestDescription.HeaderText = "RequestDescription"
        Me.RequestDescription.Name = "RequestDescription"
        Me.RequestDescription.ReadOnly = True
        '
        'Status
        '
        Me.Status.DataPropertyName = "Status"
        Me.Status.HeaderText = "Status"
        Me.Status.Name = "Status"
        Me.Status.ReadOnly = True
        '
        'TechnicianFName
        '
        Me.TechnicianFName.DataPropertyName = "Technician"
        Me.TechnicianFName.HeaderText = "Technician"
        Me.TechnicianFName.Name = "TechnicianFName"
        Me.TechnicianFName.ReadOnly = True
        '
        'TechnicianPhone
        '
        Me.TechnicianPhone.DataPropertyName = "TechnicianPhone"
        Me.TechnicianPhone.HeaderText = "TechnicianPhone"
        Me.TechnicianPhone.Name = "TechnicianPhone"
        Me.TechnicianPhone.ReadOnly = True
        '
        'RequestCompletedDate
        '
        Me.RequestCompletedDate.DataPropertyName = "RequestCompletedDate"
        Me.RequestCompletedDate.HeaderText = "Completion Date"
        Me.RequestCompletedDate.Name = "RequestCompletedDate"
        Me.RequestCompletedDate.ReadOnly = True
        '
        'TechnicianComment
        '
        Me.TechnicianComment.DataPropertyName = "TechnicianComment"
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TechnicianComment.DefaultCellStyle = DataGridViewCellStyle2
        Me.TechnicianComment.HeaderText = " TechnicianComment"
        Me.TechnicianComment.Name = "TechnicianComment"
        Me.TechnicianComment.ReadOnly = True
        '
        'lblUserType
        '
        Me.lblUserType.AutoSize = True
        Me.lblUserType.Location = New System.Drawing.Point(735, 471)
        Me.lblUserType.Name = "lblUserType"
        Me.lblUserType.Size = New System.Drawing.Size(0, 14)
        Me.lblUserType.TabIndex = 1
        Me.lblUserType.Visible = False
        '
        'frmViewRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PrjHelpDesk.My.Resources.Resources.LogInImages
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1207, 493)
        Me.Controls.Add(Me.lblUserType)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmViewRequest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmViewRequest"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents dgview As System.Windows.Forms.DataGridView
    Friend WithEvents RequestId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RequesterFName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Requester As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Phone As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RequestDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RequestSubject As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RequestDescription As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TechnicianFName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TechnicianPhone As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RequestCompletedDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TechnicianComment As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblUserType As System.Windows.Forms.Label
End Class
