public class EmailSenderOptions
{
    public string SMTPServer { get; set; }
    public int SMTPPort { get; set; }
    public string SMTPUser { get; set; }
    public string SMTPPassword { get; set; }
    public string FromEmail { get; set; }
    public string FromName { get; set; }
}