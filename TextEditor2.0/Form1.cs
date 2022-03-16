using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Threading;

namespace TextEditor2._0
{
    public partial class Form1 : Form
    {
        public bool flag = false;
        public List<RichTextBox> rtb = new List<RichTextBox>();
        public List<bool> flags = new List<bool>();

        public Form1()
        {
            InitializeComponent();
            richTextBox1.ContextMenuStrip = contextMenuStrip1;
            colorDialog2.Color = richTextBox1.BackColor;

            openFileDialog1.Filter = "Text files(*.txt)|*.txt|Rtf files(*.rtf)|*.rtf|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|Rtf files(*.rtf)|*.rtf|All files(*.*)|*.*";
        }

        /// <summary>
        /// Changes flag on true if text is changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyTextChanged(object sender, EventArgs e)
        {
            int index = rtb.IndexOf((RichTextBox) sender);
            flags[index] = true;
        }

        /// <summary>
        /// Checks if there are any unsaved files and closes form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                int tabIndex = 0;
                foreach (var s in rtb)
                {
                    if (flags[rtb.IndexOf(s)])
                    {
                        var result =
                            MessageBox.Show(
                                $"{tabControl1.TabPages[rtb.IndexOf(s) + 1].Text} Имеются несохраненные данные. Сохранить их?",
                                "TextEditor", MessageBoxButtons.YesNoCancel);
                        if (DialogResult.Cancel == result)
                        {
                            e.Cancel = true;
                        }
                        else if (DialogResult.Yes == result)
                        {
                            if (File.Exists(tabControl1.TabPages[rtb.IndexOf(s) + 1].Text))
                            {
                                tabControl1.SelectedIndex = rtb.IndexOf(s) + 1;
                                saveFile_Click(sender, e);
                            }
                            else
                            {
                                tabControl1.SelectedIndex = rtb.IndexOf(s) + 1;
                                saveFileAs_Click(sender, e);
                            }
                        }
                        else if (DialogResult.No == result)
                        {
                            e.Cancel = false;
                        }

                        tabIndex++;
                    }

                    flags[rtb.IndexOf(s)] = false;
                }

                if (flag)
                {
                    var result =
                        MessageBox.Show($"{tabControl1.SelectedTab.Text} Имеются несохраненные данные. Сохранить их?",
                            "TextEditor", MessageBoxButtons.YesNoCancel);
                    if (DialogResult.Cancel == result)
                    {
                        e.Cancel = true;
                    }
                    else if (DialogResult.Yes == result)
                    {
                        if (File.Exists(tabControl1.SelectedTab.Text))
                        {
                            saveFile_Click(sender, e);
                        }
                        else
                        {
                            saveFileAs_Click(sender, e);
                        }
                    }
                    else if (DialogResult.No == result)
                    {
                        e.Cancel = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Changes the style of the font.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void styleFont_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
                foreach (var s in rtb)
                    s.SelectionFont = fontDialog1.Font;
            }
        }

