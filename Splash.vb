Public Class Splash


    Dim n As Integer



    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        n = n + 1
        lblload.Text = " Loading " & n & "%"

        pb1.Value = pb1.Value + 1
        If n = 100 Then
            Timer1.Stop()
            Login.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblload.Text = " "
        n = 0
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If n Mod 2 = 0 Then
            lblload.ForeColor = Color.Navy
            lblload.BackColor = Color.Yellow

        Else
            lblload.ForeColor = Color.Yellow
            lblload.BackColor = Color.Navy


        End If
    End Sub
End Class