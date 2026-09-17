namespace LojaDoces
{
    class Pedido
    {
        public string? NomeDoce { get; set; }
        public double PrecoUnitario { get; set; }
        public int Quantidade { get; set; }
        public int IdadeCliente { get; set; }

        public double CalcularDesconto() // determina que ACIMA de 10 unidades comprados, o cliente obtém 10% de desconto
        {
            double valorTotal = PrecoUnitario * Quantidade;

            if (Quantidade >= 10)
            {
                return valorTotal * 0.10;
            }
            return 0.0;

        }

        public double CalcularValorFinal() // calcula valor final com desconto JÁ aplicado
        {
            double valorTotalBruto = PrecoUnitario * Quantidade;
            double desconto = CalcularDesconto();
            return valorTotalBruto - desconto;
        }
        
        public double CalcularParcela() // calcula parcelamento em até 3x caso valor final seja VÁLIDO
        {
            return CalcularValorFinal() / 3.0;
        }

        public bool ValidarBrinde() // determina se cliente tem direito a brinde (critérios: ser MAIOR de idade e comprado ao menos 5 UNIDADES)
        {
            return (IdadeCliente >= 18 && Quantidade >= 5) || (CalcularValorFinal() > 100.0);
        }
    }
}