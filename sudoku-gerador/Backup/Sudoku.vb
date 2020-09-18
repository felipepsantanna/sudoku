Public Class SudokuForm
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents Button15 As System.Windows.Forms.Button
    Friend WithEvents Button16 As System.Windows.Forms.Button
    Friend WithEvents Button17 As System.Windows.Forms.Button
    Friend WithEvents Button18 As System.Windows.Forms.Button
    Friend WithEvents Button19 As System.Windows.Forms.Button
    Friend WithEvents Button20 As System.Windows.Forms.Button
    Friend WithEvents Button21 As System.Windows.Forms.Button
    Friend WithEvents Button22 As System.Windows.Forms.Button
    Friend WithEvents Button23 As System.Windows.Forms.Button
    Friend WithEvents Button24 As System.Windows.Forms.Button
    Friend WithEvents Button25 As System.Windows.Forms.Button
    Friend WithEvents Button26 As System.Windows.Forms.Button
    Friend WithEvents Button27 As System.Windows.Forms.Button
    Friend WithEvents Button28 As System.Windows.Forms.Button
    Friend WithEvents Button29 As System.Windows.Forms.Button
    Friend WithEvents Button30 As System.Windows.Forms.Button
    Friend WithEvents Button31 As System.Windows.Forms.Button
    Friend WithEvents Button32 As System.Windows.Forms.Button
    Friend WithEvents Button33 As System.Windows.Forms.Button
    Friend WithEvents Button34 As System.Windows.Forms.Button
    Friend WithEvents Button35 As System.Windows.Forms.Button
    Friend WithEvents Button36 As System.Windows.Forms.Button
    Friend WithEvents Button37 As System.Windows.Forms.Button
    Friend WithEvents Button38 As System.Windows.Forms.Button
    Friend WithEvents Button39 As System.Windows.Forms.Button
    Friend WithEvents Button40 As System.Windows.Forms.Button
    Friend WithEvents Button41 As System.Windows.Forms.Button
    Friend WithEvents Button42 As System.Windows.Forms.Button
    Friend WithEvents Button43 As System.Windows.Forms.Button
    Friend WithEvents Button44 As System.Windows.Forms.Button
    Friend WithEvents Button45 As System.Windows.Forms.Button
    Friend WithEvents Button46 As System.Windows.Forms.Button
    Friend WithEvents Button47 As System.Windows.Forms.Button
    Friend WithEvents Button48 As System.Windows.Forms.Button
    Friend WithEvents Button49 As System.Windows.Forms.Button
    Friend WithEvents Button50 As System.Windows.Forms.Button
    Friend WithEvents Button51 As System.Windows.Forms.Button
    Friend WithEvents Button52 As System.Windows.Forms.Button
    Friend WithEvents Button53 As System.Windows.Forms.Button
    Friend WithEvents Button54 As System.Windows.Forms.Button
    Friend WithEvents Button55 As System.Windows.Forms.Button
    Friend WithEvents Button56 As System.Windows.Forms.Button
    Friend WithEvents Button57 As System.Windows.Forms.Button
    Friend WithEvents Button58 As System.Windows.Forms.Button
    Friend WithEvents Button59 As System.Windows.Forms.Button
    Friend WithEvents Button60 As System.Windows.Forms.Button
    Friend WithEvents Button61 As System.Windows.Forms.Button
    Friend WithEvents Button62 As System.Windows.Forms.Button
    Friend WithEvents Button63 As System.Windows.Forms.Button
    Friend WithEvents Button64 As System.Windows.Forms.Button
    Friend WithEvents Button65 As System.Windows.Forms.Button
    Friend WithEvents Button66 As System.Windows.Forms.Button
    Friend WithEvents Button67 As System.Windows.Forms.Button
    Friend WithEvents Button68 As System.Windows.Forms.Button
    Friend WithEvents Button69 As System.Windows.Forms.Button
    Friend WithEvents Button70 As System.Windows.Forms.Button
    Friend WithEvents Button71 As System.Windows.Forms.Button
    Friend WithEvents Button72 As System.Windows.Forms.Button
    Friend WithEvents Button73 As System.Windows.Forms.Button
    Friend WithEvents Button74 As System.Windows.Forms.Button
    Friend WithEvents Button75 As System.Windows.Forms.Button
    Friend WithEvents Button76 As System.Windows.Forms.Button
    Friend WithEvents Button77 As System.Windows.Forms.Button
    Friend WithEvents Button78 As System.Windows.Forms.Button
    Friend WithEvents Button79 As System.Windows.Forms.Button
    Friend WithEvents Button80 As System.Windows.Forms.Button
    Friend WithEvents Button81 As System.Windows.Forms.Button
    Friend WithEvents btnNewGame As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents spnDifficulty As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblConfiguring As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnShowSolution As System.Windows.Forms.Button
    Friend WithEvents lblDone As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.Button9 = New System.Windows.Forms.Button
        Me.Button10 = New System.Windows.Forms.Button
        Me.Button11 = New System.Windows.Forms.Button
        Me.Button12 = New System.Windows.Forms.Button
        Me.Button13 = New System.Windows.Forms.Button
        Me.Button14 = New System.Windows.Forms.Button
        Me.Button15 = New System.Windows.Forms.Button
        Me.Button16 = New System.Windows.Forms.Button
        Me.Button17 = New System.Windows.Forms.Button
        Me.Button18 = New System.Windows.Forms.Button
        Me.Button19 = New System.Windows.Forms.Button
        Me.Button20 = New System.Windows.Forms.Button
        Me.Button21 = New System.Windows.Forms.Button
        Me.Button22 = New System.Windows.Forms.Button
        Me.Button23 = New System.Windows.Forms.Button
        Me.Button24 = New System.Windows.Forms.Button
        Me.Button25 = New System.Windows.Forms.Button
        Me.Button26 = New System.Windows.Forms.Button
        Me.Button27 = New System.Windows.Forms.Button
        Me.Button28 = New System.Windows.Forms.Button
        Me.Button29 = New System.Windows.Forms.Button
        Me.Button30 = New System.Windows.Forms.Button
        Me.Button31 = New System.Windows.Forms.Button
        Me.Button32 = New System.Windows.Forms.Button
        Me.Button33 = New System.Windows.Forms.Button
        Me.Button34 = New System.Windows.Forms.Button
        Me.Button35 = New System.Windows.Forms.Button
        Me.Button36 = New System.Windows.Forms.Button
        Me.Button37 = New System.Windows.Forms.Button
        Me.Button38 = New System.Windows.Forms.Button
        Me.Button39 = New System.Windows.Forms.Button
        Me.Button40 = New System.Windows.Forms.Button
        Me.Button41 = New System.Windows.Forms.Button
        Me.Button42 = New System.Windows.Forms.Button
        Me.Button43 = New System.Windows.Forms.Button
        Me.Button44 = New System.Windows.Forms.Button
        Me.Button45 = New System.Windows.Forms.Button
        Me.Button46 = New System.Windows.Forms.Button
        Me.Button47 = New System.Windows.Forms.Button
        Me.Button48 = New System.Windows.Forms.Button
        Me.Button49 = New System.Windows.Forms.Button
        Me.Button50 = New System.Windows.Forms.Button
        Me.Button51 = New System.Windows.Forms.Button
        Me.Button52 = New System.Windows.Forms.Button
        Me.Button53 = New System.Windows.Forms.Button
        Me.Button54 = New System.Windows.Forms.Button
        Me.Button55 = New System.Windows.Forms.Button
        Me.Button56 = New System.Windows.Forms.Button
        Me.Button57 = New System.Windows.Forms.Button
        Me.Button58 = New System.Windows.Forms.Button
        Me.Button59 = New System.Windows.Forms.Button
        Me.Button60 = New System.Windows.Forms.Button
        Me.Button61 = New System.Windows.Forms.Button
        Me.Button62 = New System.Windows.Forms.Button
        Me.Button63 = New System.Windows.Forms.Button
        Me.Button64 = New System.Windows.Forms.Button
        Me.Button65 = New System.Windows.Forms.Button
        Me.Button66 = New System.Windows.Forms.Button
        Me.Button67 = New System.Windows.Forms.Button
        Me.Button68 = New System.Windows.Forms.Button
        Me.Button69 = New System.Windows.Forms.Button
        Me.Button70 = New System.Windows.Forms.Button
        Me.Button71 = New System.Windows.Forms.Button
        Me.Button72 = New System.Windows.Forms.Button
        Me.Button73 = New System.Windows.Forms.Button
        Me.Button74 = New System.Windows.Forms.Button
        Me.Button75 = New System.Windows.Forms.Button
        Me.Button76 = New System.Windows.Forms.Button
        Me.Button77 = New System.Windows.Forms.Button
        Me.Button78 = New System.Windows.Forms.Button
        Me.Button79 = New System.Windows.Forms.Button
        Me.Button80 = New System.Windows.Forms.Button
        Me.Button81 = New System.Windows.Forms.Button
        Me.btnNewGame = New System.Windows.Forms.Button
        Me.spnDifficulty = New System.Windows.Forms.NumericUpDown
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblConfiguring = New System.Windows.Forms.Label
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnShowSolution = New System.Windows.Forms.Button
        Me.lblDone = New System.Windows.Forms.Label
        CType(Me.spnDifficulty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(16, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(24, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(40, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(24, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(64, 16)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(24, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button4.Location = New System.Drawing.Point(96, 16)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(24, 23)
        Me.Button4.TabIndex = 3
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button5.Location = New System.Drawing.Point(120, 16)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(24, 23)
        Me.Button5.TabIndex = 4
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button6.Location = New System.Drawing.Point(144, 16)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(24, 23)
        Me.Button6.TabIndex = 5
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button7.Location = New System.Drawing.Point(176, 16)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(24, 23)
        Me.Button7.TabIndex = 6
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button8.Location = New System.Drawing.Point(200, 16)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(24, 23)
        Me.Button8.TabIndex = 7
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button9.Location = New System.Drawing.Point(224, 16)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(24, 23)
        Me.Button9.TabIndex = 8
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button10.Location = New System.Drawing.Point(16, 40)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(24, 23)
        Me.Button10.TabIndex = 9
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button11.Location = New System.Drawing.Point(40, 40)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(24, 23)
        Me.Button11.TabIndex = 10
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button12.Location = New System.Drawing.Point(64, 40)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(24, 23)
        Me.Button12.TabIndex = 11
        Me.Button12.UseVisualStyleBackColor = False
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button13.Location = New System.Drawing.Point(96, 40)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(24, 23)
        Me.Button13.TabIndex = 12
        Me.Button13.UseVisualStyleBackColor = False
        '
        'Button14
        '
        Me.Button14.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button14.Location = New System.Drawing.Point(120, 40)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(24, 23)
        Me.Button14.TabIndex = 13
        Me.Button14.UseVisualStyleBackColor = False
        '
        'Button15
        '
        Me.Button15.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button15.Location = New System.Drawing.Point(144, 40)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(24, 23)
        Me.Button15.TabIndex = 14
        Me.Button15.UseVisualStyleBackColor = False
        '
        'Button16
        '
        Me.Button16.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button16.Location = New System.Drawing.Point(176, 40)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(24, 23)
        Me.Button16.TabIndex = 15
        Me.Button16.UseVisualStyleBackColor = False
        '
        'Button17
        '
        Me.Button17.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button17.Location = New System.Drawing.Point(200, 40)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(24, 23)
        Me.Button17.TabIndex = 16
        Me.Button17.UseVisualStyleBackColor = False
        '
        'Button18
        '
        Me.Button18.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button18.Location = New System.Drawing.Point(224, 40)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(24, 23)
        Me.Button18.TabIndex = 17
        Me.Button18.UseVisualStyleBackColor = False
        '
        'Button19
        '
        Me.Button19.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button19.Location = New System.Drawing.Point(16, 64)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(24, 23)
        Me.Button19.TabIndex = 18
        Me.Button19.UseVisualStyleBackColor = False
        '
        'Button20
        '
        Me.Button20.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button20.Location = New System.Drawing.Point(40, 64)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(24, 23)
        Me.Button20.TabIndex = 19
        Me.Button20.UseVisualStyleBackColor = False
        '
        'Button21
        '
        Me.Button21.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button21.Location = New System.Drawing.Point(64, 64)
        Me.Button21.Name = "Button21"
        Me.Button21.Size = New System.Drawing.Size(24, 23)
        Me.Button21.TabIndex = 20
        Me.Button21.UseVisualStyleBackColor = False
        '
        'Button22
        '
        Me.Button22.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button22.Location = New System.Drawing.Point(96, 64)
        Me.Button22.Name = "Button22"
        Me.Button22.Size = New System.Drawing.Size(24, 23)
        Me.Button22.TabIndex = 21
        Me.Button22.UseVisualStyleBackColor = False
        '
        'Button23
        '
        Me.Button23.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button23.Location = New System.Drawing.Point(120, 64)
        Me.Button23.Name = "Button23"
        Me.Button23.Size = New System.Drawing.Size(24, 23)
        Me.Button23.TabIndex = 22
        Me.Button23.UseVisualStyleBackColor = False
        '
        'Button24
        '
        Me.Button24.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button24.Location = New System.Drawing.Point(144, 64)
        Me.Button24.Name = "Button24"
        Me.Button24.Size = New System.Drawing.Size(24, 23)
        Me.Button24.TabIndex = 23
        Me.Button24.UseVisualStyleBackColor = False
        '
        'Button25
        '
        Me.Button25.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button25.Location = New System.Drawing.Point(176, 64)
        Me.Button25.Name = "Button25"
        Me.Button25.Size = New System.Drawing.Size(24, 23)
        Me.Button25.TabIndex = 24
        Me.Button25.UseVisualStyleBackColor = False
        '
        'Button26
        '
        Me.Button26.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button26.Location = New System.Drawing.Point(200, 64)
        Me.Button26.Name = "Button26"
        Me.Button26.Size = New System.Drawing.Size(24, 23)
        Me.Button26.TabIndex = 25
        Me.Button26.UseVisualStyleBackColor = False
        '
        'Button27
        '
        Me.Button27.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button27.Location = New System.Drawing.Point(224, 64)
        Me.Button27.Name = "Button27"
        Me.Button27.Size = New System.Drawing.Size(24, 23)
        Me.Button27.TabIndex = 26
        Me.Button27.UseVisualStyleBackColor = False
        '
        'Button28
        '
        Me.Button28.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button28.Location = New System.Drawing.Point(16, 96)
        Me.Button28.Name = "Button28"
        Me.Button28.Size = New System.Drawing.Size(24, 23)
        Me.Button28.TabIndex = 53
        Me.Button28.UseVisualStyleBackColor = False
        '
        'Button29
        '
        Me.Button29.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button29.Location = New System.Drawing.Point(40, 96)
        Me.Button29.Name = "Button29"
        Me.Button29.Size = New System.Drawing.Size(24, 23)
        Me.Button29.TabIndex = 52
        Me.Button29.UseVisualStyleBackColor = False
        '
        'Button30
        '
        Me.Button30.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button30.Location = New System.Drawing.Point(64, 96)
        Me.Button30.Name = "Button30"
        Me.Button30.Size = New System.Drawing.Size(24, 23)
        Me.Button30.TabIndex = 51
        Me.Button30.UseVisualStyleBackColor = False
        '
        'Button31
        '
        Me.Button31.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button31.Location = New System.Drawing.Point(96, 96)
        Me.Button31.Name = "Button31"
        Me.Button31.Size = New System.Drawing.Size(24, 23)
        Me.Button31.TabIndex = 50
        Me.Button31.UseVisualStyleBackColor = False
        '
        'Button32
        '
        Me.Button32.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button32.Location = New System.Drawing.Point(120, 96)
        Me.Button32.Name = "Button32"
        Me.Button32.Size = New System.Drawing.Size(24, 23)
        Me.Button32.TabIndex = 49
        Me.Button32.UseVisualStyleBackColor = False
        '
        'Button33
        '
        Me.Button33.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button33.Location = New System.Drawing.Point(144, 96)
        Me.Button33.Name = "Button33"
        Me.Button33.Size = New System.Drawing.Size(24, 23)
        Me.Button33.TabIndex = 48
        Me.Button33.UseVisualStyleBackColor = False
        '
        'Button34
        '
        Me.Button34.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button34.Location = New System.Drawing.Point(176, 96)
        Me.Button34.Name = "Button34"
        Me.Button34.Size = New System.Drawing.Size(24, 23)
        Me.Button34.TabIndex = 47
        Me.Button34.UseVisualStyleBackColor = False
        '
        'Button35
        '
        Me.Button35.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button35.Location = New System.Drawing.Point(200, 96)
        Me.Button35.Name = "Button35"
        Me.Button35.Size = New System.Drawing.Size(24, 23)
        Me.Button35.TabIndex = 46
        Me.Button35.UseVisualStyleBackColor = False
        '
        'Button36
        '
        Me.Button36.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button36.Location = New System.Drawing.Point(224, 96)
        Me.Button36.Name = "Button36"
        Me.Button36.Size = New System.Drawing.Size(24, 23)
        Me.Button36.TabIndex = 45
        Me.Button36.UseVisualStyleBackColor = False
        '
        'Button37
        '
        Me.Button37.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button37.Location = New System.Drawing.Point(16, 120)
        Me.Button37.Name = "Button37"
        Me.Button37.Size = New System.Drawing.Size(24, 23)
        Me.Button37.TabIndex = 44
        Me.Button37.UseVisualStyleBackColor = False
        '
        'Button38
        '
        Me.Button38.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button38.Location = New System.Drawing.Point(40, 120)
        Me.Button38.Name = "Button38"
        Me.Button38.Size = New System.Drawing.Size(24, 23)
        Me.Button38.TabIndex = 43
        Me.Button38.UseVisualStyleBackColor = False
        '
        'Button39
        '
        Me.Button39.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button39.Location = New System.Drawing.Point(64, 120)
        Me.Button39.Name = "Button39"
        Me.Button39.Size = New System.Drawing.Size(24, 23)
        Me.Button39.TabIndex = 42
        Me.Button39.UseVisualStyleBackColor = False
        '
        'Button40
        '
        Me.Button40.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button40.Location = New System.Drawing.Point(96, 120)
        Me.Button40.Name = "Button40"
        Me.Button40.Size = New System.Drawing.Size(24, 23)
        Me.Button40.TabIndex = 41
        Me.Button40.UseVisualStyleBackColor = False
        '
        'Button41
        '
        Me.Button41.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button41.Location = New System.Drawing.Point(120, 120)
        Me.Button41.Name = "Button41"
        Me.Button41.Size = New System.Drawing.Size(24, 23)
        Me.Button41.TabIndex = 40
        Me.Button41.UseVisualStyleBackColor = False
        '
        'Button42
        '
        Me.Button42.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button42.Location = New System.Drawing.Point(144, 120)
        Me.Button42.Name = "Button42"
        Me.Button42.Size = New System.Drawing.Size(24, 23)
        Me.Button42.TabIndex = 39
        Me.Button42.UseVisualStyleBackColor = False
        '
        'Button43
        '
        Me.Button43.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button43.Location = New System.Drawing.Point(176, 120)
        Me.Button43.Name = "Button43"
        Me.Button43.Size = New System.Drawing.Size(24, 23)
        Me.Button43.TabIndex = 38
        Me.Button43.UseVisualStyleBackColor = False
        '
        'Button44
        '
        Me.Button44.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button44.Location = New System.Drawing.Point(200, 120)
        Me.Button44.Name = "Button44"
        Me.Button44.Size = New System.Drawing.Size(24, 23)
        Me.Button44.TabIndex = 37
        Me.Button44.UseVisualStyleBackColor = False
        '
        'Button45
        '
        Me.Button45.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button45.Location = New System.Drawing.Point(224, 120)
        Me.Button45.Name = "Button45"
        Me.Button45.Size = New System.Drawing.Size(24, 23)
        Me.Button45.TabIndex = 36
        Me.Button45.UseVisualStyleBackColor = False
        '
        'Button46
        '
        Me.Button46.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button46.Location = New System.Drawing.Point(16, 144)
        Me.Button46.Name = "Button46"
        Me.Button46.Size = New System.Drawing.Size(24, 23)
        Me.Button46.TabIndex = 35
        Me.Button46.UseVisualStyleBackColor = False
        '
        'Button47
        '
        Me.Button47.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button47.Location = New System.Drawing.Point(40, 144)
        Me.Button47.Name = "Button47"
        Me.Button47.Size = New System.Drawing.Size(24, 23)
        Me.Button47.TabIndex = 34
        Me.Button47.UseVisualStyleBackColor = False
        '
        'Button48
        '
        Me.Button48.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button48.Location = New System.Drawing.Point(64, 144)
        Me.Button48.Name = "Button48"
        Me.Button48.Size = New System.Drawing.Size(24, 23)
        Me.Button48.TabIndex = 33
        Me.Button48.UseVisualStyleBackColor = False
        '
        'Button49
        '
        Me.Button49.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button49.Location = New System.Drawing.Point(96, 144)
        Me.Button49.Name = "Button49"
        Me.Button49.Size = New System.Drawing.Size(24, 23)
        Me.Button49.TabIndex = 32
        Me.Button49.UseVisualStyleBackColor = False
        '
        'Button50
        '
        Me.Button50.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button50.Location = New System.Drawing.Point(120, 144)
        Me.Button50.Name = "Button50"
        Me.Button50.Size = New System.Drawing.Size(24, 23)
        Me.Button50.TabIndex = 31
        Me.Button50.UseVisualStyleBackColor = False
        '
        'Button51
        '
        Me.Button51.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button51.Location = New System.Drawing.Point(144, 144)
        Me.Button51.Name = "Button51"
        Me.Button51.Size = New System.Drawing.Size(24, 23)
        Me.Button51.TabIndex = 30
        Me.Button51.UseVisualStyleBackColor = False
        '
        'Button52
        '
        Me.Button52.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button52.Location = New System.Drawing.Point(176, 144)
        Me.Button52.Name = "Button52"
        Me.Button52.Size = New System.Drawing.Size(24, 23)
        Me.Button52.TabIndex = 29
        Me.Button52.UseVisualStyleBackColor = False
        '
        'Button53
        '
        Me.Button53.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button53.Location = New System.Drawing.Point(200, 144)
        Me.Button53.Name = "Button53"
        Me.Button53.Size = New System.Drawing.Size(24, 23)
        Me.Button53.TabIndex = 28
        Me.Button53.UseVisualStyleBackColor = False
        '
        'Button54
        '
        Me.Button54.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button54.Location = New System.Drawing.Point(224, 144)
        Me.Button54.Name = "Button54"
        Me.Button54.Size = New System.Drawing.Size(24, 23)
        Me.Button54.TabIndex = 27
        Me.Button54.UseVisualStyleBackColor = False
        '
        'Button55
        '
        Me.Button55.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button55.Location = New System.Drawing.Point(16, 176)
        Me.Button55.Name = "Button55"
        Me.Button55.Size = New System.Drawing.Size(24, 23)
        Me.Button55.TabIndex = 80
        Me.Button55.UseVisualStyleBackColor = False
        '
        'Button56
        '
        Me.Button56.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button56.Location = New System.Drawing.Point(40, 176)
        Me.Button56.Name = "Button56"
        Me.Button56.Size = New System.Drawing.Size(24, 23)
        Me.Button56.TabIndex = 79
        Me.Button56.UseVisualStyleBackColor = False
        '
        'Button57
        '
        Me.Button57.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button57.Location = New System.Drawing.Point(64, 176)
        Me.Button57.Name = "Button57"
        Me.Button57.Size = New System.Drawing.Size(24, 23)
        Me.Button57.TabIndex = 78
        Me.Button57.UseVisualStyleBackColor = False
        '
        'Button58
        '
        Me.Button58.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button58.Location = New System.Drawing.Point(96, 176)
        Me.Button58.Name = "Button58"
        Me.Button58.Size = New System.Drawing.Size(24, 23)
        Me.Button58.TabIndex = 77
        Me.Button58.UseVisualStyleBackColor = False
        '
        'Button59
        '
        Me.Button59.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button59.Location = New System.Drawing.Point(120, 176)
        Me.Button59.Name = "Button59"
        Me.Button59.Size = New System.Drawing.Size(24, 23)
        Me.Button59.TabIndex = 76
        Me.Button59.UseVisualStyleBackColor = False
        '
        'Button60
        '
        Me.Button60.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button60.Location = New System.Drawing.Point(144, 176)
        Me.Button60.Name = "Button60"
        Me.Button60.Size = New System.Drawing.Size(24, 23)
        Me.Button60.TabIndex = 75
        Me.Button60.UseVisualStyleBackColor = False
        '
        'Button61
        '
        Me.Button61.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button61.Location = New System.Drawing.Point(176, 176)
        Me.Button61.Name = "Button61"
        Me.Button61.Size = New System.Drawing.Size(24, 23)
        Me.Button61.TabIndex = 74
        Me.Button61.UseVisualStyleBackColor = False
        '
        'Button62
        '
        Me.Button62.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button62.Location = New System.Drawing.Point(200, 176)
        Me.Button62.Name = "Button62"
        Me.Button62.Size = New System.Drawing.Size(24, 23)
        Me.Button62.TabIndex = 73
        Me.Button62.UseVisualStyleBackColor = False
        '
        'Button63
        '
        Me.Button63.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button63.Location = New System.Drawing.Point(224, 176)
        Me.Button63.Name = "Button63"
        Me.Button63.Size = New System.Drawing.Size(24, 23)
        Me.Button63.TabIndex = 72
        Me.Button63.UseVisualStyleBackColor = False
        '
        'Button64
        '
        Me.Button64.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button64.Location = New System.Drawing.Point(16, 200)
        Me.Button64.Name = "Button64"
        Me.Button64.Size = New System.Drawing.Size(24, 23)
        Me.Button64.TabIndex = 71
        Me.Button64.UseVisualStyleBackColor = False
        '
        'Button65
        '
        Me.Button65.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button65.Location = New System.Drawing.Point(40, 200)
        Me.Button65.Name = "Button65"
        Me.Button65.Size = New System.Drawing.Size(24, 23)
        Me.Button65.TabIndex = 70
        Me.Button65.UseVisualStyleBackColor = False
        '
        'Button66
        '
        Me.Button66.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button66.Location = New System.Drawing.Point(64, 200)
        Me.Button66.Name = "Button66"
        Me.Button66.Size = New System.Drawing.Size(24, 23)
        Me.Button66.TabIndex = 69
        Me.Button66.UseVisualStyleBackColor = False
        '
        'Button67
        '
        Me.Button67.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button67.Location = New System.Drawing.Point(96, 200)
        Me.Button67.Name = "Button67"
        Me.Button67.Size = New System.Drawing.Size(24, 23)
        Me.Button67.TabIndex = 68
        Me.Button67.UseVisualStyleBackColor = False
        '
        'Button68
        '
        Me.Button68.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button68.Location = New System.Drawing.Point(120, 200)
        Me.Button68.Name = "Button68"
        Me.Button68.Size = New System.Drawing.Size(24, 23)
        Me.Button68.TabIndex = 67
        Me.Button68.UseVisualStyleBackColor = False
        '
        'Button69
        '
        Me.Button69.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button69.Location = New System.Drawing.Point(144, 200)
        Me.Button69.Name = "Button69"
        Me.Button69.Size = New System.Drawing.Size(24, 23)
        Me.Button69.TabIndex = 66
        Me.Button69.UseVisualStyleBackColor = False
        '
        'Button70
        '
        Me.Button70.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button70.Location = New System.Drawing.Point(176, 200)
        Me.Button70.Name = "Button70"
        Me.Button70.Size = New System.Drawing.Size(24, 23)
        Me.Button70.TabIndex = 65
        Me.Button70.UseVisualStyleBackColor = False
        '
        'Button71
        '
        Me.Button71.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button71.Location = New System.Drawing.Point(200, 200)
        Me.Button71.Name = "Button71"
        Me.Button71.Size = New System.Drawing.Size(24, 23)
        Me.Button71.TabIndex = 64
        Me.Button71.UseVisualStyleBackColor = False
        '
        'Button72
        '
        Me.Button72.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button72.Location = New System.Drawing.Point(224, 200)
        Me.Button72.Name = "Button72"
        Me.Button72.Size = New System.Drawing.Size(24, 23)
        Me.Button72.TabIndex = 63
        Me.Button72.UseVisualStyleBackColor = False
        '
        'Button73
        '
        Me.Button73.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button73.Location = New System.Drawing.Point(16, 224)
        Me.Button73.Name = "Button73"
        Me.Button73.Size = New System.Drawing.Size(24, 23)
        Me.Button73.TabIndex = 62
        Me.Button73.UseVisualStyleBackColor = False
        '
        'Button74
        '
        Me.Button74.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button74.Location = New System.Drawing.Point(40, 224)
        Me.Button74.Name = "Button74"
        Me.Button74.Size = New System.Drawing.Size(24, 23)
        Me.Button74.TabIndex = 61
        Me.Button74.UseVisualStyleBackColor = False
        '
        'Button75
        '
        Me.Button75.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button75.Location = New System.Drawing.Point(64, 224)
        Me.Button75.Name = "Button75"
        Me.Button75.Size = New System.Drawing.Size(24, 23)
        Me.Button75.TabIndex = 60
        Me.Button75.UseVisualStyleBackColor = False
        '
        'Button76
        '
        Me.Button76.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button76.Location = New System.Drawing.Point(96, 224)
        Me.Button76.Name = "Button76"
        Me.Button76.Size = New System.Drawing.Size(24, 23)
        Me.Button76.TabIndex = 59
        Me.Button76.UseVisualStyleBackColor = False
        '
        'Button77
        '
        Me.Button77.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button77.Location = New System.Drawing.Point(120, 224)
        Me.Button77.Name = "Button77"
        Me.Button77.Size = New System.Drawing.Size(24, 23)
        Me.Button77.TabIndex = 58
        Me.Button77.UseVisualStyleBackColor = False
        '
        'Button78
        '
        Me.Button78.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button78.Location = New System.Drawing.Point(144, 224)
        Me.Button78.Name = "Button78"
        Me.Button78.Size = New System.Drawing.Size(24, 23)
        Me.Button78.TabIndex = 57
        Me.Button78.UseVisualStyleBackColor = False
        '
        'Button79
        '
        Me.Button79.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button79.Location = New System.Drawing.Point(176, 224)
        Me.Button79.Name = "Button79"
        Me.Button79.Size = New System.Drawing.Size(24, 23)
        Me.Button79.TabIndex = 56
        Me.Button79.UseVisualStyleBackColor = False
        '
        'Button80
        '
        Me.Button80.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button80.Location = New System.Drawing.Point(200, 224)
        Me.Button80.Name = "Button80"
        Me.Button80.Size = New System.Drawing.Size(24, 23)
        Me.Button80.TabIndex = 55
        Me.Button80.UseVisualStyleBackColor = False
        '
        'Button81
        '
        Me.Button81.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button81.Location = New System.Drawing.Point(224, 224)
        Me.Button81.Name = "Button81"
        Me.Button81.Size = New System.Drawing.Size(24, 23)
        Me.Button81.TabIndex = 54
        Me.Button81.UseVisualStyleBackColor = False
        '
        'btnNewGame
        '
        Me.btnNewGame.Location = New System.Drawing.Point(16, 296)
        Me.btnNewGame.Name = "btnNewGame"
        Me.btnNewGame.Size = New System.Drawing.Size(104, 23)
        Me.btnNewGame.TabIndex = 81
        Me.btnNewGame.Text = "Novo Jogo"
        '
        'spnDifficulty
        '
        Me.spnDifficulty.Location = New System.Drawing.Point(80, 265)
        Me.spnDifficulty.Maximum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.spnDifficulty.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.spnDifficulty.Name = "spnDifficulty"
        Me.spnDifficulty.Size = New System.Drawing.Size(32, 20)
        Me.spnDifficulty.TabIndex = 82
        Me.spnDifficulty.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 267)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "Dificuldade"
        '
        'lblConfiguring
        '
        Me.lblConfiguring.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblConfiguring.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfiguring.Location = New System.Drawing.Point(26, 122)
        Me.lblConfiguring.Name = "lblConfiguring"
        Me.lblConfiguring.Size = New System.Drawing.Size(208, 16)
        Me.lblConfiguring.TabIndex = 84
        Me.lblConfiguring.Text = "Configurando... Aguarde..."
        Me.lblConfiguring.Visible = False
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(192, 264)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(56, 23)
        Me.btnExit.TabIndex = 85
        Me.btnExit.Text = "Sair"
        '
        'btnShowSolution
        '
        Me.btnShowSolution.Enabled = False
        Me.btnShowSolution.Location = New System.Drawing.Point(144, 296)
        Me.btnShowSolution.Name = "btnShowSolution"
        Me.btnShowSolution.Size = New System.Drawing.Size(104, 24)
        Me.btnShowSolution.TabIndex = 86
        Me.btnShowSolution.Text = "Solução"
        '
        'lblDone
        '
        Me.lblDone.BackColor = System.Drawing.SystemColors.Info
        Me.lblDone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDone.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDone.Location = New System.Drawing.Point(128, 267)
        Me.lblDone.Name = "lblDone"
        Me.lblDone.Size = New System.Drawing.Size(56, 16)
        Me.lblDone.TabIndex = 87
        Me.lblDone.Text = "FEITO"
        Me.lblDone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblDone.Visible = False
        '
        'SudokuForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(264, 334)
        Me.Controls.Add(Me.lblDone)
        Me.Controls.Add(Me.btnShowSolution)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblConfiguring)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.spnDifficulty)
        Me.Controls.Add(Me.btnNewGame)
        Me.Controls.Add(Me.Button55)
        Me.Controls.Add(Me.Button56)
        Me.Controls.Add(Me.Button57)
        Me.Controls.Add(Me.Button58)
        Me.Controls.Add(Me.Button59)
        Me.Controls.Add(Me.Button60)
        Me.Controls.Add(Me.Button61)
        Me.Controls.Add(Me.Button62)
        Me.Controls.Add(Me.Button63)
        Me.Controls.Add(Me.Button64)
        Me.Controls.Add(Me.Button65)
        Me.Controls.Add(Me.Button66)
        Me.Controls.Add(Me.Button67)
        Me.Controls.Add(Me.Button68)
        Me.Controls.Add(Me.Button69)
        Me.Controls.Add(Me.Button70)
        Me.Controls.Add(Me.Button71)
        Me.Controls.Add(Me.Button72)
        Me.Controls.Add(Me.Button73)
        Me.Controls.Add(Me.Button74)
        Me.Controls.Add(Me.Button75)
        Me.Controls.Add(Me.Button76)
        Me.Controls.Add(Me.Button77)
        Me.Controls.Add(Me.Button78)
        Me.Controls.Add(Me.Button79)
        Me.Controls.Add(Me.Button80)
        Me.Controls.Add(Me.Button81)
        Me.Controls.Add(Me.Button28)
        Me.Controls.Add(Me.Button29)
        Me.Controls.Add(Me.Button30)
        Me.Controls.Add(Me.Button31)
        Me.Controls.Add(Me.Button32)
        Me.Controls.Add(Me.Button33)
        Me.Controls.Add(Me.Button34)
        Me.Controls.Add(Me.Button35)
        Me.Controls.Add(Me.Button36)
        Me.Controls.Add(Me.Button37)
        Me.Controls.Add(Me.Button38)
        Me.Controls.Add(Me.Button39)
        Me.Controls.Add(Me.Button40)
        Me.Controls.Add(Me.Button41)
        Me.Controls.Add(Me.Button42)
        Me.Controls.Add(Me.Button43)
        Me.Controls.Add(Me.Button44)
        Me.Controls.Add(Me.Button45)
        Me.Controls.Add(Me.Button46)
        Me.Controls.Add(Me.Button47)
        Me.Controls.Add(Me.Button48)
        Me.Controls.Add(Me.Button49)
        Me.Controls.Add(Me.Button50)
        Me.Controls.Add(Me.Button51)
        Me.Controls.Add(Me.Button52)
        Me.Controls.Add(Me.Button53)
        Me.Controls.Add(Me.Button54)
        Me.Controls.Add(Me.Button27)
        Me.Controls.Add(Me.Button26)
        Me.Controls.Add(Me.Button25)
        Me.Controls.Add(Me.Button24)
        Me.Controls.Add(Me.Button23)
        Me.Controls.Add(Me.Button22)
        Me.Controls.Add(Me.Button21)
        Me.Controls.Add(Me.Button20)
        Me.Controls.Add(Me.Button19)
        Me.Controls.Add(Me.Button18)
        Me.Controls.Add(Me.Button17)
        Me.Controls.Add(Me.Button16)
        Me.Controls.Add(Me.Button15)
        Me.Controls.Add(Me.Button14)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "SudokuForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sudoku"
        CType(Me.spnDifficulty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    ' atributos privadors
    Private SolutionShown As Boolean = False
    Private SudokuGrid(81) As Integer
    Private SudokuTemp(81) As String
    Private SudokuSolution(81) As String
    Private CurButtons(81) As Button
    Private RandNumb As New System.Random(CType(Now.Ticks Mod Int32.MaxValue, Integer))

    Private Sub SudokuForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i, j, k As Integer
        Dim row, col As Integer

        CurButtons(1) = Button1
        CurButtons(2) = Button2
        CurButtons(3) = Button3
        CurButtons(4) = Button4
        CurButtons(5) = Button5
        CurButtons(6) = Button6
        CurButtons(7) = Button7
        CurButtons(8) = Button8
        CurButtons(9) = Button9
        CurButtons(10) = Button10
        CurButtons(11) = Button11
        CurButtons(12) = Button12
        CurButtons(13) = Button13
        CurButtons(14) = Button14
        CurButtons(15) = Button15
        CurButtons(16) = Button16
        CurButtons(17) = Button17
        CurButtons(18) = Button18
        CurButtons(19) = Button19
        CurButtons(20) = Button20
        CurButtons(21) = Button21
        CurButtons(22) = Button22
        CurButtons(23) = Button23
        CurButtons(24) = Button24
        CurButtons(25) = Button25
        CurButtons(26) = Button26
        CurButtons(27) = Button27
        CurButtons(28) = Button28
        CurButtons(29) = Button29
        CurButtons(30) = Button30
        CurButtons(31) = Button31
        CurButtons(32) = Button32
        CurButtons(33) = Button33
        CurButtons(34) = Button34
        CurButtons(35) = Button35
        CurButtons(36) = Button36
        CurButtons(37) = Button37
        CurButtons(38) = Button38
        CurButtons(39) = Button39
        CurButtons(40) = Button40
        CurButtons(41) = Button41
        CurButtons(42) = Button42
        CurButtons(43) = Button43
        CurButtons(44) = Button44
        CurButtons(45) = Button45
        CurButtons(46) = Button46
        CurButtons(47) = Button47
        CurButtons(48) = Button48
        CurButtons(49) = Button49
        CurButtons(50) = Button50
        CurButtons(51) = Button51
        CurButtons(52) = Button52
        CurButtons(53) = Button53
        CurButtons(54) = Button54
        CurButtons(55) = Button55
        CurButtons(56) = Button56
        CurButtons(57) = Button57
        CurButtons(58) = Button58
        CurButtons(59) = Button59
        CurButtons(60) = Button60
        CurButtons(61) = Button61
        CurButtons(62) = Button62
        CurButtons(63) = Button63
        CurButtons(64) = Button64
        CurButtons(65) = Button65
        CurButtons(66) = Button66
        CurButtons(67) = Button67
        CurButtons(68) = Button68
        CurButtons(69) = Button69
        CurButtons(70) = Button70
        CurButtons(71) = Button71
        CurButtons(72) = Button72
        CurButtons(73) = Button73
        CurButtons(74) = Button74
        CurButtons(75) = Button75
        CurButtons(76) = Button76
        CurButtons(77) = Button77
        CurButtons(78) = Button78
        CurButtons(79) = Button79
        CurButtons(80) = Button80
        CurButtons(81) = Button81
        For i = 1 To 81
            CurButtons(i).Enabled = False
        Next i
    End Sub
    Private Sub btnNewGame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewGame.Click
        While Not CreateSudokuGrid()
        End While
        lblDone.Visible = False
        btnShowSolution.Enabled = True
        btnShowSolution.Text = "Solução"
        SolutionShown = False
    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If (MsgBox("Confirma o encerramento do jogo ? ", MsgBoxStyle.YesNo, "Sudoku") = MsgBoxResult.Yes) Then
            Close()
        End If
    End Sub
    Private Sub SudokuButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click, Button10.Click, Button11.Click, Button12.Click, Button13.Click, Button14.Click, Button15.Click, Button16.Click, Button17.Click, Button18.Click, Button19.Click, Button20.Click, Button21.Click, Button22.Click, Button23.Click, Button24.Click, Button25.Click, Button26.Click, Button27.Click, Button28.Click, Button29.Click, Button30.Click, Button31.Click, Button32.Click, Button33.Click, Button34.Click, Button35.Click, Button36.Click, Button37.Click, Button38.Click, Button39.Click, Button40.Click, Button41.Click, Button42.Click, Button43.Click, Button44.Click, Button45.Click, Button46.Click, Button47.Click, Button48.Click, Button49.Click, Button50.Click, Button51.Click, Button52.Click, Button53.Click, Button54.Click, Button55.Click, Button56.Click, Button57.Click, Button58.Click, Button59.Click, Button60.Click, Button61.Click, Button62.Click, Button63.Click, Button64.Click, Button65.Click, Button66.Click, Button67.Click, Button68.Click, Button69.Click, Button70.Click, Button71.Click, Button72.Click, Button73.Click, Button74.Click, Button75.Click, Button76.Click, Button77.Click, Button78.Click, Button79.Click, Button80.Click, Button81.Click
        Dim i As Integer
        Dim solFound As Boolean = True
        Dim CurButton As Button = CType(sender, Button)

        If Not SolutionShown Then
            If CurButton.Text = "" Then
                CurButton.Text = "1"
            ElseIf CurButton.Text = "9" Then
                CurButton.Text = ""
            Else
                CurButton.Text = Trim(Str(CInt(CurButton.Text) + 1))
            End If
            For i = 1 To 81
                If CurButtons(i).Text <> SudokuSolution(i) Then
                    solFound = False
                    Exit For
                End If
            Next i
            lblDone.Visible = solFound
        End If
    End Sub
    Private Sub btnShowSolution_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowSolution.Click
        Dim i As Integer

        If SolutionShown Then
            For i = 1 To 81
                CurButtons(i).Text = SudokuTemp(i)
            Next i
            btnShowSolution.Text = "Solução"
        Else
            For i = 1 To 81
                SudokuTemp(i) = CurButtons(i).Text
                CurButtons(i).Text = SudokuSolution(i)
            Next i
            btnShowSolution.Text = "Ocultar"
        End If
        SolutionShown = Not SolutionShown
    End Sub
    Private Function CreateSudokuGrid() As Boolean
        Dim i, j, k As Integer
        Dim numRand As Integer
        Dim CurButton As Button
        Dim ValIsOK(9) As Boolean
        Dim valsOK As Integer = 0

        Cursor.Current = Cursors.WaitCursor
        lblConfiguring.Visible = True
        For i = 1 To 81
            CurButton = CurButtons(i)
            CurButton.Text = ""
            CurButton.BackColor = System.Drawing.Color.Cyan
            CurButton.Visible = False
            SudokuSolution(i) = ""
        Next i
        lblConfiguring.Visible = True
        lblConfiguring.Refresh()
        For i = 1 To 81
            If True Then
                CurButton = CurButtons(i)
                valsOK = GetValidVals(i, ValIsOK)
                If valsOK <= 0 Then
                    Return False
                End If
                numRand = RandNumb.Next(0, valsOK) + 1
                k = 0
                For j = 1 To 9
                    If ValIsOK(j) Then
                        k = k + 1
                        If k = numRand Then
                            Exit For
                        End If
                    End If
                Next j
                CurButton.Text = j.ToString()
                CurButton.BackColor = System.Drawing.Color.LightSalmon
            End If
        Next i
        lblConfiguring.Visible = False
        For i = 1 To 81
            CurButton = CurButtons(i)
            SudokuSolution(i) = CurButton.Text
            numRand = RandNumb.Next(0, spnDifficulty.Value + 1) + 1
            If numRand > 1 Then
                CurButton.Text = ""
                CurButton.BackColor = System.Drawing.Color.Cyan
                CurButton.Enabled = True
            Else
                CurButton.Enabled = False
            End If
            CurButton.Visible = True
        Next i
        Cursor.Current = Cursors.Default
        Return True
    End Function
    Private Function GetValidVals(ByVal Location As Integer, ByRef ValidVals As Boolean()) As Integer
        Dim i, j, k As Integer
        Dim row, col As Integer
        Dim numStr As String
        Dim numOK As Boolean
        Dim retVal As Integer = 0

        For i = 1 To 9
            numOK = True
            numStr = i.ToString()
            For j = 1 To 9
                k = (Int((Location - 1) / 9) * 9) + j
                If CurButtons(k).Text = numStr Then
                    numOK = False
                    Exit For
                End If
            Next j
            If numOK Then
                For j = 1 To 9
                    k = (((Location - 1) Mod 9) + 1) + ((j - 1) * 9)
                    If CurButtons(k).Text = numStr Then
                        numOK = False
                        Exit For
                    End If
                Next j
            End If
            If numOK Then
                row = Int(Int((Location - 1) / 9) / 3)
                col = Int(((Location - 1) Mod 9) / 3)
                For j = 1 To 9
                    k = (((row * 3) + Int((j - 1) / 3)) * 9) + (col * 3) + ((j - 1) Mod 3) + 1
                    If CurButtons(k).Text = numStr Then
                        numOK = False
                        Exit For
                    End If
                Next j
            End If
            ValidVals(i) = numOK
            If numOK Then
                retVal = retVal + 1
            End If
        Next i
        Return retVal
    End Function

End Class
