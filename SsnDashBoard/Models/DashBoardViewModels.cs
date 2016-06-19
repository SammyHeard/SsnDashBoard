using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SsnDashBoard.Models
{
    public class CallViewModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Registrar name")]
        public string Registrar { get; set; }

        [DataType(DataType.Duration)]
        [Display(Name="Waiting")]
        public System.DateTimeOffset WaitingTime { get; }

        [DataType(DataType.DateTime)]
        [Display(Name = "PlacedTime")]
        public System.DateTime PlacedTime { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "StartTime")]
        public System.DateTime StartTime { get; set; }

        [DataType(DataType.Text)]
        [Display(Name ="Supervisor name")]
        public string Supervisor { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "EndTime")]
        public System.DateTime EndTime { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "SuspendTime")]
        public System.DateTime SuspendTime { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name ="Note")]
        public string Note { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Registrar location")]
        public string RegistrarLocation { get; set; }

        [DataType(DataType.Text)]
        [Display(Name ="Registrar GPS Location")]
        public string RegGPSLocation { get; set; }
    }

    public class ShiftViewModel
    {
        
    }
}