Public Class Connect4

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
   
        If Button1.Enabled = True Then

            lblpick.Visible = True
            lstcolors.Visible = True
            lblplayer2.Visible = True
        End If
        lblplayer1.Visible = False
    End Sub


    Private Sub Connect4_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lstcolors.Items.Add("Red")
        lstcolors.Items.Add("Yellow")
    End Sub

    Private Sub lstcolors_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstcolors.SelectedIndexChanged
        Select Case lstcolors.SelectedItem
            Case Is = "Red"
                Button1.BackColor = Color.Red
            Case Is = "Yellow"
                Button1.BackColor = Color.Yellow
        End Select
    End Sub
End Class
