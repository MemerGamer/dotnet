﻿namespace Bozsi
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("csiguszz", typeof(ColorPage));
        }
    }
}
