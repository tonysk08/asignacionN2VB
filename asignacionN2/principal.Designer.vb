<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class principal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbMale = New System.Windows.Forms.RadioButton()
        Me.rbFemal = New System.Windows.Forms.RadioButton()
        Me.txtPhoneNumber = New System.Windows.Forms.MaskedTextBox()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.txtNAge = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbTrataniento = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.pbImagen = New System.Windows.Forms.PictureBox()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.rtbDescripcion = New System.Windows.Forms.RichTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblAcredor = New System.Windows.Forms.Label()
        Me.lbTotalPayF = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lbDiscountF = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblCostF = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lbDaysF = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbtratamientoF = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbNameF = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblLitLetters = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtNAge, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(247, 37)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Su Información"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbMale)
        Me.GroupBox1.Controls.Add(Me.rbFemal)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 130)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(169, 90)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sexo"
        '
        'rbMale
        '
        Me.rbMale.AutoSize = True
        Me.rbMale.Location = New System.Drawing.Point(29, 54)
        Me.rbMale.Name = "rbMale"
        Me.rbMale.Size = New System.Drawing.Size(73, 17)
        Me.rbMale.TabIndex = 8
        Me.rbMale.TabStop = True
        Me.rbMale.Text = "Masculino"
        Me.rbMale.UseVisualStyleBackColor = True
        '
        'rbFemal
        '
        Me.rbFemal.AutoSize = True
        Me.rbFemal.Checked = True
        Me.rbFemal.Location = New System.Drawing.Point(29, 31)
        Me.rbFemal.Name = "rbFemal"
        Me.rbFemal.Size = New System.Drawing.Size(71, 17)
        Me.rbFemal.TabIndex = 7
        Me.rbFemal.TabStop = True
        Me.rbFemal.Text = "Femenino"
        Me.rbFemal.UseVisualStyleBackColor = True
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Location = New System.Drawing.Point(10, 256)
        Me.txtPhoneNumber.Mask = "0000-0000"
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtPhoneNumber.TabIndex = 18
        '
        'dtpDate
        '
        Me.dtpDate.Location = New System.Drawing.Point(10, 307)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpDate.TabIndex = 17
        Me.dtpDate.Value = New Date(2019, 10, 7, 9, 14, 42, 0)
        '
        'txtNAge
        '
        Me.txtNAge.Location = New System.Drawing.Point(218, 85)
        Me.txtNAge.Name = "txtNAge"
        Me.txtNAge.Size = New System.Drawing.Size(68, 20)
        Me.txtNAge.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(215, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Edad:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Nombre:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(10, 86)
        Me.txtName.MaxLength = 20
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(169, 20)
        Me.txtName.TabIndex = 13
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(84, 397)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 23
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 345)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Tipo de tratamiento"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 240)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Numero de Telefono"
        '
        'cbTrataniento
        '
        Me.cbTrataniento.FormattingEnabled = True
        Me.cbTrataniento.Items.AddRange(New Object() {"Tipo A", "Tipo B", "Tipo C", "--------------"})
        Me.cbTrataniento.Location = New System.Drawing.Point(13, 361)
        Me.cbTrataniento.Name = "cbTrataniento"
        Me.cbTrataniento.Size = New System.Drawing.Size(121, 21)
        Me.cbTrataniento.TabIndex = 20
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.btnCalcular)
        Me.GroupBox2.Controls.Add(Me.dtpDate)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.cbTrataniento)
        Me.GroupBox2.Controls.Add(Me.txtPhoneNumber)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtName)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtNAge)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(291, 426)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Informacion"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(10, 291)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(92, 13)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Fecha de ingreso:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.pbImagen)
        Me.GroupBox3.Controls.Add(Me.lblCost)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.rtbDescripcion)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Location = New System.Drawing.Point(309, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(236, 426)
        Me.GroupBox3.TabIndex = 26
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Descripcion de tratamiento"
        '
        'pbImagen
        '
        Me.pbImagen.Location = New System.Drawing.Point(0, 286)
        Me.pbImagen.Name = "pbImagen"
        Me.pbImagen.Size = New System.Drawing.Size(229, 134)
        Me.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbImagen.TabIndex = 31
        Me.pbImagen.TabStop = False
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Location = New System.Drawing.Point(115, 259)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(43, 13)
        Me.lblCost.TabIndex = 30
        Me.lblCost.Text = "$$$$$$"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(72, 259)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Costo:"
        '
        'rtbDescripcion
        '
        Me.rtbDescripcion.Location = New System.Drawing.Point(5, 45)
        Me.rtbDescripcion.Name = "rtbDescripcion"
        Me.rtbDescripcion.ReadOnly = True
        Me.rtbDescripcion.Size = New System.Drawing.Size(224, 198)
        Me.rtbDescripcion.TabIndex = 28
        Me.rtbDescripcion.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Incluye:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblLitLetters)
        Me.GroupBox4.Controls.Add(Me.lblAcredor)
        Me.GroupBox4.Controls.Add(Me.lbTotalPayF)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.lbDiscountF)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.lblCostF)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.lbDaysF)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.lbtratamientoF)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.lbNameF)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Location = New System.Drawing.Point(558, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(226, 425)
        Me.GroupBox4.TabIndex = 27
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Factura"
        '
        'lblAcredor
        '
        Me.lblAcredor.AutoSize = True
        Me.lblAcredor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAcredor.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblAcredor.Location = New System.Drawing.Point(6, 361)
        Me.lblAcredor.Name = "lblAcredor"
        Me.lblAcredor.Size = New System.Drawing.Size(10, 13)
        Me.lblAcredor.TabIndex = 13
        Me.lblAcredor.Text = "."
        '
        'lbTotalPayF
        '
        Me.lbTotalPayF.AutoSize = True
        Me.lbTotalPayF.Location = New System.Drawing.Point(187, 286)
        Me.lbTotalPayF.Name = "lbTotalPayF"
        Me.lbTotalPayF.Size = New System.Drawing.Size(34, 13)
        Me.lbTotalPayF.TabIndex = 12
        Me.lbTotalPayF.Text = "-$$$$"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(21, 286)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(71, 13)
        Me.Label15.TabIndex = 11
        Me.Label15.Text = "Tota a pagar:"
        '
        'lbDiscountF
        '
        Me.lbDiscountF.AutoSize = True
        Me.lbDiscountF.Location = New System.Drawing.Point(181, 216)
        Me.lbDiscountF.Name = "lbDiscountF"
        Me.lbDiscountF.Size = New System.Drawing.Size(34, 13)
        Me.lbDiscountF.TabIndex = 10
        Me.lbDiscountF.Text = "-$$$$"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(21, 216)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(62, 13)
        Me.Label14.TabIndex = 9
        Me.Label14.Text = "Desceunto:"
        '
        'lblCostF
        '
        Me.lblCostF.AutoSize = True
        Me.lblCostF.Location = New System.Drawing.Point(182, 154)
        Me.lblCostF.Name = "lblCostF"
        Me.lblCostF.Size = New System.Drawing.Size(31, 13)
        Me.lblCostF.TabIndex = 8
        Me.lblCostF.Text = "$$$$"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(21, 154)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(113, 13)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "Costo del Tratameinto:"
        '
        'lbDaysF
        '
        Me.lbDaysF.AutoSize = True
        Me.lbDaysF.Location = New System.Drawing.Point(181, 186)
        Me.lbDaysF.Name = "lbDaysF"
        Me.lbDaysF.Size = New System.Drawing.Size(39, 13)
        Me.lbDaysF.TabIndex = 6
        Me.lbDaysF.Text = "xx dias"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(21, 186)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Estancia:"
        '
        'lbtratamientoF
        '
        Me.lbtratamientoF.AutoSize = True
        Me.lbtratamientoF.Location = New System.Drawing.Point(182, 120)
        Me.lbtratamientoF.Name = "lbtratamientoF"
        Me.lbtratamientoF.Size = New System.Drawing.Size(39, 13)
        Me.lbtratamientoF.TabIndex = 4
        Me.lbtratamientoF.Text = "TIPOX"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(21, 120)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 13)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Tratamiento:"
        '
        'lbNameF
        '
        Me.lbNameF.AutoSize = True
        Me.lbNameF.Location = New System.Drawing.Point(182, 85)
        Me.lbNameF.Name = "lbNameF"
        Me.lbNameF.Size = New System.Drawing.Size(38, 13)
        Me.lbNameF.TabIndex = 2
        Me.lbNameF.Text = "NAME"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(21, 85)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Cliente:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(87, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Spa la SAL"
        '
        'lblLitLetters
        '
        Me.lblLitLetters.AutoSize = True
        Me.lblLitLetters.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLitLetters.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLitLetters.Location = New System.Drawing.Point(7, 386)
        Me.lblLitLetters.Name = "lblLitLetters"
        Me.lblLitLetters.Size = New System.Drawing.Size(11, 13)
        Me.lblLitLetters.TabIndex = 14
        Me.lblLitLetters.Text = "."
        '
        'principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "principal"
        Me.Text = "principal"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtNAge, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbMale As RadioButton
    Friend WithEvents rbFemal As RadioButton
    Friend WithEvents txtPhoneNumber As MaskedTextBox
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents txtNAge As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbTrataniento As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents pbImagen As PictureBox
    Friend WithEvents lblCost As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents rtbDescripcion As RichTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents lblCostF As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lbDaysF As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lbtratamientoF As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lbNameF As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lbTotalPayF As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents lbDiscountF As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblAcredor As Label
    Friend WithEvents lblLitLetters As Label
End Class
