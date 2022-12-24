namespace Cronometro
{
    partial class Cronometro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbxContador = new System.Windows.Forms.TextBox();
            this.rbtProgressiva = new System.Windows.Forms.RadioButton();
            this.rbtRegressiva = new System.Windows.Forms.RadioButton();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnPausar = new System.Windows.Forms.Button();
            this.btnParar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxContador
            // 
            this.tbxContador.Location = new System.Drawing.Point(12, 12);
            this.tbxContador.Name = "tbxContador";
            this.tbxContador.Size = new System.Drawing.Size(264, 23);
            this.tbxContador.TabIndex = 0;
            this.tbxContador.Text = "0";
            this.tbxContador.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // rbtProgressiva
            // 
            this.rbtProgressiva.AutoSize = true;
            this.rbtProgressiva.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtProgressiva.Location = new System.Drawing.Point(40, 41);
            this.rbtProgressiva.Name = "rbtProgressiva";
            this.rbtProgressiva.Size = new System.Drawing.Size(85, 19);
            this.rbtProgressiva.TabIndex = 1;
            this.rbtProgressiva.Text = "Progressiva";
            this.rbtProgressiva.UseVisualStyleBackColor = true;
            // 
            // rbtRegressiva
            // 
            this.rbtRegressiva.AutoSize = true;
            this.rbtRegressiva.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.rbtRegressiva.Location = new System.Drawing.Point(163, 41);
            this.rbtRegressiva.Name = "rbtRegressiva";
            this.rbtRegressiva.Size = new System.Drawing.Size(80, 19);
            this.rbtRegressiva.TabIndex = 2;
            this.rbtRegressiva.Text = "Regressiva";
            this.rbtRegressiva.UseVisualStyleBackColor = true;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciar.Enabled = false;
            this.btnIniciar.Location = new System.Drawing.Point(12, 76);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 3;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            // 
            // btnPausar
            // 
            this.btnPausar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPausar.Location = new System.Drawing.Point(107, 76);
            this.btnPausar.Name = "btnPausar";
            this.btnPausar.Size = new System.Drawing.Size(75, 23);
            this.btnPausar.TabIndex = 4;
            this.btnPausar.Text = "Pausar";
            this.btnPausar.UseVisualStyleBackColor = true;
            // 
            // btnParar
            // 
            this.btnParar.BackColor = System.Drawing.Color.Red;
            this.btnParar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnParar.Location = new System.Drawing.Point(201, 76);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(75, 23);
            this.btnParar.TabIndex = 5;
            this.btnParar.Text = "Parar";
            this.btnParar.UseVisualStyleBackColor = false;
            // 
            // Cronometro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(295, 115);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnPausar);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.rbtRegressiva);
            this.Controls.Add(this.rbtProgressiva);
            this.Controls.Add(this.tbxContador);
            this.Name = "Cronometro";
            this.Text = "Cronômetro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbxContador;
        private RadioButton rbtProgressiva;
        private RadioButton rbtRegressiva;
        private Button btnIniciar;
        private Button btnPausar;
        private Button btnParar;
    }
}