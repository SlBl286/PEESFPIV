using BlazorBootstrap;

namespace PEESFPIV.Frontend.Models;

public class SystemFunction : NavItem{
    public new Guid Id { get;set;}

    public string Code {get;set;} = null!;
    
}