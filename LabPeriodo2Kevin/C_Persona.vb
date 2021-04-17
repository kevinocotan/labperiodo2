Public Class C_Persona
    Private nombre, apellido, dui, estado, sexo As String
    Private fecha_inicio As String
    Private Contratado As Boolean

    Public Sub New(nom As String, ape As String, du As String, est As String, fech As String, sex As String)
        nombre = nom
        apellido = ape
        dui = du
        estado = est
        fecha_inicio = fech
        sexo = sex
        Contratado = est

    End Sub

    Public Property P_Nombre As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Public Property P_Apellido As String
        Get
            Return apellido
        End Get
        Set(value As String)
            apellido = value
        End Set
    End Property

    Public Property P_Dui As String
        Get
            Return dui
        End Get
        Set(value As String)
            dui = value
        End Set
    End Property

    Public Property P_Estado As String
        Get
            Return estado
        End Get
        Set(value As String)
            estado = value
        End Set
    End Property

    Public Property P_FechaInicio As String
        Get
            Return fecha_inicio
        End Get
        Set(value As String)
            fecha_inicio = value
        End Set
    End Property

    Public Property P_Sexo As String
        Get
            Return sexo
        End Get
        Set(value As String)
            sexo = value
        End Set
    End Property

    Public Property P_Contratado As String
        Get
            Return Contratado
        End Get
        Set(value As String)
            Contratado = value
        End Set
    End Property

    Public Overridable Sub darDescripcionPersona()
        Console.WriteLine("--------------------------------------------------------------------")
        Console.WriteLine("")
        Console.WriteLine("Datos de la Persona: ")
        Console.WriteLine("Nombre: " & P_Nombre)
        Console.WriteLine("Apellido: " & P_Apellido)
        Console.WriteLine("DUI: " & P_Dui)
        Console.WriteLine("Contratado: " & P_Contratado)
        Console.WriteLine("Fecha de Inicio: " & P_FechaInicio)
        Console.WriteLine("Genero: " & P_Sexo)
    End Sub


End Class
