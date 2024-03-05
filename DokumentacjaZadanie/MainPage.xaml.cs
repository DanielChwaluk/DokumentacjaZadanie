namespace DokumentacjaZadanie
{
    public partial class MainPage : ContentPage
    {
        class Liczby
        {
            private int a1;
            private int a2;
            private int suma;
            public Liczby(int b1, int b2)
            {
                a1 = b1;
                a2 = b2;
            }
            public Liczby()
            {
                a1 = 0;
                a2 = 0;
            }
            public int DodajLiczby(int b1, int b2)
            {
                suma = b1+ b2;
                return suma;
            }
            public void PokazLiczby()
            {
                return $"Liczba 1:{a1} Liczba 2: ";
            }
        }
        public MainPage()
        {
            InitializeComponent();
        }


    }
}