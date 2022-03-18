Class Form3
    Dim bigarray(100, 200) As String 'declare array large enough for dataset
    Dim icount As Integer
    Dim linesInFile As Integer = 0
    Dim columns As Integer
    Dim sr As New System.IO.StreamReader("E:\VB\markdata.csv")
    Dim x, y As Integer
    Dim english As Double
    Dim maths As Double
    Dim pe As Double
    Private Sub Search_Click(sender As Object, e As EventArgs) Handles btn_search.Click

        'Prompt for search entries
        MsgBox("Loading file")
        '(columns, rows)

        'Load the whole database into a 2 dimension array - bigarray
        Do Until sr.EndOfStream = True

            linesInFile = linesInFile + 1 ' indicates the number of rows, j

            lbl_holder.Text = sr.ReadLine & vbNewLine
            'the test array splits the label2 into array items seperated by a comma
            Dim testArray() As String = Split(lbl_holder.Text, Delimiter:=",")
            'MsgBox(testArray.Length) ' 7 columns in 1 row. testArray.length=7

            For columns = 0 To (testArray.Length - 1)
                bigarray(columns, linesInFile) = testArray(columns)
            Next
        Loop
        x = columns
        y = linesInFile
        'Test if data sucessfully saved
        'MsgBox(bigarray(0, 2)) ' understanding silicon life
        'MsgBox(bigarray(0, 1)) ' This is the title row (not data)
        MsgBox("Let's find our entry")

        Dim student As String
        student = InputBox("What is the name of the student?")
        'purchasertofind = InputBox("What is the name of the subject?")


        Dim validation As Boolean
        Dim sfound As Boolean = False
        Dim blank As Boolean = False

        validation = IsNumeric((student))

        'MsgBox(linesInFile)
        If student = "" Then
            blank = True
        End If

        If blank = False Then


            If validation = False Then
                For icount = 0 To linesInFile

                    'MsgBox("Count = " + Str(icount))
                    If bigarray(0, icount) = student Then 'And bigarray(2, icount) = purchasertofind Then
                        MsgBox("Student found at Count = " + Str(icount))

                        sfound = True
                        'MsgBox("CSV loaded successfully!")
                        lbl_found_student.Text = bigarray(0, icount)
                        lbl_found_english.Text = bigarray(1, icount)
                        lbl_found_maths.Text = bigarray(2, icount)
                        lbl_found_pe.Text = bigarray(3, icount)


                        'MsgBox("Click button on right to rate book")

                        'Button2.Enabled = True
                        'rate the book


                    End If

                Next
            Else
                MsgBox("Please enter a valid student name")
                sfound = True
            End If

            If sfound = False Then
                MsgBox("Sorry, there was no match. Let's try again.")
            End If
        Else
            MsgBox("Please enter a valid student name")
        End If


    End Sub

    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub btn_submit_Click(sender As Object, e As EventArgs)

        'this code will save the entire array in a new CSV file
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("E:\newmarkdata.csv", True)
        Dim coloumns As Integer = 0
        Dim c1 As Integer = 0
        Dim rows = 7

        Dim x As Integer
        x = bigarray.Length

        For c1 = 0 To (rows - 1)
            For columns = 0 To 4
                If columns = 4 Then
                    file.WriteLine(bigarray(columns, c1) + ",")
                Else
                    file.Write(bigarray(columns, c1) + ",")
                End If
            Next
            'write an if else so that at the written line, a comma is not written
            'there is a small bug here. Please correct it.
        Next

        file.Close()
        MsgBox("Finished writing to file!")
    End Sub

End Class