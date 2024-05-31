namespace Complementario055834157
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

       

        private void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            {
                //Obtendrá y validará los datos de la base y altura del triangulo
                if (double.TryParse(Base.Text, out double baseLength) && baseLength > 0 &&
                    double.TryParse(Altura.Text, out double height) && height > 0)
                { 
                    //Hará la ecuación matematica del los datos para identificar el perimetro y la superficie de un triangulo
                    double perimetro = 2 * (baseLength + height);
                    double area = baseLength * height;

                    //Mostrará los resultados del perimetro y superficie del triangulo
                    PerimetroResultado.Text = $"Perímetro: {perimetro}";
                    AreaResultado.Text = $"Superficie: {area}";
                }
               
            }

        }
    }

}
