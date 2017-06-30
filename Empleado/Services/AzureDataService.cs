using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Empleado.Models;
using Microsoft.WindowsAzure.MobileServices;
using Microsoft.WindowsAzure.MobileServices.SQLiteStore;
using Microsoft.WindowsAzure.MobileServices.Sync;


namespace Empleado.Services
{
    public class AzureDataService
    {
		public MobileServiceClient MobileService { get; set; }
		
        IMobileServiceSyncTable<Job> JobsTable;

        public async Task Initialize()
        {
			//Create our client
            MobileService = new MobileServiceClient("http://empleadomobile.azurewebsites.net");

			const string path = "syncstore.db";

			//setup our local sqlite store and intialize our table
			var store = new MobileServiceSQLiteStore(path);
            store.DefineTable<Job>();
			await MobileService.SyncContext.InitializeAsync(store, new MobileServiceSyncHandler());

			//Get our sync table that will call out to azure
			JobsTable = MobileService.GetSyncTable<Job>();
        }
        
        public async Task<IEnumerable<Job>> GetJobs()
        {
            await SyncJobs();

            return await JobsTable.ToEnumerableAsync();
        }

        public async Task SyncJobs()
        {
			//pull down all latest changes and then push current coffees up
            await JobsTable.PullAsync("allJobs", JobsTable.CreateQuery());
			await MobileService.SyncContext.PushAsync();            
        }
    }
}

