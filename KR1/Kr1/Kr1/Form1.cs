namespace Kr1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string path = this.textBox1.Text;
                if (is_file(path))
                {
                    File.Delete(path); // delete a file
                }
                else
                {
                    Directory.Delete(path, true); // delete a directory & it's contents
                }
            }
            catch
            {
                this.stoopid();
            }
        }
        private bool is_file(string path)
        {
            // get the file attributes for file or directory
            FileAttributes attr = File.GetAttributes(path);

            //detect whether its a directory or file
            if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
                return false;
            else
                return true;
        }
        private void stoopid()
        {
            string message = "Возможно неверно задан путь к файлу";
            string caption = "Внимание!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, caption, buttons);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder_dialog = new FolderBrowserDialog();
            if (folder_dialog.ShowDialog() == DialogResult.OK)
            {
                this.textBox1.Text = folder_dialog.SelectedPath;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            OpenFileDialog file_dialog = new OpenFileDialog();

            file_dialog.InitialDirectory = this.textBox1.Text;
            file_dialog.RestoreDirectory = true;

            if (file_dialog.ShowDialog() == DialogResult.OK)
            {
                this.textBox1.Text = file_dialog.FileName;
            }
        }
    }
}