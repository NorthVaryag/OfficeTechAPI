using System.ComponentModel.DataAnnotations;

namespace OfficeTechAPI.Models;

public class NewRequestDto
{
    [StringLength(50)]
    public string deviceType { get; set; }
    
    [StringLength(75)]
    public string deviceModel { get; set; }
    
    [StringLength(175)]
    public string problemDescription { get; set; }
    
    [StringLength(175)]
    public string location { get; set; }
}