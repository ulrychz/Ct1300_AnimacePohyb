namespace Ct1300_AnimacePohyb.Pages
{
    public partial class Animace1
    {
        protected override void OnInitialized()
        {
            base.OnInitialized();
            InicializaceHry();
        }
        public Models.Postava Postava { get; set; }

        private void InicializaceHry()
        {
            Postava = new Models.Postava(jmeno: "Maxipes", obrazek: "../img/maxipes.png");
            Postava.PridejPozici(pozX: 45, pozY: 280, velikostObrazku: 70);
            Postava.PridejPozici(pozX: 450, pozY: 240, velikostObrazku: 40);
            Postava.PridejPozici(pozX: 840, pozY: 340, velikostObrazku: 80);
            Postava.PridejPozici(pozX: 110, pozY: 470, velikostObrazku: 100);

        }
    }
}
