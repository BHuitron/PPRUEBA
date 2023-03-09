Imports System
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity
Imports System.Linq

Partial Public Class Model1
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=Biblioteca")
    End Sub

    Public Overridable Property C__MigrationHistory As DbSet(Of C__MigrationHistory)
    Public Overridable Property Addendas As DbSet(Of Addendas)
    Public Overridable Property AspNetRoles As DbSet(Of AspNetRoles)
    Public Overridable Property AspNetUserClaims As DbSet(Of AspNetUserClaims)
    Public Overridable Property AspNetUserLogins As DbSet(Of AspNetUserLogins)
    Public Overridable Property AspNetUsers As DbSet(Of AspNetUsers)
    Public Overridable Property document_type As DbSet(Of document_type)

    Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
        modelBuilder.Entity(Of Addendas)() _
            .Property(Function(e) e.Usuario) _
            .IsUnicode(False)

        modelBuilder.Entity(Of AspNetRoles)() _
            .HasMany(Function(e) e.AspNetUsers) _
            .WithMany(Function(e) e.AspNetRoles) _
            .Map(Function(m) m.ToTable("AspNetUserRoles").MapLeftKey("RoleId").MapRightKey("UserId"))

        modelBuilder.Entity(Of AspNetUsers)() _
            .HasMany(Function(e) e.AspNetUserClaims) _
            .WithRequired(Function(e) e.AspNetUsers) _
            .HasForeignKey(Function(e) e.UserId)

        modelBuilder.Entity(Of AspNetUsers)() _
            .HasMany(Function(e) e.AspNetUserLogins) _
            .WithRequired(Function(e) e.AspNetUsers) _
            .HasForeignKey(Function(e) e.UserId)
    End Sub
End Class
