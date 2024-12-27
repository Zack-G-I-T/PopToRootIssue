namespace ModalPopToRootIssue
{
    public partial class SixthPage : ContentPage
    {

        public SixthPage()
        {
            InitializeComponent();


        }


        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("SeventhPage");
        }
    }

}
