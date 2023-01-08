Option Explicit On
Public Class Connect4
    'Inyambae N. Kanu 
    'started 07/03/11
    'last updated '03/04/11

    Private Sub Connect4_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        lblred.Visible = False 'this is to set the lables to false
        lblyellow.Visible = False
        pnlconnect4.BackColor = Color.Blue
        lstcolors.Items.Add("Red")
        lstcolors.Items.Add("Yellow")
        lstcolors.Visible = True
        grpconnect4.Visible = False

        'From buttons8 upwards to button42 are enabled false until user enables the buttons 1 to 7
        Button8.Enabled = False
        Button9.Enabled = False
        Button10.Enabled = False
        Button11.Enabled = False
        Button12.Enabled = False
        Button13.Enabled = False
        Button14.Enabled = False
        Button15.Enabled = False
        Button16.Enabled = False
        Button17.Enabled = False
        Button18.Enabled = False
        Button19.Enabled = False
        Button20.Enabled = False
        Button21.Enabled = False
        Button22.Enabled = False
        Button23.Enabled = False
        Button24.Enabled = False
        Button25.Enabled = False
        Button26.Enabled = False
        Button27.Enabled = False
        Button28.Enabled = False
        Button29.Enabled = False
        Button30.Enabled = False
        Button31.Enabled = False
        Button32.Enabled = False
        Button33.Enabled = False
        Button34.Enabled = False
        Button35.Enabled = False
        Button36.Enabled = False
        Button37.Enabled = False
        Button38.Enabled = False
        Button39.Enabled = False
        Button40.Enabled = False
        Button41.Enabled = False
        Button42.Enabled = False
      
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            grpconnect4.Visible = True
        Else
            grpconnect4.Visible = False

        End If


    End Sub

    Private Sub NewGameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewGameToolStripMenuItem.Click
        'resets the scores aswell
        lblyellowwin.Text = 0
        lblredwin.Text = 0
        'all buttons set to white 
        Button1.BackColor = Color.White
        Button2.BackColor = Color.White
        Button3.BackColor = Color.White
        Button4.BackColor = Color.White
        Button5.BackColor = Color.White
        Button6.BackColor = Color.White
        Button7.BackColor = Color.White
        Button8.BackColor = Color.White
        Button9.BackColor = Color.White
        Button10.BackColor = Color.White
        Button11.BackColor = Color.White
        Button12.BackColor = Color.White
        Button13.BackColor = Color.White
        Button14.BackColor = Color.White
        Button15.BackColor = Color.White
        Button16.BackColor = Color.White
        Button17.BackColor = Color.White
        Button18.BackColor = Color.White
        Button19.BackColor = Color.White
        Button20.BackColor = Color.White
        Button21.BackColor = Color.White
        Button22.BackColor = Color.White
        Button23.BackColor = Color.White
        Button24.BackColor = Color.White
        Button25.BackColor = Color.White
        Button26.BackColor = Color.White
        Button27.BackColor = Color.White
        Button28.BackColor = Color.White
        Button29.BackColor = Color.White
        Button30.BackColor = Color.White
        Button31.BackColor = Color.White
        Button32.BackColor = Color.White
        Button33.BackColor = Color.White
        Button34.BackColor = Color.White
        Button35.BackColor = Color.White
        Button36.BackColor = Color.White
        Button37.BackColor = Color.White
        Button38.BackColor = Color.White
        Button39.BackColor = Color.White
        Button40.BackColor = Color.White
        Button41.BackColor = Color.White
        Button42.BackColor = Color.White


        'bottom button set to true 
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = True

        'From buttons8 upwards to button42 are enabled false until user enables the buttons 1 to 7
        Button8.Enabled = False
        Button9.Enabled = False
        Button10.Enabled = False
        Button11.Enabled = False
        Button12.Enabled = False
        Button13.Enabled = False
        Button14.Enabled = False
        Button15.Enabled = False
        Button16.Enabled = False
        Button17.Enabled = False
        Button18.Enabled = False
        Button19.Enabled = False
        Button20.Enabled = False
        Button21.Enabled = False
        Button22.Enabled = False
        Button23.Enabled = False
        Button24.Enabled = False
        Button25.Enabled = False
        Button26.Enabled = False
        Button27.Enabled = False
        Button28.Enabled = False
        Button29.Enabled = False
        Button30.Enabled = False
        Button31.Enabled = False
        Button32.Enabled = False
        Button33.Enabled = False
        Button34.Enabled = False
        Button35.Enabled = False
        Button36.Enabled = False
        Button37.Enabled = False
        Button38.Enabled = False
        Button39.Enabled = False
        Button40.Enabled = False
        Button41.Enabled = False
        Button42.Enabled = False

    End Sub


    Private Sub PlayAgainToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlayAgainToolStripMenuItem.Click
        'all buttons set to white 
        Button1.BackColor = Color.White
        Button2.BackColor = Color.White
        Button3.BackColor = Color.White
        Button4.BackColor = Color.White
        Button5.BackColor = Color.White
        Button6.BackColor = Color.White
        Button7.BackColor = Color.White
        Button8.BackColor = Color.White
        Button9.BackColor = Color.White
        Button10.BackColor = Color.White
        Button11.BackColor = Color.White
        Button12.BackColor = Color.White
        Button13.BackColor = Color.White
        Button14.BackColor = Color.White
        Button15.BackColor = Color.White
        Button16.BackColor = Color.White
        Button17.BackColor = Color.White
        Button18.BackColor = Color.White
        Button19.BackColor = Color.White
        Button20.BackColor = Color.White
        Button21.BackColor = Color.White
        Button22.BackColor = Color.White
        Button23.BackColor = Color.White
        Button24.BackColor = Color.White
        Button25.BackColor = Color.White
        Button26.BackColor = Color.White
        Button27.BackColor = Color.White
        Button28.BackColor = Color.White
        Button29.BackColor = Color.White
        Button30.BackColor = Color.White
        Button31.BackColor = Color.White
        Button32.BackColor = Color.White
        Button33.BackColor = Color.White
        Button34.BackColor = Color.White
        Button35.BackColor = Color.White
        Button36.BackColor = Color.White
        Button37.BackColor = Color.White
        Button38.BackColor = Color.White
        Button39.BackColor = Color.White
        Button40.BackColor = Color.White
        Button41.BackColor = Color.White
        Button42.BackColor = Color.White


        'bottom button set to true 
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = True

        'From buttons8 upwards to button42 are enabled false until user enables the buttons 1 to 7
        Button8.Enabled = False
        Button9.Enabled = False
        Button10.Enabled = False
        Button11.Enabled = False
        Button12.Enabled = False
        Button13.Enabled = False
        Button14.Enabled = False
        Button15.Enabled = False
        Button16.Enabled = False
        Button17.Enabled = False
        Button18.Enabled = False
        Button19.Enabled = False
        Button20.Enabled = False
        Button21.Enabled = False
        Button22.Enabled = False
        Button23.Enabled = False
        Button24.Enabled = False
        Button25.Enabled = False
        Button26.Enabled = False
        Button27.Enabled = False
        Button28.Enabled = False
        Button29.Enabled = False
        Button30.Enabled = False
        Button31.Enabled = False
        Button32.Enabled = False
        Button33.Enabled = False
        Button34.Enabled = False
        Button35.Enabled = False
        Button36.Enabled = False
        Button37.Enabled = False
        Button38.Enabled = False
        Button39.Enabled = False
        Button40.Enabled = False
        Button41.Enabled = False
        Button42.Enabled = False



    End Sub

    Private Sub HowToPlayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HowToPlayToolStripMenuItem.Click
        How_To_Play.Show()
        Me.Hide()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click

        If MessageBox.Show("Do You Want To Exit The Program", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Close()  'code to close the form
            End 'closes any execution
        End If


    End Sub

    Private Sub SaveResultToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveResultToolStripMenuItem.Click

        SaveResult.Filter = "Text Files|*.txt|Word files|*.doc|Access|*mdb"
        SaveResult.ShowDialog()

    End Sub

    Private Sub SaveResult_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SaveResult.FileOk
        Dim objWriter As New System.IO.StreamWriter(SaveResult.FileName)
        objWriter.WriteLine(lblredtext.Text)
        objWriter.WriteLine(lblredwin.Text)
        objWriter.WriteLine(lblyellowtext.Text)
        objWriter.WriteLine(lblredwin.Text)
        objWriter.Close()
        MsgBox("Score Saved")

    End Sub

    Private Sub OpenScores_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenScores.FileOk

        'Dim reader As New System.IO.StreamReader(OpenScores.FileName)
        'reader.ReadToEnd()
        'reader.Close()


    End Sub

    Private Sub OpenScoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenScoresToolStripMenuItem.Click
        'code to open files in vb 
        OpenScores.InitialDirectory = "Libraries\Documents"
        OpenScores.Filter = "Text Files|*.txt|Word files|*.doc|Access|*mdb"
        OpenScores.ShowDialog()
        Process.Start(OpenScores.FileName)


    End Sub

    Private Sub Redhorizontalvictory() 'this procedure is the code is to win the game for red horizantal color 
        'The red player wins coding for horizontal

        'the code for different button1 wins 
        If Button1.BackColor = Color.Red And Button2.BackColor = Color.Red And Button3.BackColor = Color.Red And Button4.BackColor = Color.Red Then
            MsgBox("RED PLAYER WINS") 'message to show winner
            lblredwin.Text += 1 'this adds one to what ever text you got in the label
            Call enabledfalse() 'disables all buttons 
        ElseIf Button1.BackColor = Color.Red And Button8.BackColor = Color.Red And Button15.BackColor = Color.Red And Button22.BackColor = Color.Red Then
            MsgBox("RED PLAYER WINS")
            lblredwin.Text += 1
            Call enabledfalse()
        ElseIf Button1.BackColor = Color.Red And Button9.BackColor = Color.Red And Button17.BackColor = Color.Red And Button25.BackColor = Color.Red Then
            MsgBox("RED PLAYER WINS")
            lblredwin.Text += 1
            Call enabledfalse()

            'the code for red horizontal wins buttons 2 to 7
        ElseIf Button2.BackColor = Color.Red And Button3.BackColor = Color.Red And Button4.BackColor = Color.Red And Button5.BackColor = Color.Red Then
            MsgBox("RED PLAYER WINS")
            lblredwin.Text += 1
            Call enabledfalse()
        ElseIf Button3.BackColor = Color.Red And Button4.BackColor = Color.Red And Button5.BackColor = Color.Red And Button6.BackColor = Color.Red Then
            MsgBox("RED PLAYER WINS")
            lblredwin.Text += 1
            Call enabledfalse()
        ElseIf Button4.BackColor = Color.Red And Button5.BackColor = Color.Red And Button6.BackColor = Color.Red And Button7.BackColor = Color.Red Then
            MsgBox("RED PLAYER WINS")
            lblredwin.Text += 1
            Call enabledfalse()

            'the code for red horizontal wins buttons 8 to 14
        ElseIf Button8.BackColor = Color.Red And Button9.BackColor = Color.Red And Button10.BackColor = Color.Red And Button11.BackColor = Color.Red Then
            MsgBox("RED PLAYER WINS")
            lblredwin.Text += 1
            Call enabledfalse()
        ElseIf Button9.BackColor = Color.Red And Button10.BackColor = Color.Red And Button11.BackColor = Color.Red And Button12.BackColor = Color.Red Then
            MsgBox("RED PLAYER WINS")
            lblredwin.Text += 1
            Call enabledfalse()
        ElseIf Button10.BackColor = Color.Red And Button11.BackColor = Color.Red And Button12.BackColor = Color.Red And Button13.BackColor = Color.Red Then
            MsgBox("RED PLAYER WINS")
            lblredwin.Text += 1
            Call enabledfalse()
        ElseIf Button11.BackColor = Color.Red And Button12.BackColor = Color.Red And Button13.BackColor = Color.Red And Button14.BackColor = Color.Red Then
            MsgBox("RED PLAYER WINS")
            lblredwin.Text += 1
            Call enabledfalse()

            'the code for red horizontal wins buttons 15 to 21

        ElseIf Button15.BackColor = Color.Red And Button16.BackColor = Color.Red And Button17.BackColor = Color.Red And Button18.BackColor = Color.Red Then
            MsgBox("RED PLAYER WINS")
            lblredwin.Text += 1
            Call enabledfalse()
        ElseIf Button16.BackColor = Color.Red And Button17.BackColor = Color.Red And Button18.BackColor = Color.Red And Button19.BackColor = Color.Red Then
            MsgBox("RED PLAYER WINS")
            lblredwin.Text += 1
            Call enabledfalse()
        ElseIf Button17.BackColor = Color.Red And Button18.BackColor = Color.Red And Button19.BackColor = Color.Red And Button20.BackColor = Color.Red Then
            MsgBox("RED PLAYER WINS")
            lblredwin.Text += 1
            Call enabledfalse()
        ElseIf Button18.BackColor = Color.Red And Button19.BackColor = Color.Red And Button20.BackColor = Color.Red And Button21.BackColor = Color.Red Then
            MsgBox("RED PLAYER WINS")
            lblredwin.Text += 1
            Call enabledfalse()

            'the code for red horizontal wins buttons 22 to 28

        ElseIf Button22.BackColor = Color.Red And Button23.BackColor = Color.Red And Button24.BackColor = Color.Red And Button25.BackColor = Color.Red Then
            MsgBox("RED PLAYER WINS")
            lblredwin.Text += 1
            Call enabledfalse()
        ElseIf Button23.BackColor = Color.Red And Button24.BackColor = Color.Red And Button25.BackColor = Color.Red And Button26.BackColor = Color.Red Then
            MsgBox("RED PLAYER WINS")
            lblredwin.Text += 1
            Call enabledfalse()
        ElseIf Button24.BackColor = Color.Red And Button25.BackColor = Color.Red And Button26.BackColor = Color.Red And Button27.BackColor = Color.Red Then
            MsgBox("RED PLAYER WINS")
            lblredwin.Text += 1
            Call enabledfalse()
        ElseIf Button25.BackColor = Color.Red And Button26.BackColor = Color.Red And Button27.BackColor = Color.Red And Button28.BackColor = Color.Red Then
            MsgBox("RED PLAYER WINS")
            lblredwin.Text += 1
            Call enabledfalse()

            'the code for red horizontal wins buttons 29 to 35

        ElseIf Button29.BackColor = Color.Red And Button30.BackColor = Color.Red And Button31.BackColor = Color.Red And Button32.BackColor = Color.Red Then
            MsgBox("RED PLAYER WINS")
            lblredwin.Text += 1
            Call enabledfalse()
        ElseIf Button30.BackColor = Color.Red And Button31.BackColor = Color.Red And Button32.BackColor = Color.Red And Button33.BackColor = Color.Red Then
            MsgBox("RED PLAYER WINS")
            lblredwin.Text += 1
            Call enabledfalse()
        ElseIf Button31.BackColor = Color.Red And Button32.BackColor = Color.Red And Button33.BackColor = Color.Red And Button34.BackColor = Color.Red Then
            MsgBox("RED PLAYER WINS")
            lblredwin.Text += 1
            Call enabledfalse()
        ElseIf Button32.BackColor = Color.Red And Button33.BackColor = Color.Red And Button34.BackColor = Color.Red And Button35.BackColor = Color.Red Then
            MsgBox("RED PLAYER WINS")
            lblredwin.Text += 1
            Call enabledfalse()

            'the code for red horizontal wins buttons 36 to 42
        ElseIf Button36.BackColor = Color.Red And Button37.BackColor = Color.Red And Button38.BackColor = Color.Red And Button39.BackColor = Color.Red Then
            MsgBox("RED PLAYER WINS")
            lblredwin.Text += 1
            Call enabledfalse()
        ElseIf Button37.BackColor = Color.Red And Button38.BackColor = Color.Red And Button39.BackColor = Color.Red And Button40.BackColor = Color.Red Then
            MsgBox("RED PLAYER WINS")
            lblredwin.Text += 1
            Call enabledfalse()
        ElseIf Button38.BackColor = Color.Red And Button39.BackColor = Color.Red And Button40.BackColor = Color.Red And Button41.BackColor = Color.Red Then
            MsgBox("RED PLAYER WINS")
            lblredwin.Text += 1
            Call enabledfalse()
        ElseIf Button39.BackColor = Color.Red And Button40.BackColor = Color.Red And Button41.BackColor = Color.Red And Button42.BackColor = Color.Red Then
            MsgBox("RED PLAYER WINS")
            lblredwin.Text += 1
            Call enabledfalse()
        End If

    End Sub

    Private Sub redverticalvictory()
        'code for red vertically

        'the code for red vertical wins buttons 8 to 36
        If Button8.BackColor = Color.Red And Button15.BackColor = Color.Red And Button22.BackColor = Color.Red And Button29.BackColor = Color.Red Then
            MsgBox("RED PLAYER WINS")
            lblredwin.Text += 1
            Call enabledfalse()
        ElseIf Button15.BackColor = Color.Red And Button22.BackColor = Color.Red And Button29.BackColor = Color.Red And Button36.BackColor = Color.Red Then
            MsgBox("RED PLAYER WINS")
            lblredwin.Text += 1
            Call enabledfalse()

            'the code for red vertical wins buttons 2 to 37
        ElseIf Button2.BackColor = Color.Red And Button9.BackColor = Color.Red And Button16.BackColor = Color.Red And Button23.BackColor = Color.Red Then
            MsgBox("RED PLAYER WINS")
            lblredwin.Text += 1
            Call enabledfalse()
        ElseIf Button9.BackColor = Color.Red And Button16.BackColor = Color.Red And Button23.BackColor = Color.Red And Button30.BackColor = Color.Red Then
            MsgBox("RED PLAYER WINS")
            lblredwin.Text += 1
            Call enabledfalse()
        ElseIf Button16.BackColor = Color.Red And Button23.BackColor = Color.Red And Button30.BackColor = Color.Red And Button37.BackColor = Color.Red Then
            MsgBox("RED PLAYER WINS")
            lblredwin.Text += 1
            Call enabledfalse()
      
            'the code for red vertical wins buttons 3 to 38
        ElseIf Button3.BackColor = Color.Red And Button10.BackColor = Color.Red And Button17.BackColor = Color.Red And Button24.BackColor = Color.Red Then
            MsgBox("RED PLAYER WINS")
            lblredwin.Text += 1
            Call enabledfalse()
        ElseIf Button10.BackColor = Color.Red And Button17.BackColor = Color.Red And Button24.BackColor = Color.Red And Button31.BackColor = Color.Red Then
            MsgBox("RED PLAYER WINS")
            lblredwin.Text += 1
            Call enabledfalse()
        ElseIf Button17.BackColor = Color.Red And Button24.BackColor = Color.Red And Button31.BackColor = Color.Red And Button38.BackColor = Color.Red Then
            MsgBox("RED PLAYER WINS")
            lblredwin.Text += 1
            Call enabledfalse()

            'the code for red vertical wins buttons 4 to 39
        ElseIf Button4.BackColor = Color.Red And Button11.BackColor = Color.Red And Button18.BackColor = Color.Red And Button25.BackColor = Color.Red Then
            MsgBox("RED PLAYER WINS")
            lblredwin.Text += 1
            Call enabledfalse()
        ElseIf Button11.BackColor = Color.Red And Button18.BackColor = Color.Red And Button25.BackColor = Color.Red And Button32.BackColor = Color.Red Then
            MsgBox("RED PLAYER WINS")
            lblredwin.Text += 1
            Call enabledfalse()
        ElseIf Button18.BackColor = Color.Red And Button25.BackColor = Color.Red And Button32.BackColor = Color.Red And Button39.BackColor = Color.Red Then
            MsgBox("RED PLAYER WINS")
            lblredwin.Text += 1
            Call enabledfalse()

            'the code for red vertical wins buttons 5 to 40
        ElseIf Button5.BackColor = Color.Red And Button12.BackColor = Color.Red And Button19.BackColor = Color.Red And Button25.BackColor = Color.Red Then
            MsgBox("RED PLAYER WINS")
            lblredwin.Text += 1
            Call enabledfalse()
        ElseIf Button12.BackColor = Color.Red And Button19.BackColor = Color.Red And Button26.BackColor = Color.Red And Button33.BackColor = Color.Red Then
            MsgBox("RED PLAYER WINS")
            lblredwin.Text += 1
            Call enabledfalse()
        ElseIf Button19.BackColor = Color.Red And Button26.BackColor = Color.Red And Button33.BackColor = Color.Red And Button40.BackColor = Color.Red Then
            MsgBox("RED PLAYER WINS")
            lblredwin.Text += 1
            Call enabledfalse()

            'the code for red vertical wins buttons 6 to 41
        ElseIf Button6.BackColor = Color.Red And Button13.BackColor = Color.Red And Button20.BackColor = Color.Red And Button27.BackColor = Color.Red Then
            MsgBox("RED PLAYER WINS")
            lblredwin.Text += 1
            Call enabledfalse()
        ElseIf Button13.BackColor = Color.Red And Button20.BackColor = Color.Red And Button27.BackColor = Color.Red And Button34.BackColor = Color.Red Then
            MsgBox("RED PLAYER WINS")
            lblredwin.Text += 1
            Call enabledfalse()
        ElseIf Button20.BackColor = Color.Red And Button27.BackColor = Color.Red And Button34.BackColor = Color.Red And Button41.BackColor = Color.Red Then
            MsgBox("RED PLAYER WINS")
            lblredwin.Text += 1
            Call enabledfalse()


            'the code for red vertical wins buttons 7 to 42
        ElseIf Button7.BackColor = Color.Red And Button14.BackColor = Color.Red And Button21.BackColor = Color.Red And Button28.BackColor = Color.Red Then
            MsgBox("RED PLAYER WINS")
            lblredwin.Text += 1
            Call enabledfalse()
        ElseIf Button14.BackColor = Color.Red And Button21.BackColor = Color.Red And Button28.BackColor = Color.Red And Button35.BackColor = Color.Red Then
            MsgBox("RED PLAYER WINS")
            lblredwin.Text += 1
            Call enabledfalse()
        ElseIf Button21.BackColor = Color.Red And Button28.BackColor = Color.Red And Button35.BackColor = Color.Red And Button42.BackColor = Color.Red Then
            MsgBox("RED PLAYER WINS")
            lblredwin.Text += 1
            Call enabledfalse()
        End If



    End Sub

    Private Sub reddiagonalvictory()
        'diagonal wins for red
        'the code for red diagonal wins buttons 4 to 29
        If Button4.BackColor = Color.Red And Button10.BackColor = Color.Red And Button16.BackColor = Color.Red And Button22.BackColor = Color.Red Then
            MsgBox("RED PLAYER WINS")
            lblredwin.Text += 1
            Call enabledfalse()
        ElseIf Button5.BackColor = Color.Red And Button11.BackColor = Color.Red And Button17.BackColor = Color.Red And Button23.BackColor = Color.Red Then
            MsgBox("RED PLAYER WINS")
            lblredwin.Text += 1
            Call enabledfalse()
        ElseIf Button11.BackColor = Color.Red And Button17.BackColor = Color.Red And Button23.BackColor = Color.Red And Button29.BackColor = Color.Red Then
            MsgBox("RED PLAYER WINS")
            lblredwin.Text += 1
            Call enabledfalse()

            'the code for red diagonal wins buttons 7 to 37
        ElseIf Button7.BackColor = Color.Red And Button13.BackColor = Color.Red And Button19.BackColor = Color.Red And Button25.BackColor = Color.Red Then
            MsgBox("RED PLAYER WINS")
            lblredwin.Text += 1
            Call enabledfalse()
        ElseIf Button13.BackColor = Color.Red And Button19.BackColor = Color.Red And Button25.BackColor = Color.Red And Button31.BackColor = Color.Red Then
            MsgBox("RED PLAYER WINS")
            lblredwin.Text += 1
            Call enabledfalse()
        ElseIf Button19.BackColor = Color.Red And Button25.BackColor = Color.Red And Button31.BackColor = Color.Red And Button37.BackColor = Color.Red Then
            MsgBox("RED PLAYER WINS")
            lblredwin.Text += 1
            Call enabledfalse()


            'the code for red diagonal wins buttons 14 to 38
        ElseIf Button14.BackColor = Color.Red And Button20.BackColor = Color.Red And Button26.BackColor = Color.Red And Button32.BackColor = Color.Red Then
            MsgBox("RED PLAYER WINS")
            lblredwin.Text += 1
            Call enabledfalse()
        ElseIf Button20.BackColor = Color.Red And Button26.BackColor = Color.Red And Button32.BackColor = Color.Red And Button38.BackColor = Color.Red Then
            MsgBox("RED PLAYER WINS")
            lblredwin.Text += 1
            Call enabledfalse()

            'the code for red diagonal wins buttons 14 to 38
        ElseIf Button21.BackColor = Color.Red And Button27.BackColor = Color.Red And Button33.BackColor = Color.Red And Button39.BackColor = Color.Red Then
            MsgBox("RED PLAYER WINS")
            lblredwin.Text += 1
            Call enabledfalse()


        End If











    End Sub


    Private Sub reddiagonalvictory2()

        'diagonal wins for red other direction
        'the code for red diagonal wins buttons 4 to 28
        If Button4.BackColor = Color.Red And Button12.BackColor = Color.Red And Button20.BackColor = Color.Red And Button28.BackColor = Color.Red Then
            MsgBox("RED PLAYER WINS")
            lblredwin.Text += 1
            Call enabledfalse()

            'the code for red diagonal wins buttons 3 to 35
        ElseIf Button3.BackColor = Color.Red And Button11.BackColor = Color.Red And Button19.BackColor = Color.Red And Button27.BackColor = Color.Red Then
            MsgBox("RED PLAYER WINS")
            lblredwin.Text += 1
            Call enabledfalse()
        ElseIf Button11.BackColor = Color.Red And Button19.BackColor = Color.Red And Button27.BackColor = Color.Red And Button35.BackColor = Color.Red Then
            MsgBox("RED PLAYER WINS")
            lblredwin.Text += 1
            Call enabledfalse()

            'the code for red diagonal wins buttons 2 to 42
        ElseIf Button2.BackColor = Color.Red And Button10.BackColor = Color.Red And Button18.BackColor = Color.Red And Button26.BackColor = Color.Red Then
            MsgBox("RED PLAYER WINS")
            lblredwin.Text += 1
            Call enabledfalse()
        ElseIf Button10.BackColor = Color.Red And Button18.BackColor = Color.Red And Button26.BackColor = Color.Red And Button34.BackColor = Color.Red Then
            MsgBox("RED PLAYER WINS")
            lblredwin.Text += 1
            Call enabledfalse()
        ElseIf Button18.BackColor = Color.Red And Button26.BackColor = Color.Red And Button34.BackColor = Color.Red And Button42.BackColor = Color.Red Then
            MsgBox("RED PLAYER WINS")
            lblredwin.Text += 1
            Call enabledfalse()


            'the code for red diagonal wins buttons 1 to 41
        ElseIf Button1.BackColor = Color.Red And Button9.BackColor = Color.Red And Button17.BackColor = Color.Red And Button25.BackColor = Color.Red Then
            MsgBox("RED PLAYER WINS")
            lblredwin.Text += 1
            Call enabledfalse()
        ElseIf Button9.BackColor = Color.Red And Button17.BackColor = Color.Red And Button25.BackColor = Color.Red And Button33.BackColor = Color.Red Then
            MsgBox("RED PLAYER WINS")
            lblredwin.Text += 1
            Call enabledfalse()
        ElseIf Button17.BackColor = Color.Red And Button25.BackColor = Color.Red And Button33.BackColor = Color.Red And Button41.BackColor = Color.Red Then
            MsgBox("RED PLAYER WINS")
            lblredwin.Text += 1
            Call enabledfalse()

            'the code for red diagonal wins buttons 8 to 40
        ElseIf Button8.BackColor = Color.Red And Button16.BackColor = Color.Red And Button24.BackColor = Color.Red And Button32.BackColor = Color.Red Then
            MsgBox("RED PLAYER WINS")
            lblredwin.Text += 1
            Call enabledfalse()
        ElseIf Button16.BackColor = Color.Red And Button24.BackColor = Color.Red And Button32.BackColor = Color.Red And Button40.BackColor = Color.Red Then
            MsgBox("RED PLAYER WINS")
            lblredwin.Text += 1
            Call enabledfalse()

            'the code for red diagonal wins buttons 15 to 39
        ElseIf Button15.BackColor = Color.Red And Button23.BackColor = Color.Red And Button31.BackColor = Color.Red And Button39.BackColor = Color.Red Then
            MsgBox("RED PLAYER WINS")
            lblredwin.Text += 1
            Call enabledfalse()


        End If





    End Sub


    Private Sub yellowhorizontalvictory()
        'The yellow player wins coding for horizontal

        'the code for different button1 wins 
        If Button1.BackColor = Color.Yellow And Button2.BackColor = Color.Yellow And Button3.BackColor = Color.Yellow And Button4.BackColor = Color.Yellow Then
            MsgBox("YELLOW PLAYER WINS")
            lblyellowwin.Text += 1
            Call enabledfalse()
        ElseIf Button1.BackColor = Color.Yellow And Button8.BackColor = Color.Yellow And Button15.BackColor = Color.Yellow And Button22.BackColor = Color.Yellow Then
            MsgBox("YELLOW PLAYER WINS")
            lblyellowwin.Text += 1
            Call enabledfalse()
        ElseIf Button1.BackColor = Color.Yellow And Button9.BackColor = Color.Yellow And Button17.BackColor = Color.Yellow And Button25.BackColor = Color.Yellow Then
            MsgBox("YELLOW PLAYER WINS")
            lblyellowwin.Text += 1
            Call enabledfalse()

            'the code for yellow horizontal wins buttons 2 to 7
        ElseIf Button2.BackColor = Color.Yellow And Button3.BackColor = Color.Yellow And Button4.BackColor = Color.Yellow And Button5.BackColor = Color.Yellow Then
            MsgBox("YELLOW PLAYER WINS")
            lblyellowwin.Text += 1
            Call enabledfalse()
        ElseIf Button3.BackColor = Color.Yellow And Button4.BackColor = Color.Yellow And Button5.BackColor = Color.Yellow And Button6.BackColor = Color.Yellow Then
            MsgBox("YELLOW PLAYER WINS")
            lblyellowwin.Text += 1
            Call enabledfalse()
        ElseIf Button4.BackColor = Color.Yellow And Button5.BackColor = Color.Yellow And Button6.BackColor = Color.Yellow And Button7.BackColor = Color.Yellow Then
            MsgBox("YELLOW PLAYER WINS")
            lblyellowwin.Text += 1
            Call enabledfalse()

            'the code for yellow horizontal wins buttons 8 to 14
        ElseIf Button8.BackColor = Color.Yellow And Button9.BackColor = Color.Yellow And Button10.BackColor = Color.Yellow And Button11.BackColor = Color.Yellow Then
            MsgBox("YELLOW PLAYER WINS")
            lblyellowwin.Text += 1
            Call enabledfalse()
        ElseIf Button9.BackColor = Color.Yellow And Button10.BackColor = Color.Yellow And Button11.BackColor = Color.Yellow And Button12.BackColor = Color.Yellow Then
            MsgBox("YELLOW PLAYER WINS")
            lblyellowwin.Text += 1
            Call enabledfalse()
        ElseIf Button10.BackColor = Color.Yellow And Button11.BackColor = Color.Yellow And Button12.BackColor = Color.Yellow And Button13.BackColor = Color.Yellow Then
            MsgBox("YELLOW PLAYER WINS")
            lblyellowwin.Text += 1
            Call enabledfalse()
        ElseIf Button11.BackColor = Color.Yellow And Button12.BackColor = Color.Yellow And Button13.BackColor = Color.Yellow And Button14.BackColor = Color.Yellow Then
            MsgBox("YELLOW PLAYER WINS")
            lblyellowwin.Text += 1
            Call enabledfalse()

            'the code for yellow horizontal wins buttons 15 to 21

        ElseIf Button15.BackColor = Color.Yellow And Button16.BackColor = Color.Yellow And Button17.BackColor = Color.Yellow And Button18.BackColor = Color.Yellow Then
            MsgBox("YELLOW PLAYER WINS")
            lblyellowwin.Text += 1
            Call enabledfalse()
        ElseIf Button16.BackColor = Color.Yellow And Button17.BackColor = Color.Yellow And Button18.BackColor = Color.Yellow And Button19.BackColor = Color.Yellow Then
            MsgBox("YELLOW PLAYER WINS")
            lblyellowwin.Text += 1
            Call enabledfalse()
        ElseIf Button17.BackColor = Color.Yellow And Button18.BackColor = Color.Yellow And Button19.BackColor = Color.Yellow And Button20.BackColor = Color.Yellow Then
            MsgBox("YELLOW PLAYER WINS")
            lblyellowwin.Text += 1
            Call enabledfalse()
        ElseIf Button18.BackColor = Color.Yellow And Button19.BackColor = Color.Yellow And Button20.BackColor = Color.Yellow And Button21.BackColor = Color.Yellow Then
            MsgBox("YELLOW PLAYER WINS")
            lblyellowwin.Text += 1
            Call enabledfalse()

            'the code for yellow horizontal wins buttons 22 to 28

        ElseIf Button22.BackColor = Color.Yellow And Button23.BackColor = Color.Yellow And Button24.BackColor = Color.Yellow And Button25.BackColor = Color.Yellow Then
            MsgBox("YELLOW PLAYER WINS")
            lblyellowwin.Text += 1
            Call enabledfalse()
        ElseIf Button23.BackColor = Color.Yellow And Button24.BackColor = Color.Yellow And Button25.BackColor = Color.Yellow And Button26.BackColor = Color.Yellow Then
            MsgBox("YELLOW PLAYER WINS")
            lblyellowwin.Text += 1
            Call enabledfalse()
        ElseIf Button24.BackColor = Color.Yellow And Button25.BackColor = Color.Yellow And Button26.BackColor = Color.Yellow And Button27.BackColor = Color.Yellow Then
            MsgBox("YELLOW PLAYER WINS")
            lblyellowwin.Text += 1
            Call enabledfalse()
        ElseIf Button25.BackColor = Color.Yellow And Button26.BackColor = Color.Yellow And Button27.BackColor = Color.Yellow And Button28.BackColor = Color.Yellow Then
            MsgBox("YELLOW PLAYER WINS")
            lblyellowwin.Text += 1
            Call enabledfalse()

            'the code for yellow horizontal wins buttons 29 to 35

        ElseIf Button29.BackColor = Color.Yellow And Button30.BackColor = Color.Yellow And Button31.BackColor = Color.Yellow And Button32.BackColor = Color.Yellow Then
            MsgBox("YELLOW PLAYER WINS")
            lblyellowwin.Text += 1
            Call enabledfalse()
        ElseIf Button30.BackColor = Color.Yellow And Button31.BackColor = Color.Yellow And Button32.BackColor = Color.Yellow And Button33.BackColor = Color.Yellow Then
            MsgBox("YELLOW PLAYER WINS")
            lblyellowwin.Text += 1
            Call enabledfalse()
        ElseIf Button31.BackColor = Color.Yellow And Button32.BackColor = Color.Yellow And Button33.BackColor = Color.Yellow And Button34.BackColor = Color.Yellow Then
            MsgBox("YELLOW PLAYER WINS")
            lblyellowwin.Text += 1
            Call enabledfalse()
        ElseIf Button32.BackColor = Color.Yellow And Button33.BackColor = Color.Yellow And Button34.BackColor = Color.Yellow And Button35.BackColor = Color.Yellow Then
            MsgBox("YELLOW PLAYER WINS")
            lblyellowwin.Text += 1
            Call enabledfalse()

            'the code for yellow horizontal wins buttons 36 to 42
        ElseIf Button36.BackColor = Color.Yellow And Button37.BackColor = Color.Yellow And Button38.BackColor = Color.Yellow And Button39.BackColor = Color.Yellow Then
            MsgBox("YELLOW PLAYER WINS")
            lblyellowwin.Text += 1
            Call enabledfalse()
        ElseIf Button37.BackColor = Color.Yellow And Button38.BackColor = Color.Yellow And Button39.BackColor = Color.Yellow And Button40.BackColor = Color.Yellow Then
            MsgBox("YELLOW PLAYER WINS")
            lblyellowwin.Text += 1
            Call enabledfalse()
        ElseIf Button38.BackColor = Color.Yellow And Button39.BackColor = Color.Yellow And Button40.BackColor = Color.Yellow And Button41.BackColor = Color.Yellow Then
            MsgBox("YELLOW PLAYER WINS")
            lblyellowwin.Text += 1
            Call enabledfalse()
        ElseIf Button39.BackColor = Color.Yellow And Button40.BackColor = Color.Yellow And Button41.BackColor = Color.Yellow And Button42.BackColor = Color.Yellow Then
            MsgBox("YELLOW PLAYER WINS")
            lblyellowwin.Text += 1
            Call enabledfalse()
        End If






    End Sub

    Private Sub yellowverticalvictory()

        'code for yellow vertically

        'the code for yellow vertical wins buttons 8 to 36
        If Button8.BackColor = Color.Yellow And Button15.BackColor = Color.Yellow And Button22.BackColor = Color.Yellow And Button29.BackColor = Color.Yellow Then
            MsgBox("YELLOW PLAYER WINS")
            lblyellowwin.Text += 1
            Call enabledfalse()
        ElseIf Button15.BackColor = Color.Yellow And Button22.BackColor = Color.Yellow And Button29.BackColor = Color.Yellow And Button36.BackColor = Color.Yellow Then
            MsgBox("YELLOW PLAYER WINS")
            lblyellowwin.Text += 1
            Call enabledfalse()

            'the code for yellow vertical wins buttons 2 to 37
        ElseIf Button2.BackColor = Color.Yellow And Button9.BackColor = Color.Yellow And Button16.BackColor = Color.Yellow And Button23.BackColor = Color.Yellow Then
            MsgBox("YELLOW PLAYER WINS")
            lblyellowwin.Text += 1
            Call enabledfalse()
        ElseIf Button9.BackColor = Color.Yellow And Button16.BackColor = Color.Yellow And Button23.BackColor = Color.Yellow And Button30.BackColor = Color.Yellow Then
            MsgBox("YELLOW PLAYER WINS")
            lblyellowwin.Text += 1
            Call enabledfalse()
        ElseIf Button16.BackColor = Color.Yellow And Button23.BackColor = Color.Yellow And Button30.BackColor = Color.Yellow And Button37.BackColor = Color.Yellow Then
            MsgBox("YELLOW PLAYER WINS")
            lblyellowwin.Text += 1
            Call enabledfalse()

            'the code for yellow vertical wins buttons 3 to 38
        ElseIf Button3.BackColor = Color.Yellow And Button10.BackColor = Color.Yellow And Button17.BackColor = Color.Yellow And Button24.BackColor = Color.Yellow Then
            MsgBox("YELLOW PLAYER WINS")
            lblyellowwin.Text += 1
            Call enabledfalse()
        ElseIf Button10.BackColor = Color.Yellow And Button17.BackColor = Color.Yellow And Button24.BackColor = Color.Yellow And Button31.BackColor = Color.Yellow Then
            MsgBox("YELLOW PLAYER WINS")
            lblyellowwin.Text += 1
            Call enabledfalse()
        ElseIf Button17.BackColor = Color.Yellow And Button24.BackColor = Color.Yellow And Button31.BackColor = Color.Yellow And Button38.BackColor = Color.Yellow Then
            MsgBox("YELLOW PLAYER WINS")
            lblyellowwin.Text += 1
            Call enabledfalse()

            'the code for yellow vertical wins buttons 4 to 39
        ElseIf Button4.BackColor = Color.Yellow And Button11.BackColor = Color.Yellow And Button18.BackColor = Color.Yellow And Button25.BackColor = Color.Yellow Then
            MsgBox("YELLOW PLAYER WINS")
            lblyellowwin.Text += 1
            Call enabledfalse()
        ElseIf Button11.BackColor = Color.Yellow And Button18.BackColor = Color.Yellow And Button25.BackColor = Color.Yellow And Button32.BackColor = Color.Yellow Then
            MsgBox("YELLOW PLAYER WINS")
            lblyellowwin.Text += 1
            Call enabledfalse()
        ElseIf Button18.BackColor = Color.Yellow And Button25.BackColor = Color.Yellow And Button32.BackColor = Color.Yellow And Button39.BackColor = Color.Yellow Then
            MsgBox("YELLOW PLAYER WINS")
            lblyellowwin.Text += 1
            Call enabledfalse()

            'the code for yellow vertical wins buttons 5 to 40
        ElseIf Button5.BackColor = Color.Yellow And Button12.BackColor = Color.Yellow And Button19.BackColor = Color.Yellow And Button25.BackColor = Color.Yellow Then
            MsgBox("YELLOW PLAYER WINS")
            lblyellowwin.Text += 1
            Call enabledfalse()
        ElseIf Button12.BackColor = Color.Yellow And Button19.BackColor = Color.Yellow And Button26.BackColor = Color.Yellow And Button33.BackColor = Color.Yellow Then
            MsgBox("YELLOW PLAYER WINS")
            lblyellowwin.Text += 1
            Call enabledfalse()
        ElseIf Button19.BackColor = Color.Yellow And Button26.BackColor = Color.Yellow And Button33.BackColor = Color.Yellow And Button40.BackColor = Color.Yellow Then
            MsgBox("YELLOW PLAYER WINS")
            lblyellowwin.Text += 1
            Call enabledfalse()

            'the code for yellow vertical wins buttons 6 to 41
        ElseIf Button6.BackColor = Color.Yellow And Button13.BackColor = Color.Yellow And Button20.BackColor = Color.Yellow And Button27.BackColor = Color.Yellow Then
            MsgBox("YELLOW PLAYER WINS")
            lblyellowwin.Text += 1
            Call enabledfalse()
        ElseIf Button13.BackColor = Color.Yellow And Button20.BackColor = Color.Yellow And Button27.BackColor = Color.Yellow And Button34.BackColor = Color.Yellow Then
            MsgBox("YELLOW PLAYER WINS")
            lblyellowwin.Text += 1
            Call enabledfalse()
        ElseIf Button20.BackColor = Color.Yellow And Button27.BackColor = Color.Yellow And Button34.BackColor = Color.Yellow And Button41.BackColor = Color.Yellow Then
            MsgBox("YELLOW PLAYER WINS")
            lblyellowwin.Text += 1
            Call enabledfalse()


            'the code for yellow vertical wins buttons 7 to 42
        ElseIf Button7.BackColor = Color.Yellow And Button14.BackColor = Color.Yellow And Button21.BackColor = Color.Yellow And Button28.BackColor = Color.Yellow Then
            MsgBox("YELLOW PLAYER WINS")
            lblyellowwin.Text += 1
            Call enabledfalse()
        ElseIf Button14.BackColor = Color.Yellow And Button21.BackColor = Color.Yellow And Button28.BackColor = Color.Yellow And Button35.BackColor = Color.Yellow Then
            MsgBox("YELLOW PLAYER WINS")
            lblyellowwin.Text += 1
            Call enabledfalse()
        ElseIf Button21.BackColor = Color.Yellow And Button28.BackColor = Color.Yellow And Button35.BackColor = Color.Yellow And Button42.BackColor = Color.Red Then
            MsgBox("YELLOW PLAYER WINS")
            lblyellowwin.Text += 1
            Call enabledfalse()
        End If





    End Sub

    Private Sub yellowdiagonalvictory()
        'diagonal wins for Yellow
        'the code for Yellow diagonal wins buttons 4 to 29
        If Button4.BackColor = Color.Yellow And Button10.BackColor = Color.Yellow And Button16.BackColor = Color.Yellow And Button22.BackColor = Color.Yellow Then
            MsgBox("YELLOW PLAYER WINS")
            lblyellowwin.Text += 1
            Call enabledfalse()
        ElseIf Button5.BackColor = Color.Yellow And Button11.BackColor = Color.Yellow And Button17.BackColor = Color.Yellow And Button23.BackColor = Color.Yellow Then
            MsgBox("YELLOW PLAYER WINS")
            lblyellowwin.Text += 1
            Call enabledfalse()
        ElseIf Button11.BackColor = Color.Yellow And Button17.BackColor = Color.Yellow And Button23.BackColor = Color.Yellow And Button29.BackColor = Color.Yellow Then
            MsgBox("YELLOW PLAYER WINS")
            lblyellowwin.Text += 1
            Call enabledfalse()

            'the code for Yellow diagonal wins buttons 7 to 37
        ElseIf Button7.BackColor = Color.Yellow And Button13.BackColor = Color.Yellow And Button19.BackColor = Color.Yellow And Button25.BackColor = Color.Yellow Then
            MsgBox("YELLOW PLAYER WINS")
            lblyellowwin.Text += 1
            Call enabledfalse()
        ElseIf Button13.BackColor = Color.Yellow And Button19.BackColor = Color.Yellow And Button25.BackColor = Color.Yellow And Button31.BackColor = Color.Yellow Then
            MsgBox("YELLOW PLAYER WINS")
            lblyellowwin.Text += 1
            Call enabledfalse()
        ElseIf Button19.BackColor = Color.Yellow And Button25.BackColor = Color.Yellow And Button31.BackColor = Color.Yellow And Button37.BackColor = Color.Yellow Then
            MsgBox("YELLOW PLAYER WINS")
            lblyellowwin.Text += 1
            Call enabledfalse()


            'the code for Yellow diagonal wins buttons 14 to 38
        ElseIf Button14.BackColor = Color.Yellow And Button20.BackColor = Color.Yellow And Button26.BackColor = Color.Yellow And Button32.BackColor = Color.Yellow Then
            MsgBox("YELLOW PLAYER WINS")
            lblyellowwin.Text += 1
            Call enabledfalse()
        ElseIf Button20.BackColor = Color.Yellow And Button26.BackColor = Color.Yellow And Button32.BackColor = Color.Yellow And Button38.BackColor = Color.Yellow Then
            MsgBox("YELLOW PLAYER WINS")
            lblyellowwin.Text += 1
            Call enabledfalse()

            'the code for Yellow diagonal wins buttons 14 to 38
        ElseIf Button21.BackColor = Color.Yellow And Button27.BackColor = Color.Yellow And Button33.BackColor = Color.Yellow And Button39.BackColor = Color.Yellow Then
            MsgBox("YELLOW PLAYER WINS")
            lblyellowwin.Text += 1
            Call enabledfalse()


        End If





    End Sub

    Private Sub yellowdiagonalvictory2()

        'diagonal wins for Yellow other direction
        'the code for Yellow diagonal wins buttons 4 to 28
        If Button4.BackColor = Color.Yellow And Button12.BackColor = Color.Yellow And Button20.BackColor = Color.Yellow And Button28.BackColor = Color.Yellow Then
            MsgBox("YELLOW PLAYER WINS")
            lblyellowwin.Text += 1
            Call enabledfalse()

            'the code for Yellow diagonal wins buttons 3 to 35
        ElseIf Button3.BackColor = Color.Yellow And Button11.BackColor = Color.Yellow And Button19.BackColor = Color.Yellow And Button27.BackColor = Color.Yellow Then
            MsgBox("YELLOW PLAYER WINS")
            lblyellowwin.Text += 1
            Call enabledfalse()
        ElseIf Button11.BackColor = Color.Yellow And Button19.BackColor = Color.Yellow And Button27.BackColor = Color.Yellow And Button35.BackColor = Color.Yellow Then
            MsgBox("YELLOW PLAYER WINS")
            lblyellowwin.Text += 1
            Call enabledfalse()

            'the code for Yellow diagonal wins buttons 2 to 42
        ElseIf Button2.BackColor = Color.Yellow And Button10.BackColor = Color.Yellow And Button18.BackColor = Color.Yellow And Button26.BackColor = Color.Yellow Then
            MsgBox("YELLOW PLAYER WINS")
            lblyellowwin.Text += 1
            Call enabledfalse()
        ElseIf Button10.BackColor = Color.Yellow And Button18.BackColor = Color.Yellow And Button26.BackColor = Color.Yellow And Button34.BackColor = Color.Yellow Then
            MsgBox("YELLOW PLAYER WINS")
            lblyellowwin.Text += 1
            Call enabledfalse()
        ElseIf Button18.BackColor = Color.Yellow And Button26.BackColor = Color.Yellow And Button34.BackColor = Color.Yellow And Button42.BackColor = Color.Yellow Then
            MsgBox("YELLOW PLAYER WINS")
            lblyellowwin.Text += 1
            Call enabledfalse()


            'the code for Yellow diagonal wins buttons 1 to 41
        ElseIf Button1.BackColor = Color.Yellow And Button9.BackColor = Color.Yellow And Button17.BackColor = Color.Yellow And Button25.BackColor = Color.Yellow Then
            MsgBox("YELLOW PLAYER WINS")
            lblyellowwin.Text += 1
            Call enabledfalse()
        ElseIf Button9.BackColor = Color.Yellow And Button17.BackColor = Color.Yellow And Button25.BackColor = Color.Yellow And Button33.BackColor = Color.Yellow Then
            MsgBox("YELLOW PLAYER WINS")
            lblyellowwin.Text += 1
            Call enabledfalse()
        ElseIf Button17.BackColor = Color.Yellow And Button25.BackColor = Color.Yellow And Button33.BackColor = Color.Yellow And Button41.BackColor = Color.Yellow Then
            MsgBox("YELLOW PLAYER WINS")
            lblyellowwin.Text += 1
            Call enabledfalse()

            'the code for Yellow diagonal wins buttons 8 to 40
        ElseIf Button8.BackColor = Color.Yellow And Button16.BackColor = Color.Yellow And Button24.BackColor = Color.Yellow And Button32.BackColor = Color.Yellow Then
            MsgBox("YELLOW PLAYER WINS")
            lblyellowwin.Text += 1
            Call enabledfalse()
        ElseIf Button16.BackColor = Color.Yellow And Button24.BackColor = Color.Yellow And Button32.BackColor = Color.Yellow And Button40.BackColor = Color.Yellow Then
            MsgBox("YELLOW PLAYER WINS")
            lblyellowwin.Text += 1
            Call enabledfalse()

            'the code for Yellow diagonal wins buttons 15 to 39
        ElseIf Button15.BackColor = Color.Yellow And Button23.BackColor = Color.Yellow And Button31.BackColor = Color.Yellow And Button39.BackColor = Color.Yellow Then
            MsgBox("YELLOW PLAYER WINS")
            lblyellowwin.Text += 1
            Call enabledfalse()
        End If



    End Sub

    Private Sub enabledfalse()
        'this procedure is sets all your buttons to false when you a Player wins the game 
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False
        Button9.Enabled = False
        Button10.Enabled = False
        Button11.Enabled = False
        Button12.Enabled = False
        Button13.Enabled = False
        Button14.Enabled = False
        Button15.Enabled = False
        Button16.Enabled = False
        Button17.Enabled = False
        Button18.Enabled = False
        Button19.Enabled = False
        Button20.Enabled = False
        Button21.Enabled = False
        Button22.Enabled = False
        Button23.Enabled = False
        Button24.Enabled = False
        Button25.Enabled = False
        Button26.Enabled = False
        Button27.Enabled = False
        Button28.Enabled = False
        Button29.Enabled = False
        Button30.Enabled = False
        Button31.Enabled = False
        Button32.Enabled = False
        Button33.Enabled = False
        Button34.Enabled = False
        Button35.Enabled = False
        Button36.Enabled = False
        Button37.Enabled = False
        Button38.Enabled = False
        Button39.Enabled = False
        Button40.Enabled = False
        Button41.Enabled = False
        Button42.Enabled = False


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If Button1.Enabled = True Then
            Select Case lstcolors.SelectedItem
                Case Is = "Red"
                    Button1.BackColor = Color.Red
                Case Is = "Yellow"
                    Button1.BackColor = Color.Yellow
            End Select
        End If


        If Button1.BackColor = Color.Red Then
            Button8.Enabled = True
            Button1.Enabled = False
            lblred.Visible = False
            lblyellow.Visible = True

        End If
        If Button1.BackColor = Color.Yellow Then
            Button8.Enabled = True
            Button1.Enabled = False
            lblred.Visible = True
            lblyellow.Visible = False
        End If

        'procedures for red wins
        Call Redhorizontalvictory()
        Call redverticalvictory()
        Call reddiagonalvictory()
        Call reddiagonalvictory2()

        'procedures for yeloow wins
        Call yellowhorizontalvictory()
        Call yellowverticalvictory()
        Call yellowdiagonalvictory()
        Call yellowdiagonalvictory2()

        ChangePlayer()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If Button2.Enabled = True Then
            Select Case lstcolors.SelectedItem
                Case Is = "Red"
                    Button2.BackColor = Color.Red
                Case Is = "Yellow"
                    Button2.BackColor = Color.Yellow
            End Select
        End If

        If Button2.BackColor = Color.Red Then
            Button9.Enabled = True
            Button2.Enabled = False
            lblred.Visible = False
            lblyellow.Visible = True
        End If
        If Button2.BackColor = Color.Yellow Then
            Button9.Enabled = True
            Button2.Enabled = False
            lblred.Visible = True
            lblyellow.Visible = False
        End If

        'procedures for red wins
        Call Redhorizontalvictory()
        Call redverticalvictory()
        Call reddiagonalvictory()
        Call reddiagonalvictory2()

        'procedures for yeloow wins
        Call yellowhorizontalvictory()
        Call yellowverticalvictory()
        Call yellowdiagonalvictory()
        Call yellowdiagonalvictory2()

        ChangePlayer()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Button3.Enabled = True Then

            Select Case lstcolors.SelectedItem
                Case Is = "Red"
                    Button3.BackColor = Color.Red
                Case Is = "Yellow"
                    Button3.BackColor = Color.Yellow
            End Select
        End If
        If Button3.BackColor = Color.Red Then
            Button10.Enabled = True
            Button3.Enabled = False
            lblred.Visible = False
            lblyellow.Visible = True
        End If
        If Button3.BackColor = Color.Yellow Then
            Button10.Enabled = True
            Button3.Enabled = False
            lblred.Visible = True
            lblyellow.Visible = False
        End If

        'procedures for red wins
        Call Redhorizontalvictory()
        Call redverticalvictory()
        Call reddiagonalvictory()
        Call reddiagonalvictory2()

        'procedures for yeloow wins
        Call yellowhorizontalvictory()
        Call yellowverticalvictory()
        Call yellowdiagonalvictory()
        Call yellowdiagonalvictory2()

        ChangePlayer()
    End Sub



    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Button4.Enabled = True Then

            Select Case lstcolors.SelectedItem
                Case Is = "Red"
                    Button4.BackColor = Color.Red
                Case Is = "Yellow"
                    Button4.BackColor = Color.Yellow
            End Select
        End If
        If Button4.BackColor = Color.Red Then
            Button11.Enabled = True
            Button4.Enabled = False
            lblred.Visible = False
            lblyellow.Visible = True
        End If
        If Button4.BackColor = Color.Yellow Then
            Button11.Enabled = True
            Button4.Enabled = False
            lblred.Visible = True
            lblyellow.Visible = False
        End If

        'procedures for red wins
        Call Redhorizontalvictory()
        Call redverticalvictory()
        Call reddiagonalvictory()
        Call reddiagonalvictory2()

        'procedures for yeloow wins
        Call yellowhorizontalvictory()
        Call yellowverticalvictory()
        Call yellowdiagonalvictory()
        Call yellowdiagonalvictory2()



    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        If Button5.Enabled = True Then

            Select Case lstcolors.SelectedItem
                Case Is = "Red"
                    Button5.BackColor = Color.Red
                Case Is = "Yellow"
                    Button5.BackColor = Color.Yellow
            End Select
        End If
        If Button5.BackColor = Color.Red Then
            Button12.Enabled = True
            Button5.Enabled = False
            lblred.Visible = False
            lblyellow.Visible = True
        End If
        If Button5.BackColor = Color.Yellow Then
            Button12.Enabled = True
            Button5.Enabled = False
            lblred.Visible = True
            lblyellow.Visible = False
        End If

        'procedures for red wins
        Call Redhorizontalvictory()
        Call redverticalvictory()
        Call reddiagonalvictory()
        Call reddiagonalvictory2()

        'procedures for yeloow wins
        Call yellowhorizontalvictory()
        Call yellowverticalvictory()
        Call yellowdiagonalvictory()
        Call yellowdiagonalvictory2()


    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If Button6.Enabled = True Then

            Select Case lstcolors.SelectedItem
                Case Is = "Red"
                    Button6.BackColor = Color.Red
                Case Is = "Yellow"
                    Button6.BackColor = Color.Yellow
            End Select
        End If
        If Button6.BackColor = Color.Red Then
            Button13.Enabled = True
            Button6.Enabled = False
            lblred.Visible = False
            lblyellow.Visible = True
        End If
        If Button6.BackColor = Color.Yellow Then
            Button13.Enabled = True
            Button6.Enabled = False
            lblred.Visible = True
            lblyellow.Visible = False
        End If

        'procedures for red wins
        Call Redhorizontalvictory()
        Call redverticalvictory()
        Call reddiagonalvictory()
        Call reddiagonalvictory2()

        'procedures for yeloow wins
        Call yellowhorizontalvictory()
        Call yellowverticalvictory()
        Call yellowdiagonalvictory()
        Call yellowdiagonalvictory2()

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If Button7.Enabled = True Then

            Select Case lstcolors.SelectedItem
                Case Is = "Red"
                    Button7.BackColor = Color.Red
                Case Is = "Yellow"
                    Button7.BackColor = Color.Yellow
            End Select
        End If
        If Button7.BackColor = Color.Red Then
            Button14.Enabled = True
            Button7.Enabled = False
            lblred.Visible = False
            lblyellow.Visible = True
        End If
        If Button7.BackColor = Color.Yellow Then
            Button14.Enabled = True
            Button7.Enabled = False
            lblred.Visible = True
            lblyellow.Visible = False
        End If

        'procedures for red wins
        Call Redhorizontalvictory()
        Call redverticalvictory()
        Call reddiagonalvictory()
        Call reddiagonalvictory2()

        'procedures for yeloow wins
        Call yellowhorizontalvictory()
        Call yellowverticalvictory()
        Call yellowdiagonalvictory()
        Call yellowdiagonalvictory2()


    End Sub


    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If Button8.Enabled = True Then

            Select Case lstcolors.SelectedItem
                Case Is = "Red"
                    Button8.BackColor = Color.Red
                Case Is = "Yellow"
                    Button8.BackColor = Color.Yellow
            End Select
        End If
        If Button8.BackColor = Color.Red Then
            Button15.Enabled = True
            Button8.Enabled = False
            lblred.Visible = False
            lblyellow.Visible = True
        End If
        If Button8.BackColor = Color.Yellow Then
            Button15.Enabled = True
            Button8.Enabled = False
            lblred.Visible = True
            lblyellow.Visible = False
        End If

        'procedures for red wins
        Call Redhorizontalvictory()
        Call redverticalvictory()
        Call reddiagonalvictory()
        Call reddiagonalvictory2()

        'procedures for yeloow wins
        Call yellowhorizontalvictory()
        Call yellowverticalvictory()
        Call yellowdiagonalvictory()
        Call yellowdiagonalvictory2()

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        If Button9.Enabled = True Then
            Select Case lstcolors.SelectedItem
                Case Is = "Red"
                    Button9.BackColor = Color.Red
                Case Is = "Yellow"
                    Button9.BackColor = Color.Yellow
            End Select
        End If


        If Button9.BackColor = Color.Red Then
            Button16.Enabled = True
            Button9.Enabled = False
            lblred.Visible = False
            lblyellow.Visible = True

        End If
        If Button9.BackColor = Color.Yellow Then
            Button16.Enabled = True
            Button9.Enabled = False
            lblred.Visible = True
            lblyellow.Visible = False
        End If

        'procedures for red wins
        Call Redhorizontalvictory()
        Call redverticalvictory()
        Call reddiagonalvictory()
        Call reddiagonalvictory2()

        'procedures for yeloow wins
        Call yellowhorizontalvictory()
        Call yellowverticalvictory()
        Call yellowdiagonalvictory()
        Call yellowdiagonalvictory2()



    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        If Button10.Enabled = True Then
            Select Case lstcolors.SelectedItem
                Case Is = "Red"
                    Button10.BackColor = Color.Red
                Case Is = "Yellow"
                    Button10.BackColor = Color.Yellow
            End Select
        End If


        If Button10.BackColor = Color.Red Then
            Button17.Enabled = True
            Button10.Enabled = False
            lblred.Visible = False
            lblyellow.Visible = True

        End If
        If Button10.BackColor = Color.Yellow Then
            Button17.Enabled = True
            Button10.Enabled = False
            lblred.Visible = True
            lblyellow.Visible = False
        End If

        'procedures for red wins
        Call Redhorizontalvictory()
        Call redverticalvictory()
        Call reddiagonalvictory()
        Call reddiagonalvictory2()

        'procedures for yeloow wins
        Call yellowhorizontalvictory()
        Call yellowverticalvictory()
        Call yellowdiagonalvictory()
        Call yellowdiagonalvictory2()



    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click

        If Button11.Enabled = True Then
            Select Case lstcolors.SelectedItem
                Case Is = "Red"
                    Button11.BackColor = Color.Red
                Case Is = "Yellow"
                    Button11.BackColor = Color.Yellow
            End Select
        End If


        If Button11.BackColor = Color.Red Then
            Button18.Enabled = True
            Button11.Enabled = False
            lblred.Visible = False
            lblyellow.Visible = True

        End If
        If Button11.BackColor = Color.Yellow Then
            Button18.Enabled = True
            Button11.Enabled = False
            lblred.Visible = True
            lblyellow.Visible = False
        End If

        'procedures for red wins
        Call Redhorizontalvictory()
        Call redverticalvictory()
        Call reddiagonalvictory()
        Call reddiagonalvictory2()

        'procedures for yeloow wins
        Call yellowhorizontalvictory()
        Call yellowverticalvictory()
        Call yellowdiagonalvictory()
        Call yellowdiagonalvictory2()


    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click

        If Button12.Enabled = True Then
            Select Case lstcolors.SelectedItem
                Case Is = "Red"
                    Button12.BackColor = Color.Red
                Case Is = "Yellow"
                    Button12.BackColor = Color.Yellow
            End Select
        End If


        If Button12.BackColor = Color.Red Then
            Button19.Enabled = True
            Button12.Enabled = False
            lblred.Visible = False
            lblyellow.Visible = True

        End If
        If Button12.BackColor = Color.Yellow Then
            Button19.Enabled = True
            Button12.Enabled = False
            lblred.Visible = True
            lblyellow.Visible = False
        End If

        'procedures for red wins
        Call Redhorizontalvictory()
        Call redverticalvictory()
        Call reddiagonalvictory()
        Call reddiagonalvictory2()

        'procedures for yeloow wins
        Call yellowhorizontalvictory()
        Call yellowverticalvictory()
        Call yellowdiagonalvictory()
        Call yellowdiagonalvictory2()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        If Button13.Enabled = True Then
            Select Case lstcolors.SelectedItem
                Case Is = "Red"
                    Button13.BackColor = Color.Red
                Case Is = "Yellow"
                    Button13.BackColor = Color.Yellow
            End Select
        End If


        If Button13.BackColor = Color.Red Then
            Button20.Enabled = True
            Button13.Enabled = False
            lblred.Visible = False
            lblyellow.Visible = True

        End If
        If Button13.BackColor = Color.Yellow Then
            Button20.Enabled = True
            Button13.Enabled = False
            lblred.Visible = True
            lblyellow.Visible = False
        End If

        'procedures for red wins
        Call Redhorizontalvictory()
        Call redverticalvictory()
        Call reddiagonalvictory()
        Call reddiagonalvictory2()

        'procedures for yeloow wins
        Call yellowhorizontalvictory()
        Call yellowverticalvictory()
        Call yellowdiagonalvictory()
        Call yellowdiagonalvictory2()



    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        If Button14.Enabled = True Then
            Select Case lstcolors.SelectedItem
                Case Is = "Red"
                    Button14.BackColor = Color.Red
                Case Is = "Yellow"
                    Button14.BackColor = Color.Yellow
            End Select
        End If


        If Button14.BackColor = Color.Red Then
            Button21.Enabled = True
            Button14.Enabled = False
            lblred.Visible = False
            lblyellow.Visible = True

        End If
        If Button14.BackColor = Color.Yellow Then
            Button21.Enabled = True
            Button14.Enabled = False
            lblred.Visible = True
            lblyellow.Visible = False
        End If

        'procedures for red wins
        Call Redhorizontalvictory()
        Call redverticalvictory()
        Call reddiagonalvictory()
        Call reddiagonalvictory2()

        'procedures for yeloow wins
        Call yellowhorizontalvictory()
        Call yellowverticalvictory()
        Call yellowdiagonalvictory()
        Call yellowdiagonalvictory2()
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        If Button15.Enabled = True Then
            Select Case lstcolors.SelectedItem
                Case Is = "Red"
                    Button15.BackColor = Color.Red
                Case Is = "Yellow"
                    Button15.BackColor = Color.Yellow
            End Select
        End If


        If Button15.BackColor = Color.Red Then
            Button22.Enabled = True
            Button15.Enabled = False
            lblred.Visible = False
            lblyellow.Visible = True

        End If
        If Button15.BackColor = Color.Yellow Then
            Button22.Enabled = True
            Button15.Enabled = False
            lblred.Visible = True
            lblyellow.Visible = False
        End If

        'procedures for red wins
        Call Redhorizontalvictory()
        Call redverticalvictory()
        Call reddiagonalvictory()
        Call reddiagonalvictory2()

        'procedures for yeloow wins
        Call yellowhorizontalvictory()
        Call yellowverticalvictory()
        Call yellowdiagonalvictory()
        Call yellowdiagonalvictory2()

    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        If Button16.Enabled = True Then
            Select Case lstcolors.SelectedItem
                Case Is = "Red"
                    Button16.BackColor = Color.Red
                Case Is = "Yellow"
                    Button16.BackColor = Color.Yellow
            End Select
        End If


        If Button16.BackColor = Color.Red Then
            Button23.Enabled = True
            Button16.Enabled = False
            lblred.Visible = False
            lblyellow.Visible = True

        End If
        If Button16.BackColor = Color.Yellow Then
            Button23.Enabled = True
            Button16.Enabled = False
            lblred.Visible = True
            lblyellow.Visible = False
        End If

        'procedures for red wins
        Call Redhorizontalvictory()
        Call redverticalvictory()
        Call reddiagonalvictory()
        Call reddiagonalvictory2()

        'procedures for yeloow wins
        Call yellowhorizontalvictory()
        Call yellowverticalvictory()
        Call yellowdiagonalvictory()
        Call yellowdiagonalvictory2()
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        If Button17.Enabled = True Then
            Select Case lstcolors.SelectedItem
                Case Is = "Red"
                    Button17.BackColor = Color.Red
                Case Is = "Yellow"
                    Button17.BackColor = Color.Yellow
            End Select
        End If


        If Button17.BackColor = Color.Red Then
            Button24.Enabled = True
            Button17.Enabled = False
            lblred.Visible = False
            lblyellow.Visible = True

        End If
        If Button17.BackColor = Color.Yellow Then
            Button24.Enabled = True
            Button17.Enabled = False
            lblred.Visible = True
            lblyellow.Visible = False
        End If

        'procedures for red wins
        Call Redhorizontalvictory()
        Call redverticalvictory()
        Call reddiagonalvictory()
        Call reddiagonalvictory2()

        'procedures for yeloow wins
        Call yellowhorizontalvictory()
        Call yellowverticalvictory()
        Call yellowdiagonalvictory()
        Call yellowdiagonalvictory2()
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        If Button18.Enabled = True Then
            Select Case lstcolors.SelectedItem
                Case Is = "Red"
                    Button18.BackColor = Color.Red
                Case Is = "Yellow"
                    Button18.BackColor = Color.Yellow
            End Select
        End If


        If Button18.BackColor = Color.Red Then
            Button25.Enabled = True
            Button18.Enabled = False
            lblred.Visible = False
            lblyellow.Visible = True

        End If
        If Button18.BackColor = Color.Yellow Then
            Button25.Enabled = True
            Button18.Enabled = False
            lblred.Visible = True
            lblyellow.Visible = False
        End If

        'procedures for red wins
        Call Redhorizontalvictory()
        Call redverticalvictory()
        Call reddiagonalvictory()
        Call reddiagonalvictory2()

        'procedures for yeloow wins
        Call yellowhorizontalvictory()
        Call yellowverticalvictory()
        Call yellowdiagonalvictory()
        Call yellowdiagonalvictory2()
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        If Button19.Enabled = True Then
            Select Case lstcolors.SelectedItem
                Case Is = "Red"
                    Button19.BackColor = Color.Red
                Case Is = "Yellow"
                    Button19.BackColor = Color.Yellow
            End Select
        End If


        If Button19.BackColor = Color.Red Then
            Button26.Enabled = True
            Button19.Enabled = False
            lblred.Visible = False
            lblyellow.Visible = True

        End If
        If Button19.BackColor = Color.Yellow Then
            Button26.Enabled = True
            Button19.Enabled = False
            lblred.Visible = True
            lblyellow.Visible = False
        End If

        'procedures for red wins
        Call Redhorizontalvictory()
        Call redverticalvictory()
        Call reddiagonalvictory()
        Call reddiagonalvictory2()

        'procedures for yeloow wins
        Call yellowhorizontalvictory()
        Call yellowverticalvictory()
        Call yellowdiagonalvictory()
        Call yellowdiagonalvictory2()
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        If Button20.Enabled = True Then
            Select Case lstcolors.SelectedItem
                Case Is = "Red"
                    Button20.BackColor = Color.Red
                Case Is = "Yellow"
                    Button20.BackColor = Color.Yellow
            End Select
        End If


        If Button20.BackColor = Color.Red Then
            Button27.Enabled = True
            Button20.Enabled = False
            lblred.Visible = False
            lblyellow.Visible = True

        End If
        If Button20.BackColor = Color.Yellow Then
            Button27.Enabled = True
            Button20.Enabled = False
            lblred.Visible = True
            lblyellow.Visible = False
        End If

        'procedures for red wins
        Call Redhorizontalvictory()
        Call redverticalvictory()
        Call reddiagonalvictory()
        Call reddiagonalvictory2()

        'procedures for yeloow wins
        Call yellowhorizontalvictory()
        Call yellowverticalvictory()
        Call yellowdiagonalvictory()
        Call yellowdiagonalvictory2()
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click

        If Button21.Enabled = True Then
            Select Case lstcolors.SelectedItem
                Case Is = "Red"
                    Button21.BackColor = Color.Red
                Case Is = "Yellow"
                    Button21.BackColor = Color.Yellow
            End Select
        End If


        If Button21.BackColor = Color.Red Then
            Button28.Enabled = True
            Button21.Enabled = False
            lblred.Visible = False
            lblyellow.Visible = True

        End If
        If Button21.BackColor = Color.Yellow Then
            Button28.Enabled = True
            Button21.Enabled = False
            lblred.Visible = True
            lblyellow.Visible = False
        End If

        'procedures for red wins
        Call Redhorizontalvictory()
        Call redverticalvictory()
        Call reddiagonalvictory()
        Call reddiagonalvictory2()

        'procedures for yeloow wins
        Call yellowhorizontalvictory()
        Call yellowverticalvictory()
        Call yellowdiagonalvictory()
        Call yellowdiagonalvictory2()

    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click

        If Button22.Enabled = True Then
            Select Case lstcolors.SelectedItem
                Case Is = "Red"
                    Button22.BackColor = Color.Red
                Case Is = "Yellow"
                    Button22.BackColor = Color.Yellow
            End Select
        End If


        If Button22.BackColor = Color.Red Then
            Button29.Enabled = True
            Button22.Enabled = False
            lblred.Visible = False
            lblyellow.Visible = True

        End If
        If Button22.BackColor = Color.Yellow Then
            Button29.Enabled = True
            Button22.Enabled = False
            lblred.Visible = True
            lblyellow.Visible = False
        End If

        'procedures for red wins
        Call Redhorizontalvictory()
        Call redverticalvictory()
        Call reddiagonalvictory()
        Call reddiagonalvictory2()

        'procedures for yeloow wins
        Call yellowhorizontalvictory()
        Call yellowverticalvictory()
        Call yellowdiagonalvictory()
        Call yellowdiagonalvictory2()

    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        If Button23.Enabled = True Then
            Select Case lstcolors.SelectedItem
                Case Is = "Red"
                    Button23.BackColor = Color.Red
                Case Is = "Yellow"
                    Button23.BackColor = Color.Yellow
            End Select
        End If


        If Button23.BackColor = Color.Red Then
            Button30.Enabled = True
            Button23.Enabled = False
            lblred.Visible = False
            lblyellow.Visible = True

        End If
        If Button23.BackColor = Color.Yellow Then
            Button30.Enabled = True
            Button23.Enabled = False
            lblred.Visible = True
            lblyellow.Visible = False
        End If

        'procedures for red wins
        Call Redhorizontalvictory()
        Call redverticalvictory()
        Call reddiagonalvictory()
        Call reddiagonalvictory2()

        'procedures for yeloow wins
        Call yellowhorizontalvictory()
        Call yellowverticalvictory()
        Call yellowdiagonalvictory()
        Call yellowdiagonalvictory2()
    End Sub

    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click
        If Button24.Enabled = True Then
            Select Case lstcolors.SelectedItem
                Case Is = "Red"
                    Button24.BackColor = Color.Red
                Case Is = "Yellow"
                    Button24.BackColor = Color.Yellow
            End Select
        End If


        If Button24.BackColor = Color.Red Then
            Button31.Enabled = True
            Button24.Enabled = False
            lblred.Visible = False
            lblyellow.Visible = True

        End If
        If Button24.BackColor = Color.Yellow Then
            Button31.Enabled = True
            Button24.Enabled = False
            lblred.Visible = True
            lblyellow.Visible = False
        End If

        'procedures for red wins
        Call Redhorizontalvictory()
        Call redverticalvictory()
        Call reddiagonalvictory()
        Call reddiagonalvictory2()

        'procedures for yeloow wins
        Call yellowhorizontalvictory()
        Call yellowverticalvictory()
        Call yellowdiagonalvictory()
        Call yellowdiagonalvictory2()

    End Sub

    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button25.Click

        If Button25.Enabled = True Then
            Select Case lstcolors.SelectedItem
                Case Is = "Red"
                    Button25.BackColor = Color.Red
                Case Is = "Yellow"
                    Button25.BackColor = Color.Yellow
            End Select
        End If


        If Button25.BackColor = Color.Red Then
            Button32.Enabled = True
            Button25.Enabled = False
            lblred.Visible = False
            lblyellow.Visible = True

        End If
        If Button25.BackColor = Color.Yellow Then
            Button32.Enabled = True
            Button25.Enabled = False
            lblred.Visible = True
            lblyellow.Visible = False
        End If

        'procedures for red wins
        Call Redhorizontalvictory()
        Call redverticalvictory()
        Call reddiagonalvictory()
        Call reddiagonalvictory2()

        'procedures for yeloow wins
        Call yellowhorizontalvictory()
        Call yellowverticalvictory()
        Call yellowdiagonalvictory()
        Call yellowdiagonalvictory2()

    End Sub

    Private Sub Button26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button26.Click
        If Button26.Enabled = True Then
            Select Case lstcolors.SelectedItem
                Case Is = "Red"
                    Button26.BackColor = Color.Red
                Case Is = "Yellow"
                    Button26.BackColor = Color.Yellow
            End Select
        End If


        If Button26.BackColor = Color.Red Then
            Button33.Enabled = True
            Button26.Enabled = False
            lblred.Visible = False
            lblyellow.Visible = True

        End If
        If Button26.BackColor = Color.Yellow Then
            Button33.Enabled = True
            Button26.Enabled = False
            lblred.Visible = True
            lblyellow.Visible = False
        End If

        'procedures for red wins
        Call Redhorizontalvictory()
        Call redverticalvictory()
        Call reddiagonalvictory()
        Call reddiagonalvictory2()

        'procedures for yeloow wins
        Call yellowhorizontalvictory()
        Call yellowverticalvictory()
        Call yellowdiagonalvictory()
        Call yellowdiagonalvictory2()
    End Sub

    Private Sub Button27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button27.Click
        If Button27.Enabled = True Then
            Select Case lstcolors.SelectedItem
                Case Is = "Red"
                    Button27.BackColor = Color.Red
                Case Is = "Yellow"
                    Button27.BackColor = Color.Yellow
            End Select
        End If


        If Button27.BackColor = Color.Red Then
            Button34.Enabled = True
            Button27.Enabled = False
            lblred.Visible = False
            lblyellow.Visible = True

        End If
        If Button27.BackColor = Color.Yellow Then
            Button34.Enabled = True
            Button27.Enabled = False
            lblred.Visible = True
            lblyellow.Visible = False
        End If

        'procedures for red wins
        Call Redhorizontalvictory()
        Call redverticalvictory()
        Call reddiagonalvictory()
        Call reddiagonalvictory2()

        'procedures for yeloow wins
        Call yellowhorizontalvictory()
        Call yellowverticalvictory()
        Call yellowdiagonalvictory()
        Call yellowdiagonalvictory2()
    End Sub

    Private Sub Button28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button28.Click
        If Button28.Enabled = True Then
            Select Case lstcolors.SelectedItem
                Case Is = "Red"
                    Button28.BackColor = Color.Red
                Case Is = "Yellow"
                    Button28.BackColor = Color.Yellow
            End Select
        End If


        If Button28.BackColor = Color.Red Then
            Button35.Enabled = True
            Button28.Enabled = False
            lblred.Visible = False
            lblyellow.Visible = True

        End If
        If Button28.BackColor = Color.Yellow Then
            Button35.Enabled = True
            Button28.Enabled = False
            lblred.Visible = True
            lblyellow.Visible = False
        End If

        'procedures for red wins
        Call Redhorizontalvictory()
        Call redverticalvictory()
        Call reddiagonalvictory()
        Call reddiagonalvictory2()

        'procedures for yeloow wins
        Call yellowhorizontalvictory()
        Call yellowverticalvictory()
        Call yellowdiagonalvictory()
        Call yellowdiagonalvictory2()
    End Sub

    Private Sub Button29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button29.Click
        If Button29.Enabled = True Then
            Select Case lstcolors.SelectedItem
                Case Is = "Red"
                    Button29.BackColor = Color.Red
                Case Is = "Yellow"
                    Button29.BackColor = Color.Yellow
            End Select
        End If


        If Button29.BackColor = Color.Red Then
            Button36.Enabled = True
            Button29.Enabled = False
            lblred.Visible = False
            lblyellow.Visible = True

        End If
        If Button29.BackColor = Color.Yellow Then
            Button36.Enabled = True
            Button29.Enabled = False
            lblred.Visible = True
            lblyellow.Visible = False
        End If

        'procedures for red wins
        Call Redhorizontalvictory()
        Call redverticalvictory()
        Call reddiagonalvictory()
        Call reddiagonalvictory2()

        'procedures for yeloow wins
        Call yellowhorizontalvictory()
        Call yellowverticalvictory()
        Call yellowdiagonalvictory()
        Call yellowdiagonalvictory2()
    End Sub

    Private Sub Button30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button30.Click
        If Button30.Enabled = True Then
            Select Case lstcolors.SelectedItem
                Case Is = "Red"
                    Button30.BackColor = Color.Red
                Case Is = "Yellow"
                    Button30.BackColor = Color.Yellow
            End Select
        End If


        If Button30.BackColor = Color.Red Then
            Button37.Enabled = True
            Button30.Enabled = False
            lblred.Visible = False
            lblyellow.Visible = True

        End If
        If Button30.BackColor = Color.Yellow Then
            Button37.Enabled = True
            Button30.Enabled = False
            lblred.Visible = True
            lblyellow.Visible = False
        End If

        'procedures for red wins
        Call Redhorizontalvictory()
        Call redverticalvictory()
        Call reddiagonalvictory()
        Call reddiagonalvictory2()

        'procedures for yeloow wins
        Call yellowhorizontalvictory()
        Call yellowverticalvictory()
        Call yellowdiagonalvictory()
        Call yellowdiagonalvictory2()
    End Sub

    Private Sub Button31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button31.Click
        If Button31.Enabled = True Then
            Select Case lstcolors.SelectedItem
                Case Is = "Red"
                    Button31.BackColor = Color.Red
                Case Is = "Yellow"
                    Button31.BackColor = Color.Yellow
            End Select
        End If


        If Button31.BackColor = Color.Red Then
            Button38.Enabled = True
            Button31.Enabled = False
            lblred.Visible = False
            lblyellow.Visible = True

        End If
        If Button31.BackColor = Color.Yellow Then
            Button38.Enabled = True
            Button31.Enabled = False
            lblred.Visible = True
            lblyellow.Visible = False
        End If

        'procedures for red wins
        Call Redhorizontalvictory()
        Call redverticalvictory()
        Call reddiagonalvictory()
        Call reddiagonalvictory2()

        'procedures for yeloow wins
        Call yellowhorizontalvictory()
        Call yellowverticalvictory()
        Call yellowdiagonalvictory()
        Call yellowdiagonalvictory2()


    End Sub

    Private Sub Button32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button32.Click
        If Button32.Enabled = True Then
            Select Case lstcolors.SelectedItem
                Case Is = "Red"
                    Button32.BackColor = Color.Red
                Case Is = "Yellow"
                    Button32.BackColor = Color.Yellow
            End Select
        End If


        If Button32.BackColor = Color.Red Then
            Button39.Enabled = True
            Button32.Enabled = False
            lblred.Visible = False
            lblyellow.Visible = True

        End If
        If Button32.BackColor = Color.Yellow Then
            Button39.Enabled = True
            Button32.Enabled = False
            lblred.Visible = True
            lblyellow.Visible = False
        End If

        'procedures for red wins
        Call Redhorizontalvictory()
        Call redverticalvictory()
        Call reddiagonalvictory()
        Call reddiagonalvictory2()

        'procedures for yeloow wins
        Call yellowhorizontalvictory()
        Call yellowverticalvictory()
        Call yellowdiagonalvictory()
        Call yellowdiagonalvictory2()
    End Sub

    Private Sub Button33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button33.Click
        If Button33.Enabled = True Then
            Select Case lstcolors.SelectedItem
                Case Is = "Red"
                    Button33.BackColor = Color.Red
                Case Is = "Yellow"
                    Button33.BackColor = Color.Yellow
            End Select
        End If


        If Button33.BackColor = Color.Red Then
            Button40.Enabled = True
            Button33.Enabled = False
            lblred.Visible = False
            lblyellow.Visible = True

        End If
        If Button33.BackColor = Color.Yellow Then
            Button40.Enabled = True
            Button33.Enabled = False
            lblred.Visible = True
            lblyellow.Visible = False
        End If

        'procedures for red wins
        Call Redhorizontalvictory()
        Call redverticalvictory()
        Call reddiagonalvictory()
        Call reddiagonalvictory2()

        'procedures for yeloow wins
        Call yellowhorizontalvictory()
        Call yellowverticalvictory()
        Call yellowdiagonalvictory()
        Call yellowdiagonalvictory2()


    End Sub

    Private Sub Button34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button34.Click
        If Button34.Enabled = True Then
            Select Case lstcolors.SelectedItem
                Case Is = "Red"
                    Button34.BackColor = Color.Red
                Case Is = "Yellow"
                    Button34.BackColor = Color.Yellow
            End Select
        End If


        If Button34.BackColor = Color.Red Then
            Button41.Enabled = True
            Button34.Enabled = False
            lblred.Visible = False
            lblyellow.Visible = True

        End If
        If Button34.BackColor = Color.Yellow Then
            Button41.Enabled = True
            Button34.Enabled = False
            lblred.Visible = True
            lblyellow.Visible = False
        End If

        'procedures for red wins
        Call Redhorizontalvictory()
        Call redverticalvictory()
        Call reddiagonalvictory()
        Call reddiagonalvictory2()

        'procedures for yeloow wins
        Call yellowhorizontalvictory()
        Call yellowverticalvictory()
        Call yellowdiagonalvictory()
        Call yellowdiagonalvictory2()



    End Sub


    Private Sub Button35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button35.Click
        If Button35.Enabled = True Then
            Select Case lstcolors.SelectedItem
                Case Is = "Red"
                    Button35.BackColor = Color.Red
                Case Is = "Yellow"
                    Button35.BackColor = Color.Yellow
            End Select
        End If


        If Button35.BackColor = Color.Red Then
            Button39.Enabled = True
            Button42.Enabled = False
            lblred.Visible = False
            lblyellow.Visible = True

        End If
        If Button35.BackColor = Color.Yellow Then
            Button42.Enabled = True
            Button35.Enabled = False
            lblred.Visible = True
            lblyellow.Visible = False
        End If

        'procedures for red wins
        Call Redhorizontalvictory()
        Call redverticalvictory()
        Call reddiagonalvictory()
        Call reddiagonalvictory2()

        'procedures for yeloow wins
        Call yellowhorizontalvictory()
        Call yellowverticalvictory()
        Call yellowdiagonalvictory()
        Call yellowdiagonalvictory2()

    End Sub

    Private Sub Button36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button36.Click

        If Button36.Enabled = True Then
            Select Case lstcolors.SelectedItem
                Case Is = "Red"
                    Button36.BackColor = Color.Red
                Case Is = "Yellow"
                    Button36.BackColor = Color.Yellow
            End Select
        End If


        If Button36.BackColor = Color.Red Then
            Button36.Enabled = False
            lblred.Visible = False
            lblyellow.Visible = True

        End If
        If Button36.BackColor = Color.Yellow Then
            Button36.Enabled = False
            lblred.Visible = True
            lblyellow.Visible = False
        End If

        'procedures for red wins
        Call Redhorizontalvictory()
        Call redverticalvictory()
        Call reddiagonalvictory()
        Call reddiagonalvictory2()

        'procedures for yeloow wins
        Call yellowhorizontalvictory()
        Call yellowverticalvictory()
        Call yellowdiagonalvictory()
        Call yellowdiagonalvictory2()



    End Sub

    Private Sub Button37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button37.Click
        If Button37.Enabled = True Then
            Select Case lstcolors.SelectedItem
                Case Is = "Red"
                    Button37.BackColor = Color.Red
                Case Is = "Yellow"
                    Button37.BackColor = Color.Yellow
            End Select
        End If


        If Button37.BackColor = Color.Red Then
            Button37.Enabled = False
            lblred.Visible = False
            lblyellow.Visible = True

        End If
        If Button37.BackColor = Color.Yellow Then
            Button37.Enabled = False
            lblred.Visible = True
            lblyellow.Visible = False
        End If

        'procedures for red wins
        Call Redhorizontalvictory()
        Call redverticalvictory()
        Call reddiagonalvictory()
        Call reddiagonalvictory2()

        'procedures for yeloow wins
        Call yellowhorizontalvictory()
        Call yellowverticalvictory()
        Call yellowdiagonalvictory()
        Call yellowdiagonalvictory2()
    End Sub

    Private Sub Button38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button38.Click
        If Button38.Enabled = True Then
            Select Case lstcolors.SelectedItem
                Case Is = "Red"
                    Button38.BackColor = Color.Red
                Case Is = "Yellow"
                    Button38.BackColor = Color.Yellow
            End Select
        End If


        If Button38.BackColor = Color.Red Then
            Button38.Enabled = False
            lblred.Visible = False
            lblyellow.Visible = True

        End If
        If Button38.BackColor = Color.Yellow Then
            Button38.Enabled = False
            lblred.Visible = True
            lblyellow.Visible = False
        End If

        'procedures for red wins
        Call Redhorizontalvictory()
        Call redverticalvictory()
        Call reddiagonalvictory()
        Call reddiagonalvictory2()

        'procedures for yeloow wins
        Call yellowhorizontalvictory()
        Call yellowverticalvictory()
        Call yellowdiagonalvictory()
        Call yellowdiagonalvictory2()
    End Sub

    Private Sub Button39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button39.Click
        If Button39.Enabled = True Then
            Select Case lstcolors.SelectedItem
                Case Is = "Red"
                    Button39.BackColor = Color.Red
                Case Is = "Yellow"
                    Button39.BackColor = Color.Yellow
            End Select
        End If


        If Button39.BackColor = Color.Red Then
            Button39.Enabled = False
            lblred.Visible = False
            lblyellow.Visible = True

        End If
        If Button39.BackColor = Color.Yellow Then
            Button39.Enabled = False
            lblred.Visible = True
            lblyellow.Visible = False
        End If

        'procedures for red wins
        Call Redhorizontalvictory()
        Call redverticalvictory()
        Call reddiagonalvictory()
        Call reddiagonalvictory2()

        'procedures for yeloow wins
        Call yellowhorizontalvictory()
        Call yellowverticalvictory()
        Call yellowdiagonalvictory()
        Call yellowdiagonalvictory2()
    End Sub

    Private Sub Button40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button40.Click
        If Button40.Enabled = True Then
            Select Case lstcolors.SelectedItem
                Case Is = "Red"
                    Button40.BackColor = Color.Red
                Case Is = "Yellow"
                    Button40.BackColor = Color.Yellow
            End Select
        End If


        If Button40.BackColor = Color.Red Then
            Button40.Enabled = False
            lblred.Visible = False
            lblyellow.Visible = True

        End If
        If Button40.BackColor = Color.Yellow Then
            Button40.Enabled = False
            lblred.Visible = True
            lblyellow.Visible = False
        End If

        'procedures for red wins
        Call Redhorizontalvictory()
        Call redverticalvictory()
        Call reddiagonalvictory()
        Call reddiagonalvictory2()

        'procedures for yeloow wins
        Call yellowhorizontalvictory()
        Call yellowverticalvictory()
        Call yellowdiagonalvictory()
        Call yellowdiagonalvictory2()
    End Sub

    Private Sub Button41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button41.Click
        If Button41.Enabled = True Then
            Select Case lstcolors.SelectedItem
                Case Is = "Red"
                    Button41.BackColor = Color.Red
                Case Is = "Yellow"
                    Button41.BackColor = Color.Yellow
            End Select
        End If


        If Button41.BackColor = Color.Red Then
            Button41.Enabled = False
            lblred.Visible = False
            lblyellow.Visible = True

        End If
        If Button41.BackColor = Color.Yellow Then
            Button41.Enabled = False
            lblred.Visible = True
            lblyellow.Visible = False
        End If

        'procedures for red wins
        Call Redhorizontalvictory()
        Call redverticalvictory()
        Call reddiagonalvictory()
        Call reddiagonalvictory2()

        'procedures for yeloow wins
        Call yellowhorizontalvictory()
        Call yellowverticalvictory()
        Call yellowdiagonalvictory()
        Call yellowdiagonalvictory2()
    End Sub

    Private Sub Button42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button42.Click
        If Button42.Enabled = True Then
            Select Case lstcolors.SelectedItem
                Case Is = "Red"
                    Button42.BackColor = Color.Red
                Case Is = "Yellow"
                    Button42.BackColor = Color.Yellow
            End Select
        End If


        If Button42.BackColor = Color.Red Then
            Button42.Enabled = False
            lblred.Visible = False
            lblyellow.Visible = True

        End If
        If Button42.BackColor = Color.Yellow Then
            Button42.Enabled = False
            lblred.Visible = True
            lblyellow.Visible = False
        End If

        'procedures for red wins
        Call Redhorizontalvictory()
        Call redverticalvictory()
        Call reddiagonalvictory()
        Call reddiagonalvictory2()

        'procedures for yeloow wins
        Call yellowhorizontalvictory()
        Call yellowverticalvictory()
        Call yellowdiagonalvictory()
        Call yellowdiagonalvictory2()
    End Sub

    Sub ChangePlayer()
        If lstcolors.SelectedIndex = 0 Then
            lstcolors.SelectedIndex = 1
        Else
            lstcolors.SelectedIndex = 0
        End If
    End Sub
End Class