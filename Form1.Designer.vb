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
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtReg = New System.Windows.Forms.TextBox()
        Me.txtFname = New System.Windows.Forms.TextBox()
        Me.txtLname = New System.Windows.Forms.TextBox()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.txtAdm = New System.Windows.Forms.TextBox()
        Me.txtNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLoad
        '
        Me.btnLoad.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnLoad.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoad.Location = New System.Drawing.Point(52, 288)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(267, 33)
        Me.btnLoad.TabIndex = 0
        Me.btnLoad.Text = "Load Database"
        Me.btnLoad.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Papyrus", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(52, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "RegNo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Papyrus", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(49, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "FName"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Papyrus", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(52, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 19)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "LName"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Papyrus", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(49, 203)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 19)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Contact"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Papyrus", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 242)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 19)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Date Of Admission"
        '
        'txtReg
        '
        Me.txtReg.Location = New System.Drawing.Point(150, 51)
        Me.txtReg.Name = "txtReg"
        Me.txtReg.Size = New System.Drawing.Size(151, 20)
        Me.txtReg.TabIndex = 6
        '
        'txtFname
        '
        Me.txtFname.Location = New System.Drawing.Point(150, 100)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(151, 20)
        Me.txtFname.TabIndex = 7
        '
        'txtLname
        '
        Me.txtLname.Location = New System.Drawing.Point(150, 155)
        Me.txtLname.Name = "txtLname"
        Me.txtLname.Size = New System.Drawing.Size(151, 20)
        Me.txtLname.TabIndex = 8
        '
        'txtContact
        '
        Me.txtContact.Location = New System.Drawing.Point(150, 203)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(151, 20)
        Me.txtContact.TabIndex = 9
        '
        'txtAdm
        '
        Me.txtAdm.Location = New System.Drawing.Point(150, 242)
        Me.txtAdm.Name = "txtAdm"
        Me.txtAdm.Size = New System.Drawing.Size(151, 20)
        Me.txtAdm.TabIndex = 10
        '
        'txtNext
        '
        Me.txtNext.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtNext.Font = New System.Drawing.Font("Papyrus", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNext.Location = New System.Drawing.Point(55, 337)
        Me.txtNext.Name = "txtNext"
        Me.txtNext.Size = New System.Drawing.Size(75, 26)
        Me.txtNext.TabIndex = 11
        Me.txtNext.Text = "Next"
        Me.txtNext.UseVisualStyleBackColor = False
        '
        'btnPrevious
        '
        Me.btnPrevious.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnPrevious.Font = New System.Drawing.Font("Papyrus", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.Location = New System.Drawing.Point(244, 337)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(75, 26)
        Me.btnPrevious.TabIndex = 12
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnClear.Font = New System.Drawing.Font("Papyrus", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(55, 385)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnAdd.Font = New System.Drawing.Font("Papyrus", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(150, 337)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 14
        Me.btnAdd.Text = "Add "
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnClose.Font = New System.Drawing.Font("Papyrus", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(244, 385)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 15
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnSearch.Font = New System.Drawing.Font("Papyrus", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(150, 385)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 16
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'DataGridView
        '
        Me.DataGridView.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.GridColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.DataGridView.Location = New System.Drawing.Point(503, 37)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.Size = New System.Drawing.Size(414, 312)
        Me.DataGridView.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Papyrus", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(393, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 24)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "GIGANET"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(927, 430)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DataGridView)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.txtNext)
        Me.Controls.Add(Me.txtAdm)
        Me.Controls.Add(Me.txtContact)
        Me.Controls.Add(Me.txtLname)
        Me.Controls.Add(Me.txtFname)
        Me.Controls.Add(Me.txtReg)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLoad)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtReg As System.Windows.Forms.TextBox
    Friend WithEvents txtFname As System.Windows.Forms.TextBox
    Friend WithEvents txtLname As System.Windows.Forms.TextBox
    Friend WithEvents txtContact As System.Windows.Forms.TextBox
    Friend WithEvents txtAdm As System.Windows.Forms.TextBox
    Friend WithEvents txtNext As System.Windows.Forms.Button
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
