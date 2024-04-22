using AnimacePohyb.Models;

namespace AnimacePohyb.Pages
{
    public partial class Animace1
    {
        public Postava Postava { get; private set; }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            InicializaceHry();
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await Task.Run(()=>Postava.Presun());
                StateHasChanged();
            }
            await base.OnAfterRenderAsync(firstRender);
        }
        private void InicializaceHry()
        {
            Postava = new Postava(obrazek: "../img/maxipes.png", popisek: "Maxipes", 150);
            Postava.PridejPozici(pozX: 45, pozY: 280, velikostObrazku: 70);
            Postava.PridejPozici(pozX: 450, pozY: 240, velikostObrazku: 40);
            Postava.PridejPozici(pozX: 840, pozY: 340, velikostObrazku: 80);
            Postava.PridejPozici(pozX: 110, pozY: 470, velikostObrazku: 100);
        }
    }
}
