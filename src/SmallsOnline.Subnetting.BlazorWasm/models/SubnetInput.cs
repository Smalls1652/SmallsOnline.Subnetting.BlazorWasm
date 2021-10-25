using System.ComponentModel.DataAnnotations;

namespace SmallsOnline.Subnetting.BlazorWasm.Models
{
    public class SubnetInput
    {
        [Required]
        public string SubnetString { get; set; }
    }
}
