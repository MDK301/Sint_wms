using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

public class StaffVM
{
    [Key]  // Đánh dấu thuộc tính này là khóa chính
    public int Id { get; set; }


    [JsonPropertyName("Name")]
    public string Name { get; set; }

    [JsonPropertyName("Position")]
    public string Position { get; set; }

    [JsonPropertyName("Office")]
    public string Office { get; set; }

    [JsonPropertyName("Age")]
    public String Age { get; set; }

    [JsonPropertyName("Startdate")]
    public string Startdate { get; set; }  

    [JsonPropertyName("Salary")]
    public string Salary { get; set; }
}
