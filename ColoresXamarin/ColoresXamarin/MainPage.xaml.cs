using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ColoresXamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Btn_Calcula_Clicked(object sender, EventArgs e)
        {
            ColoresCambio();
        }
        public void ColoresCambio()
        {
            string color = PickerColor.SelectedItem.ToString();
            switch (color)
            {
                case "Azul":
                    btn_Calcula.BackgroundColor=Color.Blue;
                    btn_Calcula.TextColor = Color.Black;
                    btn_C3.IsVisible = true;
                    btn_C1.BackgroundColor = Color.Blue;
                    btn_C2.BackgroundColor = Color.Blue;
                    btn_C3.BackgroundColor = Color.Blue;
                    break;
                case "Rojo":
                    btn_Calcula.BackgroundColor = Color.Red;
                    btn_Calcula.TextColor = Color.Black;
                    btn_C3.IsVisible = true;
                    btn_C1.BackgroundColor = Color.Red;
                    btn_C2.BackgroundColor = Color.Red;
                    btn_C3.BackgroundColor = Color.Red;
                    break;
                case "Amarillo":
                    btn_Calcula.BackgroundColor = Color.Yellow;
                    btn_Calcula.TextColor = Color.Black;
                    btn_C3.IsVisible = true;
                    btn_C1.BackgroundColor = Color.Yellow;
                    btn_C2.BackgroundColor = Color.Yellow;
                    btn_C3.BackgroundColor = Color.Yellow;
                    break;
                case "Verde":
                    btn_Calcula.BackgroundColor = Color.Green;
                    btn_Calcula.TextColor = Color.Black;
                    btn_C3.IsVisible = false;
                    btn_C1.BackgroundColor = Color.Blue;
                    btn_C2.BackgroundColor = Color.Yellow;
                    btn_C3.BackgroundColor = Color.Green;
                    break;
                case "Naranja":
                    btn_Calcula.BackgroundColor = Color.Orange;
                    btn_Calcula.TextColor = Color.Black;
                    btn_C3.IsVisible = false;
                    btn_C1.BackgroundColor = Color.Red;
                    btn_C2.BackgroundColor = Color.Yellow;
                    btn_C3.BackgroundColor = Color.Orange;
                    break;
                case "Magenta":
                    btn_Calcula.BackgroundColor = Color.Magenta;
                    btn_Calcula.TextColor = Color.Black;
                    btn_C3.IsVisible = false;
                    btn_C1.BackgroundColor = Color.Blue;
                    btn_C2.BackgroundColor = Color.Red;
                    btn_C3.BackgroundColor = Color.Magenta;
                    break;
                case "Cian":
                    btn_Calcula.BackgroundColor = Color.Cyan;
                    btn_Calcula.TextColor = Color.Black;
                    btn_C3.IsVisible = false;
                    btn_C1.BackgroundColor = Color.Blue;
                    btn_C2.BackgroundColor = Color.Green;
                    btn_C3.BackgroundColor = Color.Cyan;
                    break;
                case "Negro":
                    btn_Calcula.BackgroundColor = Color.Black;
                    btn_Calcula.TextColor = Color.White;
                    btn_C3.IsVisible = true;
                    btn_C1.BackgroundColor = Color.Cyan;
                    btn_C2.BackgroundColor = Color.Magenta;
                    btn_C3.BackgroundColor = Color.Yellow;
                    break;
                case "Blanco":
                    btn_Calcula.BackgroundColor = Color.White;
                    btn_Calcula.TextColor = Color.Black;
                    btn_C3.IsVisible = true;
                    btn_C1.BackgroundColor = Color.Red;
                    btn_C2.BackgroundColor = Color.Green;
                    btn_C3.BackgroundColor = Color.Blue;
                    break;
                default:
                    break;
            }
        }
    }
}
