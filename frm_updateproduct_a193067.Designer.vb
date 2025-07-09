<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_updateproduct_a193067
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_updateproduct_a193067))
        Me.lbl_brand = New System.Windows.Forms.Label()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.grd_updateproduct = New System.Windows.Forms.DataGridView()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.lbl_instructions = New System.Windows.Forms.Label()
        Me.lbl_gender = New System.Windows.Forms.Label()
        Me.txt_quantity = New System.Windows.Forms.TextBox()
        Me.lbl_quantity = New System.Windows.Forms.Label()
        Me.txt_size = New System.Windows.Forms.TextBox()
        Me.lbl_size = New System.Windows.Forms.Label()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.lbl_type = New System.Windows.Forms.Label()
        Me.txt_produtname = New System.Windows.Forms.TextBox()
        Me.lbl_productname = New System.Windows.Forms.Label()
        Me.txt_productID = New System.Windows.Forms.TextBox()
        Me.lbl_productID = New System.Windows.Forms.Label()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.cmb_type = New System.Windows.Forms.ComboBox()
        Me.cmb_gender = New System.Windows.Forms.ComboBox()
        CType(Me.grd_updateproduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_brand
        '
        Me.lbl_brand.AutoSize = True
        Me.lbl_brand.BackColor = System.Drawing.Color.Transparent
        Me.lbl_brand.Font = New System.Drawing.Font("Goudy Stout", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_brand.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lbl_brand.Location = New System.Drawing.Point(12, 20)
        Me.lbl_brand.Name = "lbl_brand"
        Me.lbl_brand.Size = New System.Drawing.Size(307, 23)
        Me.lbl_brand.TabIndex = 20
        Me.lbl_brand.Text = "CHAMPION SPORTS"
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Ravie", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(371, 67)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(404, 44)
        Me.lbl_title.TabIndex = 21
        Me.lbl_title.Text = "Update  Products"
        '
        'grd_updateproduct
        '
        Me.grd_updateproduct.AllowUserToAddRows = False
        Me.grd_updateproduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_updateproduct.Location = New System.Drawing.Point(75, 170)
        Me.grd_updateproduct.MultiSelect = False
        Me.grd_updateproduct.Name = "grd_updateproduct"
        Me.grd_updateproduct.ReadOnly = True
        Me.grd_updateproduct.RowHeadersWidth = 51
        Me.grd_updateproduct.RowTemplate.Height = 24
        Me.grd_updateproduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grd_updateproduct.Size = New System.Drawing.Size(950, 241)
        Me.grd_updateproduct.TabIndex = 22
        '
        'pic_product
        '
        Me.pic_product.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic_product.Location = New System.Drawing.Point(75, 440)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(251, 285)
        Me.pic_product.TabIndex = 23
        Me.pic_product.TabStop = False
        '
        'lbl_instructions
        '
        Me.lbl_instructions.AutoSize = True
        Me.lbl_instructions.BackColor = System.Drawing.Color.Transparent
        Me.lbl_instructions.Font = New System.Drawing.Font("Ravie", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_instructions.ForeColor = System.Drawing.Color.Red
        Me.lbl_instructions.Location = New System.Drawing.Point(83, 130)
        Me.lbl_instructions.Name = "lbl_instructions"
        Me.lbl_instructions.Size = New System.Drawing.Size(445, 27)
        Me.lbl_instructions.TabIndex = 39
        Me.lbl_instructions.Text = "* Please select the data below. *"
        '
        'lbl_gender
        '
        Me.lbl_gender.AutoSize = True
        Me.lbl_gender.BackColor = System.Drawing.Color.Transparent
        Me.lbl_gender.Font = New System.Drawing.Font("Ravie", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_gender.Location = New System.Drawing.Point(887, 440)
        Me.lbl_gender.Name = "lbl_gender"
        Me.lbl_gender.Size = New System.Drawing.Size(100, 22)
        Me.lbl_gender.TabIndex = 52
        Me.lbl_gender.Text = "Gender :"
        '
        'txt_quantity
        '
        Me.txt_quantity.Location = New System.Drawing.Point(642, 722)
        Me.txt_quantity.Name = "txt_quantity"
        Me.txt_quantity.Size = New System.Drawing.Size(166, 22)
        Me.txt_quantity.TabIndex = 51
        '
        'lbl_quantity
        '
        Me.lbl_quantity.AutoSize = True
        Me.lbl_quantity.BackColor = System.Drawing.Color.Transparent
        Me.lbl_quantity.Font = New System.Drawing.Font("Ravie", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_quantity.Location = New System.Drawing.Point(638, 680)
        Me.lbl_quantity.Name = "lbl_quantity"
        Me.lbl_quantity.Size = New System.Drawing.Size(126, 22)
        Me.lbl_quantity.TabIndex = 50
        Me.lbl_quantity.Text = "Quantity :"
        '
        'txt_size
        '
        Me.txt_size.Location = New System.Drawing.Point(642, 612)
        Me.txt_size.Name = "txt_size"
        Me.txt_size.Size = New System.Drawing.Size(166, 22)
        Me.txt_size.TabIndex = 49
        '
        'lbl_size
        '
        Me.lbl_size.AutoSize = True
        Me.lbl_size.BackColor = System.Drawing.Color.Transparent
        Me.lbl_size.Font = New System.Drawing.Font("Ravie", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_size.Location = New System.Drawing.Point(638, 564)
        Me.lbl_size.Name = "lbl_size"
        Me.lbl_size.Size = New System.Drawing.Size(72, 22)
        Me.lbl_size.TabIndex = 48
        Me.lbl_size.Text = "Size :"
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(642, 483)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(166, 22)
        Me.txt_price.TabIndex = 47
        '
        'lbl_price
        '
        Me.lbl_price.AutoSize = True
        Me.lbl_price.BackColor = System.Drawing.Color.Transparent
        Me.lbl_price.Font = New System.Drawing.Font("Ravie", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_price.Location = New System.Drawing.Point(638, 440)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(137, 22)
        Me.lbl_price.TabIndex = 46
        Me.lbl_price.Text = "Price (RM):"
        '
        'lbl_type
        '
        Me.lbl_type.AutoSize = True
        Me.lbl_type.BackColor = System.Drawing.Color.Transparent
        Me.lbl_type.Font = New System.Drawing.Font("Ravie", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_type.Location = New System.Drawing.Point(380, 680)
        Me.lbl_type.Name = "lbl_type"
        Me.lbl_type.Size = New System.Drawing.Size(71, 22)
        Me.lbl_type.TabIndex = 44
        Me.lbl_type.Text = "Type:"
        '
        'txt_produtname
        '
        Me.txt_produtname.Location = New System.Drawing.Point(374, 612)
        Me.txt_produtname.Name = "txt_produtname"
        Me.txt_produtname.Size = New System.Drawing.Size(186, 22)
        Me.txt_produtname.TabIndex = 43
        '
        'lbl_productname
        '
        Me.lbl_productname.AutoSize = True
        Me.lbl_productname.BackColor = System.Drawing.Color.Transparent
        Me.lbl_productname.Font = New System.Drawing.Font("Ravie", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_productname.Location = New System.Drawing.Point(370, 564)
        Me.lbl_productname.Name = "lbl_productname"
        Me.lbl_productname.Size = New System.Drawing.Size(174, 22)
        Me.lbl_productname.TabIndex = 42
        Me.lbl_productname.Text = "Product Name:"
        '
        'txt_productID
        '
        Me.txt_productID.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_productID.Location = New System.Drawing.Point(384, 483)
        Me.txt_productID.Name = "txt_productID"
        Me.txt_productID.ReadOnly = True
        Me.txt_productID.Size = New System.Drawing.Size(176, 22)
        Me.txt_productID.TabIndex = 41
        '
        'lbl_productID
        '
        Me.lbl_productID.AutoSize = True
        Me.lbl_productID.BackColor = System.Drawing.Color.Transparent
        Me.lbl_productID.Font = New System.Drawing.Font("Ravie", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_productID.Location = New System.Drawing.Point(380, 440)
        Me.lbl_productID.Name = "lbl_productID"
        Me.lbl_productID.Size = New System.Drawing.Size(130, 22)
        Me.lbl_productID.TabIndex = 40
        Me.lbl_productID.Text = "ProductID:"
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_update.Font = New System.Drawing.Font("Ravie", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_update.Location = New System.Drawing.Point(642, 779)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(175, 59)
        Me.btn_update.TabIndex = 54
        Me.btn_update.Text = "UPDATE"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'cmb_type
        '
        Me.cmb_type.FormattingEnabled = True
        Me.cmb_type.Location = New System.Drawing.Point(374, 720)
        Me.cmb_type.Name = "cmb_type"
        Me.cmb_type.Size = New System.Drawing.Size(186, 24)
        Me.cmb_type.TabIndex = 55
        '
        'cmb_gender
        '
        Me.cmb_gender.FormattingEnabled = True
        Me.cmb_gender.Location = New System.Drawing.Point(891, 483)
        Me.cmb_gender.Name = "cmb_gender"
        Me.cmb_gender.Size = New System.Drawing.Size(129, 24)
        Me.cmb_gender.TabIndex = 56
        '
        'frm_updateproduct_a193067
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1099, 877)
        Me.Controls.Add(Me.cmb_gender)
        Me.Controls.Add(Me.cmb_type)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.lbl_gender)
        Me.Controls.Add(Me.txt_quantity)
        Me.Controls.Add(Me.lbl_quantity)
        Me.Controls.Add(Me.txt_size)
        Me.Controls.Add(Me.lbl_size)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.lbl_price)
        Me.Controls.Add(Me.lbl_type)
        Me.Controls.Add(Me.txt_produtname)
        Me.Controls.Add(Me.lbl_productname)
        Me.Controls.Add(Me.txt_productID)
        Me.Controls.Add(Me.lbl_productID)
        Me.Controls.Add(Me.lbl_instructions)
        Me.Controls.Add(Me.pic_product)
        Me.Controls.Add(Me.grd_updateproduct)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.lbl_brand)
        Me.DoubleBuffered = True
        Me.Name = "frm_updateproduct_a193067"
        Me.Text = "frm_updateproduct_a193067"
        CType(Me.grd_updateproduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_brand As Label
    Friend WithEvents lbl_title As Label
    Friend WithEvents grd_updateproduct As DataGridView
    Friend WithEvents pic_product As PictureBox
    Friend WithEvents lbl_instructions As Label
    Friend WithEvents lbl_gender As Label
    Friend WithEvents txt_quantity As TextBox
    Friend WithEvents lbl_quantity As Label
    Friend WithEvents txt_size As TextBox
    Friend WithEvents lbl_size As Label
    Friend WithEvents txt_price As TextBox
    Friend WithEvents lbl_price As Label
    Friend WithEvents lbl_type As Label
    Friend WithEvents txt_produtname As TextBox
    Friend WithEvents lbl_productname As Label
    Friend WithEvents txt_productID As TextBox
    Friend WithEvents lbl_productID As Label
    Friend WithEvents btn_update As Button
    Friend WithEvents cmb_type As ComboBox
    Friend WithEvents cmb_gender As ComboBox
End Class
