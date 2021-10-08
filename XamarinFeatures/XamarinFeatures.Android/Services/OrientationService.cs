using Android.Content;
using Android.Runtime;
using Android.Views;
using Xamarin.Forms.Internals;
using XamarinFeatures.Droid.Services;
using XamarinFeatures.Services;

[assembly: Xamarin.Forms.Dependency(typeof(OrientationService))]
namespace XamarinFeatures.Droid.Services
{
    public class OrientationService : IOrientationService
    {
        public DeviceOrientation GetOrientation()
        {
            IWindowManager windowManager = Android.App.Application.Context.GetSystemService(Context.WindowService).JavaCast<IWindowManager>();

            SurfaceOrientation orientation = windowManager.DefaultDisplay.Rotation;
            bool isLandscape = orientation == SurfaceOrientation.Rotation90 ||
            orientation == SurfaceOrientation.Rotation270;
            return isLandscape ? DeviceOrientation.Landscape : DeviceOrientation.Portrait;
        }
    }
}

