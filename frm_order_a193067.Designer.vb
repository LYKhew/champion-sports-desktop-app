<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_order_a193067
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_order_a193067))
        Me.lbl_order = New System.Windows.Forms.Label()
        Me.grd_order = New System.Windows.Forms.DataGridView()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        CType(Me.grd_order, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_order
        '
        Me.lbl_order.AutoSize = True
        Me.lbl_order.BackColor = System.Drawing.Color.Transparent
        Me.lbl_order.Font = New System.Drawing.Font("Ravie", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_order.ForeColor = System.Drawing.Color.Black
        Me.lbl_order.Location = New System.Drawing.Point(422, 44)
        Me.lbl_order.Name = "lbl_order"
        Me.lbl_order.Size = New System.Drawing.Size(137, 40)
        Me.lbl_order.TabIndex = 0
        Me.lbl_order.Text = "Order"
        '
        'grd_order
        '
        Me.grd_order.BackgroundColor = System.Drawing.Color.White
        Me.grd_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_order.Location = New System.Drawing.Point(100, 112)
        Me.grd_order.Name = "grd_order"
        Me.grd_order.ReadOnly = True
        Me.grd_order.RowHeadersWidth = 51
        Me.grd_order.RowTemplate.Height = 24
        Me.grd_order.Size = New System.Drawing.Size(798, 334)
        Me.grd_order.TabIndex = 1
        '
        'btn_insert
        '
        Me.btn_insert.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_insert.Font = New System.Drawing.Font("Ravie", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insert.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_insert.Location = New System.Drawing.Point(307, 480)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(390, 60)
        Me.btn_insert.TabIndex = 12
        Me.btn_insert.Text = "Make Order"
        Me.btn_insert.UseVisualStyleBackColor = False
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_update.Font = New System.Drawing.Font("Ravie", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_update.Location = New System.Drawing.Point(307, 568)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(390, 60)
        Me.btn_update.TabIndex = 11
        Me.btn_update.Text = " View Order"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'frm_order_a193067
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1002, 681)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.grd_order)
        Me.Controls.Add(Me.lbl_order)
        Me.DoubleBuffered = True
        Me.Name = "frm_order_a193067"
        Me.Text = "frm_order_a193067"
        CType(Me.grd_order, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_order As Label
    Friend WithEvents grd_order As DataGridView
    Friend WithEvents btn_insert As Button
    Friend WithEvents btn_update As Button
End Class
