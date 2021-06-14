
namespace FormFranciscoRocha
{
    partial class FrmFabricaCelular
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
            this.comboBoxMaterial = new System.Windows.Forms.ComboBox();
            this.comboBoxBateria = new System.Windows.Forms.ComboBox();
            this.comboBoxPulgadas = new System.Windows.Forms.ComboBox();
            this.comboBoxRes = new System.Windows.Forms.ComboBox();
            this.comboBoxJack = new System.Windows.Forms.ComboBox();
            this.comboBoxHuella = new System.Windows.Forms.ComboBox();
            this.comboBoxCamara = new System.Windows.Forms.ComboBox();
            this.ButtonFabricar = new System.Windows.Forms.Button();
            this.ButtonCerrar = new System.Windows.Forms.Button();
            this.ButtonUPC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxMarca
            // 
            this.comboBoxMarca.Location = new System.Drawing.Point(35, 94);
            // 
            // comboBoxRam
            // 
            this.comboBoxRam.Location = new System.Drawing.Point(370, 94);
            // 
            // comboBoxSistemaOP
            // 
            this.comboBoxSistemaOP.Location = new System.Drawing.Point(35, 199);
            // 
            // comboBoxGPU
            // 
            this.comboBoxGPU.Location = new System.Drawing.Point(172, 94);
            // 
            // comboBoxAlmacenamiento
            // 
            this.comboBoxAlmacenamiento.Location = new System.Drawing.Point(593, 94);
            // 
            // CodigoUPC
            // 
            this.CodigoUPC.Location = new System.Drawing.Point(172, 199);
            // 
            // comboBoxMaterial
            // 
            this.comboBoxMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMaterial.FormattingEnabled = true;
            this.comboBoxMaterial.Location = new System.Drawing.Point(174, 303);
            this.comboBoxMaterial.Name = "comboBoxMaterial";
            this.comboBoxMaterial.Size = new System.Drawing.Size(181, 21);
            this.comboBoxMaterial.TabIndex = 8;
            this.comboBoxMaterial.SelectedIndexChanged += new System.EventHandler(this.comboBoxMaterial_SelectedIndexChanged);
            // 
            // comboBoxBateria
            // 
            this.comboBoxBateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBateria.FormattingEnabled = true;
            this.comboBoxBateria.Location = new System.Drawing.Point(37, 303);
            this.comboBoxBateria.Name = "comboBoxBateria";
            this.comboBoxBateria.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBateria.TabIndex = 9;
            // 
            // comboBoxPulgadas
            // 
            this.comboBoxPulgadas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPulgadas.FormattingEnabled = true;
            this.comboBoxPulgadas.Location = new System.Drawing.Point(593, 199);
            this.comboBoxPulgadas.Name = "comboBoxPulgadas";
            this.comboBoxPulgadas.Size = new System.Drawing.Size(177, 21);
            this.comboBoxPulgadas.TabIndex = 10;
            // 
            // comboBoxRes
            // 
            this.comboBoxRes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRes.FormattingEnabled = true;
            this.comboBoxRes.Location = new System.Drawing.Point(370, 199);
            this.comboBoxRes.Name = "comboBoxRes";
            this.comboBoxRes.Size = new System.Drawing.Size(207, 21);
            this.comboBoxRes.TabIndex = 11;
            // 
            // comboBoxJack
            // 
            this.comboBoxJack.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxJack.FormattingEnabled = true;
            this.comboBoxJack.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.comboBoxJack.Location = new System.Drawing.Point(525, 303);
            this.comboBoxJack.Name = "comboBoxJack";
            this.comboBoxJack.Size = new System.Drawing.Size(101, 21);
            this.comboBoxJack.TabIndex = 12;
            // 
            // comboBoxHuella
            // 
            this.comboBoxHuella.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHuella.FormattingEnabled = true;
            this.comboBoxHuella.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.comboBoxHuella.Location = new System.Drawing.Point(670, 303);
            this.comboBoxHuella.Name = "comboBoxHuella";
            this.comboBoxHuella.Size = new System.Drawing.Size(101, 21);
            this.comboBoxHuella.TabIndex = 13;
            // 
            // comboBoxCamara
            // 
            this.comboBoxCamara.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCamara.FormattingEnabled = true;
            this.comboBoxCamara.Location = new System.Drawing.Point(387, 303);
            this.comboBoxCamara.Name = "comboBoxCamara";
            this.comboBoxCamara.Size = new System.Drawing.Size(101, 21);
            this.comboBoxCamara.TabIndex = 14;
            // 
            // ButtonFabricar
            // 
            this.ButtonFabricar.BackColor = System.Drawing.Color.Transparent;
            this.ButtonFabricar.FlatAppearance.BorderSize = 0;
            this.ButtonFabricar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ButtonFabricar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ButtonFabricar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonFabricar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.ButtonFabricar.Location = new System.Drawing.Point(798, 87);
            this.ButtonFabricar.Name = "ButtonFabricar";
            this.ButtonFabricar.Size = new System.Drawing.Size(172, 59);
            this.ButtonFabricar.TabIndex = 28;
            this.ButtonFabricar.UseVisualStyleBackColor = false;
            this.ButtonFabricar.Click += new System.EventHandler(this.ButtonFabricar_Click);
            this.ButtonFabricar.MouseEnter += new System.EventHandler(this.ButtonFabricar_MouseEnter);
            this.ButtonFabricar.MouseLeave += new System.EventHandler(this.ButtonFabricar_MouseLeave);
            // 
            // ButtonCerrar
            // 
            this.ButtonCerrar.BackColor = System.Drawing.Color.Transparent;
            this.ButtonCerrar.FlatAppearance.BorderSize = 0;
            this.ButtonCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ButtonCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ButtonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.ButtonCerrar.Location = new System.Drawing.Point(798, 197);
            this.ButtonCerrar.Name = "ButtonCerrar";
            this.ButtonCerrar.Size = new System.Drawing.Size(172, 59);
            this.ButtonCerrar.TabIndex = 29;
            this.ButtonCerrar.UseVisualStyleBackColor = false;
            this.ButtonCerrar.Click += new System.EventHandler(this.ButtonCerrar_Click);
            this.ButtonCerrar.MouseEnter += new System.EventHandler(this.ButtonCerrar_MouseEnter);
            this.ButtonCerrar.MouseLeave += new System.EventHandler(this.ButtonCerrar_MouseLeave);
            // 
            // ButtonUPC
            // 
            this.ButtonUPC.BackColor = System.Drawing.Color.Transparent;
            this.ButtonUPC.FlatAppearance.BorderSize = 0;
            this.ButtonUPC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ButtonUPC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ButtonUPC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonUPC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.ButtonUPC.Location = new System.Drawing.Point(222, 227);
            this.ButtonUPC.Name = "ButtonUPC";
            this.ButtonUPC.Size = new System.Drawing.Size(84, 31);
            this.ButtonUPC.TabIndex = 31;
            this.ButtonUPC.UseVisualStyleBackColor = false;
            this.ButtonUPC.Click += new System.EventHandler(this.ButtonUPC_Click_1);
            // 
            // FrmFabricaCelular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FormFranciscoRocha.Properties.Resources.FondoFabricaCelular;
            this.ClientSize = new System.Drawing.Size(992, 450);
            this.Controls.Add(this.ButtonUPC);
            this.Controls.Add(this.ButtonCerrar);
            this.Controls.Add(this.ButtonFabricar);
            this.Controls.Add(this.comboBoxCamara);
            this.Controls.Add(this.comboBoxHuella);
            this.Controls.Add(this.comboBoxJack);
            this.Controls.Add(this.comboBoxRes);
            this.Controls.Add(this.comboBoxPulgadas);
            this.Controls.Add(this.comboBoxBateria);
            this.Controls.Add(this.comboBoxMaterial);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FrmFabricaCelular";
            this.Text = "FrmFabricaCelular";
            this.Load += new System.EventHandler(this.FrmFabricaCelular_Load);
            this.Controls.SetChildIndex(this.comboBoxMarca, 0);
            this.Controls.SetChildIndex(this.comboBoxRam, 0);
            this.Controls.SetChildIndex(this.comboBoxSistemaOP, 0);
            this.Controls.SetChildIndex(this.comboBoxGPU, 0);
            this.Controls.SetChildIndex(this.comboBoxAlmacenamiento, 0);
            this.Controls.SetChildIndex(this.CodigoUPC, 0);
            this.Controls.SetChildIndex(this.comboBoxMaterial, 0);
            this.Controls.SetChildIndex(this.comboBoxBateria, 0);
            this.Controls.SetChildIndex(this.comboBoxPulgadas, 0);
            this.Controls.SetChildIndex(this.comboBoxRes, 0);
            this.Controls.SetChildIndex(this.comboBoxJack, 0);
            this.Controls.SetChildIndex(this.comboBoxHuella, 0);
            this.Controls.SetChildIndex(this.comboBoxCamara, 0);
            this.Controls.SetChildIndex(this.ButtonFabricar, 0);
            this.Controls.SetChildIndex(this.ButtonCerrar, 0);
            this.Controls.SetChildIndex(this.ButtonUPC, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxMaterial;
        private System.Windows.Forms.ComboBox comboBoxBateria;
        private System.Windows.Forms.ComboBox comboBoxPulgadas;
        private System.Windows.Forms.ComboBox comboBoxRes;
        private System.Windows.Forms.ComboBox comboBoxJack;
        private System.Windows.Forms.ComboBox comboBoxHuella;
        private System.Windows.Forms.ComboBox comboBoxCamara;
        private System.Windows.Forms.Button ButtonFabricar;
        private System.Windows.Forms.Button ButtonCerrar;
        private System.Windows.Forms.Button ButtonUPC;
    }
}