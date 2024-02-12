<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMasterDokter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMasterDokter))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtIDDokter_Akmal = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNama_Akmal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker_Akmal = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RadioButtonLakiLaki_Akmal = New System.Windows.Forms.RadioButton()
        Me.RadioButtonPerempuan_Akmal = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtAlamat_Akmal = New System.Windows.Forms.TextBox()
        Me.MaskedTxtNoTelepon_Akmal = New System.Windows.Forms.MaskedTextBox()
        Me.PanelDataDokter_Akmal = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ButtonResetCari_Akmal = New System.Windows.Forms.Button()
        Me.ButtonCari_Akmal = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtCari_Akmal = New System.Windows.Forms.TextBox()
        Me.PanelFormDokter_Akmal = New System.Windows.Forms.Panel()
        Me.ButtonDelete_Akmal = New System.Windows.Forms.Button()
        Me.ButtonEdit_Akmal = New System.Windows.Forms.Button()
        Me.ButtonClear_Akmal = New System.Windows.Forms.Button()
        Me.ButtonSave_Akmal = New System.Windows.Forms.Button()
        Me.ButtonHideForm_Akmal = New System.Windows.Forms.Button()
        Me.DataGridView_Akmal = New System.Windows.Forms.DataGridView()
        Me.ButtonShowForm_Akmal = New System.Windows.Forms.Button()
        Me.PanelDataDokter_Akmal.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PanelFormDokter_Akmal.SuspendLayout()
        CType(Me.DataGridView_Akmal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID DOKTER"
        '
        'TxtIDDokter_Akmal
        '
        Me.TxtIDDokter_Akmal.Location = New System.Drawing.Point(162, 38)
        Me.TxtIDDokter_Akmal.Name = "TxtIDDokter_Akmal"
        Me.TxtIDDokter_Akmal.Size = New System.Drawing.Size(200, 20)
        Me.TxtIDDokter_Akmal.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "NAMA DOKTER"
        '
        'TxtNama_Akmal
        '
        Me.TxtNama_Akmal.Location = New System.Drawing.Point(162, 80)
        Me.TxtNama_Akmal.Name = "TxtNama_Akmal"
        Me.TxtNama_Akmal.Size = New System.Drawing.Size(200, 20)
        Me.TxtNama_Akmal.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "TANGGAL LAHIR"
        '
        'DateTimePicker_Akmal
        '
        Me.DateTimePicker_Akmal.Location = New System.Drawing.Point(162, 127)
        Me.DateTimePicker_Akmal.Name = "DateTimePicker_Akmal"
        Me.DateTimePicker_Akmal.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker_Akmal.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "NO TELEPON"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(47, 222)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "JENIS KELAMIN"
        '
        'RadioButtonLakiLaki_Akmal
        '
        Me.RadioButtonLakiLaki_Akmal.AutoSize = True
        Me.RadioButtonLakiLaki_Akmal.Location = New System.Drawing.Point(162, 220)
        Me.RadioButtonLakiLaki_Akmal.Name = "RadioButtonLakiLaki_Akmal"
        Me.RadioButtonLakiLaki_Akmal.Size = New System.Drawing.Size(74, 17)
        Me.RadioButtonLakiLaki_Akmal.TabIndex = 7
        Me.RadioButtonLakiLaki_Akmal.TabStop = True
        Me.RadioButtonLakiLaki_Akmal.Text = "LAKI-LAKI"
        Me.RadioButtonLakiLaki_Akmal.UseVisualStyleBackColor = True
        '
        'RadioButtonPerempuan_Akmal
        '
        Me.RadioButtonPerempuan_Akmal.AutoSize = True
        Me.RadioButtonPerempuan_Akmal.Location = New System.Drawing.Point(258, 222)
        Me.RadioButtonPerempuan_Akmal.Name = "RadioButtonPerempuan_Akmal"
        Me.RadioButtonPerempuan_Akmal.Size = New System.Drawing.Size(93, 17)
        Me.RadioButtonPerempuan_Akmal.TabIndex = 8
        Me.RadioButtonPerempuan_Akmal.TabStop = True
        Me.RadioButtonPerempuan_Akmal.Text = "PEREMPUAN"
        Me.RadioButtonPerempuan_Akmal.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(47, 271)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "ALAMAT"
        '
        'TxtAlamat_Akmal
        '
        Me.TxtAlamat_Akmal.Location = New System.Drawing.Point(162, 268)
        Me.TxtAlamat_Akmal.Name = "TxtAlamat_Akmal"
        Me.TxtAlamat_Akmal.Size = New System.Drawing.Size(200, 20)
        Me.TxtAlamat_Akmal.TabIndex = 9
        '
        'MaskedTxtNoTelepon_Akmal
        '
        Me.MaskedTxtNoTelepon_Akmal.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.MaskedTxtNoTelepon_Akmal.Location = New System.Drawing.Point(162, 177)
        Me.MaskedTxtNoTelepon_Akmal.Mask = "6200000000000"
        Me.MaskedTxtNoTelepon_Akmal.Name = "MaskedTxtNoTelepon_Akmal"
        Me.MaskedTxtNoTelepon_Akmal.RejectInputOnFirstFailure = True
        Me.MaskedTxtNoTelepon_Akmal.Size = New System.Drawing.Size(200, 20)
        Me.MaskedTxtNoTelepon_Akmal.TabIndex = 6
        '
        'PanelDataDokter_Akmal
        '
        Me.PanelDataDokter_Akmal.BackColor = System.Drawing.Color.SlateBlue
        Me.PanelDataDokter_Akmal.Controls.Add(Me.Panel1)
        Me.PanelDataDokter_Akmal.Controls.Add(Me.PanelFormDokter_Akmal)
        Me.PanelDataDokter_Akmal.Controls.Add(Me.DataGridView_Akmal)
        Me.PanelDataDokter_Akmal.Controls.Add(Me.ButtonShowForm_Akmal)
        Me.PanelDataDokter_Akmal.Location = New System.Drawing.Point(53, 51)
        Me.PanelDataDokter_Akmal.Name = "PanelDataDokter_Akmal"
        Me.PanelDataDokter_Akmal.Size = New System.Drawing.Size(932, 611)
        Me.PanelDataDokter_Akmal.TabIndex = 14
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.ButtonResetCari_Akmal)
        Me.Panel1.Controls.Add(Me.ButtonCari_Akmal)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.TxtCari_Akmal)
        Me.Panel1.Location = New System.Drawing.Point(490, 26)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(408, 56)
        Me.Panel1.TabIndex = 17
        '
        'ButtonResetCari_Akmal
        '
        Me.ButtonResetCari_Akmal.BackColor = System.Drawing.Color.Red
        Me.ButtonResetCari_Akmal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonResetCari_Akmal.ForeColor = System.Drawing.Color.White
        Me.ButtonResetCari_Akmal.Location = New System.Drawing.Point(314, 17)
        Me.ButtonResetCari_Akmal.Name = "ButtonResetCari_Akmal"
        Me.ButtonResetCari_Akmal.Size = New System.Drawing.Size(75, 23)
        Me.ButtonResetCari_Akmal.TabIndex = 15
        Me.ButtonResetCari_Akmal.Text = "Reset"
        Me.ButtonResetCari_Akmal.UseVisualStyleBackColor = False
        '
        'ButtonCari_Akmal
        '
        Me.ButtonCari_Akmal.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.ButtonCari_Akmal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCari_Akmal.ForeColor = System.Drawing.Color.White
        Me.ButtonCari_Akmal.Location = New System.Drawing.Point(226, 16)
        Me.ButtonCari_Akmal.Name = "ButtonCari_Akmal"
        Me.ButtonCari_Akmal.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCari_Akmal.TabIndex = 15
        Me.ButtonCari_Akmal.Text = "Cari"
        Me.ButtonCari_Akmal.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Cari"
        '
        'TxtCari_Akmal
        '
        Me.TxtCari_Akmal.Location = New System.Drawing.Point(56, 19)
        Me.TxtCari_Akmal.Name = "TxtCari_Akmal"
        Me.TxtCari_Akmal.Size = New System.Drawing.Size(155, 20)
        Me.TxtCari_Akmal.TabIndex = 18
        '
        'PanelFormDokter_Akmal
        '
        Me.PanelFormDokter_Akmal.BackColor = System.Drawing.Color.White
        Me.PanelFormDokter_Akmal.Controls.Add(Me.ButtonDelete_Akmal)
        Me.PanelFormDokter_Akmal.Controls.Add(Me.ButtonEdit_Akmal)
        Me.PanelFormDokter_Akmal.Controls.Add(Me.ButtonClear_Akmal)
        Me.PanelFormDokter_Akmal.Controls.Add(Me.ButtonSave_Akmal)
        Me.PanelFormDokter_Akmal.Controls.Add(Me.ButtonHideForm_Akmal)
        Me.PanelFormDokter_Akmal.Controls.Add(Me.TxtIDDokter_Akmal)
        Me.PanelFormDokter_Akmal.Controls.Add(Me.Label1)
        Me.PanelFormDokter_Akmal.Controls.Add(Me.MaskedTxtNoTelepon_Akmal)
        Me.PanelFormDokter_Akmal.Controls.Add(Me.Label2)
        Me.PanelFormDokter_Akmal.Controls.Add(Me.TxtAlamat_Akmal)
        Me.PanelFormDokter_Akmal.Controls.Add(Me.TxtNama_Akmal)
        Me.PanelFormDokter_Akmal.Controls.Add(Me.Label6)
        Me.PanelFormDokter_Akmal.Controls.Add(Me.Label3)
        Me.PanelFormDokter_Akmal.Controls.Add(Me.RadioButtonPerempuan_Akmal)
        Me.PanelFormDokter_Akmal.Controls.Add(Me.DateTimePicker_Akmal)
        Me.PanelFormDokter_Akmal.Controls.Add(Me.RadioButtonLakiLaki_Akmal)
        Me.PanelFormDokter_Akmal.Controls.Add(Me.Label4)
        Me.PanelFormDokter_Akmal.Controls.Add(Me.Label5)
        Me.PanelFormDokter_Akmal.Location = New System.Drawing.Point(490, 114)
        Me.PanelFormDokter_Akmal.Name = "PanelFormDokter_Akmal"
        Me.PanelFormDokter_Akmal.Size = New System.Drawing.Size(408, 446)
        Me.PanelFormDokter_Akmal.TabIndex = 0
        Me.PanelFormDokter_Akmal.Visible = False
        '
        'ButtonDelete_Akmal
        '
        Me.ButtonDelete_Akmal.BackColor = System.Drawing.Color.Red
        Me.ButtonDelete_Akmal.FlatAppearance.BorderSize = 0
        Me.ButtonDelete_Akmal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDelete_Akmal.ForeColor = System.Drawing.Color.White
        Me.ButtonDelete_Akmal.Location = New System.Drawing.Point(167, 388)
        Me.ButtonDelete_Akmal.Name = "ButtonDelete_Akmal"
        Me.ButtonDelete_Akmal.Size = New System.Drawing.Size(75, 30)
        Me.ButtonDelete_Akmal.TabIndex = 2
        Me.ButtonDelete_Akmal.Text = "Delete"
        Me.ButtonDelete_Akmal.UseVisualStyleBackColor = False
        '
        'ButtonEdit_Akmal
        '
        Me.ButtonEdit_Akmal.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.ButtonEdit_Akmal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEdit_Akmal.ForeColor = System.Drawing.Color.White
        Me.ButtonEdit_Akmal.Location = New System.Drawing.Point(53, 388)
        Me.ButtonEdit_Akmal.Name = "ButtonEdit_Akmal"
        Me.ButtonEdit_Akmal.Size = New System.Drawing.Size(75, 30)
        Me.ButtonEdit_Akmal.TabIndex = 15
        Me.ButtonEdit_Akmal.Text = "Edit"
        Me.ButtonEdit_Akmal.UseVisualStyleBackColor = False
        '
        'ButtonClear_Akmal
        '
        Me.ButtonClear_Akmal.BackColor = System.Drawing.Color.DarkOrange
        Me.ButtonClear_Akmal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClear_Akmal.ForeColor = System.Drawing.Color.White
        Me.ButtonClear_Akmal.Location = New System.Drawing.Point(167, 326)
        Me.ButtonClear_Akmal.Name = "ButtonClear_Akmal"
        Me.ButtonClear_Akmal.Size = New System.Drawing.Size(75, 30)
        Me.ButtonClear_Akmal.TabIndex = 15
        Me.ButtonClear_Akmal.Text = "Clear"
        Me.ButtonClear_Akmal.UseVisualStyleBackColor = False
        '
        'ButtonSave_Akmal
        '
        Me.ButtonSave_Akmal.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.ButtonSave_Akmal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSave_Akmal.ForeColor = System.Drawing.Color.White
        Me.ButtonSave_Akmal.Location = New System.Drawing.Point(281, 326)
        Me.ButtonSave_Akmal.Name = "ButtonSave_Akmal"
        Me.ButtonSave_Akmal.Size = New System.Drawing.Size(75, 30)
        Me.ButtonSave_Akmal.TabIndex = 16
        Me.ButtonSave_Akmal.Text = "Simpan"
        Me.ButtonSave_Akmal.UseVisualStyleBackColor = False
        '
        'ButtonHideForm_Akmal
        '
        Me.ButtonHideForm_Akmal.BackColor = System.Drawing.Color.Gold
        Me.ButtonHideForm_Akmal.FlatAppearance.BorderSize = 0
        Me.ButtonHideForm_Akmal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonHideForm_Akmal.ForeColor = System.Drawing.Color.Black
        Me.ButtonHideForm_Akmal.Location = New System.Drawing.Point(53, 329)
        Me.ButtonHideForm_Akmal.Name = "ButtonHideForm_Akmal"
        Me.ButtonHideForm_Akmal.Size = New System.Drawing.Size(75, 30)
        Me.ButtonHideForm_Akmal.TabIndex = 15
        Me.ButtonHideForm_Akmal.Text = "Hide"
        Me.ButtonHideForm_Akmal.UseVisualStyleBackColor = False
        '
        'DataGridView_Akmal
        '
        Me.DataGridView_Akmal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView_Akmal.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView_Akmal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Akmal.Location = New System.Drawing.Point(35, 114)
        Me.DataGridView_Akmal.Name = "DataGridView_Akmal"
        Me.DataGridView_Akmal.Size = New System.Drawing.Size(418, 446)
        Me.DataGridView_Akmal.StandardTab = True
        Me.DataGridView_Akmal.TabIndex = 1
        '
        'ButtonShowForm_Akmal
        '
        Me.ButtonShowForm_Akmal.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.ButtonShowForm_Akmal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonShowForm_Akmal.ForeColor = System.Drawing.Color.White
        Me.ButtonShowForm_Akmal.Location = New System.Drawing.Point(35, 39)
        Me.ButtonShowForm_Akmal.Name = "ButtonShowForm_Akmal"
        Me.ButtonShowForm_Akmal.Size = New System.Drawing.Size(75, 30)
        Me.ButtonShowForm_Akmal.TabIndex = 0
        Me.ButtonShowForm_Akmal.Text = "Show Form"
        Me.ButtonShowForm_Akmal.UseVisualStyleBackColor = False
        '
        'FormMasterDokter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1029, 700)
        Me.Controls.Add(Me.PanelDataDokter_Akmal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormMasterDokter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Data Master Dokter"
        Me.PanelDataDokter_Akmal.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PanelFormDokter_Akmal.ResumeLayout(False)
        Me.PanelFormDokter_Akmal.PerformLayout()
        CType(Me.DataGridView_Akmal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtIDDokter_Akmal As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtNama_Akmal As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker_Akmal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents RadioButtonLakiLaki_Akmal As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonPerempuan_Akmal As System.Windows.Forms.RadioButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtAlamat_Akmal As System.Windows.Forms.TextBox
    Friend WithEvents MaskedTxtNoTelepon_Akmal As System.Windows.Forms.MaskedTextBox
    Friend WithEvents PanelDataDokter_Akmal As System.Windows.Forms.Panel
    Friend WithEvents PanelFormDokter_Akmal As System.Windows.Forms.Panel
    Friend WithEvents ButtonShowForm_Akmal As System.Windows.Forms.Button
    Friend WithEvents DataGridView_Akmal As System.Windows.Forms.DataGridView
    Friend WithEvents ButtonHideForm_Akmal As System.Windows.Forms.Button
    Friend WithEvents ButtonSave_Akmal As System.Windows.Forms.Button
    Friend WithEvents ButtonClear_Akmal As System.Windows.Forms.Button
    Friend WithEvents ButtonEdit_Akmal As System.Windows.Forms.Button
    Friend WithEvents ButtonDelete_Akmal As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtCari_Akmal As System.Windows.Forms.TextBox
    Friend WithEvents ButtonCari_Akmal As System.Windows.Forms.Button
    Friend WithEvents ButtonResetCari_Akmal As System.Windows.Forms.Button
End Class
