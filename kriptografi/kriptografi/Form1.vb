Imports System.Text
Imports System.IO

Public Class Form1
    Private Const FilterTxt As String = "Text File(*.txt)|*.txt"
    Sub bersih()
        txtasal.Text = ""
        txthasil.Text = ""
        txtasal.Focus()
        number.Value = 3
        rdbenkripsi.Checked = True
    End Sub
    Sub isi()
        If rdbdeskripsi.Checked = True Then
            lbawal.Text = "Chiphertext/Data Tersandi"
            lbhasil.Text = "Plaintext/Data Asli"
        Else
            rdbenkripsi.Checked = True
            lbawal.Text = "Plaintext/Data Asli"
            lbhasil.Text = "Chiphertext/Data Tersandi"
        End If
    End Sub
    Dim a
    Private Sub btnkeluar_Click(sender As Object, e As EventArgs) Handles btnkeluar.Click
        a = MsgBox("Apakah Anda Ingin Keluar ???", vbOK + vbQuestion, "Terima Kasih")
        If a = vbOK Then
            Me.Close()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rdbenkripsi.Checked = True
        lbawal.Text = "Plaintext/Data Asli"
        lbhasil.Text = "Chiphertext/Data Tersandi"

    End Sub

    Private Sub Txtenkripsi_CheckedChanged(sender As Object, e As EventArgs) Handles rdbenkripsi.CheckedChanged
        txtasal.Focus()
    End Sub

    Private Sub rdbdeskripsi_CheckedChanged(sender As Object, e As EventArgs) Handles rdbdeskripsi.CheckedChanged
        isi()
        txtasal.Focus()
    End Sub

    Private Sub btnproses_Click(sender As Object, e As EventArgs) Handles btnproses.Click
        If txtasal.Text = "" Then
            MsgBox("Data Masih Kosong", vbInformation, "Silahkan Isi Dahulu")
            txtasal.Focus()
        ElseIf rdbenkripsi.Checked = True Then
            Dim jumlah As Double = Len(txtasal.Text)
            Dim x As String
            Dim xkalimat As String = ""
            Dim i As Double
            Dim bil As Integer
            For i = 1 To jumlah
                x = Mid(txtasal.Text, i, 1)
                bil = Asc(x) + number.Value
                x = Chr(bil)
                xkalimat = xkalimat + x
            Next i
            txthasil.Text = xkalimat
        ElseIf rdbdeskripsi.Checked = True Then
            Dim jumlah As Double = Len(txtasal.Text)
            Dim x As String
            Dim xkalimat As String = ""
            Dim i As Double
            Dim bil As Integer
            For i = 1 To jumlah
                x = Mid(txtasal.Text, i, 1)
                bil = Asc(x) - number.Value
                x = Chr(bil)
                xkalimat = xkalimat + x
            Next i
            txthasil.Text = xkalimat
        Else
            MsgBox(vbInformation, "Pilih Kategori Terlebih Dahulu")
        End If
    End Sub

    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        bersih()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub btncari_Click(sender As Object, e As EventArgs) Handles btncari.Click
        Dim od As New OpenFileDialog
        Dim sr As StreamReader
        With od
            OpenFileDialog1.RestoreDirectory = True
            .Filter = FilterTxt
            If .ShowDialog().Equals(DialogResult.OK) Then
                sr = New StreamReader(.FileName)
                txtasal.Text = sr.ReadToEnd
                sr.Close()
            End If
            End With
    End Sub
End Class
