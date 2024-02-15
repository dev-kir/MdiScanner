<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnScan = New System.Windows.Forms.Button()
        Me.txtInterval = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_add
        '
        Me.btn_add.Location = New System.Drawing.Point(713, 12)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(75, 23)
        Me.btn_add.TabIndex = 0
        Me.btn_add.Text = "ADD"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 41)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(776, 368)
        Me.DataGridView1.TabIndex = 2
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(512, 415)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(75, 23)
        Me.btnStop.TabIndex = 7
        Me.btnStop.Text = "STOP"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnScan
        '
        Me.btnScan.Location = New System.Drawing.Point(431, 415)
        Me.btnScan.Name = "btnScan"
        Me.btnScan.Size = New System.Drawing.Size(75, 23)
        Me.btnScan.TabIndex = 8
        Me.btnScan.Text = "SCAN"
        Me.btnScan.UseVisualStyleBackColor = True
        '
        'txtInterval
        '
        Me.txtInterval.Location = New System.Drawing.Point(325, 418)
        Me.txtInterval.Name = "txtInterval"
        Me.txtInterval.Size = New System.Drawing.Size(100, 20)
        Me.txtInterval.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(198, 421)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "INTERVAL (MINUTES):"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtInterval)
        Me.Controls.Add(Me.btnScan)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btn_add)
        Me.Name = "Form1"
        Me.Text = "MdiScanner"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_add As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnStop As Button
    Friend WithEvents btnScan As Button
    Friend WithEvents txtInterval As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
End Class
