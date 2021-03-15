<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPhilosopherDogCar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblPhilosopher = New System.Windows.Forms.Label()
        Me.lblDog = New System.Windows.Forms.Label()
        Me.lblCar = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblQuote = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblbreed = New System.Windows.Forms.Label()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.lblMake = New System.Windows.Forms.Label()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtQuote = New System.Windows.Forms.TextBox()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.txtBreed = New System.Windows.Forms.TextBox()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.txtMake = New System.Windows.Forms.TextBox()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.cboColor = New System.Windows.Forms.ComboBox()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.btnPhilosopher = New System.Windows.Forms.Button()
        Me.btnDog = New System.Windows.Forms.Button()
        Me.btnCar = New System.Windows.Forms.Button()
        Me.lbxPhilosopher = New System.Windows.Forms.ListBox()
        Me.lbxDog = New System.Windows.Forms.ListBox()
        Me.lbxCar = New System.Windows.Forms.ListBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPhilosopher
        '
        Me.lblPhilosopher.AutoSize = True
        Me.lblPhilosopher.BackColor = System.Drawing.Color.Silver
        Me.lblPhilosopher.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhilosopher.Location = New System.Drawing.Point(25, 25)
        Me.lblPhilosopher.Name = "lblPhilosopher"
        Me.lblPhilosopher.Size = New System.Drawing.Size(103, 20)
        Me.lblPhilosopher.TabIndex = 0
        Me.lblPhilosopher.Text = "Philosopher"
        '
        'lblDog
        '
        Me.lblDog.AutoSize = True
        Me.lblDog.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDog.Location = New System.Drawing.Point(25, 249)
        Me.lblDog.Name = "lblDog"
        Me.lblDog.Size = New System.Drawing.Size(42, 20)
        Me.lblDog.TabIndex = 1
        Me.lblDog.Text = "Dog"
        '
        'lblCar
        '
        Me.lblCar.AutoSize = True
        Me.lblCar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCar.Location = New System.Drawing.Point(25, 476)
        Me.lblCar.Name = "lblCar"
        Me.lblCar.Size = New System.Drawing.Size(37, 20)
        Me.lblCar.TabIndex = 2
        Me.lblCar.Text = "Car"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(46, 65)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(53, 16)
        Me.lblName.TabIndex = 3
        Me.lblName.Text = "Name:"
        '
        'lblQuote
        '
        Me.lblQuote.AutoSize = True
        Me.lblQuote.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuote.Location = New System.Drawing.Point(46, 122)
        Me.lblQuote.Name = "lblQuote"
        Me.lblQuote.Size = New System.Drawing.Size(53, 16)
        Me.lblQuote.TabIndex = 4
        Me.lblQuote.Text = "Quote:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(46, 181)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(45, 16)
        Me.lblDate.TabIndex = 5
        Me.lblDate.Text = "Date:"
        '
        'lblbreed
        '
        Me.lblbreed.AutoSize = True
        Me.lblbreed.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbreed.Location = New System.Drawing.Point(37, 293)
        Me.lblbreed.Name = "lblbreed"
        Me.lblbreed.Size = New System.Drawing.Size(54, 16)
        Me.lblbreed.TabIndex = 6
        Me.lblbreed.Text = "Breed:"
        '
        'lblColor
        '
        Me.lblColor.AutoSize = True
        Me.lblColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColor.Location = New System.Drawing.Point(33, 347)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(49, 16)
        Me.lblColor.TabIndex = 7
        Me.lblColor.Text = "Color:"
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeight.Location = New System.Drawing.Point(33, 400)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(95, 16)
        Me.lblWeight.TabIndex = 8
        Me.lblWeight.Text = "Weight (lbs):"
        '
        'lblMake
        '
        Me.lblMake.AutoSize = True
        Me.lblMake.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMake.Location = New System.Drawing.Point(46, 522)
        Me.lblMake.Name = "lblMake"
        Me.lblMake.Size = New System.Drawing.Size(50, 16)
        Me.lblMake.TabIndex = 9
        Me.lblMake.Text = "Make:"
        '
        'lblModel
        '
        Me.lblModel.AutoSize = True
        Me.lblModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModel.Location = New System.Drawing.Point(47, 572)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(55, 16)
        Me.lblModel.TabIndex = 10
        Me.lblModel.Text = "Model:"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType.Location = New System.Drawing.Point(47, 622)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(48, 16)
        Me.lblType.TabIndex = 11
        Me.lblType.Text = "Type:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(143, 65)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(201, 20)
        Me.txtName.TabIndex = 0
        '
        'txtQuote
        '
        Me.txtQuote.Location = New System.Drawing.Point(143, 122)
        Me.txtQuote.Name = "txtQuote"
        Me.txtQuote.Size = New System.Drawing.Size(201, 20)
        Me.txtQuote.TabIndex = 1
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(143, 177)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(201, 20)
        Me.txtDate.TabIndex = 2
        '
        'txtBreed
        '
        Me.txtBreed.Location = New System.Drawing.Point(143, 289)
        Me.txtBreed.Name = "txtBreed"
        Me.txtBreed.Size = New System.Drawing.Size(201, 20)
        Me.txtBreed.TabIndex = 5
        '
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(143, 396)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(201, 20)
        Me.txtWeight.TabIndex = 7
        '
        'txtMake
        '
        Me.txtMake.Location = New System.Drawing.Point(143, 518)
        Me.txtMake.Name = "txtMake"
        Me.txtMake.Size = New System.Drawing.Size(201, 20)
        Me.txtMake.TabIndex = 10
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(143, 568)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(201, 20)
        Me.txtModel.TabIndex = 11
        '
        'cboColor
        '
        Me.cboColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboColor.FormattingEnabled = True
        Me.cboColor.Location = New System.Drawing.Point(143, 342)
        Me.cboColor.Name = "cboColor"
        Me.cboColor.Size = New System.Drawing.Size(201, 21)
        Me.cboColor.TabIndex = 6
        '
        'cboType
        '
        Me.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboType.FormattingEnabled = True
        Me.cboType.Location = New System.Drawing.Point(143, 617)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(201, 21)
        Me.cboType.TabIndex = 12
        '
        'btnPhilosopher
        '
        Me.btnPhilosopher.BackColor = System.Drawing.Color.LightGray
        Me.btnPhilosopher.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPhilosopher.Location = New System.Drawing.Point(373, 120)
        Me.btnPhilosopher.Name = "btnPhilosopher"
        Me.btnPhilosopher.Size = New System.Drawing.Size(139, 23)
        Me.btnPhilosopher.TabIndex = 3
        Me.btnPhilosopher.Text = "Create"
        Me.btnPhilosopher.UseVisualStyleBackColor = False
        '
        'btnDog
        '
        Me.btnDog.BackColor = System.Drawing.Color.LightGray
        Me.btnDog.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDog.Location = New System.Drawing.Point(373, 340)
        Me.btnDog.Name = "btnDog"
        Me.btnDog.Size = New System.Drawing.Size(139, 23)
        Me.btnDog.TabIndex = 8
        Me.btnDog.Text = "Create"
        Me.btnDog.UseVisualStyleBackColor = False
        '
        'btnCar
        '
        Me.btnCar.BackColor = System.Drawing.Color.LightGray
        Me.btnCar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCar.Location = New System.Drawing.Point(373, 565)
        Me.btnCar.Name = "btnCar"
        Me.btnCar.Size = New System.Drawing.Size(139, 23)
        Me.btnCar.TabIndex = 13
        Me.btnCar.Text = "Create"
        Me.btnCar.UseVisualStyleBackColor = False
        '
        'lbxPhilosopher
        '
        Me.lbxPhilosopher.BackColor = System.Drawing.Color.SkyBlue
        Me.lbxPhilosopher.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbxPhilosopher.FormattingEnabled = True
        Me.lbxPhilosopher.ItemHeight = 16
        Me.lbxPhilosopher.Location = New System.Drawing.Point(558, 50)
        Me.lbxPhilosopher.Name = "lbxPhilosopher"
        Me.lbxPhilosopher.Size = New System.Drawing.Size(203, 132)
        Me.lbxPhilosopher.TabIndex = 4
        '
        'lbxDog
        '
        Me.lbxDog.BackColor = System.Drawing.Color.SkyBlue
        Me.lbxDog.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbxDog.FormattingEnabled = True
        Me.lbxDog.ItemHeight = 16
        Me.lbxDog.Location = New System.Drawing.Point(558, 269)
        Me.lbxDog.Name = "lbxDog"
        Me.lbxDog.Size = New System.Drawing.Size(203, 132)
        Me.lbxDog.TabIndex = 9
        '
        'lbxCar
        '
        Me.lbxCar.BackColor = System.Drawing.Color.SkyBlue
        Me.lbxCar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbxCar.FormattingEnabled = True
        Me.lbxCar.ItemHeight = 16
        Me.lbxCar.Location = New System.Drawing.Point(558, 491)
        Me.lbxCar.Name = "lbxCar"
        Me.lbxCar.Size = New System.Drawing.Size(203, 132)
        Me.lbxCar.TabIndex = 14
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.OrangeRed
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.Location = New System.Drawing.Point(310, 658)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(202, 37)
        Me.btnReset.TabIndex = 15
        Me.btnReset.Text = "Reset Fields"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'frmPhilosopherDogCar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(795, 707)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.lbxCar)
        Me.Controls.Add(Me.lbxDog)
        Me.Controls.Add(Me.lbxPhilosopher)
        Me.Controls.Add(Me.btnCar)
        Me.Controls.Add(Me.btnDog)
        Me.Controls.Add(Me.btnPhilosopher)
        Me.Controls.Add(Me.cboType)
        Me.Controls.Add(Me.cboColor)
        Me.Controls.Add(Me.txtModel)
        Me.Controls.Add(Me.txtMake)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.txtBreed)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.txtQuote)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.lblModel)
        Me.Controls.Add(Me.lblMake)
        Me.Controls.Add(Me.lblWeight)
        Me.Controls.Add(Me.lblColor)
        Me.Controls.Add(Me.lblbreed)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblQuote)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblCar)
        Me.Controls.Add(Me.lblDog)
        Me.Controls.Add(Me.lblPhilosopher)
        Me.Name = "frmPhilosopherDogCar"
        Me.Text = "Philosophers, Dogs, and Cars"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPhilosopher As Label
    Friend WithEvents lblDog As Label
    Friend WithEvents lblCar As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblQuote As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblbreed As Label
    Friend WithEvents lblColor As Label
    Friend WithEvents lblWeight As Label
    Friend WithEvents lblMake As Label
    Friend WithEvents lblModel As Label
    Friend WithEvents lblType As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtQuote As TextBox
    Friend WithEvents txtDate As TextBox
    Friend WithEvents txtBreed As TextBox
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents txtMake As TextBox
    Friend WithEvents txtModel As TextBox
    Friend WithEvents cboColor As ComboBox
    Friend WithEvents cboType As ComboBox
    Friend WithEvents btnPhilosopher As Button
    Friend WithEvents btnDog As Button
    Friend WithEvents btnCar As Button
    Friend WithEvents lbxPhilosopher As ListBox
    Friend WithEvents lbxDog As ListBox
    Friend WithEvents lbxCar As ListBox
    Friend WithEvents btnReset As Button
End Class
