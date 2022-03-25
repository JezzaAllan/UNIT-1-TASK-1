Public Class Form4
    Dim bigarray(100, 200) As String 'declare array large enough for dataset
    Dim icount As Integer
    Dim linesInFile As Integer = 0
    Dim columns As Integer
    Dim sr As New System.IO.StreamReader("E:\VB\markdata.csv")
    Dim x, y As Integer

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Do Until sr.EndOfStream = True

            linesInFile = linesInFile + 1 ' indicates the number of rows, j

            Label9.Text = sr.ReadLine & vbNewLine
            'the test array splits the label2 into array items seperated by a comma
            Dim testArray() As String = Split(Label9.Text, Delimiter:=",")
            'MsgBox(testArray.Length) ' 7 columns in 1 row. testArray.length=7

            For columns = 0 To (testArray.Length - 1)
                bigarray(columns, linesInFile) = testArray(columns)
            Next
        Loop

    End Sub

    Private Sub student(sender As Object, e As EventArgs) Handles btn_student.Click

        Label13.Text = ""
        Label14.Text = ""
        Label15.Text = ""
        Label16.Text = ""
        Label17.Text = ""
        Label18.Text = ""



        Dim student As String
        Dim array(3) As String
        Dim place As Integer
        student = (InputBox("Enter the name of the student:"))
        lbl_display.Text = "Now displaying: " + student

        For x = 0 To linesInFile
            If bigarray(0, x) = student Then
                For y = 0 To 2
                    array(y) = bigarray(y + 1, x)
                Next
                place = x

            End If
        Next

        'MsgBox(array(0))
        'MsgBox(array(2))

        System.Array.Sort(array)

        Label21.Text = array(1)
        Label20.Text = array(2)
        Label19.Text = array(3)

        Dim count As Integer = 1
        'MsgBox(place)
        'MsgBox(bigarray(0, place))

        For count = 1 To 3
            'MsgBox(bigarray(place, count))

            If bigarray(count, place) = array(1) Then
                'MsgBox(count)
                Label10.Text = bigarray(count, 1) '1 cause moved down?
                'MsgBox("found 1" + bigarray(count, 0))
            ElseIf bigarray(count, place) = array(2) Then
                ' MsgBox(count)
                Label11.Text = bigarray(count, 1)
                'MsgBox("found 2" + bigarray(count, 0))
            ElseIf bigarray(count, place) = array(3) Then
                'MsgBox(count)
                Label12.Text = bigarray(count, 1)
                ' MsgBox("found 3" + bigarray(count, 0))

            End If
        Next

    End Sub



    Private Sub btn_subject_Click(sender As Object, e As EventArgs) Handles btn_subject.Click
        Dim subject As String
        Dim sarray(6) As String
        Dim places As Integer
        subject = (InputBox("Enter the name of the subject:"))
        Dim c As Integer = 1
        Dim d As Integer = 0



        lbl_display.Text = "Now displaying: " + subject


        bigarray(3, 1) = "PE"
        Dim found As Boolean = False

        For c = 1 To 3
            'MsgBox(bigarray(c, 1))
            If bigarray(c, 1) = subject Then
                'MsgBox("found")
                For d = 0 To 6
                    sarray(d) = bigarray(c, d + 1)
                Next
                places = c
                found = True
            Else
                'MsgBox(bigarray(c, 1) + " not equal to " + subject)
            End If
        Next

        If found = False Then
            MsgBox("No enteries found for that subjuct")
            Label13.Text = ""
            Label14.Text = ""
            Label15.Text = ""
            Label16.Text = ""
            Label17.Text = ""
            Label18.Text = ""
            Label12.Text = ""
            Label11.Text = ""
            Label10.Text = ""

            lbl_award.Text = "Award: "
            lbl_markd.Text = "Mark: "
        End If

        System.Array.Sort(sarray)

        Label21.Text = sarray(5)
        Label20.Text = sarray(4)
        Label19.Text = sarray(3)
        Label18.Text = sarray(2)
        Label17.Text = sarray(1)
        Label16.Text = sarray(0)

        Dim count As Integer = 1
        'MsgBox(place)
        'MsgBox(bigarray(0, place))
        'MsgBox(bigarray(2, 2))
        Dim coun As Integer
        Dim zero As Integer
        Dim one As Integer
        Dim two As Integer
        Dim three As Integer
        Dim four As Integer

        For coun = 0 To 7
            If zero < 1 And bigarray(places, coun) = sarray(0) Then
                'MsgBox(count)
                Label15.Text = bigarray(0, coun)
                zero = 1
                'MsgBox("found 1")
            ElseIf one < 1 And bigarray(places, coun) = sarray(1) Then
                'MsgBox(count)
                Label14.Text = bigarray(0, coun)
                one = 1
                'MsgBox("found 2")
            ElseIf two < 1 And bigarray(places, coun) = sarray(2) Then
                'MsgBox(count)
                Label13.Text = bigarray(0, coun)
                two = 1
                'MsgBox("found 3")
            ElseIf three < 1 And bigarray(places, coun) = sarray(3) Then
                'MsgBox(count)
                Label12.Text = bigarray(0, coun)
                three = 1
                'MsgBox("found 2")
            ElseIf four < 1 And bigarray(places, coun) = sarray(4) Then
                'MsgBox(count)
                Label11.Text = bigarray(0, coun)
                four = 1
                'MsgBox("found 3")
            ElseIf bigarray(places, coun) = sarray(5) Then
                'MsgBox(count)
                Label10.Text = bigarray(0, coun)
                'MsgBox("found 3")

            End If
        Next

        If found = True Then
            If Label21.Text = Label20.Text Then
                lbl_award.Text = "Award: " + Label10.Text + " and " + Label11.Text
                lbl_markd.Text = "Mark: " + Label21.Text
            Else
                lbl_award.Text = "Award: " + Label10.Text
                lbl_markd.Text = "Mark: " + Label21.Text
            End If
        End If

    End Sub



    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click
        Me.Hide()
        Form1.Show()
    End Sub

End Class