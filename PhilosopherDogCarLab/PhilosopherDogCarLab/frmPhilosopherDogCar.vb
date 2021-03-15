'Author: Bruce Brown
'Date: 2/17/2021
'Purpose: This application is designed to intake information about philosophers, dogs,and cars with the ability
'of displaying that information back to the user.

Option Strict On
Option Explicit On

Imports System.ComponentModel


Public Class frmPhilosopherDogCar

    'Module Level Objects
    Dim lstPhilosophers As New BindingList(Of Philosophers)
    Dim lstDogs As New BindingList(Of Dogs)
    Dim lstCars As New BindingList(Of Cars)

    Private Sub btnPhilosopher_Click(sender As Object, e As EventArgs) Handles btnPhilosopher.Click

        'Declare and assign validation variable
        Dim blnIsValidDate As Boolean = IsDate(txtDate.Text)

        'Validate inputs have data
        If txtName.Text <> String.Empty Then
            If txtQuote.Text <> String.Empty Then
                If txtDate.Text <> String.Empty Then
                    If blnIsValidDate = True Then

                        'Declare and set objects and variables
                        Dim objPhilosopher As New Philosophers(txtName.Text, txtQuote.Text, txtDate.Text)

                        'Add new customer object to list of customers
                        lstPhilosophers.Add(objPhilosopher)

                        'Clears the fields for next entry
                        ClearPhilosopher()
                        txtName.Focus()

                    Else
                        Call Msg("You did not enter a valid date. Please try again.")
                        txtDate.Clear()
                        txtDate.Focus()
                    End If
                Else
                    Call Msg("Philosopher's date of quote is blank. Please try again.")
                    txtDate.Focus()
                End If
            Else
                Call Msg("Philosopher's quote is blank. Please try again.")
                txtQuote.Focus()
            End If
        Else
            Call Msg("Philosopher's name is blank. Please try again.")
            txtName.Focus()
        End If

    End Sub

    Private Sub btnDog_Click(sender As Object, e As EventArgs) Handles btnDog.Click

        'Declare and assign validation variable
        Dim blnIsValidNumber As Boolean = IsNumeric(txtWeight.Text)

        'Validate inputs have data
        If txtBreed.Text <> String.Empty Then
            If txtWeight.Text <> String.Empty Then
                If blnIsValidNumber = True Then

                    'Declare and set objects and vareiables
                    Dim objDog As New Dogs(txtBreed.Text, cboColor.SelectedItem.ToString, txtWeight.Text)

                    'Add new customer object to list of customers
                    lstDogs.Add(objDog)

                    'Clears the fields for next entry
                    ClearDog()
                    txtBreed.Focus()

                Else
                    Call Msg("You did not enter a number for the dog's weight. Please try again.")
                    txtWeight.Clear()
                    txtWeight.Focus()
                End If
            Else
                Call Msg("Dog's weight is blank. Please try again.")
                txtWeight.Focus()
            End If
        Else
            Call Msg("Dog's breed is blank. Please try again.")
            txtBreed.Focus()
        End If

    End Sub

    Private Sub btnCar_Click(sender As Object, e As EventArgs) Handles btnCar.Click
        'Validate inputs have data
        If txtMake.Text <> String.Empty Then
            If txtModel.Text <> String.Empty Then

                'Declare and set objects and vareiables
                Dim objCar As New Cars(txtMake.Text, txtModel.Text, cboType.SelectedItem.ToString)

                'Add new customer object to list of customers
                lstCars.Add(objCar)

                'Clears the fields for next entry
                ClearCar()
                txtMake.Focus()

            Else
                Call Msg("Car's model is blank. Please try again.")
                txtModel.Focus()
            End If
        Else
            Call Msg("Car's make is blank. Please try again.")
            txtMake.Focus()
        End If

    End Sub

    Public Sub Msg(ByVal strMsg As String)
        MessageBox.Show(strMsg, "Philosophers, Dogs, and Cars", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
    End Sub

    Private Sub frmPhilosopherDogCar_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Populate Dog Color List
        cboColor.Items.Add("Brown")
        cboColor.Items.Add("White")
        cboColor.Items.Add("Tan")
        cboColor.Items.Add("Golden")
        cboColor.Items.Add("Black")
        cboColor.Items.Add("White and Black")
        cboColor.Items.Add("White and Brown")
        cboColor.Items.Add("Black and Brown")

        'Populate Car Type List
        cboType.Items.Add("Coupe")
        cboType.Items.Add("Sedan")
        cboType.Items.Add("Truck")
        cboType.Items.Add("SUV")
        cboType.Items.Add("Crossover")
        cboType.Items.Add("Convertible")
        cboType.Items.Add("Hatchback")
        cboType.Items.Add("Sports Car")
        cboType.Items.Add("Minivan")
        cboType.Items.Add("Van")
        cboType.Items.Add("Station Wagon")

        'Automatically selects the first Sex and Activity Level
        cboColor.SelectedIndex = 0
        cboType.SelectedIndex = 0

        'Saves and displays objects in list box
        lbxPhilosopher.DataSource = lstPhilosophers
        lbxDog.DataSource = lstDogs
        lbxCar.DataSource = lstCars
        lbxPhilosopher.DisplayMember = "PhilosopherName"
        lbxDog.DisplayMember = "Breed"
        lbxCar.DisplayMember = "CarModel"
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'Resets all text fields
        ClearPhilosopher()
        ClearDog()
        ClearCar()
        txtName.Focus()
    End Sub

    Private Sub ClearPhilosopher()
        'Clears the text from the Philosopher fields
        txtName.Text = String.Empty
        txtQuote.Text = String.Empty
        txtDate.Text = String.Empty
    End Sub

    Private Sub ClearDog()
        'Clears the text from the dog fields
        txtBreed.Text = String.Empty
        txtWeight.Text = String.Empty
        cboColor.SelectedIndex = 0
    End Sub

    Private Sub ClearCar()
        'Clears the text from the car fields
        txtMake.Text = String.Empty
        txtModel.Text = String.Empty
        cboType.SelectedIndex = 0
    End Sub

    Private Sub lbxPhilosopher_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxPhilosopher.SelectedIndexChanged
        'Displays a message box with the grabbed information from the Philosopher class's function
        Dim objSelectedPhilosopher As Philosophers = CType(lbxPhilosopher.SelectedItem, Philosophers)
        MessageBox.Show(objSelectedPhilosopher.Philosopher_Info)
    End Sub

    Private Sub lbxDog_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxDog.SelectedIndexChanged
        'Displays a message box with the grabbed information from the Dog class's function
        Dim objSelectedDog As Dogs = CType(lbxDog.SelectedItem, Dogs)
        MessageBox.Show(objSelectedDog.Dog_Info)
    End Sub

    Private Sub lbxCar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxCar.SelectedIndexChanged
        'Displays a message box with the grabbed information from the Car class's function
        Dim objSelectedCar As Cars = CType(lbxCar.SelectedItem, Cars)
        MessageBox.Show(objSelectedCar.Car_Info)
    End Sub
End Class
