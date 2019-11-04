<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Me.connectbtn = New System.Windows.Forms.Button()
        Me.dbtxt = New System.Windows.Forms.TextBox()
        Me.pwstxt = New System.Windows.Forms.TextBox()
        Me.usertxt = New System.Windows.Forms.TextBox()
        Me.servertxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'connectbtn
        '
        Me.connectbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.connectbtn.Location = New System.Drawing.Point(322, 294)
        Me.connectbtn.Name = "connectbtn"
        Me.connectbtn.Size = New System.Drawing.Size(111, 50)
        Me.connectbtn.TabIndex = 26
        Me.connectbtn.Text = "Connect"
        Me.connectbtn.UseVisualStyleBackColor = True
        '
        'dbtxt
        '
        Me.dbtxt.Location = New System.Drawing.Point(322, 242)
        Me.dbtxt.Name = "dbtxt"
        Me.dbtxt.Size = New System.Drawing.Size(275, 20)
        Me.dbtxt.TabIndex = 25
        '
        'pwstxt
        '
        Me.pwstxt.Location = New System.Drawing.Point(322, 194)
        Me.pwstxt.Name = "pwstxt"
        Me.pwstxt.Size = New System.Drawing.Size(275, 20)
        Me.pwstxt.TabIndex = 24
        '
        'usertxt
        '
        Me.usertxt.Location = New System.Drawing.Point(322, 150)
        Me.usertxt.Name = "usertxt"
        Me.usertxt.Size = New System.Drawing.Size(275, 20)
        Me.usertxt.TabIndex = 23
        '
        'servertxt
        '
        Me.servertxt.Location = New System.Drawing.Point(322, 107)
        Me.servertxt.Name = "servertxt"
        Me.servertxt.Size = New System.Drawing.Size(275, 20)
        Me.servertxt.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(204, 242)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 16)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Database"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(204, 198)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 16)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(204, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 16)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "User Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(204, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 16)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Server Name"
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.connectbtn)
        Me.Controls.Add(Me.dbtxt)
        Me.Controls.Add(Me.pwstxt)
        Me.Controls.Add(Me.usertxt)
        Me.Controls.Add(Me.servertxt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "LoginForm"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents connectbtn As Button
    Friend WithEvents dbtxt As TextBox
    Friend WithEvents pwstxt As TextBox
    Friend WithEvents usertxt As TextBox
    Friend WithEvents servertxt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
