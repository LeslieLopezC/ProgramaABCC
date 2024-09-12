<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtSku = New System.Windows.Forms.TextBox()
        Me.TxtArticulo = New System.Windows.Forms.TextBox()
        Me.TxtMarca = New System.Windows.Forms.TextBox()
        Me.TxtModelo = New System.Windows.Forms.TextBox()
        Me.CmbDepartamento = New System.Windows.Forms.ComboBox()
        Me.CmbClase = New System.Windows.Forms.ComboBox()
        Me.CmbFamilia = New System.Windows.Forms.ComboBox()
        Me.TxtStock = New System.Windows.Forms.TextBox()
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
        Me.TxtFechaAlta = New System.Windows.Forms.TextBox()
        Me.TxtFechaBaja = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.BtnValidar = New System.Windows.Forms.Button()
        Me.BtnInsertar = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnConsultar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sku:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Articulo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Marca:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 187)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Modelo:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 284)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Clase:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 236)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Depto:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 328)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 18)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Familia:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 380)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 18)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Stock:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(246, 380)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 18)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Cantidad:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 429)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 18)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Fecha alta:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(246, 429)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 18)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Fecha Baja:"
        '
        'TxtSku
        '
        Me.TxtSku.Location = New System.Drawing.Point(56, 45)
        Me.TxtSku.Name = "TxtSku"
        Me.TxtSku.Size = New System.Drawing.Size(120, 20)
        Me.TxtSku.TabIndex = 11
        '
        'TxtArticulo
        '
        Me.TxtArticulo.Location = New System.Drawing.Point(70, 94)
        Me.TxtArticulo.Name = "TxtArticulo"
        Me.TxtArticulo.Size = New System.Drawing.Size(358, 20)
        Me.TxtArticulo.TabIndex = 12
        '
        'TxtMarca
        '
        Me.TxtMarca.Location = New System.Drawing.Point(72, 142)
        Me.TxtMarca.Name = "TxtMarca"
        Me.TxtMarca.Size = New System.Drawing.Size(356, 20)
        Me.TxtMarca.TabIndex = 13
        '
        'TxtModelo
        '
        Me.TxtModelo.Location = New System.Drawing.Point(72, 185)
        Me.TxtModelo.Name = "TxtModelo"
        Me.TxtModelo.Size = New System.Drawing.Size(356, 20)
        Me.TxtModelo.TabIndex = 14
        '
        'CmbDepartamento
        '
        Me.CmbDepartamento.FormattingEnabled = True
        Me.CmbDepartamento.Location = New System.Drawing.Point(73, 237)
        Me.CmbDepartamento.Name = "CmbDepartamento"
        Me.CmbDepartamento.Size = New System.Drawing.Size(355, 21)
        Me.CmbDepartamento.TabIndex = 15
        '
        'CmbClase
        '
        Me.CmbClase.FormattingEnabled = True
        Me.CmbClase.Location = New System.Drawing.Point(73, 284)
        Me.CmbClase.Name = "CmbClase"
        Me.CmbClase.Size = New System.Drawing.Size(355, 21)
        Me.CmbClase.TabIndex = 16
        '
        'CmbFamilia
        '
        Me.CmbFamilia.FormattingEnabled = True
        Me.CmbFamilia.Location = New System.Drawing.Point(73, 325)
        Me.CmbFamilia.Name = "CmbFamilia"
        Me.CmbFamilia.Size = New System.Drawing.Size(355, 21)
        Me.CmbFamilia.TabIndex = 17
        '
        'TxtStock
        '
        Me.TxtStock.Location = New System.Drawing.Point(69, 380)
        Me.TxtStock.Name = "TxtStock"
        Me.TxtStock.Size = New System.Drawing.Size(87, 20)
        Me.TxtStock.TabIndex = 18
        '
        'TxtCantidad
        '
        Me.TxtCantidad.Location = New System.Drawing.Point(313, 380)
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.Size = New System.Drawing.Size(115, 20)
        Me.TxtCantidad.TabIndex = 19
        '
        'TxtFechaAlta
        '
        Me.TxtFechaAlta.Location = New System.Drawing.Point(94, 430)
        Me.TxtFechaAlta.Name = "TxtFechaAlta"
        Me.TxtFechaAlta.Size = New System.Drawing.Size(100, 20)
        Me.TxtFechaAlta.TabIndex = 20
        '
        'TxtFechaBaja
        '
        Me.TxtFechaBaja.Location = New System.Drawing.Point(328, 430)
        Me.TxtFechaBaja.Name = "TxtFechaBaja"
        Me.TxtFechaBaja.Size = New System.Drawing.Size(100, 20)
        Me.TxtFechaBaja.TabIndex = 21
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(299, 43)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(33, 20)
        Me.TextBox9.TabIndex = 22
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(338, 45)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(108, 18)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Descontinuado"
        '
        'BtnValidar
        '
        Me.BtnValidar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnValidar.Location = New System.Drawing.Point(12, 491)
        Me.BtnValidar.Name = "BtnValidar"
        Me.BtnValidar.Size = New System.Drawing.Size(77, 23)
        Me.BtnValidar.TabIndex = 24
        Me.BtnValidar.Text = "Validar"
        Me.BtnValidar.UseVisualStyleBackColor = True
        '
        'BtnInsertar
        '
        Me.BtnInsertar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInsertar.Location = New System.Drawing.Point(101, 491)
        Me.BtnInsertar.Name = "BtnInsertar"
        Me.BtnInsertar.Size = New System.Drawing.Size(75, 23)
        Me.BtnInsertar.TabIndex = 25
        Me.BtnInsertar.Text = "Insertar"
        Me.BtnInsertar.UseVisualStyleBackColor = True
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizar.Location = New System.Drawing.Point(197, 491)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.BtnActualizar.TabIndex = 26
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.Location = New System.Drawing.Point(299, 491)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminar.TabIndex = 27
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnConsultar
        '
        Me.BtnConsultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConsultar.Location = New System.Drawing.Point(404, 491)
        Me.BtnConsultar.Name = "BtnConsultar"
        Me.BtnConsultar.Size = New System.Drawing.Size(75, 23)
        Me.BtnConsultar.TabIndex = 28
        Me.BtnConsultar.Text = "Consultar"
        Me.BtnConsultar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(491, 530)
        Me.Controls.Add(Me.BtnConsultar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.BtnInsertar)
        Me.Controls.Add(Me.BtnValidar)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.TxtFechaBaja)
        Me.Controls.Add(Me.TxtFechaAlta)
        Me.Controls.Add(Me.TxtCantidad)
        Me.Controls.Add(Me.TxtStock)
        Me.Controls.Add(Me.CmbFamilia)
        Me.Controls.Add(Me.CmbClase)
        Me.Controls.Add(Me.CmbDepartamento)
        Me.Controls.Add(Me.TxtModelo)
        Me.Controls.Add(Me.TxtMarca)
        Me.Controls.Add(Me.TxtArticulo)
        Me.Controls.Add(Me.TxtSku)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtSku As TextBox
    Friend WithEvents TxtArticulo As TextBox
    Friend WithEvents TxtMarca As TextBox
    Friend WithEvents TxtModelo As TextBox
    Friend WithEvents CmbDepartamento As ComboBox
    Friend WithEvents CmbClase As ComboBox
    Friend WithEvents CmbFamilia As ComboBox
    Friend WithEvents TxtStock As TextBox
    Friend WithEvents TxtCantidad As TextBox
    Friend WithEvents TxtFechaAlta As TextBox
    Friend WithEvents TxtFechaBaja As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents BtnValidar As Button
    Friend WithEvents BtnInsertar As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnConsultar As Button
End Class
