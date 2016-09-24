Public Class Form1
    Dim sPathOrigen As String = "D:\Calibre eBooks (Pral)\__Pte colocar" ' Directorio por defecto donde estan los libros a mover    
    Dim sPathDestino As String = "D:\Calibre eBooks (Pral)"     ' direcotrio inicial a donde mover los libros   


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateTextBoxes()
    End Sub

    Sub UpdateTextBoxes()
        Me.TextBox1.Text = sPathOrigen.ToString
        Me.TextBox2.Text = sPathDestino.ToString
    End Sub

    Private Sub ButtonOrigen_Click(sender As Object, e As EventArgs)

        ' abre un dialog para elegir un nuevo folder.
        sPathOrigen = ElegirDirectorio(sPathOrigen)
        UpdateTextBoxes()

    End Sub

    Private Sub ButtonCancelar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub ButtonDestino_Click(sender As Object, e As EventArgs)
        ' abre un dialog para elegir un nuevo folder.
        sPathDestino = ElegirDirectorio(sPathDestino)
        UpdateTextBoxes()

    End Sub

    Function ElegirDirectorio(ByVal sInitialPath As String) As String

        ' Funcion que utiliza el objeto FolderBrowserDialog para que el usuario elija un directorio. Si se presiona CANCEL el no selecciona nada.
        With FolderBrowserDialog1
            .SelectedPath = sInitialPath
            .ShowDialog()
            ElegirDirectorio = .SelectedPath
        End With

    End Function

    Private Sub ButtonMover_Click(sender As Object, e As EventArgs)
        ' Mover todos los directorios que existen en el path orgines y que empiezan con la letra A al 
        ' directorio destino + "_A"
        Dim Alfabeto As String() = {"A", "B", "C", "D", "E", "F", "G", "H", "G", "I", "J", "K", "L", "M", "N", "O", "P",
                   "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"}

        Dim s As String = ""
        Button1.Visible = True
        For Each s In Alfabeto
            MoverDirectorios(s)
        Next
        Button1.Visible = False
    End Sub

    Sub MoverDirectorios(sLetra)
        ' Identficar los directorios que existen en el path origen
        Dim origen As String = sPathOrigen
        Dim sSearchPattern As String = sLetra & "*"
        Dim directorios As String() = System.IO.Directory.GetDirectories(origen & "\", sSearchPattern)  ' devuelve un array con todos los ficheros que cumplen los criterios recibidos como argumento

        Dim i As Integer = 1
        Dim destino As String
        Dim dirName As String


        Me.LabelLetra.Text = " moviendo directorios con la letra : " & sLetra & " (" & "Numero de archivos " & directorios.Count & ")."
        Refresh()


        ' Mover cada directorio encontrado 
        For i = 0 To directorios.GetUpperBound(0)
            Try
                dirName = IO.Path.GetFileName(directorios(i))
                destino = sPathDestino & "\_" & sLetra & "\" & dirName & "\"
                LabelDirectorio.Text = directorios(i)
                Refresh()
                My.Computer.FileSystem.MoveDirectory(directorios(i), destino, True)           ' Mover un folder del origen al destino sobreescribiendo caso necesario.

            Catch ex As Exception
                Debug.Print(directorios(i) & " " & ex.Message)
            End Try
        Next


        Me.LabelLetra.Text = ""
        LabelDirectorio.Text = ""
        Me.Refresh()
        My.Application.DoEvents()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        MsgBox("Se va a cancelar la ejecucion del programa")
        Me.Close()
    End Sub

    Sub ListarDirectoriosEncontrados(ByVal a() As String)
        Dim i As Integer = 0
        Dim s As String
        Dim texto As String = ""

        For Each s In a
            texto = texto & s & vbCrLf
        Next

        MsgBox(texto)


    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("Mover libros. Ultima actualizacion: 24 septiembre de 2016")
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Label1_Enter(sender As Object, e As EventArgs) Handles Label1.Enter

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
