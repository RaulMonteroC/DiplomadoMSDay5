using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;
using Empleado.Models;
using Empleado.Data.SeedData;
using Empleado.Services;
using System.Threading.Tasks;

namespace Empleado.ViewModels
{
	public class JobListViewModel : BindableBase, INavigationAware
	{
        public List<JobListItemViewModel> Jobs { get; set; }

        readonly INavigationService _navigationService;
        readonly AzureDataService _azureDataService;

		public JobListViewModel(INavigationService navigationService, AzureDataService azureDataService)
		{
            _navigationService = navigationService;

            _azureDataService = azureDataService;

            Task.Run(async () => await LoadJobs());
        }

        public async Task LoadJobs()
        {
            var jobData = await _azureDataService.GetJobs();

			Jobs = Jobs ?? new List<JobListItemViewModel>();

			foreach (var job in jobData)
			{
                Jobs.Add(new JobListItemViewModel(job, _navigationService));
			}
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            
        }
    }
}
