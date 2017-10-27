using System;
using PrismUnity.Droid.Services;
using PrismUnity.Services;
using Xamarin.Forms;

[assembly: Dependency(typeof(DependancyService_Android))]
namespace PrismUnity.Droid.Services
{
    public class DependancyService_Android : IDependancyServiceDemo
    {


        public string PlatformName()
        {
            return "its Android";
        }
    }
}
