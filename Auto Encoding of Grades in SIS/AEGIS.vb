
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

            If xlApp Is Nothing Then
                MessageBox.Show("Excel is not properly installed!")
                Return
            End If

            xlWb = xlApp.Workbooks.Open(FileNameGS)

            xlApp.Visible = True
            xlWs = xlWb.ActiveSheet

            'CHECK INFO
            Dim acadYr As String = xlWs.Range("B1").Value
            Dim sem As String = xlWs.Range("B2").Value
            Dim subjCode As String = xlWs.Range("B3").Value
            Dim courseCode As String = xlWs.Range("B4").Value
            Dim year As String = xlWs.Range("B5").Value
            Dim section As String = xlWs.Range("B6").Value
            Dim lastRow As Integer = xlWs.UsedRange.Rows.Count

            If acadYr <> "" Then
                If sem <> "" Then
                    If subjCode <> "" Then
                        If courseCode <> "" Then
                            If year <> "" Then
                                If section <> "" Then
                                    MessageBox.Show("Completely filled out")
                                    WebBrowser.Navigate("sisfaculty.pup.edu.ph")
                                    'Process.Start("https://www.twitter.com")

                                End If
                            End If
                        End If
                    End If
                End If
            End If

        Else
            MessageBox.Show("The file " + FileNameGS + " does not exist.")
            Return
        End If

    End Sub

    Private Sub TextBoxGS_TextChanged(sender As Object, e As EventArgs) Handles TextBoxGS.TextChanged
        FileNameGS = TextBoxGS.Text
    End Sub

    Private Sub GetGSTemplate_MouseEnter(sender As Object, e As EventArgs) Handles GetGSTemplate.MouseEnter
        GetGSTemplate.ForeColor = Color.Tomato
    End Sub

    Private Sub GetGSTemplate_MouseLeave(sender As Object, e As EventArgs) Handles GetGSTemplate.MouseLeave
        GetGSTemplate.ForeColor = Color.Firebrick
    End Sub



    Private Sub GetGSTemplate_Click(sender As Object, e As EventArgs) Handles GetGSTemplate.Click
        'CREATE GRADE SHEET TEMPLATE IN EXCEL
        Dim xlApp As Excel.Application
        Dim xlWb As Excel.Workbook
        Dim xlWs As Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value

        'INITIALIZATION
        xlApp = New Excel.Application

        If xlApp Is Nothing Then
            MessageBox.Show("Excel is not properly installed!")
            Return
        End If

        xlWb = xlApp.Workbooks.Add(misValue)
        xlWs = xlWb.Sheets("Sheet1")

        'CONTENT
        With xlWs

            .Range("A1").Value = "School Year"
            .Range("A2").Value = "Semester"
            .Range("A3").Value = "Subject Code"
            .Range("A4").Value = "Course Code"
            .Range("A5").Value = "Year Level"
            .Range("A6").Value = "Section"

            .Range("B1").Value = "1920"
            .Range("B2").Value = "First"
            .Range("B3").Value = "COEN 3284"
            .Range("B4").Value = "BSCOE"
            .Range("B5").Value = "1"
            .Range("B6").Value = "1"
            .Range("B1:B6").HorizontalAlignment = Excel.Constants.xlLeft

            .Columns(1).ColumnWidth = 12
            .Range("A8").Value = "No"
            .Range("A8:A9").Merge()

            .Columns(2).ColumnWidth = 35
            .Range("B8").Value = "Name"
            .Range("B8:B9").Merge()

            .Columns(3).ColumnWidth = 16
            .Range("C8").Value = "Student Number"
            .Range("C8:C9").Merge()

            .Range("D8").Value = "Grade"
            .Range("D8:E8").Merge()
            .Columns(4).ColumnWidth = 8.5
            .Range("D9").Value = "Midterm"
            .Columns(5).ColumnWidth = 8.5
            .Range("E9").Value = "Final"

            .Columns(6).ColumnWidth = 10.5
            .Range("F8").Value = "Final Grade"
            .Range("F8:F9").Merge()

            .Range("A10").Value = "1"
            .Range("B10").Value = "DELA CRUZ, JUAN B."
            .Range("C10").Value = "2020-00001-MN-0"
            .Range("D10").Value = "1.00"
            .Range("E10").Value = "1.00"
            .Range("F10").Formula = "=AVERAGE(D10:E10)"

            .Range("A8:F10").HorizontalAlignment = Excel.Constants.xlCenter
            .Range("B10").HorizontalAlignment = Excel.Constants.xlLeft


        End With
        xlWb.SaveAs("C:\Users\" & SystemInformation.UserName & "\Documents\Grades Template.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue,
          Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue)
        xlWb.Close(True, misValue, misValue)
        xlApp.Quit()

        releaseObject(xlWs)
        releaseObject(xlWb)
        releaseObject(xlApp)

        MessageBox.Show("Template saved, you can find the file in your documents folder.")


    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub WebBrowser_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser.DocumentCompleted

    End Sub
End Class
