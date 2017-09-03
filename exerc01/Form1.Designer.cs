namespace exerc01
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cxEntrada = new System.Windows.Forms.Label();
            this.cxEntrada01 = new System.Windows.Forms.TextBox();
            this.btEntrada = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cxEntrada
            // 
            this.cxEntrada.AutoSize = true;
            this.cxEntrada.Location = new System.Drawing.Point(23, 37);
            this.cxEntrada.Name = "cxEntrada";
            this.cxEntrada.Size = new System.Drawing.Size(113, 13);
            this.cxEntrada.TabIndex = 0;
            this.cxEntrada.Text = "Entre com o seu nome";
            this.cxEntrada.Click += new System.EventHandler(this.label1_Click);
            // 
            // cxEntrada01
            // 
            this.cxEntrada01.Location = new System.Drawing.Point(26, 96);
            this.cxEntrada01.Name = "cxEntrada01";
            this.cxEntrada01.Size = new System.Drawing.Size(208, 20);
            this.cxEntrada01.TabIndex = 1;
            // 
            // btEntrada
            // 
            this.btEntrada.Location = new System.Drawing.Point(26, 142);
            this.btEntrada.Name = "btEntrada";
            this.btEntrada.Size = new System.Drawing.Size(101, 36);
            this.btEntrada.TabIndex = 2;
            this.btEntrada.Text = "Clique em mim";
            this.btEntrada.UseVisualStyleBackColor = true;
            this.btEntrada.Click += new System.EventHandler(this.btEntrada_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(353, 325);
            this.Controls.Add(this.btEntrada);
            this.Controls.Add(this.cxEntrada01);
            this.Controls.Add(this.cxEntrada);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Minha Primeira Aplicação";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cxEntrada;
        private System.Windows.Forms.TextBox cxEntrada01;
        private System.Windows.Forms.Button btEntrada;

    }
}

