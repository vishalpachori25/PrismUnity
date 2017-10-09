using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;

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

        public MainPageViewModel(IPageDialogService _pageDialogService)
        {
            pageDialogService = _pageDialogService;
            ClickMeCommand = new DelegateCommand(ClickMeAction);
        }

        void ClickMeAction()
        {
            pageDialogService.DisplayAlertAsync("Button Clicked", "the message will come here", "OK");
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

