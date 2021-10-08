using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinFeatures.Services;

namespace XamarinFeatures.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public HomeViewModel(INavigationService navigationService) : base(navigationService)
        {
            CheckPositionCommand = new DelegateCommand(CheckPosition);
        }

        private void CheckPosition()
        {
            var orientation = DependencyService.Get<IOrientationService>().GetOrientation();
            if (orientation == Xamarin.Forms.Internals.DeviceOrientation.Portrait)
            {
                PositionText = "Portrait Orientation";
            }
            else
            {
                PositionText = "Landscape Orientation";
            }
        }

        public ICommand CheckPositionCommand { get; }
        public string PositionText { get; set; }
    }
}
