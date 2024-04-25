
namespace Ct1300_AnimacePohyb.Pages
{
    public partial class Animace1
    {
        protected override void OnInitialized()
        {
            base.OnInitialized();
            InicializaceHry();
        }
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await Task.Run(Postava.Presun);
                StateHasChanged();
            }
            await base.OnAfterRenderAsync(firstRender);
        }
        public Models.Postava Postava { get; set; }

        private void InicializaceHry()
        {
            Postava = new Models.Postava(jmeno: "Maxipes", obrazek: "../img/maxipes.png",width: 150);
            Postava.PridejPozici(pozX: 45, pozY: 280, velikostObrazku: 70);
            Postava.PridejPozici(pozX: 450, pozY: 240, velikostObrazku: 40);
            Postava.PridejPozici(pozX: 840, pozY: 340, velikostObrazku: 80);
            Postava.PridejPozici(pozX: 110, pozY: 470, velikostObrazku: 100);

        }
    }
}
