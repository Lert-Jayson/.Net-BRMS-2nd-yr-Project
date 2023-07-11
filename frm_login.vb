Imports System.Windows.Forms
Imports System.Data.Odbc
Imports System.Security.Cryptography
Imports System.Speech.Synthesis

Public Class frm_login
    Dim mycmd As New OdbcCommand
    Dim readUser As OdbcDataReader
    Dim speaker As New SpeechSynthesizer

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub frm_login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        speaker.Rate = 1
        speaker.Volume = 100
        speaker.Speak("Welcome to our Baranggay Buhay records management System. Good day.")

        txt_username.Focus()
        btn_login.Enabled = False



    End Sub

    Private Function MD5(ByVal sPassword As String) As String
        Dim p As New System.Security.Cryptography.MD5CryptoServiceProvider()
        Dim bs As Byte() = System.Text.Encoding.UTF8.GetBytes(sPassword)
        bs = p.ComputeHash(bs)
        Dim s As New System.Text.StringBuilder()
        For Each b As Byte In bs
            s.Append(b.ToString("x2").ToLower())
        Next
        Return s.ToString()
    End Function


    Private Sub txt_username_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_username.KeyDown
        If e.KeyCode = 13 Then
            If txt_username.Text = "" Then
                MessageBox.Show("Enter your Username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_username.Focus()
            Else
                txt_pword.Focus()
            End If
        End If
    End Sub

    Private Sub txt_pword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_pword.KeyDown
        If e.KeyCode = 13 Then
            If txt_pword.Text = "" Then
                MessageBox.Show("Enter your Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_pword.Focus()
            Else
                btn_login.Enabled = True
                btn_login.Focus()
            End If
        End If
    End Sub

    Private Sub btn_login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_login.Click
        connectMe()

        'With mycmd
        '    .Connection = con
        '    .CommandText = "select * from user_tbl where uname = '" & txt_username.Text & "' and pword = MD5('" & txt_pword.Text & "')"
        '    .ExecuteNonQuery()
        'End With
        'readUser = mycmd.ExecuteReader
        'If readUser.HasRows Then
        '    readUser.Read()
        '    username1 = readUser!fname & " " & readUser!lname

        '    Dim my_main As New frm_main

        '    Me.Hide()
        '    my_main.Show()


        'Else
        '    MessageBox.Show("Username and password do not match.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    txt_username.Clear()
        '    txt_pword.Clear()
        '    btn_login.Enabled = False
        '    txt_username.Focus()
        'End If


        Try

            With mycmd
                .Connection = con
                .CommandText = "select * from user_tbl where uname = '" & txt_username.Text & "' and pword = MD5('" & txt_pword.Text & "' and position = 'CAPTAIN' or 'KAGAWAD' or 'SK CHAIRMAIN' or 'SK KAGAWAD')"
                .ExecuteNonQuery()
            End With
            readUser = mycmd.ExecuteReader

            If readUser.HasRows Then
                readUser.Read()
                username1 = readUser!fname & " " & readUser!lname
                usertype = readUser!position

                Dim my_main As New frm_main
                Me.Hide()
                my_main.Show()


            Else
                readUser.Read()
                username1 = readUser!fname & " " & readUser!lname
                usertype = readUser!position

                Dim my_main As New frm_main
                Me.Hide()
                my_main.Show()

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class