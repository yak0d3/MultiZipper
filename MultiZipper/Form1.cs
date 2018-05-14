using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;
using System.IO;
using System.Threading;

namespace MultiZipper
{
    public partial class multizipper_form : Form
    {
        public multizipper_form()
        {
            InitializeComponent();

            bgw.WorkerReportsProgress = true;
            bgw.WorkerSupportsCancellation = true;

            bgw.DoWork += delegate
            {
                try
                {
                    ThreadPool.SetMinThreads(400,400); // You can make edits for the number of concurrent threads to be used. (Updates will be added in the next versions.
                    Parallel.ForEach(Directory.GetFiles(mainDir,extension).Select(Path.GetFileName), file =>
                    {

                            createZip(mainDir, oDir, file);
                            d++;
                            p++;
                            bgw.ReportProgress(p);
                    });
                }
                catch (Exception ex)
                {
                    f++;
                    p++;
                    bgw.ReportProgress(p);
                   // MessageBox.Show(ex.ToString()); // Remove '//' to activate the erros display.
                }
            };
            bgw.ProgressChanged += delegate
            {
                statLabel.Text = "Succeeded: "+d+"\nFailed: "+f+"\nProcessed: "+p+"/"+t; //updating the status label
            };

            bgw.RunWorkerCompleted += delegate
            {
                startBtn.Enabled = true;
                stopBtn.Enabled = false;
                browseBtn1.Enabled = true;
                browseBtn2.Enabled = true;
            };
        }


        private BackgroundWorker bgw = new BackgroundWorker();

        #region counters
        /* d for Succeeded, p for Processed, f for Failed and t for Total */
        private int d,p,f,t = 0;
        #endregion

        #region paths_variables
        private string mainDir = String.Empty; //main directory
        private string oDir = String.Empty; //outputs directory
        #endregion

        #region folderBrowsingDialogs
        private FolderBrowserDialog fbd1 = new FolderBrowserDialog();
        private FolderBrowserDialog fbd2 = new FolderBrowserDialog();
        #endregion

        private string extension = String.Empty;

        private void browseBtn1_Click(object sender, EventArgs e)
        {
            if (fbd1.ShowDialog() == DialogResult.OK)
            {
                t = Directory.GetFiles(fbd1.SelectedPath).Count();
                mainDir = fbd1.SelectedPath;
            }
        }

        private void browseBtn2_Click(object sender, EventArgs e)
        {
            
            if (fbd2.ShowDialog() == DialogResult.OK)
            {
                t = Directory.GetFiles(fbd2.SelectedPath).Count();
                oDir = fbd2.SelectedPath;
            }
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            bgw.Dispose();
            bgw.CancelAsync();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(fbd1.SelectedPath.Trim() != "")
            {
                if(fbd2.SelectedPath.Trim() != "")
                {
                    startBtn.Enabled = false;
                    stopBtn.Enabled = true;
                    browseBtn1.Enabled = false;
                    browseBtn2.Enabled = false;

                    if(extBox.Text.Trim() != "")
                    {
                        extension = "*." + extBox.Text.Replace(".","");
                    }
                    else
                    {
                        extension = "*";
                    }
                    d = 0;
                    p = 0;
                    f = 0;
                    t = Directory.GetFiles(mainDir,extension).Select(Path.GetFileName).Count();

                    bgw.RunWorkerAsync();
                }
                else
                {
                    MessageBox.Show("Please select the outputs directory.");
                }
            }
            else
            {
                MessageBox.Show("Please select the directory containing your files.");
            }
        }

        
        private void createZip(string main_path,string opath,string filename)
        {
                Directory.CreateDirectory(opath + @"\~" + filename);

                File.Copy(main_path + @"\" + filename, opath + @"\~" + filename + @"\" + filename);

                ZipFile.CreateFromDirectory(opath + @"\~" + filename, opath + @"\" + Path.GetFileNameWithoutExtension(filename) + ".zip");

                Directory.Delete(opath + @"\~" + filename, true);

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
