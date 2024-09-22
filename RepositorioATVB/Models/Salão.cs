namespace RepositorioATVB.Models
{
    public class Salão
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Genero { get; set; }
        public int CabeleireiraId { get; set; }
        public Cabeleireira Cabeleireira { get; set; }
    }


}
