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
        Me.btnexit.Location = New System.Drawing.Point(434, 204)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(75, 30)
        Me.btnexit.TabIndex = 0
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'lblsrc
        '
        Me.lblsrc.AutoSize = True
        Me.lblsrc.Location = New System.Drawing.Point(44, 114)
        Me.lblsrc.Name = "lblsrc"
        Me.lblsrc.Size = New System.Drawing.Size(73, 13)
        Me.lblsrc.TabIndex = 1
        Me.lblsrc.Text = "Media Source"
        '
        'lbldst
        '
        Me.lbldst.AutoSize = True
        Me.lbldst.Location = New System.Drawing.Point(41, 148)
        Me.lbldst.Name = "lbldst"
        Me.lbldst.Size = New System.Drawing.Size(92, 13)
        Me.lbldst.TabIndex = 2
        Me.lbldst.Text = "Media Destination"
        '
        'txtsrc
        '
        Me.txtsrc.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsrc.Location = New System.Drawing.Point(169, 106)
        Me.txtsrc.Name = "txtsrc"
        Me.txtsrc.Size = New System.Drawing.Size(242, 22)
        Me.txtsrc.TabIndex = 3
        '
        'txtdst
        '
        Me.txtdst.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdst.Location = New System.Drawing.Point(171, 145)
        Me.txtdst.Name = "txtdst"
        Me.txtdst.Size = New System.Drawing.Size(238, 22)
        Me.txtdst.TabIndex = 4
        '
        'btnorg
        '
        Me.btnorg.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnorg.Location = New System.Drawing.Point(353, 204)
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
        Me.ClientSize = New System.Drawing.Size(535, 252)
        Me.Controls.Add(Me.btnorg)
        Me.Controls.Add(Me.txtdst)
        Me.Controls.Add(Me.txtsrc)
        Me.Controls.Add(Me.lbldst)
        Me.Controls.Add(Me.lblsrc)
        Me.Controls.Add(Me.btnexit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmmain"
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
