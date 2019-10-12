namespace RegistroAsistencia.UI.Consultas
{
    partial class cAsistencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cAsistencia));
            this.ConsultarButton = new System.Windows.Forms.Button();
            this.CriterioTextBox = new System.Windows.Forms.TextBox();
            this.FiltrarComboBox = new System.Windows.Forms.ComboBox();
            this.HastaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DesdeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ConsultaDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ConsultarButton
            // 
            this.ConsultarButton.Image = ((System.Drawing.Image)(resources.GetObject("ConsultarButton.Image")));
            this.ConsultarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ConsultarButton.Location = new System.Drawing.Point(517, 18);
            this.ConsultarButton.Name = "ConsultarButton";
            this.ConsultarButton.Size = new System.Drawing.Size(84, 28);
            this.ConsultarButton.TabIndex = 53;
            this.ConsultarButton.Text = "Consultar";
            this.ConsultarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ConsultarButton.UseVisualStyleBackColor = true;
            this.ConsultarButton.Click += new System.EventHandler(this.ConsultarButton_Click);
            // 
            // CriterioTextBox
            // 
            this.CriterioTextBox.Location = new System.Drawing.Point(296, 23);
            this.CriterioTextBox.Name = "CriterioTextBox";
            this.CriterioTextBox.Size = new System.Drawing.Size(205, 20);
            this.CriterioTextBox.TabIndex = 52;
            // 
            // FiltrarComboBox
            // 
            this.FiltrarComboBox.FormattingEnabled = true;
            this.FiltrarComboBox.Items.AddRange(new object[] {
            "Todo",
            "ID",
            "Cantidad"});
            this.FiltrarComboBox.Location = new System.Drawing.Point(199, 23);
            this.FiltrarComboBox.Name = "FiltrarComboBox";
            this.FiltrarComboBox.Size = new System.Drawing.Size(88, 21);
            this.FiltrarComboBox.TabIndex = 51;
            // 
            // HastaDateTimePicker
            // 
            this.HastaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.HastaDateTimePicker.Location = new System.Drawing.Point(111, 23);
            this.HastaDateTimePicker.Name = "HastaDateTimePicker";
            this.HastaDateTimePicker.Size = new System.Drawing.Size(82, 20);
            this.HastaDateTimePicker.TabIndex = 50;
            // 
            // DesdeDateTimePicker
            // 
            this.DesdeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DesdeDateTimePicker.Location = new System.Drawing.Point(23, 23);
            this.DesdeDateTimePicker.Name = "DesdeDateTimePicker";
            this.DesdeDateTimePicker.Size = new System.Drawing.Size(82, 20);
            this.DesdeDateTimePicker.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(293, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Criterio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Filtro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Hasta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Desde";
            // 
            // ConsultaDataGridView
            // 
            this.ConsultaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultaDataGridView.Location = new System.Drawing.Point(12, 47);
            this.ConsultaDataGridView.Name = "ConsultaDataGridView";
            this.ConsultaDataGridView.Size = new System.Drawing.Size(610, 363);
            this.ConsultaDataGridView.TabIndex = 44;
            // 
            // cAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 416);
            this.Controls.Add(this.ConsultarButton);
            this.Controls.Add(this.CriterioTextBox);
            this.Controls.Add(this.FiltrarComboBox);
            this.Controls.Add(this.HastaDateTimePicker);
            this.Controls.Add(this.DesdeDateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConsultaDataGridView);
            this.Name = "cAsistencia";
            this.Text = "cAsistencia";
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConsultarButton;
        private System.Windows.Forms.TextBox CriterioTextBox;
        private System.Windows.Forms.ComboBox FiltrarComboBox;
        private System.Windows.Forms.DateTimePicker HastaDateTimePicker;
        private System.Windows.Forms.DateTimePicker DesdeDateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ConsultaDataGridView;
    }
}