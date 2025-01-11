namespace PEESFPIV.Frontend.Models;

public class Partner: BaseModel
{
    public string VnName { get; set;} = "";
    public string EnName { get; set;} = "";
    public string Image { get;set;} = "";
    public int Order { get;set;}
}