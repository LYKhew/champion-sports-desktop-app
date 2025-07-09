<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_viewproduct_a193067
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_viewproduct_a193067))
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.lbl_brand = New System.Windows.Forms.Label()
        Me.lbl_productID = New System.Windows.Forms.Label()
        Me.lbl_productName = New System.Windows.Forms.Label()
        Me.txt_productName = New System.Windows.Forms.TextBox()
        Me.pic_products = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_gender = New System.Windows.Forms.Label()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.lbl_type = New System.Windows.Forms.Label()
        Me.lbl_size = New System.Windows.Forms.Label()
        Me.lbl_quantity = New System.Windows.Forms.Label()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.txt_type = New System.Windows.Forms.TextBox()
        Me.txt_size = New System.Windows.Forms.TextBox()
        Me.txt_gender = New System.Windows.Forms.TextBox()
        Me.txt_quantity = New System.Windows.Forms.TextBox()
        Me.cmb_productID = New System.Windows.Forms.ComboBox()
        CType(Me.pic_products, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Ravie", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(502, 33)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(331, 44)
        Me.lbl_title.TabIndex = 0
        Me.lbl_title.Text = "View Product"
        '
        'lbl_brand
        '
        Me.lbl_brand.AutoSize = True
        Me.lbl_brand.BackColor = System.Drawing.Color.Transparent
        Me.lbl_brand.Font = New System.Drawing.Font("Goudy Stout", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_brand.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lbl_brand.Location = New System.Drawing.Point(32, 65)
        Me.lbl_brand.Name = "lbl_brand"
        Me.lbl_brand.Size = New System.Drawing.Size(307, 23)
        Me.lbl_brand.TabIndex = 1
        Me.lbl_brand.Text = "CHAMPION SPORTS"
        '
        'lbl_productID
        '
        Me.lbl_productID.AutoSize = True
        Me.lbl_productID.BackColor = System.Drawing.Color.Transparent
        Me.lbl_productID.Font = New System.Drawing.Font("Ravie", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_productID.ForeColor = System.Drawing.Color.Red
        Me.lbl_productID.Location = New System.Drawing.Point(374, 110)
        Me.lbl_productID.Name = "lbl_productID"
        Me.lbl_productID.Size = New System.Drawing.Size(194, 19)
        Me.lbl_productID.TabIndex = 3
        Me.lbl_productID.Text = "Select Product ID: *"
        '
        'lbl_productName
        '
        Me.lbl_productName.AutoSize = True
        Me.lbl_productName.BackColor = System.Drawing.Color.Transparent
        Me.lbl_productName.Font = New System.Drawing.Font("Ravie", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_productName.Location = New System.Drawing.Point(374, 210)
        Me.lbl_productName.Name = "lbl_productName"
        Me.lbl_productName.Size = New System.Drawing.Size(148, 19)
        Me.lbl_productName.TabIndex = 4
        Me.lbl_productName.Text = "Product Name:"
        '
        'txt_productName
        '
        Me.txt_productName.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_productName.Location = New System.Drawing.Point(377, 258)
        Me.txt_productName.Name = "txt_productName"
        Me.txt_productName.ReadOnly = True
        Me.txt_productName.Size = New System.Drawing.Size(260, 22)
        Me.txt_productName.TabIndex = 5
        '
        'pic_products
        '
        Me.pic_products.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.pic_products.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic_products.Location = New System.Drawing.Point(36, 110)
        Me.pic_products.Name = "pic_products"
        Me.pic_products.Size = New System.Drawing.Size(293, 332)
        Me.pic_products.TabIndex = 6
        Me.pic_products.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(490, 327)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 17)
        Me.Label1.TabIndex = 7
        '
        'lbl_gender
        '
        Me.lbl_gender.AutoSize = True
        Me.lbl_gender.BackColor = System.Drawing.Color.Transparent
        Me.lbl_gender.Font = New System.Drawing.Font("Ravie", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_gender.Location = New System.Drawing.Point(763, 325)
        Me.lbl_gender.Name = "lbl_gender"
        Me.lbl_gender.Size = New System.Drawing.Size(79, 19)
        Me.lbl_gender.TabIndex = 8
        Me.lbl_gender.Text = "Gender:"
        '
        'lbl_price
        '
        Me.lbl_price.AutoSize = True
        Me.lbl_price.BackColor = System.Drawing.Color.Transparent
        Me.lbl_price.Font = New System.Drawing.Font("Ravie", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_price.Location = New System.Drawing.Point(375, 325)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(116, 19)
        Me.lbl_price.TabIndex = 9
        Me.lbl_price.Text = "Price (RM):"
        '
        'lbl_type
        '
        Me.lbl_type.AutoSize = True
        Me.lbl_type.BackColor = System.Drawing.Color.Transparent
        Me.lbl_type.Font = New System.Drawing.Font("Ravie", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_type.Location = New System.Drawing.Point(763, 110)
        Me.lbl_type.Name = "lbl_type"
        Me.lbl_type.Size = New System.Drawing.Size(60, 19)
        Me.lbl_type.TabIndex = 10
        Me.lbl_type.Text = "Type:"
        '
        'lbl_size
        '
        Me.lbl_size.AutoSize = True
        Me.lbl_size.BackColor = System.Drawing.Color.Transparent
        Me.lbl_size.Font = New System.Drawing.Font("Ravie", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_size.Location = New System.Drawing.Point(763, 210)
        Me.lbl_size.Name = "lbl_size"
        Me.lbl_size.Size = New System.Drawing.Size(55, 19)
        Me.lbl_size.TabIndex = 11
        Me.lbl_size.Text = "Size:"
        '
        'lbl_quantity
        '
        Me.lbl_quantity.AutoSize = True
        Me.lbl_quantity.BackColor = System.Drawing.Color.Transparent
        Me.lbl_quantity.Font = New System.Drawing.Font("Ravie", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_quantity.Location = New System.Drawing.Point(763, 423)
        Me.lbl_quantity.Name = "lbl_quantity"
        Me.lbl_quantity.Size = New System.Drawing.Size(101, 19)
        Me.lbl_quantity.TabIndex = 12
        Me.lbl_quantity.Text = "Quantity:"
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(377, 370)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.ReadOnly = True
        Me.txt_price.Size = New System.Drawing.Size(260, 22)
        Me.txt_price.TabIndex = 13
        '
        'txt_type
        '
        Me.txt_type.Location = New System.Drawing.Point(767, 151)
        Me.txt_type.Name = "txt_type"
        Me.txt_type.ReadOnly = True
        Me.txt_type.Size = New System.Drawing.Size(201, 22)
        Me.txt_type.TabIndex = 14
        '
        'txt_size
        '
        Me.txt_size.Location = New System.Drawing.Point(767, 258)
        Me.txt_size.Name = "txt_size"
        Me.txt_size.ReadOnly = True
        Me.txt_size.Size = New System.Drawing.Size(201, 22)
        Me.txt_size.TabIndex = 15
        '
        'txt_gender
        '
        Me.txt_gender.Location = New System.Drawing.Point(767, 370)
        Me.txt_gender.Name = "txt_gender"
        Me.txt_gender.ReadOnly = True
        Me.txt_gender.Size = New System.Drawing.Size(201, 22)
        Me.txt_gender.TabIndex = 16
        '
        'txt_quantity
        '
        Me.txt_quantity.Location = New System.Drawing.Point(767, 467)
        Me.txt_quantity.Name = "txt_quantity"
        Me.txt_quantity.ReadOnly = True
        Me.txt_quantity.Size = New System.Drawing.Size(201, 22)
        Me.txt_quantity.TabIndex = 17
        '
        'cmb_productID
        '
        Me.cmb_productID.FormattingEnabled = True
        Me.cmb_productID.Location = New System.Drawing.Point(379, 149)
        Me.cmb_productID.Name = "cmb_productID"
        Me.cmb_productID.Size = New System.Drawing.Size(258, 24)
        Me.cmb_productID.TabIndex = 18
        '
        'frm_viewproduct_a193067
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1029, 512)
        Me.Controls.Add(Me.cmb_productID)
        Me.Controls.Add(Me.txt_quantity)
        Me.Controls.Add(Me.txt_gender)
        Me.Controls.Add(Me.txt_size)
        Me.Controls.Add(Me.txt_type)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.lbl_quantity)
        Me.Controls.Add(Me.lbl_size)
        Me.Controls.Add(Me.lbl_type)
        Me.Controls.Add(Me.lbl_price)
        Me.Controls.Add(Me.lbl_gender)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pic_products)
        Me.Controls.Add(Me.txt_productName)
        Me.Controls.Add(Me.lbl_productName)
        Me.Controls.Add(Me.lbl_productID)
        Me.Controls.Add(Me.lbl_brand)
        Me.Controls.Add(Me.lbl_title)
        Me.DoubleBuffered = True
        Me.Name = "frm_viewproduct_a193067"
        Me.Text = "frm_viewproduct_a193067"
        CType(Me.pic_products, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_title As Label
    Friend WithEvents lbl_brand As Label
    Friend WithEvents lbl_productID As Label
    Friend WithEvents lbl_productName As Label
    Friend WithEvents txt_productName As TextBox
    Friend WithEvents pic_products As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_gender As Label
    Friend WithEvents lbl_price As Label
    Friend WithEvents lbl_type As Label
    Friend WithEvents lbl_size As Label
    Friend WithEvents lbl_quantity As Label
    Friend WithEvents txt_price As TextBox
    Friend WithEvents txt_type As TextBox
    Friend WithEvents txt_size As TextBox
    Friend WithEvents txt_gender As TextBox
    Friend WithEvents txt_quantity As TextBox
    Friend WithEvents cmb_productID As ComboBox
End Class
