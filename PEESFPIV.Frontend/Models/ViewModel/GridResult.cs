namespace PEESFPIV.Frontend.Models.ViewModel;

public class GridResult<T>  where T : class
{
    public int Total { get; set; }

    public List<T> Values{ get; set; } = new List<T>();
}