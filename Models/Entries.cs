using System.ComponentModel.DataAnnotations;

namespace EN.Web.Models
{
    public class Entries
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? SurnameId { get; set; }
        public string Surname { get; set; }
        public string ContactNumber { get; set; }
        public string EmailAddress { get; set; }
        public string CNIC { get; set; }
        public string Reference { get; set; }
        public int? ReferenceId { get; set; }
        public int? UnionCounsilId { get; set; }
        public string UnionCounsil { get; set; }
        public int? TalukaId { get; set; }
        public string Taluka { get; set; }
        public int? DistrictId { get; set; }
        public string District { get; set; }
        public int? DehId { get; set; }
        public string Deh { get; set; }
        public int? VillageId { get; set; }
        public string Village { get; set; }
        public int? CityId { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
    }
    public class Entries_ViewModel
    {
        public int Id { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only")]
        public string Name { get; set; }

        public int? SurnameId { get; set; }

        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only")]
        public string Surname { get; set; }

        public string ContactNumber { get; set; }

        public string EmailAddress { get; set; }

        public string CNIC { get; set; }

        public int? DistrictId { get; set; }
        public string District { get; set; }

        public int? TalukaId { get; set; }
        public string Taluka { get; set; }

        public int? UnionCounsilId { get; set; }
        public string UnionCouncil { get; set; }

        public int? DehId { get; set; }
        public string Deh { get; set; }

        public int? CityId { get; set; }
        public string City { get; set; }

        public int? VillageId { get; set; }

        public string Address { get; set; }

        public int? ReferenceId { get; set; }

        public bool IsAReference { get; set; }
        public string Village { get; set; }

        public bool IsDeleted { get; set; }
    }

    public class Entries_CreateViewModel
    {   
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int? SurnameId { get; set; }
        public string ContactNumber { get; set; }
        public string EmailAddress { get; set; }
        public string CNIC { get; set; }
        public string District { get; set; }
        public int? TalukaId { get; set; }
        public string Taluka { get; set; }
        public int? UnionCounsilId { get; set; }
        public string UnionCouncil { get; set; }
        public string Deh { get; set; }
        public int? CityId { get; set; }
        public string City { get; set; }
        public int? VillageId { get; set; }
        public string Village { get; set; }
        public string Address { get; set; }
        public int? ReferenceId { get; set; }
        public bool IsAReference { get; set; }
        public bool IsDeleted { get; set; }
    }
}
