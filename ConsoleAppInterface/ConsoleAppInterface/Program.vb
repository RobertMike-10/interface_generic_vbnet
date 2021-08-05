Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
    End Sub


    Public Interface IRepositoryBase(Of T As Class)
        Function FindAll() As ICollection(Of T)
        Function FindById(id As Integer) As T
        Function Create(entity As T) As Boolean
        Function Update(entity As T) As Boolean
        Function Delete(entity As T) As Boolean
        Function Save() As Boolean
    End Interface
End Module
