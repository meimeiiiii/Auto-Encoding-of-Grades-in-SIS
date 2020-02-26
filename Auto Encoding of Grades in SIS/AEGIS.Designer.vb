<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AEGS
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AEGS))
        Me.TextBoxUN = New System.Windows.Forms.TextBox()
        Me.LabelUN = New System.Windows.Forms.Label()
        Me.LabelPW = New System.Windows.Forms.Label()
        Me.TextBoxPW = New System.Windows.Forms.TextBox()
        Me.LabelGS = New System.Windows.Forms.Label()
        Me.BtnBrowse = New System.Windows.Forms.Button()
        Me.DialogBrowse = New System.Windows.Forms.OpenFileDialog()
        Me.TextBoxGS = New System.Windows.Forms.TextBox()
        Me.BtnEncode = New System.Windows.Forms.Button()
        Me.WebBrowser = New System.Windows.Forms.WebBrowser()
        Me.GetGSTemplate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBoxUN
        '
        Me.TextBoxUN.Location = New System.Drawing.Point(74, 47)
        Me.TextBoxUN.Name = "TextBoxUN"
        Me.TextBoxUN.Size = New System.Drawing.Size(111, 20)
        Me.TextBoxUN.TabIndex = 0
        '
        'LabelUN
        '
        Me.LabelUN.AutoSize = True
        Me.LabelUN.Location = New System.Drawing.Point(12, 50)
        Me.LabelUN.Name = "LabelUN"
        Me.LabelUN.Size = New System.Drawing.Size(60, 13)
        Me.LabelUN.TabIndex = 1
        Me.LabelUN.Text = "User Name"
        '
        'LabelPW
        '
        Me.LabelPW.AutoSize = True
        Me.LabelPW.Location = New System.Drawing.Point(200, 50)
        Me.LabelPW.Name = "LabelPW"
        Me.LabelPW.Size = New System.Drawing.Size(53, 13)
        Me.LabelPW.TabIndex = 3
        Me.LabelPW.Text = "Password"
        '
        'TextBoxPW
        '
        Me.TextBoxPW.Location = New System.Drawing.Point(255, 47)
        Me.TextBoxPW.Name = "TextBoxPW"
        Me.TextBoxPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.TextBoxPW.Size = New System.Drawing.Size(111, 20)
        Me.TextBoxPW.TabIndex = 2
        '
        'LabelGS
        '
        Me.LabelGS.AutoSize = True
        Me.LabelGS.Location = New System.Drawing.Point(384, 50)
        Me.LabelGS.Name = "LabelGS"
        Me.LabelGS.Size = New System.Drawing.Size(64, 13)
        Me.LabelGS.TabIndex = 4
        Me.LabelGS.Text = "GradeSheet"
        '
        'BtnBrowse
        '
        Me.BtnBrowse.Location = New System.Drawing.Point(661, 44)
        Me.BtnBrowse.Name = "BtnBrowse"
        Me.BtnBrowse.Size = New System.Drawing.Size(85, 23)
        Me.BtnBrowse.TabIndex = 5
        Me.BtnBrowse.Text = "Browse"
        Me.BtnBrowse.UseVisualStyleBackColor = True
        '
        'DialogBrowse
        '
        Me.DialogBrowse.InitialDirectory = "C:\"
        Me.DialogBrowse.Title = "Select Grade Sheet"
        '
        'TextBoxGS
        '
        Me.TextBoxGS.Location = New System.Drawing.Point(451, 46)
        Me.TextBoxGS.Name = "TextBoxGS"
        Me.TextBoxGS.Size = New System.Drawing.Size(193, 20)
        Me.TextBoxGS.TabIndex = 6
        '
        'BtnEncode
        '
        Me.BtnEncode.Location = New System.Drawing.Point(752, 45)
        Me.BtnEncode.Name = "BtnEncode"
        Me.BtnEncode.Size = New System.Drawing.Size(91, 23)
        Me.BtnEncode.TabIndex = 7
        Me.BtnEncode.Text = "Encode"
        Me.BtnEncode.UseVisualStyleBackColor = True
        '
        'WebBrowser
        '
        Me.WebBrowser.Location = New System.Drawing.Point(12, 74)
        Me.WebBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser.Name = "WebBrowser"
        Me.WebBrowser.Size = New System.Drawing.Size(831, 362)
        Me.WebBrowser.TabIndex = 8
        '
        'GetGSTemplate
        '
        Me.GetGSTemplate.Location = New System.Drawing.Point(703, 12)
        Me.GetGSTemplate.Name = "GetGSTemplate"
        Me.GetGSTemplate.Size = New System.Drawing.Size(140, 23)
        Me.GetGSTemplate.TabIndex = 9
        Me.GetGSTemplate.Text = "Get Gradesheet Template"
        Me.GetGSTemplate.UseVisualStyleBackColor = True
        '
        'AEGS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(855, 448)
        Me.Controls.Add(Me.GetGSTemplate)
        Me.Controls.Add(Me.WebBrowser)
        Me.Controls.Add(Me.BtnEncode)
        Me.Controls.Add(Me.TextBoxGS)
        Me.Controls.Add(Me.BtnBrowse)
        Me.Controls.Add(Me.LabelGS)
        Me.Controls.Add(Me.LabelPW)
        Me.Controls.Add(Me.TextBoxPW)
        Me.Controls.Add(Me.LabelUN)
        Me.Controls.Add(Me.TextBoxUN)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AEGS"
        Me.Text = "Auto Encoding of Grades in SIS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxUN As TextBox
    Friend WithEvents LabelUN As Label
    Friend WithEvents LabelPW As Label
    Friend WithEvents TextBoxPW As TextBox
    Friend WithEvents LabelGS As Label
    Friend WithEvents BtnBrowse As Button
    Friend WithEvents DialogBrowse As OpenFileDialog
    Friend WithEvents TextBoxGS As TextBox
    Friend WithEvents BtnEncode As Button
    Friend WithEvents WebBrowser As WebBrowser
    Friend WithEvents GetGSTemplate As Button
End Class
