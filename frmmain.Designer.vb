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
        Me.txtsrc = New System.Windows.Forms.TextBox()
        Me.txtdst = New System.Windows.Forms.TextBox()
        Me.btnorg = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnexit
        '
        Me.btnexit.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Location = New System.Drawing.Point(450, 130)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(75, 30)
        Me.btnexit.TabIndex = 0
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'lblsrc
        '
        Me.lblsrc.AutoSize = True
        Me.lblsrc.BackColor = System.Drawing.Color.Transparent
        Me.lblsrc.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsrc.ForeColor = System.Drawing.Color.Red
        Me.lblsrc.Location = New System.Drawing.Point(8, 22)
        Me.lblsrc.Name = "lblsrc"
        Me.lblsrc.Size = New System.Drawing.Size(103, 19)
        Me.lblsrc.TabIndex = 1
        Me.lblsrc.Text = "Media Source"
        '
        'lbldst
        '
        Me.lbldst.AutoSize = True
        Me.lbldst.BackColor = System.Drawing.Color.Transparent
        Me.lbldst.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldst.ForeColor = System.Drawing.Color.Red
        Me.lbldst.Location = New System.Drawing.Point(9, 61)
        Me.lbldst.Name = "lbldst"
        Me.lbldst.Size = New System.Drawing.Size(134, 19)
        Me.lbldst.TabIndex = 2
        Me.lbldst.Text = "Media Destination"
        '
        'txtsrc
        '
        Me.txtsrc.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtsrc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtsrc.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsrc.Location = New System.Drawing.Point(150, 22)
        Me.txtsrc.Name = "txtsrc"
        Me.txtsrc.Size = New System.Drawing.Size(300, 18)
        Me.txtsrc.TabIndex = 3
        '
        'txtdst
        '
        Me.txtdst.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtdst.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtdst.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdst.Location = New System.Drawing.Point(150, 61)
        Me.txtdst.Name = "txtdst"
        Me.txtdst.Size = New System.Drawing.Size(300, 18)
        Me.txtdst.TabIndex = 4
        '
        'btnorg
        '
        Me.btnorg.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnorg.Location = New System.Drawing.Point(452, 93)
        Me.btnorg.Name = "btnorg"
        Me.btnorg.Size = New System.Drawing.Size(75, 31)
        Me.btnorg.TabIndex = 5
        Me.btnorg.Text = "Begin"
        Me.btnorg.UseVisualStyleBackColor = True
        '
        'frmmain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Media.My.Resources.Resources.DSCN1281
        Me.ClientSize = New System.Drawing.Size(535, 252)
        Me.Controls.Add(Me.btnorg)
        Me.Controls.Add(Me.txtdst)
        Me.Controls.Add(Me.txtsrc)
        Me.Controls.Add(Me.lbldst)
        Me.Controls.Add(Me.lblsrc)
        Me.Controls.Add(Me.btnexit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmmain"
        Me.TransparencyKey = System.Drawing.Color.White
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents lblsrc As System.Windows.Forms.Label
    Friend WithEvents lbldst As System.Windows.Forms.Label
    Friend WithEvents txtsrc As System.Windows.Forms.TextBox
    Friend WithEvents txtdst As System.Windows.Forms.TextBox
    Friend WithEvents btnorg As System.Windows.Forms.Button

End Class
