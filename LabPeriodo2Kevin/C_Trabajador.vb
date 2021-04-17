Public Class C_Trabajador
    Inherits C_Persona

    Private AFP As Integer
    Private Salario As String
    Private descuento As String

    Public Sub New(nom As String, ape As String, du As String, est As Boolean, fech As String, sex As String, ch As Double, af As Integer, sal As String, descu As Double)
        MyBase.New(nom, ape, du, est, fech, sex)
        AFP = af
        Salario = sal
        descuento = descu

    End Sub

    Public Property P_AFP As String
        Get
            Return AFP
        End Get
        Set(value As String)
            AFP = value
        End Set
    End Property

    Public Property P_Salario As String
        Get
            Return Salario
        End Get
        Set(value As String)
            Salario = value
        End Set
    End Property

    Public Property P_descuento As String
        Get
            Return descuento
        End Get
        Set(value As String)
            descuento = value
        End Set
    End Property


    Public Overrides Sub darDescripcionPersona()
        Console.WriteLine("--------------------------------------------------------------------")
        Console.WriteLine("")
        Console.WriteLine("Datos del Trabajador: ")
        Console.WriteLine("Nombre: " & P_Nombre)
        Console.WriteLine("Apellido: " & P_Apellido)
        Console.WriteLine("DUI: " & P_Dui)
        Console.WriteLine("AFP: " & P_AFP)
        Console.WriteLine("Salario: " & P_Salario)
        Console.WriteLine("Descuento: " & P_descuento)
        Console.WriteLine("Contratado: " & P_Contratado)
        Console.WriteLine("Fecha de Inicio: " & P_FechaInicio)
        Console.WriteLine("Genero: " & P_Sexo)

    End Sub



End Class
