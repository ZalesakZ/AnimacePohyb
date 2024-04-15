namespace AnimacePohyb.Models
{
    public class Souradnice
    {
        public Souradnice(int pozX, int pozY, int velikostObrazku) 
        {
            PozX = pozX;
            PozY = pozY;
            VelikostObrazku = velikostObrazku;
        }
        private int PozX { get; }
        private int PozY { get; }
        public int VelikostObrazku { get; }
        public string Style => $"left: {PozX}px; top: {PozY}px;";

    }
}
