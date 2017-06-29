using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Empleado.Models;
using Empleado.Views;
using Prism.Commands;
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

        public DelegateCommand NavigateToDetailCommand { get; set; }

        readonly INavigationService _navigationService;

        public JobListItemViewModel(Job job, INavigationService navigationService)
        {
            Job = job;
            _navigationService = navigationService;

            SetupProperties();

            WireCommands();
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
            NavigateToDetailCommand = new DelegateCommand(async () => await NavigateToDetail());
        }

		private async Task NavigateToDetail()
		{
			await _navigationService.NavigateAsync(nameof(JobDetail), 
                                                   new NavigationParameters{{"Job", Job}});
		}
    }
}
