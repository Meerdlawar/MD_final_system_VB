Imports System.Drawing.Printing

Public Class printAllergiesInformationPage


    Private Sub print()
        ' sets a value indicating the allergen information to obtain printer settings
        PrintDialog1.Document = PrintDocument1
        ' if the user clicks OK then it prints 
        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub printPreview()
        ' sets the document to be previewed
        PrintPreviewDialog1.Document = PrintDocument1
        ' The document is put in preveiew mode
        PrintPreviewDialog1.ShowDialog()
    End Sub




    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        ' calls the print function when the print button is clicked
        print()
    End Sub

    Private Sub btnPrintPreview_Click(sender As Object, e As EventArgs) Handles btnPrintPreview.Click
        ' preview of document is displayed before printing
        printPreview()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        ' displays the image at the center of the preview display
        e.Graphics.DrawImage(PictureBox1.Image, 0, 0)
    End Sub

    Private Sub tbnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' hides the current page
        Me.Hide()
        ' displays the main menu
        main_menu.Show()
    End Sub
End Class