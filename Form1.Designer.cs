namespace ManipulacaoMatriculaMVP
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblMatr = new System.Windows.Forms.Label();
            this.lblAlunos = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lstMatr = new System.Windows.Forms.ListBox();
            this.btnRem = new System.Windows.Forms.Button();
            this.btnMatr = new System.Windows.Forms.Button();
            this.lstAlunos = new System.Windows.Forms.ListBox();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lblMatr);
            this.pnlMain.Controls.Add(this.lblAlunos);
            this.pnlMain.Controls.Add(this.btnSalvar);
            this.pnlMain.Controls.Add(this.lstMatr);
            this.pnlMain.Controls.Add(this.btnRem);
            this.pnlMain.Controls.Add(this.btnMatr);
            this.pnlMain.Controls.Add(this.lstAlunos);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(353, 202);
            this.pnlMain.TabIndex = 0;
            // 
            // lblMatr
            // 
            this.lblMatr.AutoSize = true;
            this.lblMatr.Location = new System.Drawing.Point(171, 9);
            this.lblMatr.Name = "lblMatr";
            this.lblMatr.Size = new System.Drawing.Size(67, 13);
            this.lblMatr.TabIndex = 6;
            this.lblMatr.Text = "Matriculados";
            // 
            // lblAlunos
            // 
            this.lblAlunos.AutoSize = true;
            this.lblAlunos.Location = new System.Drawing.Point(9, 9);
            this.lblAlunos.Name = "lblAlunos";
            this.lblAlunos.Size = new System.Drawing.Size(39, 13);
            this.lblAlunos.TabIndex = 5;
            this.lblAlunos.Text = "Alunos";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(219, 152);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // lstMatr
            // 
            this.lstMatr.FormattingEnabled = true;
            this.lstMatr.Location = new System.Drawing.Point(174, 25);
            this.lstMatr.Name = "lstMatr";
            this.lstMatr.Size = new System.Drawing.Size(120, 121);
            this.lstMatr.TabIndex = 3;
            // 
            // btnRem
            // 
            this.btnRem.Location = new System.Drawing.Point(138, 89);
            this.btnRem.Name = "btnRem";
            this.btnRem.Size = new System.Drawing.Size(30, 25);
            this.btnRem.TabIndex = 2;
            this.btnRem.Text = "<<";
            this.btnRem.UseVisualStyleBackColor = true;
            // 
            // btnMatr
            // 
            this.btnMatr.Location = new System.Drawing.Point(138, 58);
            this.btnMatr.Name = "btnMatr";
            this.btnMatr.Size = new System.Drawing.Size(30, 25);
            this.btnMatr.TabIndex = 1;
            this.btnMatr.Text = ">>";
            this.btnMatr.UseVisualStyleBackColor = true;
            this.btnMatr.Click += new System.EventHandler(this.btnMatr_Click);
            // 
            // lstAlunos
            // 
            this.lstAlunos.FormattingEnabled = true;
            this.lstAlunos.Items.AddRange(new object[] {
            "Matheus",
            "Ítalo"});
            this.lstAlunos.Location = new System.Drawing.Point(12, 25);
            this.lstAlunos.Name = "lstAlunos";
            this.lstAlunos.Size = new System.Drawing.Size(120, 121);
            this.lstAlunos.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 202);
            this.Controls.Add(this.pnlMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.ListBox lstMatr;
        private System.Windows.Forms.Button btnRem;
        private System.Windows.Forms.Button btnMatr;
        private System.Windows.Forms.ListBox lstAlunos;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblMatr;
        private System.Windows.Forms.Label lblAlunos;
    }
}

