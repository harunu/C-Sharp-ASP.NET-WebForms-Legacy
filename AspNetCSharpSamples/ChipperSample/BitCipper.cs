namespace ChipperSample
{
    class BitCipper : Ichipher
    {
        ushort key;
        public BitCipper(ushort k)
        {
            key = k;
        }

        public string encode(string str)
        {
            string chipperText = "";
            for (int i = 0; i < str.Length; i++)
            {
                chipperText = chipperText + (char)(str[i] ^ key);
            }
            return chipperText;
        }


        public string decode(string str)
        {
            string plainText = "";
            for (int i = 0; i < str.Length; i++)
            {
                plainText = plainText + (char)(str[i] ^ key);
            }
            return plainText;
        }
    }
}

