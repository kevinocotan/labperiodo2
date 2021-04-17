Module Module1

    Sub Main()
        Dim persona(0) As C_Persona
        persona(0) = New C_Persona("Kevin", "Ocotan", True, "23233233", "21/08/2000", "Masculino")

        Dim trabajador(1) As C_Trabajador
        trabajador(0) = New C_Trabajador("Melvin", "Morales", "443213", True, "29/09/2002", "Masculino", "434", "500", "50", "450")
        trabajador(1) = New C_Trabajador("Diana", "Recinos", "56445", True, "29/09/2002", "Femenino", "543", "600", "100", "500")

        Dim obrero(1) As C_Obrero
        obrero(0) = New C_Obrero("Pedro", "Lopez", "34423", True, "04/02/2003", "Masculino", "20", "10", "5", "12", "50", "350")
        obrero(1) = New C_Obrero("Maria", "Morales", "4452", False, "04/02/2003", "Femenino", "21", "11", "4", "10", "10", "490")

        For Each per As C_Persona In persona
            per.darDescripcionPersona()
        Next

        For Each tra As C_Trabajador In trabajador
            tra.darDescripcionPersona()
        Next

        For Each obre As C_Obrero In obrero
            obre.darDescripcionPersona()
        Next


    End Sub

End Module
