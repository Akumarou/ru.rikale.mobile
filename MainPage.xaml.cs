namespace ru.rikale.mobile
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override bool OnBackButtonPressed()
        {

            return App.NeedToBlockBackButton ? true : base.OnBackButtonPressed();
        }

    }
}
