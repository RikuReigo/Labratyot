using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projektipohja
{
    public partial class MainForm : Form
    {
        private String EditorFileName = "Untitled";

        private void SetFormTitleText()

        {

            // Tiedoston nimi formiin. 

            FileInfo fileinfo = new FileInfo(EditorFileName);

            Text = fileinfo.Name + " - Editor";

        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MenuFileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MenuFile_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditorFileName = "Untitled";

            DocumentRichTextBox.Clear();

            SetFormTitleText();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ReadFile()
        {
            try

            {

                // Luodaan StreamReader objekti ja luetaan tiedosto. 

                using (StreamReader Reader = new StreamReader(EditorFileName))

                {

                    // Luku 

                    DocumentRichTextBox.Clear();

                    DocumentRichTextBox.Text = Reader.ReadToEnd();

                }

            }

            catch (IOException ex)

            {

                MessageBox.Show("Error: " + ex.Message, "Open File",

                                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void SaveFile()
        {
            try

            {

                // Luodaan SteramWriter objekti ja kirjoitetaan teksti tiedostoon. 

                using (StreamWriter StrWriter = new StreamWriter(EditorFileName))

                {

                    // Kirjoitus 

                    StrWriter.Write(DocumentRichTextBox.Text);

                }

            }

            catch (IOException ex)

            {

                MessageBox.Show("Error: " + ex.Message, "Save File",

                                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Luodaan standardi avausdialogiobjekti ja alustetaan se. 

            OpenFileDialog OpenFileDlg = new OpenFileDialog();

            OpenFileDlg.Title = "Open";

            OpenFileDlg.ShowReadOnly = true;

            OpenFileDlg.Filter = "Text documents (*.txt)|*.txt|All files|*.*";



            // Avataan windowsin standardi avausdialogi. 

            if (OpenFileDlg.ShowDialog() == DialogResult.OK)

            {

                // Talletetaan tiedoston nimi ja polku lukemista varten. 

                EditorFileName = OpenFileDlg.FileName;



                // Luetaan tiedosotn sisältö ja tuodaan se näytölle. 

                ReadFile();



                SetFormTitleText();

            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (EditorFileName == "Untitled")

            {

                saveAsToolStripMenuItem_Click(sender, e);

            }

            else

            {

                SaveFile();

            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Luodaan standardi talletusdialogiobjekti ja alustetaan se. 

            SaveFileDialog SaveFileDlg = new SaveFileDialog();

            SaveFileDlg.Filter = "Text documents (*.txt)|*.txt|All files|*.*";



            // Avataan windowsin standardi talletusdialogi. 

            if (SaveFileDlg.ShowDialog() == DialogResult.OK)

            {

                // Talletetaan tiedoston nimi ja polku talletusta varten. 

                EditorFileName = SaveFileDlg.FileName;



                SaveFile();



                SetFormTitleText();

            }
        }
    }
}
