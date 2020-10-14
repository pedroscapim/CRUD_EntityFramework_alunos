namespace CRUD_EntityFramework_alunos
{
    partial class FormAgenda
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnINSERIR = new System.Windows.Forms.Button();
            this.btnALTERAR = new System.Windows.Forms.Button();
            this.btnEXCLUIR = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txttelefone = new System.Windows.Forms.TextBox();
            this.grid = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcep = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "TELEFONE";
            // 
            // btnINSERIR
            // 
            this.btnINSERIR.Location = new System.Drawing.Point(47, 202);
            this.btnINSERIR.Name = "btnINSERIR";
            this.btnINSERIR.Size = new System.Drawing.Size(75, 23);
            this.btnINSERIR.TabIndex = 3;
            this.btnINSERIR.Text = "INSERIR";
            this.btnINSERIR.UseVisualStyleBackColor = true;
            this.btnINSERIR.Click += new System.EventHandler(this.btnINSERIR_Click);
            // 
            // btnALTERAR
            // 
            this.btnALTERAR.Location = new System.Drawing.Point(139, 200);
            this.btnALTERAR.Name = "btnALTERAR";
            this.btnALTERAR.Size = new System.Drawing.Size(75, 23);
            this.btnALTERAR.TabIndex = 4;
            this.btnALTERAR.Text = "ALTERAR";
            this.btnALTERAR.UseVisualStyleBackColor = true;
            this.btnALTERAR.Click += new System.EventHandler(this.btnALTERAR_Click);
            // 
            // btnEXCLUIR
            // 
            this.btnEXCLUIR.Location = new System.Drawing.Point(232, 199);
            this.btnEXCLUIR.Name = "btnEXCLUIR";
            this.btnEXCLUIR.Size = new System.Drawing.Size(75, 23);
            this.btnEXCLUIR.TabIndex = 5;
            this.btnEXCLUIR.Text = "EXCLUIR";
            this.btnEXCLUIR.UseVisualStyleBackColor = true;
            this.btnEXCLUIR.Click += new System.EventHandler(this.btnEXCLUIR_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(94, 36);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(61, 20);
            this.txtid.TabIndex = 6;
            this.txtid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(94, 62);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(214, 20);
            this.txtnome.TabIndex = 7;
            // 
            // txttelefone
            // 
            this.txttelefone.Location = new System.Drawing.Point(94, 85);
            this.txttelefone.Name = "txttelefone";
            this.txttelefone.Size = new System.Drawing.Size(214, 20);
            this.txttelefone.TabIndex = 8;
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(52, 251);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(271, 103);
            this.grid.TabIndex = 9;
            this.grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellClick);
            this.grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "CEP";
            // 
            // txtcep
            // 
            this.txtcep.Location = new System.Drawing.Point(94, 110);
            this.txtcep.Name = "txtcep";
            this.txtcep.Size = new System.Drawing.Size(214, 20);
            this.txtcep.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 386);
            this.Controls.Add(this.txtcep);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.txttelefone);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.btnEXCLUIR);
            this.Controls.Add(this.btnALTERAR);
            this.Controls.Add(this.btnINSERIR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "AGENDA";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnINSERIR;
        private System.Windows.Forms.Button btnALTERAR;
        private System.Windows.Forms.Button btnEXCLUIR;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txttelefone;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcep;
    }
}

