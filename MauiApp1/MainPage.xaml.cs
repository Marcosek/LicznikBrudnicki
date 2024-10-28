namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        int licz = 0;
        int kolejnyLicznik = 2; 

        public MainPage()
        {
            InitializeComponent();
        }

        private void PlusKlikniety(object sender, EventArgs e)
        {
            licz++;
            Licznik.Text = $"{licz}";
        }

        private void MinusKlikniety(object sender, EventArgs e)
        {
            licz--;
            Licznik.Text = $"{licz}";
        }

        private void DodajLicznikKlikniety(object sender, EventArgs e)
        {

            var licznikLayout = new VerticalStackLayout { Spacing = 10 };

 
            var nazwaLabel = new Label
            {
                Text = $"Licznik {kolejnyLicznik++}",
                FontSize = 18,
                HorizontalOptions = LayoutOptions.Center
            };

            var licznikLabel = new Label
            {
                Text = "0",
                FontSize = 18,
                HorizontalOptions = LayoutOptions.Center
            };

            var plusPrzycisk = new Button { Text = "+" };
            plusPrzycisk.Clicked += (s, args) =>
            {
                int value = int.Parse(licznikLabel.Text);
                licznikLabel.Text = $"{++value}";
            };

            var minusPrzycisk = new Button { Text = "-" };
            minusPrzycisk.Clicked += (s, args) =>
            {
                int value = int.Parse(licznikLabel.Text);
                licznikLabel.Text = $"{--value}";
            };

            licznikLayout.Children.Add(nazwaLabel);
            licznikLayout.Children.Add(licznikLabel);
            licznikLayout.Children.Add(plusPrzycisk);
            licznikLayout.Children.Add(minusPrzycisk);

            MainLayout.Children.Add(licznikLayout);
        }
    }
}