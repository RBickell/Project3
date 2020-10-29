using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Project3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void OpenFileDialogBox_HelpRequest(object sender, EventArgs e)
        {
            
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
                string inputfile;
                OpenFileDialog OFD = new OpenFileDialog();
            string sfirst;
            string sLast;
            string Lword;
            string Vword;
            
            if (OFD.ShowDialog() == DialogResult.OK)
                {
                    inputfile = OFD.FileName;
                    string [] file = File.ReadAllText(inputfile, Encoding.ASCII).Split(new[] { ' ' },StringSplitOptions.RemoveEmptyEntries);
                    DataTable tbl = new DataTable();
                    tbl.Columns.Add("Words");
                    tbl.Columns.Add("Length");
                    tbl.Columns.Add("Vowels");
                    Array.Sort(file);
                    
                foreach (string s in file)
                {
                    if (s.Length > 0)
                    {
                        DataRow row = tbl.NewRow();
                        row["Words"] = s.ToLower();
                        row["Length"] = s.Length;
                        row["Vowels"] = s.Count(c => "aeiou".Contains(Char.ToLower(c)));
                        tbl.Rows.Add(row);
                    }
                        DGVInput.DataSource = tbl;
                    sfirst = file[0];
                    FirstWordTextBox.Text = sfirst;
                    sLast = file[file.Length-1];
                    LastWordTextBox.Text = sLast;

                    Lword="";
                    int ctr = 0;
                    foreach (String x in file)
                    {
                        if(x.Length>ctr)
                        {
                            Lword = x;
                            ctr = x.Length;
                        }
                    }
                    LongWordTextBox.Text = Lword;

                    char[] vowels = new char[] {'a','e','i','o','u'};
                    int mostVowels = 0;
                    Vword="";
                    int numberofvowels;

                    for (int i = 0; i < file.Length; i++)
                    {
                        string part = file[i];
                        numberofvowels = 0;
                        foreach (var vowel in vowels)
                        {
                            numberofvowels = part.Count("aeiouAEIOU".Contains);
                            /*if (part.Contains(vowel)) numberofvowels++;*/
                        }
                        if (mostVowels < numberofvowels)
                        {
                            mostVowels = numberofvowels;
                            Vword = part;
                        }
                    }    
                        VWordTextBox.Text = Vword;
                }
                StreamWriter outputfile;
                outputfile = File.CreateText("Projectoutputfile.txt");
                outputfile.WriteLine("First Word is " + FirstWordTextBox.Text);
                outputfile.WriteLine("Last Word is " + LastWordTextBox.Text);
                outputfile.WriteLine("Longest Word is " + LongWordTextBox.Text);
                outputfile.WriteLine("Most Vowel Word is " + VWordTextBox.Text);
                outputfile.Close();
                MessageBox.Show("Data has been written to file");
            }
                else
                {
                    MessageBox.Show("Operation Canceled");
                }
        }

        private void DGVInput_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
