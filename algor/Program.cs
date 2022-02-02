class algor
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter text to encrypt");
        String str = Console.ReadLine();
        String str2 = str.ToUpper();

        Console.WriteLine("Enter key to decrypt");
        String keyword = Console.ReadLine();
        String kyeword2 = keyword.ToUpper();


        String key = generateKey(str2, kyeword2);
        String cipher_text = cipherText(str2, key);

        Console.WriteLine("Ciphertext : " + cipher_text + "\n");
    }

    static String generateKey(String str, String key)
    {
        int x = str.Length;

        for (int i = 0; ; i++)
        {
            if (x == i)
                i = 0;
            if (key.Length == str.Length)
                break;
            key += (key[i]);
        }
        return key;
    }
    static String cipherText(String str, String key)
    {
        String cipher_text ="";

        for (int i = 0; i < str.Length; i++)
        {
            int x = (str[i] + key[i]) % 26;

            x += 'A';

            cipher_text += (char)(x);
        }
        return cipher_text;
    }
}