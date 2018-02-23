namespace NextElementsConverter
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.src = new MetroFramework.Controls.MetroButton();
            this.src_txt = new MetroFramework.Controls.MetroLabel();
            this.Progress = new MetroFramework.Controls.MetroProgressSpinner();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.convert = new MetroFramework.Controls.MetroButton();
            this.version_list = new MetroFramework.Controls.MetroComboBox();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.split = new MetroFramework.Controls.MetroButton();
            this.dst_txt = new MetroFramework.Controls.MetroLabel();
            this.dst = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.empty_string = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.empty_float = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.empty_int = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // src
            // 
            this.src.Location = new System.Drawing.Point(23, 63);
            this.src.Name = "src";
            this.src.Size = new System.Drawing.Size(170, 23);
            this.src.TabIndex = 1;
            this.src.Text = "Выбрать исходный файл";
            this.src.UseSelectable = true;
            this.src.Click += new System.EventHandler(this.src_Click);
            // 
            // src_txt
            // 
            this.src_txt.AutoSize = true;
            this.src_txt.Location = new System.Drawing.Point(199, 63);
            this.src_txt.Name = "src_txt";
            this.src_txt.Size = new System.Drawing.Size(56, 19);
            this.src_txt.TabIndex = 2;
            this.src_txt.Text = "Версия:";
            // 
            // Progress
            // 
            this.Progress.Location = new System.Drawing.Point(134, 366);
            this.Progress.Maximum = 100;
            this.Progress.Name = "Progress";
            this.Progress.Size = new System.Drawing.Size(150, 150);
            this.Progress.TabIndex = 3;
            this.Progress.UseSelectable = true;
            this.Progress.Visible = false;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 92);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(404, 144);
            this.metroTabControl1.TabIndex = 4;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.convert);
            this.metroTabPage1.Controls.Add(this.version_list);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(396, 102);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Конвертировать";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // convert
            // 
            this.convert.Location = new System.Drawing.Point(123, 63);
            this.convert.Name = "convert";
            this.convert.Size = new System.Drawing.Size(150, 23);
            this.convert.TabIndex = 3;
            this.convert.Text = "Конвертировать";
            this.convert.UseSelectable = true;
            this.convert.Click += new System.EventHandler(this.convert_Click);
            // 
            // version_list
            // 
            this.version_list.FormattingEnabled = true;
            this.version_list.ItemHeight = 23;
            this.version_list.Items.AddRange(new object[] {
            "Выберите версию для конвертирования"});
            this.version_list.Location = new System.Drawing.Point(3, 18);
            this.version_list.Name = "version_list";
            this.version_list.Size = new System.Drawing.Size(393, 29);
            this.version_list.TabIndex = 2;
            this.version_list.UseSelectable = true;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.split);
            this.metroTabPage2.Controls.Add(this.dst_txt);
            this.metroTabPage2.Controls.Add(this.dst);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(396, 102);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Соединить";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // split
            // 
            this.split.Enabled = false;
            this.split.Location = new System.Drawing.Point(107, 76);
            this.split.Name = "split";
            this.split.Size = new System.Drawing.Size(150, 23);
            this.split.TabIndex = 7;
            this.split.Text = "Соединить";
            this.split.UseSelectable = true;
            this.split.Click += new System.EventHandler(this.split_Click);
            // 
            // dst_txt
            // 
            this.dst_txt.AutoSize = true;
            this.dst_txt.Location = new System.Drawing.Point(263, 20);
            this.dst_txt.Name = "dst_txt";
            this.dst_txt.Size = new System.Drawing.Size(56, 19);
            this.dst_txt.TabIndex = 6;
            this.dst_txt.Text = "Версия:";
            // 
            // dst
            // 
            this.dst.Location = new System.Drawing.Point(9, 20);
            this.dst.Name = "dst";
            this.dst.Size = new System.Drawing.Size(248, 23);
            this.dst.TabIndex = 2;
            this.dst.Text = "Выбрать файл для слияния";
            this.dst.UseSelectable = true;
            this.dst.Click += new System.EventHandler(this.dst_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.empty_string);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.empty_float);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.empty_int);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(30, 242);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 118);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки";
            // 
            // empty_string
            // 
            // 
            // 
            // 
            this.empty_string.CustomButton.Image = null;
            this.empty_string.CustomButton.Location = new System.Drawing.Point(98, 1);
            this.empty_string.CustomButton.Name = "";
            this.empty_string.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.empty_string.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.empty_string.CustomButton.TabIndex = 1;
            this.empty_string.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.empty_string.CustomButton.UseSelectable = true;
            this.empty_string.CustomButton.Visible = false;
            this.empty_string.Lines = new string[0];
            this.empty_string.Location = new System.Drawing.Point(105, 77);
            this.empty_string.MaxLength = 32767;
            this.empty_string.Name = "empty_string";
            this.empty_string.PasswordChar = '\0';
            this.empty_string.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.empty_string.SelectedText = "";
            this.empty_string.SelectionLength = 0;
            this.empty_string.SelectionStart = 0;
            this.empty_string.ShortcutsEnabled = true;
            this.empty_string.Size = new System.Drawing.Size(120, 23);
            this.empty_string.TabIndex = 5;
            this.empty_string.UseSelectable = true;
            this.empty_string.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.empty_string.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(6, 81);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(93, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Пустая строка";
            // 
            // empty_float
            // 
            // 
            // 
            // 
            this.empty_float.CustomButton.Image = null;
            this.empty_float.CustomButton.Location = new System.Drawing.Point(110, 1);
            this.empty_float.CustomButton.Name = "";
            this.empty_float.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.empty_float.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.empty_float.CustomButton.TabIndex = 1;
            this.empty_float.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.empty_float.CustomButton.UseSelectable = true;
            this.empty_float.CustomButton.Visible = false;
            this.empty_float.Lines = new string[] {
        "1"};
            this.empty_float.Location = new System.Drawing.Point(93, 48);
            this.empty_float.MaxLength = 32767;
            this.empty_float.Name = "empty_float";
            this.empty_float.PasswordChar = '\0';
            this.empty_float.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.empty_float.SelectedText = "";
            this.empty_float.SelectionLength = 0;
            this.empty_float.SelectionStart = 0;
            this.empty_float.ShortcutsEnabled = true;
            this.empty_float.Size = new System.Drawing.Size(132, 23);
            this.empty_float.TabIndex = 3;
            this.empty_float.Text = "1";
            this.empty_float.UseSelectable = true;
            this.empty_float.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.empty_float.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 52);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(81, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Пустой float";
            // 
            // empty_int
            // 
            // 
            // 
            // 
            this.empty_int.CustomButton.Image = null;
            this.empty_int.CustomButton.Location = new System.Drawing.Point(122, 1);
            this.empty_int.CustomButton.Name = "";
            this.empty_int.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.empty_int.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.empty_int.CustomButton.TabIndex = 1;
            this.empty_int.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.empty_int.CustomButton.UseSelectable = true;
            this.empty_int.CustomButton.Visible = false;
            this.empty_int.Lines = new string[] {
        "0"};
            this.empty_int.Location = new System.Drawing.Point(81, 19);
            this.empty_int.MaxLength = 32767;
            this.empty_int.Name = "empty_int";
            this.empty_int.PasswordChar = '\0';
            this.empty_int.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.empty_int.SelectedText = "";
            this.empty_int.SelectionLength = 0;
            this.empty_int.SelectionStart = 0;
            this.empty_int.ShortcutsEnabled = true;
            this.empty_int.Size = new System.Drawing.Size(144, 23);
            this.empty_int.TabIndex = 1;
            this.empty_int.Text = "0";
            this.empty_int.UseSelectable = true;
            this.empty_int.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.empty_int.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 23);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(69, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Пустой int";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 520);
            this.Controls.Add(this.Progress);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.src_txt);
            this.Controls.Add(this.src);
            this.Name = "MainForm";
            this.Text = "Next Elements.data Converter";
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton src;
        private MetroFramework.Controls.MetroLabel src_txt;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        public MetroFramework.Controls.MetroProgressSpinner Progress;
        private MetroFramework.Controls.MetroComboBox version_list;
        private MetroFramework.Controls.MetroButton convert;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox empty_int;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox empty_float;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox empty_string;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton dst;
        private MetroFramework.Controls.MetroLabel dst_txt;
        private MetroFramework.Controls.MetroButton split;
    }
}

