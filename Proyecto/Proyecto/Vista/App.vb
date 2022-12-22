﻿Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status

Public Class App
    Private Shared formulario As App

    Dim insertar As Registrar
    Dim modificar As Editar
    Dim ver As VerIndividual
    Dim verDG As Buscar

    'Usamos la función Shared para poder acceder a ella sin necesidad de
    'instanciar un objeto de tipo App
    Public Shared Function GetInstance() As App
        If formulario Is Nothing Then
            formulario = New App()
        End If
        Return formulario
    End Function

    Private Sub App_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lSesion.Text = "Sesion: " + Controlador.getUser()
        MenuLado.Hide()
    End Sub

    Private Sub CargarFormulario(formulario As Form)
        'Borra los controles que pudiera haber en el Panel
        pContenido.Controls.Clear()

        'El formulario que queremos cargar no sera de nivel superior
        formulario.TopLevel = False

        'Añadimos el formulario a los controles del Panel
        pContenido.Controls.Add(formulario)

        formulario.Dock = System.Windows.Forms.DockStyle.Fill
        'Muestra el formulario
        formulario.Show()
    End Sub

    Public Sub QuitarFormulario()
        'Borra los controles que pudiera haber en el Panel
        pContenido.Controls.Clear()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles miSalir.Click
        Controlador.VolverLogin()
        Me.Close()
    End Sub

    Private Sub miShow_Click(sender As Object, e As EventArgs) Handles miShow.Click
        MenuLado.Show()
    End Sub

    Private Sub miHide_Click(sender As Object, e As EventArgs) Handles miHide.Click
        MenuLado.Hide()
    End Sub

    Private Sub miInsertar_Click(sender As Object, e As EventArgs) Handles miInsertar.Click
        'Como GetInstance es de tipo Shared no necesitamos una instancia de objeto para poder usarla
        'Simplemente la usamos con el nombre de la clase a la que pertenece
        insertar = insertar.GetInstance()

        'CargarFormulario carga el formulario en el panel1
        CargarFormulario(insertar)
    End Sub

    Private Sub miModificar_Click(sender As Object, e As EventArgs) Handles miModificar.Click
        'Como GetInstance es de tipo Shared no necesitamos una instancia de objeto para poder usarla
        'Simplemente la usamos con el nombre de la clase a la que pertenece
        modificar = modificar.GetInstance()

        'CargarFormulario carga el formulario en el panel1
        CargarFormulario(modificar)
    End Sub

    Private Sub miTodos_Click(sender As Object, e As EventArgs) Handles miTodos.Click
        'Como GetInstance es de tipo Shared no necesitamos una instancia de objeto para poder usarla
        'Simplemente la usamos con el nombre de la clase a la que pertenece
        ver = ver.GetInstance()

        'CargarFormulario carga el formulario en el panel1
        CargarFormulario(Ver)
    End Sub

    Private Sub miBuscar_Click(sender As Object, e As EventArgs) Handles miBuscar.Click
        'Como GetInstance es de tipo Shared no necesitamos una instancia de objeto para poder usarla
        'Simplemente la usamos con el nombre de la clase a la que pertenece
        verDG = verDG.GetInstance()

        'CargarFormulario carga el formulario en el panel1
        CargarFormulario(verDG)
    End Sub
End Class