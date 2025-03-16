using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate.Interfaces.Polymorphism
{
    public class Video
    {

    }
    public class Message
    {

    }
    public class MailService()
    {
        public void Send(MailService mail)
        {
            Console.WriteLine("Sending mail...");
        }
    }

    public class VideoEncoder
    {
        private readonly IList<INotificationChannel> _notificationChannels;
        public VideoEncoder()
        {
            _notificationChannels = new List<INotificationChannel>();
        }

        public void Encode(Video video)
        {
            foreach (var channel in _notificationChannels)
                channel.Send(new Message());
        }
    }
}
