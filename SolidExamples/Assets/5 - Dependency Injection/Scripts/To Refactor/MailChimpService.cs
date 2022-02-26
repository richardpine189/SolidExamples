using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MailChimpServices
{
    public void Send()
    {
        // TODO: c�digo para enviar el correo
    }
}

public class OrderService
{
    public readonly MailChimpServices _mailService;

    public OrderService(MailChimpServices mailService)
    {
        _mailService = mailService;
    }

    public void Create(Order order)
    {
        // TODO: c�digo para crear la orden

        // Enviar notificaci�n de la orden creada
        _mailService.Send();
    }
}

public class Order
{

}
