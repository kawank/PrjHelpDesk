<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReport
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgview = New System.Windows.Forms.DataGridView()
        Me.RequestId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RequesterFName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Requester = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Phone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global.PrjHelpDesk.My.Resources.Resources.LogInImages
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 4)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(1124, 67)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackgroundImage = Global.PrjHelpDesk.My.Resources.Resources.LogInImages
        Me.GroupBox2.Controls.Add(Me.dgview)
        Me.GroupBox2.Location = New System.Drawing.Point(4, 82)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox2.Size = New System.Drawing.Size(1127, 535)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(376, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(344, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Datewise Request Statistics Report"
        '
        'dgview
        '
        Me.dgview.AllowUserToAddRows = False
        Me.dgview.AllowUserToDeleteRows = False
        Me.dgview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgview.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RequestId, Me.RequesterFName, Me.Requester, Me.Phone})
        Me.dgview.Location = New System.Drawing.Point(77, 31)
        Me.dgview.Name = "dgview"
        Me.dgview.ReadOnly = True
        Me.dgview.Size = New System.Drawing.Size(891, 481)
        Me.dgview.TabIndex = 2
        '
        'RequestId
        '
        Me.RequestId.DataPropertyName = "RequestDate"
        Me.RequestId.HeaderText = "Date"
        Me.RequestId.Name = "RequestId"
        Me.RequestId.ReadOnly = True
        '
        'RequesterFName
        '
        Me.RequesterFName.DataPropertyName = "TotalRequestCount"
        Me.RequesterFName.HeaderText = "Total Request(s)"
        Me.RequesterFName.Name = "RequesterFName"
        Me.RequesterFName.ReadOnly = True
        '
        'Requester
        '
        Me.Requester.DataPropertyName = "TotalPendingRequest"
        Me.Requester.HeaderText = "Pending Requests"
        Me.Requester.Name = "Requester"
        Me.Requester.ReadOnly = True
        '
        'Phone
        '
        Me.Phone.DataPropertyName = "TotalCompletedRequest"
        Me.Phone.HeaderText = "Completed Requests"
        Me.Phone.Name = "Phone"
        Me.Phone.ReadOnly = True
        '
        'frmReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PrjHelpDesk.My.Resources.Resources.LogInImages
        Me.ClientSize = New System.Drawing.Size(1144, 641)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Report"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents dgview As System.Windows.Forms.DataGridView
    Friend WithEvents RequestId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RequesterFName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Requester As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Phone As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
