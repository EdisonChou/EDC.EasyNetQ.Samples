﻿using EasyNetQ.AutoSubscribe;
using EDC.DNC.MSAD.Messages;
using System.Threading.Tasks;

namespace EDC.DNC.MSAD.NB.NoticeService.Models
{
    public class ClientMessageConsumer: IConsumeAsync<ClientMessage>
    {
        [AutoSubscriberConsumer(SubscriptionId = "ClientMessageService.Notice")]
        public Task ConsumeAsync(ClientMessage message)
        {
            // Your business logic code here
            // eg.Build one email to client via SMTP service
            // Sample console code
            System.Console.ForegroundColor = System.ConsoleColor.Red;
            System.Console.WriteLine("Consume one message from RabbitMQ : {0}, I will send one email to client.", message.ClientName);
            System.Console.ResetColor();

            return Task.CompletedTask;
        }
    }
}
