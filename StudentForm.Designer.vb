<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentForm
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
        Me.IDtxt = New System.Windows.Forms.TextBox()
        Me.stuNametxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.marktxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.depttxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.addbtn = New System.Windows.Forms.Button()
        Me.searchbtn = New System.Windows.Forms.Button()
        Me.updatebtn = New System.Windows.Forms.Button()
        Me.deletebtn = New System.Windows.Forms.Button()
        Me.displaytxt = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID:"
        '
        'IDtxt
        '
        Me.IDtxt.Location = New System.Drawing.Point(96, 36)
        Me.IDtxt.Name = "IDtxt"
        Me.IDtxt.Size = New System.Drawing.Size(268, 20)
        Me.IDtxt.TabIndex = 1
        '
        'stuNametxt
        '
        Me.stuNametxt.Location = New System.Drawing.Point(96, 79)
        Me.stuNametxt.Name = "stuNametxt"
        Me.stuNametxt.Size = New System.Drawing.Size(268, 20)
        Me.stuNametxt.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Name:"
        '
        'marktxt
        '
        Me.marktxt.Location = New System.Drawing.Point(96, 125)
        Me.marktxt.Name = "marktxt"
        Me.marktxt.Size = New System.Drawing.Size(268, 20)
        Me.marktxt.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(43, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Mark:"
        '
        'depttxt
        '
        Me.depttxt.Location = New System.Drawing.Point(96, 174)
        Me.depttxt.Name = "depttxt"
        Me.depttxt.Size = New System.Drawing.Size(268, 20)
        Me.depttxt.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(43, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Dept:"
        '
        'addbtn
        '
        Me.addbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addbtn.Location = New System.Drawing.Point(25, 239)
        Me.addbtn.Name = "addbtn"
        Me.addbtn.Size = New System.Drawing.Size(71, 47)
        Me.addbtn.TabIndex = 8
        Me.addbtn.Text = "ADD Student"
        Me.addbtn.UseVisualStyleBackColor = True
        '
        'searchbtn
        '
        Me.searchbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchbtn.Location = New System.Drawing.Point(119, 239)
        Me.searchbtn.Name = "searchbtn"
        Me.searchbtn.Size = New System.Drawing.Size(71, 47)
        Me.searchbtn.TabIndex = 9
        Me.searchbtn.Text = "Search"
        Me.searchbtn.UseVisualStyleBackColor = True
        '
        'updatebtn
        '
        Me.updatebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updatebtn.Location = New System.Drawing.Point(214, 239)
        Me.updatebtn.Name = "updatebtn"
        Me.updatebtn.Size = New System.Drawing.Size(71, 47)
        Me.updatebtn.TabIndex = 10
        Me.updatebtn.Text = "Update"
        Me.updatebtn.UseVisualStyleBackColor = True
        '
        'deletebtn
        '
        Me.deletebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deletebtn.Location = New System.Drawing.Point(306, 239)
        Me.deletebtn.Name = "deletebtn"
        Me.deletebtn.Size = New System.Drawing.Size(71, 47)
        Me.deletebtn.TabIndex = 11
        Me.deletebtn.Text = "Delete"
        Me.deletebtn.UseVisualStyleBackColor = True
        '
        'displaytxt
        '
        Me.displaytxt.Location = New System.Drawing.Point(432, 27)
        Me.displaytxt.Multiline = True
        Me.displaytxt.Name = "displaytxt"
        Me.displaytxt.Size = New System.Drawing.Size(307, 270)
        Me.displaytxt.TabIndex = 12
        '
        'StudentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 344)
        Me.Controls.Add(Me.displaytxt)
        Me.Controls.Add(Me.deletebtn)
        Me.Controls.Add(Me.updatebtn)
        Me.Controls.Add(Me.searchbtn)
        Me.Controls.Add(Me.addbtn)
        Me.Controls.Add(Me.depttxt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.marktxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.stuNametxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.IDtxt)
        Me.Controls.Add(Me.Label1)
        Me.Name = "StudentForm"
        Me.Text = "Student Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents IDtxt As TextBox
    Friend WithEvents stuNametxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents marktxt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents depttxt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents addbtn As Button
    Friend WithEvents searchbtn As Button
    Friend WithEvents updatebtn As Button
    Friend WithEvents deletebtn As Button
    Friend WithEvents displaytxt As TextBox
End Class
