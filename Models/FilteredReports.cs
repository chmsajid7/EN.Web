using System.Collections.Generic;

namespace EN.Web.Models
{
    //Villae Wise Reports
    public class Village
    {
        public string taluka { get; set; }
        public string uc { get; set; }
        public string village { get; set; }
        public int totalPerson { get; set; }
    }
    public class VillageFilteredReports
    {
        public List<Village> villages { get; set; }
    }

    //List all talukas
    public class AllTaluka
    {
        public int id { get; set; }
        public string talukaName { get; set; }
        public object districtName { get; set; }
    }

    //List all UCs
    public class AllUCs
    {
        public int id { get; set; }
        public string talukaName { get; set; }
        public object districtName { get; set; }
    }

    //List all AllVillages
    public class AllVillages
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
