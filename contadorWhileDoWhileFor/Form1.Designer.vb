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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtInicio = New System.Windows.Forms.TextBox()
        Me.txtFim = New System.Windows.Forms.TextBox()
        Me.txtSalto = New System.Windows.Forms.TextBox()
        Me.rbtCrescente = New System.Windows.Forms.RadioButton()
        Me.rbtDecrescente = New System.Windows.Forms.RadioButton()
        Me.btnWhile = New System.Windows.Forms.Button()
        Me.btnFor = New System.Windows.Forms.Button()
        Me.btnDoWhile = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(94, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CONTADOR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Início:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(39, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Salto:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(39, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Fim:"
        '
        'txtInicio
        '
        Me.txtInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInicio.Location = New System.Drawing.Point(98, 68)
        Me.txtInicio.Name = "txtInicio"
        Me.txtInicio.Size = New System.Drawing.Size(137, 22)
        Me.txtInicio.TabIndex = 4
        Me.txtInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFim
        '
        Me.txtFim.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFim.Location = New System.Drawing.Point(98, 97)
        Me.txtFim.Name = "txtFim"
        Me.txtFim.Size = New System.Drawing.Size(137, 22)
        Me.txtFim.TabIndex = 5
        Me.txtFim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSalto
        '
        Me.txtSalto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalto.Location = New System.Drawing.Point(98, 127)
        Me.txtSalto.Name = "txtSalto"
        Me.txtSalto.Size = New System.Drawing.Size(137, 22)
        Me.txtSalto.TabIndex = 6
        Me.txtSalto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'rbtCrescente
        '
        Me.rbtCrescente.AutoSize = True
        Me.rbtCrescente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtCrescente.Location = New System.Drawing.Point(46, 165)
        Me.rbtCrescente.Name = "rbtCrescente"
        Me.rbtCrescente.Size = New System.Drawing.Size(80, 19)
        Me.rbtCrescente.TabIndex = 7
        Me.rbtCrescente.TabStop = True
        Me.rbtCrescente.Text = "Crescente"
        Me.rbtCrescente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbtCrescente.UseVisualStyleBackColor = True
        '
        'rbtDecrescente
        '
        Me.rbtDecrescente.AutoSize = True
        Me.rbtDecrescente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtDecrescente.Location = New System.Drawing.Point(132, 165)
        Me.rbtDecrescente.Name = "rbtDecrescente"
        Me.rbtDecrescente.Size = New System.Drawing.Size(94, 19)
        Me.rbtDecrescente.TabIndex = 8
        Me.rbtDecrescente.TabStop = True
        Me.rbtDecrescente.Text = "Decrescente"
        Me.rbtDecrescente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbtDecrescente.UseVisualStyleBackColor = True
        '
        'btnWhile
        '
        Me.btnWhile.Location = New System.Drawing.Point(42, 200)
        Me.btnWhile.Name = "btnWhile"
        Me.btnWhile.Size = New System.Drawing.Size(193, 23)
        Me.btnWhile.TabIndex = 9
        Me.btnWhile.Text = "While"
        Me.btnWhile.UseVisualStyleBackColor = True
        '
        'btnFor
        '
        Me.btnFor.Location = New System.Drawing.Point(42, 258)
        Me.btnFor.Name = "btnFor"
        Me.btnFor.Size = New System.Drawing.Size(193, 23)
        Me.btnFor.TabIndex = 10
        Me.btnFor.Text = "For"
        Me.btnFor.UseVisualStyleBackColor = True
        '
        'btnDoWhile
        '
        Me.btnDoWhile.Location = New System.Drawing.Point(42, 229)
        Me.btnDoWhile.Name = "btnDoWhile"
        Me.btnDoWhile.Size = New System.Drawing.Size(193, 23)
        Me.btnDoWhile.TabIndex = 11
        Me.btnDoWhile.Text = "Do While"
        Me.btnDoWhile.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 312)
        Me.Controls.Add(Me.btnDoWhile)
        Me.Controls.Add(Me.btnFor)
        Me.Controls.Add(Me.btnWhile)
        Me.Controls.Add(Me.rbtDecrescente)
        Me.Controls.Add(Me.rbtCrescente)
        Me.Controls.Add(Me.txtSalto)
        Me.Controls.Add(Me.txtFim)
        Me.Controls.Add(Me.txtInicio)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Contador"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtInicio As System.Windows.Forms.TextBox
    Friend WithEvents txtFim As System.Windows.Forms.TextBox
    Friend WithEvents txtSalto As System.Windows.Forms.TextBox
    Friend WithEvents rbtCrescente As System.Windows.Forms.RadioButton
    Friend WithEvents rbtDecrescente As System.Windows.Forms.RadioButton
    Friend WithEvents btnWhile As System.Windows.Forms.Button
    Friend WithEvents btnFor As System.Windows.Forms.Button
    Friend WithEvents btnDoWhile As System.Windows.Forms.Button

End Class
