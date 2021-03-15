'Author: Bruce Brown
'Date: 2/17/2021
'Purpose: Manages the car data inputted by the user.

Option Strict On
Option Explicit On


Public Class Cars

    'Define Class or Module Level Variables
    Private mstrMake As String
    Private mstrModel As String
    Private mstrType As String


    Public Property CarMake As String
        Get
            Return mstrMake
        End Get
        Set(strvalue As String)
            mstrMake = strvalue
        End Set
    End Property

    Public Property CarModel As String
        Get
            Return mstrModel
        End Get
        Set(strvalue As String)
            mstrModel = strvalue
        End Set
    End Property

    Public Property Type As String
        Get
            Return mstrType
        End Get
        Set(strvalue As String)
            mstrType = strvalue
        End Set
    End Property

    'Default Constructor
    Public Sub New()
        mstrMake = String.Empty
        mstrModel = String.Empty
        mstrType = String.Empty
    End Sub

    'Overload Constructors
    Public Sub New(ByVal strMake As String)
        mstrMake = strMake
        mstrModel = String.Empty
        mstrType = String.Empty
    End Sub

    Public Sub New(ByVal strMake As String, ByVal strModel As String)
        mstrMake = strMake
        mstrModel = strModel
        mstrType = String.Empty
    End Sub

    Public Sub New(ByVal strMake As String, ByVal strModel As String, ByVal strType As String)
        mstrMake = strMake
        mstrModel = strModel
        mstrType = strType
    End Sub

    'Methods
    Public Function Car_Info() As String
        Return "Make: " & mstrMake & "  " & "Model: " & mstrModel & "  " & "Vehicle Type: " & mstrType
    End Function


End Class
