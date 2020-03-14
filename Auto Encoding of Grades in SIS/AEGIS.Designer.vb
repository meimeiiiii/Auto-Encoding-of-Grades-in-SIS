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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBoxUN
        '
        Me.TextBoxUN.BackColor = System.Drawing.Color.Maroon
        Me.TextBoxUN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxUN.Font = New System.Drawing.Font("Montserrat", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxUN.ForeColor = System.Drawing.Color.White
        Me.TextBoxUN.Location = New System.Drawing.Point(12, 155)
        Me.TextBoxUN.Name = "TextBoxUN"
        Me.TextBoxUN.Size = New System.Drawing.Size(235, 24)
        Me.TextBoxUN.TabIndex = 0
        '
        'LabelUN
        '
        Me.LabelUN.AutoSize = True
        Me.LabelUN.BackColor = System.Drawing.Color.Transparent
        Me.LabelUN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelUN.Font = New System.Drawing.Font("Montserrat Light", 9.7!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUN.ForeColor = System.Drawing.Color.Gainsboro
        Me.LabelUN.Location = New System.Drawing.Point(12, 132)
        Me.LabelUN.Name = "LabelUN"
        Me.LabelUN.Size = New System.Drawing.Size(81, 18)
        Me.LabelUN.TabIndex = 1
        Me.LabelUN.Text = "User Name"
        '
        'LabelPW
        '
        Me.LabelPW.AutoSize = True
        Me.LabelPW.BackColor = System.Drawing.Color.Transparent
        Me.LabelPW.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelPW.Font = New System.Drawing.Font("Montserrat Light", 9.7!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPW.ForeColor = System.Drawing.Color.Gainsboro
        Me.LabelPW.Location = New System.Drawing.Point(12, 206)
        Me.LabelPW.Name = "LabelPW"
        Me.LabelPW.Size = New System.Drawing.Size(70, 18)
        Me.LabelPW.TabIndex = 3
        Me.LabelPW.Text = "Password"
        '
        'TextBoxPW
        '
        Me.TextBoxPW.BackColor = System.Drawing.Color.Maroon
        Me.TextBoxPW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxPW.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPW.ForeColor = System.Drawing.Color.White
        Me.TextBoxPW.Location = New System.Drawing.Point(12, 229)
        Me.TextBoxPW.Name = "TextBoxPW"
        Me.TextBoxPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.TextBoxPW.Size = New System.Drawing.Size(235, 23)
        Me.TextBoxPW.TabIndex = 2
        '
        'LabelGS
        '
        Me.LabelGS.AutoSize = True
        Me.LabelGS.BackColor = System.Drawing.Color.Transparent
        Me.LabelGS.Font = New System.Drawing.Font("Montserrat Light", 9.7!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelGS.ForeColor = System.Drawing.Color.LightGray
        Me.LabelGS.Location = New System.Drawing.Point(14, 286)
        Me.LabelGS.Name = "LabelGS"
        Me.LabelGS.Size = New System.Drawing.Size(86, 18)
        Me.LabelGS.TabIndex = 4
        Me.LabelGS.Text = "GradeSheet"
        '
        'BtnBrowse
        '
        Me.BtnBrowse.BackColor = System.Drawing.Color.Maroon
        Me.BtnBrowse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.BtnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBrowse.Font = New System.Drawing.Font("Montserrat Light", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBrowse.ForeColor = System.Drawing.Color.Gainsboro
        Me.BtnBrowse.Location = New System.Drawing.Point(29, 347)
        Me.BtnBrowse.Name = "BtnBrowse"
        Me.BtnBrowse.Size = New System.Drawing.Size(202, 31)
        Me.BtnBrowse.TabIndex = 5
        Me.BtnBrowse.Text = "Browse Grade Sheet"
        Me.BtnBrowse.UseVisualStyleBackColor = False
        '
        'DialogBrowse
        '
        Me.DialogBrowse.InitialDirectory = "C:\"
        Me.DialogBrowse.Title = "Select Grade Sheet"
        '
        'TextBoxGS
        '
        Me.TextBoxGS.BackColor = System.Drawing.Color.Maroon
        Me.TextBoxGS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxGS.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxGS.ForeColor = System.Drawing.Color.White
        Me.TextBoxGS.Location = New System.Drawing.Point(12, 309)
        Me.TextBoxGS.Name = "TextBoxGS"
        Me.TextBoxGS.Size = New System.Drawing.Size(235, 23)
        Me.TextBoxGS.TabIndex = 6
        '
        'BtnEncode
        '
        Me.BtnEncode.BackColor = System.Drawing.Color.Maroon
        Me.BtnEncode.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.BtnEncode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEncode.Font = New System.Drawing.Font("Montserrat Light", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEncode.ForeColor = System.Drawing.Color.Gainsboro
        Me.BtnEncode.Location = New System.Drawing.Point(54, 442)
        Me.BtnEncode.Name = "BtnEncode"
        Me.BtnEncode.Size = New System.Drawing.Size(146, 31)
        Me.BtnEncode.TabIndex = 7
        Me.BtnEncode.Text = "Encode Grades"
        Me.BtnEncode.UseVisualStyleBackColor = False
        '
        'WebBrowser
        '
        Me.WebBrowser.Location = New System.Drawing.Point(259, 0)
        Me.WebBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser.Name = "WebBrowser"
        Me.WebBrowser.Size = New System.Drawing.Size(1019, 697)
        Me.WebBrowser.TabIndex = 8
        '
        'GetGSTemplate
        '
        Me.GetGSTemplate.FlatAppearance.BorderSize = 0
        Me.GetGSTemplate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GetGSTemplate.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GetGSTemplate.ForeColor = System.Drawing.Color.White
        Me.GetGSTemplate.Location = New System.Drawing.Point(29, 521)
        Me.GetGSTemplate.Name = "GetGSTemplate"
        Me.GetGSTemplate.Size = New System.Drawing.Size(202, 28)
        Me.GetGSTemplate.TabIndex = 9
        Me.GetGSTemplate.Text = "Get Gradesheet Template"
        Me.GetGSTemplate.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkRed
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.BtnBrowse)
        Me.Panel1.Controls.Add(Me.BtnEncode)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TextBoxGS)
        Me.Panel1.Controls.Add(Me.GetGSTemplate)
        Me.Panel1.Controls.Add(Me.LabelUN)
        Me.Panel1.Controls.Add(Me.LabelGS)
        Me.Panel1.Controls.Add(Me.LabelPW)
        Me.Panel1.Controls.Add(Me.TextBoxPW)
        Me.Panel1.Controls.Add(Me.TextBoxUN)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(261, 697)
        Me.Panel1.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Montserrat SemiBold", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Goldenrod
        Me.Label2.Location = New System.Drawing.Point(175, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 17)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "by AGMU"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Montserrat ExtraBold", 50.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(253, 92)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "AEGiS"
        '
        'AEGS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(1280, 697)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.WebBrowser)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "AEGS"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Auto Encoding of Grades in SIS"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
