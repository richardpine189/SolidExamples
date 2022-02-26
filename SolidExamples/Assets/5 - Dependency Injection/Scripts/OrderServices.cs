public class OrderServices
{
    public readonly IMailService _mailService;

    public OrderServices(IMailService mailService)
    {
        _mailService = mailService;
    }

    public void Create(Order order)
    {
        // TODO: código para crear la orden

        // Enviar notificación de la orden creada
        _mailService.Send();
    }
}
