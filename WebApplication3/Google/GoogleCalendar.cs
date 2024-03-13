namespace WebApplication3.Google;

public class GoogleCalendar
{
    private string id;
    private string summary;
    private string description;
    private string location;
    private string timeZone;

    public GoogleCalendar(string id, string summary, string description, string location, string timeZone)
    {
        this.id = id;
        this.summary = summary;
        this.description = description;
        this.location = location;
        this.timeZone = timeZone;
    }

    public string Id
    {
        get => id;
        set => id = value;
    }

    public string Summary
    {
        get => summary;
        set => summary = value;
    }

    public string Description
    {
        get => description;
        set => description = value;
    }

    public string Location
    {
        get => location;
        set => location = value;
    }

    public string TimeZone
    {
        get => timeZone;
        set => timeZone = value;
    }
}