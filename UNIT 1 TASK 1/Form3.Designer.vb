<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.btn_search = New System.Windows.Forms.Button()
        Me.lbl_holder = New System.Windows.Forms.Label()
        Me.lbl_found_pe = New System.Windows.Forms.Label()
        Me.lbl_found_maths = New System.Windows.Forms.Label()
        Me.lbl_found_english = New System.Windows.Forms.Label()
        Me.lbl_found_student = New System.Windows.Forms.Label()
        Me.lbl_pe = New System.Windows.Forms.Label()
        Me.lbl_english = New System.Windows.Forms.Label()
        Me.lbl_maths = New System.Windows.Forms.Label()
        Me.lbl_student = New System.Windows.Forms.Label()
        Me.btn_home = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_search
        '
        Me.btn_search.Location = New System.Drawing.Point(640, 380)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(129, 48)
        Me.btn_search.TabIndex = 0
        Me.btn_search.Text = "Enter student"
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'lbl_holder
        '
        Me.lbl_holder.AutoSize = True
        Me.lbl_holder.Location = New System.Drawing.Point(593, 44)
        Me.lbl_holder.Name = "lbl_holder"
        Me.lbl_holder.Size = New System.Drawing.Size(16, 13)
        Me.lbl_holder.TabIndex = 1
        Me.lbl_holder.Text = "..."
        '
        'lbl_found_pe
        '
        Me.lbl_found_pe.AutoSize = True
        Me.lbl_found_pe.Location = New System.Drawing.Point(324, 246)
        Me.lbl_found_pe.Name = "lbl_found_pe"
        Me.lbl_found_pe.Size = New System.Drawing.Size(16, 13)
        Me.lbl_found_pe.TabIndex = 36
        Me.lbl_found_pe.Text = "..."
        '
        'lbl_found_maths
        '
        Me.lbl_found_maths.AutoSize = True
        Me.lbl_found_maths.Location = New System.Drawing.Point(324, 207)
        Me.lbl_found_maths.Name = "lbl_found_maths"
        Me.lbl_found_maths.Size = New System.Drawing.Size(16, 13)
        Me.lbl_found_maths.TabIndex = 35
        Me.lbl_found_maths.Text = "..."
        '
        'lbl_found_english
        '
        Me.lbl_found_english.AutoSize = True
        Me.lbl_found_english.Location = New System.Drawing.Point(324, 172)
        Me.lbl_found_english.Name = "lbl_found_english"
        Me.lbl_found_english.Size = New System.Drawing.Size(16, 13)
        Me.lbl_found_english.TabIndex = 34
        Me.lbl_found_english.Text = "..."
        '
        'lbl_found_student
        '
        Me.lbl_found_student.AutoSize = True
        Me.lbl_found_student.Location = New System.Drawing.Point(324, 135)
        Me.lbl_found_student.Name = "lbl_found_student"
        Me.lbl_found_student.Size = New System.Drawing.Size(16, 13)
        Me.lbl_found_student.TabIndex = 33
        Me.lbl_found_student.Text = "..."
        '
        'lbl_pe
        '
        Me.lbl_pe.AutoSize = True
        Me.lbl_pe.Location = New System.Drawing.Point(164, 246)
        Me.lbl_pe.Name = "lbl_pe"
        Me.lbl_pe.Size = New System.Drawing.Size(21, 13)
        Me.lbl_pe.TabIndex = 32
        Me.lbl_pe.Text = "PE"
        '
        'lbl_english
        '
        Me.lbl_english.AutoSize = True
        Me.lbl_english.Location = New System.Drawing.Point(164, 172)
        Me.lbl_english.Name = "lbl_english"
        Me.lbl_english.Size = New System.Drawing.Size(41, 13)
        Me.lbl_english.TabIndex = 31
        Me.lbl_english.Text = "English"
        '
        'lbl_maths
        '
        Me.lbl_maths.AutoSize = True
        Me.lbl_maths.Location = New System.Drawing.Point(164, 207)
        Me.lbl_maths.Name = "lbl_maths"
        Me.lbl_maths.Size = New System.Drawing.Size(36, 13)
        Me.lbl_maths.TabIndex = 30
        Me.lbl_maths.Text = "Maths"
        '
        'lbl_student
        '
        Me.lbl_student.AutoSize = True
        Me.lbl_student.Location = New System.Drawing.Point(164, 135)
        Me.lbl_student.Name = "lbl_student"
        Me.lbl_student.Size = New System.Drawing.Size(44, 13)
        Me.lbl_student.TabIndex = 29
        Me.lbl_student.Text = "Student"
        '
        'btn_home
        '
        Me.btn_home.Location = New System.Drawing.Point(45, 393)
        Me.btn_home.Name = "btn_home"
        Me.btn_home.Size = New System.Drawing.Size(75, 23)
        Me.btn_home.TabIndex = 39
        Me.btn_home.Text = "Home"
        Me.btn_home.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(234, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Mark Display"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btn_home)
        Me.Controls.Add(Me.lbl_found_pe)
        Me.Controls.Add(Me.lbl_found_maths)
        Me.Controls.Add(Me.lbl_found_english)
        Me.Controls.Add(Me.lbl_found_student)
        Me.Controls.Add(Me.lbl_pe)
        Me.Controls.Add(Me.lbl_english)
        Me.Controls.Add(Me.lbl_maths)
        Me.Controls.Add(Me.lbl_student)
        Me.Controls.Add(Me.lbl_holder)
        Me.Controls.Add(Me.btn_search)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_search As Button
    Friend WithEvents lbl_holder As Label
    Friend WithEvents lbl_found_pe As Label
    Friend WithEvents lbl_found_maths As Label
    Friend WithEvents lbl_found_english As Label
    Friend WithEvents lbl_found_student As Label
    Friend WithEvents lbl_pe As Label
    Friend WithEvents lbl_english As Label
    Friend WithEvents lbl_maths As Label
    Friend WithEvents lbl_student As Label
    Friend WithEvents btn_home As Button
    Friend WithEvents Label6 As Label
End Class
