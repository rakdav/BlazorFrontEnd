namespace BlazorFrontEnd.Models
{
    public class AcqClass
    {
        public int IdAcq { get; set; }
        public int? IdClientWoman { get; set; }
        public int? IdClientMan { get; set; }
        public DateTime? Date { get; set; }
        public bool WomanAgr { get; set; }
        public bool ManAgr { get; set; }
    }
}
