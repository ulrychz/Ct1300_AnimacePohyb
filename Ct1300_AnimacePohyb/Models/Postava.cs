namespace Ct1300_AnimacePohyb.Models
{
    public class Postava
    {
        public Postava(string jmeno, string obrazek, int width) 
        { 
            Jmeno = jmeno;
            Obrazek = obrazek;
            AktualniPozice = 0;
            Width = width;
            AktualniPozice = -1;
        }
        private List<Souradnice> PoziceList { get; set; } = new List<Souradnice>();

        public string Jmeno { get; }
        public string Obrazek { get; }
        private int AktualniPozice { get; set; }
        public string Style
        {
            get
            {
                if (AktualniPozice < 0)
                {
                    return $"width: {Width}px;";
                }
                else
                {
                    return PoziceList[AktualniPozice].Style + $"width: {Width}px;";
                }
            }
        }

        public string StyleTransform => HlavaVpravo ? "transform: rotateY(0deg);" : "transform: rotateY(180deg);";
        public int Width { get; set; }
        private bool SmerVpred { get; set; } = true;
        private bool HlavaVpravo { get; set; } = true;
        public void PridejPozici(int pozX, int pozY, int velikostObrazku)
        {
            PoziceList.Add(new Souradnice(pozX, pozY, velikostObrazku));
        }
        public void Presun()
        {
            if (SmerVpred)
            {
                if (AktualniPozice == PoziceList.Count - 1)
                {
                    SmerVpred = false;
                }
            }
            else
            {
                if (AktualniPozice <= 0)
                {
                    SmerVpred = true;
                }
            }

            var predchoziPozice = AktualniPozice;

            if (SmerVpred)
                AktualniPozice++;
            else
                AktualniPozice--;
            
            HlavaVpravo = predchoziPozice < 0 || PoziceList[predchoziPozice].PozX < PoziceList[AktualniPozice].PozX;
        }
    }
}
