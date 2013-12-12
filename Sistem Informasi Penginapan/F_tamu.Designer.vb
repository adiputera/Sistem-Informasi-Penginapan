<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_tamu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_tamu))
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.btnresepsionis = New System.Windows.Forms.Button()
        Me.btntamu = New System.Windows.Forms.Button()
        Me.btnkamar = New System.Windows.Forms.Button()
        Me.btnhome = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgview = New System.Windows.Forms.DataGridView()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btndel = New System.Windows.Forms.Button()
        CType(Me.dgview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnlogout
        '
        Me.btnlogout.BackColor = System.Drawing.Color.Transparent
        Me.btnlogout.BackgroundImage = CType(resources.GetObject("btnlogout.BackgroundImage"), System.Drawing.Image)
        Me.btnlogout.Location = New System.Drawing.Point(852, 42)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(119, 45)
        Me.btnlogout.TabIndex = 5
        Me.btnlogout.UseVisualStyleBackColor = False
        '
        'btnresepsionis
        '
        Me.btnresepsionis.BackColor = System.Drawing.Color.Transparent
        Me.btnresepsionis.BackgroundImage = CType(resources.GetObject("btnresepsionis.BackgroundImage"), System.Drawing.Image)
        Me.btnresepsionis.Location = New System.Drawing.Point(582, 42)
        Me.btnresepsionis.Name = "btnresepsionis"
        Me.btnresepsionis.Size = New System.Drawing.Size(155, 45)
        Me.btnresepsionis.TabIndex = 4
        Me.btnresepsionis.UseVisualStyleBackColor = False
        '
        'btntamu
        '
        Me.btntamu.BackColor = System.Drawing.Color.Transparent
        Me.btntamu.BackgroundImage = CType(resources.GetObject("btntamu.BackgroundImage"), System.Drawing.Image)
        Me.btntamu.Location = New System.Drawing.Point(402, 42)
        Me.btntamu.Name = "btntamu"
        Me.btntamu.Size = New System.Drawing.Size(119, 45)
        Me.btntamu.TabIndex = 3
        Me.btntamu.UseVisualStyleBackColor = False
        '
        'btnkamar
        '
        Me.btnkamar.BackColor = System.Drawing.Color.Transparent
        Me.btnkamar.BackgroundImage = CType(resources.GetObject("btnkamar.BackgroundImage"), System.Drawing.Image)
        Me.btnkamar.Location = New System.Drawing.Point(212, 42)
        Me.btnkamar.Name = "btnkamar"
        Me.btnkamar.Size = New System.Drawing.Size(125, 45)
        Me.btnkamar.TabIndex = 2
        Me.btnkamar.UseVisualStyleBackColor = False
        '
        'btnhome
        '
        Me.btnhome.BackColor = System.Drawing.Color.Transparent
        Me.btnhome.BackgroundImage = CType(resources.GetObject("btnhome.BackgroundImage"), System.Drawing.Image)
        Me.btnhome.Location = New System.Drawing.Point(34, 42)
        Me.btnhome.Name = "btnhome"
        Me.btnhome.Size = New System.Drawing.Size(119, 45)
        Me.btnhome.TabIndex = 1
        Me.btnhome.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(149, 184)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 38)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Home"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dgview
        '
        Me.dgview.BackgroundColor = System.Drawing.Color.White
        Me.dgview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgview.Location = New System.Drawing.Point(31, 149)
        Me.dgview.Name = "dgview"
        Me.dgview.Size = New System.Drawing.Size(940, 469)
        Me.dgview.TabIndex = 7
        '
        'btnadd
        '
        Me.btnadd.BackgroundImage = CType(resources.GetObject("btnadd.BackgroundImage"), System.Drawing.Image)
        Me.btnadd.Location = New System.Drawing.Point(34, 635)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(104, 45)
        Me.btnadd.TabIndex = 23
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.BackgroundImage = CType(resources.GetObject("btnedit.BackgroundImage"), System.Drawing.Image)
        Me.btnedit.Location = New System.Drawing.Point(212, 635)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(104, 45)
        Me.btnedit.TabIndex = 24
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btndel
        '
        Me.btndel.BackgroundImage = CType(resources.GetObject("btndel.BackgroundImage"), System.Drawing.Image)
        Me.btndel.Location = New System.Drawing.Point(381, 635)
        Me.btndel.Name = "btndel"
        Me.btndel.Size = New System.Drawing.Size(104, 45)
        Me.btndel.TabIndex = 25
        Me.btndel.UseVisualStyleBackColor = True
        '
        'F_tamu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1018, 692)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btndel)
        Me.Controls.Add(Me.dgview)
        Me.Controls.Add(Me.btnlogout)
        Me.Controls.Add(Me.btnresepsionis)
        Me.Controls.Add(Me.btnhome)
        Me.Controls.Add(Me.btntamu)
        Me.Controls.Add(Me.btnkamar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "F_tamu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "tamu"
        CType(Me.dgview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnlogout As System.Windows.Forms.Button
    Friend WithEvents btnresepsionis As System.Windows.Forms.Button
    Friend WithEvents btntamu As System.Windows.Forms.Button
    Friend WithEvents btnkamar As System.Windows.Forms.Button
    Friend WithEvents btnhome As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dgview As System.Windows.Forms.DataGridView
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btndel As System.Windows.Forms.Button
End Class
