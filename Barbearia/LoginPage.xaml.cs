using Barbearia.Pages;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace Barbearia
{
    public partial class LoginPage : ContentPage
    {
  
        public LoginPage()
        {
            InitializeComponent();
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
               
                string entryemailuser = Entry_Email_User.Text.ToString();
                string entrysenha = Entry_Senha.Text.ToString();
                string user = "admin";
                string senha = "12345678";


                if ((entryemailuser == user) && (entrysenha == senha))
                { 
                    await Navigation.PushAsync(new MainPage());
                    await DisplayAlert("Alerta", $"campo ", "Ok");
                }
                else
                {
                    await DisplayAlert("Alerta", $"campo ", "Ok");
                }
            }
            catch
            {
                await DisplayAlert("Alerta", "Campo Vazio", "Ok");
            }
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RecuperaSenhaPage());
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CadastroPage());
        }
    }

}
