namespace ContactosApp.Helpers
{
    public class APImage
    {
        public static byte[] Tobyte(IFormFile file)
        {
            if (file == null || file.Length == 0)
                return null;

            using(var ms = new MemoryStream())
            {
                file.CopyTo(ms);
                return ms.ToArray();
            }


        }
    }
}
