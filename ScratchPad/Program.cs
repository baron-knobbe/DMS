
RunEmailManager();

void RunEmailManager()
{
    var mgr = new EmailAttachmentManager();
    mgr.SendEmail("Hello, World!");
}

class EmailAttachmentManager
{
    public void SendEmail(string message)
    {
        Console.WriteLine($"Sending email: {message}");
    }
}

