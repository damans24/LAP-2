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
        Me.nameTextBox = New System.Windows.Forms.TextBox()
        Me.phoneTextBox = New System.Windows.Forms.TextBox()
        Me.addressTextBox = New System.Windows.Forms.TextBox()
        Me.arrangementsNumTextBox = New System.Windows.Forms.TextBox()
        Me.arrangementsSizeTextBox = New System.Windows.Forms.TextBox()
        Me.subtotalTextBox = New System.Windows.Forms.TextBox()
        Me.discountTextBox = New System.Windows.Forms.TextBox()
        Me.deliveryTextBox = New System.Windows.Forms.TextBox()
        Me.taxTextBox = New System.Windows.Forms.TextBox()
        Me.totalTextBox = New System.Windows.Forms.TextBox()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.addressLabel = New System.Windows.Forms.Label()
        Me.phoneLabel = New System.Windows.Forms.Label()
        Me.arrangementsNumLabel = New System.Windows.Forms.Label()
        Me.arrangementsSizeLabel = New System.Windows.Forms.Label()
        Me.discLabel = New System.Windows.Forms.Label()
        Me.sizeLabel = New System.Windows.Forms.Label()
        Me.subtotalLabel = New System.Windows.Forms.Label()
        Me.discountLabel = New System.Windows.Forms.Label()
        Me.deliveryLabel = New System.Windows.Forms.Label()
        Me.taxLabel = New System.Windows.Forms.Label()
        Me.totalLabel = New System.Windows.Forms.Label()
        Me.submitOrderButton = New System.Windows.Forms.Button()
        Me.resetButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'nameTextBox
        '
        Me.nameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameTextBox.Location = New System.Drawing.Point(361, 12)
        Me.nameTextBox.Multiline = True
        Me.nameTextBox.Name = "nameTextBox"
        Me.nameTextBox.Size = New System.Drawing.Size(381, 39)
        Me.nameTextBox.TabIndex = 0
        '
        'phoneTextBox
        '
        Me.phoneTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phoneTextBox.Location = New System.Drawing.Point(361, 127)
        Me.phoneTextBox.Multiline = True
        Me.phoneTextBox.Name = "phoneTextBox"
        Me.phoneTextBox.Size = New System.Drawing.Size(381, 39)
        Me.phoneTextBox.TabIndex = 1
        '
        'addressTextBox
        '
        Me.addressTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addressTextBox.Location = New System.Drawing.Point(361, 67)
        Me.addressTextBox.Multiline = True
        Me.addressTextBox.Name = "addressTextBox"
        Me.addressTextBox.Size = New System.Drawing.Size(381, 39)
        Me.addressTextBox.TabIndex = 2
        '
        'arrangementsNumTextBox
        '
        Me.arrangementsNumTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.arrangementsNumTextBox.Location = New System.Drawing.Point(361, 183)
        Me.arrangementsNumTextBox.Multiline = True
        Me.arrangementsNumTextBox.Name = "arrangementsNumTextBox"
        Me.arrangementsNumTextBox.Size = New System.Drawing.Size(100, 39)
        Me.arrangementsNumTextBox.TabIndex = 3
        '
        'arrangementsSizeTextBox
        '
        Me.arrangementsSizeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.arrangementsSizeTextBox.Location = New System.Drawing.Point(361, 239)
        Me.arrangementsSizeTextBox.Multiline = True
        Me.arrangementsSizeTextBox.Name = "arrangementsSizeTextBox"
        Me.arrangementsSizeTextBox.Size = New System.Drawing.Size(100, 39)
        Me.arrangementsSizeTextBox.TabIndex = 4
        '
        'subtotalTextBox
        '
        Me.subtotalTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subtotalTextBox.Location = New System.Drawing.Point(257, 378)
        Me.subtotalTextBox.Multiline = True
        Me.subtotalTextBox.Name = "subtotalTextBox"
        Me.subtotalTextBox.ReadOnly = True
        Me.subtotalTextBox.Size = New System.Drawing.Size(381, 39)
        Me.subtotalTextBox.TabIndex = 5
        Me.subtotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'discountTextBox
        '
        Me.discountTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.discountTextBox.Location = New System.Drawing.Point(257, 434)
        Me.discountTextBox.Multiline = True
        Me.discountTextBox.Name = "discountTextBox"
        Me.discountTextBox.ReadOnly = True
        Me.discountTextBox.Size = New System.Drawing.Size(381, 39)
        Me.discountTextBox.TabIndex = 6
        Me.discountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'deliveryTextBox
        '
        Me.deliveryTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deliveryTextBox.Location = New System.Drawing.Point(257, 491)
        Me.deliveryTextBox.Multiline = True
        Me.deliveryTextBox.Name = "deliveryTextBox"
        Me.deliveryTextBox.ReadOnly = True
        Me.deliveryTextBox.Size = New System.Drawing.Size(381, 39)
        Me.deliveryTextBox.TabIndex = 7
        Me.deliveryTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'taxTextBox
        '
        Me.taxTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.taxTextBox.Location = New System.Drawing.Point(257, 548)
        Me.taxTextBox.Multiline = True
        Me.taxTextBox.Name = "taxTextBox"
        Me.taxTextBox.ReadOnly = True
        Me.taxTextBox.Size = New System.Drawing.Size(381, 39)
        Me.taxTextBox.TabIndex = 8
        Me.taxTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'totalTextBox
        '
        Me.totalTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalTextBox.Location = New System.Drawing.Point(257, 606)
        Me.totalTextBox.Multiline = True
        Me.totalTextBox.Name = "totalTextBox"
        Me.totalTextBox.ReadOnly = True
        Me.totalTextBox.Size = New System.Drawing.Size(381, 39)
        Me.totalTextBox.TabIndex = 9
        Me.totalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nameLabel
        '
        Me.nameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameLabel.Location = New System.Drawing.Point(70, 12)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(285, 39)
        Me.nameLabel.TabIndex = 10
        Me.nameLabel.Text = "Name:"
        '
        'addressLabel
        '
        Me.addressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addressLabel.Location = New System.Drawing.Point(70, 70)
        Me.addressLabel.Name = "addressLabel"
        Me.addressLabel.Size = New System.Drawing.Size(285, 39)
        Me.addressLabel.TabIndex = 11
        Me.addressLabel.Text = "Delivery Address:"
        '
        'phoneLabel
        '
        Me.phoneLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phoneLabel.Location = New System.Drawing.Point(70, 130)
        Me.phoneLabel.Name = "phoneLabel"
        Me.phoneLabel.Size = New System.Drawing.Size(285, 39)
        Me.phoneLabel.TabIndex = 12
        Me.phoneLabel.Text = "Contact Phone:"
        '
        'arrangementsNumLabel
        '
        Me.arrangementsNumLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.arrangementsNumLabel.Location = New System.Drawing.Point(70, 186)
        Me.arrangementsNumLabel.Name = "arrangementsNumLabel"
        Me.arrangementsNumLabel.Size = New System.Drawing.Size(285, 39)
        Me.arrangementsNumLabel.TabIndex = 13
        Me.arrangementsNumLabel.Text = "Number of Arrangements"
        '
        'arrangementsSizeLabel
        '
        Me.arrangementsSizeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.arrangementsSizeLabel.Location = New System.Drawing.Point(70, 242)
        Me.arrangementsSizeLabel.Name = "arrangementsSizeLabel"
        Me.arrangementsSizeLabel.Size = New System.Drawing.Size(285, 39)
        Me.arrangementsSizeLabel.TabIndex = 14
        Me.arrangementsSizeLabel.Text = "Size of Arrangements:"
        '
        'discLabel
        '
        Me.discLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.discLabel.Location = New System.Drawing.Point(467, 186)
        Me.discLabel.Name = "discLabel"
        Me.discLabel.Size = New System.Drawing.Size(325, 39)
        Me.discLabel.TabIndex = 15
        Me.discLabel.Text = "10% Discount For 10 or More"
        '
        'sizeLabel
        '
        Me.sizeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sizeLabel.Location = New System.Drawing.Point(467, 242)
        Me.sizeLabel.Name = "sizeLabel"
        Me.sizeLabel.Size = New System.Drawing.Size(276, 39)
        Me.sizeLabel.TabIndex = 16
        Me.sizeLabel.Text = "S ($25), M ($35), L ($45)"
        '
        'subtotalLabel
        '
        Me.subtotalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subtotalLabel.Location = New System.Drawing.Point(22, 378)
        Me.subtotalLabel.Name = "subtotalLabel"
        Me.subtotalLabel.Size = New System.Drawing.Size(195, 39)
        Me.subtotalLabel.TabIndex = 17
        Me.subtotalLabel.Text = "Subtotal:"
        '
        'discountLabel
        '
        Me.discountLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.discountLabel.Location = New System.Drawing.Point(22, 434)
        Me.discountLabel.Name = "discountLabel"
        Me.discountLabel.Size = New System.Drawing.Size(207, 39)
        Me.discountLabel.TabIndex = 18
        Me.discountLabel.Text = "Discount Amount:"
        '
        'deliveryLabel
        '
        Me.deliveryLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deliveryLabel.Location = New System.Drawing.Point(22, 491)
        Me.deliveryLabel.Name = "deliveryLabel"
        Me.deliveryLabel.Size = New System.Drawing.Size(195, 39)
        Me.deliveryLabel.TabIndex = 19
        Me.deliveryLabel.Text = "Delivery Fee:"
        '
        'taxLabel
        '
        Me.taxLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.taxLabel.Location = New System.Drawing.Point(22, 548)
        Me.taxLabel.Name = "taxLabel"
        Me.taxLabel.Size = New System.Drawing.Size(195, 39)
        Me.taxLabel.TabIndex = 20
        Me.taxLabel.Text = "Tax:"
        '
        'totalLabel
        '
        Me.totalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalLabel.Location = New System.Drawing.Point(22, 606)
        Me.totalLabel.Name = "totalLabel"
        Me.totalLabel.Size = New System.Drawing.Size(195, 39)
        Me.totalLabel.TabIndex = 21
        Me.totalLabel.Text = "Total:"
        '
        'submitOrderButton
        '
        Me.submitOrderButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submitOrderButton.Location = New System.Drawing.Point(52, 305)
        Me.submitOrderButton.Name = "submitOrderButton"
        Me.submitOrderButton.Size = New System.Drawing.Size(189, 50)
        Me.submitOrderButton.TabIndex = 22
        Me.submitOrderButton.Text = "Submit Order"
        Me.submitOrderButton.UseVisualStyleBackColor = True
        '
        'resetButton
        '
        Me.resetButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resetButton.Location = New System.Drawing.Point(308, 305)
        Me.resetButton.Name = "resetButton"
        Me.resetButton.Size = New System.Drawing.Size(189, 50)
        Me.resetButton.TabIndex = 23
        Me.resetButton.Text = "Reset Form"
        Me.resetButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitButton.Location = New System.Drawing.Point(564, 305)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(189, 50)
        Me.exitButton.TabIndex = 24
        Me.exitButton.Text = "Exit App"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 657)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.resetButton)
        Me.Controls.Add(Me.submitOrderButton)
        Me.Controls.Add(Me.totalLabel)
        Me.Controls.Add(Me.taxLabel)
        Me.Controls.Add(Me.deliveryLabel)
        Me.Controls.Add(Me.discountLabel)
        Me.Controls.Add(Me.subtotalLabel)
        Me.Controls.Add(Me.sizeLabel)
        Me.Controls.Add(Me.discLabel)
        Me.Controls.Add(Me.arrangementsSizeLabel)
        Me.Controls.Add(Me.arrangementsNumLabel)
        Me.Controls.Add(Me.phoneLabel)
        Me.Controls.Add(Me.addressLabel)
        Me.Controls.Add(Me.nameLabel)
        Me.Controls.Add(Me.totalTextBox)
        Me.Controls.Add(Me.taxTextBox)
        Me.Controls.Add(Me.deliveryTextBox)
        Me.Controls.Add(Me.discountTextBox)
        Me.Controls.Add(Me.subtotalTextBox)
        Me.Controls.Add(Me.arrangementsSizeTextBox)
        Me.Controls.Add(Me.arrangementsNumTextBox)
        Me.Controls.Add(Me.addressTextBox)
        Me.Controls.Add(Me.phoneTextBox)
        Me.Controls.Add(Me.nameTextBox)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nameTextBox As TextBox
    Friend WithEvents phoneTextBox As TextBox
    Friend WithEvents addressTextBox As TextBox
    Friend WithEvents arrangementsNumTextBox As TextBox
    Friend WithEvents arrangementsSizeTextBox As TextBox
    Friend WithEvents subtotalTextBox As TextBox
    Friend WithEvents discountTextBox As TextBox
    Friend WithEvents deliveryTextBox As TextBox
    Friend WithEvents taxTextBox As TextBox
    Friend WithEvents totalTextBox As TextBox
    Friend WithEvents nameLabel As Label
    Friend WithEvents addressLabel As Label
    Friend WithEvents phoneLabel As Label
    Friend WithEvents arrangementsNumLabel As Label
    Friend WithEvents arrangementsSizeLabel As Label
    Friend WithEvents discLabel As Label
    Friend WithEvents sizeLabel As Label
    Friend WithEvents subtotalLabel As Label
    Friend WithEvents discountLabel As Label
    Friend WithEvents deliveryLabel As Label
    Friend WithEvents taxLabel As Label
    Friend WithEvents totalLabel As Label
    Friend WithEvents submitOrderButton As Button
    Friend WithEvents resetButton As Button
    Friend WithEvents exitButton As Button
End Class
