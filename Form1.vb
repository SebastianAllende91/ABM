Imports System.IO
Imports System.Data.SqlClient

Public Class Form1
    Dim ar As String
    Dim con As New SqlConnection("data source=" & CStr(leerarchivo(ar)) & "; initial catalog=Sistema; integrated security=true")
    Dim tipo As String
    Dim data As Object
    Dim saludo As String


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MenuStrip1.Visible = False
        lSaludo.Visible = False
    End Sub
    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Dim cli As New Clientes
        cli.Show()
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem.Click
        Dim cli As New Proveedores
        cli.Show()
    End Sub

    Private Sub AdministradoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministradoresToolStripMenuItem.Click
        Dim cli As New Administradores
        cli.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            tipo = "Clientes"
            data = Loguear(tipo, tUsuario.Text, tPassword.Text)

            If data Then
                'MenuStrip1.Visible = True
                pLogin.Visible = False
                saludo = "Bienvenid@ " & tUsuario.Text
                lSaludo.Text = saludo
                lSaludo.Visible = True
            Else
                'MenuStrip1.Visible = False
                pLogin.Visible = True
                MessageBox.Show("Usuario o password incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                tPassword.Text = ""
                tUsuario.Text = ""
            End If
        Catch ex As Exception
            Console.Write(ex.Message)
        End Try


    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If MessageBox.Show("¿Seguro desea salir?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Close()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            tipo = "Proveedores"
            data = Loguear(tipo, tUsuario.Text, tPassword.Text)

            If data Then
                'MenuStrip1.Visible = True
                pLogin.Visible = False
                saludo = "Bienvenid@ " & tUsuario.Text
                lSaludo.Text = saludo
                lSaludo.Visible = True
            Else
                'MenuStrip1.Visible = False
                pLogin.Visible = True
                MessageBox.Show("Usuario o password incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                tPassword.Text = ""
                tUsuario.Text = ""
            End If
        Catch ex As Exception
            Console.Write(ex.Message)
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            tipo = "Administradores"
            data = Loguear(tipo, tUsuario.Text, tPassword.Text)

            If data Then
                MenuStrip1.Visible = True
                pLogin.Visible = False
                saludo = "Bienvenid@ " & tUsuario.Text
                lSaludo.Text = saludo
                lSaludo.Visible = True
            Else
                'MenuStrip1.Visible = False
                pLogin.Visible = True
                MessageBox.Show("Usuario o password incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                tPassword.Text = ""
                tUsuario.Text = ""
            End If
        Catch ex As Exception
            Console.Write(ex.Message)
        End Try

    End Sub

End Class
