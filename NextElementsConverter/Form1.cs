using MetroFramework.Forms;
using NextElementsConverter.ElementsFile;
using System.Windows.Forms;
using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Linq;
using MetroFramework;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace NextElementsConverter
{
    public partial class MainForm : MetroForm
    {
        eListCollection src_el;
        eListCollection dst_el;
        string[] files;

        public MainForm()
        {
            InitializeComponent();
            files = Directory.GetFiles(Path.Combine(Application.StartupPath, "Configs"), "*.cfg");
            foreach (string file in files)
            {
                int.TryParse(Regex.Match(Path.GetFileName(file), @"v(\d+)").Groups[1].Value, out int v);
                version_list.Items.Add(v);
            }
            version_list.SelectedIndex = 0;
        }

        private void src_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                src_el = new eListCollection(ofd.FileName, this);
                src_txt.Text = string.Format("Версия: {0}", src_el.Version);
            }
        }

        private void convert_Click(object sender, EventArgs e)
        {
            short.TryParse(version_list.Text, out short dst_version);
            if (src_el.Version < dst_version)
            {
                MetroMessageBox.Show(this, "Мы крайне не рекомендуем использовать конвертирование в версию выше!", "Предупреждение");
            }
            if (src_el.Version == dst_version)
            {
                MetroMessageBox.Show(this, "Странно конвертировать в ту же версию!", "Предупреждение");
            }
            eListCollection dst_el = new eListCollection(this);
            eList[] conf = dst_el.loadConfiguration(files.Where(x => x.Contains(string.Format("v{0}.cfg", dst_version))).First());
            dst_el.Lists = conf;
            dst_el.Version = dst_version;
            dst_el.Signature = src_el.Signature;
            Progress.Visible = true;
            Progress.Maximum = dst_el.Lists.Length;
            for (int i = 0; i < dst_el.Lists.Length; ++i)
            {
                ++Progress.Value;
                if (i != dst_el.ConversationListIndex)
                {
                    var list = src_el.Lists.Where(x => x.listName == dst_el.Lists[i].listName).ToList();
                    if (list.Count > 0)
                    {
                        Dictionary<int, int> field_index = new Dictionary<int, int>();
                        for (int j = 0; j < dst_el.Lists[i].elementFields.Length; ++j)
                        {
                            int src = Array.IndexOf(list.First().elementFields, dst_el.Lists[i].elementFields[j]);
                            field_index.Add(j, src);
                        }
                        dst_el.Lists[i].elementValues = new object[list.First().elementValues.Length][];
                        dst_el.Lists[i].listOffset = list.First().listOffset;
                        for (int j = 0; j < list.First().elementValues.Length; ++j)
                        {
                            Application.DoEvents();
                            object[] values = new object[dst_el.Lists[i].elementFields.Length];
                            for (int k = 0; k < dst_el.Lists[i].elementFields.Length; ++k)
                            {
                                if (field_index.ContainsKey(k) && field_index[k] != -1)
                                {
                                    values[k] = list.First().elementValues[j][field_index[k]];
                                }
                                else
                                {
                                    values[k] = GetEmptyValue(dst_el.Lists[i].elementTypes[k]);
                                }
                            }
                            dst_el.Lists[i].elementValues[j] = values;
                        }
                    }
                    else
                    {
                        dst_el.Lists[i].elementValues = new object[0][];
                        dst_el.Lists[i].listOffset = BitConverter.GetBytes(0);
                    }
                }
                else
                {
                    dst_el.Lists[i] = src_el.Lists[i];
                }
            }
            Progress.Visible = false;
            Progress.Value = 0;
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                dst_el.Save(sfd.FileName);
            }
        }

        private object GetEmptyValue(string type)
        {
            if (type.Contains("int"))
            {
                return int.Parse(empty_int.Text);
            }
            if (type.Contains("float"))
            {
                return float.Parse(empty_float.Text);
            }
            if (type.Contains("wstring"))
            {
                return Encoding.Unicode.GetBytes(empty_string.Text);
            }
            if (type.Contains("string"))
            {
                return Encoding.GetEncoding(936).GetBytes(empty_string.Text);
            }
            return "";
        }

        private void dst_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                dst_el = new eListCollection(ofd.FileName, this);
                dst_txt.Text = string.Format("Версия: {0}", dst_el.Version);
                split.Enabled = true;
            }
        }

        private void split_Click(object sender, EventArgs e)
        {
            
        }
    }
}
