using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleApp.Models
{
    public class IndexModel
    {
        public string VehMake { get; set; }

        public List<SelectListItem> Makes { get; set; }

        public IndexModel()
        {
            Makes = new List<SelectListItem>();
        }
    }
}