'Author: Bruce Brown
'Date: 2/17/2021
'Purpose: Manages the philosopher data inputted by the user.

Option Strict On
Option Explicit On


Public Class Philosophers

    'Define Class or Module Level Variables
    Private mstrName As String
    Private mstrQuote As String
    Private mstrDate As String


    Public Property PhilosopherName As String
        Get
            Return mstrName
        End Get
        Set(strvalue As String)
            mstrName = strvalue
        End Set
    End Property

    Public Property Quote As String
        Get
            Return mstrQuote
        End Get
        Set(strvalue As String)
            mstrQuote = strvalue
        End Set
    End Property

    Public Property QuoteDate As String
        Get
            Return mstrDate
        End Get
        Set(strvalue As String)
            mstrDate = strvalue
        End Set
    End Property

    'Default Constructor
    Public Sub New()
        mstrName = String.Empty
        mstrQuote = String.Empty
        mstrDate = String.Empty
    End Sub

    'Overload Constructors
    Public Sub New(ByVal strName As String)
        mstrName = strName
        mstrQuote = String.Empty
        mstrDate = String.Empty
    End Sub

    Public Sub New(ByVal strName As String, ByVal strQuote As String)
        mstrName = strName
        mstrQuote = strQuote
        mstrDate = String.Empty
    End Sub

    Public Sub New(ByVal strName As String, ByVal strQuote As String, ByVal strDate As String)
        mstrName = strName
        mstrQuote = strQuote
        mstrDate = strDate
    End Sub

    'Methods
    Public Function Philosopher_Info() As String
        Return "Philosopher: " & mstrName & "  " & " Famous Quote: " & "'" & mstrQuote & "'" & "  " & "Date: " & mstrDate
    End Function


End Class
