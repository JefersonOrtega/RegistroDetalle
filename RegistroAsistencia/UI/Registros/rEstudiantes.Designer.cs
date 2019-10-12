namespace RegistroAsistencia.UI.Registros
{
    partial class rEstudiantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rEstudiantes));
            this.label1 = new System.Windows.Forms.Label();
            this.EstudianteIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.NombresTextBox = new System.Windows.Forms.TextBox();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.BuscarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EstudianteIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // EstudianteIdNumericUpDown
            // 
            this.EstudianteIdNumericUpDown.Location = new System.Drawing.Point(37, 11);
            this.EstudianteIdNumericUpDown.Name = "EstudianteIdNumericUpDown";
            this.EstudianteIdNumericUpDown.Size = new System.Drawing.Size(59, 20);
            this.EstudianteIdNumericUpDown.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombres";
            // 
            // NombresTextBox
            // 
            this.NombresTextBox.Location = new System.Drawing.Point(67, 49);
            this.NombresTextBox.Name = "NombresTextBox";
            this.NombresTextBox.Size = new System.Drawing.Size(207, 20);
            this.NombresTextBox.TabIndex = 5;
            // 
            // GuardarButton
            // 
            this.GuardarButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.GuardarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GuardarButton.Image = ((System.Drawing.Image)(resources.GetObject("GuardarButton.Image")));
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GuardarButton.Location = new System.Drawing.Point(107, 98);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(80, 59);
            this.GuardarButton.TabIndex = 33;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GuardarButton.UseVisualStyleBackColor = false;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.EliminarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EliminarButton.Image = ((System.Drawing.Image)(resources.GetObject("EliminarButton.Image")));
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EliminarButton.Location = new System.Drawing.Point(195, 98);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(80, 59);
            this.EliminarButton.TabIndex = 32;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EliminarButton.UseVisualStyleBackColor = false;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.NuevoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NuevoButton.Image = ((System.Drawing.Image)(resources.GetObject("NuevoButton.Image")));
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NuevoButton.Location = new System.Drawing.Point(16, 98);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(80, 59);
            this.NuevoButton.TabIndex = 31;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NuevoButton.UseVisualStyleBackColor = false;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // BuscarButton
            // 
            this.BuscarButton.FlatAppearance.BorderSize = 0;
            this.BuscarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuscarButton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarButton.Image")));
            this.BuscarButton.Location = new System.Drawing.Point(102, 5);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(28, 28);
            this.BuscarButton.TabIndex = 34;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // rEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 175);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.NombresTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EstudianteIdNumericUpDown);
            this.Controls.Add(this.label1);
            this.Name = "rEstudiantes";
            this.Text = "rEstudiantes";
            ((System.ComponentModel.ISupportInitialize)(this.EstudianteIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown EstudianteIdNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NombresTextBox;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private System.Windows.Forms.Button BuscarButton;
    }
}