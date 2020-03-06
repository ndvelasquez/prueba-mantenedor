Public Class vventa
    Dim idventa, idcliente As Integer
    Dim fechaventa As Date
    Dim tipocomprobante, numcomprobante, criteriobusqueda, textoabuscar, mensaje As String

    Public Property gmensaje
        Get
            Return mensaje
        End Get
        Set(value)
            mensaje = value
        End Set
    End Property
    Public Property gcriteriobusqueda
        Get
            Return criteriobusqueda
        End Get
        Set(value)
            criteriobusqueda = value
        End Set
    End Property
    Public Property gtextoabuscar
        Get
            Return textoabuscar
        End Get
        Set(value)
            textoabuscar = value
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
    Public Property gidcliente
        Get
            Return idcliente
        End Get
        Set(value)
            idcliente = value
        End Set
    End Property
    Public Property gfechaventa
        Get
            Return fechaventa
        End Get
        Set(value)
            fechaventa = value
        End Set
    End Property
    Public Property gtipocombrobante
        Get
            Return tipocomprobante
        End Get
        Set(value)
            tipocomprobante = value
        End Set
    End Property
    Public Property gnumcomprobante
        Get
            Return numcomprobante
        End Get
        Set(value)
            numcomprobante = value
        End Set
    End Property

    Public Sub New()

    End Sub
    Public Sub New(ByVal idventa As Integer, ByVal idcliente As Integer, ByVal fechaventa As Date, ByVal tipocomprobante As String, ByVal numcomprobante As String, ByVal criteriobusqueda As String, ByVal textoabuscar As String, ByVal mensaje As String)
        gmensaje = mensaje
        gidventa = idventa
        gidcliente = idcliente
        gfechaventa = fechaventa
        gtipocombrobante = tipocomprobante
        gnumcomprobante = numcomprobante
        gcriteriobusqueda = criteriobusqueda
        gtextoabuscar = textoabuscar
    End Sub
End Class
