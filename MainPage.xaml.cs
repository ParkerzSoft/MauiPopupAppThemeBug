using CommunityToolkit.Maui.Views ;

namespace MauiPopupAppTheme
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
        InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            this.ShowPopupAsync ( new Views.DemoPopup() ) ;
        }

        private void OnChangeTheme(object sender, EventArgs e)
        {
            if ( ((App)App.Current).UserAppTheme == AppTheme.Dark )
                ((App)App.Current).UserAppTheme = AppTheme.Light ;
            else
                ((App)App.Current).UserAppTheme = AppTheme.Dark ;
        }
    }

}
