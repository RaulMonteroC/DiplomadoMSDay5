﻿using Prism.Unity;
using Empleado.Views;

namespace Empleado
{
	public partial class App : PrismApplication
	{
		public App(IPlatformInitializer initializer = null) : base(initializer) { }

		protected override void OnInitialized()
		{
			InitializeComponent();

            NavigationService.NavigateAsync($"{nameof(NavContainer)}/{nameof(JobList)}");
		}

		protected override void RegisterTypes()
		{
            Container.RegisterTypeForNavigation<JobList>();
            Container.RegisterTypeForNavigation<JobDetail>();
            Container.RegisterTypeForNavigation<NavContainer>();
		}
	}
}

