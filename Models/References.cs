namespace EN.Web.Models
{
    public class References
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? SurnameId { get; set; }
        public string Surname { get; set; }
        public string ContactNumber { get; set; }
        public string CNIC { get; set; }
        public string ReferencedBy { get; set; }
        public int Recommended { get; set; }
        public int? ReferenceId { get; set; }
        public int? UnionCounsilId { get; set; }
        public string UnionCounsil { get; set; }
        public int? TalukaId { get; set; }
        public string Taluka { get; set; }
        public string District { get; set; }
        public string Deh { get; set; }
        public int? VillageId { get; set; }
        public string Village { get; set; }
        public int? CityId { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
    }
}
