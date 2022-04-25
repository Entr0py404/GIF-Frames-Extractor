Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Public Class Form1
    Dim fd1 As Imaging.FrameDimension
    Dim GIF_FrameCount As Integer = 0
    Dim EventsOn As Boolean = False
    'Form1 - Load
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PixelBox1.AllowDrop = True
        'Load setttings
        ToolStripMenuItem_CompletionNotification.Checked = My.Settings.CompletionNotification
        EventsOn = True
    End Sub
    'PixelBox1 - DragDrop
    Private Sub PixelBox1_DragDrop(sender As Object, e As DragEventArgs) Handles PixelBox1.DragDrop
        Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        If files.Length <> 0 Then
            Try
                PixelBox1.Image = Nothing
                PixelBox1.Refresh()
                PixelBox1.Image = Image.FromFile(files(0))
                TextBox_FileName.Text = Path.GetFileNameWithoutExtension(files(0))
                TextBox_ExportDirectory.Clear()
                TextBox_ExportDirectory.AppendText(Path.GetDirectoryName(files(0)))
                fd1 = New Imaging.FrameDimension(PixelBox1.Image.FrameDimensionsList()(0))
                GIF_FrameCount = PixelBox1.Image.GetFrameCount(fd1)
                Label_FramesCount.Text = "Frames: " & GIF_FrameCount
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
    'PixelBox1 - DragEnter
    Private Sub PixelBox1_DragEnter(sender As Object, e As DragEventArgs) Handles PixelBox1.DragEnter
        Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        If e.Data.GetDataPresent(DataFormats.FileDrop) And Path.GetExtension(files(0)).ToLower = ".gif" Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    'Button_SelectExportDirectory - Click
    Private Sub Button_SelectExportDirectory_Click(sender As Object, e As EventArgs) Handles Button_SelectExportDirectory.Click
        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
            TextBox_ExportDirectory.Clear()
            TextBox_ExportDirectory.AppendText(FolderBrowserDialog1.SelectedPath)
        End If
    End Sub
    'Button_ExtractFrames - Click
    Private Sub Button_ExtractFrames_Click(sender As Object, e As EventArgs) Handles Button_ExtractFrames.Click
        If PixelBox1.Image IsNot Nothing Then
            PixelBox1.Enabled = False
            For index As Integer = 0 To GIF_FrameCount - 1
                PixelBox1.Image.SelectActiveFrame(fd1, index)
                PixelBox1.Invalidate()
                PixelBox1.Image.Save(TextBox_ExportDirectory.Text & "\" & TextBox_FileName.Text & "_" & index + 1 & ".png", Imaging.ImageFormat.Png)
            Next
            PixelBox1.Enabled = True

            ClearAllForNext()

            If ToolStripMenuItem_CompletionNotification.Checked Then
                MsgBox(GIF_FrameCount & " Frames extracted from gif.", MsgBoxStyle.Information)
            End If
        End If
    End Sub
    'ClearAllForNext
    Private Sub ClearAllForNext()
        TextBox_ExportDirectory.Clear()
        TextBox_FileName.Clear()
        PixelBox1.Image = Nothing
        PixelBox1.Refresh()
        Label_FramesCount.Text = "Frames:"
    End Sub
    'CleanInput
    Function CleanInput(strIn As String) As String
        ' Replace invalid characters with empty strings.
        Try
            'If we timeout when replacing invalid characters, we should return String.Empty.
            Return Regex.Replace(strIn, "[^\w\.@-]", "")
        Catch e As RegexMatchTimeoutException
            Return String.Empty
        End Try
    End Function
    'TextBox_FileName - KeyPress
    Private Sub TextBox_FileName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_FileName.KeyPress
        If Not e.KeyChar = ChrW(Keys.Back) Then
            If New String(Path.GetInvalidFileNameChars()).Contains(e.KeyChar.ToString) Then
                e.Handled = True
            End If
        End If
    End Sub
    'GetMemoryBitmapFromFile(path)
    Public Shared Function GetMemoryBitmapFromFile(path As String) As Bitmap
        Dim bm As Bitmap
        Using img As Image = Image.FromFile(path)
            bm = New Bitmap(img)
        End Using
        Return bm
    End Function
    'ToolStripMenuItem_Clear - Click
    Private Sub ToolStripMenuItem_Clear_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem_Clear.Click
        ClearAllForNext()
    End Sub
    '
    'Window Handle Code
    '
    'Move Window - Panel
    Private Sub Panel_Main_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel_Main.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Panel_Main.Capture = False
            Const WM_NCLBUTTONDOWN As Integer = &HA1S
            Const HTCAPTION As Integer = 2
            Dim msg As Message = Message.Create(Me.Handle, WM_NCLBUTTONDOWN, New IntPtr(HTCAPTION), IntPtr.Zero)
            Me.DefWndProc(msg)
        End If
    End Sub
    'Move Window - Label_Application_Title
    Private Sub Label_Application_Title_MouseDown(sender As Object, e As MouseEventArgs) Handles Label_Application_Title.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Label_Application_Title.Capture = False
            Const WM_NCLBUTTONDOWN As Integer = &HA1S
            Const HTCAPTION As Integer = 2
            Dim msg As Message = Message.Create(Me.Handle, WM_NCLBUTTONDOWN, New IntPtr(HTCAPTION), IntPtr.Zero)
            Me.DefWndProc(msg)
        End If
    End Sub
    'Minimize
    Private Sub PictureBox_Minimize_Click(sender As Object, e As EventArgs) Handles PictureBox_Minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    'Close
    Private Sub PictureBox_Close_Click(sender As Object, e As EventArgs) Handles PictureBox_Close.Click
        Me.Close()
    End Sub
    'Minimize Blue
    Private Sub PictureBox_Minimize_MouseHover(sender As Object, e As EventArgs) Handles PictureBox_Minimize.MouseHover
        PictureBox_Minimize.Image = My.Resources.Minimize_Blue
    End Sub
    'Minimize Grey
    Private Sub PictureBox_Minimize_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox_Minimize.MouseLeave
        PictureBox_Minimize.Image = My.Resources.Minimize_Grey
    End Sub
    'Form Deactivate Close Grey
    Private Sub Main_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        PictureBox_Close.Image = My.Resources.Close_Grey
        Panel_Main.BackColor = Color.FromArgb(28, 30, 34)
    End Sub
    'Form Activated Close Red
    Private Sub Main_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        PictureBox_Close.Image = My.Resources.Close_Red
        Panel_Main.BackColor = Color.Black
    End Sub
    'ToolStripMenuItem1 - DropDownClosed
    Private Sub ToolStripMenuItem1_DropDownClosed(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.DropDownClosed
        ToolStripMenuItem1.ForeColor = Color.WhiteSmoke
    End Sub
    'ToolStripMenuItem1 - DropDownOpened
    Private Sub ToolStripMenuItem1_DropDownOpened(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.DropDownOpened
        ToolStripMenuItem1.ForeColor = Color.Black
    End Sub
    'CompletionNotificationToolStripMenuItem - CheckedChanged
    Private Sub CompletionNotificationToolStripMenuItem_CheckedChanged(sender As Object, e As EventArgs) Handles ToolStripMenuItem_CompletionNotification.CheckedChanged
        If EventsOn = True Then
            My.Settings.CompletionNotification = ToolStripMenuItem_CompletionNotification.Checked
        End If
    End Sub
End Class

Public Class PixelBox
    Inherits PictureBox

    <Category("Behavior")>
    <DefaultValue(InterpolationMode.NearestNeighbor)>
    Public Property InterpolationMode As InterpolationMode = InterpolationMode.NearestNeighbor

    <Category("Behavior")>
    <DefaultValue(PixelOffsetMode.Default)>
    Public Property PixelOffsetMode As PixelOffsetMode = PixelOffsetMode.Default

    <Category("Behavior")>
    <DefaultValue(SmoothingMode.Default)>
    Public Property SmoothingMode As SmoothingMode = SmoothingMode.Default

    <Category("Behavior")>
    <DefaultValue(CompositingQuality.Default)>
    Public Property CompositingQuality As CompositingQuality = CompositingQuality.Default

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        e.Graphics.InterpolationMode = Me.InterpolationMode
        e.Graphics.PixelOffsetMode = Me.PixelOffsetMode
        e.Graphics.SmoothingMode = Me.SmoothingMode
        e.Graphics.CompositingQuality = Me.CompositingQuality
        MyBase.OnPaint(e)
    End Sub
End Class