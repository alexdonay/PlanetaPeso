namespace PlanetaPeso
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txPesoTerra = new System.Windows.Forms.TextBox();
            this.btCalcula = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbSaturno = new System.Windows.Forms.RadioButton();
            this.rbUrano = new System.Windows.Forms.RadioButton();
            this.rbMarte = new System.Windows.Forms.RadioButton();
            this.rbJupter = new System.Windows.Forms.RadioButton();
            this.rbVenus = new System.Windows.Forms.RadioButton();
            this.rbMercurio = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Peso na Terra (kg):";
            // 
            // txPesoTerra
            // 
            this.txPesoTerra.Location = new System.Drawing.Point(73, 90);
            this.txPesoTerra.Name = "txPesoTerra";
            this.txPesoTerra.Size = new System.Drawing.Size(100, 20);
            this.txPesoTerra.TabIndex = 1;
            this.txPesoTerra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txPesoTerra_KeyPress);
            // 
            // btCalcula
            // 
            this.btCalcula.Location = new System.Drawing.Point(241, 87);
            this.btCalcula.Name = "btCalcula";
            this.btCalcula.Size = new System.Drawing.Size(75, 23);
            this.btCalcula.TabIndex = 2;
            this.btCalcula.Text = "Calcula Peso";
            this.btCalcula.UseVisualStyleBackColor = true;
            this.btCalcula.Click += new System.EventHandler(this.btCalcula_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbSaturno);
            this.panel1.Controls.Add(this.rbUrano);
            this.panel1.Controls.Add(this.rbMarte);
            this.panel1.Controls.Add(this.rbJupter);
            this.panel1.Controls.Add(this.rbVenus);
            this.panel1.Controls.Add(this.rbMercurio);
            this.panel1.Location = new System.Drawing.Point(73, 151);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 212);
            this.panel1.TabIndex = 3;
            // 
            // rbSaturno
            // 
            this.rbSaturno.AutoSize = true;
            this.rbSaturno.Location = new System.Drawing.Point(209, 75);
            this.rbSaturno.Name = "rbSaturno";
            this.rbSaturno.Size = new System.Drawing.Size(62, 17);
            this.rbSaturno.TabIndex = 5;
            this.rbSaturno.TabStop = true;
            this.rbSaturno.Text = "Saturno";
            this.rbSaturno.UseVisualStyleBackColor = true;
            // 
            // rbUrano
            // 
            this.rbUrano.AutoSize = true;
            this.rbUrano.Location = new System.Drawing.Point(209, 125);
            this.rbUrano.Name = "rbUrano";
            this.rbUrano.Size = new System.Drawing.Size(54, 17);
            this.rbUrano.TabIndex = 4;
            this.rbUrano.TabStop = true;
            this.rbUrano.Text = "Urano";
            this.rbUrano.UseVisualStyleBackColor = true;
            // 
            // rbMarte
            // 
            this.rbMarte.AutoSize = true;
            this.rbMarte.Location = new System.Drawing.Point(118, 75);
            this.rbMarte.Name = "rbMarte";
            this.rbMarte.Size = new System.Drawing.Size(52, 17);
            this.rbMarte.TabIndex = 3;
            this.rbMarte.TabStop = true;
            this.rbMarte.Text = "Marte";
            this.rbMarte.UseVisualStyleBackColor = true;
            // 
            // rbJupter
            // 
            this.rbJupter.AutoSize = true;
            this.rbJupter.Location = new System.Drawing.Point(118, 125);
            this.rbJupter.Name = "rbJupter";
            this.rbJupter.Size = new System.Drawing.Size(54, 17);
            this.rbJupter.TabIndex = 2;
            this.rbJupter.TabStop = true;
            this.rbJupter.Text = "Júpter";
            this.rbJupter.UseVisualStyleBackColor = true;
            // 
            // rbVenus
            // 
            this.rbVenus.AutoSize = true;
            this.rbVenus.Location = new System.Drawing.Point(15, 125);
            this.rbVenus.Name = "rbVenus";
            this.rbVenus.Size = new System.Drawing.Size(55, 17);
            this.rbVenus.TabIndex = 1;
            this.rbVenus.TabStop = true;
            this.rbVenus.Text = "Vênus";
            this.rbVenus.UseVisualStyleBackColor = true;
            // 
            // rbMercurio
            // 
            this.rbMercurio.AutoSize = true;
            this.rbMercurio.Location = new System.Drawing.Point(15, 75);
            this.rbMercurio.Name = "rbMercurio";
            this.rbMercurio.Size = new System.Drawing.Size(66, 17);
            this.rbMercurio.TabIndex = 0;
            this.rbMercurio.TabStop = true;
            this.rbMercurio.Text = "Mercúrio";
            this.rbMercurio.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btCalcula);
            this.Controls.Add(this.txPesoTerra);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txPesoTerra;
        private System.Windows.Forms.Button btCalcula;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbMarte;
        private System.Windows.Forms.RadioButton rbJupter;
        private System.Windows.Forms.RadioButton rbVenus;
        private System.Windows.Forms.RadioButton rbMercurio;
        private System.Windows.Forms.RadioButton rbSaturno;
        private System.Windows.Forms.RadioButton rbUrano;
    }
}

