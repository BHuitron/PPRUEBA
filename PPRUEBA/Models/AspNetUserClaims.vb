Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class AspNetUserClaims
    Public Property Id As Integer

    <Required>
    <StringLength(128)>
    Public Property UserId As String

    Public Property ClaimType As String

    Public Property ClaimValue As String

    Public Overridable Property AspNetUsers As AspNetUsers
End Class
