
namespace basics_of_c_sharp.DesignPatterns.Adapter;

// target interface
public interface IMediaPlayer
{
   void Play(string audioType,string fileName);
}

public class AudioPlayer : IMediaPlayer
{
    public void Play(string audioType, string fileName)
    {
        if (audioType == "mp3")
        {
            Console.WriteLine($"Playing mp3 file. Name: {fileName}");
        }
        else
        {
            Console.WriteLine("Unsupported Audio type");
        }
    }
}

    // We have a VideoPlayer interface that can play media files in .mp4 format.

    // Adaptee interface
    public interface IVideoPlayer
    {
        void PlayVideo(string fileName);
    }

    public class Mp4Player : IVideoPlayer
    {
        public void PlayVideo(string fileName)
        {
            Console.WriteLine($"Playing mp4 file. Name: {fileName}");
        }
    }

    /** 
     * Adapter
     * We create a MediaAdapter class that implements the IMediaPlayer interface and has a VideoPlayer object as its instance variable.
     **/

    public class MediaAdapter : IMediaPlayer
    {
        private readonly IVideoPlayer _videoPlayer;

        public MediaAdapter(IVideoPlayer videoPlayer)
        {
            _videoPlayer = videoPlayer;
        }
        public void Play(string audioType, string fileName)
        {
            if (audioType == "mp4")
            {
                _videoPlayer.PlayVideo(fileName);
            }
            else
            {
                Console.WriteLine("Unsupported audio type");
            }
        }
    }

public class MediaPlayerTestDrive
{
    public static void Main()
    {
        // playing music with media player
        Console.WriteLine("Playing audio in media player");
        IMediaPlayer audioPlayer = new AudioPlayer();
        PlayMedia(audioPlayer, "audio1.mp3", "mp3");


        // playing video with video player
        Console.WriteLine("\nPlaying video in video player");

        IVideoPlayer videoPlayer = new Mp4Player();
        videoPlayer.PlayVideo("video1.mp4");

        // playing video as mp4 audio with media player
        Console.WriteLine("\nPlaying mp4 file in media player");

        IMediaPlayer mp4Player = new MediaAdapter(new Mp4Player());
        PlayMedia(mp4Player, "file2.mp4", "mp4");

    }

    private static void PlayMedia(IMediaPlayer mediaPlayer, string fileName, string fileType)
    {
        mediaPlayer.Play( fileType, fileName);
    }
}
