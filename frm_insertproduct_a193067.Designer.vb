<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_insertproduct_a193067
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_insertproduct_a193067))
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.btn_selectpic = New System.Windows.Forms.Button()
        Me.lbl_productID = New System.Windows.Forms.Label()
        Me.txt_productID = New System.Windows.Forms.TextBox()
        Me.lbl_productname = New System.Windows.Forms.Label()
        Me.txt_produtname = New System.Windows.Forms.TextBox()
        Me.lbl_type = New System.Windows.Forms.Label()
        Me.cmb_type = New System.Windows.Forms.ComboBox()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.lbl_size = New System.Windows.Forms.Label()
        Me.txt_size = New System.Windows.Forms.TextBox()
        Me.lbl_quantity = New System.Windows.Forms.Label()
        Me.txt_quantity = New System.Windows.Forms.TextBox()
        Me.lbl_gender = New System.Windows.Forms.Label()
        Me.cmb_gender = New System.Windows.Forms.ComboBox()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.lbl_brand = New System.Windows.Forms.Label()
        Me.grd_insertproduct = New System.Windows.Forms.DataGridView()
        Me.txt_picture = New System.Windows.Forms.TextBox()
        Me.lbl_instructions = New System.Windows.Forms.Label()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_insertproduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Ravie", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(355, 57)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(377, 44)
        Me.lbl_title.TabIndex = 0
        Me.lbl_title.Text = "Insert Products"
        '
        'pic_product
        '
        Me.pic_product.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic_product.Location = New System.Drawing.Point(48, 428)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(251, 285)
        Me.pic_product.TabIndex = 1
        Me.pic_product.TabStop = False
        '
        'btn_selectpic
        '
        Me.btn_selectpic.BackColor = System.Drawing.Color.LightCoral
        Me.btn_selectpic.Font = New System.Drawing.Font("Ravie", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_selectpic.ForeColor = System.Drawing.Color.White
        Me.btn_selectpic.Location = New System.Drawing.Point(63, 793)
        Me.btn_selectpic.Name = "btn_selectpic"
        Me.btn_selectpic.Size = New System.Drawing.Size(227, 44)
        Me.btn_selectpic.TabIndex = 2
        Me.btn_selectpic.Text = "Select Picture"
        Me.btn_selectpic.UseVisualStyleBackColor = False
        '
        'lbl_productID
        '
        Me.lbl_productID.AutoSize = True
        Me.lbl_productID.BackColor = System.Drawing.Color.Transparent
        Me.lbl_productID.Font = New System.Drawing.Font("Ravie", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_productID.Location = New System.Drawing.Point(345, 430)
        Me.lbl_productID.Name = "lbl_productID"
        Me.lbl_productID.Size = New System.Drawing.Size(130, 22)
        Me.lbl_productID.TabIndex = 3
        Me.lbl_productID.Text = "ProductID:"
        '
        'txt_productID
        '
        Me.txt_productID.Location = New System.Drawing.Point(349, 479)
        Me.txt_productID.Name = "txt_productID"
        Me.txt_productID.ReadOnly = True
        Me.txt_productID.Size = New System.Drawing.Size(189, 22)
        Me.txt_productID.TabIndex = 4
        '
        'lbl_productname
        '
        Me.lbl_productname.AutoSize = True
        Me.lbl_productname.BackColor = System.Drawing.Color.Transparent
        Me.lbl_productname.Font = New System.Drawing.Font("Ravie", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_productname.Location = New System.Drawing.Point(345, 541)
        Me.lbl_productname.Name = "lbl_productname"
        Me.lbl_productname.Size = New System.Drawing.Size(174, 22)
        Me.lbl_productname.TabIndex = 5
        Me.lbl_productname.Text = "Product Name:"
        '
        'txt_produtname
        '
        Me.txt_produtname.Location = New System.Drawing.Point(349, 585)
        Me.txt_produtname.Name = "txt_produtname"
        Me.txt_produtname.Size = New System.Drawing.Size(186, 22)
        Me.txt_produtname.TabIndex = 6
        '
        'lbl_type
        '
        Me.lbl_type.AutoSize = True
        Me.lbl_type.BackColor = System.Drawing.Color.Transparent
        Me.lbl_type.Font = New System.Drawing.Font("Ravie", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_type.Location = New System.Drawing.Point(345, 640)
        Me.lbl_type.Name = "lbl_type"
        Me.lbl_type.Size = New System.Drawing.Size(71, 22)
        Me.lbl_type.TabIndex = 7
        Me.lbl_type.Text = "Type:"
        '
        'cmb_type
        '
        Me.cmb_type.FormattingEnabled = True
        Me.cmb_type.Location = New System.Drawing.Point(349, 689)
        Me.cmb_type.Name = "cmb_type"
        Me.cmb_type.Size = New System.Drawing.Size(179, 24)
        Me.cmb_type.TabIndex = 8
        '
        'lbl_price
        '
        Me.lbl_price.AutoSize = True
        Me.lbl_price.BackColor = System.Drawing.Color.Transparent
        Me.lbl_price.Font = New System.Drawing.Font("Ravie", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_price.Location = New System.Drawing.Point(624, 430)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(137, 22)
        Me.lbl_price.TabIndex = 9
        Me.lbl_price.Text = "Price (RM):"
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(628, 479)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(166, 22)
        Me.txt_price.TabIndex = 10
        '
        'lbl_size
        '
        Me.lbl_size.AutoSize = True
        Me.lbl_size.BackColor = System.Drawing.Color.Transparent
        Me.lbl_size.Font = New System.Drawing.Font("Ravie", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_size.Location = New System.Drawing.Point(634, 541)
        Me.lbl_size.Name = "lbl_size"
        Me.lbl_size.Size = New System.Drawing.Size(72, 22)
        Me.lbl_size.TabIndex = 11
        Me.lbl_size.Text = "Size :"
        '
        'txt_size
        '
        Me.txt_size.Location = New System.Drawing.Point(628, 585)
        Me.txt_size.Name = "txt_size"
        Me.txt_size.Size = New System.Drawing.Size(166, 22)
        Me.txt_size.TabIndex = 12
        '
        'lbl_quantity
        '
        Me.lbl_quantity.AutoSize = True
        Me.lbl_quantity.BackColor = System.Drawing.Color.Transparent
        Me.lbl_quantity.Font = New System.Drawing.Font("Ravie", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_quantity.Location = New System.Drawing.Point(624, 640)
        Me.lbl_quantity.Name = "lbl_quantity"
        Me.lbl_quantity.Size = New System.Drawing.Size(126, 22)
        Me.lbl_quantity.TabIndex = 13
        Me.lbl_quantity.Text = "Quantity :"
        '
        'txt_quantity
        '
        Me.txt_quantity.Location = New System.Drawing.Point(628, 691)
        Me.txt_quantity.Name = "txt_quantity"
        Me.txt_quantity.Size = New System.Drawing.Size(186, 22)
        Me.txt_quantity.TabIndex = 14
        '
        'lbl_gender
        '
        Me.lbl_gender.AutoSize = True
        Me.lbl_gender.BackColor = System.Drawing.Color.Transparent
        Me.lbl_gender.Font = New System.Drawing.Font("Ravie", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_gender.Location = New System.Drawing.Point(882, 430)
        Me.lbl_gender.Name = "lbl_gender"
        Me.lbl_gender.Size = New System.Drawing.Size(100, 22)
        Me.lbl_gender.TabIndex = 15
        Me.lbl_gender.Text = "Gender :"
        '
        'cmb_gender
        '
        Me.cmb_gender.FormattingEnabled = True
        Me.cmb_gender.Location = New System.Drawing.Point(886, 477)
        Me.cmb_gender.Name = "cmb_gender"
        Me.cmb_gender.Size = New System.Drawing.Size(138, 24)
        Me.cmb_gender.TabIndex = 16
        '
        'btn_insert
        '
        Me.btn_insert.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_insert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_insert.Font = New System.Drawing.Font("Ravie", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insert.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_insert.Location = New System.Drawing.Point(628, 760)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(175, 59)
        Me.btn_insert.TabIndex = 17
        Me.btn_insert.Text = "INSERT"
        Me.btn_insert.UseVisualStyleBackColor = False
        '
        'lbl_brand
        '
        Me.lbl_brand.AutoSize = True
        Me.lbl_brand.BackColor = System.Drawing.Color.Transparent
        Me.lbl_brand.Font = New System.Drawing.Font("Goudy Stout", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_brand.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lbl_brand.Location = New System.Drawing.Point(12, 18)
        Me.lbl_brand.Name = "lbl_brand"
        Me.lbl_brand.Size = New System.Drawing.Size(307, 23)
        Me.lbl_brand.TabIndex = 18
        Me.lbl_brand.Text = "CHAMPION SPORTS"
        '
        'grd_insertproduct
        '
        Me.grd_insertproduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_insertproduct.Location = New System.Drawing.Point(48, 120)
        Me.grd_insertproduct.Name = "grd_insertproduct"
        Me.grd_insertproduct.ReadOnly = True
        Me.grd_insertproduct.RowHeadersWidth = 51
        Me.grd_insertproduct.RowTemplate.Height = 24
        Me.grd_insertproduct.Size = New System.Drawing.Size(976, 241)
        Me.grd_insertproduct.TabIndex = 19
        '
        'txt_picture
        '
        Me.txt_picture.Location = New System.Drawing.Point(99, 745)
        Me.txt_picture.Name = "txt_picture"
        Me.txt_picture.Size = New System.Drawing.Size(146, 22)
        Me.txt_picture.TabIndex = 20
        '
        'lbl_instructions
        '
        Me.lbl_instructions.AutoSize = True
        Me.lbl_instructions.BackColor = System.Drawing.Color.Transparent
        Me.lbl_instructions.Font = New System.Drawing.Font("Ravie", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_instructions.ForeColor = System.Drawing.Color.Red
        Me.lbl_instructions.Location = New System.Drawing.Point(435, 381)
        Me.lbl_instructions.Name = "lbl_instructions"
        Me.lbl_instructions.Size = New System.Drawing.Size(448, 27)
        Me.lbl_instructions.TabIndex = 21
        Me.lbl_instructions.Text = "* Please insert the data below. *"
        '
        'frm_insertproduct_a193067
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1101, 883)
        Me.Controls.Add(Me.lbl_instructions)
        Me.Controls.Add(Me.txt_picture)
        Me.Controls.Add(Me.grd_insertproduct)
        Me.Controls.Add(Me.lbl_brand)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.cmb_gender)
        Me.Controls.Add(Me.lbl_gender)
        Me.Controls.Add(Me.txt_quantity)
        Me.Controls.Add(Me.lbl_quantity)
        Me.Controls.Add(Me.txt_size)
        Me.Controls.Add(Me.lbl_size)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.lbl_price)
        Me.Controls.Add(Me.cmb_type)
        Me.Controls.Add(Me.lbl_type)
        Me.Controls.Add(Me.txt_produtname)
        Me.Controls.Add(Me.lbl_productname)
        Me.Controls.Add(Me.txt_productID)
        Me.Controls.Add(Me.lbl_productID)
        Me.Controls.Add(Me.btn_selectpic)
        Me.Controls.Add(Me.pic_product)
        Me.Controls.Add(Me.lbl_title)
        Me.DoubleBuffered = True
        Me.Name = "frm_insertproduct_a193067"
        Me.Text = "frm_insertproduct_a193067"
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_insertproduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_title As Label
    Friend WithEvents pic_product As PictureBox
    Friend WithEvents btn_selectpic As Button
    Friend WithEvents lbl_productID As Label
    Friend WithEvents txt_productID As TextBox
    Friend WithEvents lbl_productname As Label
    Friend WithEvents txt_produtname As TextBox
    Friend WithEvents lbl_type As Label
    Friend WithEvents cmb_type As ComboBox
    Friend WithEvents lbl_price As Label
    Friend WithEvents txt_price As TextBox
    Friend WithEvents lbl_size As Label
    Friend WithEvents txt_size As TextBox
    Friend WithEvents lbl_quantity As Label
    Friend WithEvents txt_quantity As TextBox
    Friend WithEvents lbl_gender As Label
    Friend WithEvents cmb_gender As ComboBox
    Friend WithEvents btn_insert As Button
    Friend WithEvents lbl_brand As Label
    Friend WithEvents grd_insertproduct As DataGridView
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents txt_picture As TextBox
    Friend WithEvents lbl_instructions As Label
End Class
