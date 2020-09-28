using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Net;
using System.Text.Encodings.Web;
using System.Security.Policy;
using System.Web;
using NLog;
using System.Threading;

namespace Linker
{
    public partial class Form1 : Form
    {
        Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillInsertCombo();
            cmCategory.SelectedIndex = 0;
            ShowLinks();
            StyleGrid();
            if (File.Exists("link.gif"))
            {
                pictureBox1.Image = Properties.Resources.link;
            }
            ctmnuReload.Click += new System.EventHandler(this.ctmnuReload_Click);
            ctmnuBackup.Click += new System.EventHandler(this.ctmnuBackup_Click);
        }

        /// <summary>
        /// Combo box contains category content like shopping,
        /// news etc. change category.xml file to add new
        /// </summary>
        private void FillInsertCombo()
        {
            LoadXML(@"category.xml", cmAddCategory);
            if (cmCategory.Items.Count > 0)
                cmCategory.SelectedIndex = 0;
        }

        private void ctmnuReload_Click(object sender, System.EventArgs e)
        {
            ShowLinks();
        }

        private void ctmnuBackup_Click(object sender, System.EventArgs e)
        {
            Backup();
        }

        /// <summary>
        /// Backup SQLite database
        /// </summary>
        private void Backup()
        {
            string strSuffix = "";
            strSuffix = DateTime.Now.ToString("ddMMyy_HHmmss");
            File.Copy(Application.StartupPath + "MyBookmarks.db3", Application.StartupPath +
                "MyBookmarks_backup_" + strSuffix + ".db3");
            if (File.Exists("MyBookmarks_backup_" + strSuffix + ".db3"))
            {
                MessageBox.Show("Info", "Backup " + strSuffix + " created.",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void StyleGrid()
        {
            dataGridView1.RowTemplate.Resizable = DataGridViewTriState.True;
            dataGridView1.RowTemplate.Height = 14;
            this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.Bisque;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor =
                Color.Beige;
        }

        /// <summary>
        /// Show All
        /// </summary>
        private void ShowLinks()
        {

            using (SQLiteConnection cs = new SQLiteConnection(@"Data Source=MyBookmarks.db3"))
            {
                try
                {
                    cs.Open();
                    SQLiteDataAdapter da = new SQLiteDataAdapter();
                    da.SelectCommand = new SQLiteCommand("select * from tblLinks;", cs);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cs.Close();
                    dataGridView1.DataSource = dt;

                    statuslabel.Text = "Found: " + dataGridView1.Rows.Count;
                    da.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    txSearch.Text = "%";
                    cmCategory.SelectedIndex = 0;
                }
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txSearch.Text))
            {
                SearchLink(cmCategory.Text, txSearch.Text);
            }
            else
            {
                MessageBox.Show("Error", "Search empty!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        /// <summary>
        /// Query
        /// </summary>
        /// <param name="col">string Table Column</param>
        /// <param name="txt">string Search</param>
        private void SearchLink(string col, string txt)
        {
            using (SQLiteConnection cs = new SQLiteConnection(@"Data Source=MyBookmarks.db3"))
            {
                try
                {
                    cs.Open();
                    SQLiteDataAdapter da = new SQLiteDataAdapter();
                    da.SelectCommand = new SQLiteCommand("SELECT * FROM tblLinks WHERE " + col + " LIKE '" + txt + "';", cs);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cs.Close();
                    dataGridView1.DataSource = dt;
                    statuslabel.Text = "Found: " + dataGridView1.Rows.Count;
                    da.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                txLink.Text = Convert.ToString(selectedRow.Cells[1].Value);
            }

        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            InsertItem();
        }

        private void OpenUrl(string url)
        {
            try
            {
                System.Diagnostics.Process.Start(url);
            }
            catch
            {
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    url = url.Replace("&", "^&");
                    Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    Process.Start("xdg-open", url);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    Process.Start("open", url);
                }
                else
                {
                    MessageBox.Show("Error", "URL Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btStartURL_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txLink.Text))
            {
                OpenUrl(txLink.Text);
            }
            else
            {
                MessageBox.Show("Error", "URL empty!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                try
                {
                    btSearch.PerformClick();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n" + ex.Source);
                }
            }
        }

        /// <summary>
        /// Load XML File to ComboBox
        /// </summary>
        /// <param name="xmlFileName">string Filename</param>
        /// <param name="cmCategory">ComboBox Name</param>
        private void LoadXML(string xmlFileName, ComboBox cmCategory)
        {
            if (File.Exists(System.Windows.Forms.Application.StartupPath + xmlFileName))
            {
                XmlTextReader xtr = null;
                string filename = xmlFileName;
                try
                {
                    try
                    {
                        xtr = new XmlTextReader(filename);
                        xtr.WhitespaceHandling = WhitespaceHandling.None;
                        while (xtr.Read())
                        {
                            switch (xtr.NodeType)
                            {
                                case XmlNodeType.Text:
                                    cmCategory.Items.Add(xtr.Value);
                                    // select 1st element if cmbXml.SelectedIndex = 0
                                    // cmbXml.SelectedIndex = 0;
                                    break;
                                case XmlNodeType.Whitespace:
                                    break;
                                case XmlNodeType.XmlDeclaration:
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        GetException(ex);
                    }

                }
                finally
                {
                    if (xtr != null)
                        xtr.Close();
                }
            }
            else
            {
                MessageBox.Show("introuvable : " + xmlFileName);
            }
        }

        /// <summary>
        /// GetException
        /// </summary>
        /// <param name="ex">Exception ex</param>
        internal void GetException(Exception ex)
        {
            if (ex.InnerException != null)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace + "\n" + ex.InnerException.Message);
            }
        }

        /// <summary>
        /// Insert Link
        /// </summary>
        private void InsertItem()
        {
            using (SQLiteConnection cs = new SQLiteConnection(@"Data Source=MyBookmarks.db3"))
            {
                SQLiteCommand insertCmd = cs.CreateCommand();
                insertCmd.CommandText = "INSERT INTO tblLinks(URL, CATEGORY, KEYWORDS) VALUES (@url, @cat, @keyw)";

                cs.Open();
                insertCmd.Parameters.AddWithValue("url", txAddURL.Text);
                insertCmd.Parameters.AddWithValue("cat", cmAddCategory.Text);
                insertCmd.Parameters.AddWithValue("keyw", txAddKeywords.Text);
                int result = insertCmd.ExecuteNonQuery();
                if (result == 0)
                {
                    MessageBox.Show("Error", "Insert Query Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Success", "Your data has been added.",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                cs.Close();
                tabControl1.SelectedTab = tabPage1;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selTabName = tabControl1.SelectedTab.Name;

            switch (selTabName)
            {
                case "tabPage1":
                    ShowLinks();
                    break;
                case "tabPage2":
                    statuslabel.Text = "Add new link";
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Gets favicon from base url
        /// </summary>
        private void ShowFavIcon()
        {
            var builder = new UriBuilder(txLink.Text);
            builder.Path = String.Empty;
            var baseUri = builder.Uri;
            var baseUrl = baseUri.ToString();

            try
            {
                if (ClassUtility.DoesUrlRespond(baseUrl))
                {
                    //logger.Info("favicon found.");
                    Image img = ClassUtility.GetFavIcon(baseUrl);
                    pictureBox2.Image = img;
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message + Environment.NewLine + "Default NOFAVICON set.");
            }
        }

        private void txLink_TextChanged(object sender, EventArgs e)
        {
            Thread thread = new Thread(ShowFavIcon);
            thread.Start();
        }
    }
}
