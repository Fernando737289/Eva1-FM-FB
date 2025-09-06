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
        PictureBox1 = New PictureBox()
        txtDisplay = New TextBox()
        btBorrar = New Button()
        btDiv = New Button()
        btMul = New Button()
        bt9 = New Button()
        bt7 = New Button()
        bt8 = New Button()
        bt4 = New Button()
        bt5 = New Button()
        bt6 = New Button()
        btRestar = New Button()
        bt1 = New Button()
        bt2 = New Button()
        bt3 = New Button()
        btSum = New Button()
        bt0 = New Button()
        btIgual = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(64, 22)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(215, 77)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' txtDisplay
        ' 
        txtDisplay.Location = New Point(46, 123)
        txtDisplay.Name = "txtDisplay"
        txtDisplay.Size = New Size(249, 23)
        txtDisplay.TabIndex = 1
        ' 
        ' btBorrar
        ' 
        btBorrar.Location = New Point(46, 171)
        btBorrar.Name = "btBorrar"
        btBorrar.Size = New Size(184, 28)
        btBorrar.TabIndex = 2
        btBorrar.Text = "Borrar"
        btBorrar.UseVisualStyleBackColor = True
        ' 
        ' btDiv
        ' 
        btDiv.Location = New Point(250, 171)
        btDiv.Name = "btDiv"
        btDiv.Size = New Size(45, 28)
        btDiv.TabIndex = 3
        btDiv.Text = "/"
        btDiv.UseVisualStyleBackColor = True
        ' 
        ' btMul
        ' 
        btMul.Location = New Point(250, 220)
        btMul.Name = "btMul"
        btMul.Size = New Size(45, 28)
        btMul.TabIndex = 4
        btMul.Text = "X"
        btMul.UseVisualStyleBackColor = True
        ' 
        ' bt9
        ' 
        bt9.Location = New Point(185, 220)
        bt9.Name = "bt9"
        bt9.Size = New Size(45, 28)
        bt9.TabIndex = 5
        bt9.Text = "9"
        bt9.UseVisualStyleBackColor = True
        ' 
        ' bt7
        ' 
        bt7.Location = New Point(46, 220)
        bt7.Name = "bt7"
        bt7.Size = New Size(45, 28)
        bt7.TabIndex = 6
        bt7.Text = "7"
        bt7.UseVisualStyleBackColor = True
        ' 
        ' bt8
        ' 
        bt8.Location = New Point(116, 220)
        bt8.Name = "bt8"
        bt8.Size = New Size(45, 28)
        bt8.TabIndex = 7
        bt8.Text = "8"
        bt8.UseVisualStyleBackColor = True
        ' 
        ' bt4
        ' 
        bt4.Location = New Point(46, 278)
        bt4.Name = "bt4"
        bt4.Size = New Size(45, 28)
        bt4.TabIndex = 8
        bt4.Text = "4"
        bt4.UseVisualStyleBackColor = True
        ' 
        ' bt5
        ' 
        bt5.Location = New Point(116, 278)
        bt5.Name = "bt5"
        bt5.Size = New Size(45, 28)
        bt5.TabIndex = 9
        bt5.Text = "5"
        bt5.UseVisualStyleBackColor = True
        ' 
        ' bt6
        ' 
        bt6.Location = New Point(185, 278)
        bt6.Name = "bt6"
        bt6.Size = New Size(45, 28)
        bt6.TabIndex = 10
        bt6.Text = "6"
        bt6.UseVisualStyleBackColor = True
        ' 
        ' btRestar
        ' 
        btRestar.Location = New Point(250, 278)
        btRestar.Name = "btRestar"
        btRestar.Size = New Size(45, 28)
        btRestar.TabIndex = 11
        btRestar.Text = "-"
        btRestar.UseVisualStyleBackColor = True
        ' 
        ' bt1
        ' 
        bt1.Location = New Point(46, 336)
        bt1.Name = "bt1"
        bt1.Size = New Size(45, 28)
        bt1.TabIndex = 12
        bt1.Text = "1"
        bt1.UseVisualStyleBackColor = True
        ' 
        ' bt2
        ' 
        bt2.Location = New Point(116, 336)
        bt2.Name = "bt2"
        bt2.Size = New Size(45, 28)
        bt2.TabIndex = 13
        bt2.Text = "2"
        bt2.UseVisualStyleBackColor = True
        ' 
        ' bt3
        ' 
        bt3.Location = New Point(185, 336)
        bt3.Name = "bt3"
        bt3.Size = New Size(45, 28)
        bt3.TabIndex = 14
        bt3.Text = "3"
        bt3.UseVisualStyleBackColor = True
        ' 
        ' btSum
        ' 
        btSum.Location = New Point(250, 336)
        btSum.Name = "btSum"
        btSum.Size = New Size(45, 28)
        btSum.TabIndex = 15
        btSum.Text = "+"
        btSum.UseVisualStyleBackColor = True
        ' 
        ' bt0
        ' 
        bt0.Location = New Point(46, 386)
        bt0.Name = "bt0"
        bt0.Size = New Size(115, 28)
        bt0.TabIndex = 16
        bt0.Text = "0"
        bt0.UseVisualStyleBackColor = True
        ' 
        ' btIgual
        ' 
        btIgual.Location = New Point(185, 386)
        btIgual.Name = "btIgual"
        btIgual.Size = New Size(110, 28)
        btIgual.TabIndex = 17
        btIgual.Text = "="
        btIgual.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(345, 450)
        Controls.Add(btIgual)
        Controls.Add(bt0)
        Controls.Add(btSum)
        Controls.Add(bt3)
        Controls.Add(bt2)
        Controls.Add(bt1)
        Controls.Add(btRestar)
        Controls.Add(bt6)
        Controls.Add(bt5)
        Controls.Add(bt4)
        Controls.Add(bt8)
        Controls.Add(bt7)
        Controls.Add(bt9)
        Controls.Add(btMul)
        Controls.Add(btDiv)
        Controls.Add(btBorrar)
        Controls.Add(txtDisplay)
        Controls.Add(PictureBox1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtDisplay As TextBox
    Friend WithEvents btBorrar As Button
    Friend WithEvents btDiv As Button
    Friend WithEvents btMul As Button
    Friend WithEvents bt9 As Button
    Friend WithEvents bt7 As Button
    Friend WithEvents bt8 As Button
    Friend WithEvents bt4 As Button
    Friend WithEvents bt5 As Button
    Friend WithEvents bt6 As Button
    Friend WithEvents btRestar As Button
    Friend WithEvents bt1 As Button
    Friend WithEvents bt2 As Button
    Friend WithEvents bt3 As Button
    Friend WithEvents btSum As Button
    Friend WithEvents bt0 As Button
    Friend WithEvents btIgual As Button

End Class
