namespace lab1;

public partial class Form1 : Form
{
    private void FillGrid(char[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                string text = matrix[i, j] switch
                {
                    'i' => "i/j",
                    'j' => "j/i",
                    _ => matrix[i, j].ToString()
                };
                tableLayoutPanel1.GetControlFromPosition(j, i).Text = text;
            }
        }
    }

    private string ClearStr(string str, string alphabet)
    {
        return new string(str.Where(c => alphabet.Contains(c) || c == ' ').ToArray());
    }

    public Form1()
    {
        InitializeComponent();
        for (int i = 0; i < 11; i++)
        {
            for (int j = 0; j < 11; j++)
            {
                Label myLabel = new Label
                {
                    AutoSize = true
                };
                tableLayoutPanel1.Controls.Add(myLabel, i, j);
            }
        }
    }

    private void cipherButton_Click(object sender, EventArgs e)
    {
        string key = ClearStr(keyTextBox.Text.ToLower(), Vigener.MyAlphabet);
        string text = ClearStr(inputTextBox.Text.ToLower(), Vigener.MyAlphabet);

        if (string.IsNullOrWhiteSpace(key) || string.IsNullOrWhiteSpace(text))
        {
            MessageBox.Show("Поле ключа и исходного текста не должны быть пустыми", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        try
        {
            string cipheredText = Vigener.Cipher(key, text);
            outputTextBox.Text = cipheredText;
            SaveToFile(cipheredText, "Сохранить зашифрованный текст");
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void unCipherButton_Click(object sender, EventArgs e)
    {
        string key = ClearStr(keyTextBox.Text.ToLower(), Vigener.MyAlphabet);
        string text = ClearStr(inputTextBox.Text.ToLower(), Vigener.MyAlphabet);

        if (string.IsNullOrWhiteSpace(key) || string.IsNullOrWhiteSpace(text))
        {
            MessageBox.Show("Поле ключа и исходного текста не должны быть пустыми", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        try
        {
            string decipheredText = Vigener.Decipher(key, text);
            outputTextBox.Text = decipheredText;
            SaveToFile(decipheredText, "Сохранить расшифрованный текст");
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void SaveToFile(string text, string title)
    {
        using SaveFileDialog saveFileDialog = new SaveFileDialog
        {
            Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*",
            Title = title,
            DefaultExt = "txt"
        };

        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            try
            {
                File.WriteAllText(saveFileDialog.FileName, text);
                MessageBox.Show("Файл успешно сохранён!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private void openFileButton_Click(object sender, EventArgs e)
    {
        if (openFileDialog1.ShowDialog() == DialogResult.OK)
        {
            inputTextBox.Text = File.ReadAllText(openFileDialog1.FileName);
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        string key1 = ClearStr(keyPlTextBox1.Text.ToLower(), Plefner.MyAlphabet);
        string key2 = ClearStr(keyPlTextBox2.Text.ToLower(), Plefner.MyAlphabet);
        string key3 = ClearStr(keyPlTextBox3.Text.ToLower(), Plefner.MyAlphabet);
        string key4 = ClearStr(keyPlTextBox4.Text.ToLower(), Plefner.MyAlphabet);
        string text = ClearStr(inputTextBox2.Text.ToLower(), Plefner.MyAlphabet);

        if (new[] { key1, key2, key3, key4, text }.Any(string.IsNullOrWhiteSpace))
        {
            MessageBox.Show("Поле ключа и исходного текста не должны быть пустыми", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        try
        {
            FillGrid(Plefner.FillMatrix(key1, key2, key3, key4));
            string cipheredText = Plefner.Cipherise(key1, key2, key3, key4, text);
            outTextBox2.Text = cipheredText;
            SaveToFile(cipheredText, "Сохранить зашифрованный текст");
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void button2_Click(object sender, EventArgs e)
    {
        if (openFileDialog1.ShowDialog() == DialogResult.OK)
        {
            inputTextBox2.Text = File.ReadAllText(openFileDialog1.FileName);
        }
    }

    private void button1_Click_1(object sender, EventArgs e)
    {
        string key1 = ClearStr(keyPlTextBox1.Text.ToLower(), Plefner.MyAlphabet);
        string key2 = ClearStr(keyPlTextBox2.Text.ToLower(), Plefner.MyAlphabet);
        string key3 = ClearStr(keyPlTextBox3.Text.ToLower(), Plefner.MyAlphabet);
        string key4 = ClearStr(keyPlTextBox4.Text.ToLower(), Plefner.MyAlphabet);
        string text = ClearStr(inputTextBox2.Text.ToLower(), Plefner.MyAlphabet);

        if (new[] { key1, key2, key3, key4, text }.Any(string.IsNullOrWhiteSpace))
        {
            MessageBox.Show("Поле ключа и исходного текста не должны быть пустыми", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        try
        {
            FillGrid(Plefner.FillMatrix(key1, key2, key3, key4));
            string decipheredText = Plefner.UnCipherise(key1, key2, key3, key4, text);
            outTextBox2.Text = decipheredText;
            SaveToFile(decipheredText, "Сохранить расшифрованный текст");
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}