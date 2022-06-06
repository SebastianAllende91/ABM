<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
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
        Me.tApellido = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pCampos = New System.Windows.Forms.Panel()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pBotones = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.bNuevoCliente = New System.Windows.Forms.Button()
        Me.bBuscar = New System.Windows.Forms.Button()
        Me.lLegajo = New System.Windows.Forms.Label()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pCampos.SuspendLayout()
        Me.pBotones.SuspendLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Apellido o parte (vacío = todos):"
        '
        'tApellido
        '
        Me.tApellido.Location = New System.Drawing.Point(287, 18)
        Me.tApellido.Name = "tApellido"
        Me.tApellido.Size = New System.Drawing.Size(220, 22)
        Me.tApellido.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2})
        Me.DataGridView1.Location = New System.Drawing.Point(25, 56)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(368, 569)
        Me.DataGridView1.TabIndex = 3
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "Id"
        Me.Column2.HeaderText = "N°"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 40
        '
        'pCampos
        '
        Me.pCampos.Controls.Add(Me.CheckBox1)
        Me.pCampos.Controls.Add(Me.TextBox13)
        Me.pCampos.Controls.Add(Me.TextBox12)
        Me.pCampos.Controls.Add(Me.TextBox11)
        Me.pCampos.Controls.Add(Me.TextBox10)
        Me.pCampos.Controls.Add(Me.TextBox9)
        Me.pCampos.Controls.Add(Me.DateTimePicker1)
        Me.pCampos.Controls.Add(Me.TextBox8)
        Me.pCampos.Controls.Add(Me.TextBox7)
        Me.pCampos.Controls.Add(Me.TextBox6)
        Me.pCampos.Controls.Add(Me.TextBox5)
        Me.pCampos.Controls.Add(Me.TextBox4)
        Me.pCampos.Controls.Add(Me.TextBox3)
        Me.pCampos.Controls.Add(Me.TextBox2)
        Me.pCampos.Controls.Add(Me.TextBox1)
        Me.pCampos.Controls.Add(Me.Label15)
        Me.pCampos.Controls.Add(Me.Label14)
        Me.pCampos.Controls.Add(Me.Label13)
        Me.pCampos.Controls.Add(Me.Label12)
        Me.pCampos.Controls.Add(Me.Label11)
        Me.pCampos.Controls.Add(Me.Label10)
        Me.pCampos.Controls.Add(Me.Label9)
        Me.pCampos.Controls.Add(Me.Label8)
        Me.pCampos.Controls.Add(Me.Label7)
        Me.pCampos.Controls.Add(Me.Label6)
        Me.pCampos.Controls.Add(Me.Label5)
        Me.pCampos.Controls.Add(Me.Label4)
        Me.pCampos.Controls.Add(Me.Label3)
        Me.pCampos.Controls.Add(Me.Label2)
        Me.pCampos.Location = New System.Drawing.Point(419, 56)
        Me.pCampos.Name = "pCampos"
        Me.pCampos.Size = New System.Drawing.Size(369, 466)
        Me.pCampos.TabIndex = 4
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(269, 62)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(76, 21)
        Me.CheckBox1.TabIndex = 29
        Me.CheckBox1.Text = "Activo?"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'TextBox13
        '
        Me.TextBox13.Location = New System.Drawing.Point(92, 422)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(254, 22)
        Me.TextBox13.TabIndex = 28
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(92, 383)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(254, 22)
        Me.TextBox12.TabIndex = 27
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(92, 347)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(254, 22)
        Me.TextBox11.TabIndex = 26
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(92, 310)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(254, 22)
        Me.TextBox10.TabIndex = 25
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(92, 263)
        Me.TextBox9.Multiline = True
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(254, 41)
        Me.TextBox9.TabIndex = 24
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(114, 235)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(131, 22)
        Me.DateTimePicker1.TabIndex = 23
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(92, 207)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(254, 22)
        Me.TextBox8.TabIndex = 22
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(92, 180)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(254, 22)
        Me.TextBox7.TabIndex = 21
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(92, 150)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(254, 22)
        Me.TextBox6.TabIndex = 20
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(92, 118)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(254, 22)
        Me.TextBox5.TabIndex = 19
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(92, 90)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(254, 22)
        Me.TextBox4.TabIndex = 18
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(119, 60)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(126, 22)
        Me.TextBox3.TabIndex = 16
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(92, 33)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(254, 22)
        Me.TextBox2.TabIndex = 15
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(92, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(254, 22)
        Me.TextBox1.TabIndex = 14
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 427)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(47, 17)
        Me.Label15.TabIndex = 13
        Me.Label15.Text = "Clave:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 388)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(61, 17)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "Usuario:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(4, 352)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(63, 17)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Cuil/Cuit:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(4, 315)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 17)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Email:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(3, 269)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 17)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Comentarios:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(4, 242)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 17)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Fecha de Nac.:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(4, 213)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 17)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Telefono:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(4, 185)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 17)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Provincia:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(4, 156)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 17)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Localidad:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 125)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 17)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Cod. Postal:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 17)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Domicilio:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Doc.(solo num):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nombre/s:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Apellido/s:"
        '
        'pBotones
        '
        Me.pBotones.Controls.Add(Me.Button3)
        Me.pBotones.Controls.Add(Me.Button2)
        Me.pBotones.Location = New System.Drawing.Point(533, 528)
        Me.pBotones.Name = "pBotones"
        Me.pBotones.Size = New System.Drawing.Size(255, 97)
        Me.pBotones.TabIndex = 5
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(136, 20)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(115, 60)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Eliminar Cliente"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(3, 20)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(123, 60)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Aceptar Cambios"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'bNuevoCliente
        '
        Me.bNuevoCliente.Location = New System.Drawing.Point(414, 548)
        Me.bNuevoCliente.Name = "bNuevoCliente"
        Me.bNuevoCliente.Size = New System.Drawing.Size(113, 60)
        Me.bNuevoCliente.TabIndex = 0
        Me.bNuevoCliente.Text = "Nuevo Cliente"
        Me.bNuevoCliente.UseVisualStyleBackColor = True
        '
        'bBuscar
        '
        Me.bBuscar.Location = New System.Drawing.Point(533, 18)
        Me.bBuscar.Name = "bBuscar"
        Me.bBuscar.Size = New System.Drawing.Size(75, 23)
        Me.bBuscar.TabIndex = 6
        Me.bBuscar.Text = "Buscar"
        Me.bBuscar.UseVisualStyleBackColor = True
        '
        'lLegajo
        '
        Me.lLegajo.AutoSize = True
        Me.lLegajo.Location = New System.Drawing.Point(772, 36)
        Me.lLegajo.Name = "lLegajo"
        Me.lLegajo.Size = New System.Drawing.Size(16, 17)
        Me.lLegajo.TabIndex = 7
        Me.lLegajo.Text = "0"
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = Global.Proyecto_Final.My.Resources.Resources.boton_x
        Me.PictureBox8.Location = New System.Drawing.Point(237, 16)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox8.TabIndex = 2
        Me.PictureBox8.TabStop = False
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 638)
        Me.Controls.Add(Me.lLegajo)
        Me.Controls.Add(Me.bBuscar)
        Me.Controls.Add(Me.bNuevoCliente)
        Me.Controls.Add(Me.pBotones)
        Me.Controls.Add(Me.pCampos)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.tApellido)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Clientes"
        Me.Text = "Clientes"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pCampos.ResumeLayout(False)
        Me.pCampos.PerformLayout()
        Me.pBotones.ResumeLayout(False)
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tApellido As TextBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents pCampos As Panel
    Friend WithEvents pBotones As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents bNuevoCliente As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents bBuscar As Button
    Friend WithEvents lLegajo As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
End Class
