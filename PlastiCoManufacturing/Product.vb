Public Class Product
    Public name As String
    Public subAssemblies As List(Of SubAssembly)

    Public Sub New(name As String)
        Me.name = name
        Me.subAssemblies = New List(Of SubAssembly)
    End Sub

    Public Sub New(name As String, subAssemblies As List(Of SubAssembly))
        Me.name = name
        Me.subAssemblies = subAssemblies
    End Sub

    Public Shared Function getDisplayList(products As List(Of Product), Optional sorted As Boolean = True) As List(Of String)
        Dim returnValues As New List(Of String)

        For Each product As Product In products
            returnValues.Add(product.name)
        Next

        If sorted Then
            returnValues.Sort()
        End If

        Return returnValues
    End Function
End Class
