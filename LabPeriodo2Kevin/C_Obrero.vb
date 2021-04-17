Public Class C_Obrero
    Inherits C_Trabajador

    Private CostoHora As Double
    Private CostoHoraExtra As Double
    Private HorasExtra As Integer
    Private Horas As Integer
    Private contratado As Boolean

    Public Sub New(nom As String, ape As String, du As String, est As Boolean, fech As String, sex As String, v As String, ch As Double, che As Double, he As Double, ho As Integer, des As String)
        MyBase.New(nom, ape, du, est, fech, sex, ch, che, he, ho)
        CostoHora = ch
        CostoHoraExtra = che
        HorasExtra = he
        Horas = ho
        contratado = est

    End Sub

    Public Property P_CostoHora As String
        Get
            Return CostoHora
        End Get
        Set(value As String)
            CostoHora = value
        End Set
    End Property

    Public Property P_CostoHoraExtra As String
        Get
            Return CostoHoraExtra
        End Get
        Set(value As String)
            CostoHoraExtra = value
        End Set
    End Property

    Public Property P_HorasExtra As String
        Get
            Return HorasExtra
        End Get
        Set(value As String)
            HorasExtra = value
        End Set
    End Property

    Public Property P_Horas As String
        Get
            Return Horas
        End Get
        Set(value As String)
            Horas = value
        End Set
    End Property

    Public Overrides Sub darDescripcionPersona()
        Console.WriteLine("--------------------------------------------------------------------")
        Console.WriteLine("")
        Console.WriteLine("Datos del Obrero: ")
        Console.WriteLine("Nombre: " & P_Nombre)
        Console.WriteLine("Apellido: " & P_Apellido)
        Console.WriteLine("Dui: " & P_Dui)
        Console.WriteLine("Contratado: " & P_Contratado)
        Console.WriteLine("Costo Hora: " & P_CostoHora)
        Console.WriteLine("Costo Hora Extra: " & P_CostoHoraExtra)
        Console.WriteLine("Horas Extra: " & P_HorasExtra)
        Console.WriteLine("Horas: " & P_Horas)
        Console.WriteLine("Salario: " & P_Salario)
        Console.WriteLine("Descuento: " & P_descuento)
        Console.WriteLine("Fecha de Inicio: " & P_FechaInicio)
        Console.WriteLine("Genero: " & P_Sexo)
    End Sub




End Class
