using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssessmentApplication.Models
{
    public class Project
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public double Duration { get; set; }

        public double Cost { get; set; }
    }
}
