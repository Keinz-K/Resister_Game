Imports 抵抗色あてゲーム.Form1
Module _4_And_5_Mode
    Dim resist_value As String
    Dim row1, row2, row3, row5 As Integer
    Const Msgbox_title As String = "抵抗色あてゲーム"
    Dim stick As Bitmap
    Sub Textbox1_GotFocus()
        Form1.TextBox1.Text = ""
        Form1.TextBox1.ForeColor = Color.Black
        Form1.ImeMode = ImeMode.Disable
        Form1.TextBox1.ImeMode = ImeMode.Disable
    End Sub
    Sub Fivemode_Click()
        Form1.Text = "抵抗色あてゲーム - 5色帯モード"
        Form1.Title_Panel.Visible = False
        Form1.C_row(4).Visible = True
        Form1.FreeMode_Screen.Visible = True
        Form1.FreeMode_Screen.Controls.Add(Form1.Return_label)
        Form1.FreeMode_Screen.Controls.Add(Form1.Panel2)
        Form1.Panel2.BackColor = Form1.Panel2.Parent.BackColor
        Score_reset()
        Color_rnd_Five()
        Default_textbox()
    End Sub
    Sub Freemode_Click()
        Form1.Text = "抵抗色あてゲーム - フリーモード"
        Form1.Title_Panel.Visible = False
        Form1.FreeMode_Screen.Visible = True
        Form1.Panel2.BackColor = Form1.Panel2.Parent.BackColor
        Form1.FreeMode_Screen.Controls.Add(Form1.Return_label)
        Form1.FreeMode_Screen.Controls.Add(Form1.Panel2)
        Form1.Panel2.BackColor = Form1.Panel2.Parent.BackColor
        Score_reset()
        Color_rnd_Four()
        Default_textbox()
        Form1.C_row(4).Visible = False
    End Sub
    Sub Gosa_Click()
        Form1.Text = "抵抗色あてゲーム - 誤差選択モード"
        Color_rnd_Four()
        Score_reset()
        Form1.Title_Panel.Visible = False
        Form1.Random_mode.Visible = True
        Form1.Random_mode.Controls.Add(Form1.Return_label)
        Form1.Random_mode.Controls.Add(Form1.Panel2)
        Form1.Panel2.BackColor = Form1.Panel2.Parent.BackColor
        Form1.Judge_4_5()
    End Sub
    Sub How_Play_Click()
        Form1.Title_Panel.Visible = False
        Form1.How_play_panel.Visible = True
        Form1.How_play_panel.Controls.Add(Form1.Return_label)
        Form1.Text = "抵抗色あてゲーム - 遊び方"
    End Sub
    Sub Retuen_Label_click()
        Form1.Text = "抵抗色あてゲーム - タイトル"
        If Form1.FreeMode_Screen.Visible = True Then
            Form1.FreeMode_Screen.Visible = False
            Form1.Title_Panel.Visible = True
            Form1.TextBox1.Enabled = False
        ElseIf Form1.How_play_panel.Visible = True Then
            Form1.How_play_panel.Visible = False
            Form1.Title_Panel.Visible = True
        ElseIf Form1.Random_mode.Visible = True Then
            Form1.Random_mode.Visible = False
            Form1.Title_Panel.Visible = True
        End If
    End Sub

    Private Sub HorizonalAlignCenter(control As Control, y As Integer)
        control.Location = New Point(control.Parent.Width / 2 - control.Width / 2, y)
    End Sub
    Sub Form_Load_Setting()
        Form1.Text = "抵抗色あてゲーム - タイトル"
        Dim default_point As New Point(50, 50)
        Form1.Resist_body.Controls.Add(Form1.PictureBox1)
        Form1.Title_Panel.Location = default_point
        Form1.PictureBox1.BackColor = Color.White
        Form1.FreeMode_Screen.Location = default_point
        Form1.How_play_panel.Location = default_point
        Form1.Random_mode.Location = default_point
        HorizonalAlignCenter(Form1.Title, Form1.Title.Location.Y)
        HorizonalAlignCenter(Form1.Freemode_l, 90)
        HorizonalAlignCenter(Form1.How_play, 150)
        Form1.Size = New Size(100 + Form1.Title_Panel.Width, Form1.Title_Panel.Height + 130)
        Form1.Resist_body.BackColor = Color.BurlyWood
        Form1.Label1.Text = "ランダムに変わる抵抗の帯に対応した値を入力しよう!" & vbCrLf & "入力した後にEnterを押して正解を確認しよう!" & vbCrLf & "正解するとスコアが加算されるよ!" & vbCrLf & "目指せスコア1万点!"
        Form1.Label1.Location = New Point(30, 30)
        Form1.Resist_body.Location = New Point(Form1.PictureBox1.Location.X + Form1.PictureBox1.Width / 2 - Form1.Resist_body.Width / 2, Form1.PictureBox1.Location.Y + Form1.PictureBox1.Height / 2 - Form1.Resist_body.Height / 2)
        HorizonalAlignCenter(Form1.Five_l, 110)
        HorizonalAlignCenter(Form1.Gosa_l, 130)
        Form1.Panel2.BackColor = Form1.Panel2.Parent.BackColor
        Form1.C_row(0) = Form1.L_1
        Form1.C_row(1) = Form1.L_2
        Form1.C_row(2) = Form1.L_3
        Form1.C_row(3) = Form1.L_4
        Form1.C_row(4) = Form1.L_5
        Form1.Panel2.Controls.Add(Form1.PictureBox1)
        stick = New Bitmap(Form1.PictureBox1.Width, Form1.PictureBox1.Height)
        Dim img_ As Graphics = Graphics.FromImage(stick)
        Dim brush As New SolidBrush(Color.Gray)
        Dim a As Single = Form1.PictureBox1.Height / 2 - 10
        Dim c As Integer = 20
        Dim b As Integer = Form1.PictureBox1.Width
        img_.FillRectangle(brush, 0, a, b, c)
        img_.Dispose()
        brush.Dispose()
        Form1.PictureBox1.Image = stick
        Form1.Button_4(0) = Form1.B_1
        Form1.Button_4(1) = Form1.B_2
        Form1.Button_4(2) = Form1.B_3
        Form1.Button_4(3) = Form1.B_4
    End Sub
    Sub Score_reset()
        'MsgBox("reset")
        Form1.Score_0.Text = "0"
        Form1.Score_1.Text = "0"
    End Sub
    Sub Default_textbox()
        Form1.TextBox1.Enabled = True
        Form1.TextBox1.ForeColor = Color.Gray
        Form1.TextBox1.Text = "ここに値を入力"
    End Sub
    Sub Color_rnd_Five()
        Dim i As Integer
        Form1.L_5.Visible = True
        For i = 0 To 4
            Form1.C_row(i).Width = 26 * 2 / 3
            Form1.C_row(i).Location = New Point((32) * 2 / 3 * i + 7 * 2 / 3, 0)
        Next
        row1 = _4_And_5_Mode.C_one()
        row2 = _4_And_5_Mode.C_two()
        row3 = _4_And_5_Mode.C_three_5()
        Form1.range = _4_And_5_Mode.C_four_5()
        row5 = _4_And_5_Mode.C_five()
    End Sub
    Sub Textbox1_Keypress(a As Integer)
        If a = 13 And Form1.C_row(4).Visible = False Then 'Enterを押したとき 入力の正誤判定→入力欄の操作
            Value_judge_Four()
            Color_rnd_Four()
        ElseIf a = 13 And Form1.C_row(4).Visible = True Then
            Value_judge_Five()
            Color_rnd_Five()
        End If
    End Sub
    Sub Color_rnd_Four()
        Dim i As Integer
        Form1.L_5.Visible = False
        For i = 0 To 3
            Form1.C_row(i).Width = 31 * 2 / 3  '*2/3を入れることで、編集時のスケーリングの都合でレイアウトの不一致が発生しないようにパラメータをいじっている
            Form1.C_row(i).Location = New Point((41) * 2 / 3 * i + 7 * 2 / 3, 0)
        Next
        row1 = C_one()
        row2 = C_two()
        row3 = C_three()
        Form1.range = C_four()
    End Sub
    Sub Value_judge_Four()
        Dim v As Single = Val(row1 & row2)
        resist_value = Math.Round(v * Math.Pow(10, row3), 2) '小数点が浮上する問題があったため追加。計算の過程で小数点第2位以下は出てこないため2桁目で四捨五入(0以外出てこないので実質切り捨て
        If Form1.TextBox1.Text = resist_value Then
            MsgBox("正解", vbOKOnly, Msgbox_title)
            Form1.TextBox1.Text = ""
            Form1.Score_0.Text += 1
            Form1.Score_1.Text += 1
        Else
            If (row3 >= 0) Then
                MsgBox("違います" & vbCrLf &
                   "Submit-value: " & vbTab & Form1.TextBox1.Text & vbCrLf &
                   "Answer:" & vbTab & resist_value &
                   "(" & Math.Round(resist_value / Math.Pow(10, row3), 1) & "E+" & row3 & ")", vbOKOnly, Msgbox_title)
                Form1.TextBox1.Text = ""
                Form1.Score_1.Text = "0"
            Else
                MsgBox("違います" & vbCrLf &
                   "Submit-value: " & vbTab & Form1.TextBox1.Text & vbCrLf &
                   "Answer:" & vbTab & resist_value &
                   "(" & Math.Round(resist_value / Math.Pow(10, row3), 1) & "E" & row3 & ")", vbOKOnly, Msgbox_title)
                Form1.TextBox1.Text = ""
                Form1.Score_1.Text = "0"
            End If
        End If
    End Sub
    Sub Value_judge_Five()
        Dim v As Integer = Val(row1 & row2 & row5)
        resist_value = Math.Round(v * Math.Pow(10, row3), 2) '小数点が浮上する問題があったため追加。計算の過程で小数点第2位以下は出てこないため2桁目で四捨五入(0以外出てこないので実質切り捨て
        If Form1.TextBox1.Text = resist_value Then
            MsgBox("正解", vbOKOnly, Msgbox_title)
            Form1.TextBox1.Text = ""
            Form1.Score_0.Text += 1
            Form1.Score_1.Text += 1
        Else
            If (row3 >= 0) Then
                MsgBox("違います" & vbCrLf &
                   "Submit-value: " & vbTab & Form1.TextBox1.Text & vbCrLf &
                   "Answer:" & vbTab & resist_value &
                   "(" & Math.Round(resist_value / Math.Pow(10, row3), 1) & "E+" & row3 & ")", vbOKOnly, Msgbox_title)
                Form1.TextBox1.Text = ""
                Form1.Score_1.Text = "0"
            Else
                MsgBox("違います" & vbCrLf &
                   "Submit-value: " & vbTab & Form1.TextBox1.Text & vbCrLf &
                   "Answer:" & vbTab & resist_value &
                   "(" & Math.Round(resist_value / Math.Pow(10, row3), 1) & "E" & row3 & ")", vbOKOnly, Msgbox_title)
                Form1.TextBox1.Text = ""
                Form1.Score_1.Text = "0"
            End If
        End If
    End Sub
    Function C_one() As Integer
        Dim num_R As Integer = 10 - 1
        Dim i As Integer = Randbetween(1, num_R)
        Select Case i
            'Case 1 '
            '    Form1.L_1.BackColor = Color.Black
            '    Exit Select
            Case 1
                Form1.L_1.BackColor = Color.Brown
            Case 2
                Form1.L_1.BackColor = Color.Red
            Case 3
                Form1.L_1.BackColor = Color.Orange
            Case 4
                Form1.L_1.BackColor = Color.Yellow
            Case 5
                Form1.L_1.BackColor = Color.Green
            Case 6
                Form1.L_1.BackColor = Color.Blue
            Case 7
                Form1.L_1.BackColor = Color.Purple
            Case 8
                Form1.L_1.BackColor = Color.Gray
            Case 9
                Form1.L_1.BackColor = Color.White
        End Select
        C_one = i
    End Function
    Function C_two() As Integer
        Dim num_R As Integer = 10
        Dim i As Integer = Randbetween(1, num_R)
        Select Case i
            Case 1
                Form1.L_2.BackColor = Color.Black
            Case 2
                Form1.L_2.BackColor = Color.Brown
            Case 3
                Form1.L_2.BackColor = Color.Red
            Case 4
                Form1.L_2.BackColor = Color.Orange
            Case 5
                Form1.L_2.BackColor = Color.Yellow
            Case 6
                Form1.L_2.BackColor = Color.Green
            Case 7
                Form1.L_2.BackColor = Color.Blue
            Case 8
                Form1.L_2.BackColor = Color.Purple
            Case 9
                Form1.L_2.BackColor = Color.Gray
            Case 10
                Form1.L_2.BackColor = Color.White
        End Select
        C_two = i - 1
    End Function
    Function C_five() As Integer '3
        Dim num_R As Integer = 10
        Dim i As Integer = Randbetween(1, num_R)
        Select Case i
            Case 1
                Form1.L_3.BackColor = Color.Black
            Case 2
                Form1.L_3.BackColor = Color.Brown
            Case 3
                Form1.L_3.BackColor = Color.Red
            Case 4
                Form1.L_3.BackColor = Color.Orange
            Case 5
                Form1.L_3.BackColor = Color.Yellow
            Case 6
                Form1.L_3.BackColor = Color.Green
            Case 7
                Form1.L_3.BackColor = Color.Blue
            Case 8
                Form1.L_3.BackColor = Color.Purple
            Case 9
                Form1.L_3.BackColor = Color.Gray
            Case 10
                Form1.L_3.BackColor = Color.White
        End Select
        C_five = i - 1
    End Function
    Function C_three() As Integer  '乗数
        Dim num_R As Integer = 10
        Dim i As Integer = Randbetween(1, num_R)
        Select Case i
            Case 1
                Form1.L_3.BackColor = Color.Black
                C_three = i - 1
            Case 2
                Form1.L_3.BackColor = Color.Brown
                C_three = i - 1
            Case 3
                Form1.L_3.BackColor = Color.Red
                C_three = i - 1
            Case 4
                Form1.L_3.BackColor = Color.Orange
                C_three = i - 1
            Case 5
                Form1.L_3.BackColor = Color.Yellow
                C_three = i - 1
            Case 6
                Form1.L_3.BackColor = Color.Green
                C_three = i - 1
            Case 7
                Form1.L_3.BackColor = Color.Blue
                C_three = i - 1
            Case 8
                Form1.L_3.BackColor = Color.Purple
                C_three = i - 1
            Case 9 ' C_three = -1
                Form1.L_3.BackColor = Color.Gold
                C_three = -1
            Case 10 ' C_three = -2
                Form1.L_3.BackColor = Color.Silver
                C_three = -2
        End Select
        Return C_three
    End Function
    Function C_three_5() As Integer  '乗数
        Dim num_R As Integer = 10
        Dim i As Integer = Randbetween(1, num_R)
        Select Case i
            Case 1
                Form1.L_4.BackColor = Color.Black
                C_three_5 = i - 1
            Case 2
                Form1.L_4.BackColor = Color.Brown
                C_three_5 = i - 1
            Case 3
                Form1.L_4.BackColor = Color.Red
                C_three_5 = i - 1
            Case 4
                Form1.L_4.BackColor = Color.Orange
                C_three_5 = i - 1
            Case 5
                Form1.L_4.BackColor = Color.Yellow
                C_three_5 = i - 1
            Case 6
                Form1.L_4.BackColor = Color.Green
                C_three_5 = i - 1
            Case 7
                Form1.L_4.BackColor = Color.Blue
                C_three_5 = i - 1
            Case 8
                Form1.L_4.BackColor = Color.Purple
                C_three_5 = i - 1
            Case 9
                Form1.L_4.BackColor = Color.Gold
                C_three_5 = -1
            Case 10
                Form1.L_4.BackColor = Color.Silver
                C_three_5 = -2
        End Select
        Return C_three_5
    End Function
    Function C_four() As String  '許容差
        Dim num_R As Integer = 8 '9
        Dim i As Integer = Randbetween(1, num_R)
        Select Case i
            Case 1
                Form1.L_4.BackColor = Color.Brown
                C_four = "±1%"
            Case 2
                Form1.L_4.BackColor = Color.Red
                C_four = "±2%"
            Case 3
                Form1.L_4.BackColor = Color.Gray
                C_four = "±0.05%"
            Case 4
                Form1.L_4.BackColor = Color.Green
                C_four = "±0.5%"
            Case 5
                Form1.L_4.BackColor = Color.Blue
                C_four = "±0.25%"
            Case 6
                Form1.L_4.BackColor = Color.Purple
                C_four = "±0.1%"
            Case 7
                Form1.L_4.BackColor = Color.Gold
                C_four = "±5%"
            Case 8
                Form1.L_4.BackColor = Color.Silver
                C_four = "±10%"
                'Case 9 '未確認の為コメント化
                '    Form1.L_4.BackColor = Form1.Resist_body.BackColor
                '    C_four = "±20%"
            Case Else
                C_four = ""
        End Select

    End Function
    Function C_four_Label() As String  '許容差
        Dim num_R As Integer = 8 '9
        Dim i As Integer = Randbetween(1, num_R)
        Select Case i
            Case 1
                Form1.L_4.BackColor = Color.Brown
                C_four_Label = "±1%"
            Case 2
                Form1.L_4.BackColor = Color.Red
                C_four_Label = "±2%"
            Case 3
                Form1.L_4.BackColor = Color.Gray
                C_four_Label = "±0.05%"
            Case 4
                Form1.L_4.BackColor = Color.Green
                C_four_Label = "±0.5%"
            Case 5
                Form1.L_4.BackColor = Color.Blue
                C_four_Label = "±0.25%"
            Case 6
                Form1.L_4.BackColor = Color.Purple
                C_four_Label = "±0.1%"
            Case 7
                Form1.L_4.BackColor = Color.Gold
                C_four_Label = "±5%"
            Case 8
                Form1.L_4.BackColor = Color.Silver
                C_four_Label = "±10%"
                'Case 9 '未確認の為コメント化
                '    Form1.L_4.BackColor = Form1.Resist_body.BackColor
                '    C_four_Label = "±20%"
            Case Else
                C_four_Label = ""
        End Select
    End Function

    Function C_four_5_Label() As String '許容差
        Dim num_R As Integer = 8 '9
        Dim i As Integer = Randbetween(1, num_R)
        Select Case i
            Case 1
                Form1.L_5.BackColor = Color.Brown
                C_four_5_Label = "±1%"
            Case 2
                Form1.L_5.BackColor = Color.Red
                C_four_5_Label = "±2%"
            Case 3
                Form1.L_5.BackColor = Color.Gray
                C_four_5_Label = "±0.05%"
            Case 4
                Form1.L_5.BackColor = Color.Green
                C_four_5_Label = "±0.5%"
            Case 5
                Form1.L_5.BackColor = Color.Blue
                C_four_5_Label = "±0.25%"
            Case 6
                Form1.L_5.BackColor = Color.Purple
                C_four_5_Label = "±0.1%"
            Case 7
                Form1.L_5.BackColor = Color.Gold
                C_four_5_Label = "±5%"
            Case 8
                Form1.L_5.BackColor = Color.Silver
                C_four_5_Label = "±10%"
                'Case 9
                '    Form1.L_5.BackColor = Form1.Resist_body.BackColor
                '    C_four_5 = "±20%"
            Case Else
                C_four_5_Label = ""
        End Select
    End Function
    'aaa
    Function C_four_5() As String '許容差
        Dim num_R As Integer = 8 '9
        Dim i As Integer = Randbetween(1, num_R)
        Select Case i
            Case 1
                Form1.L_5.BackColor = Color.Brown
                C_four_5 = "±1%"
            Case 2
                Form1.L_5.BackColor = Color.Red
                C_four_5 = "±2%"
            Case 3
                Form1.L_5.BackColor = Color.Gray
                C_four_5 = "±0.05%"
            Case 4
                Form1.L_5.BackColor = Color.Green
                C_four_5 = "±0.5%"
            Case 5
                Form1.L_5.BackColor = Color.Blue
                C_four_5 = "±0.25%"
            Case 6
                Form1.L_5.BackColor = Color.Purple
                C_four_5 = "±0.1%"
            Case 7
                Form1.L_5.BackColor = Color.Gold
                C_four_5 = "±5%"
            Case 8
                Form1.L_5.BackColor = Color.Silver
                C_four_5 = "±10%"
                'Case 9
                '    Form1.L_5.BackColor = Form1.Resist_body.BackColor
                '    C_four_5 = "±20%"
            Case Else
                C_four_5 = ""
        End Select
    End Function
    Function Randbetween(min_value As Integer, max_value As Integer) As Integer
        Dim a As Integer = max_value - min_value
        Dim i As Integer
        Dim r As Single = Rnd()
        Dim j As Integer
        If (a <= 0) Then
            'MyBase.Close()
            MsgBox("使い方が違います!")
        Else
            For i = min_value To max_value Step 1
                j += 1
                If (1 / a * j >= r) Then
                    Exit For
                End If
            Next
        End If
        Return j
    End Function
End Module
