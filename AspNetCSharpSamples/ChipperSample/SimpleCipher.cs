namespace ChipperSample
{
    class SimpleCipher : Ichipher
    {
        #region ICipher Members
        public string encode(string str)
        {
            string cipperText = "";
            for (int i = 0; i < str.Length; i++)
            {
                cipperText = cipperText + (char)(str[i] + 1);
            }
            return cipperText;
        }

        public string decode(string str)
        {

            string plaintext = "";
            for (int i = 0; i < str.Length; i++)
            {
                plaintext = plaintext + (char)(str[i] - 1);
            }
            return plaintext;
        }
        #endregion
    }

}
