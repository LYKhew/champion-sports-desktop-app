<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_vieworder_a193067
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_vieworder_a193067))
        Me.lbl_invoice = New System.Windows.Forms.Label()
        Me.lbl_address1 = New System.Windows.Forms.Label()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.lbl_address2 = New System.Windows.Forms.Label()
        Me.lbl_notel = New System.Windows.Forms.Label()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.grd_orderdetails = New System.Windows.Forms.DataGridView()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.lbl_subTotal = New System.Windows.Forms.Label()
        Me.txt_subtotal = New System.Windows.Forms.TextBox()
        CType(Me.grd_orderdetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_invoice
        '
        Me.lbl_invoice.AutoSize = True
        Me.lbl_invoice.BackColor = System.Drawing.Color.Transparent
        Me.lbl_invoice.Font = New System.Drawing.Font("Ravie", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_invoice.Location = New System.Drawing.Point(495, 19)
        Me.lbl_invoice.Name = "lbl_invoice"
        Me.lbl_invoice.Size = New System.Drawing.Size(174, 44)
        Me.lbl_invoice.TabIndex = 1
        Me.lbl_invoice.Text = "Invoice"
        '
        'lbl_address1
        '
        Me.lbl_address1.AutoSize = True
        Me.lbl_address1.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_address1.Location = New System.Drawing.Point(460, 118)
        Me.lbl_address1.Name = "lbl_address1"
        Me.lbl_address1.Size = New System.Drawing.Size(225, 22)
        Me.lbl_address1.TabIndex = 25
        Me.lbl_address1.Text = "No 16, Laluan Mutiara 3"
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Ravie", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(354, 74)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(431, 44)
        Me.lbl_title.TabIndex = 26
        Me.lbl_title.Text = "CHAMPION SPORTS"
        '
        'lbl_address2
        '
        Me.lbl_address2.AutoSize = True
        Me.lbl_address2.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_address2.Location = New System.Drawing.Point(460, 140)
        Me.lbl_address2.Name = "lbl_address2"
        Me.lbl_address2.Size = New System.Drawing.Size(214, 22)
        Me.lbl_address2.TabIndex = 27
        Me.lbl_address2.Text = "Taman Pertama, Perak"
        '
        'lbl_notel
        '
        Me.lbl_notel.AutoSize = True
        Me.lbl_notel.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_notel.Location = New System.Drawing.Point(465, 162)
        Me.lbl_notel.Name = "lbl_notel"
        Me.lbl_notel.Size = New System.Drawing.Size(209, 22)
        Me.lbl_notel.TabIndex = 28
        Me.lbl_notel.Text = "Phone : 011-26101538"
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_email.Location = New System.Drawing.Point(403, 184)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(337, 22)
        Me.lbl_email.TabIndex = 29
        Me.lbl_email.Text = "Email: championsports@gmail.com"
        '
        'grd_orderdetails
        '
        Me.grd_orderdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_orderdetails.Location = New System.Drawing.Point(67, 279)
        Me.grd_orderdetails.Name = "grd_orderdetails"
        Me.grd_orderdetails.ReadOnly = True
        Me.grd_orderdetails.RowHeadersWidth = 51
        Me.grd_orderdetails.RowTemplate.Height = 24
        Me.grd_orderdetails.Size = New System.Drawing.Size(989, 254)
        Me.grd_orderdetails.TabIndex = 34
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.BackColor = System.Drawing.Color.Transparent
        Me.lbl_total.Font = New System.Drawing.Font("Ravie", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.Location = New System.Drawing.Point(567, 656)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(173, 27)
        Me.lbl_total.TabIndex = 39
        Me.lbl_total.Text = "Total (RM) :"
        '
        'txt_total
        '
        Me.txt_total.Location = New System.Drawing.Point(760, 662)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.ReadOnly = True
        Me.txt_total.Size = New System.Drawing.Size(177, 22)
        Me.txt_total.TabIndex = 40
        '
        'lbl_subTotal
        '
        Me.lbl_subTotal.AutoSize = True
        Me.lbl_subTotal.BackColor = System.Drawing.Color.Transparent
        Me.lbl_subTotal.Font = New System.Drawing.Font("Ravie", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_subTotal.Location = New System.Drawing.Point(519, 573)
        Me.lbl_subTotal.Name = "lbl_subTotal"
        Me.lbl_subTotal.Size = New System.Drawing.Size(221, 27)
        Me.lbl_subTotal.TabIndex = 41
        Me.lbl_subTotal.Text = "Sub Total (RM):"
        '
        'txt_subtotal
        '
        Me.txt_subtotal.Location = New System.Drawing.Point(760, 578)
        Me.txt_subtotal.Name = "txt_subtotal"
        Me.txt_subtotal.ReadOnly = True
        Me.txt_subtotal.Size = New System.Drawing.Size(177, 22)
        Me.txt_subtotal.TabIndex = 42
        '
        'frm_vieworder_a193067
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1118, 821)
        Me.Controls.Add(Me.txt_subtotal)
        Me.Controls.Add(Me.lbl_subTotal)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.grd_orderdetails)
        Me.Controls.Add(Me.lbl_email)
        Me.Controls.Add(Me.lbl_notel)
        Me.Controls.Add(Me.lbl_address2)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.lbl_address1)
        Me.Controls.Add(Me.lbl_invoice)
        Me.Name = "frm_vieworder_a193067"
        Me.Text = "frm_vieworder_a193067"
        CType(Me.grd_orderdetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_invoice As Label
    Friend WithEvents lbl_address1 As Label
    Friend WithEvents lbl_title As Label
    Friend WithEvents lbl_address2 As Label
    Friend WithEvents lbl_notel As Label
    Friend WithEvents lbl_email As Label
    Friend WithEvents grd_orderdetails As DataGridView
    Friend WithEvents lbl_total As Label
    Friend WithEvents txt_total As TextBox
    Friend WithEvents lbl_subTotal As Label
    Friend WithEvents txt_subtotal As TextBox
End Class
