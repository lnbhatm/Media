<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmmain))
        Me.btnexit = New System.Windows.Forms.Button()
        Me.lblsrc = New System.Windows.Forms.Label()
        Me.lbldst = New System.Windows.Forms.Label()
        Me.txtdst = New System.Windows.Forms.TextBox()
        Me.btnorg = New System.Windows.Forms.Button()
        Me.pgbar = New System.Windows.Forms.ProgressBar()
        Me.lblprgs = New System.Windows.Forms.Label()
        Me.txtsrc = New System.Windows.Forms.TextBox()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnexit
        '
        Me.btnexit.BackColor = System.Drawing.Color.Transparent
        Me.btnexit.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.ForeColor = System.Drawing.Color.Green
        Me.btnexit.Location = New System.Drawing.Point(492, 432)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(80, 40)
        Me.btnexit.TabIndex = 0
        Me.btnexit.Text = "E&xit"
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'lblsrc
        '
        Me.lblsrc.AutoSize = True
        Me.lblsrc.BackColor = System.Drawing.Color.Transparent
        Me.lblsrc.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsrc.ForeColor = System.Drawing.Color.Black
        Me.lblsrc.Location = New System.Drawing.Point(17, 22)
        Me.lblsrc.Name = "lblsrc"
        Me.lblsrc.Size = New System.Drawing.Size(81, 15)
        Me.lblsrc.TabIndex = 1
        Me.lblsrc.Text = "Media Source"
        '
        'lbldst
        '
        Me.lbldst.AutoSize = True
        Me.lbldst.BackColor = System.Drawing.Color.Transparent
        Me.lbldst.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldst.ForeColor = System.Drawing.Color.Black
        Me.lbldst.Location = New System.Drawing.Point(19, 61)
        Me.lbldst.Name = "lbldst"
        Me.lbldst.Size = New System.Drawing.Size(71, 15)
        Me.lbldst.TabIndex = 2
        Me.lbldst.Text = "Destination"
        '
        'txtdst
        '
        Me.txtdst.BackColor = System.Drawing.Color.White
        Me.txtdst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdst.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdst.ForeColor = System.Drawing.Color.Black
        Me.txtdst.Location = New System.Drawing.Point(103, 56)
        Me.txtdst.Name = "txtdst"
        Me.txtdst.Size = New System.Drawing.Size(454, 22)
        Me.txtdst.TabIndex = 4
        '
        'btnorg
        '
        Me.btnorg.BackColor = System.Drawing.Color.Transparent
        Me.btnorg.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnorg.ForeColor = System.Drawing.Color.Green
        Me.btnorg.Location = New System.Drawing.Point(411, 432)
        Me.btnorg.Name = "btnorg"
        Me.btnorg.Size = New System.Drawing.Size(80, 40)
        Me.btnorg.TabIndex = 5
        Me.btnorg.Text = "&Start"
        Me.btnorg.UseVisualStyleBackColor = False
        '
        'pgbar
        '
        Me.pgbar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pgbar.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.pgbar.ForeColor = System.Drawing.Color.LightGray
        Me.pgbar.Location = New System.Drawing.Point(3, 437)
        Me.pgbar.Name = "pgbar"
        Me.pgbar.Size = New System.Drawing.Size(276, 34)
        Me.pgbar.TabIndex = 6
        '
        'lblprgs
        '
        Me.lblprgs.BackColor = System.Drawing.Color.White
        Me.lblprgs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblprgs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblprgs.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprgs.ForeColor = System.Drawing.Color.Black
        Me.lblprgs.Location = New System.Drawing.Point(286, 435)
        Me.lblprgs.Name = "lblprgs"
        Me.lblprgs.Size = New System.Drawing.Size(40, 40)
        Me.lblprgs.TabIndex = 7
        Me.lblprgs.Text = "0%"
        Me.lblprgs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtsrc
        '
        Me.txtsrc.BackColor = System.Drawing.Color.White
        Me.txtsrc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsrc.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsrc.ForeColor = System.Drawing.Color.Black
        Me.txtsrc.Location = New System.Drawing.Point(103, 21)
        Me.txtsrc.Name = "txtsrc"
        Me.txtsrc.Size = New System.Drawing.Size(454, 22)
        Me.txtsrc.TabIndex = 8
        '
        'btnreset
        '
        Me.btnreset.BackColor = System.Drawing.Color.Transparent
        Me.btnreset.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreset.ForeColor = System.Drawing.Color.Green
        Me.btnreset.Location = New System.Drawing.Point(329, 432)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(80, 40)
        Me.btnreset.TabIndex = 9
        Me.btnreset.Text = "&Reset"
        Me.btnreset.UseVisualStyleBackColor = False
        '
        'frmmain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Media.My.Resources.Resources.DSCN1281
        Me.ClientSize = New System.Drawing.Size(575, 469)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.txtsrc)
        Me.Controls.Add(Me.lblprgs)
        Me.Controls.Add(Me.pgbar)
        Me.Controls.Add(Me.btnorg)
        Me.Controls.Add(Me.txtdst)
        Me.Controls.Add(Me.lbldst)
        Me.Controls.Add(Me.lblsrc)
        Me.Controls.Add(Me.btnexit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmmain"
        Me.Text = "MEDIA MANAGER"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents lblsrc As System.Windows.Forms.Label
    Friend WithEvents lbldst As System.Windows.Forms.Label
    Friend WithEvents txtdst As System.Windows.Forms.TextBox
    Friend WithEvents btnorg As System.Windows.Forms.Button
    Friend WithEvents pgbar As System.Windows.Forms.ProgressBar
    Friend WithEvents lblprgs As System.Windows.Forms.Label
    Friend WithEvents txtsrc As System.Windows.Forms.TextBox
    Friend WithEvents btnreset As System.Windows.Forms.Button

End Class
