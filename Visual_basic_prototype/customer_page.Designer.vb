<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class customer_page
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
        Me.customerDGV = New System.Windows.Forms.DataGridView()
        Me.customerID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prefix = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.phone_number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subfix = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btncustomerCancel = New System.Windows.Forms.Button()
        Me.btncustomerSave = New System.Windows.Forms.Button()
        Me.txtCustomerPrefix = New System.Windows.Forms.TextBox()
        Me.btncustomerClear = New System.Windows.Forms.Button()
        Me.btncustomerDelete = New System.Windows.Forms.Button()
        Me.txtCustomerLname = New System.Windows.Forms.TextBox()
        Me.lblProductPrice = New System.Windows.Forms.Label()
        Me.txtCustomerNumber = New System.Windows.Forms.TextBox()
        Me.lblDietInquiries = New System.Windows.Forms.Label()
        Me.lbltype = New System.Windows.Forms.Label()
        Me.btncustomerAdd = New System.Windows.Forms.Button()
        Me.txtCustomerFname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btncustomerBack = New System.Windows.Forms.Button()
        Me.txtCustomerEmail = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCustomerSubfix = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCustomerSearch = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.customerDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'customerDGV
        '
        Me.customerDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.customerDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.customerID, Me.prefix, Me.Fname, Me.Lname, Me.phone_number, Me.email, Me.subfix})
        Me.customerDGV.Location = New System.Drawing.Point(12, 75)
        Me.customerDGV.Name = "customerDGV"
        Me.customerDGV.Size = New System.Drawing.Size(745, 538)
        Me.customerDGV.TabIndex = 0
        '
        'customerID
        '
        Me.customerID.HeaderText = "Customer ID"
        Me.customerID.Name = "customerID"
        Me.customerID.ReadOnly = True
        '
        'prefix
        '
        Me.prefix.HeaderText = "pre-fix"
        Me.prefix.Name = "prefix"
        Me.prefix.ReadOnly = True
        '
        'Fname
        '
        Me.Fname.HeaderText = "First Name"
        Me.Fname.Name = "Fname"
        Me.Fname.ReadOnly = True
        '
        'Lname
        '
        Me.Lname.HeaderText = "Last Name"
        Me.Lname.Name = "Lname"
        Me.Lname.ReadOnly = True
        '
        'phone_number
        '
        Me.phone_number.HeaderText = "Phone Number"
        Me.phone_number.Name = "phone_number"
        Me.phone_number.ReadOnly = True
        '
        'email
        '
        Me.email.HeaderText = "Email"
        Me.email.Name = "email"
        Me.email.ReadOnly = True
        '
        'subfix
        '
        Me.subfix.HeaderText = "Sub-fix"
        Me.subfix.Name = "subfix"
        Me.subfix.ReadOnly = True
        '
        'btncustomerCancel
        '
        Me.btncustomerCancel.Location = New System.Drawing.Point(1023, 505)
        Me.btncustomerCancel.Name = "btncustomerCancel"
        Me.btncustomerCancel.Size = New System.Drawing.Size(105, 36)
        Me.btncustomerCancel.TabIndex = 71
        Me.btncustomerCancel.Text = "Cancel"
        Me.btncustomerCancel.UseVisualStyleBackColor = True
        '
        'btncustomerSave
        '
        Me.btncustomerSave.Location = New System.Drawing.Point(912, 506)
        Me.btncustomerSave.Name = "btncustomerSave"
        Me.btncustomerSave.Size = New System.Drawing.Size(105, 35)
        Me.btncustomerSave.TabIndex = 70
        Me.btncustomerSave.Text = "Save"
        Me.btncustomerSave.UseVisualStyleBackColor = True
        '
        'txtCustomerPrefix
        '
        Me.txtCustomerPrefix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCustomerPrefix.Location = New System.Drawing.Point(959, 133)
        Me.txtCustomerPrefix.Name = "txtCustomerPrefix"
        Me.txtCustomerPrefix.Size = New System.Drawing.Size(241, 20)
        Me.txtCustomerPrefix.TabIndex = 69
        '
        'btncustomerClear
        '
        Me.btncustomerClear.Location = New System.Drawing.Point(1082, 464)
        Me.btncustomerClear.Name = "btncustomerClear"
        Me.btncustomerClear.Size = New System.Drawing.Size(105, 35)
        Me.btncustomerClear.TabIndex = 68
        Me.btncustomerClear.Text = "Clear"
        Me.btncustomerClear.UseVisualStyleBackColor = True
        '
        'btncustomerDelete
        '
        Me.btncustomerDelete.Location = New System.Drawing.Point(971, 464)
        Me.btncustomerDelete.Name = "btncustomerDelete"
        Me.btncustomerDelete.Size = New System.Drawing.Size(105, 35)
        Me.btncustomerDelete.TabIndex = 67
        Me.btncustomerDelete.Text = "Delete"
        Me.btncustomerDelete.UseVisualStyleBackColor = True
        '
        'txtCustomerLname
        '
        Me.txtCustomerLname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCustomerLname.Location = New System.Drawing.Point(959, 215)
        Me.txtCustomerLname.Name = "txtCustomerLname"
        Me.txtCustomerLname.Size = New System.Drawing.Size(241, 20)
        Me.txtCustomerLname.TabIndex = 66
        '
        'lblProductPrice
        '
        Me.lblProductPrice.AutoSize = True
        Me.lblProductPrice.Location = New System.Drawing.Point(849, 215)
        Me.lblProductPrice.Name = "lblProductPrice"
        Me.lblProductPrice.Size = New System.Drawing.Size(61, 13)
        Me.lblProductPrice.TabIndex = 65
        Me.lblProductPrice.Text = "Last Name:"
        '
        'txtCustomerNumber
        '
        Me.txtCustomerNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCustomerNumber.Location = New System.Drawing.Point(959, 263)
        Me.txtCustomerNumber.Name = "txtCustomerNumber"
        Me.txtCustomerNumber.Size = New System.Drawing.Size(241, 20)
        Me.txtCustomerNumber.TabIndex = 64
        '
        'lblDietInquiries
        '
        Me.lblDietInquiries.AutoSize = True
        Me.lblDietInquiries.Location = New System.Drawing.Point(849, 263)
        Me.lblDietInquiries.Name = "lblDietInquiries"
        Me.lblDietInquiries.Size = New System.Drawing.Size(79, 13)
        Me.lblDietInquiries.TabIndex = 63
        Me.lblDietInquiries.Text = "Phone-number:"
        '
        'lbltype
        '
        Me.lbltype.AutoSize = True
        Me.lbltype.Location = New System.Drawing.Point(849, 135)
        Me.lbltype.Name = "lbltype"
        Me.lbltype.Size = New System.Drawing.Size(42, 13)
        Me.lbltype.TabIndex = 62
        Me.lbltype.Text = "Pre-Fix:"
        '
        'btncustomerAdd
        '
        Me.btncustomerAdd.Location = New System.Drawing.Point(860, 464)
        Me.btncustomerAdd.Name = "btncustomerAdd"
        Me.btncustomerAdd.Size = New System.Drawing.Size(105, 35)
        Me.btncustomerAdd.TabIndex = 61
        Me.btncustomerAdd.Text = "Add"
        Me.btncustomerAdd.UseVisualStyleBackColor = True
        '
        'txtCustomerFname
        '
        Me.txtCustomerFname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCustomerFname.Location = New System.Drawing.Point(960, 176)
        Me.txtCustomerFname.Name = "txtCustomerFname"
        Me.txtCustomerFname.Size = New System.Drawing.Size(241, 20)
        Me.txtCustomerFname.TabIndex = 58
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(849, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "First Name:"
        '
        'btncustomerBack
        '
        Me.btncustomerBack.Location = New System.Drawing.Point(1251, 65)
        Me.btncustomerBack.Name = "btncustomerBack"
        Me.btncustomerBack.Size = New System.Drawing.Size(84, 36)
        Me.btncustomerBack.TabIndex = 56
        Me.btncustomerBack.Text = "Back"
        Me.btncustomerBack.UseVisualStyleBackColor = True
        '
        'txtCustomerEmail
        '
        Me.txtCustomerEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCustomerEmail.Location = New System.Drawing.Point(959, 311)
        Me.txtCustomerEmail.Name = "txtCustomerEmail"
        Me.txtCustomerEmail.Size = New System.Drawing.Size(241, 20)
        Me.txtCustomerEmail.TabIndex = 73
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(849, 311)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "e-mail:"
        '
        'txtCustomerSubfix
        '
        Me.txtCustomerSubfix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCustomerSubfix.Location = New System.Drawing.Point(959, 354)
        Me.txtCustomerSubfix.Name = "txtCustomerSubfix"
        Me.txtCustomerSubfix.Size = New System.Drawing.Size(241, 20)
        Me.txtCustomerSubfix.TabIndex = 75
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(849, 354)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "Sub-fix:"
        '
        'txtCustomerSearch
        '
        Me.txtCustomerSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCustomerSearch.Location = New System.Drawing.Point(516, 49)
        Me.txtCustomerSearch.Name = "txtCustomerSearch"
        Me.txtCustomerSearch.Size = New System.Drawing.Size(241, 20)
        Me.txtCustomerSearch.TabIndex = 76
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(411, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 77
        Me.Label4.Text = "Search Customer:"
        '
        'customer_page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1402, 704)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCustomerSearch)
        Me.Controls.Add(Me.txtCustomerSubfix)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCustomerEmail)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btncustomerCancel)
        Me.Controls.Add(Me.btncustomerSave)
        Me.Controls.Add(Me.txtCustomerPrefix)
        Me.Controls.Add(Me.btncustomerClear)
        Me.Controls.Add(Me.btncustomerDelete)
        Me.Controls.Add(Me.txtCustomerLname)
        Me.Controls.Add(Me.lblProductPrice)
        Me.Controls.Add(Me.txtCustomerNumber)
        Me.Controls.Add(Me.lblDietInquiries)
        Me.Controls.Add(Me.lbltype)
        Me.Controls.Add(Me.btncustomerAdd)
        Me.Controls.Add(Me.txtCustomerFname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btncustomerBack)
        Me.Controls.Add(Me.customerDGV)
        Me.Name = "customer_page"
        Me.Text = "cusstomer_page"
        CType(Me.customerDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents customerDGV As DataGridView
    Friend WithEvents customerID As DataGridViewTextBoxColumn
    Friend WithEvents prefix As DataGridViewTextBoxColumn
    Friend WithEvents Fname As DataGridViewTextBoxColumn
    Friend WithEvents Lname As DataGridViewTextBoxColumn
    Friend WithEvents phone_number As DataGridViewTextBoxColumn
    Friend WithEvents email As DataGridViewTextBoxColumn
    Friend WithEvents subfix As DataGridViewTextBoxColumn
    Friend WithEvents btncustomerCancel As Button
    Friend WithEvents btncustomerSave As Button
    Friend WithEvents txtCustomerPrefix As TextBox
    Friend WithEvents btncustomerClear As Button
    Friend WithEvents btncustomerDelete As Button
    Friend WithEvents txtCustomerLname As TextBox
    Friend WithEvents lblProductPrice As Label
    Friend WithEvents txtCustomerNumber As TextBox
    Friend WithEvents lblDietInquiries As Label
    Friend WithEvents lbltype As Label
    Friend WithEvents btncustomerAdd As Button
    Friend WithEvents txtCustomerFname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btncustomerBack As Button
    Friend WithEvents txtCustomerEmail As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCustomerSubfix As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCustomerSearch As TextBox
    Friend WithEvents Label4 As Label
End Class
