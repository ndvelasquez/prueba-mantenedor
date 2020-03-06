Public Class vproducto
    Dim idproducto, idcategoria, cantidad As Integer
    Dim nombreProducto, numDocumento As String
    Dim precio As Double

    Public Property gidproducto
        Get
            Return idproducto
        End Get
        Set(value)
            idproducto = value
        End Set
    End Property
    Public Property gidcategoria
        Get
            Return idcategoria
        End Get
        Set(value)
            idcategoria = value
        End Set
    End Property
    Public Property gnombreproducto
        Get
            Return nombreProducto
        End Get
        Set(value)
            nombreProducto = value
        End Set
    End Property
    Public Property gnumDocumento
        Get
            Return numDocumento
        End Get
        Set(value)
            numDocumento = value
        End Set
    End Property
    Public Property gcantidad
        Get
            Return cantidad
        End Get
        Set(value)
            cantidad = value
        End Set
    End Property
    Public Property gprecio
        Get
            Return precio
        End Get
        Set(value)
            precio = value
        End Set
    End Property

    Public Sub New()

    End Sub
    Public Sub New(ByVal idproducto As Integer, ByVal idcategoria As Integer, ByVal nombreProducto As String, ByVal numDocumento As String, ByVal cantidad As Integer, ByVal precio As Double)
        gidproducto = idproducto
        gidcategoria = idcategoria
        gnombreproducto = nombreProducto
        gnumDocumento = numDocumento
        gcantidad = cantidad
        gprecio = precio
    End Sub
End Class
