using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AljasMVCComputer2.Models
{
    public class ComputerSpecsViewModel
    {
        public List<Computer> Computers { get; set; }
        public SelectList Specs { get; set; }
        public string ComputerSpecs { get; set; }
        public string SearchString { get; set; }
    }
}