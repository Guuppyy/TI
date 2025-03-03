namespace lab1;

public class Vigener
{
    public const string MyAlphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

    private static string RemoveSpaces(string str) => str.Replace(" ", "");

    private static char ShiftChar(char textChar, char keyChar, bool encrypt)
    {
        int textIndex = MyAlphabet.IndexOf(textChar);
        int keyIndex = MyAlphabet.IndexOf(keyChar);

        if (textIndex == -1 || keyIndex == -1)
            throw new ArgumentException("Input text or key contains invalid characters.");

        int shift = encrypt
            ? (textIndex + keyIndex) % MyAlphabet.Length
            : (MyAlphabet.Length + textIndex - keyIndex) % MyAlphabet.Length;

        return MyAlphabet[shift];
    }

    public static string Cipher(string key, string text)
    {
        return ProcessText(key, text, true);
    }

    public static string Decipher(string key, string cipherText)
    {
        return ProcessText(key, cipherText, false);
    }

    private static string ProcessText(string key, string text, bool encrypt)
    {
        string cleanedKey = RemoveSpaces(key);
        char[] result = new char[text.Length];
        int keyIndex = 0;

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] != ' ')
            {
                result[i] = ShiftChar(text[i], cleanedKey[keyIndex], encrypt);
                keyIndex = (keyIndex + 1) % cleanedKey.Length;
            }
            else
            {
                result[i] = text[i];
            }
        }
        return new string(result);
    }
}