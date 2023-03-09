Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class document_type
    Public Property id As Guid

    Public Property type_documents As Short

    <Required>
    Public Property nombre As String

    Public Property codigo_addenda As Short

    Public Property fecha_creacion As Date
End Class
