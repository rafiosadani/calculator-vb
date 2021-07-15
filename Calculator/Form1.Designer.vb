<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Btn7 = New System.Windows.Forms.Button()
        Me.Btn8 = New System.Windows.Forms.Button()
        Me.Btn9 = New System.Windows.Forms.Button()
        Me.Btn4 = New System.Windows.Forms.Button()
        Me.Btn5 = New System.Windows.Forms.Button()
        Me.Btn6 = New System.Windows.Forms.Button()
        Me.Btn1 = New System.Windows.Forms.Button()
        Me.Btn2 = New System.Windows.Forms.Button()
        Me.Btn3 = New System.Windows.Forms.Button()
        Me.Btn0 = New System.Windows.Forms.Button()
        Me.BtnC = New System.Windows.Forms.Button()
        Me.BtnHasil = New System.Windows.Forms.Button()
        Me.BtnKali = New System.Windows.Forms.Button()
        Me.BtnBagi = New System.Windows.Forms.Button()
        Me.BtnKurang = New System.Windows.Forms.Button()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(22, 29)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(277, 45)
        Me.TextBox1.TabIndex = 0
        '
        'Btn7
        '
        Me.Btn7.Location = New System.Drawing.Point(13, 91)
        Me.Btn7.Name = "Btn7"
        Me.Btn7.Size = New System.Drawing.Size(62, 36)
        Me.Btn7.TabIndex = 1
        Me.Btn7.Text = "7"
        Me.Btn7.UseVisualStyleBackColor = True
        '
        'Btn8
        '
        Me.Btn8.Location = New System.Drawing.Point(93, 91)
        Me.Btn8.Name = "Btn8"
        Me.Btn8.Size = New System.Drawing.Size(62, 36)
        Me.Btn8.TabIndex = 2
        Me.Btn8.Text = "8"
        Me.Btn8.UseVisualStyleBackColor = True
        '
        'Btn9
        '
        Me.Btn9.Location = New System.Drawing.Point(171, 91)
        Me.Btn9.Name = "Btn9"
        Me.Btn9.Size = New System.Drawing.Size(62, 36)
        Me.Btn9.TabIndex = 3
        Me.Btn9.Text = "9"
        Me.Btn9.UseVisualStyleBackColor = True
        '
        'Btn4
        '
        Me.Btn4.Location = New System.Drawing.Point(13, 143)
        Me.Btn4.Name = "Btn4"
        Me.Btn4.Size = New System.Drawing.Size(62, 36)
        Me.Btn4.TabIndex = 4
        Me.Btn4.Text = "4"
        Me.Btn4.UseVisualStyleBackColor = True
        '
        'Btn5
        '
        Me.Btn5.Location = New System.Drawing.Point(93, 143)
        Me.Btn5.Name = "Btn5"
        Me.Btn5.Size = New System.Drawing.Size(62, 36)
        Me.Btn5.TabIndex = 5
        Me.Btn5.Text = "5"
        Me.Btn5.UseVisualStyleBackColor = True
        '
        'Btn6
        '
        Me.Btn6.Location = New System.Drawing.Point(171, 143)
        Me.Btn6.Name = "Btn6"
        Me.Btn6.Size = New System.Drawing.Size(62, 36)
        Me.Btn6.TabIndex = 6
        Me.Btn6.Text = "6"
        Me.Btn6.UseVisualStyleBackColor = True
        '
        'Btn1
        '
        Me.Btn1.Location = New System.Drawing.Point(13, 197)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(62, 36)
        Me.Btn1.TabIndex = 7
        Me.Btn1.Text = "1"
        Me.Btn1.UseVisualStyleBackColor = True
        '
        'Btn2
        '
        Me.Btn2.Location = New System.Drawing.Point(93, 197)
        Me.Btn2.Name = "Btn2"
        Me.Btn2.Size = New System.Drawing.Size(62, 36)
        Me.Btn2.TabIndex = 8
        Me.Btn2.Text = "2"
        Me.Btn2.UseVisualStyleBackColor = True
        '
        'Btn3
        '
        Me.Btn3.Location = New System.Drawing.Point(171, 197)
        Me.Btn3.Name = "Btn3"
        Me.Btn3.Size = New System.Drawing.Size(62, 36)
        Me.Btn3.TabIndex = 9
        Me.Btn3.Text = "3"
        Me.Btn3.UseVisualStyleBackColor = True
        '
        'Btn0
        '
        Me.Btn0.Location = New System.Drawing.Point(13, 254)
        Me.Btn0.Name = "Btn0"
        Me.Btn0.Size = New System.Drawing.Size(62, 36)
        Me.Btn0.TabIndex = 10
        Me.Btn0.Text = "0"
        Me.Btn0.UseVisualStyleBackColor = True
        '
        'BtnC
        '
        Me.BtnC.Location = New System.Drawing.Point(93, 254)
        Me.BtnC.Name = "BtnC"
        Me.BtnC.Size = New System.Drawing.Size(62, 36)
        Me.BtnC.TabIndex = 11
        Me.BtnC.Text = "C"
        Me.BtnC.UseVisualStyleBackColor = True
        '
        'BtnHasil
        '
        Me.BtnHasil.Location = New System.Drawing.Point(171, 254)
        Me.BtnHasil.Name = "BtnHasil"
        Me.BtnHasil.Size = New System.Drawing.Size(62, 36)
        Me.BtnHasil.TabIndex = 12
        Me.BtnHasil.Text = "="
        Me.BtnHasil.UseVisualStyleBackColor = True
        '
        'BtnKali
        '
        Me.BtnKali.Location = New System.Drawing.Point(249, 254)
        Me.BtnKali.Name = "BtnKali"
        Me.BtnKali.Size = New System.Drawing.Size(62, 36)
        Me.BtnKali.TabIndex = 13
        Me.BtnKali.Text = "X"
        Me.BtnKali.UseVisualStyleBackColor = True
        '
        'BtnBagi
        '
        Me.BtnBagi.Location = New System.Drawing.Point(249, 197)
        Me.BtnBagi.Name = "BtnBagi"
        Me.BtnBagi.Size = New System.Drawing.Size(62, 36)
        Me.BtnBagi.TabIndex = 14
        Me.BtnBagi.Text = "/"
        Me.BtnBagi.UseVisualStyleBackColor = True
        '
        'BtnKurang
        '
        Me.BtnKurang.Location = New System.Drawing.Point(249, 143)
        Me.BtnKurang.Name = "BtnKurang"
        Me.BtnKurang.Size = New System.Drawing.Size(62, 36)
        Me.BtnKurang.TabIndex = 15
        Me.BtnKurang.Text = "-"
        Me.BtnKurang.UseVisualStyleBackColor = True
        '
        'BtnTambah
        '
        Me.BtnTambah.Location = New System.Drawing.Point(249, 91)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(62, 36)
        Me.BtnTambah.TabIndex = 16
        Me.BtnTambah.Text = "+"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(102, 305)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(114, 35)
        Me.BtnExit.TabIndex = 18
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 347)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.BtnKurang)
        Me.Controls.Add(Me.BtnBagi)
        Me.Controls.Add(Me.BtnKali)
        Me.Controls.Add(Me.BtnHasil)
        Me.Controls.Add(Me.BtnC)
        Me.Controls.Add(Me.Btn0)
        Me.Controls.Add(Me.Btn3)
        Me.Controls.Add(Me.Btn2)
        Me.Controls.Add(Me.Btn1)
        Me.Controls.Add(Me.Btn6)
        Me.Controls.Add(Me.Btn5)
        Me.Controls.Add(Me.Btn4)
        Me.Controls.Add(Me.Btn9)
        Me.Controls.Add(Me.Btn8)
        Me.Controls.Add(Me.Btn7)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Calculator"
        Me.Text = "Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Btn7 As Button
    Friend WithEvents Btn8 As Button
    Friend WithEvents Btn9 As Button
    Friend WithEvents Btn4 As Button
    Friend WithEvents Btn5 As Button
    Friend WithEvents Btn6 As Button
    Friend WithEvents Btn1 As Button
    Friend WithEvents Btn2 As Button
    Friend WithEvents Btn3 As Button
    Friend WithEvents Btn0 As Button
    Friend WithEvents BtnC As Button
    Friend WithEvents BtnHasil As Button
    Friend WithEvents BtnKali As Button
    Friend WithEvents BtnBagi As Button
    Friend WithEvents BtnKurang As Button
    Friend WithEvents BtnTambah As Button
    Friend WithEvents BtnExit As Button
End Class
