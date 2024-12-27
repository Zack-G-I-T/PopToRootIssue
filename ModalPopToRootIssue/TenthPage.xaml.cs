namespace ModalPopToRootIssue
{
    public partial class TenthPage : ContentPage
    {

        public TenthPage()
        {
            InitializeComponent();


        }
        private async void PopAnimation(object sender, EventArgs e)
        {
            await Shell.Current.Navigation.PopToRootAsync();
        }

        private async void PopNoAnimation(object sender, EventArgs e)
        {
            await Shell.Current.Navigation.PopToRootAsync(false);
        }
    }

}
