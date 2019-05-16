using System;

namespace Delegates.VideoEncoder
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine($"MailService: Sending and email...{e.Video.Title}");
        }
    }
}