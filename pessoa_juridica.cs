namespace Atividade
{
    class Pessoa_Juridica : Clientes
    {
        public string Cnpj { get; set; }
        public string Ie { get; set; }

        public override void Pagar_Imposto(float v)
        {
            this.Valor = v;
            this.ValorImposto = this.Valor * 20 / 100;
            this.Total = this.Valor + this.ValorImposto;
        }
    }
}

