<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main_menu
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
        Me.btnProducts = New System.Windows.Forms.Button()
        Me.btnCustomer_order_history = New System.Windows.Forms.Button()
        Me.btnPrint_allegies_info = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCustomers = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnProducts
        '
        Me.btnProducts.Location = New System.Drawing.Point(329, 158)
        Me.btnProducts.Name = "btnProducts"
        Me.btnProducts.Size = New System.Drawing.Size(192, 23)
        Me.btnProducts.TabIndex = 0
        Me.btnProducts.Text = "Products"
        Me.btnProducts.UseVisualStyleBackColor = True
        '
        'btnCustomer_order_history
        '
        Me.btnCustomer_order_history.Location = New System.Drawing.Point(329, 216)
        Me.btnCustomer_order_history.Name = "btnCustomer_order_history"
        Me.btnCustomer_order_history.Size = New System.Drawing.Size(192, 23)
        Me.btnCustomer_order_history.TabIndex = 1
        Me.btnCustomer_order_history.Text = "Customer Order History"
        Me.btnCustomer_order_history.UseVisualStyleBackColor = True
        '
        'btnPrint_allegies_info
        '
        Me.btnPrint_allegies_info.Location = New System.Drawing.Point(329, 245)
        Me.btnPrint_allegies_info.Name = "btnPrint_allegies_info"
        Me.btnPrint_allegies_info.Size = New System.Drawing.Size(192, 23)
        Me.btnPrint_allegies_info.TabIndex = 3
        Me.btnPrint_allegies_info.Text = "Print allergies information"
        Me.btnPrint_allegies_info.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(329, 274)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(192, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCustomers
        '
        Me.btnCustomers.Location = New System.Drawing.Point(329, 187)
        Me.btnCustomers.Name = "btnCustomers"
        Me.btnCustomers.Size = New System.Drawing.Size(192, 23)
        Me.btnCustomers.TabIndex = 6
        Me.btnCustomers.Text = "Customers"
        Me.btnCustomers.UseVisualStyleBackColor = True
        '
        'main_menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCustomers)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnPrint_allegies_info)
        Me.Controls.Add(Me.btnCustomer_order_history)
        Me.Controls.Add(Me.btnProducts)
        Me.Name = "main_menu"
        Me.Text = "main_menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnProducts As Button
    Friend WithEvents btnCustomer_order_history As Button
    Friend WithEvents btnPrint_allegies_info As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnCustomers As Button
End Class
