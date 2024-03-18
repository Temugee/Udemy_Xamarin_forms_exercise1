using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Xamarin_forms_ios_android_moshi
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            currentQuote.Text = quotes[i];
        }
        private int i = 0;
        private string[] quotes = new string[]
        {
            "Life is like riding a bicycle. To keep your balance, you must keep moving.",
            "You can't blame gravity for falling in love.",
            "Look deep into nature, and then you will understand everything better."
        };

        private void Button_Clicked(object sender, EventArgs e)
        {
            i++;
            if (i>= quotes.Length)
                i = 0;

            currentQuote.Text = quotes[i];
        }
    }
}
