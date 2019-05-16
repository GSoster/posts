using System;
using System.Threading;

namespace Delegates.VideoEncoder
{
    public class VideoEncoder
    {
        //1 - define delegate
        public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);//event handler in the subscribers

        //2 - define an event based on that delegate
        // it is the same as doing:
        // public event EventHandler<VideoEventArgs> VideoEncoded;
        //or
        // public event EventHandler VideoEncoded;
        public event VideoEncodedEventHandler VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(1000);
            OnVideoEncoded(video);
        }

        //3 - raise an event
        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
            {
                VideoEncoded(this, new VideoEventArgs() { Video = video });
            }
        }
    }
}