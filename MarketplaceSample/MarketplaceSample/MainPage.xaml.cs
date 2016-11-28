using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

//
// Launch the Windows Store App Sample
// see the complete ms-windows-store: URI scheme reference from
// https://msdn.microsoft.com/en-us/windows/uwp/launch-resume/launch-store-app
//

namespace MarketplaceSample
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void Button_Click_PDP(object sender, RoutedEventArgs e)
        {
            // URI for Product Detail Page
            // TODO: change ProductId current value with your own product id
            var uri = new Uri(@"ms-windows-store://pdp/?ProductId=9WZDNCRFHVJL");
            var success = await Windows.System.Launcher.LaunchUriAsync(uri);
        }

        private async void Button_Click_WriteReview(object sender, RoutedEventArgs e)
        {
            // URI for Write a Review Page
            // TODO: change ProductId current value with your own product id
            var uri = new Uri(@"ms-windows-store://review/?ProductId=9WZDNCRFHVJL");
            var success = await Windows.System.Launcher.LaunchUriAsync(uri);
        }

        private async void Button_Click_PublisherProducts(object sender, RoutedEventArgs e)
        {
            // URI for Publisher's Product Page
            // TODO: change name current value with your own company name
            var uri = new Uri(@"ms-windows-store://publisher/?name=Microsoft Corporation");
            var success = await Windows.System.Launcher.LaunchUriAsync(uri);
        }
    }
}
