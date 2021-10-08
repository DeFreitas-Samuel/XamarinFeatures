using UIKit;
using Xamarin.Forms.Internals;
using XamarinFeatures.iOS.Services;
using XamarinFeatures.Services;

[assembly: Xamarin.Forms.Dependency(typeof(OrientationService))]
namespace XamarinFeatures.iOS.Services
{

    public class OrientationService : IOrientationService
    {
        public DeviceOrientation GetOrientation()
        {
            UIInterfaceOrientation orientation = UIApplication.SharedApplication.StatusBarOrientation;

            bool isPortrait = orientation == UIInterfaceOrientation.Portrait ||
            orientation == UIInterfaceOrientation.PortraitUpsideDown;
            return isPortrait ? DeviceOrientation.Portrait : DeviceOrientation.Landscape;
        }
    }
    
}