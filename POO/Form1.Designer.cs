namespace POO
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
            this.txbDescricaoCarro = new System.Windows.Forms.TextBox();
            this.txbQuilometragem = new System.Windows.Forms.TextBox();
            this.txbCapacidadeCarro = new System.Windows.Forms.TextBox();
            this.btnCriarCarro = new System.Windows.Forms.Button();
            this.btnMoverCarro = new System.Windows.Forms.Button();
            this.gbCarro = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbAviao = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbDescricaoAviao = new System.Windows.Forms.TextBox();
            this.btnCriarAvião = new System.Windows.Forms.Button();
            this.btnMoverAviao = new System.Windows.Forms.Button();
            this.txbCapacidadeAviao = new System.Windows.Forms.TextBox();
            this.txbHoras = new System.Windows.Forms.TextBox();
            this.btnCriarPessoa = new System.Windows.Forms.Button();
            this.gBike = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txbDescricaoBike = new System.Windows.Forms.TextBox();
            this.btnCriarBike = new System.Windows.Forms.Button();
            this.btnMoverBike = new System.Windows.Forms.Button();
            this.txbCapacidadeBike = new System.Windows.Forms.TextBox();
            this.ckSuspensao = new System.Windows.Forms.CheckBox();
            this.rbCarro = new System.Windows.Forms.RadioButton();
            this.rbAviao = new System.Windows.Forms.RadioButton();
            this.rbBike = new System.Windows.Forms.RadioButton();
            this.gbCarro.SuspendLayout();
            this.gbAviao.SuspendLayout();
            this.gBike.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbDescricaoCarro
            // 
            this.txbDescricaoCarro.Location = new System.Drawing.Point(6, 37);
            this.txbDescricaoCarro.Name = "txbDescricaoCarro";
            this.txbDescricaoCarro.Size = new System.Drawing.Size(100, 20);
            this.txbDescricaoCarro.TabIndex = 0;
            // 
            // txbQuilometragem
            // 
            this.txbQuilometragem.Location = new System.Drawing.Point(246, 37);
            this.txbQuilometragem.Name = "txbQuilometragem";
            this.txbQuilometragem.Size = new System.Drawing.Size(100, 20);
            this.txbQuilometragem.TabIndex = 1;
            // 
            // txbCapacidadeCarro
            // 
            this.txbCapacidadeCarro.Location = new System.Drawing.Point(125, 37);
            this.txbCapacidadeCarro.Name = "txbCapacidadeCarro";
            this.txbCapacidadeCarro.Size = new System.Drawing.Size(100, 20);
            this.txbCapacidadeCarro.TabIndex = 2;
            // 
            // btnCriarCarro
            // 
            this.btnCriarCarro.Location = new System.Drawing.Point(6, 78);
            this.btnCriarCarro.Name = "btnCriarCarro";
            this.btnCriarCarro.Size = new System.Drawing.Size(86, 26);
            this.btnCriarCarro.TabIndex = 6;
            this.btnCriarCarro.Text = "Criar";
            this.btnCriarCarro.UseVisualStyleBackColor = true;
            this.btnCriarCarro.Click += new System.EventHandler(this.btnCriarCarro_Click);
            // 
            // btnMoverCarro
            // 
            this.btnMoverCarro.Location = new System.Drawing.Point(125, 78);
            this.btnMoverCarro.Name = "btnMoverCarro";
            this.btnMoverCarro.Size = new System.Drawing.Size(86, 26);
            this.btnMoverCarro.TabIndex = 8;
            this.btnMoverCarro.Text = "Mover";
            this.btnMoverCarro.UseVisualStyleBackColor = true;
            this.btnMoverCarro.Click += new System.EventHandler(this.btnMoverCarro_Click);
            // 
            // gbCarro
            // 
            this.gbCarro.Controls.Add(this.label3);
            this.gbCarro.Controls.Add(this.label2);
            this.gbCarro.Controls.Add(this.label1);
            this.gbCarro.Controls.Add(this.txbDescricaoCarro);
            this.gbCarro.Controls.Add(this.btnCriarCarro);
            this.gbCarro.Controls.Add(this.btnMoverCarro);
            this.gbCarro.Controls.Add(this.txbCapacidadeCarro);
            this.gbCarro.Controls.Add(this.txbQuilometragem);
            this.gbCarro.Location = new System.Drawing.Point(12, 14);
            this.gbCarro.Name = "gbCarro";
            this.gbCarro.Size = new System.Drawing.Size(357, 121);
            this.gbCarro.TabIndex = 10;
            this.gbCarro.TabStop = false;
            this.gbCarro.Text = "Carro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Quilometragem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Capacidade";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Descrição";
            // 
            // gbAviao
            // 
            this.gbAviao.Controls.Add(this.label6);
            this.gbAviao.Controls.Add(this.label5);
            this.gbAviao.Controls.Add(this.label4);
            this.gbAviao.Controls.Add(this.txbDescricaoAviao);
            this.gbAviao.Controls.Add(this.btnCriarAvião);
            this.gbAviao.Controls.Add(this.btnMoverAviao);
            this.gbAviao.Controls.Add(this.txbCapacidadeAviao);
            this.gbAviao.Controls.Add(this.txbHoras);
            this.gbAviao.Location = new System.Drawing.Point(12, 141);
            this.gbAviao.Name = "gbAviao";
            this.gbAviao.Size = new System.Drawing.Size(357, 121);
            this.gbAviao.TabIndex = 11;
            this.gbAviao.TabStop = false;
            this.gbAviao.Text = "Avião";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(243, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Horas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Capacidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Descrição";
            // 
            // txbDescricaoAviao
            // 
            this.txbDescricaoAviao.Location = new System.Drawing.Point(6, 37);
            this.txbDescricaoAviao.Name = "txbDescricaoAviao";
            this.txbDescricaoAviao.Size = new System.Drawing.Size(100, 20);
            this.txbDescricaoAviao.TabIndex = 0;
            // 
            // btnCriarAvião
            // 
            this.btnCriarAvião.Location = new System.Drawing.Point(6, 78);
            this.btnCriarAvião.Name = "btnCriarAvião";
            this.btnCriarAvião.Size = new System.Drawing.Size(86, 26);
            this.btnCriarAvião.TabIndex = 6;
            this.btnCriarAvião.Text = "Criar";
            this.btnCriarAvião.UseVisualStyleBackColor = true;
            this.btnCriarAvião.Click += new System.EventHandler(this.btnCriarAvião_Click);
            // 
            // btnMoverAviao
            // 
            this.btnMoverAviao.Location = new System.Drawing.Point(125, 78);
            this.btnMoverAviao.Name = "btnMoverAviao";
            this.btnMoverAviao.Size = new System.Drawing.Size(86, 26);
            this.btnMoverAviao.TabIndex = 8;
            this.btnMoverAviao.Text = "Mover";
            this.btnMoverAviao.UseVisualStyleBackColor = true;
            this.btnMoverAviao.Click += new System.EventHandler(this.btnMoverAviao_Click);
            // 
            // txbCapacidadeAviao
            // 
            this.txbCapacidadeAviao.Location = new System.Drawing.Point(125, 37);
            this.txbCapacidadeAviao.Name = "txbCapacidadeAviao";
            this.txbCapacidadeAviao.Size = new System.Drawing.Size(100, 20);
            this.txbCapacidadeAviao.TabIndex = 2;
            // 
            // txbHoras
            // 
            this.txbHoras.Location = new System.Drawing.Point(246, 37);
            this.txbHoras.Name = "txbHoras";
            this.txbHoras.Size = new System.Drawing.Size(100, 20);
            this.txbHoras.TabIndex = 1;
            // 
            // btnCriarPessoa
            // 
            this.btnCriarPessoa.Location = new System.Drawing.Point(18, 395);
            this.btnCriarPessoa.Name = "btnCriarPessoa";
            this.btnCriarPessoa.Size = new System.Drawing.Size(86, 26);
            this.btnCriarPessoa.TabIndex = 12;
            this.btnCriarPessoa.Text = "Criar Pessoa";
            this.btnCriarPessoa.UseVisualStyleBackColor = true;
            this.btnCriarPessoa.Click += new System.EventHandler(this.btnCriarPessoa_Click);
            // 
            // gBike
            // 
            this.gBike.Controls.Add(this.ckSuspensao);
            this.gBike.Controls.Add(this.label8);
            this.gBike.Controls.Add(this.label9);
            this.gBike.Controls.Add(this.txbDescricaoBike);
            this.gBike.Controls.Add(this.btnCriarBike);
            this.gBike.Controls.Add(this.btnMoverBike);
            this.gBike.Controls.Add(this.txbCapacidadeBike);
            this.gBike.Location = new System.Drawing.Point(12, 268);
            this.gBike.Name = "gBike";
            this.gBike.Size = new System.Drawing.Size(357, 121);
            this.gBike.TabIndex = 14;
            this.gBike.TabStop = false;
            this.gBike.Text = "Bike";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(122, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Capacidade";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Descrição";
            // 
            // txbDescricaoBike
            // 
            this.txbDescricaoBike.Location = new System.Drawing.Point(6, 37);
            this.txbDescricaoBike.Name = "txbDescricaoBike";
            this.txbDescricaoBike.Size = new System.Drawing.Size(100, 20);
            this.txbDescricaoBike.TabIndex = 0;
            // 
            // btnCriarBike
            // 
            this.btnCriarBike.Location = new System.Drawing.Point(6, 78);
            this.btnCriarBike.Name = "btnCriarBike";
            this.btnCriarBike.Size = new System.Drawing.Size(86, 26);
            this.btnCriarBike.TabIndex = 6;
            this.btnCriarBike.Text = "Criar";
            this.btnCriarBike.UseVisualStyleBackColor = true;
            // 
            // btnMoverBike
            // 
            this.btnMoverBike.Location = new System.Drawing.Point(125, 78);
            this.btnMoverBike.Name = "btnMoverBike";
            this.btnMoverBike.Size = new System.Drawing.Size(86, 26);
            this.btnMoverBike.TabIndex = 8;
            this.btnMoverBike.Text = "Mover";
            this.btnMoverBike.UseVisualStyleBackColor = true;
            // 
            // txbCapacidadeBike
            // 
            this.txbCapacidadeBike.Location = new System.Drawing.Point(125, 37);
            this.txbCapacidadeBike.Name = "txbCapacidadeBike";
            this.txbCapacidadeBike.Size = new System.Drawing.Size(100, 20);
            this.txbCapacidadeBike.TabIndex = 2;
            // 
            // ckSuspensao
            // 
            this.ckSuspensao.AutoSize = true;
            this.ckSuspensao.Location = new System.Drawing.Point(240, 40);
            this.ckSuspensao.Name = "ckSuspensao";
            this.ckSuspensao.Size = new System.Drawing.Size(79, 17);
            this.ckSuspensao.TabIndex = 13;
            this.ckSuspensao.Text = "Suspensão";
            this.ckSuspensao.UseVisualStyleBackColor = true;
            // 
            // rbCarro
            // 
            this.rbCarro.AutoSize = true;
            this.rbCarro.Location = new System.Drawing.Point(127, 400);
            this.rbCarro.Name = "rbCarro";
            this.rbCarro.Size = new System.Drawing.Size(50, 17);
            this.rbCarro.TabIndex = 15;
            this.rbCarro.TabStop = true;
            this.rbCarro.Text = "Carro";
            this.rbCarro.UseVisualStyleBackColor = true;
            // 
            // rbAviao
            // 
            this.rbAviao.AutoSize = true;
            this.rbAviao.Location = new System.Drawing.Point(205, 400);
            this.rbAviao.Name = "rbAviao";
            this.rbAviao.Size = new System.Drawing.Size(52, 17);
            this.rbAviao.TabIndex = 16;
            this.rbAviao.TabStop = true;
            this.rbAviao.Text = "Avião";
            this.rbAviao.UseVisualStyleBackColor = true;
            // 
            // rbBike
            // 
            this.rbBike.AutoSize = true;
            this.rbBike.Location = new System.Drawing.Point(274, 400);
            this.rbBike.Name = "rbBike";
            this.rbBike.Size = new System.Drawing.Size(46, 17);
            this.rbBike.TabIndex = 17;
            this.rbBike.TabStop = true;
            this.rbBike.Text = "Bike";
            this.rbBike.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 439);
            this.Controls.Add(this.rbBike);
            this.Controls.Add(this.rbAviao);
            this.Controls.Add(this.rbCarro);
            this.Controls.Add(this.gBike);
            this.Controls.Add(this.btnCriarPessoa);
            this.Controls.Add(this.gbAviao);
            this.Controls.Add(this.gbCarro);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POO com C#";
            this.gbCarro.ResumeLayout(false);
            this.gbCarro.PerformLayout();
            this.gbAviao.ResumeLayout(false);
            this.gbAviao.PerformLayout();
            this.gBike.ResumeLayout(false);
            this.gBike.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbDescricaoCarro;
        private System.Windows.Forms.TextBox txbQuilometragem;
        private System.Windows.Forms.TextBox txbCapacidadeCarro;
        private System.Windows.Forms.Button btnCriarCarro;
        private System.Windows.Forms.Button btnMoverCarro;
        private System.Windows.Forms.GroupBox gbCarro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbAviao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbDescricaoAviao;
        private System.Windows.Forms.Button btnCriarAvião;
        private System.Windows.Forms.Button btnMoverAviao;
        private System.Windows.Forms.TextBox txbCapacidadeAviao;
        private System.Windows.Forms.TextBox txbHoras;
        private System.Windows.Forms.Button btnCriarPessoa;
        private System.Windows.Forms.GroupBox gBike;
        private System.Windows.Forms.CheckBox ckSuspensao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbDescricaoBike;
        private System.Windows.Forms.Button btnCriarBike;
        private System.Windows.Forms.Button btnMoverBike;
        private System.Windows.Forms.TextBox txbCapacidadeBike;
        private System.Windows.Forms.RadioButton rbCarro;
        private System.Windows.Forms.RadioButton rbAviao;
        private System.Windows.Forms.RadioButton rbBike;
    }
}

