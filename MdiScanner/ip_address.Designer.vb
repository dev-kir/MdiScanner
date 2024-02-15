<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ip_address
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btn_return = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtIp_address = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_return
        '
        Me.btn_return.Location = New System.Drawing.Point(713, 12)
        Me.btn_return.Name = "btn_return"
        Me.btn_return.Size = New System.Drawing.Size(75, 23)
        Me.btn_return.TabIndex = 0
        Me.btn_return.Text = "RETURN"
        Me.btn_return.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 41)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(776, 368)
        Me.DataGridView1.TabIndex = 1
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(336, 417)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(358, 20)
        Me.txtName.TabIndex = 0
        '
        'txtIp_address
        '
        Me.txtIp_address.Location = New System.Drawing.Point(93, 417)
        Me.txtIp_address.Name = "txtIp_address"
        Me.txtIp_address.Size = New System.Drawing.Size(190, 20)
        Me.txtIp_address.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 420)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "IP ADDRESS:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(289, 420)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "NAME:"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(713, 415)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'ip_address
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtIp_address)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btn_return)
        Me.Name = "ip_address"
        Me.Text = "ip_address"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_return As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtIp_address As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAdd As Button
End Class
