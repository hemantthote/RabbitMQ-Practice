namespace Contracts;

public class ErrorCreated{
    public int Id { get; set; }
    public string Message { get; set; }
    public string StackTrace { get; set; }
    public int UserId { get; set; }
    public int AppId { get; set; }
    public int AppAccountId { get; set; }   
}