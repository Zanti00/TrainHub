using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace TrainHub.Static_Classes
{
    public static class ImageFileManager
    {
        private static readonly string BaseImageDirectory = Path.Combine(Application.StartupPath, "MemberImages");

        static ImageFileManager()
        {
            // Ensure the base directory exists
            if (!Directory.Exists(BaseImageDirectory))
            {
                Directory.CreateDirectory(BaseImageDirectory);
            }
        }

        /// <summary>
        /// Save captured image to file system
        /// </summary>
        /// <param name="image">The image to save</param>
        /// <param name="memberId">Member ID for filename</param>
        /// <param name="memberEmail">Member email for folder organization (optional)</param>
        /// <returns>The file path where image was saved</returns>
        public static string SaveMemberImage(Bitmap image, int memberId, string memberEmail = null)
        {
            if (image == null)
                throw new ArgumentNullException(nameof(image));

            try
            {
                // Create subfolder structure (optional - you can use just BaseImageDirectory)
                string yearFolder = Path.Combine(BaseImageDirectory, DateTime.Now.Year.ToString());
                if (!Directory.Exists(yearFolder))
                {
                    Directory.CreateDirectory(yearFolder);
                }

                // Generate unique filename
                string fileName = $"member_{memberId}_{DateTime.Now:yyyyMMdd_HHmmss}.jpg";
                string fullPath = Path.Combine(yearFolder, fileName);

                // Resize image if too large (optional - for storage optimization)
                using (Bitmap resizedImage = ResizeImageIfNeeded(image, 800, 600))
                {
                    // Save as JPEG with good quality
                    ImageCodecInfo jpegCodec = GetEncoderInfo("image/jpeg");
                    EncoderParameters encoderParams = new EncoderParameters(1);
                    encoderParams.Param[0] = new EncoderParameter(Encoder.Quality, 85L); // 85% quality

                    resizedImage.Save(fullPath, jpegCodec, encoderParams);
                    encoderParams.Dispose();
                }

                return fullPath;
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to save member image: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Load member image from file path
        /// </summary>
        /// <param name="filePath">Path to the image file</param>
        /// <returns>Bitmap image or null if not found</returns>
        public static Bitmap LoadMemberImage(string filePath)
        {
            if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath))
                return null;

            try
            {
                // Create a copy of the image to avoid file locking issues
                using (var originalImage = new Bitmap(filePath))
                {
                    return new Bitmap(originalImage);
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Delete member image file
        /// </summary>
        /// <param name="filePath">Path to the image file</param>
        /// <returns>True if deleted successfully</returns>
        public static bool DeleteMemberImage(string filePath)
        {
            if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath))
                return false;

            try
            {
                File.Delete(filePath);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Get relative path for database storage
        /// </summary>
        /// <param name="fullPath">Full file path</param>
        /// <returns>Relative path from base directory</returns>
        public static string GetRelativePath(string fullPath)
        {
            if (string.IsNullOrEmpty(fullPath))
                return null;

            return Path.GetRelativePath(BaseImageDirectory, fullPath);
        }

        /// <summary>
        /// Get full path from relative path
        /// </summary>
        /// <param name="relativePath">Relative path from database</param>
        /// <returns>Full file path</returns>
        public static string GetFullPath(string relativePath)
        {
            if (string.IsNullOrEmpty(relativePath))
                return null;

            return Path.Combine(BaseImageDirectory, relativePath);
        }

        /// <summary>
        /// Resize image if it exceeds maximum dimensions
        /// </summary>
        private static Bitmap ResizeImageIfNeeded(Bitmap original, int maxWidth, int maxHeight)
        {
            if (original.Width <= maxWidth && original.Height <= maxHeight)
            {
                return new Bitmap(original);
            }

            // Calculate new dimensions maintaining aspect ratio
            float ratioX = (float)maxWidth / original.Width;
            float ratioY = (float)maxHeight / original.Height;
            float ratio = Math.Min(ratioX, ratioY);

            int newWidth = (int)(original.Width * ratio);
            int newHeight = (int)(original.Height * ratio);

            Bitmap resized = new Bitmap(newWidth, newHeight);
            using (Graphics graphics = Graphics.FromImage(resized))
            {
                graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                graphics.DrawImage(original, 0, 0, newWidth, newHeight);
            }

            return resized;
        }

        /// <summary>
        /// Get JPEG encoder info
        /// </summary>
        private static ImageCodecInfo GetEncoderInfo(string mimeType)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.MimeType == mimeType)
                    return codec;
            }
            return null;
        }

        /// <summary>
        /// Clean up old image files (optional maintenance method)
        /// </summary>
        /// <param name="daysOldToDelete">Delete files older than this many days</param>
        public static void CleanupOldImages(int daysOldToDelete = 365)
        {
            try
            {
                DateTime cutoffDate = DateTime.Now.AddDays(-daysOldToDelete);
                string[] imageFiles = Directory.GetFiles(BaseImageDirectory, "*.jpg", SearchOption.AllDirectories);

                foreach (string file in imageFiles)
                {
                    FileInfo fileInfo = new FileInfo(file);
                    if (fileInfo.CreationTime < cutoffDate)
                    {
                        File.Delete(file);
                    }
                }
            }
            catch (Exception ex)
            {
                // Log error but don't throw - this is maintenance
                System.Diagnostics.Debug.WriteLine($"Error cleaning up old images: {ex.Message}");
            }
        }
    }
}