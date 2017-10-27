using System;
using PrismUnity.iOS.Services;
using PrismUnity.Services;
using Xamarin.Forms;

[assembly: Dependency(typeof(DependancyService_IOS))]
namespace PrismUnity.iOS.Services
{
    public class DependancyService_IOS : IDependancyServiceDemo
    {
        public string PlatformName()
        {
            return "Its iOS....";
        }
    }
}
