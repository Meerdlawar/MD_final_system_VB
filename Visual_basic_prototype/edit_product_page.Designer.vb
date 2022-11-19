<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class product_edit_page
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
        Me.product_list = New System.Windows.Forms.ListView()
        Me.btnproductAdd = New System.Windows.Forms.Button()
        Me.btnproductBack = New System.Windows.Forms.Button()
        Me.lblproductname = New System.Windows.Forms.Label()
        Me.lbltype = New System.Windows.Forms.Label()
        Me.lblDietInquiries = New System.Windows.Forms.Label()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.txtDietInquiries = New System.Windows.Forms.TextBox()
        Me.cmbProductType = New System.Windows.Forms.ComboBox()
        Me.lblProductPrice = New System.Windows.Forms.Label()
        Me.txtProductPrice = New System.Windows.Forms.TextBox()
        Me.btnproductDelete = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbEditPageFilter = New System.Windows.Forms.ComboBox()
        Me.txtSelectProductID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtProductSearch = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnProductSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'product_list
        '
        Me.product_list.GridLines = True
        Me.product_list.HideSelection = False
        Me.product_list.Location = New System.Drawing.Point(12, 63)
        Me.product_list.Name = "product_list"
        Me.product_list.Size = New System.Drawing.Size(571, 363)
        Me.product_list.TabIndex = 7
        Me.product_list.UseCompatibleStateImageBehavior = False
        Me.product_list.View = System.Windows.Forms.View.Details
        '
        'btnproductAdd
        '
        Me.btnproductAdd.Location = New System.Drawing.Point(702, 391)
        Me.btnproductAdd.Name = "btnproductAdd"
        Me.btnproductAdd.Size = New System.Drawing.Size(105, 67)
        Me.btnproductAdd.TabIndex = 8
        Me.btnproductAdd.Text = "Add"
        Me.btnproductAdd.UseVisualStyleBackColor = True
        '
        'btnproductBack
        '
        Me.btnproductBack.Location = New System.Drawing.Point(994, 27)
        Me.btnproductBack.Name = "btnproductBack"
        Me.btnproductBack.Size = New System.Drawing.Size(84, 36)
        Me.btnproductBack.TabIndex = 9
        Me.btnproductBack.Text = "Back"
        Me.btnproductBack.UseVisualStyleBackColor = True
        '
        'lblproductname
        '
        Me.lblproductname.AutoSize = True
        Me.lblproductname.Location = New System.Drawing.Point(622, 139)
        Me.lblproductname.Name = "lblproductname"
        Me.lblproductname.Size = New System.Drawing.Size(75, 13)
        Me.lblproductname.TabIndex = 14
        Me.lblproductname.Text = "Product Name"
        '
        'lbltype
        '
        Me.lbltype.AutoSize = True
        Me.lbltype.Location = New System.Drawing.Point(622, 234)
        Me.lbltype.Name = "lbltype"
        Me.lbltype.Size = New System.Drawing.Size(71, 13)
        Me.lbltype.TabIndex = 15
        Me.lbltype.Text = "Product Type"
        '
        'lblDietInquiries
        '
        Me.lblDietInquiries.AutoSize = True
        Me.lblDietInquiries.Location = New System.Drawing.Point(622, 286)
        Me.lblDietInquiries.Name = "lblDietInquiries"
        Me.lblDietInquiries.Size = New System.Drawing.Size(68, 13)
        Me.lblDietInquiries.TabIndex = 16
        Me.lblDietInquiries.Text = "Diet Inquiries"
        '
        'txtProductName
        '
        Me.txtProductName.Location = New System.Drawing.Point(733, 139)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(241, 20)
        Me.txtProductName.TabIndex = 18
        '
        'txtDietInquiries
        '
        Me.txtDietInquiries.Location = New System.Drawing.Point(733, 283)
        Me.txtDietInquiries.Name = "txtDietInquiries"
        Me.txtDietInquiries.Size = New System.Drawing.Size(241, 20)
        Me.txtDietInquiries.TabIndex = 20
        '
        'cmbProductType
        '
        Me.cmbProductType.FormattingEnabled = True
        Me.cmbProductType.Items.AddRange(New Object() {"Vegetarian", "Halal", "Gluten free"})
        Me.cmbProductType.Location = New System.Drawing.Point(734, 225)
        Me.cmbProductType.Name = "cmbProductType"
        Me.cmbProductType.Size = New System.Drawing.Size(241, 21)
        Me.cmbProductType.TabIndex = 21
        '
        'lblProductPrice
        '
        Me.lblProductPrice.AutoSize = True
        Me.lblProductPrice.Location = New System.Drawing.Point(622, 185)
        Me.lblProductPrice.Name = "lblProductPrice"
        Me.lblProductPrice.Size = New System.Drawing.Size(71, 13)
        Me.lblProductPrice.TabIndex = 22
        Me.lblProductPrice.Text = "Product Price"
        '
        'txtProductPrice
        '
        Me.txtProductPrice.Location = New System.Drawing.Point(733, 182)
        Me.txtProductPrice.Name = "txtProductPrice"
        Me.txtProductPrice.Size = New System.Drawing.Size(241, 20)
        Me.txtProductPrice.TabIndex = 23
        '
        'btnproductDelete
        '
        Me.btnproductDelete.Location = New System.Drawing.Point(813, 391)
        Me.btnproductDelete.Name = "btnproductDelete"
        Me.btnproductDelete.Size = New System.Drawing.Size(105, 67)
        Me.btnproductDelete.TabIndex = 24
        Me.btnproductDelete.Text = "Delete"
        Me.btnproductDelete.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(442, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Filter:"
        '
        'cmbEditPageFilter
        '
        Me.cmbEditPageFilter.FormattingEnabled = True
        Me.cmbEditPageFilter.Location = New System.Drawing.Point(445, 36)
        Me.cmbEditPageFilter.Name = "cmbEditPageFilter"
        Me.cmbEditPageFilter.Size = New System.Drawing.Size(121, 21)
        Me.cmbEditPageFilter.TabIndex = 26
        '
        'txtSelectProductID
        '
        Me.txtSelectProductID.BackColor = System.Drawing.SystemColors.Window
        Me.txtSelectProductID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSelectProductID.Location = New System.Drawing.Point(733, 98)
        Me.txtSelectProductID.Name = "txtSelectProductID"
        Me.txtSelectProductID.ReadOnly = True
        Me.txtSelectProductID.Size = New System.Drawing.Size(51, 20)
        Me.txtSelectProductID.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(622, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "ID:"
        '
        'txtProductSearch
        '
        Me.txtProductSearch.Location = New System.Drawing.Point(309, 36)
        Me.txtProductSearch.Name = "txtProductSearch"
        Me.txtProductSearch.Size = New System.Drawing.Size(126, 20)
        Me.txtProductSearch.TabIndex = 32
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(306, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Search:"
        '
        'btnProductSave
        '
        Me.btnProductSave.Location = New System.Drawing.Point(924, 391)
        Me.btnProductSave.Name = "btnProductSave"
        Me.btnProductSave.Size = New System.Drawing.Size(105, 67)
        Me.btnProductSave.TabIndex = 33
        Me.btnProductSave.Text = "Save"
        Me.btnProductSave.UseVisualStyleBackColor = True
        '
        'product_edit_page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1126, 617)
        Me.Controls.Add(Me.btnProductSave)
        Me.Controls.Add(Me.txtProductSearch)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSelectProductID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbEditPageFilter)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnproductDelete)
        Me.Controls.Add(Me.txtProductPrice)
        Me.Controls.Add(Me.lblProductPrice)
        Me.Controls.Add(Me.cmbProductType)
        Me.Controls.Add(Me.txtDietInquiries)
        Me.Controls.Add(Me.txtProductName)
        Me.Controls.Add(Me.lblDietInquiries)
        Me.Controls.Add(Me.lbltype)
        Me.Controls.Add(Me.lblproductname)
        Me.Controls.Add(Me.btnproductBack)
        Me.Controls.Add(Me.btnproductAdd)
        Me.Controls.Add(Me.product_list)
        Me.Name = "product_edit_page"
        Me.Text = "product_edit_page"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents product_list As ListView
    Friend WithEvents btnproductAdd As Button
    Friend WithEvents btnproductBack As Button
    Friend WithEvents lblproductname As Label
    Friend WithEvents lbltype As Label
    Friend WithEvents lblDietInquiries As Label
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents txtDietInquiries As TextBox
    Friend WithEvents cmbProductType As ComboBox
    Friend WithEvents lblProductPrice As Label
    Friend WithEvents txtProductPrice As TextBox
    Friend WithEvents btnproductDelete As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbEditPageFilter As ComboBox
    Friend WithEvents txtSelectProductID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtProductSearch As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnProductSave As Button
End Class
