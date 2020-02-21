Public Class AEGS
    Dim FileNameGS As String

    Private Sub AEGS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBoxUN_TextChanged(sender As Object, e As EventArgs) Handles TextBoxUN.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles LabelPW.Click

    End Sub

    Private Sub PW_TextChanged_1(sender As Object, e As EventArgs) Handles TextBoxPW.TextChanged

    End Sub

    Private Sub BtnBrowse_Click(sender As Object, e As EventArgs) Handles BtnBrowse.Click
        DialogBrowse.ShowDialog()
        FileNameGS = DialogBrowse.FileName
        TextBoxGS.AppendText(FileNameGS)
    End Sub

    Private Sub BtnEncode_Click(sender As Object, e As EventArgs) Handles BtnEncode.Click

    End Sub
End Class
