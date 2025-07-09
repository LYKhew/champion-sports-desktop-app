<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_deleteproduct_a193067
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_deleteproduct_a193067))
        Me.lbl_brand = New System.Windows.Forms.Label()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.grd_deleteproduct = New System.Windows.Forms.DataGridView()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.lbl_productID = New System.Windows.Forms.Label()
        Me.txt_productID = New System.Windows.Forms.TextBox()
        Me.lbl_productname = New System.Windows.Forms.Label()
        Me.txt_produtname = New System.Windows.Forms.TextBox()
        Me.lbl_type = New System.Windows.Forms.Label()
        Me.txt_type = New System.Windows.Forms.TextBox()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.lbl_size = New System.Windows.Forms.Label()
        Me.txt_size = New System.Windows.Forms.TextBox()
        Me.lbl_quantity = New System.Windows.Forms.Label()
        Me.txt_quantity = New System.Windows.Forms.TextBox()
        Me.lbl_gender = New System.Windows.Forms.Label()
        Me.txt_gender = New System.Windows.Forms.TextBox()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.lbl_instructions = New System.Windows.Forms.Label()
        CType(Me.grd_deleteproduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_brand
        '
        Me.lbl_brand.AutoSize = True
        Me.lbl_brand.BackColor = System.Drawing.Color.Transparent
        Me.lbl_brand.Font = New System.Drawing.Font("Goudy Stout", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_brand.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lbl_brand.Location = New System.Drawing.Point(12, 22)
        Me.lbl_brand.Name = "lbl_brand"
        Me.lbl_brand.Size = New System.Drawing.Size(307, 23)
        Me.lbl_brand.TabIndex = 19
        Me.lbl_brand.Text = "CHAMPION SPORTS"
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Ravie", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(374, 58)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(388, 44)
        Me.lbl_title.TabIndex = 20
        Me.lbl_title.Text = "Delete  Products"
        '
        'grd_deleteproduct
        '
        Me.grd_deleteproduct.AllowUserToAddRows = False
        Me.grd_deleteproduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_deleteproduct.Location = New System.Drawing.Point(44, 149)
        Me.grd_deleteproduct.MultiSelect = False
        Me.grd_deleteproduct.Name = "grd_deleteproduct"
        Me.grd_deleteproduct.ReadOnly = True
        Me.grd_deleteproduct.RowHeadersWidth = 51
        Me.grd_deleteproduct.RowTemplate.Height = 24
        Me.grd_deleteproduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grd_deleteproduct.Size = New System.Drawing.Size(979, 241)
        Me.grd_deleteproduct.TabIndex = 21
        '
        'pic_product
        '
        Me.pic_product.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic_product.Location = New System.Drawing.Point(44, 427)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(251, 285)
        Me.pic_product.TabIndex = 22
        Me.pic_product.TabStop = False
        '
        'lbl_productID
        '
        Me.lbl_productID.AutoSize = True
        Me.lbl_productID.BackColor = System.Drawing.Color.Transparent
        Me.lbl_productID.Font = New System.Drawing.Font("Ravie", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_productID.Location = New System.Drawing.Point(368, 427)
        Me.lbl_productID.Name = "lbl_productID"
        Me.lbl_productID.Size = New System.Drawing.Size(130, 22)
        Me.lbl_productID.TabIndex = 23
        Me.lbl_productID.Text = "ProductID:"
        '
        'txt_productID
        '
        Me.txt_productID.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_productID.Location = New System.Drawing.Point(372, 470)
        Me.txt_productID.Name = "txt_productID"
        Me.txt_productID.ReadOnly = True
        Me.txt_productID.Size = New System.Drawing.Size(176, 22)
        Me.txt_productID.TabIndex = 24
        '
        'lbl_productname
        '
        Me.lbl_productname.AutoSize = True
        Me.lbl_productname.BackColor = System.Drawing.Color.Transparent
        Me.lbl_productname.Font = New System.Drawing.Font("Ravie", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_productname.Location = New System.Drawing.Point(368, 551)
        Me.lbl_productname.Name = "lbl_productname"
        Me.lbl_productname.Size = New System.Drawing.Size(174, 22)
        Me.lbl_productname.TabIndex = 25
        Me.lbl_productname.Text = "Product Name:"
        '
        'txt_produtname
        '
        Me.txt_produtname.Location = New System.Drawing.Point(372, 599)
        Me.txt_produtname.Name = "txt_produtname"
        Me.txt_produtname.ReadOnly = True
        Me.txt_produtname.Size = New System.Drawing.Size(186, 22)
        Me.txt_produtname.TabIndex = 26
        '
        'lbl_type
        '
        Me.lbl_type.AutoSize = True
        Me.lbl_type.BackColor = System.Drawing.Color.Transparent
        Me.lbl_type.Font = New System.Drawing.Font("Ravie", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_type.Location = New System.Drawing.Point(378, 667)
        Me.lbl_type.Name = "lbl_type"
        Me.lbl_type.Size = New System.Drawing.Size(71, 22)
        Me.lbl_type.TabIndex = 27
        Me.lbl_type.Text = "Type:"
        '
        'txt_type
        '
        Me.txt_type.Location = New System.Drawing.Point(372, 709)
        Me.txt_type.Name = "txt_type"
        Me.txt_type.ReadOnly = True
        Me.txt_type.Size = New System.Drawing.Size(188, 22)
        Me.txt_type.TabIndex = 28
        '
        'lbl_price
        '
        Me.lbl_price.AutoSize = True
        Me.lbl_price.BackColor = System.Drawing.Color.Transparent
        Me.lbl_price.Font = New System.Drawing.Font("Ravie", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_price.Location = New System.Drawing.Point(636, 427)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(137, 22)
        Me.lbl_price.TabIndex = 29
        Me.lbl_price.Text = "Price (RM):"
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(640, 470)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.ReadOnly = True
        Me.txt_price.Size = New System.Drawing.Size(166, 22)
        Me.txt_price.TabIndex = 30
        '
        'lbl_size
        '
        Me.lbl_size.AutoSize = True
        Me.lbl_size.BackColor = System.Drawing.Color.Transparent
        Me.lbl_size.Font = New System.Drawing.Font("Ravie", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_size.Location = New System.Drawing.Point(636, 551)
        Me.lbl_size.Name = "lbl_size"
        Me.lbl_size.Size = New System.Drawing.Size(72, 22)
        Me.lbl_size.TabIndex = 31
        Me.lbl_size.Text = "Size :"
        '
        'txt_size
        '
        Me.txt_size.Location = New System.Drawing.Point(640, 599)
        Me.txt_size.Name = "txt_size"
        Me.txt_size.ReadOnly = True
        Me.txt_size.Size = New System.Drawing.Size(166, 22)
        Me.txt_size.TabIndex = 32
        '
        'lbl_quantity
        '
        Me.lbl_quantity.AutoSize = True
        Me.lbl_quantity.BackColor = System.Drawing.Color.Transparent
        Me.lbl_quantity.Font = New System.Drawing.Font("Ravie", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_quantity.Location = New System.Drawing.Point(636, 667)
        Me.lbl_quantity.Name = "lbl_quantity"
        Me.lbl_quantity.Size = New System.Drawing.Size(126, 22)
        Me.lbl_quantity.TabIndex = 33
        Me.lbl_quantity.Text = "Quantity :"
        '
        'txt_quantity
        '
        Me.txt_quantity.Location = New System.Drawing.Point(640, 709)
        Me.txt_quantity.Name = "txt_quantity"
        Me.txt_quantity.ReadOnly = True
        Me.txt_quantity.Size = New System.Drawing.Size(166, 22)
        Me.txt_quantity.TabIndex = 34
        '
        'lbl_gender
        '
        Me.lbl_gender.AutoSize = True
        Me.lbl_gender.BackColor = System.Drawing.Color.Transparent
        Me.lbl_gender.Font = New System.Drawing.Font("Ravie", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_gender.Location = New System.Drawing.Point(885, 427)
        Me.lbl_gender.Name = "lbl_gender"
        Me.lbl_gender.Size = New System.Drawing.Size(100, 22)
        Me.lbl_gender.TabIndex = 35
        Me.lbl_gender.Text = "Gender :"
        '
        'txt_gender
        '
        Me.txt_gender.Location = New System.Drawing.Point(889, 470)
        Me.txt_gender.Name = "txt_gender"
        Me.txt_gender.ReadOnly = True
        Me.txt_gender.Size = New System.Drawing.Size(134, 22)
        Me.txt_gender.TabIndex = 36
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.Red
        Me.btn_delete.Font = New System.Drawing.Font("Ravie", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_delete.Location = New System.Drawing.Point(587, 772)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(175, 59)
        Me.btn_delete.TabIndex = 37
        Me.btn_delete.Text = "DELETE"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'lbl_instructions
        '
        Me.lbl_instructions.AutoSize = True
        Me.lbl_instructions.BackColor = System.Drawing.Color.Transparent
        Me.lbl_instructions.Font = New System.Drawing.Font("Ravie", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_instructions.ForeColor = System.Drawing.Color.Red
        Me.lbl_instructions.Location = New System.Drawing.Point(82, 119)
        Me.lbl_instructions.Name = "lbl_instructions"
        Me.lbl_instructions.Size = New System.Drawing.Size(445, 27)
        Me.lbl_instructions.TabIndex = 38
        Me.lbl_instructions.Text = "* Please select the data below. *"
        '
        'frm_deleteproduct_a193067
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1074, 843)
        Me.Controls.Add(Me.lbl_instructions)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.txt_gender)
        Me.Controls.Add(Me.lbl_gender)
        Me.Controls.Add(Me.txt_quantity)
        Me.Controls.Add(Me.lbl_quantity)
        Me.Controls.Add(Me.txt_size)
        Me.Controls.Add(Me.lbl_size)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.lbl_price)
        Me.Controls.Add(Me.txt_type)
        Me.Controls.Add(Me.lbl_type)
        Me.Controls.Add(Me.txt_produtname)
        Me.Controls.Add(Me.lbl_productname)
        Me.Controls.Add(Me.txt_productID)
        Me.Controls.Add(Me.lbl_productID)
        Me.Controls.Add(Me.pic_product)
        Me.Controls.Add(Me.grd_deleteproduct)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.lbl_brand)
        Me.DoubleBuffered = True
        Me.Name = "frm_deleteproduct_a193067"
        Me.Text = "frm_deleteproduct_a193067"
        CType(Me.grd_deleteproduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_brand As Label
    Friend WithEvents lbl_title As Label
    Friend WithEvents grd_deleteproduct As DataGridView
    Friend WithEvents pic_product As PictureBox
    Friend WithEvents lbl_productID As Label
    Friend WithEvents txt_productID As TextBox
    Friend WithEvents lbl_productname As Label
    Friend WithEvents txt_produtname As TextBox
    Friend WithEvents lbl_type As Label
    Friend WithEvents txt_type As TextBox
    Friend WithEvents lbl_price As Label
    Friend WithEvents txt_price As TextBox
    Friend WithEvents lbl_size As Label
    Friend WithEvents txt_size As TextBox
    Friend WithEvents lbl_quantity As Label
    Friend WithEvents txt_quantity As TextBox
    Friend WithEvents lbl_gender As Label
    Friend WithEvents txt_gender As TextBox
    Friend WithEvents btn_delete As Button
    Friend WithEvents lbl_instructions As Label
End Class
