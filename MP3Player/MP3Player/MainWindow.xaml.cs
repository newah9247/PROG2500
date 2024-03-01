using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Microsoft.Win32;
using TagLib;

namespace MP3Player
{
    public partial class MainWindow : Window
    {
        private MediaPlayer mediaPlayer = new MediaPlayer();
        private string currentFilePath = "";

        public MainWindow()
        {
            InitializeComponent();
            mediaPlayer.Volume = volumeSlider.Value / 100.0; // Set initial volume
        }

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            if (currentFilePath != "")
            {
                mediaPlayer.Play();
            }
        }

        private void btnPause_Click(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Pause();
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Stop();
        }

        private void btnBrowse_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse MP3 Files",
                Filter = "MP3 files (*.mp3)|*.mp3",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            if (openFileDialog1.ShowDialog() == true)
            {
                currentFilePath = openFileDialog1.FileName;
                mediaPlayer.Open(new Uri(currentFilePath));

                // Retrieve metadata and display it
                var file = TagLib.File.Create(currentFilePath);
                txtTitle.Text = file.Tag.Title;
                txtArtist.Text = file.Tag.Artists.Length > 0 ? file.Tag.Artists[0] : "";

                // Set album art image
                DisplayAlbumArt(file.Tag);
            }
        }

        private void DisplayAlbumArt(TagLib.Tag tag)
        {
            if (tag.Pictures.Length > 0)
            {
                var picture = tag.Pictures[0];
                using (var memoryStream = new MemoryStream(picture.Data.Data))
                {
                    var bitmapImage = new BitmapImage();
                    bitmapImage.BeginInit();
                    bitmapImage.CacheOption = BitmapCacheOption.OnLoad; // Ensure the image is fully loaded before setting the source
                    bitmapImage.StreamSource = memoryStream;
                    bitmapImage.EndInit();
                    bitmapImage.Freeze(); // Freeze the image to prevent it from being modified on another thread
                    albumArtImage.Source = bitmapImage;
                }
            }
            else
            {
                // If no album art found, set a default placeholder image
                albumArtImage.Source = new BitmapImage(new Uri("pack://application:,,,/Resources/placeholder.jpg"));
            }
        }

        private void volumeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            mediaPlayer.Volume = volumeSlider.Value / 100.0;
        }

        private void btnSaveMetadata_Click(object sender, RoutedEventArgs e)
        {
            if (currentFilePath != "")
            {
                mediaPlayer.Stop();

                using (var file = TagLib.File.Create(currentFilePath))
                {
                    file.Tag.Title = txtTitle.Text;
                    file.Tag.Performers = new[] { txtArtist.Text };
                    file.Save();
                }
            }
        }
    }
}