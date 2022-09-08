using biblioteca_3_1.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace biblioteca_3_1.ViewModels
{
    public class RegisterViewModel : BaseViewModel
    {
        public Command LoginCommand { get; }
        //public Command RegisterCommand { get; }

        public RegisterViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
        }

        private async void OnLoginClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }
    }
}
