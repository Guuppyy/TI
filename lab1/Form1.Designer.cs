namespace lab1;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        keyTextBox = new TextBox();
        cipherButton = new Button();
        unCipherButton = new Button();
        inputTextBox = new TextBox();
        outputTextBox = new TextBox();
        tabControl1 = new TabControl();
        vigenerTabPage = new TabPage();
        label8 = new Label();
        label7 = new Label();
        label3 = new Label();
        label2 = new Label();
        label1 = new Label();
        openFileButton = new Button();
        plefnerTabPage = new TabPage();
        label10 = new Label();
        label9 = new Label();
        keyPlTextBox3 = new TextBox();
        keyPlTextBox4 = new TextBox();
        keyPlTextBox2 = new TextBox();
        label6 = new Label();
        label5 = new Label();
        button1 = new Button();
        outTextBox2 = new TextBox();
        inputTextBox2 = new TextBox();
        button2 = new Button();
        label4 = new Label();
        keyPlTextBox1 = new TextBox();
        cipherButton2 = new Button();
        tableLayoutPanel1 = new TableLayoutPanel();
        openFileDialog1 = new OpenFileDialog();
        tabControl1.SuspendLayout();
        vigenerTabPage.SuspendLayout();
        plefnerTabPage.SuspendLayout();
        SuspendLayout();
        // 
        // keyTextBox
        // 
        keyTextBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
        keyTextBox.Location = new Point(79, 124);
        keyTextBox.Name = "keyTextBox";
        keyTextBox.Size = new Size(215, 37);
        keyTextBox.TabIndex = 0;
        // 
        // cipherButton
        // 
        cipherButton.BackColor = Color.DeepPink;
        cipherButton.Cursor = Cursors.Hand;
        cipherButton.Font = new Font("Showcard Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point);
        cipherButton.Location = new Point(607, 385);
        cipherButton.Name = "cipherButton";
        cipherButton.Size = new Size(314, 80);
        cipherButton.TabIndex = 1;
        cipherButton.Text = "Encrypt";
        cipherButton.UseVisualStyleBackColor = false;
        cipherButton.Click += cipherButton_Click;
        // 
        // unCipherButton
        // 
        unCipherButton.BackColor = Color.HotPink;
        unCipherButton.Cursor = Cursors.Hand;
        unCipherButton.Font = new Font("Showcard Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point);
        unCipherButton.Location = new Point(607, 502);
        unCipherButton.Name = "unCipherButton";
        unCipherButton.Size = new Size(314, 80);
        unCipherButton.TabIndex = 2;
        unCipherButton.Text = "Decipher";
        unCipherButton.UseVisualStyleBackColor = false;
        unCipherButton.Click += unCipherButton_Click;
        // 
        // inputTextBox
        // 
        inputTextBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
        inputTextBox.Location = new Point(453, 113);
        inputTextBox.Multiline = true;
        inputTextBox.Name = "inputTextBox";
        inputTextBox.Size = new Size(400, 185);
        inputTextBox.TabIndex = 3;
        // 
        // outputTextBox
        // 
        outputTextBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
        outputTextBox.Location = new Point(889, 113);
        outputTextBox.Multiline = true;
        outputTextBox.Name = "outputTextBox";
        outputTextBox.Size = new Size(400, 185);
        outputTextBox.TabIndex = 4;
        // 
        // tabControl1
        // 
        tabControl1.Controls.Add(vigenerTabPage);
        tabControl1.Controls.Add(plefnerTabPage);
        tabControl1.Location = new Point(-3, 1);
        tabControl1.Name = "tabControl1";
        tabControl1.SelectedIndex = 0;
        tabControl1.Size = new Size(1341, 738);
        tabControl1.TabIndex = 5;
        // 
        // vigenerTabPage
        // 
        vigenerTabPage.BackColor = Color.Pink;
        vigenerTabPage.Controls.Add(label8);
        vigenerTabPage.Controls.Add(label7);
        vigenerTabPage.Controls.Add(label3);
        vigenerTabPage.Controls.Add(label2);
        vigenerTabPage.Controls.Add(label1);
        vigenerTabPage.Controls.Add(openFileButton);
        vigenerTabPage.Controls.Add(outputTextBox);
        vigenerTabPage.Controls.Add(unCipherButton);
        vigenerTabPage.Controls.Add(cipherButton);
        vigenerTabPage.Controls.Add(inputTextBox);
        vigenerTabPage.Controls.Add(keyTextBox);
        vigenerTabPage.Cursor = Cursors.Hand;
        vigenerTabPage.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
        vigenerTabPage.Location = new Point(4, 34);
        vigenerTabPage.Name = "vigenerTabPage";
        vigenerTabPage.Padding = new Padding(3);
        vigenerTabPage.Size = new Size(1333, 700);
        vigenerTabPage.TabIndex = 0;
        vigenerTabPage.Text = "Vigenere";
        // 
        // label8
        // 
        label8.Font = new Font("Showcard Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
        label8.Location = new Point(453, 344);
        label8.Name = "label8";
        label8.Size = new Size(1285, 32);
        label8.TabIndex = 10;
        label8.Text = "Кнопки \"ENC/DERYPT\" предлагают диалоговое окно для выходного файла.";
        // 
        // label7
        // 
        label7.Font = new Font("Showcard Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
        label7.Location = new Point(453, 312);
        label7.Name = "label7";
        label7.Size = new Size(1285, 32);
        label7.TabIndex = 9;
        label7.Text = "Кнопка \"FILE\" - для ввода исходного текста из файла.";
        // 
        // label3
        // 
        label3.Font = new Font("Showcard Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
        label3.Location = new Point(889, 75);
        label3.Name = "label3";
        label3.Size = new Size(303, 32);
        label3.TabIndex = 8;
        label3.Text = "encrypted text";
        // 
        // label2
        // 
        label2.Font = new Font("Showcard Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
        label2.Location = new Point(453, 75);
        label2.Name = "label2";
        label2.Size = new Size(250, 32);
        label2.TabIndex = 7;
        label2.Text = "plain text";
        // 
        // label1
        // 
        label1.Font = new Font("Showcard Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
        label1.Location = new Point(79, 75);
        label1.Name = "label1";
        label1.Size = new Size(124, 43);
        label1.TabIndex = 6;
        label1.Text = "key";
        label1.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // openFileButton
        // 
        openFileButton.BackColor = Color.Plum;
        openFileButton.Font = new Font("Showcard Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
        openFileButton.Location = new Point(209, 75);
        openFileButton.Name = "openFileButton";
        openFileButton.Size = new Size(85, 43);
        openFileButton.TabIndex = 5;
        openFileButton.Text = "FILE";
        openFileButton.UseVisualStyleBackColor = false;
        openFileButton.Click += openFileButton_Click;
        // 
        // plefnerTabPage
        // 
        plefnerTabPage.BackColor = Color.LightPink;
        plefnerTabPage.Controls.Add(label10);
        plefnerTabPage.Controls.Add(label9);
        plefnerTabPage.Controls.Add(keyPlTextBox3);
        plefnerTabPage.Controls.Add(keyPlTextBox4);
        plefnerTabPage.Controls.Add(keyPlTextBox2);
        plefnerTabPage.Controls.Add(label6);
        plefnerTabPage.Controls.Add(label5);
        plefnerTabPage.Controls.Add(button1);
        plefnerTabPage.Controls.Add(outTextBox2);
        plefnerTabPage.Controls.Add(inputTextBox2);
        plefnerTabPage.Controls.Add(button2);
        plefnerTabPage.Controls.Add(label4);
        plefnerTabPage.Controls.Add(keyPlTextBox1);
        plefnerTabPage.Controls.Add(cipherButton2);
        plefnerTabPage.Controls.Add(tableLayoutPanel1);
        plefnerTabPage.Cursor = Cursors.Hand;
        plefnerTabPage.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
        plefnerTabPage.Location = new Point(4, 34);
        plefnerTabPage.Name = "plefnerTabPage";
        plefnerTabPage.Padding = new Padding(3);
        plefnerTabPage.Size = new Size(1333, 700);
        plefnerTabPage.TabIndex = 1;
        plefnerTabPage.Text = "Playfair";
        // 
        // label10
        // 
        label10.Font = new Font("Showcard Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
        label10.Location = new Point(520, 275);
        label10.Name = "label10";
        label10.Size = new Size(1285, 32);
        label10.TabIndex = 14;
        label10.Text = "Кнопки \"ENC/DERYPT\" предлагают диалоговое окно для выходного файла.";
        // 
        // label9
        // 
        label9.Font = new Font("Showcard Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
        label9.Location = new Point(520, 243);
        label9.Name = "label9";
        label9.Size = new Size(1285, 32);
        label9.TabIndex = 13;
        label9.Text = "Кнопка \"FILE\" - для ввода исходного текста из файла.";
        // 
        // keyPlTextBox3
        // 
        keyPlTextBox3.Font = new Font("Showcard Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
        keyPlTextBox3.Location = new Point(26, 100);
        keyPlTextBox3.Name = "keyPlTextBox3";
        keyPlTextBox3.Size = new Size(227, 35);
        keyPlTextBox3.TabIndex = 12;
        // 
        // keyPlTextBox4
        // 
        keyPlTextBox4.Font = new Font("Showcard Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
        keyPlTextBox4.Location = new Point(260, 100);
        keyPlTextBox4.Name = "keyPlTextBox4";
        keyPlTextBox4.Size = new Size(227, 35);
        keyPlTextBox4.TabIndex = 11;
        // 
        // keyPlTextBox2
        // 
        keyPlTextBox2.Font = new Font("Showcard Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
        keyPlTextBox2.Location = new Point(259, 55);
        keyPlTextBox2.Name = "keyPlTextBox2";
        keyPlTextBox2.Size = new Size(227, 35);
        keyPlTextBox2.TabIndex = 10;
        // 
        // label6
        // 
        label6.Font = new Font("Showcard Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
        label6.Location = new Point(937, 19);
        label6.Name = "label6";
        label6.Size = new Size(270, 33);
        label6.TabIndex = 9;
        label6.Text = "encrypted text";
        // 
        // label5
        // 
        label5.Font = new Font("Showcard Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
        label5.Location = new Point(520, 19);
        label5.Name = "label5";
        label5.Size = new Size(270, 33);
        label5.TabIndex = 8;
        label5.Text = "plain text";
        // 
        // button1
        // 
        button1.BackColor = Color.HotPink;
        button1.Font = new Font("Showcard Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point);
        button1.Location = new Point(767, 468);
        button1.Name = "button1";
        button1.Size = new Size(314, 80);
        button1.TabIndex = 7;
        button1.Text = "decipher";
        button1.UseVisualStyleBackColor = false;
        button1.Click += button1_Click_1;
        // 
        // outTextBox2
        // 
        outTextBox2.Font = new Font("Showcard Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
        outTextBox2.Location = new Point(937, 55);
        outTextBox2.Multiline = true;
        outTextBox2.Name = "outTextBox2";
        outTextBox2.Size = new Size(400, 185);
        outTextBox2.TabIndex = 6;
        // 
        // inputTextBox2
        // 
        inputTextBox2.Font = new Font("Showcard Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
        inputTextBox2.Location = new Point(520, 55);
        inputTextBox2.Multiline = true;
        inputTextBox2.Name = "inputTextBox2";
        inputTextBox2.Size = new Size(400, 185);
        inputTextBox2.TabIndex = 5;
        // 
        // button2
        // 
        button2.BackColor = Color.Plum;
        button2.Font = new Font("Showcard Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
        button2.Location = new Point(158, 15);
        button2.Name = "button2";
        button2.Size = new Size(97, 37);
        button2.TabIndex = 4;
        button2.Text = "file";
        button2.UseVisualStyleBackColor = false;
        button2.Click += button2_Click;
        // 
        // label4
        // 
        label4.Font = new Font("Showcard Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
        label4.Location = new Point(27, 15);
        label4.Name = "label4";
        label4.Size = new Size(112, 37);
        label4.TabIndex = 3;
        label4.Text = "key";
        // 
        // keyPlTextBox1
        // 
        keyPlTextBox1.Font = new Font("Showcard Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
        keyPlTextBox1.Location = new Point(27, 55);
        keyPlTextBox1.Name = "keyPlTextBox1";
        keyPlTextBox1.Size = new Size(227, 35);
        keyPlTextBox1.TabIndex = 2;
        // 
        // cipherButton2
        // 
        cipherButton2.BackColor = Color.DeepPink;
        cipherButton2.Font = new Font("Showcard Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point);
        cipherButton2.Location = new Point(767, 341);
        cipherButton2.Name = "cipherButton2";
        cipherButton2.Size = new Size(314, 80);
        cipherButton2.TabIndex = 1;
        cipherButton2.Text = "encrypt";
        cipherButton2.UseVisualStyleBackColor = false;
        cipherButton2.Click += button1_Click;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 11;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
        tableLayoutPanel1.Location = new Point(27, 209);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 11;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        tableLayoutPanel1.Size = new Size(441, 414);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // openFileDialog1
        // 
        openFileDialog1.Filter = "(*.txt)|*.txt";
        openFileDialog1.ReadOnlyChecked = true;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1340, 740);
        Controls.Add(tabControl1);
        Name = "Form1";
        Text = "lab1";
        tabControl1.ResumeLayout(false);
        vigenerTabPage.ResumeLayout(false);
        vigenerTabPage.PerformLayout();
        plefnerTabPage.ResumeLayout(false);
        plefnerTabPage.PerformLayout();
        ResumeLayout(false);
    }

    private TextBox keyPlTextBox2;
    private TextBox keyPlTextBox4;
    private TextBox keyPlTextBox3;

    private Label label5;
    private Label label6;

    private Button cipherButton2;

    private TextBox inputTextBox2;

    private TextBox outTextBox2;

    private TextBox keyPlTextBox1;
    private Label label4;
    private Button button2;

    private Button button1;

    private TableLayoutPanel tableLayoutPanel1;

    private Label label1;
    private Label label2;
    private Label label3;

    private OpenFileDialog openFileDialog1;

    private Button openFileButton;

    private TabControl tabControl1;
    private TabPage vigenerTabPage;
    private TabPage plefnerTabPage;

    private TextBox inputTextBox;

    private TextBox keyTextBox;
    private Button cipherButton;
    private Button unCipherButton;
    private TextBox outputTextBox;

    #endregion

    private Label label8;
    private Label label7;
    private Label label10;
    private Label label9;
}