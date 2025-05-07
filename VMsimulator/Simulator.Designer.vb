<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Simulator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Simulator))
        Label1 = New Label()
        lblVMS = New Label()
        Label2 = New Label()
        pnlOutput = New Panel()
        pnlFifo = New Panel()
        lblPageFaults = New Label()
        lblPageFault = New Label()
        Label9 = New Label()
        lblNoOfStringOutput = New Label()
        lblRefStringOutput = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Panel2 = New Panel()
        btnAbout = New Button()
        btnHome = New Button()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        lblRefStringInput = New Label()
        cmbNoOfString = New ComboBox()
        btnGenerate = New Button()
        btnSimulate = New Button()
        pnlOutput.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Location = New Point(670, 88)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 25)
        Label1.TabIndex = 0
        ' 
        ' lblVMS
        ' 
        lblVMS.Anchor = AnchorStyles.Top
        lblVMS.AutoSize = True
        lblVMS.BackColor = Color.Transparent
        lblVMS.Font = New Font("Vivaldi", 36F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblVMS.ForeColor = Color.SaddleBrown
        lblVMS.Location = New Point(758, 113)
        lblVMS.Name = "lblVMS"
        lblVMS.Size = New Size(195, 86)
        lblVMS.TabIndex = 2
        lblVMS.Text = "Input"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Vivaldi", 36F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.SaddleBrown
        Label2.Location = New Point(736, 49)
        Label2.Name = "Label2"
        Label2.Size = New Size(205, 86)
        Label2.TabIndex = 3
        Label2.Text = "Output"
        ' 
        ' pnlOutput
        ' 
        pnlOutput.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlOutput.BackgroundImage = CType(resources.GetObject("pnlOutput.BackgroundImage"), Image)
        pnlOutput.Controls.Add(pnlFifo)
        pnlOutput.Controls.Add(lblPageFaults)
        pnlOutput.Controls.Add(lblPageFault)
        pnlOutput.Controls.Add(Label9)
        pnlOutput.Controls.Add(lblNoOfStringOutput)
        pnlOutput.Controls.Add(lblRefStringOutput)
        pnlOutput.Controls.Add(Label7)
        pnlOutput.Controls.Add(Label8)
        pnlOutput.Controls.Add(Label2)
        pnlOutput.Location = New Point(12, 468)
        pnlOutput.Name = "pnlOutput"
        pnlOutput.Size = New Size(1687, 685)
        pnlOutput.TabIndex = 4
        ' 
        ' pnlFifo
        ' 
        pnlFifo.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlFifo.AutoScroll = True
        pnlFifo.BackColor = Color.Tan
        pnlFifo.Location = New Point(29, 303)
        pnlFifo.Name = "pnlFifo"
        pnlFifo.Size = New Size(1632, 358)
        pnlFifo.TabIndex = 20
        ' 
        ' lblPageFaults
        ' 
        lblPageFaults.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        lblPageFaults.AutoSize = True
        lblPageFaults.BackColor = Color.Transparent
        lblPageFaults.Font = New Font("Tw Cen MT", 18F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblPageFaults.ForeColor = Color.SaddleBrown
        lblPageFaults.Location = New Point(1509, 169)
        lblPageFaults.Name = "lblPageFaults"
        lblPageFaults.Size = New Size(38, 42)
        lblPageFaults.TabIndex = 18
        lblPageFaults.Text = "0"
        ' 
        ' lblPageFault
        ' 
        lblPageFault.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        lblPageFault.AutoSize = True
        lblPageFault.BackColor = Color.Transparent
        lblPageFault.Font = New Font("Tw Cen MT", 18F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblPageFault.ForeColor = Color.SaddleBrown
        lblPageFault.Location = New Point(1314, 169)
        lblPageFault.Name = "lblPageFault"
        lblPageFault.Size = New Size(200, 42)
        lblPageFault.TabIndex = 17
        lblPageFault.Text = "Page Faults: "
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.None
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Tw Cen MT", 18F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.SaddleBrown
        Label9.Location = New Point(1111, -71)
        Label9.Name = "Label9"
        Label9.Size = New Size(0, 42)
        Label9.TabIndex = 16
        ' 
        ' lblNoOfStringOutput
        ' 
        lblNoOfStringOutput.AutoSize = True
        lblNoOfStringOutput.BackColor = Color.Transparent
        lblNoOfStringOutput.Font = New Font("Tw Cen MT", 18F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblNoOfStringOutput.ForeColor = Color.SaddleBrown
        lblNoOfStringOutput.Location = New Point(440, 219)
        lblNoOfStringOutput.Name = "lblNoOfStringOutput"
        lblNoOfStringOutput.Size = New Size(42, 42)
        lblNoOfStringOutput.TabIndex = 15
        lblNoOfStringOutput.Text = "..."
        ' 
        ' lblRefStringOutput
        ' 
        lblRefStringOutput.AutoSize = True
        lblRefStringOutput.BackColor = Color.Transparent
        lblRefStringOutput.Font = New Font("Tw Cen MT", 18F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblRefStringOutput.ForeColor = Color.SaddleBrown
        lblRefStringOutput.Location = New Point(440, 155)
        lblRefStringOutput.Name = "lblRefStringOutput"
        lblRefStringOutput.Size = New Size(42, 42)
        lblRefStringOutput.TabIndex = 14
        lblRefStringOutput.Text = "..."
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Tw Cen MT", 18F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.SaddleBrown
        Label7.Location = New Point(116, 219)
        Label7.Name = "Label7"
        Label7.Size = New Size(286, 42)
        Label7.TabIndex = 9
        Label7.Text = "Number of Frames:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Tw Cen MT", 18F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.SaddleBrown
        Label8.Location = New Point(116, 155)
        Label8.Name = "Label8"
        Label8.Size = New Size(268, 42)
        Label8.TabIndex = 8
        Label8.Text = "Reference String: "
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel2.BackColor = Color.Sienna
        Panel2.Controls.Add(btnAbout)
        Panel2.Controls.Add(btnHome)
        Panel2.Location = New Point(-23, -14)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1760, 99)
        Panel2.TabIndex = 5
        ' 
        ' btnAbout
        ' 
        btnAbout.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnAbout.BackgroundImage = CType(resources.GetObject("btnAbout.BackgroundImage"), Image)
        btnAbout.BackgroundImageLayout = ImageLayout.Zoom
        btnAbout.FlatStyle = FlatStyle.Flat
        btnAbout.ForeColor = Color.SaddleBrown
        btnAbout.Location = New Point(1573, 32)
        btnAbout.Name = "btnAbout"
        btnAbout.Size = New Size(109, 51)
        btnAbout.TabIndex = 2
        btnAbout.UseVisualStyleBackColor = True
        ' 
        ' btnHome
        ' 
        btnHome.BackgroundImage = CType(resources.GetObject("btnHome.BackgroundImage"), Image)
        btnHome.BackgroundImageLayout = ImageLayout.Zoom
        btnHome.FlatStyle = FlatStyle.Flat
        btnHome.ForeColor = Color.SaddleBrown
        btnHome.Location = New Point(54, 32)
        btnHome.Name = "btnHome"
        btnHome.Size = New Size(104, 45)
        btnHome.TabIndex = 0
        btnHome.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Tw Cen MT", 18F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.SaddleBrown
        Label3.Location = New Point(128, 261)
        Label3.Name = "Label3"
        Label3.Size = New Size(268, 42)
        Label3.TabIndex = 6
        Label3.Text = "Reference String: "
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Tw Cen MT", 18F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.SaddleBrown
        Label4.Location = New Point(128, 340)
        Label4.Name = "Label4"
        Label4.Size = New Size(286, 42)
        Label4.TabIndex = 7
        Label4.Text = "Number of Frames:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(41, 207)
        Label5.Name = "Label5"
        Label5.Size = New Size(0, 25)
        Label5.TabIndex = 8
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Tw Cen MT", 18F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.SaddleBrown
        Label6.Location = New Point(441, 340)
        Label6.Name = "Label6"
        Label6.Size = New Size(0, 42)
        Label6.TabIndex = 10
        ' 
        ' lblRefStringInput
        ' 
        lblRefStringInput.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblRefStringInput.AutoSize = True
        lblRefStringInput.BackColor = Color.Transparent
        lblRefStringInput.Font = New Font("Tw Cen MT", 18F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblRefStringInput.ForeColor = Color.SaddleBrown
        lblRefStringInput.Location = New Point(441, 261)
        lblRefStringInput.Name = "lblRefStringInput"
        lblRefStringInput.Size = New Size(0, 42)
        lblRefStringInput.TabIndex = 9
        ' 
        ' cmbNoOfString
        ' 
        cmbNoOfString.FormattingEnabled = True
        cmbNoOfString.Location = New Point(441, 350)
        cmbNoOfString.Name = "cmbNoOfString"
        cmbNoOfString.Size = New Size(200, 33)
        cmbNoOfString.TabIndex = 12
        ' 
        ' btnGenerate
        ' 
        btnGenerate.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnGenerate.BackColor = Color.BlanchedAlmond
        btnGenerate.FlatStyle = FlatStyle.Popup
        btnGenerate.Font = New Font("Tw Cen MT", 16F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnGenerate.ForeColor = Color.SaddleBrown
        btnGenerate.Location = New Point(1357, 261)
        btnGenerate.Name = "btnGenerate"
        btnGenerate.Size = New Size(226, 52)
        btnGenerate.TabIndex = 13
        btnGenerate.Text = "Generate"
        btnGenerate.UseVisualStyleBackColor = False
        ' 
        ' btnSimulate
        ' 
        btnSimulate.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnSimulate.BackColor = Color.BlanchedAlmond
        btnSimulate.FlatStyle = FlatStyle.Popup
        btnSimulate.Font = New Font("Tw Cen MT", 16F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnSimulate.ForeColor = Color.SaddleBrown
        btnSimulate.Location = New Point(1357, 335)
        btnSimulate.Name = "btnSimulate"
        btnSimulate.Size = New Size(226, 52)
        btnSimulate.TabIndex = 14
        btnSimulate.Text = "Simulate"
        btnSimulate.UseVisualStyleBackColor = False
        ' 
        ' Simulator
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1711, 1183)
        Controls.Add(btnSimulate)
        Controls.Add(btnGenerate)
        Controls.Add(cmbNoOfString)
        Controls.Add(Label6)
        Controls.Add(lblRefStringInput)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Panel2)
        Controls.Add(pnlOutput)
        Controls.Add(lblVMS)
        Controls.Add(Label1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.Fixed3D
        Name = "Simulator"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Simulator"
        pnlOutput.ResumeLayout(False)
        pnlOutput.PerformLayout()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblVMS As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pnlOutput As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblRefStringInput As Label
    Friend WithEvents cmbNoOfString As ComboBox
    Friend WithEvents btnGenerate As Button
    Friend WithEvents lblRefStringOutput As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblNoOfStringOutput As Label
    Friend WithEvents btnSimulate As Button
    Friend WithEvents btnAbout As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents lblPageFault As Label
    Friend WithEvents lblPageFaults As Label
    Friend WithEvents pnlFifo As Panel
End Class
