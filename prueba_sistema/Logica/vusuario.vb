Public Class vusuario
    Dim idusuario, estatus As Integer
    Dim nombres, apellidos, dni, username, password As String

    Public Property gidusuario
        Get
            Return idusuario
        End Get
        Set(value)
            idusuario = value
        End Set
    End Property

    Public Property gestatus
        Get
            Return estatus
        End Get
        Set(value)
            estatus = value
        End Set
    End Property

    Public Property gnombres
        Get
            Return nombres
        End Get
        Set(value)
            nombres = value
        End Set
    End Property

    Public Property gapellidos
        Get
            Return apellidos
        End Get
        Set(value)
            apellidos = value
        End Set
    End Property

    Public Property gdni
        Get
            Return dni
        End Get
        Set(value)
            dni = value
        End Set
    End Property

    Public Property gusername
        Get
            Return username
        End Get
        Set(value)
            username = value
        End Set
    End Property

    Public Property gpassword
        Get
            Return password
        End Get
        Set(value)
            password = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal idusuario As Integer, ByVal estatus As Integer, ByVal nombres As String, ByVal apellidos As String, ByVal dni As String, ByVal username As String, ByVal password As String)
        gidusuario = idusuario
        gestatus = estatus
        gnombres = nombres
        gapellidos = apellidos
        gdni = dni
        gusername = username
        gpassword = password
    End Sub
End Class
