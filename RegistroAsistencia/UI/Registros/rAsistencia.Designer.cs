namespace RegistroAsistencia.UI.Registros
{
    partial class rAsistencia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rAsistencia));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DetalledataGridView = new System.Windows.Forms.DataGridView();
            this.EstudianteIdDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombresDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PresenteDGV = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AgregarPresente = new System.Windows.Forms.Button();
            this.PresenteCheckBox = new System.Windows.Forms.CheckBox();
            this.AgregarEstudianteButton = new System.Windows.Forms.Button();
            this.EstudianteComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AsistenciaIdnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AsignaturaComboBox = new System.Windows.Forms.ComboBox();
            this.CantidadtextBox = new System.Windows.Forms.TextBox();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.MyerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.AgregarAsignaturaButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AsistenciaIdnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(249, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Asignatura";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DetalledataGridView);
            this.groupBox1.Controls.Add(this.AgregarPresente);
            this.groupBox1.Controls.Add(this.PresenteCheckBox);
            this.groupBox1.Controls.Add(this.AgregarEstudianteButton);
            this.groupBox1.Controls.Add(this.EstudianteComboBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 245);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // DetalledataGridView
            // 
            this.DetalledataGridView.AllowUserToAddRows = false;
            this.DetalledataGridView.AllowUserToDeleteRows = false;
            this.DetalledataGridView.AllowUserToOrderColumns = true;
            this.DetalledataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalledataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EstudianteIdDGV,
            this.NombresDGV,
            this.PresenteDGV});
            this.DetalledataGridView.Location = new System.Drawing.Point(7, 74);
            this.DetalledataGridView.Name = "DetalledataGridView";
            this.DetalledataGridView.ReadOnly = true;
            this.DetalledataGridView.Size = new System.Drawing.Size(393, 150);
            this.DetalledataGridView.TabIndex = 12;
            // 
            // EstudianteIdDGV
            // 
            this.EstudianteIdDGV.HeaderText = "EstudianteId";
            this.EstudianteIdDGV.Name = "EstudianteIdDGV";
            this.EstudianteIdDGV.ReadOnly = true;
            this.EstudianteIdDGV.Width = 85;
            // 
            // NombresDGV
            // 
            this.NombresDGV.FillWeight = 200F;
            this.NombresDGV.HeaderText = "Nombres";
            this.NombresDGV.Name = "NombresDGV";
            this.NombresDGV.ReadOnly = true;
            this.NombresDGV.Width = 160;
            // 
            // PresenteDGV
            // 
            this.PresenteDGV.HeaderText = "Presente";
            this.PresenteDGV.Name = "PresenteDGV";
            this.PresenteDGV.ReadOnly = true;
            this.PresenteDGV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PresenteDGV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.PresenteDGV.Width = 85;
            // 
            // AgregarPresente
            // 
            this.AgregarPresente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AgregarPresente.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarPresente.Location = new System.Drawing.Point(354, 28);
            this.AgregarPresente.Name = "AgregarPresente";
            this.AgregarPresente.Size = new System.Drawing.Size(31, 31);
            this.AgregarPresente.TabIndex = 11;
            this.AgregarPresente.Text = "+";
            this.AgregarPresente.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AgregarPresente.UseVisualStyleBackColor = true;
            this.AgregarPresente.Click += new System.EventHandler(this.AgregarPresente_Click);
            // 
            // PresenteCheckBox
            // 
            this.PresenteCheckBox.AutoSize = true;
            this.PresenteCheckBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PresenteCheckBox.Location = new System.Drawing.Point(240, 33);
            this.PresenteCheckBox.Name = "PresenteCheckBox";
            this.PresenteCheckBox.Size = new System.Drawing.Size(108, 24);
            this.PresenteCheckBox.TabIndex = 10;
            this.PresenteCheckBox.Text = "Presente";
            this.PresenteCheckBox.UseVisualStyleBackColor = true;
            // 
            // AgregarEstudianteButton
            // 
            this.AgregarEstudianteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AgregarEstudianteButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarEstudianteButton.Location = new System.Drawing.Point(155, 28);
            this.AgregarEstudianteButton.Name = "AgregarEstudianteButton";
            this.AgregarEstudianteButton.Size = new System.Drawing.Size(34, 31);
            this.AgregarEstudianteButton.TabIndex = 9;
            this.AgregarEstudianteButton.Text = "+";
            this.AgregarEstudianteButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AgregarEstudianteButton.UseVisualStyleBackColor = true;
            this.AgregarEstudianteButton.Click += new System.EventHandler(this.AgregarEstudianteButton_Click);
            // 
            // EstudianteComboBox
            // 
            this.EstudianteComboBox.FormattingEnabled = true;
            this.EstudianteComboBox.Location = new System.Drawing.Point(9, 35);
            this.EstudianteComboBox.Name = "EstudianteComboBox";
            this.EstudianteComboBox.Size = new System.Drawing.Size(140, 21);
            this.EstudianteComboBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Estudiante";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Cantidad";
            // 
            // AsistenciaIdnumericUpDown
            // 
            this.AsistenciaIdnumericUpDown.Location = new System.Drawing.Point(42, 20);
            this.AsistenciaIdnumericUpDown.Name = "AsistenciaIdnumericUpDown";
            this.AsistenciaIdnumericUpDown.Size = new System.Drawing.Size(55, 20);
            this.AsistenciaIdnumericUpDown.TabIndex = 4;
            // 
            // BuscarButton
            // 
            this.BuscarButton.FlatAppearance.BorderSize = 0;
            this.BuscarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuscarButton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarButton.Image")));
            this.BuscarButton.Location = new System.Drawing.Point(103, 14);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(28, 28);
            this.BuscarButton.TabIndex = 5;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechadateTimePicker.Location = new System.Drawing.Point(317, 20);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(110, 20);
            this.FechadateTimePicker.TabIndex = 6;
            // 
            // AsignaturaComboBox
            // 
            this.AsignaturaComboBox.FormattingEnabled = true;
            this.AsignaturaComboBox.Location = new System.Drawing.Point(103, 52);
            this.AsignaturaComboBox.Name = "AsignaturaComboBox";
            this.AsignaturaComboBox.Size = new System.Drawing.Size(272, 21);
            this.AsignaturaComboBox.TabIndex = 7;
            // 
            // CantidadtextBox
            // 
            this.CantidadtextBox.Location = new System.Drawing.Point(93, 336);
            this.CantidadtextBox.Name = "CantidadtextBox";
            this.CantidadtextBox.Size = new System.Drawing.Size(100, 20);
            this.CantidadtextBox.TabIndex = 8;
            // 
            // NuevoButton
            // 
            this.NuevoButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoButton.Location = new System.Drawing.Point(15, 364);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(74, 41);
            this.NuevoButton.TabIndex = 9;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.Location = new System.Drawing.Point(184, 364);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(74, 41);
            this.GuardarButton.TabIndex = 10;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarButton.Location = new System.Drawing.Point(353, 364);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(74, 41);
            this.EliminarButton.TabIndex = 11;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // MyerrorProvider
            // 
            this.MyerrorProvider.ContainerControl = this;
            // 
            // AgregarAsignaturaButton
            // 
            this.AgregarAsignaturaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AgregarAsignaturaButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarAsignaturaButton.Location = new System.Drawing.Point(396, 45);
            this.AgregarAsignaturaButton.Name = "AgregarAsignaturaButton";
            this.AgregarAsignaturaButton.Size = new System.Drawing.Size(31, 31);
            this.AgregarAsignaturaButton.TabIndex = 14;
            this.AgregarAsignaturaButton.Text = "+";
            this.AgregarAsignaturaButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AgregarAsignaturaButton.UseVisualStyleBackColor = true;
            this.AgregarAsignaturaButton.Click += new System.EventHandler(this.AgregarAsignaturaButton_Click);
            // 
            // rAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(441, 430);
            this.Controls.Add(this.AgregarAsignaturaButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.CantidadtextBox);
            this.Controls.Add(this.AsignaturaComboBox);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.AsistenciaIdnumericUpDown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "rAsistencia";
            this.Text = "rAsistencia";
            this.Load += new System.EventHandler(this.RAsistencia_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AsistenciaIdnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown AsistenciaIdnumericUpDown;
        private System.Windows.Forms.DataGridView DetalledataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstudianteIdDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombresDGV;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PresenteDGV;
        private System.Windows.Forms.Button AgregarPresente;
        private System.Windows.Forms.CheckBox PresenteCheckBox;
        private System.Windows.Forms.Button AgregarEstudianteButton;
        private System.Windows.Forms.ComboBox EstudianteComboBox;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.ComboBox AsignaturaComboBox;
        private System.Windows.Forms.TextBox CantidadtextBox;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.ErrorProvider MyerrorProvider;
        private System.Windows.Forms.Button AgregarAsignaturaButton;
    }
}