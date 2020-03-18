<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Me.txtLimite = New System.Windows.Forms.TextBox()
        Me.btnLancer = New System.Windows.Forms.Button()
        Me.lsTires = New System.Windows.Forms.ListBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ChartTirage = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.lbllInstruction = New System.Windows.Forms.Label()
        Me.btnTracer = New System.Windows.Forms.Button()
        Me.btnQuitter = New System.Windows.Forms.Button()
        CType(Me.ChartTirage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtLimite
        '
        Me.txtLimite.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLimite.Location = New System.Drawing.Point(281, 102)
        Me.txtLimite.Name = "txtLimite"
        Me.txtLimite.Size = New System.Drawing.Size(153, 28)
        Me.txtLimite.TabIndex = 0
        '
        'btnLancer
        '
        Me.btnLancer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLancer.Location = New System.Drawing.Point(563, 95)
        Me.btnLancer.Name = "btnLancer"
        Me.btnLancer.Size = New System.Drawing.Size(131, 37)
        Me.btnLancer.TabIndex = 1
        Me.btnLancer.Text = "LANCER"
        Me.btnLancer.UseVisualStyleBackColor = True
        '
        'lsTires
        '
        Me.lsTires.FormattingEnabled = True
        Me.lsTires.ItemHeight = 16
        Me.lsTires.Location = New System.Drawing.Point(102, 176)
        Me.lsTires.Name = "lsTires"
        Me.lsTires.Size = New System.Drawing.Size(120, 228)
        Me.lsTires.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(578, 176)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 37)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "RESET"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ChartTirage
        '
        ChartArea1.AxisX.Title = "Rang de tirage"
        ChartArea1.AxisY.Title = "Nombres tirés"
        ChartArea1.Name = "ChartArea1"
        Me.ChartTirage.ChartAreas.Add(ChartArea1)
        Me.ChartTirage.Location = New System.Drawing.Point(310, 243)
        Me.ChartTirage.Name = "ChartTirage"
        Me.ChartTirage.Size = New System.Drawing.Size(394, 161)
        Me.ChartTirage.TabIndex = 4
        Me.ChartTirage.Text = "ChartTirage"
        '
        'lblTitre
        '
        Me.lblTitre.AutoSize = True
        Me.lblTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitre.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblTitre.Location = New System.Drawing.Point(64, 21)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(212, 36)
        Me.lblTitre.TabIndex = 5
        Me.lblTitre.Text = "Tirage au sort"
        Me.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbllInstruction
        '
        Me.lbllInstruction.AutoSize = True
        Me.lbllInstruction.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllInstruction.Location = New System.Drawing.Point(88, 100)
        Me.lbllInstruction.Name = "lbllInstruction"
        Me.lbllInstruction.Size = New System.Drawing.Size(167, 24)
        Me.lbllInstruction.TabIndex = 6
        Me.lbllInstruction.Text = "Entrez un nombre:"
        '
        'btnTracer
        '
        Me.btnTracer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTracer.Location = New System.Drawing.Point(334, 176)
        Me.btnTracer.Name = "btnTracer"
        Me.btnTracer.Size = New System.Drawing.Size(100, 37)
        Me.btnTracer.TabIndex = 7
        Me.btnTracer.Text = "TRACER"
        Me.btnTracer.UseVisualStyleBackColor = True
        '
        'btnQuitter
        '
        Me.btnQuitter.Location = New System.Drawing.Point(578, 21)
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.Size = New System.Drawing.Size(100, 36)
        Me.btnQuitter.TabIndex = 8
        Me.btnQuitter.Text = "Quitter"
        Me.btnQuitter.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnQuitter)
        Me.Controls.Add(Me.btnTracer)
        Me.Controls.Add(Me.lbllInstruction)
        Me.Controls.Add(Me.lblTitre)
        Me.Controls.Add(Me.ChartTirage)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.lsTires)
        Me.Controls.Add(Me.btnLancer)
        Me.Controls.Add(Me.txtLimite)
        Me.Name = "Form1"
        Me.Text = "TD3 - Gestion du hasard et graphiques"
        CType(Me.ChartTirage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtLimite As TextBox
    Friend WithEvents btnLancer As Button
    Friend WithEvents lsTires As ListBox
    Friend WithEvents Button2 As Button
    Friend WithEvents ChartTirage As DataVisualization.Charting.Chart
    Friend WithEvents lblTitre As Label
    Friend WithEvents lbllInstruction As Label
    Friend WithEvents btnTracer As Button
    Friend WithEvents btnQuitter As Button
End Class
