using Microsoft.UI.Xaml.Controls;

namespace UnoControlSizeBugRepo
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Btn_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
        {
            Info.Children.Clear();
            Info.Children.Add(new TextBlock() { Text = $"GridOfInterest: {GridOfInterest.ActualHeight} {GridOfInterest.ActualWidth}" });
            Info.Children.Add(new TextBlock() { Text = $"InnerText: {InnerText.ActualHeight} {InnerText.ActualWidth}" });
        }
    }
}
