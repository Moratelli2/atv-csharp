namespace AtvFormsComp.model
{
    abstract class Conta
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal Saldo { get; set; }
    }
}