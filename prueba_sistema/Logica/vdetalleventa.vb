Public Class vdetalleventa
    Dim iddetalleventa, idventa, idproducto, cantidad As Integer
    Dim preciounitario As Decimal

    Public Property giddetalleventa
        Get
            Return iddetalleventa
        End Get
        Set(value)
            iddetalleventa = value
        End Set
    End Property
    Public Property gidventa
        Get
            Return idventa
        End Get
        Set(value)
            idventa = value
        End Set
    End Property
    Public Property gidproducto
        Get
            Return idproducto
        End Get
        Set(value)
            idproducto = value
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
    Public Property gpreciounitario
        Get
            Return preciounitario
        End Get
        Set(value)
            preciounitario = value
        End Set
    End Property
    Public Sub New()

    End Sub
    Public Sub New(ByVal iddetalleventa As Integer, ByVal idventa As Integer, ByVal idproducto As Integer, ByVal cantidad As Integer, ByVal preciounitario As Decimal)
        giddetalleventa = iddetalleventa
        gidventa = idventa
        gidproducto = idproducto
        gcantidad = cantidad
        gpreciounitario = preciounitario
    End Sub
End Class
