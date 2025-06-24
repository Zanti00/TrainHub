using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace TrainHub.Static_Classes
{
    public enum PersonType
    {
        Member,
        Trainer,
        Staff
    }

    public static class ImageFileManager
    {
        private static readonly string BaseImageDirectory = Path.Combine(Application.StartupPath, "Images");

        static ImageFileManager()
        {
            // Ensure the base directory exists
            if (!Directory.Exists(BaseImageDirectory))
            {
                Directory.CreateDirectory(BaseImageDirectory);
            }
        }

        /// <summary>
        /// Save captured image to file system for member, trainer, or staff
        /// </summary>
        /// <param name="image">The image to save</param>
        /// <param name="personId">Person ID for filename</param>
        /// <param name="personType">Type of person (Member, Trainer, or Staff)</param>
        /// <param name="email">Person email for additional organization (optional)</param>
        /// <returns>The file path where image was saved</returns>
        public static string SavePersonImage(Bitmap image, int personId, PersonType personType, string email = null)
        {
            if (image == null)
                throw new ArgumentNullException(nameof(image));

            try
            {
                // Create type-specific subfolder
                string typeFolder = Path.Combine(BaseImageDirectory, personType.ToString() + "s"); // "Members", "Trainers", or "Staffs"
                if (!Directory.Exists(typeFolder))
                {
                    Directory.CreateDirectory(typeFolder);
                }

                // Create year subfolder for organization
                string yearFolder = Path.Combine(typeFolder, DateTime.Now.Year.ToString());
                if (!Directory.Exists(yearFolder))
                {
                    Directory.CreateDirectory(yearFolder);
                }

                // Generate unique filename
                string fileName = $"{personType.ToString().ToLower()}_{personId}_{DateTime.Now:yyyyMMdd_HHmmss}.jpg";
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
                throw new Exception($"Failed to save {personType.ToString().ToLower()} image: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Save member image (wrapper for backward compatibility)
        /// </summary>
        public static string SaveMemberImage(Bitmap image, int memberId, string memberEmail = null)
        {
            return SavePersonImage(image, memberId, PersonType.Member, memberEmail);
        }

        /// <summary>
        /// Save trainer image
        /// </summary>
        public static string SaveTrainerImage(Bitmap image, int trainerId, string trainerEmail = null)
        {
            return SavePersonImage(image, trainerId, PersonType.Trainer, trainerEmail);
        }

        /// <summary>
        /// Save staff image
        /// </summary>
        public static string SaveStaffImage(Bitmap image, int staffId, string staffEmail = null)
        {
            return SavePersonImage(image, staffId, PersonType.Staff, staffEmail);
        }

        /// <summary>
        /// Load person image from file path
        /// </summary>
        /// <param name="filePath">Path to the image file</param>
        /// <returns>Bitmap image or null if not found</returns>
        public static Bitmap LoadPersonImage(string filePath)
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
        /// Load member image (wrapper for backward compatibility)
        /// </summary>
        public static Bitmap LoadMemberImage(string filePath)
        {
            return LoadPersonImage(filePath);
        }

        /// <summary>
        /// Load trainer image
        /// </summary>
        public static Bitmap LoadTrainerImage(string filePath)
        {
            return LoadPersonImage(filePath);
        }

        /// <summary>
        /// Load staff image
        /// </summary>
        public static Bitmap LoadStaffImage(string filePath)
        {
            return LoadPersonImage(filePath);
        }

        /// <summary>
        /// Delete person image file
        /// </summary>
        /// <param name="filePath">Path to the image file</param>
        /// <returns>True if deleted successfully</returns>
        public static bool DeletePersonImage(string filePath)
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
        /// Delete member image (wrapper for backward compatibility)
        /// </summary>
        public static bool DeleteMemberImage(string filePath)
        {
            return DeletePersonImage(filePath);
        }

        /// <summary>
        /// Delete trainer image
        /// </summary>
        public static bool DeleteTrainerImage(string filePath)
        {
            return DeletePersonImage(filePath);
        }

        /// <summary>
        /// Delete staff image
        /// </summary>
        public static bool DeleteStaffImage(string filePath)
        {
            return DeletePersonImage(filePath);
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
        /// <param name="personType">Type of person to clean up (null for all types)</param>
        public static void CleanupOldImages(int daysOldToDelete = 365, PersonType? personType = null)
        {
            try
            {
                DateTime cutoffDate = DateTime.Now.AddDays(-daysOldToDelete);

                string searchPath = BaseImageDirectory;
                if (personType.HasValue)
                {
                    searchPath = Path.Combine(BaseImageDirectory, personType.Value.ToString() + "s");
                }

                if (Directory.Exists(searchPath))
                {
                    string[] imageFiles = Directory.GetFiles(searchPath, "*.jpg", SearchOption.AllDirectories);

                    foreach (string file in imageFiles)
                    {
                        FileInfo fileInfo = new FileInfo(file);
                        if (fileInfo.CreationTime < cutoffDate)
                        {
                            File.Delete(file);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log error but don't throw - this is maintenance
                System.Diagnostics.Debug.WriteLine($"Error cleaning up old images: {ex.Message}");
            }
        }

        /// <summary>
        /// Get all image files for a specific person type
        /// </summary>
        /// <param name="personType">Type of person</param>
        /// <returns>Array of image file paths</returns>
        public static string[] GetAllImagesForType(PersonType personType)
        {
            try
            {
                string typeFolder = Path.Combine(BaseImageDirectory, personType.ToString() + "s");
                if (Directory.Exists(typeFolder))
                {
                    return Directory.GetFiles(typeFolder, "*.jpg", SearchOption.AllDirectories);
                }
                return new string[0];
            }
            catch (Exception)
            {
                return new string[0];
            }
        }
    }
}