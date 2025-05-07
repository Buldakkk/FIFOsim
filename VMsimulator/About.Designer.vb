<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(About))
        btnFifo = New Button()
        lblAbout = New Label()
        Label8 = New Label()
        SuspendLayout()
        ' 
        ' btnFifo
        ' 
        btnFifo.BackgroundImage = CType(resources.GetObject("btnFifo.BackgroundImage"), Image)
        btnFifo.BackgroundImageLayout = ImageLayout.Zoom
        btnFifo.FlatStyle = FlatStyle.Flat
        btnFifo.ForeColor = Color.SaddleBrown
        btnFifo.Location = New Point(43, 35)
        btnFifo.Name = "btnFifo"
        btnFifo.Size = New Size(104, 57)
        btnFifo.TabIndex = 1
        btnFifo.UseVisualStyleBackColor = True
        ' 
        ' lblAbout
        ' 
        lblAbout.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblAbout.BackColor = Color.Transparent
        lblAbout.Font = New Font("Tw Cen MT", 18F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblAbout.ForeColor = Color.SaddleBrown
        lblAbout.Location = New Point(0, 95)
        lblAbout.Name = "lblAbout"
        lblAbout.Size = New Size(1324, 663)
        lblAbout.TabIndex = 9
        lblAbout.Text = resources.GetString("lblAbout.Text")
        lblAbout.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Tw Cen MT Condensed Extra Bold", 26F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.SaddleBrown
        Label8.Location = New Point(481, 263)
        Label8.Name = "Label8"
        Label8.Size = New Size(362, 61)
        Label8.TabIndex = 10
        Label8.Text = "FIFO ALGORITHM"
        ' 
        ' About
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1324, 758)
        Controls.Add(Label8)
        Controls.Add(lblAbout)
        Controls.Add(btnFifo)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "About"
        StartPosition = FormStartPosition.CenterScreen
        Text = "About"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnFifo As Button
    Friend WithEvents lblAbout As Label
    Friend WithEvents Label8 As Label
End Class
