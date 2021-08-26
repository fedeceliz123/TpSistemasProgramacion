
namespace UI.Empleados
{
    partial class ListarEmpleados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvEmp = new System.Windows.Forms.DataGridView();
            this.dgvDir = new System.Windows.Forms.DataGridView();
            this.dgvTel = new System.Windows.Forms.DataGridView();
            this.dgvMail = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new ePOSOne.btnProduct.Button_WOC();
            this.tbBuscar = new UI.componentes.RJTextBox();
            this.ellipseControl1 = new UI.componentes.EllipseControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMail)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Buscar Empleado: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "Empleado: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 39;
            this.label3.Text = "Direcciones: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 461);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 40;
            this.label4.Text = "Telefonos: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(446, 461);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 41;
            this.label5.Text = "Emais: ";
            // 
            // dgvEmp
            // 
            this.dgvEmp.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmp.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmp.ColumnHeadersHeight = 30;
            this.dgvEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEmp.EnableHeadersVisualStyles = false;
            this.dgvEmp.GridColor = System.Drawing.Color.White;
            this.dgvEmp.Location = new System.Drawing.Point(54, 147);
            this.dgvEmp.Name = "dgvEmp";
            this.dgvEmp.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvEmp.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmp.Size = new System.Drawing.Size(767, 150);
            this.dgvEmp.TabIndex = 42;
            // 
            // dgvDir
            // 
            this.dgvDir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDir.Location = new System.Drawing.Point(54, 335);
            this.dgvDir.Name = "dgvDir";
            this.dgvDir.Size = new System.Drawing.Size(767, 111);
            this.dgvDir.TabIndex = 43;
            // 
            // dgvTel
            // 
            this.dgvTel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTel.Location = new System.Drawing.Point(54, 480);
            this.dgvTel.Name = "dgvTel";
            this.dgvTel.Size = new System.Drawing.Size(377, 111);
            this.dgvTel.TabIndex = 44;
            // 
            // dgvMail
            // 
            this.dgvMail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMail.Location = new System.Drawing.Point(444, 480);
            this.dgvMail.Name = "dgvMail";
            this.dgvMail.Size = new System.Drawing.Size(377, 111);
            this.dgvMail.TabIndex = 45;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.BorderColor = System.Drawing.Color.Silver;
            this.btnBuscar.ButtonColor = System.Drawing.Color.DodgerBlue;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(326, 57);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.OnHoverBorderColor = System.Drawing.SystemColors.GrayText;
            this.btnBuscar.OnHoverButtonColor = System.Drawing.Color.DarkBlue;
            this.btnBuscar.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnBuscar.Size = new System.Drawing.Size(105, 40);
            this.btnBuscar.TabIndex = 33;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextColor = System.Drawing.Color.White;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tbBuscar
            // 
            this.tbBuscar.BackColor = System.Drawing.Color.White;
            this.tbBuscar.BorderColor = System.Drawing.Color.LightGray;
            this.tbBuscar.BorderFocusColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbBuscar.BorderRadius = 5;
            this.tbBuscar.BorderSize = 2;
            this.tbBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBuscar.ForeColor = System.Drawing.Color.Black;
            this.tbBuscar.Location = new System.Drawing.Point(68, 59);
            this.tbBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.tbBuscar.Multiline = false;
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbBuscar.PasswordChar = false;
            this.tbBuscar.PlaceholderColor = System.Drawing.Color.DimGray;
            this.tbBuscar.PlaceholderText = "Buscar";
            this.tbBuscar.Size = new System.Drawing.Size(250, 35);
            this.tbBuscar.TabIndex = 3;
            this.tbBuscar.Texts = "";
            this.tbBuscar.UnderlinedStyle = false;
            // 
            // ellipseControl1
            // 
            this.ellipseControl1.BackColor = System.Drawing.Color.White;
            this.ellipseControl1.CornerRadius = 20;
            this.ellipseControl1.Location = new System.Drawing.Point(27, 12);
            this.ellipseControl1.Name = "ellipseControl1";
            this.ellipseControl1.Size = new System.Drawing.Size(825, 615);
            this.ellipseControl1.TabIndex = 0;
            this.ellipseControl1.Text = "ellipseControl1";
            // 
            // ListarEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 651);
            this.Controls.Add(this.dgvMail);
            this.Controls.Add(this.dgvTel);
            this.Controls.Add(this.dgvDir);
            this.Controls.Add(this.dgvEmp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbBuscar);
            this.Controls.Add(this.ellipseControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListarEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListarEmpleados";
            this.Load += new System.EventHandler(this.ListarEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private componentes.EllipseControl ellipseControl1;
        private componentes.RJTextBox tbBuscar;
        private System.Windows.Forms.Label label1;
        private ePOSOne.btnProduct.Button_WOC btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvEmp;
        private System.Windows.Forms.DataGridView dgvDir;
        private System.Windows.Forms.DataGridView dgvTel;
        private System.Windows.Forms.DataGridView dgvMail;
    }
}