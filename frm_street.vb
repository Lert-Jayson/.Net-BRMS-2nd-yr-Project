Imports System.Windows.Forms
Imports System.Data.Odbc


Public Class frm_street
    Dim mycmd As New OdbcCommand

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub frm_street_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_streetid.Hide()
        connectMe()

        Dim sid As Integer
        Dim cmd As New OdbcCommand("select ifnull(max(street_id),0) from street_tbl", con)
        sid = cmd.ExecuteScalar

        If sid > 0 Then
            Call get_stid()
        Else
            txt_streetid.Text = 1
        End If
        txt_street.Focus()

        Dim mycmd As New OdbcCommand("select * from street_tbl", con)
        Dim da As New OdbcDataAdapter(mycmd)
        Dim ds As New System.Data.DataSet

        da.Fill(ds, "street_tbl")

        dg_street.DataSource = ds.Tables(0)
        dg_street.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dg_street.RowsDefaultCellStyle.BackColor = Drawing.Color.Beige
        dg_street.AlternatingRowsDefaultCellStyle.BackColor = Drawing.Color.Cornsilk
        dg_street.Refresh()

        If usertype = "SK KAGAWAD" Or usertype = "SK CHAIRMAN" Or usertype = "CAPTAIN" Then
            btn_save.Enabled = False

        End If


    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        Dim stid As String
        Dim street As String

        stid = txt_streetid.Text
        street = txt_street.Text.ToUpper.Trim

        con.Close()
        Try
            con.Open()
            Dim dr As OdbcDataReader
            Dim cmd As New OdbcCommand("select * from street_tbl where street = '" & street & "'", con)
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                MessageBox.Show("Error: Duplicate Record." & " " & street & "is already created.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            Else

                With mycmd
                    .Connection = con
                    .CommandText = "insert into street_tbl values ('" & stid & "','" & street & "')"
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("street Added", "Add Account Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txt_streetid.Clear()
                txt_street.Clear()
                refreshMe()

                Call get_stid()

                txt_street.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try

    End Sub
    Public Sub get_stid()
        Dim da As New OdbcDataAdapter("select max(street_id) stid1 from street_tbl", con)
        Dim ds As New System.Data.DataSet
        da.Fill(ds)

        txt_streetid.Text = ds.Tables(0).Rows(0).Item("stid1") + 1
    End Sub

    Public Sub refreshMe()
        con.Close()

        Try
            con.Open()

            Dim mycmd As New OdbcCommand("select * from street_tbl", con)
            Dim da As New OdbcDataAdapter(mycmd)
            Dim ds As New System.Data.DataSet

            da.Fill(ds, "street_tbl")

            dg_street.DataSource = ds.Tables(0)
            dg_street.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dg_street.RowsDefaultCellStyle.BackColor = Drawing.Color.Aqua
            dg_street.AlternatingRowsDefaultCellStyle.BackColor = Drawing.Color.Bisque
            dg_street.Refresh()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub
End Class