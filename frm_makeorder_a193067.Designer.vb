<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_makeorder_a193067
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_makeorder_a193067))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_CustomerID = New System.Windows.Forms.Label()
        Me.grd_order = New System.Windows.Forms.DataGridView()
        Me.lbl_orderList = New System.Windows.Forms.Label()
        Me.lbl_orderID = New System.Windows.Forms.Label()
        Me.lbl_staff = New System.Windows.Forms.Label()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.lbl_productID = New System.Windows.Forms.Label()
        Me.cmb_staffID = New System.Windows.Forms.ComboBox()
        Me.cmb_customerID = New System.Windows.Forms.ComboBox()
        Me.btn_makeOrder = New System.Windows.Forms.Button()
        Me.lbl_subTotal = New System.Windows.Forms.Label()
        Me.txt_subTotal = New System.Windows.Forms.TextBox()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.lbl_quantity = New System.Windows.Forms.Label()
        Me.txt_quantity = New System.Windows.Forms.TextBox()
        Me.lbl_dateTime = New System.Windows.Forms.Label()
        Me.txt_dateTime = New System.Windows.Forms.TextBox()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.lbl_notel = New System.Windows.Forms.Label()
        Me.lbl_address2 = New System.Windows.Forms.Label()
        Me.lbl_address1 = New System.Windows.Forms.Label()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.txt_orderID = New System.Windows.Forms.TextBox()
        Me.cmb_productID = New System.Windows.Forms.ComboBox()
        Me.btn_generateID = New System.Windows.Forms.Button()
        CType(Me.grd_order, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Ravie", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(595, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Order"
        '
        'lbl_CustomerID
        '
        Me.lbl_CustomerID.AutoSize = True
        Me.lbl_CustomerID.BackColor = System.Drawing.Color.Transparent
        Me.lbl_CustomerID.Font = New System.Drawing.Font("Ravie", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CustomerID.Location = New System.Drawing.Point(92, 357)
        Me.lbl_CustomerID.Name = "lbl_CustomerID"
        Me.lbl_CustomerID.Size = New System.Drawing.Size(186, 27)
        Me.lbl_CustomerID.TabIndex = 1
        Me.lbl_CustomerID.Text = "CustomerID :"
        '
        'grd_order
        '
        Me.grd_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_order.Location = New System.Drawing.Point(97, 590)
        Me.grd_order.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grd_order.Name = "grd_order"
        Me.grd_order.RowHeadersWidth = 51
        Me.grd_order.RowTemplate.Height = 24
        Me.grd_order.Size = New System.Drawing.Size(707, 267)
        Me.grd_order.TabIndex = 3
        '
        'lbl_orderList
        '
        Me.lbl_orderList.AutoSize = True
        Me.lbl_orderList.BackColor = System.Drawing.Color.Transparent
        Me.lbl_orderList.Font = New System.Drawing.Font("Ravie", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_orderList.Location = New System.Drawing.Point(92, 537)
        Me.lbl_orderList.Name = "lbl_orderList"
        Me.lbl_orderList.Size = New System.Drawing.Size(169, 27)
        Me.lbl_orderList.TabIndex = 4
        Me.lbl_orderList.Text = "Order List :"
        '
        'lbl_orderID
        '
        Me.lbl_orderID.AutoSize = True
        Me.lbl_orderID.BackColor = System.Drawing.Color.Transparent
        Me.lbl_orderID.Font = New System.Drawing.Font("Ravie", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_orderID.Location = New System.Drawing.Point(92, 247)
        Me.lbl_orderID.Name = "lbl_orderID"
        Me.lbl_orderID.Size = New System.Drawing.Size(140, 27)
        Me.lbl_orderID.TabIndex = 8
        Me.lbl_orderID.Text = "Order ID :"
        '
        'lbl_staff
        '
        Me.lbl_staff.AutoSize = True
        Me.lbl_staff.BackColor = System.Drawing.Color.Transparent
        Me.lbl_staff.Font = New System.Drawing.Font("Ravie", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_staff.Location = New System.Drawing.Point(92, 449)
        Me.lbl_staff.Name = "lbl_staff"
        Me.lbl_staff.Size = New System.Drawing.Size(144, 27)
        Me.lbl_staff.TabIndex = 9
        Me.lbl_staff.Text = "Staff ID :"
        '
        'btn_insert
        '
        Me.btn_insert.BackColor = System.Drawing.Color.Black
        Me.btn_insert.Font = New System.Drawing.Font("Ravie", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insert.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_insert.Location = New System.Drawing.Point(340, 874)
        Me.btn_insert.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(213, 50)
        Me.btn_insert.TabIndex = 12
        Me.btn_insert.Text = "Insert"
        Me.btn_insert.UseVisualStyleBackColor = False
        '
        'lbl_productID
        '
        Me.lbl_productID.AutoSize = True
        Me.lbl_productID.BackColor = System.Drawing.Color.Transparent
        Me.lbl_productID.Font = New System.Drawing.Font("Ravie", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_productID.Location = New System.Drawing.Point(708, 272)
        Me.lbl_productID.Name = "lbl_productID"
        Me.lbl_productID.Size = New System.Drawing.Size(173, 27)
        Me.lbl_productID.TabIndex = 13
        Me.lbl_productID.Text = "Product ID :"
        '
        'cmb_staffID
        '
        Me.cmb_staffID.FormattingEnabled = True
        Me.cmb_staffID.Location = New System.Drawing.Point(299, 455)
        Me.cmb_staffID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmb_staffID.Name = "cmb_staffID"
        Me.cmb_staffID.Size = New System.Drawing.Size(256, 24)
        Me.cmb_staffID.TabIndex = 15
        '
        'cmb_customerID
        '
        Me.cmb_customerID.FormattingEnabled = True
        Me.cmb_customerID.Location = New System.Drawing.Point(299, 359)
        Me.cmb_customerID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmb_customerID.Name = "cmb_customerID"
        Me.cmb_customerID.Size = New System.Drawing.Size(256, 24)
        Me.cmb_customerID.TabIndex = 16
        '
        'btn_makeOrder
        '
        Me.btn_makeOrder.Font = New System.Drawing.Font("Ravie", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_makeOrder.Location = New System.Drawing.Point(943, 874)
        Me.btn_makeOrder.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_makeOrder.Name = "btn_makeOrder"
        Me.btn_makeOrder.Size = New System.Drawing.Size(209, 50)
        Me.btn_makeOrder.TabIndex = 17
        Me.btn_makeOrder.Text = "View Order"
        Me.btn_makeOrder.UseVisualStyleBackColor = True
        '
        'lbl_subTotal
        '
        Me.lbl_subTotal.AutoSize = True
        Me.lbl_subTotal.BackColor = System.Drawing.Color.Transparent
        Me.lbl_subTotal.Font = New System.Drawing.Font("Ravie", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_subTotal.Location = New System.Drawing.Point(905, 590)
        Me.lbl_subTotal.Name = "lbl_subTotal"
        Me.lbl_subTotal.Size = New System.Drawing.Size(265, 34)
        Me.lbl_subTotal.TabIndex = 19
        Me.lbl_subTotal.Text = "Sub Total (RM):"
        '
        'txt_subTotal
        '
        Me.txt_subTotal.Location = New System.Drawing.Point(915, 662)
        Me.txt_subTotal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_subTotal.Name = "txt_subTotal"
        Me.txt_subTotal.ReadOnly = True
        Me.txt_subTotal.Size = New System.Drawing.Size(255, 22)
        Me.txt_subTotal.TabIndex = 20
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.BackColor = System.Drawing.Color.Transparent
        Me.lbl_total.Font = New System.Drawing.Font("Ravie", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.Location = New System.Drawing.Point(909, 737)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(208, 34)
        Me.lbl_total.TabIndex = 21
        Me.lbl_total.Text = "Total (RM) :"
        '
        'txt_total
        '
        Me.txt_total.Location = New System.Drawing.Point(916, 815)
        Me.txt_total.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.ReadOnly = True
        Me.txt_total.Size = New System.Drawing.Size(255, 22)
        Me.txt_total.TabIndex = 22
        '
        'lbl_quantity
        '
        Me.lbl_quantity.AutoSize = True
        Me.lbl_quantity.BackColor = System.Drawing.Color.Transparent
        Me.lbl_quantity.Font = New System.Drawing.Font("Ravie", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_quantity.Location = New System.Drawing.Point(709, 357)
        Me.lbl_quantity.Name = "lbl_quantity"
        Me.lbl_quantity.Size = New System.Drawing.Size(152, 27)
        Me.lbl_quantity.TabIndex = 24
        Me.lbl_quantity.Text = "Quantity :"
        '
        'txt_quantity
        '
        Me.txt_quantity.Location = New System.Drawing.Point(916, 363)
        Me.txt_quantity.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_quantity.Name = "txt_quantity"
        Me.txt_quantity.Size = New System.Drawing.Size(255, 22)
        Me.txt_quantity.TabIndex = 26
        '
        'lbl_dateTime
        '
        Me.lbl_dateTime.AutoSize = True
        Me.lbl_dateTime.BackColor = System.Drawing.Color.Transparent
        Me.lbl_dateTime.Font = New System.Drawing.Font("Ravie", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dateTime.Location = New System.Drawing.Point(709, 449)
        Me.lbl_dateTime.Name = "lbl_dateTime"
        Me.lbl_dateTime.Size = New System.Drawing.Size(172, 27)
        Me.lbl_dateTime.TabIndex = 27
        Me.lbl_dateTime.Text = "Date/Time :"
        '
        'txt_dateTime
        '
        Me.txt_dateTime.Location = New System.Drawing.Point(916, 455)
        Me.txt_dateTime.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_dateTime.Name = "txt_dateTime"
        Me.txt_dateTime.Size = New System.Drawing.Size(255, 22)
        Me.txt_dateTime.TabIndex = 28
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.BackColor = System.Drawing.Color.Transparent
        Me.lbl_email.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_email.Location = New System.Drawing.Point(525, 198)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(337, 22)
        Me.lbl_email.TabIndex = 33
        Me.lbl_email.Text = "Email: championsports@gmail.com"
        '
        'lbl_notel
        '
        Me.lbl_notel.AutoSize = True
        Me.lbl_notel.BackColor = System.Drawing.Color.Transparent
        Me.lbl_notel.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_notel.Location = New System.Drawing.Point(585, 176)
        Me.lbl_notel.Name = "lbl_notel"
        Me.lbl_notel.Size = New System.Drawing.Size(209, 22)
        Me.lbl_notel.TabIndex = 32
        Me.lbl_notel.Text = "Phone : 011-26101538"
        '
        'lbl_address2
        '
        Me.lbl_address2.AutoSize = True
        Me.lbl_address2.BackColor = System.Drawing.Color.Transparent
        Me.lbl_address2.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_address2.Location = New System.Drawing.Point(585, 154)
        Me.lbl_address2.Name = "lbl_address2"
        Me.lbl_address2.Size = New System.Drawing.Size(214, 22)
        Me.lbl_address2.TabIndex = 31
        Me.lbl_address2.Text = "Taman Pertama, Perak"
        '
        'lbl_address1
        '
        Me.lbl_address1.AutoSize = True
        Me.lbl_address1.BackColor = System.Drawing.Color.Transparent
        Me.lbl_address1.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_address1.Location = New System.Drawing.Point(573, 132)
        Me.lbl_address1.Name = "lbl_address1"
        Me.lbl_address1.Size = New System.Drawing.Size(225, 22)
        Me.lbl_address1.TabIndex = 30
        Me.lbl_address1.Text = "No 16, Laluan Mutiara 3"
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Ravie", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(476, 76)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(431, 44)
        Me.lbl_title.TabIndex = 34
        Me.lbl_title.Text = "CHAMPION SPORTS"
        '
        'txt_orderID
        '
        Me.txt_orderID.Location = New System.Drawing.Point(299, 247)
        Me.txt_orderID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_orderID.Name = "txt_orderID"
        Me.txt_orderID.Size = New System.Drawing.Size(251, 22)
        Me.txt_orderID.TabIndex = 35
        '
        'cmb_productID
        '
        Me.cmb_productID.FormattingEnabled = True
        Me.cmb_productID.Location = New System.Drawing.Point(912, 272)
        Me.cmb_productID.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_productID.Name = "cmb_productID"
        Me.cmb_productID.Size = New System.Drawing.Size(251, 24)
        Me.cmb_productID.TabIndex = 36
        '
        'btn_generateID
        '
        Me.btn_generateID.BackColor = System.Drawing.Color.LightCoral
        Me.btn_generateID.Font = New System.Drawing.Font("Ravie", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_generateID.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_generateID.Location = New System.Drawing.Point(308, 286)
        Me.btn_generateID.Name = "btn_generateID"
        Me.btn_generateID.Size = New System.Drawing.Size(224, 46)
        Me.btn_generateID.TabIndex = 37
        Me.btn_generateID.Text = "Generate OrderID"
        Me.btn_generateID.UseVisualStyleBackColor = False
        '
        'frm_makeorder_a193067
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1267, 846)
        Me.Controls.Add(Me.btn_generateID)
        Me.Controls.Add(Me.cmb_productID)
        Me.Controls.Add(Me.txt_orderID)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.lbl_email)
        Me.Controls.Add(Me.lbl_notel)
        Me.Controls.Add(Me.lbl_address2)
        Me.Controls.Add(Me.lbl_address1)
        Me.Controls.Add(Me.txt_dateTime)
        Me.Controls.Add(Me.lbl_dateTime)
        Me.Controls.Add(Me.txt_quantity)
        Me.Controls.Add(Me.lbl_quantity)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.txt_subTotal)
        Me.Controls.Add(Me.lbl_subTotal)
        Me.Controls.Add(Me.btn_makeOrder)
        Me.Controls.Add(Me.cmb_customerID)
        Me.Controls.Add(Me.cmb_staffID)
        Me.Controls.Add(Me.lbl_productID)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.lbl_staff)
        Me.Controls.Add(Me.lbl_orderID)
        Me.Controls.Add(Me.lbl_orderList)
        Me.Controls.Add(Me.grd_order)
        Me.Controls.Add(Me.lbl_CustomerID)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frm_makeorder_a193067"
        Me.Text = "frm_makeorder_a193067"
        CType(Me.grd_order, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_CustomerID As Label
    Friend WithEvents grd_order As DataGridView
    Friend WithEvents lbl_orderList As Label
    Friend WithEvents lbl_orderID As Label
    Friend WithEvents lbl_staff As Label
    Friend WithEvents btn_insert As Button
    Friend WithEvents lbl_productID As Label
    Friend WithEvents cmb_staffID As ComboBox
    Friend WithEvents cmb_customerID As ComboBox
    Friend WithEvents btn_makeOrder As Button
    Friend WithEvents lbl_subTotal As Label
    Friend WithEvents txt_subTotal As TextBox
    Friend WithEvents lbl_total As Label
    Friend WithEvents txt_total As TextBox
    Friend WithEvents lbl_quantity As Label
    Friend WithEvents txt_quantity As TextBox
    Friend WithEvents lbl_dateTime As Label
    Friend WithEvents txt_dateTime As TextBox
    Friend WithEvents lbl_email As Label
    Friend WithEvents lbl_notel As Label
    Friend WithEvents lbl_address2 As Label
    Friend WithEvents lbl_address1 As Label
    Friend WithEvents lbl_title As Label
    Friend WithEvents txt_orderID As TextBox
    Friend WithEvents cmb_productID As ComboBox
    Friend WithEvents btn_generateID As Button
End Class
