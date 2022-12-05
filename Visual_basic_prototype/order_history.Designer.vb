<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class order_history
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
        Me.btnOrderCreate = New System.Windows.Forms.Button()
        Me.btnOrderBack = New System.Windows.Forms.Button()
        Me.orderDGV = New System.Windows.Forms.DataGridView()
        Me.orderID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customerID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.method_of_payment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.order_Placed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.order_due = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.comments = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnproducts = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnHistoryDelete = New System.Windows.Forms.Button()
        CType(Me.orderDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOrderCreate
        '
        Me.btnOrderCreate.Location = New System.Drawing.Point(977, 122)
        Me.btnOrderCreate.Name = "btnOrderCreate"
        Me.btnOrderCreate.Size = New System.Drawing.Size(105, 37)
        Me.btnOrderCreate.TabIndex = 9
        Me.btnOrderCreate.Text = "Create Order"
        Me.btnOrderCreate.UseVisualStyleBackColor = True
        '
        'btnOrderBack
        '
        Me.btnOrderBack.Location = New System.Drawing.Point(977, 79)
        Me.btnOrderBack.Name = "btnOrderBack"
        Me.btnOrderBack.Size = New System.Drawing.Size(105, 37)
        Me.btnOrderBack.TabIndex = 10
        Me.btnOrderBack.Text = "Back"
        Me.btnOrderBack.UseVisualStyleBackColor = True
        '
        'orderDGV
        '
        Me.orderDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.orderDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.orderID, Me.customerID, Me.total_price, Me.method_of_payment, Me.order_Placed, Me.order_due, Me.comments, Me.btnproducts})
        Me.orderDGV.Location = New System.Drawing.Point(56, 79)
        Me.orderDGV.Name = "orderDGV"
        Me.orderDGV.Size = New System.Drawing.Size(843, 437)
        Me.orderDGV.TabIndex = 11
        '
        'orderID
        '
        Me.orderID.HeaderText = "Order ID"
        Me.orderID.Name = "orderID"
        Me.orderID.ReadOnly = True
        '
        'customerID
        '
        Me.customerID.HeaderText = "Customer ID"
        Me.customerID.Name = "customerID"
        Me.customerID.ReadOnly = True
        '
        'total_price
        '
        Me.total_price.HeaderText = "Total Price"
        Me.total_price.Name = "total_price"
        Me.total_price.ReadOnly = True
        '
        'method_of_payment
        '
        Me.method_of_payment.HeaderText = "Payment method"
        Me.method_of_payment.Name = "method_of_payment"
        Me.method_of_payment.ReadOnly = True
        '
        'order_Placed
        '
        Me.order_Placed.HeaderText = "Order Placed"
        Me.order_Placed.Name = "order_Placed"
        Me.order_Placed.ReadOnly = True
        '
        'order_due
        '
        Me.order_due.HeaderText = "Order Due"
        Me.order_due.Name = "order_due"
        Me.order_due.ReadOnly = True
        '
        'comments
        '
        Me.comments.HeaderText = "Comments"
        Me.comments.Name = "comments"
        Me.comments.ReadOnly = True
        '
        'btnproducts
        '
        Me.btnproducts.HeaderText = "Products"
        Me.btnproducts.Name = "btnproducts"
        Me.btnproducts.ReadOnly = True
        Me.btnproducts.Text = "Edit/View products"
        Me.btnproducts.UseColumnTextForButtonValue = True
        '
        'btnHistoryDelete
        '
        Me.btnHistoryDelete.Location = New System.Drawing.Point(977, 165)
        Me.btnHistoryDelete.Name = "btnHistoryDelete"
        Me.btnHistoryDelete.Size = New System.Drawing.Size(105, 37)
        Me.btnHistoryDelete.TabIndex = 13
        Me.btnHistoryDelete.Text = "Delete"
        Me.btnHistoryDelete.UseVisualStyleBackColor = True
        '
        'order_history
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1129, 627)
        Me.Controls.Add(Me.btnHistoryDelete)
        Me.Controls.Add(Me.orderDGV)
        Me.Controls.Add(Me.btnOrderBack)
        Me.Controls.Add(Me.btnOrderCreate)
        Me.Name = "order_history"
        Me.Text = "order_history"
        CType(Me.orderDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnOrderCreate As Button
    Friend WithEvents btnOrderBack As Button
    Friend WithEvents orderDGV As DataGridView
    Friend WithEvents btnHistoryDelete As Button
    Friend WithEvents orderID As DataGridViewTextBoxColumn
    Friend WithEvents customerID As DataGridViewTextBoxColumn
    Friend WithEvents total_price As DataGridViewTextBoxColumn
    Friend WithEvents method_of_payment As DataGridViewTextBoxColumn
    Friend WithEvents order_Placed As DataGridViewTextBoxColumn
    Friend WithEvents order_due As DataGridViewTextBoxColumn
    Friend WithEvents comments As DataGridViewTextBoxColumn
    Friend WithEvents btnproducts As DataGridViewButtonColumn
End Class
