namespace AnimacePohyb.Models
{
    public class Postava
    {
        public Postava(string obrazek, string popisek) 
        {
            Obrazek = obrazek;
            Popisek = popisek; 
        }
        private List<Souradnice> PoziceList { get; set; } = new List<Souradnice>();
        public string Obrazek { get; private set; }
        public int AktualniPozice { get; set; }
        public string Popisek { get; private set; }
        public string Style => PoziceList[AktualniPozice].Style;
        public void PridejPozici(int pozX, int pozY, int velikostObrazku)
        {
            var souradnice = new Souradnice(pozX, pozY, velikostObrazku);
            PoziceList.Add(souradnice);
        }
    }   
}
