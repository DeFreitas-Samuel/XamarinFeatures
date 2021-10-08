using Prism;
using Prism.Ioc;
using Prism.Unity;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFeatures.ViewModels;
using XamarinFeatures.Views;

namespace XamarinFeatures
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer platformInitializer): base(platformInitializer)
        {
            InitializeComponent();
        }
        
        protected override void OnInitialized()
        {
            NavigationService.NavigateAsync("/HomePage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<HomePage, HomeViewModel>();
        }
    }
}
