using KonferansProje.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KonferansProje.DTO
{
    public class ConferenceDto
    {
        public int ConferenceId { get; set; }
        public konferans_tbl konferans_Tbl { get; set; }
        public katilimci_tbl katilimci_Tbl { get; set; }
        public SelectList DropDownList { get; set; }
    }
}