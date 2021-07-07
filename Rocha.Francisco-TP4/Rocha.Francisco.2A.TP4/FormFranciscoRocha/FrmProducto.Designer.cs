
namespace FormFranciscoRocha
{
    partial class FrmProducto
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
            this.comboBoxMarca = new System.Windows.Forms.ComboBox();
            this.comboBoxRam = new System.Windows.Forms.ComboBox();
            this.comboBoxSistemaOP = new System.Windows.Forms.ComboBox();
            this.comboBoxGPU = new System.Windows.Forms.ComboBox();
            this.comboBoxAlmacenamiento = new System.Windows.Forms.ComboBox();
            this.CodigoUPC = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBoxMarca
            // 
            this.comboBoxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMarca.FormattingEnabled = true;
            this.comboBoxMarca.Location = new System.Drawing.Point(34, 94);
            this.comboBoxMarca.Name = "comboBoxMarca";
            this.comboBoxMarca.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMarca.TabIndex = 0;
            this.comboBoxMarca.SelectedIndexChanged += new System.EventHandler(this.ComboBoxMarca_SelectedIndexChanged);
            // 
            // comboBoxRam
            // 
            this.comboBoxRam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRam.FormattingEnabled = true;
            this.comboBoxRam.Location = new System.Drawing.Point(369, 94);
            this.comboBoxRam.Name = "comboBoxRam";
            this.comboBoxRam.Size = new System.Drawing.Size(207, 21);
            this.comboBoxRam.TabIndex = 1;
            // 
            // comboBoxSistemaOP
            // 
            this.comboBoxSistemaOP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSistemaOP.FormattingEnabled = true;
            this.comboBoxSistemaOP.Location = new System.Drawing.Point(34, 199);
            this.comboBoxSistemaOP.Name = "comboBoxSistemaOP";
            this.comboBoxSistemaOP.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSistemaOP.TabIndex = 2;
            // 
            // comboBoxGPU
            // 
            this.comboBoxGPU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGPU.FormattingEnabled = true;
            this.comboBoxGPU.Location = new System.Drawing.Point(171, 94);
            this.comboBoxGPU.Name = "comboBoxGPU";
            this.comboBoxGPU.Size = new System.Drawing.Size(181, 21);
            this.comboBoxGPU.TabIndex = 3;
            // 
            // comboBoxAlmacenamiento
            // 
            this.comboBoxAlmacenamiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAlmacenamiento.FormattingEnabled = true;
            this.comboBoxAlmacenamiento.Location = new System.Drawing.Point(592, 94);
            this.comboBoxAlmacenamiento.Name = "comboBoxAlmacenamiento";
            this.comboBoxAlmacenamiento.Size = new System.Drawing.Size(177, 21);
            this.comboBoxAlmacenamiento.TabIndex = 4;
            // 
            // CodigoUPC
            // 
            this.CodigoUPC.Location = new System.Drawing.Point(171, 199);
            this.CodigoUPC.Name = "CodigoUPC";
            this.CodigoUPC.ReadOnly = true;
            this.CodigoUPC.Size = new System.Drawing.Size(181, 20);
            this.CodigoUPC.TabIndex = 5;
            this.CodigoUPC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 450);
            this.Controls.Add(this.CodigoUPC);
            this.Controls.Add(this.comboBoxAlmacenamiento);
            this.Controls.Add(this.comboBoxGPU);
            this.Controls.Add(this.comboBoxSistemaOP);
            this.Controls.Add(this.comboBoxRam);
            this.Controls.Add(this.comboBoxMarca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProducto";
            this.Text = "FrmProducto";
            this.Load += new System.EventHandler(this.FrmProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.ComboBox comboBoxMarca;
        protected System.Windows.Forms.ComboBox comboBoxRam;
        protected System.Windows.Forms.ComboBox comboBoxSistemaOP;
        protected System.Windows.Forms.ComboBox comboBoxGPU;
        protected System.Windows.Forms.ComboBox comboBoxAlmacenamiento;
        protected System.Windows.Forms.TextBox CodigoUPC;
    }
}