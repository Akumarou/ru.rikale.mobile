namespace ru.rikale.mobile
{
    public partial class App : Application
    {
        public static bool NeedToBlockBackButton { get; set; } = false;
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }
    }
}
