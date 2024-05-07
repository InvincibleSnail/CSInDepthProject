namespace CSInDepthProject.ChapterTwo;

public class DelegateDemo
{
    static void HandleDemoEvent(object sender, EventArgs s)
    {
        Console.WriteLine("Handle by HandleDemoEvent");
    }
    
    private EventHandler handler = new EventHandler(HandleDemoEvent);
}