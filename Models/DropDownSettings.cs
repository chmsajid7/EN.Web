using System.ComponentModel.DataAnnotations;

namespace EN.Web.Models
{
    public class DropDownSettings
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter Surname")]
        public string SurnameName { get; set; }
    }
    public class DropDownSettings_UC
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter Union Council")]
        public string UnionCounsilName { get; set; }
    }
    public class DropDownSettings_Village
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter Village")]
        public string VillageName { get; set; }
    }
    public class DropDownSettings_City
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter City")]
        public string CityName { get; set; }
    }
    public class DropDownSettings_Taluka
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter Taluka")]
        public string TalukaName { get; set; }
    }

    //public class DropDownSettings_ViewModel
    //{
    //    public int Id { get; set; }
    //    [Required]
    //    public string SurnameName { get; set; }
    //}
}
