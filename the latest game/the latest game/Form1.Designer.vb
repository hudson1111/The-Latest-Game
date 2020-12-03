<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Fire_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Linus_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Gravity_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.You_Lose = New System.Windows.Forms.PictureBox()
        Me.you_win = New System.Windows.Forms.PictureBox()
        Me.WALL8 = New System.Windows.Forms.PictureBox()
        Me.WALL7 = New System.Windows.Forms.PictureBox()
        Me.WALL6 = New System.Windows.Forms.PictureBox()
        Me.WALL5 = New System.Windows.Forms.PictureBox()
        Me.WALL3 = New System.Windows.Forms.PictureBox()
        Me.WALL2 = New System.Windows.Forms.PictureBox()
        Me.WALL = New System.Windows.Forms.PictureBox()
        Me.Linus = New System.Windows.Forms.PictureBox()
        Me.Wario = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Fire = New System.Windows.Forms.PictureBox()
        CType(Me.You_Lose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.you_win, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WALL8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WALL7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WALL6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WALL5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WALL3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WALL2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WALL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Linus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fire, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Fire_Timer
        '
        Me.Fire_Timer.Enabled = True
        Me.Fire_Timer.Interval = 20
        '
        'Linus_Timer
        '
        Me.Linus_Timer.Enabled = True
        Me.Linus_Timer.Interval = 300
        '
        'Gravity_Timer
        '
        Me.Gravity_Timer.Enabled = True
        Me.Gravity_Timer.Interval = 25
        '
        'You_Lose
        '
        Me.You_Lose.Image = Global.the_latest_game.My.Resources.Resources.game_lose_720x340
        Me.You_Lose.Location = New System.Drawing.Point(478, 70)
        Me.You_Lose.Name = "You_Lose"
        Me.You_Lose.Size = New System.Drawing.Size(224, 150)
        Me.You_Lose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.You_Lose.TabIndex = 14
        Me.You_Lose.TabStop = False
        Me.You_Lose.Visible = False
        '
        'you_win
        '
        Me.you_win.Image = CType(resources.GetObject("you_win.Image"), System.Drawing.Image)
        Me.you_win.Location = New System.Drawing.Point(478, 70)
        Me.you_win.Name = "you_win"
        Me.you_win.Size = New System.Drawing.Size(224, 150)
        Me.you_win.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.you_win.TabIndex = 12
        Me.you_win.TabStop = False
        Me.you_win.Visible = False
        '
        'WALL8
        '
        Me.WALL8.Location = New System.Drawing.Point(274, 54)
        Me.WALL8.Name = "WALL8"
        Me.WALL8.Size = New System.Drawing.Size(8, 76)
        Me.WALL8.TabIndex = 10
        Me.WALL8.TabStop = False
        Me.WALL8.Visible = False
        '
        'WALL7
        '
        Me.WALL7.Location = New System.Drawing.Point(948, 38)
        Me.WALL7.Name = "WALL7"
        Me.WALL7.Size = New System.Drawing.Size(10, 142)
        Me.WALL7.TabIndex = 9
        Me.WALL7.TabStop = False
        Me.WALL7.Visible = False
        '
        'WALL6
        '
        Me.WALL6.Location = New System.Drawing.Point(897, 317)
        Me.WALL6.Name = "WALL6"
        Me.WALL6.Size = New System.Drawing.Size(8, 37)
        Me.WALL6.TabIndex = 8
        Me.WALL6.TabStop = False
        Me.WALL6.Visible = False
        '
        'WALL5
        '
        Me.WALL5.Location = New System.Drawing.Point(897, 317)
        Me.WALL5.Name = "WALL5"
        Me.WALL5.Size = New System.Drawing.Size(142, 10)
        Me.WALL5.TabIndex = 7
        Me.WALL5.TabStop = False
        Me.WALL5.Visible = False
        '
        'WALL3
        '
        Me.WALL3.Location = New System.Drawing.Point(274, 38)
        Me.WALL3.Name = "WALL3"
        Me.WALL3.Size = New System.Drawing.Size(675, 10)
        Me.WALL3.TabIndex = 6
        Me.WALL3.TabStop = False
        Me.WALL3.Visible = False
        '
        'WALL2
        '
        Me.WALL2.Location = New System.Drawing.Point(0, 124)
        Me.WALL2.Name = "WALL2"
        Me.WALL2.Size = New System.Drawing.Size(282, 13)
        Me.WALL2.TabIndex = 5
        Me.WALL2.TabStop = False
        Me.WALL2.Visible = False
        '
        'WALL
        '
        Me.WALL.Location = New System.Drawing.Point(0, 360)
        Me.WALL.Name = "WALL"
        Me.WALL.Size = New System.Drawing.Size(895, 10)
        Me.WALL.TabIndex = 4
        Me.WALL.TabStop = False
        Me.WALL.Visible = False
        '
        'Linus
        '
        Me.Linus.BackColor = System.Drawing.Color.Black
        Me.Linus.Enabled = False
        Me.Linus.Image = CType(resources.GetObject("Linus.Image"), System.Drawing.Image)
        Me.Linus.Location = New System.Drawing.Point(806, 223)
        Me.Linus.Name = "Linus"
        Me.Linus.Size = New System.Drawing.Size(85, 131)
        Me.Linus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Linus.TabIndex = 1
        Me.Linus.TabStop = False
        '
        'Wario
        '
        Me.Wario.BackColor = System.Drawing.Color.Black
        Me.Wario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Wario.Image = CType(resources.GetObject("Wario.Image"), System.Drawing.Image)
        Me.Wario.Location = New System.Drawing.Point(61, 299)
        Me.Wario.Name = "Wario"
        Me.Wario.Size = New System.Drawing.Size(49, 55)
        Me.Wario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Wario.TabIndex = 0
        Me.Wario.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1041, 551)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'Fire
        '
        Me.Fire.BackColor = System.Drawing.Color.Transparent
        Me.Fire.BackgroundImage = Global.the_latest_game.My.Resources.Resources.fire2
        Me.Fire.Image = CType(resources.GetObject("Fire.Image"), System.Drawing.Image)
        Me.Fire.Location = New System.Drawing.Point(478, 290)
        Me.Fire.Name = "Fire"
        Me.Fire.Size = New System.Drawing.Size(50, 37)
        Me.Fire.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Fire.TabIndex = 15
        Me.Fire.TabStop = False
        Me.Fire.Visible = False
        Me.Fire.WaitOnLoad = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1041, 558)
        Me.Controls.Add(Me.Fire)
        Me.Controls.Add(Me.You_Lose)
        Me.Controls.Add(Me.you_win)
        Me.Controls.Add(Me.WALL8)
        Me.Controls.Add(Me.WALL7)
        Me.Controls.Add(Me.WALL6)
        Me.Controls.Add(Me.WALL5)
        Me.Controls.Add(Me.WALL3)
        Me.Controls.Add(Me.WALL2)
        Me.Controls.Add(Me.WALL)
        Me.Controls.Add(Me.Linus)
        Me.Controls.Add(Me.Wario)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.Text = "Super Wario For Yhe PS5"
        CType(Me.You_Lose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.you_win, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WALL8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WALL7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WALL6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WALL5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WALL3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WALL2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WALL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Linus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fire, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Fire_Timer As Timer
    Friend WithEvents Linus_Timer As Timer
    Friend WithEvents Gravity_Timer As Timer
    Friend WithEvents WALL As PictureBox
    Friend WithEvents WALL2 As PictureBox
    Friend WithEvents WALL3 As PictureBox
    Friend WithEvents WALL5 As PictureBox
    Friend WithEvents WALL6 As PictureBox
    Friend WithEvents WALL7 As PictureBox
    Friend WithEvents WALL8 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents you_win As PictureBox
    Friend WithEvents You_Lose As PictureBox
    Private WithEvents Wario As PictureBox
    Friend WithEvents Fire As PictureBox
End Class
