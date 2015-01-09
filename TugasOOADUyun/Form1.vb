Imports System.Collections.Generic
Imports TugasOOADUyun
Imports System.Windows.Forms

Public Class FrmBangku

    Private listTiket As List(Of Tiket) = New List(Of Tiket)
    Private listBangku As List(Of Button) = New List(Of Button)

    Private Sub btnConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirm.Click
        Dim intTotal As Integer = listBangku.Count
        MessageBox.Show("Total = " & intTotal & " Kursi")
    End Sub

    Private Sub A1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A1.Click
        listBangku.Add(A1)
        A1.Enabled = False
    End Sub

    Private Sub B1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B1.Click
        listBangku.Add(B1)
        B1.Enabled = False
    End Sub

    Private Sub C1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1.Click
        listBangku.Add(C1)
        C1.Enabled = False
    End Sub

    Private Sub D1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D1.Click
        listBangku.Add(D1)
        D1.Enabled = False
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        For Each btn As Button In listBangku
            btn.Enabled = True
        Next
    End Sub

    Private Sub A2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A2.Click
        listBangku.Add(A2)
        A2.Enabled = False
    End Sub

    Private Sub B2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B2.Click
        listBangku.Add(B2)
        B2.Enabled = False
    End Sub

    Private Sub C2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C2.Click
        listBangku.Add(C2)
        C2.Enabled = False
    End Sub

    Private Sub D2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D2.Click
        listBangku.Add(D2)
        D2.Enabled = False
    End Sub

    Private Sub A3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A3.Click
        listBangku.Add(A3)
        A3.Enabled = False
    End Sub

    Private Sub B3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B3.Click
        listBangku.Add(B3)
        B3.Enabled = False
    End Sub

    Private Sub C3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C3.Click
        listBangku.Add(C3)
        C3.Enabled = False
    End Sub

    Private Sub D3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D3.Click
        listBangku.Add(D3)
        D3.Enabled = False
    End Sub
End Class
