namespace PEESFPIV.Frontend.States;

public class SidebarState
{
    public bool IsOpen { get; set; } = false;

    public event Action OnChange;
    public void Open(){
        IsOpen = true;
    }

    public void Close(){
        IsOpen = false;
    }

    public void Toggle(){
        IsOpen = !IsOpen;
        NotifyStateChange();

    }

    private void NotifyStateChange()=>  OnChange?.Invoke();

}