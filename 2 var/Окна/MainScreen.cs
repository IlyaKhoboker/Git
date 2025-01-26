using System;
using System.IO;
using System.Windows.Forms;

namespace Lexems
{
    public partial class MainScreen : Form
    {
        public string[] lines = null;

        public MainScreen()
        {
            InitializeComponent();
        }
        private void MainScreen_Load(object sender, EventArgs e)
        {
            wait.Text = "";
        }

        public string[] Lines
        {
            get { return lines; }
            set { lines = value; }
        }

        private void choose_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                file_path.Text = filePath;

                using (StreamReader reader = new StreamReader(filePath))
                {
                    string fileContent = reader.ReadToEnd();
                    try
                    {
                        lines = getFileText(filePath);
                        file_view.Lines = lines;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                    }
                }
            }
        }

        public string[] getFileText(string filePath)
        {
            return File.ReadAllLines(filePath);
        }

        private void upload_btn_Click(object sender, EventArgs e)
        {

        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lexems_btn_Click(object sender, EventArgs e)
        {
            wait.Text = "Пожалуйста, подождите";

            if (lines != null)
            {
                LookLexems lookScreen = new LookLexems();
                lookScreen.inputStr = lines;

                lookScreen.Show();

                wait.Text = "Данные были загружены";
            }
            else
            {
                wait.Text = "Неверный ввод данных";
            }
        }

        public class User32
        {
            [System.Runtime.InteropServices.DllImport("user32.dll")]
            public static extern bool SetForegroundWindow(IntPtr hWnd);
        }
    }
}
