namespace CohesionAndCoupling
{
    using System;

    public static class FileUtils
    {
        public static string GetFileExtension(string fileName)
        {
            int indexOfLastDot = fileName.LastIndexOf(".", StringComparison.Ordinal);

            if (indexOfLastDot == -1)
            {
                return "No extension";
            }

            string extension = fileName.Substring(indexOfLastDot + 1);

            return extension;
        }

        public static string GetFileNameWithoutExtension(string fileName)
        {
            int indexOfLastDot = fileName.LastIndexOf(".", StringComparison.Ordinal);

            if (indexOfLastDot == -1)
            {
                return fileName;
            }

            string nameOfFile = fileName.Substring(0, indexOfLastDot);

            return nameOfFile;
        }
    }
}
