using Newtonsoft.Json;
using System.Collections.Generic;

namespace EN.Web.Models
{
    public class Reports
    {
        [JsonProperty("reports")]
        public List<Report> ListReports { get; set; }
    }

    public partial class Report
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("taluka")]
        public string Taluka { get; set; }

        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("unionCounsils")]
        public List<UnionCounsil> UnionCounsils { get; set; }

        [JsonProperty("villages")]
        public List<UnionCounsil> Villages { get; set; }
    }

    public partial class UnionCounsil
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("unionCounsil", NullValueHandling = NullValueHandling.Ignore)]
        public string UnionCounsilUnionCounsil { get; set; }

        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("entries")]
        public List<Entry> Entries { get; set; }

        [JsonProperty("village", NullValueHandling = NullValueHandling.Ignore)]
        public string Village { get; set; }
    }

    public partial class Entry
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("contactNumber")]
        public string ContactNumber { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }
    }
}
