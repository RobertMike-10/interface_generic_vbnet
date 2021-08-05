Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
    End Sub

    Public Interface IEjemplo
        Function GetNumber(number As Integer)
    End Interface

    Public Class Ejemplo
        Implements IEjemplo

        Public Function GetNumber(x As Integer) As Object Implements IEjemplo.GetNumber
            Throw New NotImplementedException()
        End Function
    End Class
End Module
