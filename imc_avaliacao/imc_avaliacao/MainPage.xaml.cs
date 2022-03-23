using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace imc_avaliacao
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            double peso = Convert.ToDouble(txt_peso.Text);
            double altura = Convert.ToDouble(txt_altura.Text);

            double imc = peso / (altura * altura);

            texto_imc.Text = $"Seu IMC é de {imc.ToString("0.00")}";

            if (imc < 18.5)
            {
                tabela.Text = "Você está abaixo do peso !";
            }
            else if (imc >= 18.5 && imc < 25)
            {
                tabela.Text = "Você está com o peso normal !";
            }
            else if (imc >= 25 && imc < 30)
            {
                tabela.Text = "Você está sobrepeso !";
            }
            else if (imc >= 30 && imc < 35)
            {
                tabela.Text = "Você está com obesidade grau 1 !";
            }
            else if (imc >= 35 && imc < 40)
            {
                tabela.Text = "Você está com obesidade grau 2 !";
            }
            else
            {
                tabela.Text = "Você está com obesidade grau 3 !";
            }

            referencia.Text = "Menor que 18,5->Abaixo do peso\nEntre 18,5 e 24,9->Peso normal\nEntre 25 e 29,9->Sobrepeso\nEntre 30 e 34,9->Obesidade grau 1\nEntre 35 e 39,9->Obesidade grau 2\nMaior que 40->Obesidade grau 3";


        }
    }
}
