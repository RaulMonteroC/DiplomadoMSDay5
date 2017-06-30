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
        public JobListItemViewModel()
        {

        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
        }

        private void SetupProperties()
        {
        }

        private void WireCommands()
        {

        }

		private async Task NavigateToDetail()
		{

		}
    }
}
