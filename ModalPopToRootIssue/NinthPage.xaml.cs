namespace ModalPopToRootIssue
{
    public partial class NinthPage : ContentPage
    {

        public NinthPage()
        {
            InitializeComponent();


        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("TenthPage");
        }
    }

}
