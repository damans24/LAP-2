
'MIS 322
'Damanbir Singh
'LAP 2
'10/14/2022


Option Explicit On
Option Strict On


Public Class Form1

    Const TAXRATE = 0.1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'set background color

        BackColor = Color.Lavender

    End Sub

    Private Sub submitOrderButton_Click(sender As Object, e As EventArgs) Handles submitOrderButton.Click
        'perform all necessary actions to submit order

        Dim sizeCost As Double
        Dim subtotal As Double
        Dim numArrangements As Integer
        Dim discountAmount As Double
        Dim deliveryFee As Double
        Dim taxAmount As Double
        Dim totalAmount As Double


        If nameTextBox.Text = Nothing Then
            MessageBox.Show("Name cannot be empty")
        ElseIf addressTextBox.Text = Nothing Then
            MessageBox.Show("Address cannot be empty")
        ElseIf phoneTextBox.Text = Nothing Then
            MessageBox.Show("Contact phone cannot be empty")
        ElseIf arrangementsNumTextBox.Text = Nothing Then
            MessageBox.Show("Arrangements number cannot be empty")
        ElseIf arrangementsSizeTextBox.Text = Nothing Then
            MessageBox.Show("Arrangements size cannot be empty")
            Exit Sub
        End If
        If Not IsNumeric(arrangementsNumTextBox.Text) Then
            MessageBox.Show("Number of arrangements must be a positive whole number")
        ElseIf arrangementsNumTextBox.Text <= "0" Then
            MessageBox.Show("Number of arrangements must be a positive whole number")
        End If

        If arrangementsSizeTextBox.Text = "S" Then
            sizeCost = 25
        ElseIf arrangementsSizeTextBox.Text = "M" Then
            sizeCost = 35
        ElseIf arrangementsSizeTextBox.Text = "L" Then
            sizeCost = 45
        Else
            MessageBox.Show("Arrangement size has to S, M or L")
            Exit Sub
        End If

        arrangementsSizeTextBox.Clear()
        numArrangements = Convert.ToInt32(arrangementsNumTextBox.Text)

        subtotal = sizeCost * numArrangements

        subtotalTextBox.Text = subtotal.ToString("C2")

        If numArrangements >= 10 Then
            discountAmount = subtotal * 0.1
        ElseIf numArrangements < 0 Then
            discountAmount = 0
        End If

        discountTextBox.Text = discountAmount.ToString("C2")

        If numArrangements = 1 OrElse numArrangements <= 5 Then
            deliveryFee = 5.0
        ElseIf numArrangements = 6 OrElse numArrangements <= 10 Then
            deliveryFee = 7.5
        ElseIf numArrangements >= 11 Then
            deliveryFee = 10.0
        End If

        deliveryTextBox.Text = deliveryFee.ToString("C2")

        taxAmount = TAXRATE * (deliveryFee + subtotal - discountAmount)
        taxTextBox.Text = taxAmount.ToString("C2")

        totalAmount = taxAmount + deliveryFee + subtotal - discountAmount
        totalTextBox.Text = totalAmount.ToString("C2")


    End Sub

    Private Sub resetButton_Click(sender As Object, e As EventArgs) Handles resetButton.Click
        'clear all textboxes

        nameTextBox.Clear()
        addressTextBox.Clear()
        phoneTextBox.Clear()
        arrangementsNumTextBox.Clear()
        arrangementsSizeTextBox.Clear()
        subtotalTextBox.Clear()
        deliveryTextBox.Clear()
        discountTextBox.Clear()
        taxTextBox.Clear()
        totalTextBox.Clear()
        nameTextBox.Select()

    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        'close application

        Close()

    End Sub
End Class
