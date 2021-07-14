
using System;

namespace FormFranciscoRocha
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonCerrar = new System.Windows.Forms.Button();
            this.ButtonFabricarPC = new System.Windows.Forms.Button();
            this.ButtonFabricarCelular = new System.Windows.Forms.Button();
            this.ButtonMostrar = new System.Windows.Forms.Button();
            this.ButtonGuardar = new System.Windows.Forms.Button();
            this.ButtonCargar = new System.Windows.Forms.Button();
            this.buttonMinimizar = new System.Windows.Forms.Button();
            this.PanelMovimientoForm = new System.Windows.Forms.Panel();
            this.CargarSQL = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonXMLaSQL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonCerrar
            // 
            this.ButtonCerrar.BackColor = System.Drawing.Color.Transparent;
            this.ButtonCerrar.FlatAppearance.BorderSize = 0;
            this.ButtonCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ButtonCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ButtonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.ButtonCerrar.Location = new System.Drawing.Point(1421, 5);
            this.ButtonCerrar.Name = "ButtonCerrar";
            this.ButtonCerrar.Size = new System.Drawing.Size(61, 65);
            this.ButtonCerrar.TabIndex = 1;
            this.ButtonCerrar.UseVisualStyleBackColor = false;
            this.ButtonCerrar.Click += new System.EventHandler(this.ButtonCerrar_Click);
            this.ButtonCerrar.MouseEnter += new System.EventHandler(this.ButtonCerrar_MouseEnter);
            this.ButtonCerrar.MouseLeave += new System.EventHandler(this.ButtonCerrar_MouseLeave);
            // 
            // ButtonFabricarPC
            // 
            this.ButtonFabricarPC.BackColor = System.Drawing.Color.Transparent;
            this.ButtonFabricarPC.FlatAppearance.BorderSize = 0;
            this.ButtonFabricarPC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ButtonFabricarPC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ButtonFabricarPC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonFabricarPC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.ButtonFabricarPC.Location = new System.Drawing.Point(88, 251);
            this.ButtonFabricarPC.Name = "ButtonFabricarPC";
            this.ButtonFabricarPC.Size = new System.Drawing.Size(233, 56);
            this.ButtonFabricarPC.TabIndex = 2;
            this.ButtonFabricarPC.UseVisualStyleBackColor = false;
            this.ButtonFabricarPC.Click += new System.EventHandler(this.ButtonFabricarPC_Click);
            this.ButtonFabricarPC.MouseEnter += new System.EventHandler(this.ButtonFabricarPC_MouseEnter);
            this.ButtonFabricarPC.MouseLeave += new System.EventHandler(this.ButtonFabricarPC_MouseLeave);
            // 
            // ButtonFabricarCelular
            // 
            this.ButtonFabricarCelular.BackColor = System.Drawing.Color.Transparent;
            this.ButtonFabricarCelular.FlatAppearance.BorderSize = 0;
            this.ButtonFabricarCelular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ButtonFabricarCelular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ButtonFabricarCelular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonFabricarCelular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.ButtonFabricarCelular.Location = new System.Drawing.Point(533, 249);
            this.ButtonFabricarCelular.Name = "ButtonFabricarCelular";
            this.ButtonFabricarCelular.Size = new System.Drawing.Size(233, 56);
            this.ButtonFabricarCelular.TabIndex = 3;
            this.ButtonFabricarCelular.UseVisualStyleBackColor = false;
            this.ButtonFabricarCelular.Click += new System.EventHandler(this.ButtonFabricarCelular_Click);
            this.ButtonFabricarCelular.MouseEnter += new System.EventHandler(this.ButtonFabricarCelular_MouseEnter);
            this.ButtonFabricarCelular.MouseLeave += new System.EventHandler(this.ButtonFabricarCelular_MouseLeave);
            // 
            // ButtonMostrar
            // 
            this.ButtonMostrar.BackColor = System.Drawing.Color.Transparent;
            this.ButtonMostrar.FlatAppearance.BorderSize = 0;
            this.ButtonMostrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ButtonMostrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ButtonMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMostrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.ButtonMostrar.Location = new System.Drawing.Point(928, 115);
            this.ButtonMostrar.Name = "ButtonMostrar";
            this.ButtonMostrar.Size = new System.Drawing.Size(236, 73);
            this.ButtonMostrar.TabIndex = 4;
            this.ButtonMostrar.UseVisualStyleBackColor = false;
            this.ButtonMostrar.Click += new System.EventHandler(this.ButtonMostrar_Click);
            this.ButtonMostrar.MouseEnter += new System.EventHandler(this.ButtonMostrar_MouseEnter);
            this.ButtonMostrar.MouseLeave += new System.EventHandler(this.ButtonMostrar_MouseLeave);
            // 
            // ButtonGuardar
            // 
            this.ButtonGuardar.BackColor = System.Drawing.Color.Transparent;
            this.ButtonGuardar.FlatAppearance.BorderSize = 0;
            this.ButtonGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ButtonGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ButtonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.ButtonGuardar.Location = new System.Drawing.Point(927, 246);
            this.ButtonGuardar.Name = "ButtonGuardar";
            this.ButtonGuardar.Size = new System.Drawing.Size(237, 73);
            this.ButtonGuardar.TabIndex = 5;
            this.ButtonGuardar.UseVisualStyleBackColor = false;
            this.ButtonGuardar.Click += new System.EventHandler(this.ButtonGuardar_Click);
            this.ButtonGuardar.MouseEnter += new System.EventHandler(this.ButtonGuardar_MouseEnter);
            this.ButtonGuardar.MouseLeave += new System.EventHandler(this.ButtonGuardar_MouseLeave);
            // 
            // ButtonCargar
            // 
            this.ButtonCargar.BackColor = System.Drawing.Color.Transparent;
            this.ButtonCargar.FlatAppearance.BorderSize = 0;
            this.ButtonCargar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ButtonCargar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ButtonCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCargar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.ButtonCargar.Location = new System.Drawing.Point(928, 378);
            this.ButtonCargar.Name = "ButtonCargar";
            this.ButtonCargar.Size = new System.Drawing.Size(235, 73);
            this.ButtonCargar.TabIndex = 6;
            this.ButtonCargar.UseVisualStyleBackColor = false;
            this.ButtonCargar.Click += new System.EventHandler(this.ButtonCargar_Click);
            this.ButtonCargar.MouseEnter += new System.EventHandler(this.ButtonCargar_MouseEnter);
            this.ButtonCargar.MouseLeave += new System.EventHandler(this.ButtonCargar_MouseLeave);
            // 
            // buttonMinimizar
            // 
            this.buttonMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.buttonMinimizar.FlatAppearance.BorderSize = 0;
            this.buttonMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.buttonMinimizar.Location = new System.Drawing.Point(1352, 23);
            this.buttonMinimizar.Name = "buttonMinimizar";
            this.buttonMinimizar.Size = new System.Drawing.Size(61, 29);
            this.buttonMinimizar.TabIndex = 13;
            this.buttonMinimizar.UseVisualStyleBackColor = false;
            this.buttonMinimizar.Click += new System.EventHandler(this.buttonMinimizar_Click);
            this.buttonMinimizar.MouseEnter += new System.EventHandler(this.buttonMinimizar_MouseEnter);
            this.buttonMinimizar.MouseLeave += new System.EventHandler(this.buttonMinimizar_MouseLeave);
            // 
            // PanelMovimientoForm
            // 
            this.PanelMovimientoForm.BackColor = System.Drawing.Color.Transparent;
            this.PanelMovimientoForm.Location = new System.Drawing.Point(-15, -15);
            this.PanelMovimientoForm.Name = "PanelMovimientoForm";
            this.PanelMovimientoForm.Size = new System.Drawing.Size(1361, 84);
            this.PanelMovimientoForm.TabIndex = 7;
            this.PanelMovimientoForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelMovimientoForm_MouseDown);
            this.PanelMovimientoForm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelMovimientoForm_MouseMove);
            this.PanelMovimientoForm.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelMovimientoForm_MouseUp);
            // 
            // CargarSQL
            // 
            this.CargarSQL.BackColor = System.Drawing.Color.Transparent;
            this.CargarSQL.FlatAppearance.BorderSize = 0;
            this.CargarSQL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CargarSQL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CargarSQL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CargarSQL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.CargarSQL.Location = new System.Drawing.Point(1209, 113);
            this.CargarSQL.Name = "CargarSQL";
            this.CargarSQL.Size = new System.Drawing.Size(236, 73);
            this.CargarSQL.TabIndex = 16;
            this.CargarSQL.UseVisualStyleBackColor = false;
            this.CargarSQL.Click += new System.EventHandler(this.CargarSQL_Click);
            this.CargarSQL.MouseEnter += new System.EventHandler(this.CargarSQL_MouseEnter);
            this.CargarSQL.MouseLeave += new System.EventHandler(this.CargarSQL_MouseLeave);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.Transparent;
            this.buttonEliminar.FlatAppearance.BorderSize = 0;
            this.buttonEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.buttonEliminar.Location = new System.Drawing.Point(1210, 243);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(236, 73);
            this.buttonEliminar.TabIndex = 17;
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            this.buttonEliminar.MouseEnter += new System.EventHandler(this.buttonEliminar_MouseEnter);
            this.buttonEliminar.MouseLeave += new System.EventHandler(this.buttonEliminar_MouseLeave);
            // 
            // buttonXMLaSQL
            // 
            this.buttonXMLaSQL.BackColor = System.Drawing.Color.Transparent;
            this.buttonXMLaSQL.FlatAppearance.BorderSize = 0;
            this.buttonXMLaSQL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonXMLaSQL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonXMLaSQL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonXMLaSQL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.buttonXMLaSQL.Location = new System.Drawing.Point(1212, 378);
            this.buttonXMLaSQL.Name = "buttonXMLaSQL";
            this.buttonXMLaSQL.Size = new System.Drawing.Size(236, 73);
            this.buttonXMLaSQL.TabIndex = 18;
            this.buttonXMLaSQL.UseVisualStyleBackColor = false;
            this.buttonXMLaSQL.Click += new System.EventHandler(this.buttonXMLaSQL_Click);
            this.buttonXMLaSQL.MouseEnter += new System.EventHandler(this.buttonXMLaSQL_MouseEnter);
            this.buttonXMLaSQL.MouseLeave += new System.EventHandler(this.buttonXMLaSQL_MouseLeave);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FormFranciscoRocha.Properties.Resources.FondoFinalTP4;
            this.ClientSize = new System.Drawing.Size(1489, 487);
            this.Controls.Add(this.buttonXMLaSQL);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.CargarSQL);
            this.Controls.Add(this.buttonMinimizar);
            this.Controls.Add(this.PanelMovimientoForm);
            this.Controls.Add(this.ButtonCargar);
            this.Controls.Add(this.ButtonGuardar);
            this.Controls.Add(this.ButtonMostrar);
            this.Controls.Add(this.ButtonFabricarCelular);
            this.Controls.Add(this.ButtonFabricarPC);
            this.Controls.Add(this.ButtonCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrincipal";
            this.Text = "|";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ButtonCerrar;
        private System.Windows.Forms.Button ButtonFabricarPC;
        private System.Windows.Forms.Button ButtonFabricarCelular;
        private System.Windows.Forms.Button ButtonMostrar;
        private System.Windows.Forms.Button ButtonGuardar;
        private System.Windows.Forms.Button ButtonCargar;
        private System.Windows.Forms.Button buttonMinimizar;
        private System.Windows.Forms.Panel PanelMovimientoForm;
        private System.Windows.Forms.Button CargarSQL;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonXMLaSQL;
    }
}

