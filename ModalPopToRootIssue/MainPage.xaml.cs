using Microsoft.Maui.Controls.PlatformConfiguration;
using CommunityToolkit.Maui.Behaviors;
using CommunityToolkit.Maui.Core;
 using CommunityToolkit.Mvvm.Messaging;


namespace ModalPopToRootIssue
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("SecondPage");
        }



        private async void GoToLastPage(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("SecondPage");
            await Shell.Current.GoToAsync("ThirdPage");
            await Shell.Current.GoToAsync("FourthPage");
            await Shell.Current.GoToAsync("FifthPage");
            await Shell.Current.GoToAsync("SixthPage");
            await Shell.Current.GoToAsync("SeventhPage");
            await Shell.Current.GoToAsync("EighthPage");
            await Shell.Current.GoToAsync("NinthPage");
            await Shell.Current.GoToAsync("TenthPage");
        }

        private async void GoToLastPageNoAnimation(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("SecondPage", false);
            await Shell.Current.GoToAsync("ThirdPage", false);
            await Shell.Current.GoToAsync("FourthPage", false);
            await Shell.Current.GoToAsync("FifthPage", false);
            await Shell.Current.GoToAsync("SixthPage", false);
            await Shell.Current.GoToAsync("SeventhPage", false);
            await Shell.Current.GoToAsync("EighthPage", false);
            await Shell.Current.GoToAsync("NinthPage", false);
            await Shell.Current.GoToAsync("TenthPage", false);
        }
    }

}
