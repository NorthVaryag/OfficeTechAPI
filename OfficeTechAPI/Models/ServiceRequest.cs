using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace OfficeTechAPI.Models;

public class ServiceRequest
{
    [Key]
    public int id { get; set; }
    
    [StringLength(50)]
    public string deviceType { get; set; }
    
    [StringLength(50)]
    public string deviceModel { get; set; }
    
    [StringLength(250)]
    public string problemDescription { get; set; }
    
    [StringLength(100)]
    public string location { get; set; }
    
    [StringLength(50)]
    public string status { get; set; }
    
    [JsonPropertyName("created_at")]
    public string createdAt { get; set; }
}