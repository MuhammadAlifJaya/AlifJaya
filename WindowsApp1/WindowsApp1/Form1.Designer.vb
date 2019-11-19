<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(118, 71)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(152, 73)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString("____________________________________________", New Font("Arial", 12, FontStyle.Regular), Brushes.Black, New Point(0, 0))
        e.Graphics.DrawString("RSI Sakinah Mojokerto", New Font("Times New Roman", 14, FontStyle.Italic), Brushes.Black, New Point(0, 30))
        e.Graphics.DrawString("Bisri", New Font("Arial", 8, FontStyle.Regular), Brushes.Black, New Point(200, 37))
        e.Graphics.DrawString("19/11/19", New Font("Arial", 8, FontStyle.Regular), Brushes.Black, New Point(200, 47))
        e.Graphics.DrawString("____________________________________________", New Font("Arial", 12, FontStyle.Regular), Brushes.Black, New Point(0, 41))
        e.Graphics.DrawString("Adelia Utomo", New Font("Arial", 12, FontStyle.Bold), Brushes.Black, New Point(70, 70))
        e.Graphics.DrawString("RM 220973/P", New Font("Arial", 8, FontStyle.Regular), Brushes.Black, New Point(190, 60))
        e.Graphics.DrawString("3 x Sehari 1 tab", New Font("Arial", 12, FontStyle.Regular), Brushes.Black, New Point(10, 90))
        e.Graphics.DrawString("Analsik", New Font("Arial", 12, FontStyle.Bold), Brushes.Black, New Point(160, 90))
        e.Graphics.DrawString(" PAGI 08.00", New Font("Arial", 8, FontStyle.Regular), Brushes.Black, New Point(15, 115))
        e.Graphics.DrawString(" SIANG 14.00", New Font("Arial", 8, FontStyle.Regular), Brushes.Black, New Point(15, 130))
        e.Graphics.DrawString(" SORE 20.00", New Font("Arial", 8, FontStyle.Regular), Brushes.Black, New Point(130, 115))
        e.Graphics.DrawString(" MALAM 02.00", New Font("Arial", 8, FontStyle.Regular), Brushes.Black, New Point(130, 130))
        e.Graphics.DrawString("____________________________________________", New Font("Arial", 12, FontStyle.Regular), Brushes.Black, New Point(0, 140))

        e.Graphics.DrawString("____________________________________________", New Font("Arial", 12, FontStyle.Regular), Brushes.Black, New Point(0, 150))
        e.Graphics.DrawString("RSI Sakinah Mojokerto", New Font("Times New Roman", 14, FontStyle.Italic), Brushes.Black, New Point(0, 180))
        e.Graphics.DrawString("Bisri", New Font("Arial", 8, FontStyle.Regular), Brushes.Black, New Point(200, 187))
        e.Graphics.DrawString("19/11/19", New Font("Arial", 8, FontStyle.Regular), Brushes.Black, New Point(200, 197))
        e.Graphics.DrawString("____________________________________________", New Font("Arial", 12, FontStyle.Regular), Brushes.Black, New Point(0, 191))
        e.Graphics.DrawString("Adelia Utomo", New Font("Arial", 12, FontStyle.Bold), Brushes.Black, New Point(70, 220))
        e.Graphics.DrawString("RM 220973/P", New Font("Arial", 8, FontStyle.Regular), Brushes.Black, New Point(190, 210))
        e.Graphics.DrawString("3 x Sehari 1 tab", New Font("Arial", 12, FontStyle.Regular), Brushes.Black, New Point(10, 240))
        e.Graphics.DrawString("Analsik", New Font("Arial", 12, FontStyle.Bold), Brushes.Black, New Point(160, 240))
        e.Graphics.DrawString(" PAGI 08.00", New Font("Arial", 8, FontStyle.Regular), Brushes.Black, New Point(15, 265))
        e.Graphics.DrawString(" SIANG 14.00", New Font("Arial", 8, FontStyle.Regular), Brushes.Black, New Point(15, 280))
        e.Graphics.DrawString(" SORE 20.00", New Font("Arial", 8, FontStyle.Regular), Brushes.Black, New Point(130, 265))
        e.Graphics.DrawString(" MALAM 02.00", New Font("Arial", 8, FontStyle.Regular), Brushes.Black, New Point(130, 280))
        e.Graphics.DrawString("____________________________________________", New Font("Arial", 12, FontStyle.Regular), Brushes.Black, New Point(0, 290))

        e.Graphics.DrawString("____________________________________________", New Font("Arial", 12, FontStyle.Regular), Brushes.Black, New Point(0, 300))
        e.Graphics.DrawString("RSI Sakinah Mojokerto", New Font("Times New Roman", 14, FontStyle.Italic), Brushes.Black, New Point(0, 330))
        e.Graphics.DrawString("Bisri", New Font("Arial", 8, FontStyle.Regular), Brushes.Black, New Point(200, 337))
        e.Graphics.DrawString("19/11/19", New Font("Arial", 8, FontStyle.Regular), Brushes.Black, New Point(200, 347))
        e.Graphics.DrawString("____________________________________________", New Font("Arial", 12, FontStyle.Regular), Brushes.Black, New Point(0, 341))
        e.Graphics.DrawString("Adelia Utomo", New Font("Arial", 12, FontStyle.Bold), Brushes.Black, New Point(70, 370))
        e.Graphics.DrawString("RM 220973/P", New Font("Arial", 8, FontStyle.Regular), Brushes.Black, New Point(190, 360))
        e.Graphics.DrawString("3 x Sehari 1 tab", New Font("Arial", 12, FontStyle.Regular), Brushes.Black, New Point(10, 390))
        e.Graphics.DrawString("Analsik", New Font("Arial", 12, FontStyle.Bold), Brushes.Black, New Point(160, 390))
        e.Graphics.DrawString(" PAGI 08.00", New Font("Arial", 8, FontStyle.Regular), Brushes.Black, New Point(15, 415))
        e.Graphics.DrawString(" SIANG 14.00", New Font("Arial", 8, FontStyle.Regular), Brushes.Black, New Point(15, 430))
        e.Graphics.DrawString(" SORE 20.00", New Font("Arial", 8, FontStyle.Regular), Brushes.Black, New Point(130, 415))
        e.Graphics.DrawString(" MALAM 02.00", New Font("Arial", 8, FontStyle.Regular), Brushes.Black, New Point(130, 430))
        e.Graphics.DrawString("____________________________________________", New Font("Arial", 12, FontStyle.Regular), Brushes.Black, New Point(0, 440))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub
End Class
