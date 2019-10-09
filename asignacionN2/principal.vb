Public Class principal
    Dim tipo As String
    Dim age As Int16
    Dim cost As Double

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbTrataniento.SelectedIndex = 3
        Dim dtFecha As Date = DateSerial(Year(Date.Today), 1, 1)
        Me.dtpDate.Value = dtFecha
        Me.dtpDate.Value = Date.Today
    End Sub
    Private Sub CbTrataniento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTrataniento.SelectedIndexChanged

        age = txtNAge.Value
        tipo = cbTrataniento.SelectedItem.ToString

        Select Case tipo
            Case "Tipo A"
                rtbDescripcion.Text = ""
                rtbDescripcion.LoadFile(Application.StartupPath & "\tipoA.txt", RichTextBoxStreamType.PlainText)
                pbImagen.Image = Image.FromFile(Application.StartupPath & "\spaA.jpg")
                cost = 280.0
                lblCost.Text = cost

            Case "Tipo B"
                rtbDescripcion.Text = ""
                rtbDescripcion.LoadFile(Application.StartupPath & "\tipoB.txt", RichTextBoxStreamType.PlainText)
                pbImagen.Image = Image.FromFile(Application.StartupPath & "\spaB.jpg")
                cost = 195.0
                lblCost.Text = cost

            Case "Tipo C"
                rtbDescripcion.Text = ""
                rtbDescripcion.LoadFile(Application.StartupPath & "\tipoC.txt", RichTextBoxStreamType.PlainText)
                pbImagen.Image = Image.FromFile(Application.StartupPath & "\spaC.jpg")
                cost = 250.0
                lblCost.Text = cost
        End Select
    End Sub

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim descuento As Double
        If (DateString = dtpDate.Value.Date Or DateString < dtpDate.Value) Then
            MsgBox("Su fecha de ingreso no puede ser igual a la actual o mayor")

        ElseIf (txtName.Text = "" Or txtNAge.Value = 0 Or txtPhoneNumber.Text = "    -" Or cbTrataniento.SelectedItem.ToString = "--------------") Then
            MsgBox("Verifique todos los campos y serciorese que esten todos llenos")

        Else
            lbNameF.Text = txtName.Text
            lbtratamientoF.Text = cbTrataniento.SelectedItem.ToString
            lblCostF.Text = lblCost.Text
            lbDaysF.Text = DateDiff("d", DateString, dtpDate.Value.Date) * -1 & " dias"

            If (txtNAge.Value > 60) Then
                descuento = (Val(lblCostF.Text) * 0.25)
                lbDiscountF.Text = descuento
            ElseIf (txtNAge.Value < 25) Then
                descuento = (Val(lblCostF.Text) * 0.15)
                lbDiscountF.Text = descuento
            Else
                lbDiscountF.Text = 0
            End If

            lbTotalPayF.Text = Val(lblCostF.Text) - Val(lbDiscountF.Text)

            If (Val(lbDaysF.Text) >= 5 And Val(lbDaysF.Text) <= 7) Then
                lblAcredor.Text = "Felicidades usted ha ganado" & vbCrLf & "un tratameinto completamente gratis"
                lblLitLetters.Text = "Valido solo en tratameintos de menor" & vbCrLf & "coste al actual facturado"
            End If
        End If
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        FormPortada.Close()
    End Sub
End Class

'MsgBox(DateString) selecciona el dia actual de la maquina sin la hora en un formato string MM/DD/AA
'MsgBox() toma la fecha selccionada sin la hora del date time picker
'conectario random