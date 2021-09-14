<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFallMarathon
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFallMarathon))
        Me.lblFallMarathon = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.btnViewInfo = New System.Windows.Forms.Button()
        Me.picMarathon = New System.Windows.Forms.PictureBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblMoreInfo = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picMarathon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFallMarathon
        '
        Me.lblFallMarathon.AutoSize = True
        Me.lblFallMarathon.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFallMarathon.Location = New System.Drawing.Point(119, 0)
        Me.lblFallMarathon.Name = "lblFallMarathon"
        Me.lblFallMarathon.Size = New System.Drawing.Size(157, 25)
        Me.lblFallMarathon.TabIndex = 0
        Me.lblFallMarathon.Text = "Fall Marathon"
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(61, 30)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(272, 16)
        Me.lblWelcome.TabIndex = 1
        Me.lblWelcome.Text = "Full and Half Marathon Runners  are Welcome"
        '
        'btnViewInfo
        '
        Me.btnViewInfo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewInfo.Location = New System.Drawing.Point(249, 129)
        Me.btnViewInfo.Name = "btnViewInfo"
        Me.btnViewInfo.Size = New System.Drawing.Size(135, 23)
        Me.btnViewInfo.TabIndex = 2
        Me.btnViewInfo.Text = "View Information"
        Me.btnViewInfo.UseVisualStyleBackColor = True
        '
        'picMarathon
        '
        Me.picMarathon.Image = CType(resources.GetObject("picMarathon.Image"), System.Drawing.Image)
        Me.picMarathon.Location = New System.Drawing.Point(12, 52)
        Me.picMarathon.Name = "picMarathon"
        Me.picMarathon.Size = New System.Drawing.Size(225, 201)
        Me.picMarathon.TabIndex = 3
        Me.picMarathon.TabStop = False
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(256, 192)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(116, 14)
        Me.lblDate.TabIndex = 4
        Me.lblDate.Text = "Date: May 30, 2017"
        Me.lblDate.Visible = False
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocation.Location = New System.Drawing.Point(245, 232)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(145, 14)
        Me.lblLocation.TabIndex = 5
        Me.lblLocation.Text = "Start Location: Ryan Park"
        Me.lblLocation.Visible = False
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(255, 213)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(119, 14)
        Me.lblTime.TabIndex = 6
        Me.lblTime.Text = "Start Time: 8:00 AM"
        Me.lblTime.Visible = False
        '
        'lblMoreInfo
        '
        Me.lblMoreInfo.AutoSize = True
        Me.lblMoreInfo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMoreInfo.Location = New System.Drawing.Point(20, 269)
        Me.lblMoreInfo.Name = "lblMoreInfo"
        Me.lblMoreInfo.Size = New System.Drawing.Size(354, 14)
        Me.lblMoreInfo.TabIndex = 7
        Me.lblMoreInfo.Text = "For more information, view the Fall Marathon Facebook page 3."
        Me.lblMoreInfo.Visible = False
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(160, 302)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmFallMarathon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 330)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblMoreInfo)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblLocation)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.picMarathon)
        Me.Controls.Add(Me.btnViewInfo)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.lblFallMarathon)
        Me.Name = "frmFallMarathon"
        Me.Text = "Fall Marathon"
        CType(Me.picMarathon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFallMarathon As Label
    Friend WithEvents lblWelcome As Label
    Friend WithEvents btnViewInfo As Button
    Friend WithEvents picMarathon As PictureBox
    Friend WithEvents lblDate As Label
    Friend WithEvents lblLocation As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents lblMoreInfo As Label
    Friend WithEvents btnExit As Button
End Class
