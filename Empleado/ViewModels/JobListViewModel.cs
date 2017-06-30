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
using System.Collections.ObjectModel;

namespace Empleado.ViewModels
{
	public class JobListViewModel : BindableBase, INavigationAware
	{
		private ObservableCollection<JobListItemViewModel> _jobs;
        public ObservableCollection<JobListItemViewModel> Jobs
		{
			get { return _jobs; }
			set { SetProperty(ref _jobs, value); }
		}

        readonly INavigationService _navigationService;
        readonly AzureDataService _azureDataService;

		public JobListViewModel(INavigationService navigationService, AzureDataService azureDataService)
		{
            _navigationService = navigationService;

            _azureDataService = azureDataService;

        }

        public async Task LoadJobs()
        {
			await _azureDataService.Initialize();
            var jobData = await _azureDataService.GetJobs();

			Jobs = Jobs ?? new ObservableCollection<JobListItemViewModel>();

			foreach (var job in jobData)
			{
                Jobs.Add(new JobListItemViewModel(job, _navigationService));
			}
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
        }

		public async void OnNavigatedTo(NavigationParameters parameters)
        {
           	await LoadJobs();
        }
    }
}
