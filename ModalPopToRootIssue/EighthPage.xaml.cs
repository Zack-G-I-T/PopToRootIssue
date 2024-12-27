namespace ModalPopToRootIssue
{
    public partial class EighthPage : ContentPage
    {

        public EighthPage()
        {
            InitializeComponent();


        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("NinthPage");
        }
    }

}
