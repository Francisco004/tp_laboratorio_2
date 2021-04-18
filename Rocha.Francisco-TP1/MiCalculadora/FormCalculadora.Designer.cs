
namespace MiCalculadora
{
    partial class FormCalculadora
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
            this.Numero1 = new System.Windows.Forms.TextBox();
            this.Numero2 = new System.Windows.Forms.TextBox();
            this.Operador = new System.Windows.Forms.ComboBox();
            this.btnOperar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnBinario = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.Resultado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Numero1
            // 
            this.Numero1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Numero1.BackColor = System.Drawing.SystemColors.Window;
            this.Numero1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Numero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numero1.Location = new System.Drawing.Point(12, 74);
            this.Numero1.Multiline = true;
            this.Numero1.Name = "Numero1";
            this.Numero1.Size = new System.Drawing.Size(162, 42);
            this.Numero1.TabIndex = 1;
            this.Numero1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Numero2
            // 
            this.Numero2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Numero2.BackColor = System.Drawing.SystemColors.Window;
            this.Numero2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Numero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numero2.Location = new System.Drawing.Point(352, 75);
            this.Numero2.Multiline = true;
            this.Numero2.Name = "Numero2";
            this.Numero2.Size = new System.Drawing.Size(162, 41);
            this.Numero2.TabIndex = 3;
            this.Numero2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Operador
            // 
            this.Operador.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Operador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Operador.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Operador.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Operador.FormattingEnabled = true;
            this.Operador.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.Operador.Location = new System.Drawing.Point(210, 73);
            this.Operador.MaxLength = 1;
            this.Operador.Name = "Operador";
            this.Operador.Size = new System.Drawing.Size(108, 45);
            this.Operador.TabIndex = 2;
            // 
            // btnOperar
            // 
            this.btnOperar.BackColor = System.Drawing.SystemColors.Control;
            this.btnOperar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOperar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOperar.FlatAppearance.BorderSize = 5;
            this.btnOperar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnOperar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOperar.Location = new System.Drawing.Point(14, 157);
            this.btnOperar.Name = "btnOperar";
            this.btnOperar.Size = new System.Drawing.Size(161, 42);
            this.btnOperar.TabIndex = 4;
            this.btnOperar.Text = "Operar";
            this.btnOperar.UseVisualStyleBackColor = false;
            this.btnOperar.Click += new System.EventHandler(this.btnOperar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.Control;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(185, 157);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(162, 43);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(355, 158);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(160, 41);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnBinario
            // 
            this.btnBinario.BackColor = System.Drawing.SystemColors.Control;
            this.btnBinario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBinario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBinario.Location = new System.Drawing.Point(10, 223);
            this.btnBinario.Name = "btnBinario";
            this.btnBinario.Size = new System.Drawing.Size(243, 43);
            this.btnBinario.TabIndex = 7;
            this.btnBinario.Text = "Convertir a binario";
            this.btnBinario.UseVisualStyleBackColor = false;
            this.btnBinario.Click += new System.EventHandler(this.btnBinario_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.BackColor = System.Drawing.SystemColors.Control;
            this.btnDecimal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDecimal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecimal.Location = new System.Drawing.Point(274, 222);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(242, 44);
            this.btnDecimal.TabIndex = 8;
            this.btnDecimal.Text = "Convertir a decimal";
            this.btnDecimal.UseVisualStyleBackColor = false;
            this.btnDecimal.Click += new System.EventHandler(this.btnDecimal_Click);
            // 
            // Resultado
            // 
            this.Resultado.AutoSize = true;
            this.Resultado.BackColor = System.Drawing.Color.Transparent;
            this.Resultado.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultado.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Resultado.Location = new System.Drawing.Point(132, 21);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(13, 29);
            this.Resultado.TabIndex = 9;
            this.Resultado.Text = "\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(407, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 22);
            this.label1.TabIndex = 10;
            // 
            // FormCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MiCalculadora.Properties.Resources.Screenshot_14;
            this.ClientSize = new System.Drawing.Size(525, 285);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btnBinario);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnOperar);
            this.Controls.Add(this.Operador);
            this.Controls.Add(this.Numero2);
            this.Controls.Add(this.Numero1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Francisco Rocha del 2A";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.TextBox Numero1;
        private System.Windows.Forms.TextBox Numero2;
        private System.Windows.Forms.ComboBox Operador;
        private System.Windows.Forms.Button btnOperar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnBinario;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Label Resultado;
        private System.Windows.Forms.Label label1;
    }
}

