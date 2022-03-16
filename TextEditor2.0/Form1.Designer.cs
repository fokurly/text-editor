
namespace TextEditor2._0
{
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.openFile = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileAs = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAllOpenedFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.openNewForm = new System.Windows.Forms.ToolStripMenuItem();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.editBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.formatBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.styleFont = new System.Windows.Forms.ToolStripMenuItem();
            this.colorFont = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.backColorBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.saveEvery10 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveEvery5 = new System.Windows.Forms.ToolStripMenuItem();
            this.addTab = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTab = new System.Windows.Forms.ToolStripMenuItem();
            this.infoBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.selectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.cutText = new System.Windows.Forms.ToolStripMenuItem();
            this.copyText = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteText = new System.Windows.Forms.ToolStripMenuItem();
            this.formatFontContext = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog2 = new System.Windows.Forms.FontDialog();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileBtn,
            this.editBtn,
            this.formatBtn,
            this.settingsBtn,
            this.addTab,
            this.deleteTab,
            this.infoBtn});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileBtn
            // 
            this.fileBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFile,
            this.saveFile,
            this.saveFileAs,
            this.saveAllOpenedFiles,
            this.openNewForm,
            this.exit});
            this.fileBtn.Name = "fileBtn";
            this.fileBtn.Size = new System.Drawing.Size(59, 24);
            this.fileBtn.Text = "Файл";
            // 
            // openFile
            // 
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(435, 26);
            this.openFile.Text = "Открыть";
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // saveFile
            // 
            this.saveFile.Name = "saveFile";
            this.saveFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveFile.Size = new System.Drawing.Size(435, 26);
            this.saveFile.Text = "Сохранить";
            this.saveFile.Click += new System.EventHandler(this.saveFile_Click);
            // 
            // saveFileAs
            // 
            this.saveFileAs.Name = "saveFileAs";
            this.saveFileAs.Size = new System.Drawing.Size(435, 26);
            this.saveFileAs.Text = "Сохранить как...";
            this.saveFileAs.Click += new System.EventHandler(this.saveFileAs_Click);
            // 
            // saveAllOpenedFiles
            // 
            this.saveAllOpenedFiles.Name = "saveAllOpenedFiles";
            this.saveAllOpenedFiles.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAllOpenedFiles.Size = new System.Drawing.Size(435, 26);
            this.saveAllOpenedFiles.Text = "Сохранение всех открытых файлов";
            this.saveAllOpenedFiles.Click += new System.EventHandler(this.saveAllOpenedFiles_Click);
            // 
            // openNewForm
            // 
            this.openNewForm.Name = "openNewForm";
            this.openNewForm.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.N)));
            this.openNewForm.Size = new System.Drawing.Size(435, 26);
            this.openNewForm.Text = "Открыть новое окно";
            this.openNewForm.Click += new System.EventHandler(this.openNewForm_Click);
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exit.Size = new System.Drawing.Size(435, 26);
            this.exit.Text = "Закрыть приложение";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // formatBtn
            // 
            this.formatBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.styleFont,
            this.colorFont});
            this.formatBtn.Name = "formatBtn";
            this.formatBtn.Size = new System.Drawing.Size(77, 24);
            this.formatBtn.Text = "Формат";
            // 
            // styleFont
            // 
            this.styleFont.Name = "styleFont";
            this.styleFont.Size = new System.Drawing.Size(190, 26);
            this.styleFont.Text = "Стиль шрифта";
            this.styleFont.Click += new System.EventHandler(this.styleFont_Click);
            // 
            // colorFont
            // 
            this.colorFont.Name = "colorFont";
            this.colorFont.Size = new System.Drawing.Size(190, 26);
            this.colorFont.Text = "Цвет шрифта";
            this.colorFont.Click += new System.EventHandler(this.colorFont_Click);
            // 
            // settingsBtn
            // 
            this.settingsBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backColorBtn,
            this.saveEvery10,
            this.saveEvery5});
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(98, 24);
            this.settingsBtn.Text = "Настройки";
            // 
            // backColorBtn
            // 
            this.backColorBtn.Name = "backColorBtn";
            this.backColorBtn.Size = new System.Drawing.Size(311, 26);
            this.backColorBtn.Text = "Цветовой фон";
            this.backColorBtn.Click += new System.EventHandler(this.backColorBtn_Click);
            // 
            // saveEvery10
            // 
            this.saveEvery10.Name = "saveEvery10";
            this.saveEvery10.Size = new System.Drawing.Size(311, 26);
            this.saveEvery10.Text = "Сохранение каждые 10 минуты";
            this.saveEvery10.Click += new System.EventHandler(this.saveEvery10_Click);
            // 
            // saveEvery5
            // 
            this.saveEvery5.Name = "saveEvery5";
            this.saveEvery5.Size = new System.Drawing.Size(311, 26);
            this.saveEvery5.Text = "Сохранение каждые 5 минут";
            this.saveEvery5.Click += new System.EventHandler(this.saveEvery5_Click);
            // 
            // addTab
            // 
            this.addTab.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.addTab.Name = "addTab";
            this.addTab.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.addTab.Size = new System.Drawing.Size(147, 24);
            this.addTab.Text = "Добавить вкладку";
            this.addTab.Click += new System.EventHandler(this.addTab_Click);
            // 
            // deleteTab
            // 
            this.deleteTab.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.deleteTab.Name = "deleteTab";
            this.deleteTab.Size = new System.Drawing.Size(136, 24);
            this.deleteTab.Text = "Удалить вкладку";
            this.deleteTab.Click += new System.EventHandler(this.deleteTab_Click);
            // 
            // infoBtn
            // 
            this.infoBtn.Name = "infoBtn";
            this.infoBtn.Size = new System.Drawing.Size(81, 24);
            this.infoBtn.Text = "Справка";
            this.infoBtn.Click += new System.EventHandler(this.infoBtn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 422);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 389);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Новая вкладка";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(786, 383);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAll,
            this.cutText,
            this.copyText,
            this.pasteText,
            this.formatFontContext});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(358, 124);
            // 
            // selectAll
            // 
            this.selectAll.Name = "selectAll";
            this.selectAll.Size = new System.Drawing.Size(357, 24);
            this.selectAll.Text = "Выбрать всё";
            this.selectAll.Click += new System.EventHandler(this.selectAll_Click);
            // 
            // cutText
            // 
            this.cutText.Name = "cutText";
            this.cutText.Size = new System.Drawing.Size(357, 24);
            this.cutText.Text = "Вырезать";
            this.cutText.Click += new System.EventHandler(this.cutText_Click);
            // 
            // copyText
            // 
            this.copyText.Name = "copyText";
            this.copyText.Size = new System.Drawing.Size(357, 24);
            this.copyText.Text = "Копировать";
            this.copyText.Click += new System.EventHandler(this.copyText_Click);
            // 
            // pasteText
            // 
            this.pasteText.Name = "pasteText";
            this.pasteText.Size = new System.Drawing.Size(357, 24);
            this.pasteText.Text = "Вставить";
            this.pasteText.Click += new System.EventHandler(this.pasteText_Click);
            // 
            // formatFontContext
            // 
            this.formatFontContext.Name = "formatFontContext";
            this.formatFontContext.Size = new System.Drawing.Size(357, 24);
            this.formatFontContext.Text = "Задать формат выделенного фрагмента";
            this.formatFontContext.Click += new System.EventHandler(this.formatFontContext_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileBtn;
        private System.Windows.Forms.ToolStripMenuItem editBtn;
        private System.Windows.Forms.ToolStripMenuItem formatBtn;
        private System.Windows.Forms.ToolStripMenuItem settingsBtn;
        private System.Windows.Forms.ToolStripMenuItem addTab;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem openFile;
        private System.Windows.Forms.ToolStripMenuItem saveFile;
        private System.Windows.Forms.ToolStripMenuItem saveFileAs;
        private System.Windows.Forms.ToolStripMenuItem saveAllOpenedFiles;
        private System.Windows.Forms.ToolStripMenuItem styleFont;
        private System.Windows.Forms.ToolStripMenuItem colorFont;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem deleteTab;
        private System.Windows.Forms.ToolStripMenuItem backColorBtn;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.ToolStripMenuItem infoBtn;
        private System.Windows.Forms.ToolStripMenuItem saveEvery10;
        private System.Windows.Forms.ToolStripMenuItem saveEvery5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem selectAll;
        private System.Windows.Forms.ToolStripMenuItem cutText;
        private System.Windows.Forms.ToolStripMenuItem copyText;
        private System.Windows.Forms.ToolStripMenuItem pasteText;
        private System.Windows.Forms.ToolStripMenuItem formatFontContext;
        private System.Windows.Forms.FontDialog fontDialog2;
        private System.Windows.Forms.ToolStripMenuItem openNewForm;
        private System.Windows.Forms.ToolStripMenuItem exit;
    }
}

