<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home_Page
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home_Page))
        btnClickToStart = New Button()
        lblVMS = New Label()
        Timer1 = New Timer(components)
        SuspendLayout()
        ' 
        ' btnClickToStart
        ' 
        btnClickToStart.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnClickToStart.BackColor = Color.BlanchedAlmond
        btnClickToStart.FlatStyle = FlatStyle.Popup
        btnClickToStart.Font = New Font("Vladimir Script", 20F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnClickToStart.ForeColor = Color.SaddleBrown
        btnClickToStart.Location = New Point(535, 657)
        btnClickToStart.Name = "btnClickToStart"
        btnClickToStart.Size = New Size(296, 73)
        btnClickToStart.TabIndex = 0
        btnClickToStart.Text = "Click to Start"
        btnClickToStart.UseVisualStyleBackColor = False
        ' 
        ' lblVMS
        ' 
        lblVMS.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblVMS.AutoSize = True
        lblVMS.BackColor = Color.Transparent
        lblVMS.Font = New Font("Vivaldi", 36F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblVMS.ForeColor = Color.SaddleBrown
        lblVMS.Location = New Point(177, 462)
        lblVMS.Name = "lblVMS"
        lblVMS.Size = New Size(55, 86)
        lblVMS.TabIndex = 1
        lblVMS.Text = " "
        ' 
        ' Timer1
        ' 
        ' 
        ' Home_Page
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1374, 964)
        Controls.Add(lblVMS)
        Controls.Add(btnClickToStart)
        DoubleBuffered = True
        Name = "Home_Page"
        Text = "Home_Page"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnClickToStart As Button
    Friend WithEvents lblVMS As Label
    Friend WithEvents Timer1 As Timer
End Class
