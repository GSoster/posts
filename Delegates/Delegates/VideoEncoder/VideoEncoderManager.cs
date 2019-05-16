namespace Delegates.VideoEncoder
{
    public static class VideoEncoderManager
    {
        public static void EncodeVideos()
        {
            var video = new Video() { Title = "Video 1" };
            var videoEncoder = new VideoEncoder(); // publisher
            var mailService = new MailService();//subscriber

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;

            videoEncoder.Encode(video);
        }
    }
}