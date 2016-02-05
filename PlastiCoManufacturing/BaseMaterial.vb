Public Class BaseMaterial
    Public name As String

    Public Sub New(name As String)
        Me.name = name
    End Sub

    Public Shared Function getDisplayList(materials As List(Of BaseMaterial),
                                          Optional sorted As Boolean = True) As List(Of String)
        Dim returnMaterials As New List(Of String)

        For Each material As BaseMaterial In materials
            returnMaterials.Add(material.name)
        Next

        If sorted Then
            returnMaterials.Sort()
        End If

        Return returnMaterials
    End Function
End Class
