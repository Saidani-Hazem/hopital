<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_main
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_main))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PatientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjoutPatientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AffichePatientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RdvToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjoutRdvToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RdvDeJourToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txt_rech = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.lbl_recherche = New System.Windows.Forms.Label()
        Me.btn_rech = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dt_datemain = New System.Windows.Forms.DateTimePicker()
        Me.dgv_resultat = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_resultat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.MenuStrip1.Font = New System.Drawing.Font("Simplified Arabic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PatientToolStripMenuItem, Me.RdvToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1924, 40)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PatientToolStripMenuItem
        '
        Me.PatientToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjoutPatientToolStripMenuItem, Me.AffichePatientToolStripMenuItem})
        Me.PatientToolStripMenuItem.Name = "PatientToolStripMenuItem"
        Me.PatientToolStripMenuItem.Size = New System.Drawing.Size(87, 36)
        Me.PatientToolStripMenuItem.Text = "Patient"
        '
        'AjoutPatientToolStripMenuItem
        '
        Me.AjoutPatientToolStripMenuItem.Name = "AjoutPatientToolStripMenuItem"
        Me.AjoutPatientToolStripMenuItem.Size = New System.Drawing.Size(226, 36)
        Me.AjoutPatientToolStripMenuItem.Text = "Ajout patient"
        '
        'AffichePatientToolStripMenuItem
        '
        Me.AffichePatientToolStripMenuItem.Name = "AffichePatientToolStripMenuItem"
        Me.AffichePatientToolStripMenuItem.Size = New System.Drawing.Size(226, 36)
        Me.AffichePatientToolStripMenuItem.Text = "Affiche patient"
        '
        'RdvToolStripMenuItem
        '
        Me.RdvToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjoutRdvToolStripMenuItem, Me.RdvDeJourToolStripMenuItem})
        Me.RdvToolStripMenuItem.Name = "RdvToolStripMenuItem"
        Me.RdvToolStripMenuItem.Size = New System.Drawing.Size(142, 36)
        Me.RdvToolStripMenuItem.Text = "Rendez-Vous"
        '
        'AjoutRdvToolStripMenuItem
        '
        Me.AjoutRdvToolStripMenuItem.Name = "AjoutRdvToolStripMenuItem"
        Me.AjoutRdvToolStripMenuItem.Size = New System.Drawing.Size(200, 36)
        Me.AjoutRdvToolStripMenuItem.Text = "Ajout Rdv"
        '
        'RdvDeJourToolStripMenuItem
        '
        Me.RdvDeJourToolStripMenuItem.Name = "RdvDeJourToolStripMenuItem"
        Me.RdvDeJourToolStripMenuItem.Size = New System.Drawing.Size(200, 36)
        Me.RdvDeJourToolStripMenuItem.Text = "Rdv de jour"
        '
        'txt_rech
        '
        Me.txt_rech.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_rech.Location = New System.Drawing.Point(846, 436)
        Me.txt_rech.Name = "txt_rech"
        Me.txt_rech.Size = New System.Drawing.Size(360, 34)
        Me.txt_rech.TabIndex = 1
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'lbl_recherche
        '
        Me.lbl_recherche.AutoSize = True
        Me.lbl_recherche.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_recherche.Location = New System.Drawing.Point(742, 440)
        Me.lbl_recherche.Name = "lbl_recherche"
        Me.lbl_recherche.Size = New System.Drawing.Size(75, 25)
        Me.lbl_recherche.TabIndex = 3
        Me.lbl_recherche.Text = "Nom :"
        '
        'btn_rech
        '
        Me.btn_rech.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_rech.Image = CType(resources.GetObject("btn_rech.Image"), System.Drawing.Image)
        Me.btn_rech.Location = New System.Drawing.Point(1256, 427)
        Me.btn_rech.Name = "btn_rech"
        Me.btn_rech.Size = New System.Drawing.Size(111, 52)
        Me.btn_rech.TabIndex = 5
        Me.btn_rech.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(944, 150)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(183, 204)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'dt_datemain
        '
        Me.dt_datemain.CalendarFont = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_datemain.Font = New System.Drawing.Font("Microsoft Tai Le", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_datemain.Location = New System.Drawing.Point(1673, 130)
        Me.dt_datemain.MinDate = New Date(2023, 11, 23, 0, 0, 0, 0)
        Me.dt_datemain.Name = "dt_datemain"
        Me.dt_datemain.Size = New System.Drawing.Size(322, 30)
        Me.dt_datemain.TabIndex = 19
        '
        'dgv_resultat
        '
        Me.dgv_resultat.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_resultat.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_resultat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_resultat.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_resultat.Location = New System.Drawing.Point(577, 537)
        Me.dgv_resultat.Name = "dgv_resultat"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_resultat.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_resultat.RowHeadersWidth = 51
        Me.dgv_resultat.RowTemplate.Height = 24
        Me.dgv_resultat.Size = New System.Drawing.Size(955, 378)
        Me.dgv_resultat.TabIndex = 20
        '
        'frm_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1924, 1005)
        Me.Controls.Add(Me.dgv_resultat)
        Me.Controls.Add(Me.dt_datemain)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_rech)
        Me.Controls.Add(Me.lbl_recherche)
        Me.Controls.Add(Me.txt_rech)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frm_main"
        Me.Text = "frm_main"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_resultat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PatientToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RdvToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjoutPatientToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AffichePatientToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjoutRdvToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RdvDeJourToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txt_rech As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents lbl_recherche As Label
    Friend WithEvents btn_rech As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents dt_datemain As DateTimePicker
    Friend WithEvents dgv_resultat As DataGridView
End Class
