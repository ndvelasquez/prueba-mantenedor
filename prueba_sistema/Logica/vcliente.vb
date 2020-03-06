Public Class vcliente
    Dim idcliente As Integer
    Dim dni, nombres, apellidos, telefono, direccion As String

    'Setter y getter

    Public Property gidcliente
        Get
            Return idcliente
        End Get
        Set(ByVal value)
            idcliente = value
        End Set
    End Property
    Public Property gdni
        Get
            Return dni
        End Get
        Set(ByVal value)
            dni = value
        End Set
    End Property
    Public Property gnombres
        Get
            Return nombres
        End Get
        Set(ByVal value)
            nombres = value
        End Set
    End Property
    Public Property gapellidos
        Get
            Return apellidos
        End Get
        Set(ByVal value)
            apellidos = value
        End Set
    End Property
    Public Property gtelefono
        Get
            Return telefono
        End Get
        Set(ByVal value)
            telefono = value
        End Set
    End Property
    Public Property gdireccion
        Get
            Return direccion
        End Get
        Set(ByVal value)
            direccion = value
        End Set
    End Property
    Public Sub New()

    End Sub

    Public Sub New(ByVal idcliente As Integer, ByVal dni As String, ByVal nombres As String, ByVal apellidos As String, ByVal telefono As String, ByVal direccion As String)
        gidcliente = idcliente
        gdni = dni
        gnombres = nombres
        gapellidos = apellidos
        gtelefono = telefono
        gdireccion = direccion
    End Sub
End Class
