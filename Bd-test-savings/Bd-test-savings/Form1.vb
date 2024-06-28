Public Class Form1
    Dim ultimo_indice As Integer = 1
    Private libros As New List(Of Libro)
    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim libroActual As New Libro(ultimo_indice, tbxTitulo.Text, tbxAutor.Text, CInt(tbxAnio.Text))
        ultimo_indice = ultimo_indice + 1
        MessageBox.Show("Titulo del libro: " & libroActual.titulo & " Autor: " & libroActual.autor & " Año de publicacion: " & libroActual.anio_publicacion)
        libros.Add(libroActual)
        dgvLibro.DataSource = Nothing
        dgvLibro.DataSource = libros
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvLibro.DataSource = libros
    End Sub
End Class
