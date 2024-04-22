using AnimacePohyb.Models;

namespace AnimacePohyb.Pages
{
    public partial class Animace2
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
                await Task.Run(() => Prichod());
                StateHasChanged();
            }
            await base.OnAfterRenderAsync(firstRender);
        }
        private List<Postava> Postavy { get; set; } = new List<Postava>();

        private void InicializaceHry()
        {
            var postava = new Postava(obrazek: "../img/maxipes.png", popisek: "Maxipes", 150);
            postava.PridejPozici(pozX: 45, pozY: 280, velikostObrazku: 70);
            postava.PridejPozici(pozX: 450, pozY: 240, velikostObrazku: 40);
            postava.PridejPozici(pozX: 840, pozY: 340, velikostObrazku: 80);
            postava.PridejPozici(pozX: 110, pozY: 470, velikostObrazku: 100);

            Postavy.Add(postava);

            var rnd = new Random();
            var pocet = rnd.Next(6,12); // od 6 do 11

            for (int i = 0; i < pocet; i++)
            {
                postava = new Postava(obrazek: "../img/krtek.png", popisek: $"Krtek {i+1}", 100);
                for (int j = 0; j < rnd.Next(3,11); j++)
                {
                    postava.PridejPozici(pozX: rnd.Next(10,890), pozY: rnd.Next(250, 470), velikostObrazku: 100);
                }
                Postavy.Add(postava);
            }
        }
        private void Prichod()
        {
            foreach (var item in Postavy)
            {
                item.Presun();
            }
        }
    }
}
