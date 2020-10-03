<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_Utama
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.DATAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ORDERPESANANToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TRANSAKSIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LAPORANToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PENGATURANPAKETToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.KELUARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LAPORANTRANSAKSIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.KELUARToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.Label3 = New System.Windows.Forms.Label
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DATAToolStripMenuItem, Me.LAPORANToolStripMenuItem, Me.KELUARToolStripMenuItem, Me.KELUARToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1352, 26)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DATAToolStripMenuItem
        '
        Me.DATAToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ORDERPESANANToolStripMenuItem, Me.TRANSAKSIToolStripMenuItem})
        Me.DATAToolStripMenuItem.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DATAToolStripMenuItem.Name = "DATAToolStripMenuItem"
        Me.DATAToolStripMenuItem.Size = New System.Drawing.Size(52, 22)
        Me.DATAToolStripMenuItem.Text = "DATA"
        '
        'ORDERPESANANToolStripMenuItem
        '
        Me.ORDERPESANANToolStripMenuItem.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ORDERPESANANToolStripMenuItem.Name = "ORDERPESANANToolStripMenuItem"
        Me.ORDERPESANANToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.ORDERPESANANToolStripMenuItem.Text = "ORDER PESANAN"
        '
        'TRANSAKSIToolStripMenuItem
        '
        Me.TRANSAKSIToolStripMenuItem.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TRANSAKSIToolStripMenuItem.Name = "TRANSAKSIToolStripMenuItem"
        Me.TRANSAKSIToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.TRANSAKSIToolStripMenuItem.Text = "TRANSAKSI"
        '
        'LAPORANToolStripMenuItem
        '
        Me.LAPORANToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PENGATURANPAKETToolStripMenuItem})
        Me.LAPORANToolStripMenuItem.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAPORANToolStripMenuItem.Name = "LAPORANToolStripMenuItem"
        Me.LAPORANToolStripMenuItem.Size = New System.Drawing.Size(56, 22)
        Me.LAPORANToolStripMenuItem.Text = "PAKET"
        '
        'PENGATURANPAKETToolStripMenuItem
        '
        Me.PENGATURANPAKETToolStripMenuItem.Name = "PENGATURANPAKETToolStripMenuItem"
        Me.PENGATURANPAKETToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.PENGATURANPAKETToolStripMenuItem.Text = "PENGATURAN PAKET"
        '
        'KELUARToolStripMenuItem
        '
        Me.KELUARToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LAPORANTRANSAKSIToolStripMenuItem})
        Me.KELUARToolStripMenuItem.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KELUARToolStripMenuItem.Name = "KELUARToolStripMenuItem"
        Me.KELUARToolStripMenuItem.Size = New System.Drawing.Size(75, 22)
        Me.KELUARToolStripMenuItem.Text = "LAPORAN"
        '
        'LAPORANTRANSAKSIToolStripMenuItem
        '
        Me.LAPORANTRANSAKSIToolStripMenuItem.Name = "LAPORANTRANSAKSIToolStripMenuItem"
        Me.LAPORANTRANSAKSIToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.LAPORANTRANSAKSIToolStripMenuItem.Text = "LAPORAN TRANSAKSI"
        '
        'KELUARToolStripMenuItem1
        '
        Me.KELUARToolStripMenuItem1.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KELUARToolStripMenuItem1.Name = "KELUARToolStripMenuItem1"
        Me.KELUARToolStripMenuItem1.Size = New System.Drawing.Size(64, 22)
        Me.KELUARToolStripMenuItem1.Text = "KELUAR"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Font = New System.Drawing.Font("Showcard Gothic", 24.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(404, 331)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(649, 80)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = """ BUDAYAKAN MALAS MENCUCI """ & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & """ KARENA MENCUCI ADALAH TUGAS KAMI """
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Menu_Utama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.AplikasiLaundry.My.Resources.Resources._6
        Me.ClientSize = New System.Drawing.Size(1352, 729)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Menu_Utama"
        Me.Text = "Menu_Utama"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DATAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ORDERPESANANToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TRANSAKSIToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LAPORANToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KELUARToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PENGATURANPAKETToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KELUARToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LAPORANTRANSAKSIToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
