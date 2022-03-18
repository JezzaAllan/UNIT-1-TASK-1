Public Class Form1
    Dim counter As Integer = 0
    Dim array(100, 200) As String

    Private Sub Enter(sender As Object, e As EventArgs) Handles btn_student.Click
        Dim name As String
        Dim testa As Boolean
        Dim testb As Boolean
        Dim testc As Boolean

        testa = IsNumeric((txt_english.Text))
        testb = IsNumeric((txt_maths.Text))
        testc = IsNumeric((txt_pe.Text))
        'MsgBox(testa)
        'MsgBox(testb)
        If testa = True And testb = True And testc = True Then


            array(0, 0) = " "
            array(1, 0) = "English"
            array(2, 0) = "Maths"
            array(3, 0) = "Pe"


            name = lbl_name.Text


            If counter >= 0 And counter <= 5 Then
                array(0, counter + 1) = name
                array(1, counter + 1) = txt_english.Text
                array(2, counter + 1) = txt_maths.Text
                array(3, counter + 1) = txt_pe.Text
                counter = counter + 1

                txt_english.Text = " "
                txt_maths.Text = " "
                txt_pe.Text = " "

                MsgBox("Marks entered successfully")
            Else
                MsgBox("Error")
            End If

            If counter = 0 Then
                lbl_name.Text = "John"
            ElseIf counter = 1 Then
                lbl_name.Text = "Damien"
            ElseIf counter = 2 Then
                lbl_name.Text = "Mark"
            ElseIf counter = 3 Then
                lbl_name.Text = "Joshua"
            ElseIf counter = 4 Then
                lbl_name.Text = "Mary"
            ElseIf counter = 5 Then
                lbl_name.Text = "Maria"

            End If
        Else
            MsgBox("Please enter valid marks")
            txt_english.Text = " "
            txt_maths.Text = " "
            txt_pe.Text = " "
        End If
    End Sub




    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles button_submit.Click

        'this code will save the entire array in a new CSV file
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("E:\newmarksagain.csv", True)
        Dim coloumns As Integer = 0
        Dim c1 As Integer = 0
        Dim rows = 7

        Dim x As Integer
        x = array.Length

        For c1 = 0 To (rows - 1)
            For columns = 0 To 4
                If columns = 4 Then
                    file.WriteLine(array(columns, c1) + ",")
                Else
                    file.Write(array(columns, c1) + ",")
                End If
            Next
            'write an if else so that at the written line, a comma is not written
            'there is a small bug here. Please correct it.
        Next

        file.Close()
        MsgBox("Finished writing to file!")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form2.Show()
        'Module1.main()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form3.Show()
        'Module1.main()
    End Sub
End Class