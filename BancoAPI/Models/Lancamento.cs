namespace BancoAPI.Models
{
    public class Lancamento
    {
        public int Id { get; set; }
        public string? descricao { get; set; }
        public DateTime data { get; set; }
        public decimal valor { get; set; }
        public bool avulso { get; set; }
        public int status { get; set; }
    }

}