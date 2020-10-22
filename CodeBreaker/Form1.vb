Imports System.Threading.Tasks
Imports System.Timers

Public Class Form1
    Dim max_value As Integer
    Dim secret_num As Integer
    Dim guess As Integer
    Dim start_time As DateTime
    Dim end_time As DateTime
    Dim elapsed_time As TimeSpan

    Dim Generator As System.Random = New System.Random()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Label4.Text = "Please enter the maximum for the random number."
        EnterBtn.Enabled = False
    End Sub


    Sub ButtonInterface(ByRef value As Integer)
        If value <= 9 Then
            Label2.Text = Label2.Text & value
        ElseIf value = 11 Then
            If OptionBtn.Text = "RESTART" Then
                Label2.Text = ""
                OptionBtn.Text = "START"
                Dim num_btns = New Button() {Button1, Button2, Button3, Button4, Button5, Button6, Button7, Button8, Button9, Button10}
                For Each ctl As Button In num_btns
                    ctl.Enabled = True
                Next
            ElseIf Integer.TryParse(Label2.Text, max_value) Then
                'max_value = Convert.ToInt32(Label2.Text)
                secret_num = Generator.Next(0, max_value)
                Label2.Text = ""
                OptionBtn.Text = "RESTART"
                EnterBtn.Enabled = True
                Label3.Text = ""
                start_time = Now
            End If
        ElseIf value = 12 And Integer.TryParse(Label2.Text, guess) Then
            'guess = Convert.ToInt32(Label2.Text)
            Label2.Text = ""
            If guess < secret_num Then
                Label3.Text = "Higher"
            ElseIf guess > secret_num Then
                Label3.Text = "Lower"
            Else
                end_time = Now
                elapsed_time = end_time.Subtract(start_time)
                Label3.Text = "Code Cracked"
                Label4.Text = "Score: " & elapsed_time.TotalSeconds.ToString("0.000") & "s"
                Dim num_btns = New Button() {Button1, Button2, Button3, Button4, Button5, Button6, Button7, Button8, Button9, Button10, EnterBtn}
                For Each ctl As Button In num_btns
                    ctl.Enabled = False
                Next

            End If

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ButtonInterface(1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ButtonInterface(2)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ButtonInterface(3)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ButtonInterface(4)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ButtonInterface(5)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ButtonInterface(6)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ButtonInterface(7)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ButtonInterface(8)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        ButtonInterface(9)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        ButtonInterface(0)
    End Sub

    Private Sub OptionBtn_Click(sender As Object, e As EventArgs) Handles OptionBtn.Click
        ButtonInterface(11)
    End Sub

    Private Sub EnterBtn_Click(sender As Object, e As EventArgs) Handles EnterBtn.Click
        ButtonInterface(12)
    End Sub

End Class