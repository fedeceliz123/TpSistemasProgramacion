
namespace UI
{
    partial class Eliminar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Eliminar));
            this.panelBarrasub = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAceptar = new ePOSOne.btnProduct.Button_WOC();
            this.btnCancelar = new ePOSOne.btnProduct.Button_WOC();
            this.ComboSexo = new RJComboBox();
            this.rjTextBox7 = new UI.componentes.RJTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBarrasub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBarrasub
            // 
            this.panelBarrasub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.panelBarrasub.Controls.Add(this.pictureBox1);
            this.panelBarrasub.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarrasub.Location = new System.Drawing.Point(0, 0);
            this.panelBarrasub.Name = "panelBarrasub";
            this.panelBarrasub.Size = new System.Drawing.Size(650, 44);
            this.panelBarrasub.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(591, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.BorderColor = System.Drawing.Color.Transparent;
            this.btnAceptar.ButtonColor = System.Drawing.Color.DodgerBlue;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(190, 222);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.OnHoverBorderColor = System.Drawing.SystemColors.GrayText;
            this.btnAceptar.OnHoverButtonColor = System.Drawing.Color.DarkBlue;
            this.btnAceptar.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnAceptar.Size = new System.Drawing.Size(105, 40);
            this.btnAceptar.TabIndex = 34;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextColor = System.Drawing.Color.White;
            this.btnAceptar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BorderColor = System.Drawing.Color.Transparent;
            this.btnCancelar.ButtonColor = System.Drawing.Color.DimGray;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Location = new System.Drawing.Point(330, 222);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.OnHoverBorderColor = System.Drawing.SystemColors.GrayText;
            this.btnCancelar.OnHoverButtonColor = System.Drawing.Color.DimGray;
            this.btnCancelar.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnCancelar.Size = new System.Drawing.Size(110, 40);
            this.btnCancelar.TabIndex = 70;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextColor = System.Drawing.Color.White;
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // ComboSexo
            // 
            this.ComboSexo.BackColor = System.Drawing.Color.DarkGray;
            this.ComboSexo.BorderColor = System.Drawing.Color.DarkGray;
            this.ComboSexo.BorderSize = 2;
            this.ComboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.ComboSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboSexo.ForeColor = System.Drawing.Color.DimGray;
            this.ComboSexo.IconColor = System.Drawing.Color.Transparent;
            this.ComboSexo.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.ComboSexo.ListTextColor = System.Drawing.Color.DimGray;
            this.ComboSexo.Location = new System.Drawing.Point(199, 154);
            this.ComboSexo.MinimumSize = new System.Drawing.Size(200, 30);
            this.ComboSexo.Name = "ComboSexo";
            this.ComboSexo.Padding = new System.Windows.Forms.Padding(2);
            this.ComboSexo.Size = new System.Drawing.Size(237, 30);
            this.ComboSexo.TabIndex = 73;
            this.ComboSexo.Texts = "";
            // 
            // rjTextBox7
            // 
            this.rjTextBox7.BackColor = System.Drawing.Color.DarkGray;
            this.rjTextBox7.BorderColor = System.Drawing.Color.LightGray;
            this.rjTextBox7.BorderFocusColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rjTextBox7.BorderRadius = 5;
            this.rjTextBox7.BorderSize = 2;
            this.rjTextBox7.Enabled = false;
            this.rjTextBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox7.ForeColor = System.Drawing.Color.Black;
            this.rjTextBox7.Location = new System.Drawing.Point(190, 150);
            this.rjTextBox7.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox7.Multiline = false;
            this.rjTextBox7.Name = "rjTextBox7";
            this.rjTextBox7.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox7.PasswordChar = false;
            this.rjTextBox7.PlaceholderColor = System.Drawing.Color.DimGray;
            this.rjTextBox7.PlaceholderText = "Sexo";
            this.rjTextBox7.Size = new System.Drawing.Size(250, 39);
            this.rjTextBox7.TabIndex = 72;
            this.rjTextBox7.Texts = "";
            this.rjTextBox7.UnderlinedStyle = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(189, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 71;
            this.label4.Text = "Motivo: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 20);
            this.label1.TabIndex = 74;
            this.label1.Text = "¿Esta seguro que desea eliminar?";
            // 
            // Eliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(650, 290);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboSexo);
            this.Controls.Add(this.rjTextBox7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.panelBarrasub);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Eliminar";
            this.Text = "Eliminar";
            this.panelBarrasub.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBarrasub;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ePOSOne.btnProduct.Button_WOC btnAceptar;
        private ePOSOne.btnProduct.Button_WOC btnCancelar;
        private RJComboBox ComboSexo;
        private componentes.RJTextBox rjTextBox7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}