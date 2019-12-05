using System;
using card.io.xf.CardIOContract;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(card.io.xf.iOS.Handlers.CardIO))]
namespace card.io.xf.iOS.Handlers
{
    public class CardIO : CardIOHandler
    {
        UIWindow window;
        UINavigationController navController;
        MainViewController mainViewController;

        public void StartScanning()
        {
            window = new UIWindow(UIScreen.MainScreen.Bounds);

            // If you have defined a root view controller, set it here:
            mainViewController = new MainViewController();
            navController = new UINavigationController(mainViewController);

            window.RootViewController = navController;

            // make the window visible
            window.MakeKeyAndVisible();
        }
    }
}
