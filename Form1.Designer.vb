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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tUsuario = New System.Windows.Forms.TextBox()
        Me.tPassword = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pLogin = New System.Windows.Forms.Panel()
        Me.lSaludo = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.AdministradoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.pLogin.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.ProveedoresToolStripMenuItem, Me.AdministradoresToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(60, 24)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(174, 26)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(174, 26)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(174, 26)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password:"
        '
        'tUsuario
        '
        Me.tUsuario.Location = New System.Drawing.Point(124, 40)
        Me.tUsuario.Name = "tUsuario"
        Me.tUsuario.Size = New System.Drawing.Size(185, 22)
        Me.tUsuario.TabIndex = 3
        '
        'tPassword
        '
        Me.tPassword.Location = New System.Drawing.Point(124, 108)
        Me.tPassword.Name = "tPassword"
        Me.tPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tPassword.Size = New System.Drawing.Size(185, 22)
        Me.tPassword.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(124, 169)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Entrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'pLogin
        '
        Me.pLogin.Controls.Add(Me.Button3)
        Me.pLogin.Controls.Add(Me.Button2)
        Me.pLogin.Controls.Add(Me.Label2)
        Me.pLogin.Controls.Add(Me.Button1)
        Me.pLogin.Controls.Add(Me.tPassword)
        Me.pLogin.Controls.Add(Me.tUsuario)
        Me.pLogin.Controls.Add(Me.Label1)
        Me.pLogin.Location = New System.Drawing.Point(227, 87)
        Me.pLogin.Name = "pLogin"
        Me.pLogin.Size = New System.Drawing.Size(350, 351)
        Me.pLogin.TabIndex = 6
        '
        'lSaludo
        '
        Me.lSaludo.AutoSize = True
        Me.lSaludo.Font = New System.Drawing.Font("Calibri", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lSaludo.Location = New System.Drawing.Point(244, 49)
        Me.lSaludo.Name = "lSaludo"
        Me.lSaludo.Size = New System.Drawing.Size(0, 35)
        Me.lSaludo.TabIndex = 7
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(124, 269)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(102, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Proveedores"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(124, 311)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(102, 23)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Admistrador"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'AdministradoresToolStripMenuItem
        '
        Me.AdministradoresToolStripMenuItem.Name = "AdministradoresToolStripMenuItem"
        Me.AdministradoresToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.AdministradoresToolStripMenuItem.Text = "Administradores"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lSaludo)
        Me.Controls.Add(Me.pLogin)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Sistema"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.pLogin.ResumeLayout(False)
        Me.pLogin.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tUsuario As TextBox
    Friend WithEvents tPassword As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents pLogin As Panel
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lSaludo As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents AdministradoresToolStripMenuItem As ToolStripMenuItem
End Class
