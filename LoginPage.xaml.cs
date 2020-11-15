using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.Xaml;

namespace PersonalHealthcareApplication
{


    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public string passwordState = "True";

        public LoginPage()
        {

            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            loginbutton.Clicked += Loginbutton_Clicked;
        }


        private void Loginbutton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Tabbed());

        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {

        }

        private void Button_Pressed(object sender, EventArgs e)
        {

        }
    }
}