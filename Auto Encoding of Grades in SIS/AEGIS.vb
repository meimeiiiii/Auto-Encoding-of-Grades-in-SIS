
Imports Excel = Microsoft.Office.Interop.Excel
Public Class AEGS
    Dim FileNameGS As String            'FILE NAME - GRADE SHEET EXCEL FILE

    Private Sub AEGS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBoxUN_TextChanged(sender As Object, e As EventArgs) Handles TextBoxUN.TextChanged

    End Sub

    Private Sub LabelGS_Click(sender As Object, e As EventArgs) Handles LabelPW.Click

    End Sub

    Private Sub PW_TextChanged_1(sender As Object, e As EventArgs) Handles TextBoxPW.TextChanged

    End Sub

    Private Sub BtnBrowse_Click(sender As Object, e As EventArgs) Handles BtnBrowse.Click
        'BROWSE FOR GRADE SHEET EXCEL FILE
        DialogBrowse.ShowDialog()
        FileNameGS = DialogBrowse.FileName
        TextBoxGS.AppendText(FileNameGS)
    End Sub

    Private Sub BtnEncode_Click(sender As Object, e As EventArgs) Handles BtnEncode.Click

        '----------------------------GRADE SHEET VALIDATION--------------------------------------

        'CHECK FILE EXIST
        If System.IO.File.Exists(FileNameGS) Then
            Dim xlApp As Excel.Application
            Dim xlWb As Excel.Workbook
            Dim xlWs As Excel.Worksheet
            'Dim xlRan As Excel.Range

            xlApp = New Excel.Application
            xlWb = xlApp.Workbooks.Open(FileNameGS)

            xlApp.Visible = True
            xlWs = xlWb.ActiveSheet

            'CHECK INFO
            Dim acadYr As String = xlWs.Range("B1").Value
            Dim sem As String = xlWs.Range("B2").Value
            Dim courseCode As String = xlWs.Range("B3").Value
            Dim year As String = xlWs.Range("B4").Value
            Dim section As String = xlWs.Range("B5").Value
            Dim lastRow As Integer = xlWs.UsedRange.Rows.Count

            If acadYr <> "" Then
                If sem <> "" Then
                    If courseCode <> "" Then
                        If year <> "" Then
                            If section <> "" Then
                                MessageBox.Show("Completely filled out")
                                WebBrowser.Navigate("https://pup.edu.ph")


                            End If
                        End If
                    End If
                End If
            End If

        Else
                        MessageBox.Show("The file " + FileNameGS + " does not exist.")
        End If

    End Sub

    Private Sub TextBoxGS_TextChanged(sender As Object, e As EventArgs) Handles TextBoxGS.TextChanged
        FileNameGS = TextBoxGS.Text
    End Sub

    Private Sub GetGSTemplate_Click(sender As Object, e As EventArgs) Handles GetGSTemplate.Click
        'CREATE GRADE SHEET TEMPLATE IN EXCEL

    End Sub

    Private Sub WebBrowser_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser.DocumentCompleted

    End Sub
End Class
