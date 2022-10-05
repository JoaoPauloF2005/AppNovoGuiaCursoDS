using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using AppNovoGuiaCursoDS.Models;
namespace AppNovoGuiaCursoDS.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ComponentesSegundo : ContentPage
    {
        public ComponentesSegundo()
        {
            InitializeComponent();
        }


        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Inglês Instrumental",

                    AtribuicoesResponsabilidades = "Comunicar-se em língua estrangeira - inglês, utilizando o vocabulário" +
                                                   "e a terminologia da área. ",

                    ValoresAtitudes = "Respeitar as manifestações culturais de outros povos. • Estimular a comunicação nas" +
                                      "relações interpessoais. • Socializar os saberes. "
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Desenvolvimento de Sistemas",

                    AtribuicoesResponsabilidades = "Analisar e projetar sistemas de informação, selecionando linguagens" +
                                                   "de programação e ambientes de desenvolvimento de acordo com as especifidades do" +
                                                   "projeto. • Codificar e depurar programas.",

                    ValoresAtitudes = "Fortalecer a persistência e o interesse na resolução de situações-problema. • Incentivar ações" +
                                      "que promovam a cooperação. • Desenvolver a criatividade. "
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }
    }
}