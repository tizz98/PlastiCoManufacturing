Public Class SubAssembly
    Public name As String
    Public baseMaterials As List(Of BaseMaterial)

    Public Sub New(name As String)
        Me.name = name
        Me.baseMaterials = New List(Of BaseMaterial)
    End Sub

    Public Sub New(name As String, baseMaterials As List(Of BaseMaterial))
        Me.name = name
        Me.baseMaterials = baseMaterials
    End Sub

    Public Shared Function getDisplayList(subAssemblies As List(Of SubAssembly),
                                          Optional sorted As Boolean = True) As List(Of String)
        Dim returnSubAsm As New List(Of String)

        For Each subAsm As SubAssembly In subAssemblies
            returnSubAsm.Add(subAsm.name)
        Next

        If sorted Then
            returnSubAsm.Sort()
        End If

        Return returnSubAsm
    End Function
End Class
