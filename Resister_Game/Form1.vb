Public Class Form1
    Public range As String
    Public C_row(5) As Panel
    Public Button_4(4) As Label
    Dim j As Integer
    Private Sub Freemode_Click() Handles Freemode_l.Click
        _4_And_5_Mode.Freemode_Click()
    End Sub
    Private Sub How_play_Click() Handles How_play.Click
        _4_And_5_Mode.How_Play_Click()
    End Sub
    Private Sub Form1_Load() Handles MyBase.Load
        _4_And_5_Mode.Form_Load_Setting()
        Gosa_l.Visible = False
    End Sub
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        Dim a As Integer = Asc(e.KeyChar)
        _4_And_5_Mode.Textbox1_Keypress(a)
    End Sub
    Private Sub Return_Click() Handles Return_label.Click
        _4_And_5_Mode.Retuen_Label_click()
    End Sub
    Private Sub Five_Click() Handles Five_l.Click
        _4_And_5_Mode.Fivemode_Click()
    End Sub
    Private Sub Change_4_Click() Handles Change_4.Click
        _4_And_5_Mode.Color_rnd_Four()
        _4_And_5_Mode.Score_reset()
    End Sub
    Private Sub Change_5_Click() Handles Change_5.Click
        _4_And_5_Mode.Color_rnd_Five()
        _4_And_5_Mode.Score_reset()
    End Sub
    Private Sub Gosa_l_Click() Handles Gosa_l.Click
        _4_And_5_Mode.Gosa_Click()
    End Sub
    Private Sub TextBox1_GotFocus() Handles TextBox1.GotFocus
        _4_And_5_Mode.Textbox1_GotFocus()
    End Sub
    Sub Judge_4_5()
        Dim i As Integer
        If (L_5.Visible = False) Then
            _4_And_5_Mode.Color_rnd_Four()
            For i = 1 To 4
                Button_4(i - 1).Text = _4_And_5_Mode.C_four_Label()
            Next
            i = _4_And_5_Mode.Randbetween(1, 4)
            Button_4(i - 1).Text = range
        ElseIf (L_5.Visible = True) Then
            _4_And_5_Mode.Color_rnd_Five()
            For i = 1 To 4
                Button_4(i - 1).Text = _4_And_5_Mode.C_four_5_Label()
            Next
            i = _4_And_5_Mode.Randbetween(1, 4)
            Button_4(i - 1).Text = range
        End If
        'いずれかの選択肢の値が一致するとき
        'If (Button_4(0).Text = range Or Button_4(1).Text = range Or Button_4(2).Text = range Or Button_4(3).Text = range) Then


        'End If
        j = i
    End Sub
    Private Sub B_1_Click() Handles B_1.Click
        Dim c As Integer = 1
        If (c = j) Then
            MsgBox("正解")
        Else
            MsgBox("不正解")
        End If
        Judge_4_5()
    End Sub
    Private Sub B_2_Click() Handles B_2.Click
        Dim c As Integer = 2
        If (c = j) Then
            MsgBox("正解")
        Else
            MsgBox("不正解")
        End If
        Judge_4_5()
    End Sub
    Private Sub B_3_Click() Handles B_3.Click
        Dim c As Integer = 3
        If (c = j) Then
            MsgBox("正解")
        Else
            MsgBox("不正解")
        End If
        Judge_4_5()
    End Sub
    Private Sub B_4_Click() Handles B_4.Click
        Dim c As Integer = 4
        If (c = j) Then
            MsgBox("正解")
        Else
            MsgBox("不正解")
        End If
        Judge_4_5()
    End Sub
End Class
