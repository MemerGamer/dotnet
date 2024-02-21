﻿namespace labor1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // 3.) LoginPage
            // MainPage = new LoginPage();

            // 4.) Form
            MainPage = new Form();

            UserAppTheme = PlatformAppTheme;
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);
            window.Title = "labor1";
            return window;
        }
    }
}