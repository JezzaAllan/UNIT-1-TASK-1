<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btn_student = New System.Windows.Forms.Button()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.txt_english = New System.Windows.Forms.TextBox()
        Me.txt_maths = New System.Windows.Forms.TextBox()
        Me.txt_pe = New System.Windows.Forms.TextBox()
        Me.button_submit = New System.Windows.Forms.Button()
        Me.lbl_englisht = New System.Windows.Forms.Label()
        Me.lbl_mathst = New System.Windows.Forms.Label()
        Me.lbl_pet = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_student
        '
        Me.btn_student.Location = New System.Drawing.Point(463, 338)
        Me.btn_student.Name = "btn_student"
        Me.btn_student.Size = New System.Drawing.Size(175, 65)
        Me.btn_student.TabIndex = 0
        Me.btn_student.Text = "Enter Student Marks"
        Me.btn_student.UseVisualStyleBackColor = True
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Location = New System.Drawing.Point(263, 63)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(64, 13)
        Me.lbl_title.TabIndex = 1
        Me.lbl_title.Text = "Enter Marks"
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Location = New System.Drawing.Point(179, 114)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(30, 13)
        Me.lbl_name.TabIndex = 2
        Me.lbl_name.Text = "John"
        '
        'txt_english
        '
        Me.txt_english.Location = New System.Drawing.Point(283, 111)
        Me.txt_english.Name = "txt_english"
        Me.txt_english.Size = New System.Drawing.Size(100, 20)
        Me.txt_english.TabIndex = 10
        '
        'txt_maths
        '
        Me.txt_maths.Location = New System.Drawing.Point(408, 111)
        Me.txt_maths.Name = "txt_maths"
        Me.txt_maths.Size = New System.Drawing.Size(100, 20)
        Me.txt_maths.TabIndex = 11
        '
        'txt_pe
        '
        Me.txt_pe.Location = New System.Drawing.Point(538, 111)
        Me.txt_pe.Name = "txt_pe"
        Me.txt_pe.Size = New System.Drawing.Size(100, 20)
        Me.txt_pe.TabIndex = 12
        '
        'button_submit
        '
        Me.button_submit.Location = New System.Drawing.Point(644, 338)
        Me.button_submit.Name = "button_submit"
        Me.button_submit.Size = New System.Drawing.Size(115, 65)
        Me.button_submit.TabIndex = 13
        Me.button_submit.Text = "Add to database"
        Me.button_submit.UseVisualStyleBackColor = True
        '
        'lbl_englisht
        '
        Me.lbl_englisht.AutoSize = True
        Me.lbl_englisht.Location = New System.Drawing.Point(312, 95)
        Me.lbl_englisht.Name = "lbl_englisht"
        Me.lbl_englisht.Size = New System.Drawing.Size(41, 13)
        Me.lbl_englisht.TabIndex = 14
        Me.lbl_englisht.Text = "English"
        '
        'lbl_mathst
        '
        Me.lbl_mathst.AutoSize = True
        Me.lbl_mathst.Location = New System.Drawing.Point(434, 95)
        Me.lbl_mathst.Name = "lbl_mathst"
        Me.lbl_mathst.Size = New System.Drawing.Size(36, 13)
        Me.lbl_mathst.TabIndex = 15
        Me.lbl_mathst.Text = "Maths"
        '
        'lbl_pet
        '
        Me.lbl_pet.AutoSize = True
        Me.lbl_pet.Location = New System.Drawing.Point(567, 95)
        Me.lbl_pet.Name = "lbl_pet"
        Me.lbl_pet.Size = New System.Drawing.Size(27, 13)
        Me.lbl_pet.TabIndex = 16
        Me.lbl_pet.Text = "P.E."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbl_pet)
        Me.Controls.Add(Me.lbl_mathst)
        Me.Controls.Add(Me.lbl_englisht)
        Me.Controls.Add(Me.button_submit)
        Me.Controls.Add(Me.txt_pe)
        Me.Controls.Add(Me.txt_maths)
        Me.Controls.Add(Me.txt_english)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.btn_student)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_student As Button
    Friend WithEvents lbl_title As Label
    Friend WithEvents lbl_name As Label
    Friend WithEvents txt_english As TextBox
    Friend WithEvents txt_maths As TextBox
    Friend WithEvents txt_pe As TextBox
    Friend WithEvents button_submit As Button
    Friend WithEvents lbl_englisht As Label
    Friend WithEvents lbl_mathst As Label
    Friend WithEvents lbl_pet As Label
End Class
