<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HệThốngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ĐăngXuấtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnTrịToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLýSPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NhânViênToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HổTrợToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HệThốngToolStripMenuItem, Me.QuảnTrịToolStripMenuItem, Me.NhânViênToolStripMenuItem, Me.HổTrợToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(508, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HệThốngToolStripMenuItem
        '
        Me.HệThốngToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ĐăngXuấtToolStripMenuItem, Me.DToolStripMenuItem})
        Me.HệThốngToolStripMenuItem.Name = "HệThốngToolStripMenuItem"
        Me.HệThốngToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.HệThốngToolStripMenuItem.Text = "Hệ thống"
        '
        'ĐăngXuấtToolStripMenuItem
        '
        Me.ĐăngXuấtToolStripMenuItem.Name = "ĐăngXuấtToolStripMenuItem"
        Me.ĐăngXuấtToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.ĐăngXuấtToolStripMenuItem.Text = "Đăng Xuất"
        '
        'DToolStripMenuItem
        '
        Me.DToolStripMenuItem.Name = "DToolStripMenuItem"
        Me.DToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.DToolStripMenuItem.Text = "D"
        '
        'QuảnTrịToolStripMenuItem
        '
        Me.QuảnTrịToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuảnLýSPToolStripMenuItem})
        Me.QuảnTrịToolStripMenuItem.Name = "QuảnTrịToolStripMenuItem"
        Me.QuảnTrịToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.QuảnTrịToolStripMenuItem.Text = "Quản trị"
        '
        'QuảnLýSPToolStripMenuItem
        '
        Me.QuảnLýSPToolStripMenuItem.Name = "QuảnLýSPToolStripMenuItem"
        Me.QuảnLýSPToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.QuảnLýSPToolStripMenuItem.Text = "Quản lý SP"
        '
        'NhânViênToolStripMenuItem
        '
        Me.NhânViênToolStripMenuItem.Name = "NhânViênToolStripMenuItem"
        Me.NhânViênToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.NhânViênToolStripMenuItem.Text = "Nhân Viên"
        '
        'HổTrợToolStripMenuItem
        '
        Me.HổTrợToolStripMenuItem.Name = "HổTrợToolStripMenuItem"
        Me.HổTrợToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.HổTrợToolStripMenuItem.Text = "Hổ trợ"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.images
        Me.PictureBox1.Location = New System.Drawing.Point(12, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(484, 253)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(508, 262)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main"
        Me.Text = "Main"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents HệThốngToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ĐăngXuấtToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuảnTrịToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuảnLýSPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NhânViênToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HổTrợToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
