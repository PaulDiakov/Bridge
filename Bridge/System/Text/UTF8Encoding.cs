namespace System.Text
{
    public class UTF8Encoding : Encoding
    {
        public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex)
        {
            throw new NotImplementedException();
        }
    }
}