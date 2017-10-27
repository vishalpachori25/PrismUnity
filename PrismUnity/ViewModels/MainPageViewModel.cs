using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using PrismUnity.Services;

namespace PrismUnity.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        IPageDialogService pageDialogService;
        public DelegateCommand ClickMeCommand { get; set; }
        string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
        string fromPlatforms = "I don't know";
        public MainPageViewModel(INavigationService navigationService, IPageDialogService _pageDialogService, IDependancyServiceDemo dsDemo)
        {
            pageDialogService = _pageDialogService;
            ClickMeCommand = new DelegateCommand(ClickMeAction);
            fromPlatforms = dsDemo.PlatformName();
        }

        void ClickMeAction()
        {

            pageDialogService.DisplayAlertAsync("Button Clicked", "the message will come here from " + fromPlatforms, "OK");
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey("title"))
                Title = (string)parameters["title"] + " and Prism";
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {

        }
    }
}

