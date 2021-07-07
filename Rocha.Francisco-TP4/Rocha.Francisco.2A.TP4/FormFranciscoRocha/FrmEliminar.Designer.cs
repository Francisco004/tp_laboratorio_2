
namespace FormFranciscoRocha
{
    partial class FrmEliminar
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
            this.textBoxEliminar = new System.Windows.Forms.TextBox();
            this.ButtonEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxEliminar
            // 
            this.textBoxEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEliminar.Location = new System.Drawing.Point(144, 50);
            this.textBoxEliminar.Name = "textBoxEliminar";
            this.textBoxEliminar.Size = new System.Drawing.Size(120, 29);
            this.textBoxEliminar.TabIndex = 5;
            // 
            // ButtonEliminar
            // 
            this.ButtonEliminar.BackColor = System.Drawing.Color.Transparent;
            this.ButtonEliminar.FlatAppearance.BorderSize = 0;
            this.ButtonEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ButtonEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ButtonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.ButtonEliminar.Location = new System.Drawing.Point(146, 95);
            this.ButtonEliminar.Name = "ButtonEliminar";
            this.ButtonEliminar.Size = new System.Drawing.Size(118, 32);
            this.ButtonEliminar.TabIndex = 28;
            this.ButtonEliminar.UseVisualStyleBackColor = false;
            this.ButtonEliminar.Click += new System.EventHandler(this.ButtonEliminar_Click);
            this.ButtonEliminar.MouseEnter += new System.EventHandler(this.ButtonEliminar_MouseEnter);
            this.ButtonEliminar.MouseLeave += new System.EventHandler(this.ButtonEliminar_MouseLeave);
            // 
            // FrmEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FormFranciscoRocha.Properties.Resources.EliminarProducto1;
            this.ClientSize = new System.Drawing.Size(405, 141);
            this.Controls.Add(this.ButtonEliminar);
            this.Controls.Add(this.textBoxEliminar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEliminar";
            this.Text = "Eliminar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxEliminar;
        private System.Windows.Forms.Button ButtonEliminar;
    }
}