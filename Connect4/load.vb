Public Class load

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        'Timer1.Interval = "100"

        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Me.Hide()
            Connect4.Show()
            Timer1.Stop()
        End If
    End Sub

    Private Sub load_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class