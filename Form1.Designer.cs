namespace LojaDoces
{
    partial class Form1
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
            lblNomeDoce = new Label();
            lblPrecoUnitario = new Label();
            lblQuantidade = new Label();
            lblIdadeCliente = new Label();
            txtNomeDoce = new TextBox();
            txtPrecoUnitario = new TextBox();
            txtQuantidade = new TextBox();
            txtIdadeCliente = new TextBox();
            lblNome = new Label();
            lblDesconto = new Label();
            lblValorFinal = new Label();
            lblParcela = new Label();
            lblStatus = new Label();
            btnCalcular = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblNomeDoce
            // 
            lblNomeDoce.AutoSize = true;
            lblNomeDoce.Location = new Point(121, 138);
            lblNomeDoce.Name = "lblNomeDoce";
            lblNomeDoce.Size = new Size(92, 20);
            lblNomeDoce.TabIndex = 0;
            lblNomeDoce.Text = "Nome Doce:";
            lblNomeDoce.Click += lblNomeDoce_Click;
            // 
            // lblPrecoUnitario
            // 
            lblPrecoUnitario.AutoSize = true;
            lblPrecoUnitario.Location = new Point(121, 177);
            lblPrecoUnitario.Name = "lblPrecoUnitario";
            lblPrecoUnitario.Size = new Size(106, 20);
            lblPrecoUnitario.TabIndex = 1;
            lblPrecoUnitario.Text = "Preço Unitário:";
            lblPrecoUnitario.Click += lblPrecoUnitario_Click;
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(121, 221);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(90, 20);
            lblQuantidade.TabIndex = 2;
            lblQuantidade.Text = "Quantidade:";
            lblQuantidade.Click += lblQuantidade_Click;
            // 
            // lblIdadeCliente
            // 
            lblIdadeCliente.AutoSize = true;
            lblIdadeCliente.Location = new Point(119, 264);
            lblIdadeCliente.Name = "lblIdadeCliente";
            lblIdadeCliente.Size = new Size(100, 20);
            lblIdadeCliente.TabIndex = 3;
            lblIdadeCliente.Text = "Idade Cliente:";
            lblIdadeCliente.Click += lblIdadeCliente_Click;
            // 
            // txtNomeDoce
            // 
            txtNomeDoce.Location = new Point(232, 131);
            txtNomeDoce.Name = "txtNomeDoce";
            txtNomeDoce.Size = new Size(125, 27);
            txtNomeDoce.TabIndex = 4;
            txtNomeDoce.TextChanged += txtNomeDoce_TextChanged;
            // 
            // txtPrecoUnitario
            // 
            txtPrecoUnitario.Location = new Point(232, 174);
            txtPrecoUnitario.Name = "txtPrecoUnitario";
            txtPrecoUnitario.Size = new Size(125, 27);
            txtPrecoUnitario.TabIndex = 5;
            txtPrecoUnitario.TextChanged += txtPrecoUnitario_TextChanged;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(232, 218);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(125, 27);
            txtQuantidade.TabIndex = 6;
            txtQuantidade.TextChanged += txtQuantidade_TextChanged;
            // 
            // txtIdadeCliente
            // 
            txtIdadeCliente.Location = new Point(232, 261);
            txtIdadeCliente.Name = "txtIdadeCliente";
            txtIdadeCliente.Size = new Size(125, 27);
            txtIdadeCliente.TabIndex = 7;
            txtIdadeCliente.TextChanged += txtIdadeCliente_TextChanged;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(412, 134);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(50, 20);
            lblNome.TabIndex = 8;
            lblNome.Text = "Nome";
            // 
            // lblDesconto
            // 
            lblDesconto.AutoSize = true;
            lblDesconto.Location = new Point(412, 177);
            lblDesconto.Name = "lblDesconto";
            lblDesconto.Size = new Size(72, 20);
            lblDesconto.TabIndex = 9;
            lblDesconto.Text = "Desconto";
            // 
            // lblValorFinal
            // 
            lblValorFinal.AutoSize = true;
            lblValorFinal.Location = new Point(412, 224);
            lblValorFinal.Name = "lblValorFinal";
            lblValorFinal.Size = new Size(78, 20);
            lblValorFinal.TabIndex = 10;
            lblValorFinal.Text = "Valor Final";
            // 
            // lblParcela
            // 
            lblParcela.AutoSize = true;
            lblParcela.Location = new Point(413, 264);
            lblParcela.Name = "lblParcela";
            lblParcela.Size = new Size(56, 20);
            lblParcela.TabIndex = 11;
            lblParcela.Text = "Parcela";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(413, 307);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(49, 20);
            lblStatus.TabIndex = 12;
            lblStatus.Text = "Status";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(183, 329);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 13;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(255, 40);
            label1.Name = "label1";
            label1.Size = new Size(278, 40);
            label1.TabIndex = 14;
            label1.Text = "                   Loja de Doces !\r\nInsira abaixo as informações necessárias:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnCalcular);
            Controls.Add(lblStatus);
            Controls.Add(lblParcela);
            Controls.Add(lblValorFinal);
            Controls.Add(lblDesconto);
            Controls.Add(lblNome);
            Controls.Add(txtIdadeCliente);
            Controls.Add(txtQuantidade);
            Controls.Add(txtPrecoUnitario);
            Controls.Add(txtNomeDoce);
            Controls.Add(lblIdadeCliente);
            Controls.Add(lblQuantidade);
            Controls.Add(lblPrecoUnitario);
            Controls.Add(lblNomeDoce);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNomeDoce;
        private Label lblPrecoUnitario;
        private Label lblQuantidade;
        private Label lblIdadeCliente;
        private TextBox txtNomeDoce;
        private TextBox txtPrecoUnitario;
        private TextBox txtQuantidade;
        private TextBox txtIdadeCliente;
        private Label lblNome;
        private Label lblDesconto;
        private Label lblValorFinal;
        private Label lblParcela;
        private Label lblStatus;
        private Button btnCalcular;
        private Label label1;
    }
}
