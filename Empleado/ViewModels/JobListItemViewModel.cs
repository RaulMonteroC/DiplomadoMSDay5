using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Empleado.Models;
using Empleado.Views;
using Prism.Mvvm;
using Prism.Navigation;
using Xamarin.Forms;

namespace Empleado.ViewModels
{
    public class JobListItemViewModel: BindableBase, INavigationAware
    {
        public Job Job { get; set; }
        public string CompanyAndCategory { get; set; }
        public string RemoteText { get; set; }

        public ICommand NavigateToDetailCommand { get; set; }

        readonly INavigationService _navigationService;

        public JobListItemViewModel(Job job, INavigationService navigationService)
        {
            Job = job;
            _navigationService = navigationService;

            SetupProperties();

            WireCommands();
        }

        public async Task NavigateToDetail()
        {       		
            var navParameters = new NavigationParameters()
            {
                {"Job", Job}
            };

            await _navigationService.NavigateAsync($"{nameof(NavContainer)}/{nameof(JobDetail)}", navParameters);
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
        }

        private void SetupProperties()
        {
			CompanyAndCategory = $"{Job.Company} | {Job.Category}";
			RemoteText = Job.IsRemote ? "Remote" : "";            
        }

        private void WireCommands()
        {
            NavigateToDetailCommand = new Command(async () => await NavigateToDetail());
        }
    }
}
