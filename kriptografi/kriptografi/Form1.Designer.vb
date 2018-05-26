<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtasal = New System.Windows.Forms.TextBox()
        Me.txthasil = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbdeskripsi = New System.Windows.Forms.RadioButton()
        Me.rdbenkripsi = New System.Windows.Forms.RadioButton()
        Me.btnproses = New System.Windows.Forms.Button()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.btnkeluar = New System.Windows.Forms.Button()
        Me.btncari = New System.Windows.Forms.Button()
        Me.number = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbhasil = New System.Windows.Forms.Label()
        Me.lbawal = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.number, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtasal
        '
        Me.txtasal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtasal.Location = New System.Drawing.Point(12, 114)
        Me.txtasal.Multiline = True
        Me.txtasal.Name = "txtasal"
        Me.txtasal.Size = New System.Drawing.Size(430, 130)
        Me.txtasal.TabIndex = 0
        '
        'txthasil
        '
        Me.txthasil.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthasil.Location = New System.Drawing.Point(11, 328)
        Me.txthasil.Multiline = True
        Me.txthasil.Name = "txthasil"
        Me.txthasil.Size = New System.Drawing.Size(430, 130)
        Me.txthasil.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbdeskripsi)
        Me.GroupBox1.Controls.Add(Me.rdbenkripsi)
        Me.GroupBox1.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 250)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(430, 49)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Kategori"
        '
        'rdbdeskripsi
        '
        Me.rdbdeskripsi.AutoSize = True
        Me.rdbdeskripsi.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbdeskripsi.Location = New System.Drawing.Point(261, 18)
        Me.rdbdeskripsi.Name = "rdbdeskripsi"
        Me.rdbdeskripsi.Size = New System.Drawing.Size(84, 21)
        Me.rdbdeskripsi.TabIndex = 1
        Me.rdbdeskripsi.TabStop = True
        Me.rdbdeskripsi.Text = "Deskripsi"
        Me.rdbdeskripsi.UseVisualStyleBackColor = True
        '
        'rdbenkripsi
        '
        Me.rdbenkripsi.AutoSize = True
        Me.rdbenkripsi.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbenkripsi.Location = New System.Drawing.Point(93, 18)
        Me.rdbenkripsi.Name = "rdbenkripsi"
        Me.rdbenkripsi.Size = New System.Drawing.Size(80, 21)
        Me.rdbenkripsi.TabIndex = 0
        Me.rdbenkripsi.TabStop = True
        Me.rdbenkripsi.Text = "Enkripsi"
        Me.rdbenkripsi.UseVisualStyleBackColor = True
        '
        'btnproses
        '
        Me.btnproses.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnproses.Image = CType(resources.GetObject("btnproses.Image"), System.Drawing.Image)
        Me.btnproses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnproses.Location = New System.Drawing.Point(82, 499)
        Me.btnproses.Name = "btnproses"
        Me.btnproses.Size = New System.Drawing.Size(103, 40)
        Me.btnproses.TabIndex = 3
        Me.btnproses.Text = "    Proses"
        Me.btnproses.UseVisualStyleBackColor = True
        '
        'btnreset
        '
        Me.btnreset.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreset.Image = CType(resources.GetObject("btnreset.Image"), System.Drawing.Image)
        Me.btnreset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnreset.Location = New System.Drawing.Point(82, 545)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(103, 39)
        Me.btnreset.TabIndex = 4
        Me.btnreset.Text = "  Reset"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'btnkeluar
        '
        Me.btnkeluar.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnkeluar.Image = CType(resources.GetObject("btnkeluar.Image"), System.Drawing.Image)
        Me.btnkeluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnkeluar.Location = New System.Drawing.Point(261, 545)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(96, 39)
        Me.btnkeluar.TabIndex = 5
        Me.btnkeluar.Text = "     Keluar"
        Me.btnkeluar.UseVisualStyleBackColor = True
        '
        'btncari
        '
        Me.btncari.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncari.Image = CType(resources.GetObject("btncari.Image"), System.Drawing.Image)
        Me.btncari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncari.Location = New System.Drawing.Point(261, 499)
        Me.btncari.Name = "btncari"
        Me.btncari.Size = New System.Drawing.Size(96, 40)
        Me.btncari.TabIndex = 6
        Me.btncari.Text = "     Open File"
        Me.btncari.UseVisualStyleBackColor = True
        '
        'number
        '
        Me.number.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.number.Location = New System.Drawing.Point(196, 467)
        Me.number.Name = "number"
        Me.number.Size = New System.Drawing.Size(55, 22)
        Me.number.TabIndex = 2
        Me.number.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(153, 468)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Key"
        '
        'lbhasil
        '
        Me.lbhasil.AutoSize = True
        Me.lbhasil.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbhasil.Location = New System.Drawing.Point(12, 310)
        Me.lbhasil.Name = "lbhasil"
        Me.lbhasil.Size = New System.Drawing.Size(45, 17)
        Me.lbhasil.TabIndex = 9
        Me.lbhasil.Text = "label2"
        '
        'lbawal
        '
        Me.lbawal.AutoSize = True
        Me.lbawal.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbawal.Location = New System.Drawing.Point(12, 96)
        Me.lbawal.Name = "lbawal"
        Me.lbawal.Size = New System.Drawing.Size(45, 17)
        Me.lbawal.TabIndex = 10
        Me.lbawal.Text = "label1"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(130, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(180, 29)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Caesar Cipher"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(50, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(353, 36)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Kriptografi Algoritma"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 608)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbawal)
        Me.Controls.Add(Me.lbhasil)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.number)
        Me.Controls.Add(Me.btncari)
        Me.Controls.Add(Me.btnkeluar)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.btnproses)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txthasil)
        Me.Controls.Add(Me.txtasal)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        CType(Me.number,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents txtasal As System.Windows.Forms.TextBox
    Friend WithEvents txthasil As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbdeskripsi As System.Windows.Forms.RadioButton
    Friend WithEvents rdbenkripsi As System.Windows.Forms.RadioButton
    Friend WithEvents btnproses As System.Windows.Forms.Button
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents btnkeluar As System.Windows.Forms.Button
    Friend WithEvents btncari As System.Windows.Forms.Button
    Friend WithEvents number As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbhasil As System.Windows.Forms.Label
    Friend WithEvents lbawal As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
