'Author: Bruce Brown
'Date: 2/17/2021
'Purpose: Manages the dog data inputted by the user.

Option Strict On
Option Explicit On


Public Class Dogs

    'Define Class or Module Level Variables
    Private mstrBreed As String
    Private mstrColor As String
    Private mstrWeight As String


    Public Property Breed As String
        Get
            Return mstrBreed
        End Get
        Set(strvalue As String)
            mstrBreed = strvalue
        End Set
    End Property

    Public Property Color As String
        Get
            Return mstrColor
        End Get
        Set(strvalue As String)
            mstrColor = strvalue
        End Set
    End Property

    Public Property Weight As String
        Get
            Return mstrWeight
        End Get
        Set(strvalue As String)
            mstrWeight = strvalue
        End Set
    End Property

    'Default Constructor
    Public Sub New()
        mstrBreed = String.Empty
        mstrColor = String.Empty
        mstrWeight = String.Empty
    End Sub

    'Overload Constructors
    Public Sub New(ByVal strBreed As String)
        mstrBreed = strBreed
        mstrColor = String.Empty
        mstrWeight = String.Empty
    End Sub

    Public Sub New(ByVal strBreed As String, ByVal strColor As String)
        mstrBreed = strBreed
        mstrColor = strColor
        mstrWeight = String.Empty
    End Sub

    Public Sub New(ByVal strBreed As String, ByVal strColor As String, ByVal strWeight As String)
        mstrBreed = strBreed
        mstrColor = strColor
        mstrWeight = strWeight
    End Sub

    'Methods
    Public Function Dog_Info() As String
        Return "Breed: " & mstrBreed & "  " & "Color: " & mstrColor & "  " & "Weight: " & mstrWeight & " pounds"
    End Function


End Class
