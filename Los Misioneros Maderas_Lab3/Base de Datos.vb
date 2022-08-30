Public Class Base_de_Datos

    Public Shared Function Cadena_Conexión() As String
        Dim CADENA As String = "provider=microsoft.jet.oledb.4.0;data source=MaderasBD.mdb"
        Return CADENA
    End Function

End Class
