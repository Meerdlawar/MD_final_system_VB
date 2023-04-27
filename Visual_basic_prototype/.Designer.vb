<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class product_page
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
        Me.productDGV = New System.Windows.Forms.DataGridView()
        Me.productID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.product_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.product_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.produce_type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.product_suitability = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtProductSearch = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnproductBack = New System.Windows.Forms.Button()
        Me.btnProductClear = New System.Windows.Forms.Button()
        Me.btnproductDelete = New System.Windows.Forms.Button()
        Me.txtProductPrice = New System.Windows.Forms.TextBox()
        Me.lblProductPrice = New System.Windows.Forms.Label()
        Me.txtDietInquiries = New System.Windows.Forms.TextBox()
        Me.lblDietInquiries = New System.Windows.Forms.Label()
        Me.lbltype = New System.Windows.Forms.Label()
        Me.btnproductAdd = New System.Windows.Forms.Button()
        Me.txtProductType = New System.Windows.Forms.TextBox()
        Me.btnProductSave = New System.Windows.Forms.Button()
        Me.btnProductCancel = New System.Windows.Forms.Button()
        CType(Me.productDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'productDGV
        '
        Me.productDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.productDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.productID, Me.product_name, Me.product_price, Me.produce_type, Me.product_suitability})
        Me.productDGV.Location = New System.Drawing.Point(12, 128)
        Me.productDGV.Name = "productDGV"
        Me.productDGV.Size = New System.Drawing.Size(496, 379)
        Me.productDGV.TabIndex = 0
        '
        'productID
        '
        Me.productID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.productID.HeaderText = "Product ID"
        Me.productID.Name = "productID"
        Me.productID.ReadOnly = True
        Me.productID.Width = 77
        '
        'product_name
        '
        Me.product_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.product_name.HeaderText = "Product Name"
        Me.product_name.Name = "product_name"
        Me.product_name.ReadOnly = True
        Me.product_name.Width = 92
        '
        'product_price
        '
        Me.product_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.product_price.HeaderText = "Product Price"
        Me.product_price.Name = "product_price"
        Me.product_price.ReadOnly = True
        Me.product_price.Width = 88
        '
        'produce_type
        '
        Me.produce_type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.produce_type.HeaderText = "Product Type"
        Me.produce_type.Name = "produce_type"
        Me.produce_type.ReadOnly = True
        Me.produce_type.Width = 88
        '
        'product_suitability
        '
        Me.product_suitability.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.product_suitability.HeaderText = "Product Suitability"
        Me.product_suitability.Name = "product_suitability"
        Me.product_suitability.ReadOnly = True
        Me.product_suitability.Width = 106
        '
        'txtProductSearch
        '
        Me.txtProductSearch.Location = New System.Drawing.Point(382, 102)
        Me.txtProductSearch.Name = "txtProductSearch"
        Me.txtProductSearch.Size = New System.Drawing.Size(126, 20)
        Me.txtProductSearch.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(379, 86)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 13)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Search Product:"
        '
        'txtProductName
        '
        Me.txtProductName.Location = New System.Drawing.Point(683, 177)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(241, 20)
        Me.txtProductName.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(571, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Product Name"
        '
        'btnproductBack
        '
        Me.btnproductBack.Location = New System.Drawing.Point(949, 102)
        Me.btnproductBack.Name = "btnproductBack"
        Me.btnproductBack.Size = New System.Drawing.Size(84, 36)
        Me.btnproductBack.TabIndex = 11
        Me.btnproductBack.Text = "Back"
        Me.btnproductBack.UseVisualStyleBackColor = True
        '
        'btnProductClear
        '
        Me.btnProductClear.Location = New System.Drawing.Point(822, 384)
        Me.btnProductClear.Name = "btnProductClear"
        Me.btnProductClear.Size = New System.Drawing.Size(105, 35)
        Me.btnProductClear.TabIndex = 7
        Me.btnProductClear.Text = "Clear"
        Me.btnProductClear.UseVisualStyleBackColor = True
        '
        'btnproductDelete
        '
        Me.btnproductDelete.Location = New System.Drawing.Point(711, 384)
        Me.btnproductDelete.Name = "btnproductDelete"
        Me.btnproductDelete.Size = New System.Drawing.Size(105, 35)
        Me.btnproductDelete.TabIndex = 6
        Me.btnproductDelete.Text = "Delete"
        Me.btnproductDelete.UseVisualStyleBackColor = True
        '
        'txtProductPrice
        '
        Me.txtProductPrice.Location = New System.Drawing.Point(682, 216)
        Me.txtProductPrice.Name = "txtProductPrice"
        Me.txtProductPrice.Size = New System.Drawing.Size(241, 20)
        Me.txtProductPrice.TabIndex = 2
        '
        'lblProductPrice
        '
        Me.lblProductPrice.AutoSize = True
        Me.lblProductPrice.Location = New System.Drawing.Point(571, 219)
        Me.lblProductPrice.Name = "lblProductPrice"
        Me.lblProductPrice.Size = New System.Drawing.Size(71, 13)
        Me.lblProductPrice.TabIndex = 47
        Me.lblProductPrice.Text = "Product Price"
        '
        'txtDietInquiries
        '
        Me.txtDietInquiries.Location = New System.Drawing.Point(682, 317)
        Me.txtDietInquiries.Name = "txtDietInquiries"
        Me.txtDietInquiries.Size = New System.Drawing.Size(241, 20)
        Me.txtDietInquiries.TabIndex = 4
        '
        'lblDietInquiries
        '
        Me.lblDietInquiries.AutoSize = True
        Me.lblDietInquiries.Location = New System.Drawing.Point(571, 320)
        Me.lblDietInquiries.Name = "lblDietInquiries"
        Me.lblDietInquiries.Size = New System.Drawing.Size(68, 13)
        Me.lblDietInquiries.TabIndex = 44
        Me.lblDietInquiries.Text = "Diet Inquiries"
        '
        'lbltype
        '
        Me.lbltype.AutoSize = True
        Me.lbltype.Location = New System.Drawing.Point(571, 268)
        Me.lbltype.Name = "lbltype"
        Me.lbltype.Size = New System.Drawing.Size(71, 13)
        Me.lbltype.TabIndex = 43
        Me.lbltype.Text = "Product Type"
        '
        'btnproductAdd
        '
        Me.btnproductAdd.Location = New System.Drawing.Point(600, 384)
        Me.btnproductAdd.Name = "btnproductAdd"
        Me.btnproductAdd.Size = New System.Drawing.Size(105, 35)
        Me.btnproductAdd.TabIndex = 5
        Me.btnproductAdd.Text = "Add"
        Me.btnproductAdd.UseVisualStyleBackColor = True
        '
        'txtProductType
        '
        Me.txtProductType.Location = New System.Drawing.Point(682, 265)
        Me.txtProductType.Name = "txtProductType"
        Me.txtProductType.Size = New System.Drawing.Size(241, 20)
        Me.txtProductType.TabIndex = 3
        '
        'btnProductSave
        '
        Me.btnProductSave.Location = New System.Drawing.Point(652, 426)
        Me.btnProductSave.Name = "btnProductSave"
        Me.btnProductSave.Size = New System.Drawing.Size(105, 35)
        Me.btnProductSave.TabIndex = 8
        Me.btnProductSave.Text = "Save"
        Me.btnProductSave.UseVisualStyleBackColor = True
        '
        'btnProductCancel
        '
        Me.btnProductCancel.Location = New System.Drawing.Point(763, 425)
        Me.btnProductCancel.Name = "btnProductCancel"
        Me.btnProductCancel.Size = New System.Drawing.Size(105, 36)
        Me.btnProductCancel.TabIndex = 9
        Me.btnProductCancel.Text = "Cancel"
        Me.btnProductCancel.UseVisualStyleBackColor = True
        '
        'product_page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1112, 658)
        Me.Controls.Add(Me.btnProductCancel)
        Me.Controls.Add(Me.btnProductSave)
        Me.Controls.Add(Me.txtProductType)
        Me.Controls.Add(Me.btnProductClear)
        Me.Controls.Add(Me.btnproductDelete)
        Me.Controls.Add(Me.txtProductPrice)
        Me.Controls.Add(Me.lblProductPrice)
        Me.Controls.Add(Me.txtDietInquiries)
        Me.Controls.Add(Me.lblDietInquiries)
        Me.Controls.Add(Me.lbltype)
        Me.Controls.Add(Me.btnproductAdd)
        Me.Controls.Add(Me.txtProductSearch)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtProductName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnproductBack)
        Me.Controls.Add(Me.productDGV)
        Me.Name = "product_page"
        Me.Text = "product_page"
        CType(Me.productDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents productDGV As DataGridView
    Friend WithEvents txtProductSearch As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnproductBack As Button
    Friend WithEvents btnProductClear As Button
    Friend WithEvents btnproductDelete As Button
    Friend WithEvents txtProductPrice As TextBox
    Friend WithEvents lblProductPrice As Label
    Friend WithEvents txtDietInquiries As TextBox
    Friend WithEvents lblDietInquiries As Label
    Friend WithEvents lbltype As Label
    Friend WithEvents btnproductAdd As Button
    Friend WithEvents productID As DataGridViewTextBoxColumn
    Friend WithEvents product_name As DataGridViewTextBoxColumn
    Friend WithEvents product_price As DataGridViewTextBoxColumn
    Friend WithEvents produce_type As DataGridViewTextBoxColumn
    Friend WithEvents product_suitability As DataGridViewTextBoxColumn
    Friend WithEvents txtProductType As TextBox
    Friend WithEvents btnProductSave As Button
    Friend WithEvents btnProductCancel As Button
End Class
