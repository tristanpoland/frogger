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
        Me.Tick = New System.Windows.Forms.Timer(Me.components)
        Me.GameTick = New System.Windows.Forms.Timer(Me.components)
        Me.car_r1c1 = New System.Windows.Forms.PictureBox()
        Me.car_r1c2 = New System.Windows.Forms.PictureBox()
        Me.car_r1c3 = New System.Windows.Forms.PictureBox()
        Me.car_r2c1 = New System.Windows.Forms.PictureBox()
        Me.car_r2c2 = New System.Windows.Forms.PictureBox()
        Me.car_r2c3 = New System.Windows.Forms.PictureBox()
        Me.Player = New System.Windows.Forms.PictureBox()
        CType(Me.car_r1c1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.car_r1c2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.car_r1c3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.car_r2c1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.car_r2c2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.car_r2c3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tick
        '
        Me.Tick.Interval = 20
        '
        'GameTick
        '
        Me.GameTick.Interval = 10
        '
        'car_r1c1
        '
        Me.car_r1c1.BackColor = System.Drawing.Color.Transparent
        Me.car_r1c1.Image = CType(resources.GetObject("car_r1c1.Image"), System.Drawing.Image)
        Me.car_r1c1.Location = New System.Drawing.Point(14, 424)
        Me.car_r1c1.Margin = New System.Windows.Forms.Padding(2)
        Me.car_r1c1.Name = "car_r1c1"
        Me.car_r1c1.Size = New System.Drawing.Size(60, 22)
        Me.car_r1c1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.car_r1c1.TabIndex = 1
        Me.car_r1c1.TabStop = False
        '
        'car_r1c2
        '
        Me.car_r1c2.BackColor = System.Drawing.Color.Transparent
        Me.car_r1c2.Image = CType(resources.GetObject("car_r1c2.Image"), System.Drawing.Image)
        Me.car_r1c2.Location = New System.Drawing.Point(156, 424)
        Me.car_r1c2.Margin = New System.Windows.Forms.Padding(2)
        Me.car_r1c2.Name = "car_r1c2"
        Me.car_r1c2.Size = New System.Drawing.Size(60, 22)
        Me.car_r1c2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.car_r1c2.TabIndex = 2
        Me.car_r1c2.TabStop = False
        '
        'car_r1c3
        '
        Me.car_r1c3.BackColor = System.Drawing.Color.Transparent
        Me.car_r1c3.Image = CType(resources.GetObject("car_r1c3.Image"), System.Drawing.Image)
        Me.car_r1c3.Location = New System.Drawing.Point(392, 424)
        Me.car_r1c3.Margin = New System.Windows.Forms.Padding(2)
        Me.car_r1c3.Name = "car_r1c3"
        Me.car_r1c3.Size = New System.Drawing.Size(60, 22)
        Me.car_r1c3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.car_r1c3.TabIndex = 3
        Me.car_r1c3.TabStop = False
        '
        'car_r2c1
        '
        Me.car_r2c1.BackColor = System.Drawing.Color.Transparent
        Me.car_r2c1.Image = CType(resources.GetObject("car_r2c1.Image"), System.Drawing.Image)
        Me.car_r2c1.Location = New System.Drawing.Point(13, 390)
        Me.car_r2c1.Margin = New System.Windows.Forms.Padding(2)
        Me.car_r2c1.Name = "car_r2c1"
        Me.car_r2c1.Size = New System.Drawing.Size(79, 24)
        Me.car_r2c1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.car_r2c1.TabIndex = 4
        Me.car_r2c1.TabStop = False
        '
        'car_r2c2
        '
        Me.car_r2c2.BackColor = System.Drawing.Color.Transparent
        Me.car_r2c2.Image = CType(resources.GetObject("car_r2c2.Image"), System.Drawing.Image)
        Me.car_r2c2.Location = New System.Drawing.Point(163, 390)
        Me.car_r2c2.Margin = New System.Windows.Forms.Padding(2)
        Me.car_r2c2.Name = "car_r2c2"
        Me.car_r2c2.Size = New System.Drawing.Size(79, 24)
        Me.car_r2c2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.car_r2c2.TabIndex = 5
        Me.car_r2c2.TabStop = False
        '
        'car_r2c3
        '
        Me.car_r2c3.BackColor = System.Drawing.Color.Transparent
        Me.car_r2c3.Image = CType(resources.GetObject("car_r2c3.Image"), System.Drawing.Image)
        Me.car_r2c3.Location = New System.Drawing.Point(444, 390)
        Me.car_r2c3.Margin = New System.Windows.Forms.Padding(2)
        Me.car_r2c3.Name = "car_r2c3"
        Me.car_r2c3.Size = New System.Drawing.Size(79, 24)
        Me.car_r2c3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.car_r2c3.TabIndex = 6
        Me.car_r2c3.TabStop = False
        '
        'Player
        '
        Me.Player.Image = CType(resources.GetObject("Player.Image"), System.Drawing.Image)
        Me.Player.Location = New System.Drawing.Point(195, 484)
        Me.Player.Name = "Player"
        Me.Player.Size = New System.Drawing.Size(36, 36)
        Me.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Player.TabIndex = 7
        Me.Player.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(463, 525)
        Me.Controls.Add(Me.Player)
        Me.Controls.Add(Me.car_r2c3)
        Me.Controls.Add(Me.car_r2c2)
        Me.Controls.Add(Me.car_r2c1)
        Me.Controls.Add(Me.car_r1c3)
        Me.Controls.Add(Me.car_r1c2)
        Me.Controls.Add(Me.car_r1c1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.Text = "Frogger"
        CType(Me.car_r1c1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.car_r1c2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.car_r1c3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.car_r2c1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.car_r2c2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.car_r2c3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Tick As Timer
    Friend WithEvents GameTick As Timer
    Friend WithEvents car_r1c1 As PictureBox
    Friend WithEvents car_r1c2 As PictureBox
    Friend WithEvents car_r1c3 As PictureBox
    Friend WithEvents car_r2c1 As PictureBox
    Friend WithEvents car_r2c2 As PictureBox
    Friend WithEvents car_r2c3 As PictureBox
    Friend WithEvents Player As PictureBox
End Class
