using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Clockopedia.Models
{
    public class ClocksCategoryViewModel
    {
        public List<Clock> Clocks { get; set; }
        public SelectList Categorys { get; set; }
        public string ClockCategory { get; set; }
        public string SearchString { get; set; }
    }
}