Imports System.IO
Imports System.Data.SqlClient

Public Class Clientes

    Dim ar As String
    Dim con As New SqlConnection("data source=" & CStr(leerarchivo(ar)) & "; initial catalog=Sistema; integrated security=true")

    Function leerarchivo(ByVal archivo As String) As String
        If File.Exists("c:\ABM\ip.txt") = True Then
            Dim SR As StreamReader = File.OpenText("c:\ABM\ip.txt")
            Dim Line As String = SR.ReadLine()
            SR.Close()
            Return Line
        Else
            MsgBox("Verifique Falta Archivo de Configuracion")
            Me.Close()
        End If
    End Function
    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        buscar(" apeynom like '" & tApellido.Text & "%' ")
    End Sub

    Sub buscar(ByVal condicion As String)

        Dim da As New SqlDataAdapter("SELECT TOP (100) PERCENT Id,apeynom from Clientes_Búsqueda where " & condicion & " order by Id", con)
        Dim ds As New DataSet
        da.Fill(ds, "Clientes")
        If ds.Tables("Clientes").Rows.Count = 0 Then

            DataGridView1.Visible = True
            pBotones.Visible = False
            pCampos.Visible = False
            lLegajo.Visible = False

        Else

            DataGridView1.DataSource = ds.Tables("Clientes")
            DataGridView1.Refresh()
            DataGridView1.Visible = True
            pCampos.Visible = True
            pBotones.Visible = True
            lLegajo.Visible = True
        End If

    End Sub
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        FilaClick(e)
    End Sub

    Private Sub DataGridView1_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.RowEnter
        FilaClick(e)
    End Sub
    Sub FilaClick(ByVal e As Object)
        Dim fila As Integer = e.RowIndex
        Dim tfila As String

        If IsNothing(DataGridView1.Rows(fila).Cells(0).Value) Then
            lLegajo.Text = "0"
            pBotones.Visible = False
            pCampos.Visible = False
            Exit Sub
        Else
            tfila = DataGridView1.Rows(fila).Cells(0).Value
            lLegajo.Text = tfila?.ToString()
            CargarCamposClientes()
        End If

    End Sub

    Sub CargarCamposClientes()
        If Val(lLegajo.Text) = 0 Then
            pBotones.Visible = False
            pCampos.Visible = False

            Exit Sub
        Else
            pBotones.Visible = True
            pCampos.Visible = True
            Try
                'Dim da As New SqlDataAdapter("SELECT  upper(ltrim(rtrim(isnull(apellidoprof,'*')))) as apellido, upper(ltrim(rtrim(isnull(nombreprof,'*')))) as nombres,isnull([documento-Prof],0) as doc, ltrim(rtrim(isnull(domicilioprof,''))) as dirección,ltrim(rtrim(isnull(localidadprof,''))) as localidad,ltrim(rtrim(isnull(provinciaprof,''))) as provincia,ltrim(rtrim(isnull(teléfonosProf,''))) as teléfonos,FechanacimientoProf as fechanacimiento,ltrim(rtrim(isnull(comentariosProf,''))) as comentarios,ltrim(rtrim(isnull([E-Mail-Prof],''))) as email, isnull(estado,0) as Estado  from profesores where nprof=" & Val(lLegajo.Text), con)
                Dim da As New SqlDataAdapter("SELECT ApellidoCli as apellido,NombreCli as nombres,[documento-Cli] as doc,DomicilioCli as domicilio,PostalCli as codigoPostal,LocalidadCli as localidad,ProvinciaCli as provincia,TeléfonosCli as teléfonos,ComentariosCli as comentarios,[E-Mail-Cli] as email,Cuit,Usuario,Clave from Clientes where Id=" & Val(lLegajo.Text), con)
                Dim ds As New DataSet
                da.Fill(ds, "Clientes")
                TextBox1.Text = ds.Tables("Clientes").Rows(0)("apellido")
                TextBox2.Text = ds.Tables("Clientes").Rows(0)("nombres")
                TextBox3.Text = ds.Tables("Clientes").Rows(0)("doc")
                TextBox4.Text = ds.Tables("Clientes").Rows(0)("domicilio")
                TextBox5.Text = ds.Tables("Clientes").Rows(0)("codigoPostal")
                TextBox6.Text = ds.Tables("Clientes").Rows(0)("localidad")
                TextBox7.Text = ds.Tables("Clientes").Rows(0)("provincia")
                TextBox8.Text = ds.Tables("Clientes").Rows(0)("teléfonos")
                TextBox9.Text = ds.Tables("Clientes").Rows(0)("comentarios")
                TextBox10.Text = ds.Tables("Clientes").Rows(0)("email")
                TextBox11.Text = ds.Tables("Clientes").Rows(0)("cuit")
                TextBox12.Text = ds.Tables("Clientes").Rows(0)("usuario")
                TextBox13.Text = ds.Tables("Clientes").Rows(0)("clave")
                CheckBox1.Checked = IIf(ds.Tables("Clientes").Rows(0)("estado") = 0, False, True)

                DateTimePicker1.Value = ds.Tables("Clientes").Rows(0)("fechanacimiento")
            Catch ex As Exception
                Console.WriteLine(ex.Message)

            End Try

        End If
    End Sub

    Private Sub bBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bBuscar.Click
        buscar(" apeynom like '" & tApellido.Text & "%' ")
    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        tApellido.Text = ""
        buscar(" apeynom like '" & tApellido.Text & "%' ")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        If MessageBox.Show("Está por ELIMINAR definitivamente al CLIENTE: " & TextBox1.Text.Trim.ToUpper & "?", "Eliminar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub
        Try
            If SQL_Accion("delete from Clientes where Id=" & Val(lLegajo.Text)) = False Then
                MsgBox("Hubo un error al intentar borrar al Cliente, reintente, y si el error persiste, anote todos los datos que quizo ingresar y comuníquese con el programador.")
            Else

                buscar("Id=" & Val(lLegajo.Text))
                MsgBox("El Cliente fue ELIMINADO de la base de datos.")

            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim errores As String = "", en As String = vbCrLf
        If TextBox1.Text.Trim.Length < 3 Then
            errores &= "Debe completar el Apellido del Cliente." & en
        End If
        If TextBox2.Text.Trim.Length < 3 Then
            errores &= "Debe completar el o los nombres del Cliente." & en
        End If
        TextBox3.Text = Val(TextBox3.Text.Trim.Replace(".", "").Replace(" ", "").Replace(",", ""))
        If TextBox3.Text.Trim.Length < 4 Or TextBox3.Text.IndexOf("11111") > -1 Or TextBox3.Text.IndexOf("12345") > -1 Or TextBox3.Text.IndexOf("000000") > -1 Then
            errores &= "Debe completar CORRECTAMENTE el documento del Cliente." & en
        End If
        'If TextBox7.Text.Trim.Length <> 0 And (TextBox7.Text.IndexOf("@") < 0 Or TextBox7.Text.IndexOf(".") < 0) Then
        '    errores &= "Verifique por favor el email del Cliente. No es obligatorio, pero si lo escribe debe ser correcto." & en
        'End If
        If errores.Length > 0 Then
            MsgBox("Hubo errores, por favor verifique y corrija antes de intentar de nuevo:" & en & en & errores)
            Exit Sub
        End If
        ' TextBox12.Text = "update Profesores set apellidos='" & TextBox1.Text.Trim.ToUpper.Replace("'", "´") & "', nombres='" & TextBox2.Text.Trim.ToUpper.Replace("'", "´") & "', sexo='" & Sexo.SelectedItem & "', doc=" & Val(TextBox3.Text.Trim.Replace(".", "").Replace(" ", "").Replace(",", "")) & ", nacionalidad='" & TextBox10.Text.Trim.ToUpper & "', dirección='" & TextBox4.Text.Trim.ToUpper.Replace("'", "´") & "', localidad='" & TextBox5.Text.Trim.ToUpper.Replace("'", "´") & "', teléfparticular='" & TextBox6.Text.Trim.ToUpper.Replace("'", "´") & "', emailalumno='" & TextBox7.Text.Trim.ToUpper.Replace("'", "´") & "', fechanacimiento=" & FechaSQL(DateTimePicker1.Value) & ", ocupación='" & TextBox8.Text.Trim.ToUpper.Replace("'", "´") & "', colegio='" & TextBox9.Text.Trim.ToUpper.Replace("'", "´") & "', turno='" & TextBox11.Text.Trim.ToUpper.Replace("'", "´") & "', comentarios='" & TextBox12.Text.Trim.ToUpper.Replace("'", "´") & "' where legajo=" & VNum(lLegajo.Text)
        If SQL_Accion("update clientes set estado=" & IIf(CheckBox1.Checked, 1, 0) & ", apellidoCli ='" & TextBox1.Text.Trim.ToUpper.Replace("'", "´") & "', nombreCli='" & TextBox2.Text.Trim.ToUpper.Replace("'", "´") & "', [documento-Cli]=" & Val(TextBox3.Text.Trim.Replace(".", "").Replace(" ", "").Replace(",", "")) & ", domicilioCli='" & TextBox4.Text.Trim.ToUpper.Replace("'", "´") & "', PostalCli='" & TextBox5.Text.Trim.ToUpper.Replace("'", "´") & "', localidadCli='" & TextBox6.Text.Trim.ToUpper.Replace("'", "´") & "', provinciaCli='" & TextBox7.Text.Trim.ToUpper.Replace("'", "´") & "', teléfonosCli='" & TextBox8.Text.Trim.ToUpper.Replace("'", "´") & "', [e-mail-Cli]='" & TextBox10.Text.Trim.ToUpper.Replace("'", "´") & "', fechanacimientoCli=" & FechaSQL(DateTimePicker1.Value) & ", comentariosCli='" & TextBox9.Text.Trim.ToUpper.Replace("'", "´") & "', cuit='" & TextBox11.Text.Trim.ToUpper.Replace("'", "´") & "', usuario='" & TextBox12.Text.Trim.ToUpper.Replace("'", "´") & "', clave='" & TextBox13.Text.Trim.ToUpper.Replace("'", "´") & "' where Id=" & VNum(lLegajo.Text)) = True Then
            MsgBox("Cambios realizados correctamente.")

            buscar(" Id=" & VNum(lLegajo.Text))
        Else
            MsgBox("Se produjo un error al querer guardar los datos del Cliente, reintente, y si el error persiste, anote todos los datos que quizo ingresar y comuníquese con el programador.")
        End If
    End Sub

    Private Sub bNuevoCliente_Click(sender As Object, e As EventArgs) Handles bNuevoCliente.Click
        Try
            If SQL_Accion("insert into Clientes (apellidoCli, nombreCli, [documento-Cli],domicilioCli, localidadCli, teléfonosCli, fechanacimientoCli, comentariosCli,[e-mail-Cli],estado,cuit,usuario,clave) values ('*****','*****',    0,   '',   '',     '',  getdate(),  '' ,   '' ,1,'','','') ") Then


                buscar(" apeynom Like '**%' ")
                MsgBox("Se ha creado un nuevo registro para el Cliente que desea ingresar, seleccione la línea nueva, cargue los datos y luego confirme con el botón 'Aceptar Cambios'.")
            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try


    End Sub


End Class