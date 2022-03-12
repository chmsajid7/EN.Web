using System.Collections.Generic;

namespace EN.Web.Models
{
    //List all talukas
    public class AllTaluka
    {
        public int id { get; set; }
        public string talukaName { get; set; }
        public object districtName { get; set; }
    }



    //UC Wise Reports
    public class UC
    {
        public string talukaName { get; set; }
        public string uc { get; set; }
        public int totalPersons { get; set; }
    }
    public class UCFilteredReports
    {
        public List<UC> uCs { get; set; }
    }

    //Taluka Wise Reports
    public class Taluka
    {
        public string talukaName { get; set; }
        public string unionCounsils { get; set; }
        public int totalPersons { get; set; }
    }
    public class FilteredReports
    {
        public List<Taluka> talukas { get; set; }
    }
}
