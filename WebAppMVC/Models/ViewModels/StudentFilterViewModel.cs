namespace WebAppMVC.ViewModels;

public class StudentFilterViewModel
{
    public string? Search { get; set; }
    public string? Name { get; set; }
    public int? MinAge { get; set; }
    public int? MaxAge { get; set; }
    public List<StudentViewModel>? Students { get; set; } = new();
}