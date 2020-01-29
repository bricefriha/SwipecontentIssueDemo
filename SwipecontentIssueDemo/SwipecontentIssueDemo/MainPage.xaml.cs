using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SwipecontentIssueDemo
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnTest_Clicked(object sender, EventArgs e)
        {
            // Send a display alerte to my god
            DisplayAlert("From Brice:", "Congrat!! you fix my issue, can I hug you?","YAAAA!");
        }
    }
}
