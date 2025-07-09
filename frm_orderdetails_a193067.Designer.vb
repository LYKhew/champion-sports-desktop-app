<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_orderdetails_a193067
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_orderdetails_a193067))
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.grd_orderdetails = New System.Windows.Forms.DataGridView()
        CType(Me.grd_orderdetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Ravie", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_title.Location = New System.Drawing.Point(339, 56)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(302, 40)
        Me.lbl_title.TabIndex = 0
        Me.lbl_title.Text = "Order Details"
        '
        'grd_orderdetails
        '
        Me.grd_orderdetails.BackgroundColor = System.Drawing.Color.White
        Me.grd_orderdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_orderdetails.Location = New System.Drawing.Point(106, 121)
        Me.grd_orderdetails.Name = "grd_orderdetails"
        Me.grd_orderdetails.ReadOnly = True
        Me.grd_orderdetails.RowHeadersWidth = 51
        Me.grd_orderdetails.RowTemplate.Height = 24
        Me.grd_orderdetails.Size = New System.Drawing.Size(754, 336)
        Me.grd_orderdetails.TabIndex = 1
        '
        'frm_orderdetails_a193067
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(995, 556)
        Me.Controls.Add(Me.grd_orderdetails)
        Me.Controls.Add(Me.lbl_title)
        Me.DoubleBuffered = True
        Me.Name = "frm_orderdetails_a193067"
        Me.Text = "frm_orderdetails_a193067"
        CType(Me.grd_orderdetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_title As Label
    Friend WithEvents grd_orderdetails As DataGridView
End Class
