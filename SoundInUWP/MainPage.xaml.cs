using System;
using Windows.Media.Core;
using Windows.Media.Playback;
using Windows.UI.Xaml;

namespace SoundInUWP
{
    public sealed partial class MainPage
    {
        private MediaPlayer _mediaPlayer = new MediaPlayer();

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnButtonMp3Click(object sender, RoutedEventArgs e)
        {
            Play("ms-appx:///closure.mp3");
        }

        private void OnButtonWavClick(object sender, RoutedEventArgs e)
        {
            Play("ms-appx:///matrix.wav");
        }

        private void Play(string fileName)
        {
            _mediaPlayer.Pause();
            _mediaPlayer.Source = MediaSource.CreateFromUri(new Uri($"{fileName}", UriKind.RelativeOrAbsolute));
            _mediaPlayer.Play();

            AudioInfo.Text = $"Playing {fileName}";
        }
    }
}
