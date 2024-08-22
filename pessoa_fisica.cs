namespace Atividade
{
    class Pessoa_Fisica : Clientes
    {
        public string Cpf { get; set; }
        public string Rg { get; set; }

        public override void Pagar_Imposto(float v)
        {
            base.Pagar_Imposto(v);  // Usa o método base de cálculo de imposto
        }
    }
}
