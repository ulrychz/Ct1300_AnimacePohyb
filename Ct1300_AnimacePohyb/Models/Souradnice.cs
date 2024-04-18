namespace Ct1300_AnimacePohyb.Models
{
    public class Souradnice
    {
        public Souradnice(int pozX, int pozY, int velikostObrazku) 
        { 
            PozX = pozX;
            PozY = pozY;
            VelikostObrazku = velikostObrazku;
        }
        public int PozX { get; }
        public int PozY { get; }
        public int VelikostObrazku { get; }
        public string Style => $"left: {PozX}px; top: {PozY}px;";
    }
}
