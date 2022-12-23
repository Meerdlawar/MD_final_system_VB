<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class order_create
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
        Me.cmbProductOrder = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtboxComments = New System.Windows.Forms.TextBox()
        Me.cmbCustomerOrder = New System.Windows.Forms.ComboBox()
        Me.DateTimePickerDue = New System.Windows.Forms.DateTimePicker()
        Me.lblTotalPrice = New System.Windows.Forms.Label()
        Me.cmbPaymentMethod = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DateTimePickerPlaced = New System.Windows.Forms.DateTimePicker()
        Me.btnBackOrderCreate = New System.Windows.Forms.Button()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnAddProduct = New System.Windows.Forms.Button()
        Me.btnremove = New System.Windows.Forms.Button()
        Me.orderCreateDGV = New System.Windows.Forms.DataGridView()
        Me.productID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.product_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.product_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.product_type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.product_suitability = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSaveOrder = New System.Windows.Forms.Button()
        CType(Me.orderCreateDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbProductOrder
        '
        Me.cmbProductOrder.FormattingEnabled = True
        Me.cmbProductOrder.Location = New System.Drawing.Point(144, 127)
        Me.cmbProductOrder.MaxDropDownItems = 20
        Me.cmbProductOrder.MaxLength = 20
        Me.cmbProductOrder.Name = "cmbProductOrder"
        Me.cmbProductOrder.Size = New System.Drawing.Size(121, 21)
        Me.cmbProductOrder.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AccessibleName = ""
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select Products:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Select Customer:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Payment method:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 256)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Order due:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(42, 325)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Comments:"
        '
        'txtboxComments
        '
        Me.txtboxComments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxComments.Location = New System.Drawing.Point(144, 305)
        Me.txtboxComments.Multiline = True
        Me.txtboxComments.Name = "txtboxComments"
        Me.txtboxComments.Size = New System.Drawing.Size(243, 120)
        Me.txtboxComments.TabIndex = 9
        '
        'cmbCustomerOrder
        '
        Me.cmbCustomerOrder.FormattingEnabled = True
        Me.cmbCustomerOrder.Location = New System.Drawing.Point(144, 154)
        Me.cmbCustomerOrder.Name = "cmbCustomerOrder"
        Me.cmbCustomerOrder.Size = New System.Drawing.Size(121, 21)
        Me.cmbCustomerOrder.TabIndex = 10
        '
        'DateTimePickerDue
        '
        Me.DateTimePickerDue.Location = New System.Drawing.Point(144, 256)
        Me.DateTimePickerDue.Name = "DateTimePickerDue"
        Me.DateTimePickerDue.Size = New System.Drawing.Size(134, 20)
        Me.DateTimePickerDue.TabIndex = 12
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.AccessibleName = ""
        Me.lblTotalPrice.AutoSize = True
        Me.lblTotalPrice.Location = New System.Drawing.Point(618, 75)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(61, 13)
        Me.lblTotalPrice.TabIndex = 15
        Me.lblTotalPrice.Text = "Total Price:"
        '
        'cmbPaymentMethod
        '
        Me.cmbPaymentMethod.FormattingEnabled = True
        Me.cmbPaymentMethod.Items.AddRange(New Object() {"Cash", "Bank Transfer", "Paypal"})
        Me.cmbPaymentMethod.Location = New System.Drawing.Point(144, 181)
        Me.cmbPaymentMethod.Name = "cmbPaymentMethod"
        Me.cmbPaymentMethod.Size = New System.Drawing.Size(121, 21)
        Me.cmbPaymentMethod.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(42, 230)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Order Placed"
        '
        'DateTimePickerPlaced
        '
        Me.DateTimePickerPlaced.Location = New System.Drawing.Point(144, 230)
        Me.DateTimePickerPlaced.Name = "DateTimePickerPlaced"
        Me.DateTimePickerPlaced.Size = New System.Drawing.Size(134, 20)
        Me.DateTimePickerPlaced.TabIndex = 18
        Me.DateTimePickerPlaced.Value = New Date(2022, 10, 27, 0, 0, 0, 0)
        '
        'btnBackOrderCreate
        '
        Me.btnBackOrderCreate.Location = New System.Drawing.Point(1089, 12)
        Me.btnBackOrderCreate.Name = "btnBackOrderCreate"
        Me.btnBackOrderCreate.Size = New System.Drawing.Size(75, 42)
        Me.btnBackOrderCreate.TabIndex = 19
        Me.btnBackOrderCreate.Text = "Back"
        Me.btnBackOrderCreate.UseVisualStyleBackColor = True
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(621, 511)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(119, 34)
        Me.btnCreate.TabIndex = 21
        Me.btnCreate.Text = "Create"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnAddProduct
        '
        Me.btnAddProduct.Location = New System.Drawing.Point(271, 127)
        Me.btnAddProduct.Name = "btnAddProduct"
        Me.btnAddProduct.Size = New System.Drawing.Size(75, 21)
        Me.btnAddProduct.TabIndex = 22
        Me.btnAddProduct.Text = "Add"
        Me.btnAddProduct.UseVisualStyleBackColor = True
        '
        'btnremove
        '
        Me.btnremove.Location = New System.Drawing.Point(871, 511)
        Me.btnremove.Name = "btnremove"
        Me.btnremove.Size = New System.Drawing.Size(119, 34)
        Me.btnremove.TabIndex = 23
        Me.btnremove.Text = "Remove"
        Me.btnremove.UseVisualStyleBackColor = True
        '
        'orderCreateDGV
        '
        Me.orderCreateDGV.AllowUserToAddRows = False
        Me.orderCreateDGV.AllowUserToDeleteRows = False
        Me.orderCreateDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.orderCreateDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.productID, Me.product_name, Me.product_price, Me.product_type, Me.product_suitability})
        Me.orderCreateDGV.Location = New System.Drawing.Point(621, 91)
        Me.orderCreateDGV.Name = "orderCreateDGV"
        Me.orderCreateDGV.Size = New System.Drawing.Size(543, 414)
        Me.orderCreateDGV.TabIndex = 24
        '
        'productID
        '
        Me.productID.HeaderText = "Product ID"
        Me.productID.Name = "productID"
        Me.productID.ReadOnly = True
        '
        'product_name
        '
        Me.product_name.HeaderText = "Product Name"
        Me.product_name.Name = "product_name"
        Me.product_name.ReadOnly = True
        '
        'product_price
        '
        Me.product_price.HeaderText = "Product Price"
        Me.product_price.Name = "product_price"
        Me.product_price.ReadOnly = True
        '
        'product_type
        '
        Me.product_type.HeaderText = "Product Type"
        Me.product_type.Name = "product_type"
        Me.product_type.ReadOnly = True
        '
        'product_suitability
        '
        Me.product_suitability.HeaderText = "Product Suitability"
        Me.product_suitability.Name = "product_suitability"
        Me.product_suitability.ReadOnly = True
        '
        'btnSaveOrder
        '
        Me.btnSaveOrder.Location = New System.Drawing.Point(746, 511)
        Me.btnSaveOrder.Name = "btnSaveOrder"
        Me.btnSaveOrder.Size = New System.Drawing.Size(119, 34)
        Me.btnSaveOrder.TabIndex = 25
        Me.btnSaveOrder.Text = "Save"
        Me.btnSaveOrder.UseVisualStyleBackColor = True
        '
        'order_create
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1300, 724)
        Me.Controls.Add(Me.btnSaveOrder)
        Me.Controls.Add(Me.orderCreateDGV)
        Me.Controls.Add(Me.btnremove)
        Me.Controls.Add(Me.btnAddProduct)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.btnBackOrderCreate)
        Me.Controls.Add(Me.DateTimePickerPlaced)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmbPaymentMethod)
        Me.Controls.Add(Me.lblTotalPrice)
        Me.Controls.Add(Me.DateTimePickerDue)
        Me.Controls.Add(Me.cmbCustomerOrder)
        Me.Controls.Add(Me.txtboxComments)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbProductOrder)
        Me.Name = "order_create"
        Me.Text = "order_create"
        CType(Me.orderCreateDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbProductOrder As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtboxComments As TextBox
    Friend WithEvents cmbCustomerOrder As ComboBox
    Friend WithEvents DateTimePickerDue As DateTimePicker
    Friend WithEvents lblTotalPrice As Label
    Friend WithEvents cmbPaymentMethod As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents DateTimePickerPlaced As DateTimePicker
    Friend WithEvents btnBackOrderCreate As Button
    Friend WithEvents btnCreate As Button
    Friend WithEvents btnAddProduct As Button
    Friend WithEvents btnremove As Button
    Friend WithEvents orderCreateDGV As DataGridView
    Friend WithEvents productID As DataGridViewTextBoxColumn
    Friend WithEvents product_name As DataGridViewTextBoxColumn
    Friend WithEvents product_price As DataGridViewTextBoxColumn
    Friend WithEvents product_type As DataGridViewTextBoxColumn
    Friend WithEvents product_suitability As DataGridViewTextBoxColumn
    Friend WithEvents btnSaveOrder As Button
End Class
