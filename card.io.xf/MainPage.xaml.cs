using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace card.io.xf
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            MessagingCenter.Subscribe<Xamarin.Forms.Application, string>(App.Current, "CCNumber", (sender, arg) =>
            {
                this.lblCCNumber.Text = arg;
            });
        }

        private void startScanning(object sender, EventArgs args)
        {
            DependencyService.Get<CardIOContract.CardIOHandler>().StartScanning();
        }
    }
}
