<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4Wall = New System.Windows.Forms.PictureBox()
        Me.PictureBox5Wall = New System.Windows.Forms.PictureBox()
        Me.PictureBox6Wall = New System.Windows.Forms.PictureBox()
        Me.Wall = New System.Windows.Forms.PictureBox()
        Me.Wall1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4Wall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5Wall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6Wall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wall1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.WindowsApp2.My.Resources.Resources.cropedreddood
        Me.PictureBox3.Location = New System.Drawing.Point(899, 152)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(74, 75)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.WindowsApp2.My.Resources.Resources.smallbullet
        Me.PictureBox2.Location = New System.Drawing.Point(167, 198)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(60, 29)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.WindowsApp2.My.Resources.Resources.cropedpacmanpng
        Me.PictureBox1.Location = New System.Drawing.Point(57, 161)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(85, 91)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox4Wall
        '
        Me.PictureBox4Wall.Location = New System.Drawing.Point(0, -2)
        Me.PictureBox4Wall.Name = "PictureBox4Wall"
        Me.PictureBox4Wall.Size = New System.Drawing.Size(1010, 10)
        Me.PictureBox4Wall.TabIndex = 3
        Me.PictureBox4Wall.TabStop = False
        '
        'PictureBox5Wall
        '
        Me.PictureBox5Wall.Location = New System.Drawing.Point(0, -2)
        Me.PictureBox5Wall.Name = "PictureBox5Wall"
        Me.PictureBox5Wall.Size = New System.Drawing.Size(10, 400)
        Me.PictureBox5Wall.TabIndex = 4
        Me.PictureBox5Wall.TabStop = False
        '
        'PictureBox6Wall
        '
        Me.PictureBox6Wall.Location = New System.Drawing.Point(0, 388)
        Me.PictureBox6Wall.Name = "PictureBox6Wall"
        Me.PictureBox6Wall.Size = New System.Drawing.Size(1015, 10)
        Me.PictureBox6Wall.TabIndex = 5
        Me.PictureBox6Wall.TabStop = False
        '
        'Wall
        '
        Me.Wall.BackColor = System.Drawing.Color.Black
        Me.Wall.Location = New System.Drawing.Point(321, -2)
        Me.Wall.Name = "Wall"
        Me.Wall.Size = New System.Drawing.Size(54, 102)
        Me.Wall.TabIndex = 10
        Me.Wall.TabStop = False
        '
        'Wall1
        '
        Me.Wall1.BackColor = System.Drawing.Color.Black
        Me.Wall1.Location = New System.Drawing.Point(321, 288)
        Me.Wall1.Name = "Wall1"
        Me.Wall1.Size = New System.Drawing.Size(54, 110)
        Me.Wall1.TabIndex = 11
        Me.Wall1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApp2.My.Resources.Resources.newbackround
        Me.ClientSize = New System.Drawing.Size(1010, 392)
        Me.Controls.Add(Me.Wall1)
        Me.Controls.Add(Me.Wall)
        Me.Controls.Add(Me.PictureBox6Wall)
        Me.Controls.Add(Me.PictureBox5Wall)
        Me.Controls.Add(Me.PictureBox4Wall)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4Wall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5Wall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6Wall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wall1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox4Wall As PictureBox
    Friend WithEvents PictureBox5Wall As PictureBox
    Friend WithEvents PictureBox6Wall As PictureBox
    Friend WithEvents Wall As PictureBox
    Friend WithEvents Wall1 As PictureBox
End Class
