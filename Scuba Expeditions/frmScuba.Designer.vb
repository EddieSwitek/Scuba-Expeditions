<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmScuba
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmScuba))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.lblLength = New System.Windows.Forms.Label()
        Me.lblScubaDive = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDiveCost = New System.Windows.Forms.Button()
        Me.lstDive = New System.Windows.Forms.ListBox()
        Me.lblSelect = New System.Windows.Forms.Label()
        Me.txtTeam = New System.Windows.Forms.TextBox()
        Me.lblTeam = New System.Windows.Forms.Label()
        Me.cboLocation = New System.Windows.Forms.ComboBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(446, 451)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.lblCost)
        Me.Panel1.Controls.Add(Me.lblLength)
        Me.Panel1.Controls.Add(Me.lblScubaDive)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.btnDiveCost)
        Me.Panel1.Controls.Add(Me.lstDive)
        Me.Panel1.Controls.Add(Me.lblSelect)
        Me.Panel1.Controls.Add(Me.txtTeam)
        Me.Panel1.Controls.Add(Me.lblTeam)
        Me.Panel1.Controls.Add(Me.cboLocation)
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Location = New System.Drawing.Point(442, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(412, 451)
        Me.Panel1.TabIndex = 1
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.Location = New System.Drawing.Point(114, 402)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(180, 25)
        Me.lblCost.TabIndex = 10
        Me.lblCost.Text = "XXXXXXXXXXXX"
        Me.lblCost.Visible = False
        '
        'lblLength
        '
        Me.lblLength.AutoSize = True
        Me.lblLength.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLength.Location = New System.Drawing.Point(114, 426)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(180, 25)
        Me.lblLength.TabIndex = 9
        Me.lblLength.Text = "XXXXXXXXXXXX"
        Me.lblLength.Visible = False
        '
        'lblScubaDive
        '
        Me.lblScubaDive.AutoSize = True
        Me.lblScubaDive.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScubaDive.Location = New System.Drawing.Point(114, 377)
        Me.lblScubaDive.Name = "lblScubaDive"
        Me.lblScubaDive.Size = New System.Drawing.Size(180, 25)
        Me.lblScubaDive.TabIndex = 8
        Me.lblScubaDive.Text = "XXXXXXXXXXXX"
        Me.lblScubaDive.Visible = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(229, 310)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(142, 52)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear Form"
        Me.btnClear.UseVisualStyleBackColor = False
        Me.btnClear.Visible = False
        '
        'btnDiveCost
        '
        Me.btnDiveCost.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnDiveCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDiveCost.ForeColor = System.Drawing.Color.White
        Me.btnDiveCost.Location = New System.Drawing.Point(43, 310)
        Me.btnDiveCost.Name = "btnDiveCost"
        Me.btnDiveCost.Size = New System.Drawing.Size(142, 52)
        Me.btnDiveCost.TabIndex = 6
        Me.btnDiveCost.Text = "Dive Cost"
        Me.btnDiveCost.UseVisualStyleBackColor = False
        Me.btnDiveCost.Visible = False
        '
        'lstDive
        '
        Me.lstDive.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDive.FormattingEnabled = True
        Me.lstDive.ItemHeight = 24
        Me.lstDive.Location = New System.Drawing.Point(93, 181)
        Me.lstDive.Name = "lstDive"
        Me.lstDive.Size = New System.Drawing.Size(189, 76)
        Me.lstDive.TabIndex = 5
        Me.lstDive.Visible = False
        '
        'lblSelect
        '
        Me.lblSelect.AutoSize = True
        Me.lblSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelect.Location = New System.Drawing.Point(88, 153)
        Me.lblSelect.Name = "lblSelect"
        Me.lblSelect.Size = New System.Drawing.Size(194, 25)
        Me.lblSelect.TabIndex = 4
        Me.lblSelect.Text = "Select Scuba Dive:"
        Me.lblSelect.Visible = False
        '
        'txtTeam
        '
        Me.txtTeam.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTeam.Location = New System.Drawing.Point(288, 99)
        Me.txtTeam.Name = "txtTeam"
        Me.txtTeam.Size = New System.Drawing.Size(33, 31)
        Me.txtTeam.TabIndex = 3
        Me.txtTeam.Visible = False
        '
        'lblTeam
        '
        Me.lblTeam.AutoSize = True
        Me.lblTeam.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeam.Location = New System.Drawing.Point(57, 105)
        Me.lblTeam.Name = "lblTeam"
        Me.lblTeam.Size = New System.Drawing.Size(225, 25)
        Me.lblTeam.TabIndex = 2
        Me.lblTeam.Text = "Number in Dive Team:"
        Me.lblTeam.Visible = False
        '
        'cboLocation
        '
        Me.cboLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLocation.FormattingEnabled = True
        Me.cboLocation.Items.AddRange(New Object() {"Australia", "Beliz", "Fiji"})
        Me.cboLocation.Location = New System.Drawing.Point(127, 57)
        Me.cboLocation.Name = "cboLocation"
        Me.cboLocation.Size = New System.Drawing.Size(155, 32)
        Me.cboLocation.TabIndex = 1
        Me.cboLocation.Text = "Select Location:"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Impact", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblTitle.Location = New System.Drawing.Point(37, 7)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(334, 36)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Oceanic Scuba Expeditions"
        '
        'frmScuba
        '
        Me.AcceptButton = Me.btnDiveCost
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(854, 451)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmScuba"
        Me.Text = "Oceanic Scuba Expeditions"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblCost As Label
    Friend WithEvents lblLength As Label
    Friend WithEvents lblScubaDive As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDiveCost As Button
    Friend WithEvents lstDive As ListBox
    Friend WithEvents lblSelect As Label
    Friend WithEvents txtTeam As TextBox
    Friend WithEvents lblTeam As Label
    Friend WithEvents cboLocation As ComboBox
    Friend WithEvents lblTitle As Label
End Class
