using Windows.UI.ViewManagement;

namespace SoftInput.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            LoadApplication(new SoftInput.App());
            _originalHeight = ApplicationView.GetForCurrentView().VisibleBounds.Height;

            InputPane.GetForCurrentView().Showing += MainPage_Showing;
            InputPane.GetForCurrentView().Hiding += MainPage_Hiding;
        }
        private double _originalHeight;
        private void MainPage_Hiding(InputPane sender, InputPaneVisibilityEventArgs args)
        {
            this.Height = _originalHeight;
            this.VerticalAlignment = Windows.UI.Xaml.VerticalAlignment.Stretch;
        }

        private void MainPage_Showing(InputPane sender, InputPaneVisibilityEventArgs args)
        {
            this.Height = _originalHeight - args.OccludedRect.Height;
            this.VerticalAlignment = Windows.UI.Xaml.VerticalAlignment.Top;
        }
    }
}
