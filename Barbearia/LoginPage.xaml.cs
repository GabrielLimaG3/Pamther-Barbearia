﻿using Barbearia.Pages;


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
                }
                else
                {
                    await DisplayAlert("Alerta", "Email ou Senha Errado", "Ok");
                }

            }
            catch
            {
                await DisplayAlert("Alerta", "Campo Vazio", "Ok");
            }

            

        }
    }

}