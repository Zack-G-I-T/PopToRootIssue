namespace ModalPopToRootIssue
{
    public partial class ThirdPage : ContentPage
    {

        public ThirdPage()
        {
            InitializeComponent();


        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("FourthPage");
        }
    }

}
