Public Class Form2
    Dim english As Double = 0
    Dim maths As Double = 0
    Dim pe As Double = 0
    Dim counter As Double = 0
    Private Sub button_submit_Click(sender As Object, e As EventArgs) Handles button_submit.Click

        Dim sr As New System.IO.StreamReader("E:\VB\markdata.csv")
        Dim linesInFile As Integer = 1
        Dim x As Integer = 0
        Label6.Text = x

        Do Until sr.EndOfStream = True
            linesInFile = linesInFile + 1
            Label5.Text = sr.ReadLine & vbNewLine
            Dim testArray() As String = Split(Label5.Text, Delimiter:=",")
            Dim y As Double

            Label1.Text = testArray(0)
            Label2.Text = testArray(1)
            Label3.Text = testArray(2)
            Label4.Text = testArray(3)
            'lbl_pe.Text = Val(testArray(5)) - Val(testArray(3))

            Label7.Text = Val(Label2.Text) + Val(Label3.Text) + Val(Label4.Text)
            y = ((Val(Label2.Text) + Val(Label3.Text) + Val(Label4.Text)) / 300) * 100
            Label8.Text = Str(Math.Round(Val(y), 2)) + "%"

            english = english + Val(Label2.Text)
            maths = maths + Val(Label3.Text)
            pe = pe + Val(Label4.Text)

            Label12.Text = Str(Math.Round(Val(english) / Val(counter), 2)) + "%"
            Label13.Text = Str(Math.Round(Val(maths) / Val(counter), 2)) + "%"
            Label14.Text = Str(Math.Round(Val(pe) / Val(counter), 2)) + "%"

            counter = counter + 1
            MsgBox("Next?", vbOK)

        Loop






    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_home.Click
        Me.Hide()
        Form1.Show()
        'Module1.main()
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles lbl_average.Click

    End Sub
End Class
