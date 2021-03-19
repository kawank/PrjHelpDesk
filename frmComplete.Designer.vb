<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComplete
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.grpRequestDetail = New System.Windows.Forms.GroupBox()
        Me.lblRequestId = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtSubject = New System.Windows.Forms.TextBox()
        Me.txtRequestDate = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpTechnical = New System.Windows.Forms.GroupBox()
        Me.TxtComments = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.TxtLName = New System.Windows.Forms.TextBox()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnCompleted = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgview = New System.Windows.Forms.DataGridView()
        Me.RequestId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RequesterFName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Requester = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Phone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RequestDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RequestSubject = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RequestDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grpRequestDetail.SuspendLayout()
        Me.grpTechnical.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpRequestDetail
        '
        Me.grpRequestDetail.BackgroundImage = Global.PrjHelpDesk.My.Resources.Resources.LogInImages
        Me.grpRequestDetail.Controls.Add(Me.lblRequestId)
        Me.grpRequestDetail.Controls.Add(Me.txtDescription)
        Me.grpRequestDetail.Controls.Add(Me.txtSubject)
        Me.grpRequestDetail.Controls.Add(Me.txtRequestDate)
        Me.grpRequestDetail.Controls.Add(Me.Label3)
        Me.grpRequestDetail.Controls.Add(Me.Label2)
        Me.grpRequestDetail.Controls.Add(Me.Label1)
        Me.grpRequestDetail.ForeColor = System.Drawing.Color.White
        Me.grpRequestDetail.Location = New System.Drawing.Point(7, 251)
        Me.grpRequestDetail.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.grpRequestDetail.Name = "grpRequestDetail"
        Me.grpRequestDetail.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.grpRequestDetail.Size = New System.Drawing.Size(972, 152)
        Me.grpRequestDetail.TabIndex = 0
        Me.grpRequestDetail.TabStop = False
        Me.grpRequestDetail.Text = "Selected Request Detail"
        '
        'lblRequestId
        '
        Me.lblRequestId.AutoSize = True
        Me.lblRequestId.Location = New System.Drawing.Point(845, 19)
        Me.lblRequestId.Name = "lblRequestId"
        Me.lblRequestId.Size = New System.Drawing.Size(0, 14)
        Me.lblRequestId.TabIndex = 6
        '
        'txtDescription
        '
        Me.txtDescription.Enabled = False
        Me.txtDescription.Location = New System.Drawing.Point(163, 76)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(790, 44)
        Me.txtDescription.TabIndex = 5
        '
        'txtSubject
        '
        Me.txtSubject.Enabled = False
        Me.txtSubject.Location = New System.Drawing.Point(163, 48)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(480, 22)
        Me.txtSubject.TabIndex = 4
        '
        'txtRequestDate
        '
        Me.txtRequestDate.Enabled = False
        Me.txtRequestDate.Location = New System.Drawing.Point(163, 20)
        Me.txtRequestDate.Name = "txtRequestDate"
        Me.txtRequestDate.Size = New System.Drawing.Size(100, 22)
        Me.txtRequestDate.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(10, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 14)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Request Description"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(10, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 14)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Request Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(10, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Request Subject"
        '
        'grpTechnical
        '
        Me.grpTechnical.BackgroundImage = Global.PrjHelpDesk.My.Resources.Resources.LogInImages
        Me.grpTechnical.Controls.Add(Me.TxtComments)
        Me.grpTechnical.Controls.Add(Me.Label7)
        Me.grpTechnical.Controls.Add(Me.txtPhone)
        Me.grpTechnical.Controls.Add(Me.TxtLName)
        Me.grpTechnical.Controls.Add(Me.txtFName)
        Me.grpTechnical.Controls.Add(Me.Label6)
        Me.grpTechnical.Controls.Add(Me.Label5)
        Me.grpTechnical.Controls.Add(Me.Label4)
        Me.grpTechnical.ForeColor = System.Drawing.Color.White
        Me.grpTechnical.Location = New System.Drawing.Point(7, 393)
        Me.grpTechnical.Name = "grpTechnical"
        Me.grpTechnical.Size = New System.Drawing.Size(973, 137)
        Me.grpTechnical.TabIndex = 1
        Me.grpTechnical.TabStop = False
        Me.grpTechnical.Text = "Technician Area"
        '
        'TxtComments
        '
        Me.TxtComments.Location = New System.Drawing.Point(163, 55)
        Me.TxtComments.Multiline = True
        Me.TxtComments.Name = "TxtComments"
        Me.TxtComments.Size = New System.Drawing.Size(790, 55)
        Me.TxtComments.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(596, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 14)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Phone"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(660, 25)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(154, 22)
        Me.txtPhone.TabIndex = 5
        '
        'TxtLName
        '
        Me.TxtLName.Location = New System.Drawing.Point(421, 27)
        Me.TxtLName.Name = "TxtLName"
        Me.TxtLName.Size = New System.Drawing.Size(154, 22)
        Me.TxtLName.TabIndex = 4
        '
        'txtFName
        '
        Me.txtFName.Location = New System.Drawing.Point(163, 25)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(154, 22)
        Me.txtFName.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(10, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 14)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Comments"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(323, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 14)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Last Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(10, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 14)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "First Name"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global.PrjHelpDesk.My.Resources.Resources.LogInImages
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Controls.Add(Me.btnCompleted)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 515)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(973, 64)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(411, 21)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnCompleted
        '
        Me.btnCompleted.Location = New System.Drawing.Point(251, 21)
        Me.btnCompleted.Name = "btnCompleted"
        Me.btnCompleted.Size = New System.Drawing.Size(154, 23)
        Me.btnCompleted.TabIndex = 0
        Me.btnCompleted.Text = "Mark as  C&ompleted"
        Me.btnCompleted.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackgroundImage = Global.PrjHelpDesk.My.Resources.Resources.LogInImages
        Me.GroupBox2.Controls.Add(Me.dgview)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(7, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(971, 255)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Select Request"
        '
        'dgview
        '
        Me.dgview.AllowUserToAddRows = False
        Me.dgview.AllowUserToDeleteRows = False
        Me.dgview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgview.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RequestId, Me.RequesterFName, Me.Requester, Me.Phone, Me.RequestDate, Me.RequestSubject, Me.RequestDescription, Me.Status})
        Me.dgview.Location = New System.Drawing.Point(7, 21)
        Me.dgview.Name = "dgview"
        Me.dgview.ReadOnly = True
        Me.dgview.Size = New System.Drawing.Size(946, 216)
        Me.dgview.TabIndex = 2
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
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.RequestDescription.DefaultCellStyle = DataGridViewCellStyle2
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
        'frmComplete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PrjHelpDesk.My.Resources.Resources.LogInImages
        Me.ClientSize = New System.Drawing.Size(992, 591)
        Me.Controls.Add(Me.grpTechnical)
        Me.Controls.Add(Me.grpRequestDetail)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmComplete"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Complete Request"
        Me.grpRequestDetail.ResumeLayout(False)
        Me.grpRequestDetail.PerformLayout()
        Me.grpTechnical.ResumeLayout(False)
        Me.grpTechnical.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpRequestDetail As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtSubject As System.Windows.Forms.TextBox
    Friend WithEvents txtRequestDate As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grpTechnical As System.Windows.Forms.GroupBox
    Friend WithEvents TxtComments As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents TxtLName As System.Windows.Forms.TextBox
    Friend WithEvents txtFName As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnCompleted As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents dgview As System.Windows.Forms.DataGridView
    Friend WithEvents RequestId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RequesterFName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Requester As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Phone As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RequestDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RequestSubject As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RequestDescription As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblRequestId As System.Windows.Forms.Label
End Class
