namespace ModalPopToRootIssue
{
    public partial class FourthPage : ContentPage
    {

        public FourthPage()
        {
            InitializeComponent();


        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("FifthPage");
        }
    }

}
