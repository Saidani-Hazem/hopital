<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ajout_rdv
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ajout_rdv))
        Me.btn_ajout = New System.Windows.Forms.Button()
        Me.lbl_code = New System.Windows.Forms.Label()
        Me.txt_code = New System.Windows.Forms.TextBox()
        Me.btn_retour = New System.Windows.Forms.Button()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.dt_date = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_rdv = New System.Windows.Forms.Label()
        Me.dt_heure = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_ajout
        '
        Me.btn_ajout.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ajout.Location = New System.Drawing.Point(1225, 792)
        Me.btn_ajout.Name = "btn_ajout"
        Me.btn_ajout.Size = New System.Drawing.Size(107, 41)
        Me.btn_ajout.TabIndex = 16
        Me.btn_ajout.Text = "AJOUT"
        Me.btn_ajout.UseVisualStyleBackColor = True
        '
        'lbl_code
        '
        Me.lbl_code.AutoSize = True
        Me.lbl_code.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl_code.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_code.ForeColor = System.Drawing.Color.Black
        Me.lbl_code.Location = New System.Drawing.Point(828, 449)
        Me.lbl_code.Name = "lbl_code"
        Me.lbl_code.Size = New System.Drawing.Size(79, 26)
        Me.lbl_code.TabIndex = 13
        Me.lbl_code.Text = "Code :"
        '
        'txt_code
        '
        Me.txt_code.Font = New System.Drawing.Font("Microsoft Tai Le", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_code.Location = New System.Drawing.Point(970, 445)
        Me.txt_code.Name = "txt_code"
        Me.txt_code.Size = New System.Drawing.Size(322, 30)
        Me.txt_code.TabIndex = 10
        '
        'btn_retour
        '
        Me.btn_retour.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_retour.Location = New System.Drawing.Point(1060, 792)
        Me.btn_retour.Name = "btn_retour"
        Me.btn_retour.Size = New System.Drawing.Size(107, 41)
        Me.btn_retour.TabIndex = 9
        Me.btn_retour.Text = "RETOUR"
        Me.btn_retour.UseVisualStyleBackColor = True
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl_date.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.ForeColor = System.Drawing.Color.Black
        Me.lbl_date.Location = New System.Drawing.Point(828, 550)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(74, 26)
        Me.lbl_date.TabIndex = 17
        Me.lbl_date.Text = "Date :"
        '
        'dt_date
        '
        Me.dt_date.CalendarFont = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_date.Font = New System.Drawing.Font("Microsoft Tai Le", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_date.Location = New System.Drawing.Point(970, 550)
        Me.dt_date.MinDate = New Date(2023, 11, 23, 0, 0, 0, 0)
        Me.dt_date.Name = "dt_date"
        Me.dt_date.Size = New System.Drawing.Size(322, 30)
        Me.dt_date.TabIndex = 18
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1005, 184)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(86, 89)
        Me.PictureBox2.TabIndex = 21
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(710, 141)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(673, 733)
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'lbl_rdv
        '
        Me.lbl_rdv.AutoSize = True
        Me.lbl_rdv.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rdv.Location = New System.Drawing.Point(878, 308)
        Me.lbl_rdv.Name = "lbl_rdv"
        Me.lbl_rdv.Size = New System.Drawing.Size(340, 31)
        Me.lbl_rdv.TabIndex = 23
        Me.lbl_rdv.Text = "AJOUT RENDEZ-VOUS"
        '
        'dt_heure
        '
        Me.dt_heure.CalendarFont = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_heure.Font = New System.Drawing.Font("Microsoft Tai Le", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_heure.Location = New System.Drawing.Point(970, 648)
        Me.dt_heure.MinDate = New Date(2023, 11, 23, 0, 0, 0, 0)
        Me.dt_heure.Name = "dt_heure"
        Me.dt_heure.Size = New System.Drawing.Size(322, 30)
        Me.dt_heure.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(828, 648)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 26)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "HEURE :"
        '
        'ajout_rdv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1646, 1032)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dt_heure)
        Me.Controls.Add(Me.lbl_rdv)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.dt_date)
        Me.Controls.Add(Me.lbl_date)
        Me.Controls.Add(Me.btn_ajout)
        Me.Controls.Add(Me.lbl_code)
        Me.Controls.Add(Me.txt_code)
        Me.Controls.Add(Me.btn_retour)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "ajout_rdv"
        Me.Text = "ajout_rdv"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_ajout As Button
    Friend WithEvents lbl_code As Label
    Friend WithEvents txt_code As TextBox
    Friend WithEvents btn_retour As Button
    Friend WithEvents lbl_date As Label
    Friend WithEvents dt_date As DateTimePicker
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbl_rdv As Label
    Friend WithEvents dt_heure As DateTimePicker
    Friend WithEvents Label1 As Label
End Class
