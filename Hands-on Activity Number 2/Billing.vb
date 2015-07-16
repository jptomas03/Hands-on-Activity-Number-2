Public Class Billing
    Dim Qty As New Collection
    Dim Item As New Collection
    Dim Unit As New Collection
    Dim Amount As New Collection

    Private Sub ComputeButton_Click(sender As Object, e As EventArgs) Handles ComputeButton.Click
        Qty.Add(QtyTB1.Text)
        Qty.Add(QtyTB2.Text)
        Qty.Add(QtyTB3.Text)
        Qty.Add(QtyTB4.Text)
        Qty.Add(QtyTB5.Text)
        Qty.Add(QtyTB6.Text)
        Qty.Add(QtyTB7.Text)
        Qty.Add(QtyTB8.Text)
        Qty.Add(QtyTB9.Text)
        Qty.Add(QtyTB10.Text)

        Item.Add(ItemTB1.Text)
        Item.Add(ItemTB2.Text)
        Item.Add(ItemTB3.Text)
        Item.Add(ItemTB4.Text)
        Item.Add(ItemTB5.Text)
        Item.Add(ItemTB6.Text)
        Item.Add(ItemTB7.Text)
        Item.Add(ItemTB8.Text)
        Item.Add(ItemTB8.Text)
        Item.Add(ItemTB10.Text)

        Unit.Add(UnitTB1.Text)
        Unit.Add(UnitTB2.Text)
        Unit.Add(UnitTB3.Text)
        Unit.Add(UnitTB4.Text)
        Unit.Add(UnitTB5.Text)
        Unit.Add(UnitTB6.Text)
        Unit.Add(UnitTB7.Text)
        Unit.Add(UnitTB8.Text)
        Unit.Add(UnitTB9.Text)
        Unit.Add(UnitTB10.Text)

        Amount.Add(AmountTB1)
        Amount.Add(AmountTB2)
        Amount.Add(AmountTB3)
        Amount.Add(AmountTB4)
        Amount.Add(AmountTB5)
        Amount.Add(AmountTB6)
        Amount.Add(AmountTB7)
        Amount.Add(AmountTB8)
        Amount.Add(AmountTB9)
        Amount.Add(AmountTB10)

        Dim i As Integer
        Dim sum As Integer
        sum = 0
        For i = 1 To Qty.Count
            If Qty(i) = "" Then
                Continue For
            End If

            Amount(i).Text = Qty(i) * Unit(i)
            sum = sum + +Amount(i).Text
            TotalAmountTB.Text = sum
            AmountInFiguresLabel.Text = TotalAmountTB.Text
        Next
    End Sub
End Class
