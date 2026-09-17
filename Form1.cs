namespace LojaDoces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblNomeDoce_Click(object sender, EventArgs e)
        {

        }

        private void lblPrecoUnitario_Click(object sender, EventArgs e)
        {

        }

        private void lblQuantidade_Click(object sender, EventArgs e)
        {

        }

        private void lblIdadeCliente_Click(object sender, EventArgs e)
        {

        }

        private void txtNomeDoce_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecoUnitario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdadeCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                Pedido pedido = new Pedido();
                pedido.NomeDoce = txtNomeDoce.Text;
                pedido.PrecoUnitario = Convert.ToDouble(txtPrecoUnitario.Text); 
                pedido.Quantidade = int.Parse(txtQuantidade.Text); 
                pedido.IdadeCliente = int.Parse(txtIdadeCliente.Text);

                double desconto = pedido.CalcularDesconto();
                double valorFinal = pedido.CalcularValorFinal();
                double parcela = pedido.CalcularParcela();
                bool brindeAprovado = pedido.ValidarBrinde();

                // Exibindo os dados formatados na tela 
                lblNome.Text = $"Produto: {pedido.NomeDoce.ToUpper()}";
                lblDesconto.Text = $"Desconto: R${desconto:N2}";
                lblValorFinal.Text = $"Valor Final: R$ {valorFinal:N2}";
                lblParcela.Text = $"Parcelamento: 3x de R$ {parcela:N2}";

                //Limpando campos  
                txtNomeDoce.Clear();
                txtPrecoUnitario.Clear();
                txtQuantidade.Clear();
                txtIdadeCliente.Clear();


                if (brindeAprovado)
                {
                    lblStatus.Text = "PARABÉNS! Você ganhou um brinde surpresa!";
                    lblStatus.ForeColor = Color.Green;
                }
                else
                {
                    lblStatus.Text = "Compra padrão realizada com sucesso!";
                    lblStatus.ForeColor = Color.Blue;
                }
            }

            catch (FormatException)
            {
                // Tratamento simples caso o usuario digite texto onde deveria ser número 
                MessageBox.Show("Preencha os campos numéricos corretamente!", "Erro de Digitação!", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}
