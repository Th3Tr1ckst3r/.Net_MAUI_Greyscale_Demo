using Microsoft.Maui.Controls;
using System.Drawing;
using System.IO;
using System.Reflection;
using Color = System.Drawing.Color;

namespace ImageGrayscaleApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnConvertToGrayscaleClicked(object sender, EventArgs e)
        {
            // Load the image
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "ImageGrayscaleApp.Resources.Images.sample.png"; // Adjust path to your image
            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {
                if (stream == null)
                    return;

                // Load the image into a Bitmap
                using (Bitmap original = new Bitmap(stream))
                {
                    // Convert to grayscale
                    Bitmap grayscale = ConvertToGrayscale(original);

                    // Save the grayscale image to a MemoryStream
                    using (MemoryStream ms = new MemoryStream())
                    {
                        grayscale.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        ms.Seek(0, SeekOrigin.Begin);

                        // Display the image
                        imageView.Source = ImageSource.FromStream(() => ms);
                    }
                }
            }
        }

        private Bitmap ConvertToGrayscale(Bitmap original)
        {
            Bitmap grayscale = new Bitmap(original.Width, original.Height);

            for (int y = 0; y < original.Height; y++)
            {
                for (int x = 0; x < original.Width; x++)
                {
                    Color originalColor = original.GetPixel(x, y);
                    int grayScale = (int)((originalColor.R * 0.3) + (originalColor.G * 0.59) + (originalColor.B * 0.11));
                    Color grayColor = Color.FromArgb(originalColor.A, grayScale, grayScale, grayScale);
                    grayscale.SetPixel(x, y, grayColor);
                }
            }

            return grayscale;
        }
    }
}
