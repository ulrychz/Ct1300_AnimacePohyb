using Ct1300_AnimacePohyb.Models;

namespace Ct1300_AnimacePohyb.Pages
{
    public partial class Animace2
    {
        public List<Models.Postava> Postavy { get; set; } = new List<Models.Postava>();
        protected override void OnInitialized()
        {
            base.OnInitialized();
            InicializaceHry();
        }
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await Task.Run(PrichodPostav);
                StateHasChanged();
            }
            await base.OnAfterRenderAsync(firstRender);
        }
        private void InicializaceHry()
        {
            var postava = new Models.Postava(jmeno: "Maxipes", obrazek: "../img/maxipes.png", width: 150);
            postava.PridejPozici(pozX: 45, pozY: 280, velikostObrazku: 70);
            postava.PridejPozici(pozX: 450, pozY: 240, velikostObrazku: 40);
            postava.PridejPozici(pozX: 840, pozY: 340, velikostObrazku: 80);
            postava.PridejPozici(pozX: 110, pozY: 470, velikostObrazku: 100);

            Postavy.Add(postava);

            var rnd = new Random();
            for (int i = 0; i < rnd.Next(6,13); i++)
            {
                postava = new Models.Postava(jmeno: $"Krtek {i+1}", obrazek: "../img/krtek.png", width: 100);
                for (int j = 0; j < rnd.Next(3,11); j++)
                {
                    postava.PridejPozici(pozX: rnd.Next(10, 890), pozY: rnd.Next(250, 470), velikostObrazku: 100);
                }
                Postavy.Add(postava);
            }
        }

        private void PrichodPostav()
        {
            foreach (var postav in Postavy)
            {
                postav.Presun();
            }
        }
    }
}
