Public Class Libro
    Private _index As Integer
    Private _titulo As String
    Private _autor As String
    Private _anio_publicacion As Integer
    Public Sub New(ByVal index As Integer, ByVal titulo As String, ByVal autor As String, ByVal anio As Integer)
        Me._index = index
        Me._titulo = titulo
        Me._autor = autor
        Me._anio_publicacion = anio
    End Sub
    Public Property titulo As String
        Get
            Return Me._titulo
        End Get
        Set(value As String)
            Me._titulo = value
        End Set
    End Property

    Public Property autor As String
        Get
            Return Me._autor
        End Get
        Set(value As String)
            Me._autor = value
        End Set
    End Property

    Public Property anio_publicacion As Integer
        Get
            Return Me._anio_publicacion
        End Get
        Set(value As Integer)
            Me._anio_publicacion = value
        End Set
    End Property

    Public Property index As Integer
        Get
            Return Me._index
        End Get
        Set(value As Integer)
            Me._index = value
        End Set
    End Property
End Class