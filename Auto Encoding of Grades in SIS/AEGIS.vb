
Imports System.Threading
Imports Excel = Microsoft.Office.Interop.Excel
Public Class AEGS
    Dim FileNameGS As String            'FILE NAME - GRADE SHEET EXCEL FILE
    Dim username As String
    Dim password As String

    Private Sub AEGS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'INITIALIZATION

        Dim proc As Process

        For Each proc In Process.GetProcessesByName("EXCEL")
            proc.Kill()
        Next

    End Sub

    Private Sub TextBoxUN_TextChanged(sender As Object, e As EventArgs) Handles TextBoxUN.TextChanged
        username = TextBoxUN.Text

    End Sub

    Private Sub LabelGS_Click(sender As Object, e As EventArgs) Handles LabelPW.Click

    End Sub

    Private Sub TextBoxPW_TextChanged_1(sender As Object, e As EventArgs) Handles TextBoxPW.TextChanged
        password = TextBoxPW.Text
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

            'xlApp.Visible = True
            xlWs = xlWb.ActiveSheet

            'CHECK INFO
            Dim dept As String = xlWs.Range("B1").Value
            Dim sy As String = xlWs.Range("B2").Value
            Dim sem As String = xlWs.Range("B3").Value
            Dim subjCode As String = xlWs.Range("B4").Value
            Dim section As String = xlWs.Range("B5").Value
            Dim lastRow As Integer = xlWs.UsedRange.Rows.Count

            If dept <> "" Then
                If sy <> "" Then
                    If sem <> "" Then
                        If subjCode <> "" Then
                            If section <> "" Then
                                MessageBox.Show("Completely filled out")
                                WebBrowser.Navigate("http://192.168.254.118:8081/AEGiS-Test-Environment/")

                                WaitForPageLoad()

                                '1 - SIGN IN

                                WebBrowser.Document.GetElementById("username").SetAttribute("value", username)
                                WebBrowser.Document.GetElementById("password").SetAttribute("value", password)

                                For Each elem As HtmlElement In WebBrowser.Document.GetElementsByTagName("input")
                                    If elem.GetAttribute("type") = "submit" And elem.GetAttribute("value") = "Sign-In" Then
                                        elem.Focus()
                                        elem.InvokeMember("click")

                                        Exit For
                                        MessageBox.Show("Sign-In Clicked")
                                    End If
                                Next

                                WaitForPageLoad()


                                '2 - MESSAGES

                                For Each elem As HtmlElement In WebBrowser.Document.GetElementsByTagName("button")
                                    If elem.GetAttribute("type") = "submit" And elem.GetAttribute("value") = "Grading Sheet" Then
                                        elem.Focus()
                                        elem.InvokeMember("click")

                                        Exit For
                                        MessageBox.Show("Grading Sheet Clicked")
                                    End If
                                Next

                                WaitForPageLoad()


                                '3 - GRADING SHEET
                                Dim elemOption As HtmlElement

                                elemOption = WebBrowser.Document.GetElementsByTagName("select").Cast(Of HtmlElement).First(Function(el) el.GetAttribute("name") = "department")
                                elemOption.Focus()
                                elemOption.GetElementsByTagName("option").Cast(Of HtmlElement).First(Function(el) el.InnerText = dept).SetAttribute("selected", "selected")

                                MessageBox.Show(dept & " selected")

                                elemOption = WebBrowser.Document.GetElementsByTagName("select").Cast(Of HtmlElement).First(Function(el) el.GetAttribute("name") = "schoolYear")
                                elemOption.Focus()
                                elemOption.GetElementsByTagName("option").Cast(Of HtmlElement).First(Function(el) el.InnerText = sy).SetAttribute("selected", "selected")

                                MessageBox.Show(sy & " selected")

                                elemOption = WebBrowser.Document.GetElementsByTagName("select").Cast(Of HtmlElement).First(Function(el) el.GetAttribute("name") = "semester")
                                elemOption.Focus()
                                elemOption.GetElementsByTagName("option").Cast(Of HtmlElement).First(Function(el) el.InnerText = sem).SetAttribute("selected", "selected")

                                MessageBox.Show(sem & " selected")

                                For Each elem As HtmlElement In WebBrowser.Document.GetElementsByTagName("input")
                                    If elem.GetAttribute("type") = "submit" And elem.GetAttribute("value") = "Search" Then
                                        elem.Focus()
                                        elem.InvokeMember("click")

                                        Exit For
                                        MessageBox.Show("Search Clicked")
                                    End If
                                Next

                                'WaitForPageLoad()


                                'loop: check all elements
                                'if element value is "   Sign-In    ", click

                                'loop: check if grades button exists
                                'wait(time)
                                'click grades

                                'loop: check if subj code exists
                                'wait(time)
                                'click subject code

                                'loop: check if CYS exists
                                'wait(time)
                                'click CYS

                                'loop: check if _ exists
                                'wait(time)

                                'loop: find name
                                'If found Then, Set midterm grade, Set final grade, Set cell value: "Encoded *date&time"
                                'Else, next, set cell value: "Student not found"

                                'Sign-out
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

        Dim FileToDelete As String

        FileToDelete = "C:\Users\" & SystemInformation.UserName & "\Documents\Grades Template.xls"

        If IO.File.Exists(FileToDelete) = True Then

            IO.File.Delete(FileToDelete)
            MsgBox("File Deleted")

        End If


        xlApp = New Excel.Application

        If xlApp Is Nothing Then
            MessageBox.Show("Excel is not properly installed!")
            Return
        End If

        xlWb = xlApp.Workbooks.Add(misValue)
        xlWs = xlWb.Sheets("Sheet1")

        'CONTENT
        With xlWs

            .Range("A1").Value = "Department"
            .Range("A2").Value = "School Year"
            .Range("A3").Value = "Semester"
            .Range("A4").Value = "Section"
            .Range("A5").Value = "Subject Code"

            .Range("B1").Value = "College"
            .Range("B2").Value = "1920"
            .Range("B3").Value = "First"
            .Range("B4").Value = "BSCOE 5-4"
            .Range("B5").Value = "BSCOE-ELEC3"
            .Range("B1:B5").HorizontalAlignment = Excel.Constants.xlLeft

            .Columns(1).ColumnWidth = 12
            .Range("A8").Value = "No"
            .Range("A8:A9").Merge()

            .Columns(2).ColumnWidth = 16
            .Range("B8").Value = "Student Number"
            .Range("B8:B9").Merge()

            .Columns(3).ColumnWidth = 35
            .Range("C8").Value = "Name"
            .Range("C8:C9").Merge()

            .Range("D8").Value = "Grade"
            .Range("D8:E8").Merge()
            .Columns(4).ColumnWidth = 8.5
            .Range("D9").Value = "First"
            .Columns(5).ColumnWidth = 8.5
            .Range("E9").Value = "Second"

            .Columns(6).ColumnWidth = 10.5
            .Range("F8").Value = "Final Grade"
            .Range("F8:F9").Merge()

            .Columns(7).ColumnWidth = 10.5
            .Range("G8").Value = "Encoded"
            .Range("G8:G9").Merge()

            .Range("A10").Value = "1"
            .Range("B10").Value = "2020-00001-MN-0"
            .Range("C10").Value = "DELA CRUZ, JUAN B."
            .Range("D10").Value = "1.00"
            .Range("E10").Value = "1.00"
            .Range("F10").Formula = "=AVERAGE(D10:E10)"

            .Range("A8:G10").HorizontalAlignment = Excel.Constants.xlCenter
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


    Private Property pageready As Boolean = False

#Region "Page Loading Functions"
    Private Sub WaitForPageLoad()
        AddHandler WebBrowser.DocumentCompleted, New WebBrowserDocumentCompletedEventHandler(AddressOf PageWaiter)
        While Not pageready
            Application.DoEvents()
        End While
        pageready = False
    End Sub

    Private Sub PageWaiter(ByVal sender As Object, ByVal e As WebBrowserDocumentCompletedEventArgs)
        If WebBrowser.ReadyState = WebBrowserReadyState.Complete Then
            pageready = True
            RemoveHandler WebBrowser.DocumentCompleted, New WebBrowserDocumentCompletedEventHandler(AddressOf PageWaiter)
        End If
    End Sub

#End Region


End Class
