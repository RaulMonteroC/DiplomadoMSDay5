using System;
using System.Collections.Generic;
using Empleado.Models;

namespace Empleado.Data.SeedData
{
    public static class JobSeedData
    {
        public static List<Job> Seed()
        {
            var jobs = new List<Job>()
            {
                new Job
                {
                    Title = "Junior Xamarin Developer",
                    Description = "Junior Xamarin Developer wanted",
                    Company = "Megsoft Consulting",
                    Category = "Mobile Development",
                    IsRemote = true,
                    Location = "Santo Domingo",
                    VisitCount = 40
                },
                new Job
                {
                    Title = "Ruby backend developer",
                    Description = "Ruby backend developer with front-end experience wanted",
                    Company = "Generic Company 1",
                    Category = "Web Development",
                    IsRemote = false,
                    Location = "California",
                    VisitCount = 40
                },
                new Job
                {
                    Title = "Enterprise Java developer",
                    Description = "Enterprise java developer wanted",
                    Company = "Generic Company 2",
                    Category = "Web Development",
                    IsRemote = true,
                    Location = "Chile",
                    VisitCount = 40
                }
            };

			return jobs;
        }
    }
}
