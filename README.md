# .Net_MAUI_Greyscale_Demo
Simple demonstration of image manipulation using C#, &amp; .Net MAUI.


To convert an image to grayscale in .NET MAUI using C# without relying on SkiaSharp, you can utilize the `System.Drawing` namespace, which provides essential GDI+ graphic functionality. Here's how you can achieve that:

1. **Setup .NET MAUI Project**  
   Make sure you have a .NET MAUI project set up. You can create one using the .NET CLI or Visual Studio.

2. **Add Necessary NuGet Packages**  
   Install the `System.Drawing.Common` package to use GDI+ functionalities.

3. **Code Implementation**  

   ### Step 1: Create a .NET MAUI Project  
   Use the .NET CLI to create a new MAUI project and navigate into the project directory.

   ### Step 2: Install System.Drawing.Common Package  
   Add the `System.Drawing.Common` package to your project using the .NET CLI.

   ### Step 3: Modify MainPage.xaml  
   Add an `Image` control and a `Button` to your XAML file to load and display the grayscale image.

   ### Step 4: Modify MainPage.xaml.cs  
   Implement the logic in your code-behind file to convert the image to grayscale. This involves loading the image, converting it to grayscale, and then displaying it.

   ### Step 5: Add Image Resource  
   Place your image file (e.g., `sample.png`) in the `Resources/Images` folder of your project. Update your project file to include this image.

   ### Step 6: Run the Project  
   Run your MAUI application. Clicking the "Convert to Grayscale" button will load the image, convert it to grayscale, and display the result.

This script sets up a simple MAUI app that processes an image to grayscale using the `System.Drawing` namespace. Adjust the resource paths as needed to match your project's structure.