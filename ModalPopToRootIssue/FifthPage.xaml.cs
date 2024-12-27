namespace ModalPopToRootIssue
{
    public partial class FifthPage : ContentPage
    {

        public FifthPage()
        {
            InitializeComponent();


        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("SixthPage");
        }
    }

}
