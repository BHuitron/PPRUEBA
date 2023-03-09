Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class Addendas
    <Key>
    Public Property IdAddenda As Guid

    <StringLength(50)>
    Public Property NombreAddenda As String

    Public Property XML As String

    Public Property FechaModificacion As Date?

    <StringLength(50)>
    Public Property Usuario As String

    Public Property Estado As Boolean?
End Class
