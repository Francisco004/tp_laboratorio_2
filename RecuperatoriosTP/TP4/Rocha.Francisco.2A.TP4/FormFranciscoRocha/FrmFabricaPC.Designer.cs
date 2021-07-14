
namespace FormFranciscoRocha
{
    partial class FrmFabricaPC
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
            this.comboBoxCPU = new System.Windows.Forms.ComboBox();
            this.comboBoxFuente = new System.Windows.Forms.ComboBox();
            this.comboBoxGabo = new System.Windows.Forms.ComboBox();
            this.comboBoxMother = new System.Windows.Forms.ComboBox();
            this.comboBoxLector = new System.Windows.Forms.ComboBox();
            this.ButtonCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonUPC = new System.Windows.Forms.Button();
            this.MovimientoForm = new System.Windows.Forms.Panel();
            this.ButtonFabricar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxCPU
            // 
            this.comboBoxCPU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCPU.FormattingEnabled = true;
            this.comboBoxCPU.Location = new System.Drawing.Point(369, 199);
            this.comboBoxCPU.Name = "comboBoxCPU";
            this.comboBoxCPU.Size = new System.Drawing.Size(207, 21);
            this.comboBoxCPU.TabIndex = 14;
            this.comboBoxCPU.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCPU_SelectedIndexChanged);
            // 
            // comboBoxFuente
            // 
            this.comboBoxFuente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFuente.FormattingEnabled = true;
            this.comboBoxFuente.Location = new System.Drawing.Point(592, 199);
            this.comboBoxFuente.Name = "comboBoxFuente";
            this.comboBoxFuente.Size = new System.Drawing.Size(177, 21);
            this.comboBoxFuente.TabIndex = 15;
            // 
            // comboBoxGabo
            // 
            this.comboBoxGabo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGabo.FormattingEnabled = true;
            this.comboBoxGabo.Location = new System.Drawing.Point(34, 304);
            this.comboBoxGabo.Name = "comboBoxGabo";
            this.comboBoxGabo.Size = new System.Drawing.Size(168, 21);
            this.comboBoxGabo.TabIndex = 18;
            // 
            // comboBoxMother
            // 
            this.comboBoxMother.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMother.FormattingEnabled = true;
            this.comboBoxMother.Location = new System.Drawing.Point(243, 304);
            this.comboBoxMother.Name = "comboBoxMother";
            this.comboBoxMother.Size = new System.Drawing.Size(252, 21);
            this.comboBoxMother.TabIndex = 19;
            this.comboBoxMother.SelectedIndexChanged += new System.EventHandler(this.comboBoxMother_SelectedIndexChanged);
            // 
            // comboBoxLector
            // 
            this.comboBoxLector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLector.FormattingEnabled = true;
            this.comboBoxLector.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.comboBoxLector.Location = new System.Drawing.Point(532, 304);
            this.comboBoxLector.Name = "comboBoxLector";
            this.comboBoxLector.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLector.TabIndex = 22;
            // 
            // ButtonCerrar
            // 
            this.ButtonCerrar.BackColor = System.Drawing.Color.Transparent;
            this.ButtonCerrar.FlatAppearance.BorderSize = 0;
            this.ButtonCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ButtonCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ButtonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.ButtonCerrar.Location = new System.Drawing.Point(797, 198);
            this.ButtonCerrar.Name = "ButtonCerrar";
            this.ButtonCerrar.Size = new System.Drawing.Size(172, 59);
            this.ButtonCerrar.TabIndex = 24;
            this.ButtonCerrar.UseVisualStyleBackColor = false;
            this.ButtonCerrar.Click += new System.EventHandler(this.ButtonCerrar_Click);
            this.ButtonCerrar.MouseEnter += new System.EventHandler(this.ButtonCerrar_MouseEnter);
            this.ButtonCerrar.MouseLeave += new System.EventHandler(this.ButtonCerrar_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(974, 455);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "label1";
            // 
            // ButtonUPC
            // 
            this.ButtonUPC.BackColor = System.Drawing.Color.Transparent;
            this.ButtonUPC.FlatAppearance.BorderSize = 0;
            this.ButtonUPC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ButtonUPC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ButtonUPC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonUPC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.ButtonUPC.Location = new System.Drawing.Point(220, 226);
            this.ButtonUPC.Name = "ButtonUPC";
            this.ButtonUPC.Size = new System.Drawing.Size(84, 31);
            this.ButtonUPC.TabIndex = 28;
            this.ButtonUPC.UseVisualStyleBackColor = false;
            this.ButtonUPC.Click += new System.EventHandler(this.ButtonUPC_Click);
            // 
            // MovimientoForm
            // 
            this.MovimientoForm.BackColor = System.Drawing.Color.Transparent;
            this.MovimientoForm.Location = new System.Drawing.Point(0, -1);
            this.MovimientoForm.Name = "MovimientoForm";
            this.MovimientoForm.Size = new System.Drawing.Size(993, 42);
            this.MovimientoForm.TabIndex = 33;
            this.MovimientoForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MovimientoForm_MouseDown);
            this.MovimientoForm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MovimientoForm_MouseMove);
            this.MovimientoForm.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MovimientoForm_MouseUp);
            // 
            // ButtonFabricar
            // 
            this.ButtonFabricar.BackColor = System.Drawing.Color.Transparent;
            this.ButtonFabricar.FlatAppearance.BorderSize = 0;
            this.ButtonFabricar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ButtonFabricar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ButtonFabricar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonFabricar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.ButtonFabricar.Location = new System.Drawing.Point(796, 87);
            this.ButtonFabricar.Name = "ButtonFabricar";
            this.ButtonFabricar.Size = new System.Drawing.Size(172, 59);
            this.ButtonFabricar.TabIndex = 27;
            this.ButtonFabricar.UseVisualStyleBackColor = false;
            this.ButtonFabricar.Click += new System.EventHandler(this.ButtonFabricar_Click);
            this.ButtonFabricar.MouseEnter += new System.EventHandler(this.ButtonFabricar_MouseEnter);
            this.ButtonFabricar.MouseLeave += new System.EventHandler(this.ButtonFabricar_MouseLeave);
            // 
            // FrmFabricaPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::FormFranciscoRocha.Properties.Resources.FondoFormPC;
            this.ClientSize = new System.Drawing.Size(992, 450);
            this.Controls.Add(this.MovimientoForm);
            this.Controls.Add(this.ButtonUPC);
            this.Controls.Add(this.ButtonFabricar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonCerrar);
            this.Controls.Add(this.comboBoxLector);
            this.Controls.Add(this.comboBoxMother);
            this.Controls.Add(this.comboBoxGabo);
            this.Controls.Add(this.comboBoxFuente);
            this.Controls.Add(this.comboBoxCPU);
            this.Name = "FrmFabricaPC";
            this.Text = "FrmFabricaPC";
            this.Load += new System.EventHandler(this.FrmFabricaPC_Load);
            this.Controls.SetChildIndex(this.comboBoxCPU, 0);
            this.Controls.SetChildIndex(this.comboBoxFuente, 0);
            this.Controls.SetChildIndex(this.comboBoxGabo, 0);
            this.Controls.SetChildIndex(this.comboBoxMother, 0);
            this.Controls.SetChildIndex(this.comboBoxLector, 0);
            this.Controls.SetChildIndex(this.ButtonCerrar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.ButtonFabricar, 0);
            this.Controls.SetChildIndex(this.ButtonUPC, 0);
            this.Controls.SetChildIndex(this.MovimientoForm, 0);
            this.Controls.SetChildIndex(this.comboBoxMarca, 0);
            this.Controls.SetChildIndex(this.comboBoxRam, 0);
            this.Controls.SetChildIndex(this.comboBoxSistemaOP, 0);
            this.Controls.SetChildIndex(this.comboBoxGPU, 0);
            this.Controls.SetChildIndex(this.comboBoxAlmacenamiento, 0);
            this.Controls.SetChildIndex(this.CodigoUPC, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxCPU;
        private System.Windows.Forms.ComboBox comboBoxFuente;
        private System.Windows.Forms.ComboBox comboBoxGabo;
        private System.Windows.Forms.ComboBox comboBoxMother;
        private System.Windows.Forms.ComboBox comboBoxLector;
        private System.Windows.Forms.Button ButtonCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonUPC;
        private System.Windows.Forms.Panel MovimientoForm;
        private System.Windows.Forms.Button ButtonFabricar;
    }
}