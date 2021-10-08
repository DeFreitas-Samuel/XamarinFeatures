using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Internals;

namespace XamarinFeatures.Services
{
    public interface IOrientationService
    {
        DeviceOrientation GetOrientation();
    }
}
