﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Sample.FolderArchitecture.View;

namespace Sample.FolderArchitecture
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new LoginPage();
        }
        protected override void OnStart()
        {
        }
        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
