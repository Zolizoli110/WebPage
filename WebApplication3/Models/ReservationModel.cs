namespace WebApplication4.Models;

public partial class ReservationModel(
    string id,
    DateTime start,
    DateTime end,
    string title,
    UserModel author,
    string text)
{
    public string Id { get; } = id;

    public DateTime Start { get; } = start;

    public DateTime End { get; } = end;

    public string Title { get; } = title;

    public UserModel Author { get; } = author;

    public string Text { get; } = text;
}