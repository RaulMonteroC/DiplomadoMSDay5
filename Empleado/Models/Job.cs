using System;
namespace Empleado.Models
{
    public class Job
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public bool IsRemote { get; set; }
        public int VisitCount { get; set; }
        public string Category { get; set; }
        public string Company { get; set; }
    }
}
