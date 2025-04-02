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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Title = New Label()
        Freemode_l = New Label()
        How_play = New Label()
        Title_Panel = New Panel()
        Gosa_l = New Label()
        Five_l = New Label()
        FreeMode_Screen = New Panel()
        Panel2 = New Panel()
        Resist_body = New Panel()
        L_5 = New Panel()
        L_3 = New Panel()
        L_4 = New Panel()
        L_2 = New Panel()
        L_1 = New Panel()
        PictureBox1 = New PictureBox()
        Label4 = New Label()
        Score_0 = New Label()
        Label5 = New Label()
        Score_1 = New Label()
        Return_label = New Label()
        TextBox1 = New TextBox()
        How_play_panel = New Panel()
        Label1 = New Label()
        Random_mode = New Panel()
        Change_5 = New Label()
        Change_4 = New Label()
        B_4 = New Label()
        B_3 = New Label()
        B_2 = New Label()
        B_1 = New Label()
        Title_Panel.SuspendLayout()
        FreeMode_Screen.SuspendLayout()
        Panel2.SuspendLayout()
        Resist_body.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        How_play_panel.SuspendLayout()
        Random_mode.SuspendLayout()
        SuspendLayout()
        ' 
        ' Title
        ' 
        Title.AutoSize = True
        Title.BackColor = SystemColors.ControlLightLight
        Title.Font = New Font("Yu Gothic UI", 25F)
        Title.Location = New Point(23, 30)
        Title.Margin = New Padding(2, 0, 2, 0)
        Title.Name = "Title"
        Title.Size = New Size(250, 46)
        Title.TabIndex = 0
        Title.Text = "抵抗色あてゲーム"
        ' 
        ' Freemode_l
        ' 
        Freemode_l.AutoSize = True
        Freemode_l.BackColor = SystemColors.ButtonHighlight
        Freemode_l.Location = New Point(89, 85)
        Freemode_l.Margin = New Padding(2, 0, 2, 0)
        Freemode_l.Name = "Freemode_l"
        Freemode_l.Size = New Size(102, 15)
        Freemode_l.TabIndex = 1
        Freemode_l.Text = "はじめる(フリーモード)"
        ' 
        ' How_play
        ' 
        How_play.AutoSize = True
        How_play.BackColor = SystemColors.ButtonHighlight
        How_play.Location = New Point(125, 154)
        How_play.Margin = New Padding(2, 0, 2, 0)
        How_play.Name = "How_play"
        How_play.Size = New Size(41, 15)
        How_play.TabIndex = 2
        How_play.Text = "遊び方"
        ' 
        ' Title_Panel
        ' 
        Title_Panel.BackColor = SystemColors.ActiveCaption
        Title_Panel.Controls.Add(Gosa_l)
        Title_Panel.Controls.Add(Five_l)
        Title_Panel.Controls.Add(How_play)
        Title_Panel.Controls.Add(Title)
        Title_Panel.Controls.Add(Freemode_l)
        Title_Panel.Location = New Point(9, 61)
        Title_Panel.Margin = New Padding(0)
        Title_Panel.Name = "Title_Panel"
        Title_Panel.Size = New Size(315, 180)
        Title_Panel.TabIndex = 3
        ' 
        ' Gosa_l
        ' 
        Gosa_l.AutoSize = True
        Gosa_l.BackColor = Color.White
        Gosa_l.ForeColor = Color.Black
        Gosa_l.Location = New Point(108, 132)
        Gosa_l.Margin = New Padding(2, 0, 2, 0)
        Gosa_l.Name = "Gosa_l"
        Gosa_l.Size = New Size(126, 15)
        Gosa_l.TabIndex = 4
        Gosa_l.Text = "はじめる(誤差選択モード)"
        ' 
        ' Five_l
        ' 
        Five_l.AutoSize = True
        Five_l.BackColor = Color.White
        Five_l.ForeColor = Color.Black
        Five_l.Location = New Point(129, 109)
        Five_l.Margin = New Padding(2, 0, 2, 0)
        Five_l.Name = "Five_l"
        Five_l.Size = New Size(108, 15)
        Five_l.TabIndex = 3
        Five_l.Text = "はじめる(5色帯モード)"
        ' 
        ' FreeMode_Screen
        ' 
        FreeMode_Screen.BackColor = Color.Chocolate
        FreeMode_Screen.Controls.Add(Panel2)
        FreeMode_Screen.Controls.Add(Return_label)
        FreeMode_Screen.Controls.Add(TextBox1)
        FreeMode_Screen.Location = New Point(31, 26)
        FreeMode_Screen.Margin = New Padding(2)
        FreeMode_Screen.Name = "FreeMode_Screen"
        FreeMode_Screen.Size = New Size(315, 180)
        FreeMode_Screen.TabIndex = 4
        FreeMode_Screen.Visible = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(Resist_body)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Score_0)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Score_1)
        Panel2.Location = New Point(0, 0)
        Panel2.Margin = New Padding(2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(313, 139)
        Panel2.TabIndex = 10
        ' 
        ' Resist_body
        ' 
        Resist_body.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Resist_body.Controls.Add(L_5)
        Resist_body.Controls.Add(L_3)
        Resist_body.Controls.Add(L_4)
        Resist_body.Controls.Add(L_2)
        Resist_body.Controls.Add(L_1)
        Resist_body.Location = New Point(46, 94)
        Resist_body.Margin = New Padding(2)
        Resist_body.Name = "Resist_body"
        Resist_body.Size = New Size(114, 50)
        Resist_body.TabIndex = 10
        ' 
        ' L_5
        ' 
        L_5.BackColor = Color.Black
        L_5.Location = New Point(107, 10)
        L_5.Margin = New Padding(2)
        L_5.Name = "L_5"
        L_5.Size = New Size(22, 50)
        L_5.TabIndex = 11
        ' 
        ' L_3
        ' 
        L_3.BackColor = Color.Black
        L_3.Location = New Point(57, 0)
        L_3.Margin = New Padding(2)
        L_3.Name = "L_3"
        L_3.Size = New Size(22, 50)
        L_3.TabIndex = 9
        ' 
        ' L_4
        ' 
        L_4.BackColor = Color.Black
        L_4.Location = New Point(82, 0)
        L_4.Margin = New Padding(2)
        L_4.Name = "L_4"
        L_4.Size = New Size(22, 50)
        L_4.TabIndex = 9
        ' 
        ' L_2
        ' 
        L_2.BackColor = Color.Black
        L_2.Location = New Point(31, 0)
        L_2.Margin = New Padding(2)
        L_2.Name = "L_2"
        L_2.Size = New Size(22, 50)
        L_2.TabIndex = 9
        ' 
        ' L_1
        ' 
        L_1.BackColor = Color.Black
        L_1.Location = New Point(5, 0)
        L_1.Margin = New Padding(2)
        L_1.Name = "L_1"
        L_1.Size = New Size(22, 50)
        L_1.TabIndex = 8
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(86, 10)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(160, 68)
        PictureBox1.TabIndex = 12
        PictureBox1.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(264, 10)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(33, 15)
        Label4.TabIndex = 2
        Label4.Text = "スコア"
        ' 
        ' Score_0
        ' 
        Score_0.AutoSize = True
        Score_0.Location = New Point(274, 40)
        Score_0.Margin = New Padding(2, 0, 2, 0)
        Score_0.Name = "Score_0"
        Score_0.Size = New Size(13, 15)
        Score_0.TabIndex = 7
        Score_0.Text = "0"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(10, 10)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(67, 15)
        Label5.TabIndex = 3
        Label5.Text = "連続正解数"
        ' 
        ' Score_1
        ' 
        Score_1.AutoSize = True
        Score_1.Location = New Point(30, 40)
        Score_1.Margin = New Padding(2, 0, 2, 0)
        Score_1.Name = "Score_1"
        Score_1.Size = New Size(31, 15)
        Score_1.TabIndex = 6
        Score_1.Text = "0000"
        ' 
        ' Return_label
        ' 
        Return_label.AutoSize = True
        Return_label.BackColor = SystemColors.ActiveCaption
        Return_label.Font = New Font("Yu Gothic UI", 16F)
        Return_label.Location = New Point(11, 140)
        Return_label.Margin = New Padding(2, 0, 2, 0)
        Return_label.Name = "Return_label"
        Return_label.Size = New Size(136, 30)
        Return_label.TabIndex = 9
        Return_label.Text = "タイトルへ戻る"
        ' 
        ' TextBox1
        ' 
        TextBox1.ImeMode = ImeMode.Off
        TextBox1.Location = New Point(96, 94)
        TextBox1.Margin = New Padding(2)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(106, 23)
        TextBox1.TabIndex = 5
        ' 
        ' How_play_panel
        ' 
        How_play_panel.BackColor = SystemColors.AppWorkspace
        How_play_panel.Controls.Add(Label1)
        How_play_panel.Location = New Point(74, 8)
        How_play_panel.Margin = New Padding(2)
        How_play_panel.Name = "How_play_panel"
        How_play_panel.Size = New Size(315, 180)
        How_play_panel.TabIndex = 3
        How_play_panel.Visible = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(34, 18)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 15)
        Label1.TabIndex = 0
        Label1.Text = "Label1"
        ' 
        ' Random_mode
        ' 
        Random_mode.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        Random_mode.Controls.Add(Change_5)
        Random_mode.Controls.Add(Change_4)
        Random_mode.Controls.Add(B_4)
        Random_mode.Controls.Add(B_3)
        Random_mode.Controls.Add(B_2)
        Random_mode.Controls.Add(B_1)
        Random_mode.Location = New Point(10, 15)
        Random_mode.Margin = New Padding(2)
        Random_mode.Name = "Random_mode"
        Random_mode.Size = New Size(315, 180)
        Random_mode.TabIndex = 5
        Random_mode.Visible = False
        ' 
        ' Change_5
        ' 
        Change_5.AutoSize = True
        Change_5.Location = New Point(238, 151)
        Change_5.Margin = New Padding(2, 0, 2, 0)
        Change_5.Name = "Change_5"
        Change_5.Size = New Size(58, 15)
        Change_5.TabIndex = 5
        Change_5.Text = "5本に変更"
        ' 
        ' Change_4
        ' 
        Change_4.AutoSize = True
        Change_4.Location = New Point(158, 151)
        Change_4.Margin = New Padding(2, 0, 2, 0)
        Change_4.Name = "Change_4"
        Change_4.Size = New Size(58, 15)
        Change_4.TabIndex = 4
        Change_4.Text = "4本に変更"
        ' 
        ' B_4
        ' 
        B_4.AutoSize = True
        B_4.Font = New Font("Yu Gothic UI", 10.8F)
        B_4.Location = New Point(150, 116)
        B_4.Margin = New Padding(2, 0, 2, 0)
        B_4.Name = "B_4"
        B_4.Size = New Size(53, 20)
        B_4.TabIndex = 3
        B_4.Text = "Label7"
        ' 
        ' B_3
        ' 
        B_3.AutoSize = True
        B_3.Font = New Font("Yu Gothic UI", 10.8F)
        B_3.Location = New Point(86, 116)
        B_3.Margin = New Padding(2, 0, 2, 0)
        B_3.Name = "B_3"
        B_3.Size = New Size(53, 20)
        B_3.TabIndex = 2
        B_3.Text = "Label6"
        ' 
        ' B_2
        ' 
        B_2.AutoSize = True
        B_2.Font = New Font("Yu Gothic UI", 10.8F)
        B_2.Location = New Point(150, 91)
        B_2.Margin = New Padding(2, 0, 2, 0)
        B_2.Name = "B_2"
        B_2.Size = New Size(53, 20)
        B_2.TabIndex = 1
        B_2.Text = "Label3"
        ' 
        ' B_1
        ' 
        B_1.AutoSize = True
        B_1.Font = New Font("Yu Gothic UI", 10.8F)
        B_1.Location = New Point(86, 91)
        B_1.Margin = New Padding(2, 0, 2, 0)
        B_1.Name = "B_1"
        B_1.Size = New Size(53, 20)
        B_1.TabIndex = 0
        B_1.Text = "Label2"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(397, 249)
        Controls.Add(FreeMode_Screen)
        Controls.Add(Random_mode)
        Controls.Add(How_play_panel)
        Controls.Add(Title_Panel)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(2)
        MaximizeBox = False
        MdiChildrenMinimizedAnchorBottom = False
        MinimizeBox = False
        Name = "Form1"
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.Manual
        Text = "抵抗色あてゲーム"
        Title_Panel.ResumeLayout(False)
        Title_Panel.PerformLayout()
        FreeMode_Screen.ResumeLayout(False)
        FreeMode_Screen.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Resist_body.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        How_play_panel.ResumeLayout(False)
        How_play_panel.PerformLayout()
        Random_mode.ResumeLayout(False)
        Random_mode.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Title As Label
    Friend WithEvents Freemode_l As Label
    Friend WithEvents How_play As Label
    Friend WithEvents Title_Panel As Panel
    Friend WithEvents FreeMode_Screen As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents How_play_panel As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Score_0 As Label
    Friend WithEvents Score_1 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Return_label As Label
    Friend WithEvents Five_l As Label
    Friend WithEvents Gosa_l As Label
    Friend WithEvents Random_mode As Panel
    Friend WithEvents B_4 As Label
    Friend WithEvents B_3 As Label
    Friend WithEvents B_2 As Label
    Friend WithEvents B_1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Change_5 As Label
    Friend WithEvents Change_4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Resist_body As Panel
    Friend WithEvents L_5 As Panel
    Friend WithEvents L_3 As Panel
    Friend WithEvents L_4 As Panel
    Friend WithEvents L_2 As Panel
    Friend WithEvents L_1 As Panel
End Class
