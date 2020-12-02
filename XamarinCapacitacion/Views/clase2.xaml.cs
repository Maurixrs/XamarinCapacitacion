using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinCapacitacion.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class clase2 : ContentPage
    {
        public clase2()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(entryNumero.Text))
            {
                DisplayAlert("Error", "Debe ingresar un Número", "Ok");
            }
            else
            {
                int number = int.Parse(entryNumero.Text);
                List<int> resultado = new List<int>();

                for (int i = 1; i <= number; i++)
                {
                    resultado.Add(i);
                }

                ListaResultado.ItemsSource = resultado;
            }
        }
    }
}