﻿Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing.Reader

Public Class Form1
    ' Constructor del formulario
    Public Sub New()
        InitializeComponent()
        ' al inicio ocultar el botón de insertar
        BtnInsertar.Visible = False
        BtnActualizar.Visible = False
        BtnEliminar.Visible = False
        BtnConsultar.Visible = False
    End Sub

    Private Sub BtnValidar_Click(sender As Object, e As EventArgs) Handles BtnValidar.Click
        Dim sku As Integer = Integer.Parse(TxtSku.Text)

        If SKUExists(sku) Then
            MessageBox.Show("El SKU ya existe.")
            BtnInsertar.Visible = False
            BtnActualizar.Visible = True
            BtnEliminar.Visible = True
            BtnConsultar.Visible = True
        Else
            MessageBox.Show("El SKU no existe, puede proceder.")
            BtnInsertar.Visible = True
            BtnActualizar.Visible = False
            BtnEliminar.Visible = False
            BtnConsultar.Visible = False
        End If
    End Sub
    Private Function SKUExists(sku As Integer) As Boolean
        Dim connString As String = "Data Source=FAMLOPEZCARDONA\SQLEXPRESS;Initial Catalog=InventarioArticulos;Integrated Security=True"
        Dim query As String = "SELECT COUNT(*) FROM Articulos WHERE SKU = @SKU"

        Using conn As New SqlConnection(connString)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@SKU", sku)
                conn.Open()
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Return count > 0
            End Using
        End Using
    End Function

    Private Sub BtnInsertar_Click(sender As Object, e As EventArgs) Handles BtnInsertar.Click
        Dim sku As Integer = Integer.Parse(TxtSku.Text)
        Dim articulo As String = TxtArticulo.Text
        Dim marca As String = TxtMarca.Text
        Dim modelo As String = TxtModelo.Text
        Dim departamento As Integer = Integer.Parse(CmbDepartamento.SelectedValue.ToString())
        Dim clase As Integer = Integer.Parse(CmbClase.SelectedValue.ToString())
        Dim familia As Integer = Integer.Parse(CmbFamilia.SelectedValue.ToString())
        Dim cantidad As Integer = Integer.Parse(TxtCantidad.Text)
        Dim stock As Integer = Integer.Parse(TxtStock.Text)

        If cantidad > stock Then
            MessageBox.Show("La cantidad no puede ser mayor al stock.")
            Return
        End If

        Dim connString As String = "Data Source=FAMLOPEZCARDONA\SQLEXPRESS;Initial Catalog=InventarioArticulos;Integrated Security=True"
        Dim query As String = "EXEC InsertarArticulo @SKU, @Articulo, @Marca, @Modelo, @Departamento, @Clase, @Familia, @Cantidad, @Stock"

        Using conn As New SqlConnection(connString)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@SKU", sku)
                cmd.Parameters.AddWithValue("@Articulo", articulo)
                cmd.Parameters.AddWithValue("@Marca", marca)
                cmd.Parameters.AddWithValue("@Modelo", modelo)
                cmd.Parameters.AddWithValue("@Departamento", departamento)
                cmd.Parameters.AddWithValue("@Clase", clase)
                cmd.Parameters.AddWithValue("@Familia", familia)
                cmd.Parameters.AddWithValue("@Cantidad", cantidad)
                cmd.Parameters.AddWithValue("@Stock", stock)

                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Dim sku As Integer = Integer.Parse(TxtSku.Text)
        Dim articulo As String = TxtArticulo.Text
        Dim marca As String = TxtMarca.Text
        Dim modelo As String = TxtModelo.Text
        Dim departamento As Integer = Integer.Parse(CmbDepartamento.SelectedValue.ToString())
        Dim clase As Integer = Integer.Parse(CmbClase.SelectedValue.ToString())
        Dim familia As Integer = Integer.Parse(CmbFamilia.SelectedValue.ToString())
        Dim cantidad As Integer = Integer.Parse(TxtCantidad.Text)
        Dim stock As Integer = Integer.Parse(TxtStock.Text)

        If cantidad > stock Then
            MessageBox.Show("La cantidad no puede ser mayor al stock.")
            Return
        End If

        Dim connString As String = "Data Source=FAMLOPEZCARDONA\SQLEXPRESS;Initial Catalog=InventarioArticulos;Integrated Security=True"
        Dim query As String = "EXEC ActualizarArticulo @SKU, @Articulo, @Marca, @Modelo, @Departamento, @Clase, @Familia, @Cantidad, @Stock, @Descontinuado"

        Using conn As New SqlConnection(connString)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@SKU", sku)
                cmd.Parameters.AddWithValue("@Articulo", articulo)
                cmd.Parameters.AddWithValue("@Marca", marca)
                cmd.Parameters.AddWithValue("@Modelo", modelo)
                cmd.Parameters.AddWithValue("@Departamento", departamento)
                cmd.Parameters.AddWithValue("@Clase", clase)
                cmd.Parameters.AddWithValue("@Familia", familia)
                cmd.Parameters.AddWithValue("@Cantidad", cantidad)
                cmd.Parameters.AddWithValue("@Stock", stock)


                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using

        MessageBox.Show("Artículo actualizado exitosamente.")
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim connString As String = "Data Source=FAMLOPEZCARDONA\SQLEXPRESS;Initial Catalog=InventarioArticulos;Integrated Security=True"
        Dim query As String = "EXEC EliminarArticulo @SKU"
        Dim sku As Integer = Integer.Parse(TxtSku.Text)
        Using conn As New SqlConnection(connString)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@SKU", sku)
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using

        MessageBox.Show("Artículo eliminado exitosamente.")
    End Sub

    Private Sub BtnConsultar_Click(sender As Object, e As EventArgs) Handles BtnConsultar.Click
        Dim sku As Integer = Integer.Parse(TxtSku.Text)

        If SKUExists(sku) Then
            MostrarDatosArticulo(sku)
        Else
            MessageBox.Show("El SKU no existe.")
        End If
    End Sub
    Private Sub MostrarDatosArticulo(sku As Integer)
        Dim connString As String = "Data Source=FAMLOPEZCARDONA\SQLEXPRESS;Initial Catalog=InventarioArticulos;Integrated Security=True"
        Dim query As String = "EXEC ConsultarArticulo @SKU"

        Using conn As New SqlConnection(connString)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@SKU", sku)
                conn.Open()
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        TxtArticulo.Text = reader("Articulo").ToString()
                        TxtMarca.Text = reader("Marca").ToString()
                        TxtModelo.Text = reader("Modelo").ToString()
                        CmbDepartamento.Text = reader("NombreDepartamento").ToString()
                        CmbClase.Text = reader("NombreClase").ToString()
                        CmbFamilia.Text = reader("NombreFamilia").ToString()
                        TxtFechaAlta.Text = Convert.ToDateTime(reader("FechaAlta")).ToString("yyyy-MM-dd")
                        TxtStock.Text = reader("Stock").ToString()
                        TxtCantidad.Text = reader("Cantidad").ToString()

                        If Not IsDBNull(reader("FechaBaja")) Then
                            TxtFechaBaja.Text = Convert.ToDateTime(reader("FechaBaja")).ToString("yyyy-MM-dd")
                        Else
                            TxtFechaBaja.Text = ""
                        End If
                    End If
                End Using
            End Using
        End Using
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Llenar los ComboBox al cargar el formulario
        LlenarComboBox(CmbDepartamento, "SELECT IDDepartamento, NombreDepartamento FROM Departamentos", "NombreDepartamento", "IDDepartamento")
        LlenarComboBox(CmbClase, "SELECT IDClase, NombreClase FROM Clases", "NombreClase", "IDClase")
        LlenarComboBox(CmbFamilia, "SELECT IDFamilia, NombreFamilia FROM Familias", "NombreFamilia", "IDFamilia")
    End Sub

    Private Sub LlenarComboBox(combo As ComboBox, query As String, displayMember As String, valueMember As String)
        Dim connString As String = "Data Source=FAMLOPEZCARDONA\SQLEXPRESS;Initial Catalog=InventarioArticulos;Integrated Security=True"

        Using conn As New SqlConnection(connString)
            Using cmd As New SqlCommand(query, conn)
                Dim adapter As New SqlDataAdapter(cmd)
                Dim dt As New DataTable()
                adapter.Fill(dt)

                combo.DataSource = dt
                combo.DisplayMember = displayMember
                combo.ValueMember = valueMember
            End Using
        End Using
    End Sub

End Class
