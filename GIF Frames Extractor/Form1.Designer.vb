<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Label_ExportDirectory = New System.Windows.Forms.Label()
        Me.Label_FileName = New System.Windows.Forms.Label()
        Me.TextBox_FileName = New System.Windows.Forms.TextBox()
        Me.TextBox_ExportDirectory = New System.Windows.Forms.TextBox()
        Me.Panel_Main = New System.Windows.Forms.Panel()
        Me.Panel_ControlBox = New System.Windows.Forms.Panel()
        Me.PictureBox_Close = New System.Windows.Forms.PictureBox()
        Me.PictureBox_Minimize = New System.Windows.Forms.PictureBox()
        Me.Label_Application_Title = New System.Windows.Forms.Label()
        Me.PictureBox_AppIcon = New System.Windows.Forms.PictureBox()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button_SelectExportDirectory = New System.Windows.Forms.Button()
        Me.Button_ExtractFrames = New System.Windows.Forms.Button()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label_FramesCount = New System.Windows.Forms.Label()
        Me.ShapeContainer3 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_Clear = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_CompletionNotification = New System.Windows.Forms.ToolStripMenuItem()
        Me.PixelBox1 = New GIF_Frames_Extractor.PixelBox()
        Me.Panel_Main.SuspendLayout()
        Me.Panel_ControlBox.SuspendLayout()
        CType(Me.PictureBox_Close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Minimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_AppIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PixelBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label_ExportDirectory
        '
        Me.Label_ExportDirectory.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_ExportDirectory.Location = New System.Drawing.Point(8, 64)
        Me.Label_ExportDirectory.Name = "Label_ExportDirectory"
        Me.Label_ExportDirectory.Size = New System.Drawing.Size(120, 23)
        Me.Label_ExportDirectory.TabIndex = 24
        Me.Label_ExportDirectory.Text = "Export Directory"
        Me.Label_ExportDirectory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_FileName
        '
        Me.Label_FileName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_FileName.Location = New System.Drawing.Point(8, 8)
        Me.Label_FileName.Name = "Label_FileName"
        Me.Label_FileName.Size = New System.Drawing.Size(80, 24)
        Me.Label_FileName.TabIndex = 23
        Me.Label_FileName.Text = "File Name"
        Me.Label_FileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox_FileName
        '
        Me.TextBox_FileName.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TextBox_FileName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_FileName.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox_FileName.Location = New System.Drawing.Point(16, 40)
        Me.TextBox_FileName.Name = "TextBox_FileName"
        Me.TextBox_FileName.Size = New System.Drawing.Size(224, 13)
        Me.TextBox_FileName.TabIndex = 1
        '
        'TextBox_ExportDirectory
        '
        Me.TextBox_ExportDirectory.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TextBox_ExportDirectory.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_ExportDirectory.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox_ExportDirectory.Location = New System.Drawing.Point(16, 96)
        Me.TextBox_ExportDirectory.Name = "TextBox_ExportDirectory"
        Me.TextBox_ExportDirectory.ReadOnly = True
        Me.TextBox_ExportDirectory.Size = New System.Drawing.Size(224, 13)
        Me.TextBox_ExportDirectory.TabIndex = 2
        Me.TextBox_ExportDirectory.TabStop = False
        '
        'Panel_Main
        '
        Me.Panel_Main.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Panel_Main.Controls.Add(Me.Panel_ControlBox)
        Me.Panel_Main.Controls.Add(Me.Label_Application_Title)
        Me.Panel_Main.Controls.Add(Me.PictureBox_AppIcon)
        Me.Panel_Main.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Main.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Panel_Main.ForeColor = System.Drawing.Color.White
        Me.Panel_Main.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Main.Name = "Panel_Main"
        Me.Panel_Main.Size = New System.Drawing.Size(330, 26)
        Me.Panel_Main.TabIndex = 79
        '
        'Panel_ControlBox
        '
        Me.Panel_ControlBox.Controls.Add(Me.PictureBox_Close)
        Me.Panel_ControlBox.Controls.Add(Me.PictureBox_Minimize)
        Me.Panel_ControlBox.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel_ControlBox.Location = New System.Drawing.Point(278, 0)
        Me.Panel_ControlBox.Name = "Panel_ControlBox"
        Me.Panel_ControlBox.Size = New System.Drawing.Size(52, 26)
        Me.Panel_ControlBox.TabIndex = 4
        '
        'PictureBox_Close
        '
        Me.PictureBox_Close.Image = Global.GIF_Frames_Extractor.My.Resources.Resources.Close_Grey
        Me.PictureBox_Close.Location = New System.Drawing.Point(30, 5)
        Me.PictureBox_Close.Name = "PictureBox_Close"
        Me.PictureBox_Close.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox_Close.TabIndex = 0
        Me.PictureBox_Close.TabStop = False
        '
        'PictureBox_Minimize
        '
        Me.PictureBox_Minimize.Image = Global.GIF_Frames_Extractor.My.Resources.Resources.Minimize_Grey
        Me.PictureBox_Minimize.Location = New System.Drawing.Point(8, 5)
        Me.PictureBox_Minimize.Name = "PictureBox_Minimize"
        Me.PictureBox_Minimize.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox_Minimize.TabIndex = 1
        Me.PictureBox_Minimize.TabStop = False
        '
        'Label_Application_Title
        '
        Me.Label_Application_Title.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label_Application_Title.Location = New System.Drawing.Point(30, 0)
        Me.Label_Application_Title.Name = "Label_Application_Title"
        Me.Label_Application_Title.Size = New System.Drawing.Size(202, 26)
        Me.Label_Application_Title.TabIndex = 2
        Me.Label_Application_Title.Text = "GIF Frames Extractor"
        Me.Label_Application_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox_AppIcon
        '
        Me.PictureBox_AppIcon.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox_AppIcon.Image = Global.GIF_Frames_Extractor.My.Resources.Resources.Application_Icon
        Me.PictureBox_AppIcon.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox_AppIcon.Name = "PictureBox_AppIcon"
        Me.PictureBox_AppIcon.Size = New System.Drawing.Size(30, 26)
        Me.PictureBox_AppIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox_AppIcon.TabIndex = 3
        Me.PictureBox_AppIcon.TabStop = False
        '
        'RectangleShape3
        '
        Me.RectangleShape3.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.RectangleShape3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.RectangleShape3.CornerRadius = 3
        Me.RectangleShape3.FillColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape3.FillGradientColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape3.Location = New System.Drawing.Point(0, 0)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.SelectionColor = System.Drawing.Color.Transparent
        Me.RectangleShape3.Size = New System.Drawing.Size(312, 224)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.RectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.RectangleShape1.CornerRadius = 3
        Me.RectangleShape1.FillColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape1.FillGradientColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape1.Location = New System.Drawing.Point(8, 32)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.SelectionColor = System.Drawing.Color.Transparent
        Me.RectangleShape1.Size = New System.Drawing.Size(240, 24)
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.RectangleShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.RectangleShape2.CornerRadius = 3
        Me.RectangleShape2.FillColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape2.FillGradientColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape2.Location = New System.Drawing.Point(8, 88)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.SelectionColor = System.Drawing.Color.Transparent
        Me.RectangleShape2.Size = New System.Drawing.Size(240, 24)
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(312, 13)
        Me.Label1.TabIndex = 81
        Me.Label1.Text = "Drag And Drop GIF Here"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button_SelectExportDirectory)
        Me.Panel1.Controls.Add(Me.Button_ExtractFrames)
        Me.Panel1.Controls.Add(Me.TextBox_ExportDirectory)
        Me.Panel1.Controls.Add(Me.Label_ExportDirectory)
        Me.Panel1.Controls.Add(Me.Label_FileName)
        Me.Panel1.Controls.Add(Me.TextBox_FileName)
        Me.Panel1.Controls.Add(Me.ShapeContainer2)
        Me.Panel1.Location = New System.Drawing.Point(8, 328)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(320, 168)
        Me.Panel1.TabIndex = 82
        '
        'Button_SelectExportDirectory
        '
        Me.Button_SelectExportDirectory.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button_SelectExportDirectory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button_SelectExportDirectory.FlatAppearance.BorderSize = 0
        Me.Button_SelectExportDirectory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_SelectExportDirectory.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_SelectExportDirectory.Location = New System.Drawing.Point(256, 88)
        Me.Button_SelectExportDirectory.Name = "Button_SelectExportDirectory"
        Me.Button_SelectExportDirectory.Size = New System.Drawing.Size(56, 24)
        Me.Button_SelectExportDirectory.TabIndex = 3
        Me.Button_SelectExportDirectory.Text = "..."
        Me.Button_SelectExportDirectory.UseVisualStyleBackColor = False
        '
        'Button_ExtractFrames
        '
        Me.Button_ExtractFrames.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Button_ExtractFrames.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button_ExtractFrames.FlatAppearance.BorderSize = 0
        Me.Button_ExtractFrames.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_ExtractFrames.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_ExtractFrames.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Button_ExtractFrames.Location = New System.Drawing.Point(24, 128)
        Me.Button_ExtractFrames.Name = "Button_ExtractFrames"
        Me.Button_ExtractFrames.Size = New System.Drawing.Size(208, 32)
        Me.Button_ExtractFrames.TabIndex = 4
        Me.Button_ExtractFrames.Text = "Extract Frames"
        Me.Button_ExtractFrames.UseVisualStyleBackColor = False
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape2, Me.RectangleShape1})
        Me.ShapeContainer2.Size = New System.Drawing.Size(320, 168)
        Me.ShapeContainer2.TabIndex = 25
        Me.ShapeContainer2.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label_FramesCount)
        Me.Panel2.Controls.Add(Me.PixelBox1)
        Me.Panel2.Controls.Add(Me.ShapeContainer3)
        Me.Panel2.Location = New System.Drawing.Point(8, 96)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(320, 232)
        Me.Panel2.TabIndex = 83
        '
        'Label_FramesCount
        '
        Me.Label_FramesCount.AutoSize = True
        Me.Label_FramesCount.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Label_FramesCount.Location = New System.Drawing.Point(8, 208)
        Me.Label_FramesCount.Name = "Label_FramesCount"
        Me.Label_FramesCount.Size = New System.Drawing.Size(44, 13)
        Me.Label_FramesCount.TabIndex = 26
        Me.Label_FramesCount.Text = "Frames:"
        '
        'ShapeContainer3
        '
        Me.ShapeContainer3.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer3.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer3.Name = "ShapeContainer3"
        Me.ShapeContainer3.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape3})
        Me.ShapeContainer3.Size = New System.Drawing.Size(320, 232)
        Me.ShapeContainer3.TabIndex = 1
        Me.ShapeContainer3.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 26)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(330, 32)
        Me.MenuStrip1.TabIndex = 86
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem_Clear, Me.ToolStripMenuItem_CompletionNotification})
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStripMenuItem1.Image = Global.GIF_Frames_Extractor.My.Resources.Resources.Settings
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(85, 28)
        Me.ToolStripMenuItem1.Text = "Settings"
        '
        'ToolStripMenuItem_Clear
        '
        Me.ToolStripMenuItem_Clear.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ToolStripMenuItem_Clear.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStripMenuItem_Clear.Image = Global.GIF_Frames_Extractor.My.Resources.Resources.Clear
        Me.ToolStripMenuItem_Clear.Name = "ToolStripMenuItem_Clear"
        Me.ToolStripMenuItem_Clear.Size = New System.Drawing.Size(203, 22)
        Me.ToolStripMenuItem_Clear.Text = "Clear"
        '
        'ToolStripMenuItem_CompletionNotification
        '
        Me.ToolStripMenuItem_CompletionNotification.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ToolStripMenuItem_CompletionNotification.Checked = True
        Me.ToolStripMenuItem_CompletionNotification.CheckOnClick = True
        Me.ToolStripMenuItem_CompletionNotification.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolStripMenuItem_CompletionNotification.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStripMenuItem_CompletionNotification.Image = Global.GIF_Frames_Extractor.My.Resources.Resources.Notification
        Me.ToolStripMenuItem_CompletionNotification.Name = "ToolStripMenuItem_CompletionNotification"
        Me.ToolStripMenuItem_CompletionNotification.Size = New System.Drawing.Size(203, 22)
        Me.ToolStripMenuItem_CompletionNotification.Text = "Completion Notification"
        '
        'PixelBox1
        '
        Me.PixelBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.PixelBox1.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality
        Me.PixelBox1.Location = New System.Drawing.Point(8, 8)
        Me.PixelBox1.Name = "PixelBox1"
        Me.PixelBox1.Size = New System.Drawing.Size(296, 208)
        Me.PixelBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PixelBox1.TabIndex = 27
        Me.PixelBox1.TabStop = False
        '
        'Form1
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(330, 498)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel_Main)
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GIF Frames Extractor"
        Me.Panel_Main.ResumeLayout(False)
        Me.Panel_ControlBox.ResumeLayout(False)
        CType(Me.PictureBox_Close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Minimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_AppIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PixelBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button_ExtractFrames As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents Button_SelectExportDirectory As Button
    Friend WithEvents Label_ExportDirectory As Label
    Friend WithEvents Label_FileName As Label
    Friend WithEvents TextBox_FileName As TextBox
    Friend WithEvents TextBox_ExportDirectory As TextBox
    Friend WithEvents Panel_Main As Panel
    Friend WithEvents Panel_ControlBox As Panel
    Friend WithEvents PictureBox_Close As PictureBox
    Friend WithEvents PictureBox_Minimize As PictureBox
    Friend WithEvents Label_Application_Title As Label
    Friend WithEvents PictureBox_AppIcon As PictureBox
    Friend WithEvents RectangleShape2 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape1 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape3 As PowerPacks.RectangleShape
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ShapeContainer2 As PowerPacks.ShapeContainer
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ShapeContainer3 As PowerPacks.ShapeContainer
    Friend WithEvents Label_FramesCount As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem_Clear As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem_CompletionNotification As ToolStripMenuItem
    Friend WithEvents PixelBox1 As PixelBox
End Class
