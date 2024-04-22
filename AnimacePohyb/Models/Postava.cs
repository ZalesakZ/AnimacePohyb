namespace AnimacePohyb.Models
{
    public class Postava
    {
        public Postava(string obrazek, string popisek, int sirkaObrazku) 
        {
            Obrazek = obrazek;
            Popisek = popisek;
            SirkaObrazku = sirkaObrazku;
            AktualniPozice = -1;
        }
        private List<Souradnice> PoziceList { get; set; } = new List<Souradnice>();
        public string Obrazek { get; private set; }
        public int AktualniPozice { get; set; }
        public string Popisek { get; private set; }
        private int SirkaObrazku { get; set; }
        public string Style
        {
            get
            {
                if (AktualniPozice < 0)
                {
                    return $"width:{SirkaObrazku}px;";
                }
                else
                {
                    var poz = PoziceList[AktualniPozice];
                    return poz.Style + $"width:{SirkaObrazku * poz.VelikostObrazku / 100}px;";
                }
                
            }
        }

        public bool Dopredu { get; set; } = true;
        private bool HlavaVpravo { get; set; } = true;
        public string TransformRotateY => HlavaVpravo ? "transform: rotateY(0deg);" : "transform: rotateY(180deg);";
        public int Progress => (int)Math.Round((double)(AktualniPozice + 1) / PoziceList.Count * 100);
        public void PridejPozici(int pozX, int pozY, int velikostObrazku)
        {
            var souradnice = new Souradnice(pozX, pozY, velikostObrazku);
            PoziceList.Add(souradnice);
        }

        public void Presun()
        {
            if (Dopredu)
            {
                if (AktualniPozice == PoziceList.Count - 1)
                {
                    Dopredu = false;
                }
            }
            else
            {
                if (AktualniPozice == 0)
                {
                    Dopredu = true;
                }
            }

            var predchoziPozice = AktualniPozice;

            if (Dopredu)
            {
                AktualniPozice++;
            }
            else
            {
                AktualniPozice--;
            }

            HlavaVpravo = predchoziPozice < 0 || PoziceList[predchoziPozice].PozX < PoziceList[AktualniPozice].PozX;
        }
    }   
}
