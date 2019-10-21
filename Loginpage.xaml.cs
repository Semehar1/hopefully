using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace hopefully
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Loginpage : ContentPage
    {
        public Loginpage()
        {
            InitializeComponent();
        }
        private void submit_Clicked(object sender, EventArgs e)
        {
            //here we get the value of both entries
            string name = username.Text;
            string pass = password.Text;
            //here we show the value of both variable in popup
            DisplayAlert("Entries value", name+ " " + pass, "ok");


        }
    }
}