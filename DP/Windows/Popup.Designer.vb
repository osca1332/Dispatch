<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Popup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Popup))
        Me.unit_box = New System.Windows.Forms.TextBox()
        Me.comment_box = New System.Windows.Forms.TextBox()
        Me.unit_tag = New System.Windows.Forms.Label()
        Me.comment_tag = New System.Windows.Forms.Label()
        Me.confirm_btn = New System.Windows.Forms.Button()
        Me.status_box = New System.Windows.Forms.TextBox()
        Me.status_tag = New System.Windows.Forms.Label()
        Me.event_box = New System.Windows.Forms.TextBox()
        Me.location_box = New System.Windows.Forms.TextBox()
        Me.event_tag = New System.Windows.Forms.Label()
        Me.location_tag = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'unit_box
        '
        Me.unit_box.BackColor = System.Drawing.Color.Black
        Me.unit_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.unit_box.ForeColor = System.Drawing.Color.Lime
        Me.unit_box.Location = New System.Drawing.Point(12, 12)
        Me.unit_box.Name = "unit_box"
        Me.unit_box.Size = New System.Drawing.Size(48, 20)
        Me.unit_box.TabIndex = 0
        '
        'comment_box
        '
        Me.comment_box.BackColor = System.Drawing.Color.Black
        Me.comment_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.comment_box.ForeColor = System.Drawing.Color.Lime
        Me.comment_box.Location = New System.Drawing.Point(12, 38)
        Me.comment_box.Name = "comment_box"
        Me.comment_box.Size = New System.Drawing.Size(233, 20)
        Me.comment_box.TabIndex = 2
        '
        'unit_tag
        '
        Me.unit_tag.AutoSize = True
        Me.unit_tag.ForeColor = System.Drawing.Color.Blue
        Me.unit_tag.Location = New System.Drawing.Point(66, 15)
        Me.unit_tag.Name = "unit_tag"
        Me.unit_tag.Size = New System.Drawing.Size(33, 13)
        Me.unit_tag.TabIndex = 2
        Me.unit_tag.Text = "UNIT"
        '
        'comment_tag
        '
        Me.comment_tag.AutoSize = True
        Me.comment_tag.ForeColor = System.Drawing.Color.Blue
        Me.comment_tag.Location = New System.Drawing.Point(251, 41)
        Me.comment_tag.Name = "comment_tag"
        Me.comment_tag.Size = New System.Drawing.Size(62, 13)
        Me.comment_tag.TabIndex = 3
        Me.comment_tag.Text = "COMMENT"
        '
        'confirm_btn
        '
        Me.confirm_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.confirm_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.confirm_btn.ForeColor = System.Drawing.Color.Lime
        Me.confirm_btn.Location = New System.Drawing.Point(12, 130)
        Me.confirm_btn.Name = "confirm_btn"
        Me.confirm_btn.Size = New System.Drawing.Size(75, 23)
        Me.confirm_btn.TabIndex = 5
        Me.confirm_btn.Text = "UPDATE"
        Me.confirm_btn.UseVisualStyleBackColor = True
        '
        'status_box
        '
        Me.status_box.BackColor = System.Drawing.Color.Black
        Me.status_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.status_box.ForeColor = System.Drawing.Color.Lime
        Me.status_box.Location = New System.Drawing.Point(197, 12)
        Me.status_box.Name = "status_box"
        Me.status_box.Size = New System.Drawing.Size(48, 20)
        Me.status_box.TabIndex = 1
        '
        'status_tag
        '
        Me.status_tag.AutoSize = True
        Me.status_tag.ForeColor = System.Drawing.Color.Blue
        Me.status_tag.Location = New System.Drawing.Point(251, 15)
        Me.status_tag.Name = "status_tag"
        Me.status_tag.Size = New System.Drawing.Size(50, 13)
        Me.status_tag.TabIndex = 6
        Me.status_tag.Text = "STATUS"
        '
        'event_box
        '
        Me.event_box.BackColor = System.Drawing.Color.Black
        Me.event_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.event_box.ForeColor = System.Drawing.Color.Lime
        Me.event_box.Location = New System.Drawing.Point(12, 64)
        Me.event_box.Name = "event_box"
        Me.event_box.Size = New System.Drawing.Size(233, 20)
        Me.event_box.TabIndex = 3
        '
        'location_box
        '
        Me.location_box.BackColor = System.Drawing.Color.Black
        Me.location_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.location_box.ForeColor = System.Drawing.Color.Lime
        Me.location_box.Location = New System.Drawing.Point(12, 90)
        Me.location_box.Name = "location_box"
        Me.location_box.Size = New System.Drawing.Size(233, 20)
        Me.location_box.TabIndex = 4
        '
        'event_tag
        '
        Me.event_tag.AutoSize = True
        Me.event_tag.ForeColor = System.Drawing.Color.Blue
        Me.event_tag.Location = New System.Drawing.Point(251, 67)
        Me.event_tag.Name = "event_tag"
        Me.event_tag.Size = New System.Drawing.Size(43, 13)
        Me.event_tag.TabIndex = 9
        Me.event_tag.Text = "EVENT"
        '
        'location_tag
        '
        Me.location_tag.AutoSize = True
        Me.location_tag.ForeColor = System.Drawing.Color.Blue
        Me.location_tag.Location = New System.Drawing.Point(251, 93)
        Me.location_tag.Name = "location_tag"
        Me.location_tag.Size = New System.Drawing.Size(61, 13)
        Me.location_tag.TabIndex = 10
        Me.location_tag.Text = "LOCATION"
        '
        'Popup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(444, 225)
        Me.Controls.Add(Me.location_tag)
        Me.Controls.Add(Me.event_tag)
        Me.Controls.Add(Me.location_box)
        Me.Controls.Add(Me.event_box)
        Me.Controls.Add(Me.status_tag)
        Me.Controls.Add(Me.status_box)
        Me.Controls.Add(Me.confirm_btn)
        Me.Controls.Add(Me.comment_tag)
        Me.Controls.Add(Me.unit_tag)
        Me.Controls.Add(Me.comment_box)
        Me.Controls.Add(Me.unit_box)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Popup"
        Me.Text = "Popup"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents unit_box As TextBox
    Friend WithEvents comment_box As TextBox
    Friend WithEvents unit_tag As Label
    Friend WithEvents comment_tag As Label
    Friend WithEvents confirm_btn As Button
    Friend WithEvents status_box As TextBox
    Friend WithEvents status_tag As Label
    Friend WithEvents event_box As TextBox
    Friend WithEvents location_box As TextBox
    Friend WithEvents event_tag As Label
    Friend WithEvents location_tag As Label
End Class
