namespace CopiaTudo
{
    partial class FormPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CaminhoCopiarText = new System.Windows.Forms.TextBox();
            this.CaminhoRaizText = new System.Windows.Forms.TextBox();
            this.AbrirJanelaText2 = new System.Windows.Forms.Button();
            this.AbrirJanelaText1 = new System.Windows.Forms.Button();
            this.CaminhoBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.CopiarButoon = new System.Windows.Forms.Button();
            this.CheckALL = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nomeArquivos = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ExtensoesText = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Caminho Raiz:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Caminho Pra Copiar:";
            // 
            // CaminhoCopiarText
            // 
            this.CaminhoCopiarText.Enabled = false;
            this.CaminhoCopiarText.Location = new System.Drawing.Point(11, 65);
            this.CaminhoCopiarText.Name = "CaminhoCopiarText";
            this.CaminhoCopiarText.Size = new System.Drawing.Size(165, 21);
            this.CaminhoCopiarText.TabIndex = 2;
            // 
            // CaminhoRaizText
            // 
            this.CaminhoRaizText.Enabled = false;
            this.CaminhoRaizText.Location = new System.Drawing.Point(11, 25);
            this.CaminhoRaizText.Name = "CaminhoRaizText";
            this.CaminhoRaizText.Size = new System.Drawing.Size(165, 21);
            this.CaminhoRaizText.TabIndex = 3;
            // 
            // AbrirJanelaText2
            // 
            this.AbrirJanelaText2.Location = new System.Drawing.Point(182, 63);
            this.AbrirJanelaText2.Name = "AbrirJanelaText2";
            this.AbrirJanelaText2.Size = new System.Drawing.Size(25, 23);
            this.AbrirJanelaText2.TabIndex = 4;
            this.AbrirJanelaText2.Text = "...";
            this.AbrirJanelaText2.UseVisualStyleBackColor = true;
            this.AbrirJanelaText2.Click += new System.EventHandler(this.AbrirJanelaText2_Click);
            // 
            // AbrirJanelaText1
            // 
            this.AbrirJanelaText1.Location = new System.Drawing.Point(182, 23);
            this.AbrirJanelaText1.Name = "AbrirJanelaText1";
            this.AbrirJanelaText1.Size = new System.Drawing.Size(25, 23);
            this.AbrirJanelaText1.TabIndex = 5;
            this.AbrirJanelaText1.Text = "...";
            this.AbrirJanelaText1.UseVisualStyleBackColor = true;
            this.AbrirJanelaText1.Click += new System.EventHandler(this.AbrirJanelaText1_Click);
            // 
            // CopiarButoon
            // 
            this.CopiarButoon.Location = new System.Drawing.Point(72, 161);
            this.CopiarButoon.Name = "CopiarButoon";
            this.CopiarButoon.Size = new System.Drawing.Size(58, 27);
            this.CopiarButoon.TabIndex = 7;
            this.CopiarButoon.Text = "Executar";
            this.CopiarButoon.UseVisualStyleBackColor = true;
            this.CopiarButoon.Click += new System.EventHandler(this.CopiarButoon_Click);
            // 
            // CheckALL
            // 
            this.CheckALL.AutoSize = true;
            this.CheckALL.Location = new System.Drawing.Point(89, 6);
            this.CheckALL.Name = "CheckALL";
            this.CheckALL.Size = new System.Drawing.Size(87, 17);
            this.CheckALL.TabIndex = 8;
            this.CheckALL.Text = "ALL Diretório";
            this.CheckALL.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Extensões:";
            // 
            // nomeArquivos
            // 
            this.nomeArquivos.Location = new System.Drawing.Point(55, 132);
            this.nomeArquivos.Name = "nomeArquivos";
            this.nomeArquivos.Size = new System.Drawing.Size(89, 23);
            this.nomeArquivos.TabIndex = 10;
            this.nomeArquivos.Text = "Lista Arquivos";
            this.nomeArquivos.UseVisualStyleBackColor = true;
            this.nomeArquivos.Click += new System.EventHandler(this.NomeArquivos_Click);
            // 
            // ExtensoesText
            // 
            this.ExtensoesText.Location = new System.Drawing.Point(11, 105);
            this.ExtensoesText.Name = "ExtensoesText";
            this.ExtensoesText.Size = new System.Drawing.Size(196, 21);
            this.ExtensoesText.TabIndex = 19;
            this.ExtensoesText.Text = ".";
            this.ExtensoesText.TextChanged += new System.EventHandler(this.ExtensoesText_TextChanged);
            this.ExtensoesText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ExtensoesText_KeyPress);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(3, 195);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(204, 23);
            this.progressBar.TabIndex = 20;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(209, 223);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.ExtensoesText);
            this.Controls.Add(this.nomeArquivos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CheckALL);
            this.Controls.Add(this.CopiarButoon);
            this.Controls.Add(this.AbrirJanelaText1);
            this.Controls.Add(this.AbrirJanelaText2);
            this.Controls.Add(this.CaminhoRaizText);
            this.Controls.Add(this.CaminhoCopiarText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CopiaTudo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CaminhoCopiarText;
        private System.Windows.Forms.TextBox CaminhoRaizText;
        private System.Windows.Forms.Button AbrirJanelaText2;
        private System.Windows.Forms.Button AbrirJanelaText1;
        private System.Windows.Forms.FolderBrowserDialog CaminhoBrowser;
        private System.Windows.Forms.Button CopiarButoon;
        private System.Windows.Forms.CheckBox CheckALL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button nomeArquivos;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox ExtensoesText;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

