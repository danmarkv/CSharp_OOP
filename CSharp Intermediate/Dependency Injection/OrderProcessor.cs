using CSharpIntermediate.Classes;

public class OrderProcessor
{
    private IEmailService _emailService;

    public OrderProcessor(IEmailService emailService)
    {
        _emailService = emailService;
    }

    public void ProcessOrder(Order order)
    {
        // process order...
        _emailService.SendConfirmation(order.CustomerEmail);
    }
}

public interface IEmailService
{
    void SendConfirmation(string email);
}

public class EmailService : IEmailService
{
    public void SendConfirmation(string email)
    {
        Console.WriteLine($"Sending email to {email}");
    }
}
