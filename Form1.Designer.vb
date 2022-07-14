<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.CB_Sports = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CB_BAUD = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CB_Data_Bits = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CB_StopBits = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXT_main = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'CB_Sports
        '
        Me.CB_Sports.FormattingEnabled = True
        Me.CB_Sports.Location = New System.Drawing.Point(12, 43)
        Me.CB_Sports.Name = "CB_Sports"
        Me.CB_Sports.Size = New System.Drawing.Size(133, 21)
        Me.CB_Sports.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(414, 43)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Open COM Port"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CB_BAUD
        '
        Me.CB_BAUD.FormattingEnabled = True
        Me.CB_BAUD.Items.AddRange(New Object() {"1200", "2400", "4800", "9600", "14400", "19200", "28800", "38400", "57600", "115200", "230400"})
        Me.CB_BAUD.Location = New System.Drawing.Point(151, 43)
        Me.CB_BAUD.Name = "CB_BAUD"
        Me.CB_BAUD.Size = New System.Drawing.Size(121, 21)
        Me.CB_BAUD.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Com Port"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(182, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Baud Rate"
        '
        'CB_Data_Bits
        '
        Me.CB_Data_Bits.FormattingEnabled = True
        Me.CB_Data_Bits.Items.AddRange(New Object() {"5", "6", "7", "8"})
        Me.CB_Data_Bits.Location = New System.Drawing.Point(278, 43)
        Me.CB_Data_Bits.Name = "CB_Data_Bits"
        Me.CB_Data_Bits.Size = New System.Drawing.Size(62, 21)
        Me.CB_Data_Bits.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(284, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Data Bits"
        '
        'CB_StopBits
        '
        Me.CB_StopBits.FormattingEnabled = True
        Me.CB_StopBits.Items.AddRange(New Object() {"1", "2"})
        Me.CB_StopBits.Location = New System.Drawing.Point(346, 43)
        Me.CB_StopBits.Name = "CB_StopBits"
        Me.CB_StopBits.Size = New System.Drawing.Size(62, 21)
        Me.CB_StopBits.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(353, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Stop Bits"
        '
        'TXT_main
        '
        Me.TXT_main.Location = New System.Drawing.Point(12, 206)
        Me.TXT_main.Multiline = True
        Me.TXT_main.Name = "TXT_main"
        Me.TXT_main.Size = New System.Drawing.Size(609, 281)
        Me.TXT_main.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(633, 499)
        Me.Controls.Add(Me.TXT_main)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CB_StopBits)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CB_Data_Bits)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CB_BAUD)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CB_Sports)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Scanner Watch"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CB_Sports As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents CB_BAUD As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CB_Data_Bits As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CB_StopBits As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TXT_main As TextBox
End Class
