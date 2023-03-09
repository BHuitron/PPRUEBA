Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class AspNetRoles
    Public Sub New()
        AspNetUsers = New HashSet(Of AspNetUsers)()
    End Sub

    Public Property Id As String

    <Required>
    <StringLength(256)>
    Public Property Name As String

    Public Overridable Property AspNetUsers As ICollection(Of AspNetUsers)
End Class
