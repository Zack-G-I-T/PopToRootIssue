namespace ModalPopToRootIssue
{
    public partial class SeventhPage : ContentPage
    {

        public SeventhPage()
        {
            InitializeComponent();


        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("EighthPage");
        }
    }

}