        /// <summary>
        /// Changes color of the font.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void colorFont_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
                foreach (var s in rtb)
                    s.SelectionColor = colorDialog1.Color;
            }
        }

        /// <summary>
        /// Save file as *.txt or *.rtf.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveFileAs_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string filename = saveFileDialog1.FileName;
                    FileInfo fileInf = new FileInfo(filename);
                    if (fileInf.Extension == ".rtf")
                    {
                        if (Convert.ToInt32(tabControl1.SelectedIndex.ToString()) == 0)
                            richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
                        else
                        {
                            RichTextBox temp = rtb[Convert.ToInt32(tabControl1.SelectedIndex.ToString()) - 1];
                            temp.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
                        }
                    }
                    else
                    {
                        if (Convert.ToInt32(tabControl1.SelectedIndex.ToString()) == 0)
                            richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                        else
                        {
                            RichTextBox temp = rtb[Convert.ToInt32(tabControl1.SelectedIndex.ToString()) - 1];
                            temp.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Open text files.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;
                FileInfo fileInf = new FileInfo(filename);
                if (fileInf.Extension == ".rtf")
                {
                    if (Convert.ToInt32(tabControl1.SelectedIndex.ToString()) == 0)
                    {
                        richTextBox1.LoadFile(filename, RichTextBoxStreamType.RichText);
                        tabControl1.SelectedTab.Text = filename;
                    }
                    else
                    {
                        RichTextBox temp = rtb[Convert.ToInt32(tabControl1.SelectedIndex.ToString()) - 1];
                        //   dictRtbTabInfo[temp] = true;
                        temp.LoadFile(filename, RichTextBoxStreamType.RichText);
                        tabControl1.SelectedTab.Text = Path.GetFileNameWithoutExtension(filename);
                    }
                }
                else
                {
                    if (Convert.ToInt32(tabControl1.SelectedIndex.ToString()) == 0)
                    {
                        richTextBox1.Text = File.ReadAllText(filename);
                        tabControl1.SelectedTab.Text = filename;
                    }
                    else
                    {
                        RichTextBox temp = rtb[Convert.ToInt32(tabControl1.SelectedIndex.ToString()) - 1];
                        temp.Text = File.ReadAllText(filename);
                        tabControl1.SelectedTab.Text = filename;
                    }
                }

                flag = false;
            }
        }

        /// <summary>
        /// Change flag in true if text in richtextbox is changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            flag = true;
        }

        /// <summary>
        /// Save current file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(tabControl1.TabPages[tabControl1.SelectedIndex - 1].Text))
                {
                    FileInfo fileInf = new FileInfo(tabControl1.TabPages[tabControl1.SelectedIndex].Text);
                    if (fileInf.Extension == ".rtf")
                    {
                        if (Convert.ToInt32(tabControl1.SelectedIndex.ToString()) == 0)
                            richTextBox1.SaveFile(fileInf.FullName, RichTextBoxStreamType.RichText);
                        else
                        {
                            RichTextBox temp = rtb[Convert.ToInt32(tabControl1.SelectedIndex.ToString()) - 1];
                            temp.SaveFile(fileInf.FullName, RichTextBoxStreamType.RichText);
                        }
                    }
                    else
                    {
                        if (Convert.ToInt32(tabControl1.SelectedIndex.ToString()) == 0)
                            richTextBox1.SaveFile(fileInf.FullName, RichTextBoxStreamType.PlainText);
                        else
                        {
                            RichTextBox temp = rtb[Convert.ToInt32(tabControl1.SelectedIndex.ToString()) - 1];
                            temp.SaveFile(fileInf.FullName, RichTextBoxStreamType.PlainText);
                        }
                    }
                }
                else
                {
                    saveFileAs_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Add tabs in form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addTab_Click(object sender, EventArgs e)
        {
            TabPage newTabPage = new TabPage();
            newTabPage.Text = "Новая вкладка " + tabControl1.TabPages.Count;
            tabControl1.TabPages.Add(newTabPage);
            RichTextBox richTextBox = new RichTextBox();
            richTextBox.SelectionColor = colorDialog1.Color;
            richTextBox.SelectionFont = fontDialog1.Font;
            richTextBox.BackColor = colorDialog2.Color;
            richTextBox.Dock = DockStyle.Fill;
            newTabPage.Controls.Add(richTextBox);
            richTextBox.TextChanged += MyTextChanged;
            richTextBox.ContextMenuStrip = contextMenuStrip1;


            rtb.Add(richTextBox);
            flags.Add(false);
        }

        /// <summary>
        /// Deleting tabs.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteTab_Click(object sender, EventArgs e)
        {
            try
            {
                rtb.RemoveAt(Convert.ToInt32(tabControl1.SelectedIndex.ToString()) - 1);
                MessageBox.Show(Convert.ToString(Convert.ToInt32(tabControl1.SelectedIndex.ToString()) - 1));
                tabControl1.TabPages.Remove(tabControl1.SelectedTab);
            }
            catch
            {
                MessageBox.Show("Вы не можете удалить данную вкладку.");
            }
        }

        /// <summary>
        /// Change back color form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backColorBtn_Click(object sender, EventArgs e)
        {
            if (colorDialog2.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = colorDialog2.Color;
                foreach (var s in rtb)
                    s.BackColor = colorDialog2.Color;
            }
        }

        /// <summary>
        /// Shows important info.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void infoBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" +
                            "• Создание документа в новом окне; ctrl + alt + n" +
                            "• Создание документа в новой вкладке; ctrl + n" +
                            "• Сохранение текущего документа; ctrl + s" +
                            "• Сохранение всех открытых в окне документов. ctrl + shift + s " +
                            "• Закрытие приложения alt + f4 (да-да, не удивляйтесь, это просто знакомые вам клавиши, но они привязаны к закрытию)" +
                            "Таймер: При активации таймера будет идти сохранение файлов каждые n минут."
            );
        }

        /// <summary>
        /// Select all text.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selectAll_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        /// <summary>
        /// Paste text.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pasteText_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        /// <summary>
        /// Copy text.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void copyText_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        /// <summary>
        /// Cut selected text.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cutText_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        /// <summary>
        /// Changes style of selected text.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void formatFontContext_Click(object sender, EventArgs e)
        {
            styleFont_Click(sender, e);
        }

        /// <summary>
        /// Saves all opened files with changed text.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveAllOpenedFiles_Click(object sender, EventArgs e)
        {
            try
            {
                int tabIndex = 0;
                foreach (var s in rtb)
                {
                    if (flags[rtb.IndexOf(s)])
                    {
                        var result =
                            MessageBox.Show(
                                $"{tabControl1.TabPages[rtb.IndexOf(s) + 1].Text} Имеются несохраненные данные. Сохранить их?",
                                "TextEditor", MessageBoxButtons.YesNoCancel);
                        if (DialogResult.Yes == result)
                        {
                            if (File.Exists(tabControl1.TabPages[rtb.IndexOf(s) + 1].Text))
                            {
                                tabControl1.SelectedIndex = rtb.IndexOf(s) + 1;
                                saveFile_Click(sender, e);
                            }
                            else
                            {
                                tabControl1.SelectedIndex = rtb.IndexOf(s) + 1;
                                saveFileAs_Click(sender, e);
                            }
                        }

                        tabIndex++;
                    }

                    flags[rtb.IndexOf(s)] = false;
                }

                if (flag)
                {
                    if (File.Exists(tabControl1.SelectedTab.Text))
                    {
                        saveFile_Click(sender, e);
                    }
                    else
                    {
                        saveFileAs_Click(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Opens new form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openNewForm_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

        /// <summary>
        /// Saves every 5 minuts.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveEvery5_Click(object sender, EventArgs e)
        {
            try
            {
                timer1.Tick += new EventHandler(saveFile_Click);
                timer1.Interval = 300000;
                timer1.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Timer to save every 10 minuts.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveEvery10_Click(object sender, EventArgs e)
        {
            try
            {
                timer1.Tick += new EventHandler(saveFile_Click);
                timer1.Interval = 600000;
                timer1.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Exit.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}