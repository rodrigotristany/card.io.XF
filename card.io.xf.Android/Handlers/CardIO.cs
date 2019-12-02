using System;
using Android.Content;
using card.io.xf.CardIOContract;
using IO.Card.Payment;
using Xamarin.Forms;

[assembly: Dependency(typeof(card.io.xf.Droid.Handlers.CardIO))]
namespace card.io.xf.Droid.Handlers
{
    public class CardIO : CardIOHandler
    {
        public static MainActivity MainActivity;

        public void StartScanning()
        {
            var intent = new Intent(MainActivity, typeof(CardIOActivity));
            intent.PutExtra(CardIOActivity.ExtraRequireExpiry, true);
            intent.PutExtra(CardIOActivity.ExtraRequireCvv, true);
            intent.PutExtra(CardIOActivity.ExtraRequirePostalCode, false);
            intent.PutExtra(CardIOActivity.ExtraUseCardioLogo, true);

            MainActivity.StartActivityForResult(intent, 101);
        }
    }
}
