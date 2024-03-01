using System;
using System.IO;
using System.Windows.Forms;

namespace os_lab_2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button_copy_click(object sender, EventArgs e) // Copy button
        {
            // Multiselect functionality:
            /* Firstly add
             *  - this.file_dialog.Multiselect = true;
             * Then the function itself:
             * 
             * DialogResult dr = this.openFileDialog1.ShowDialog();
             * if (dr != System.Windows.Forms.DialogResult.OK) { return; }
             * foreach (String file_name in openFileDialog1.FileNames) { ...
             *     * the current function goes here mostly unchanged *
             * }
             */
            try
            {
                if (is_file(this.textBox1.Text)) // copy a file
                {
                    string file_path_src = this.textBox1.Text;
                    string file_name = Path.GetFileName(file_path_src);
                    string file_path_dest = Path.Combine(this.textBox2.Text, file_name);
                    File.Copy(file_path_src, file_path_dest, true);
                }
                else // copy a folder & it's contents
                {
                    // create new dir
                    string dir_src = this.textBox1.Text;
                    string dir_dest = Path.Combine(this.textBox2.Text, Path.GetFileName(this.textBox1.Text));
                    DirectoryInfo source = new DirectoryInfo(dir_src);
                    DirectoryInfo destination = new DirectoryInfo(dir_dest);
                    copy_dir_recursive(source, destination);
                }
            }
            catch (Exception ex) // purely for debugging purposes
            {
                this.stoopid();
            }
        }
        public static void copy_dir_recursive(DirectoryInfo source, DirectoryInfo target) // It just works...
        {
            // recursive break
            if (source.FullName.ToLower() == target.FullName.ToLower()) { return; }

            // check if the target directory exists, otherwise create it.
            if (Directory.Exists(target.FullName) == false)
            {
                Directory.CreateDirectory(target.FullName);
            }

            // copy each file into new directory
            foreach (FileInfo fi in source.GetFiles())
            {
                Console.WriteLine(@"Copying {0}\{1}", target.FullName, fi.Name);
                fi.CopyTo(Path.Combine(target.ToString(), fi.Name), true);
            }

            // copy each subdirectory using recursion.
            foreach (DirectoryInfo sub_dirs in source.GetDirectories())
            {
                DirectoryInfo sub_dir = target.CreateSubdirectory(sub_dirs.Name);
                copy_dir_recursive(sub_dirs, sub_dir);
            }
        }
        private void button_move_click(object sender, EventArgs e) // Move button
        {
            try
            {
                // Move === Copy & Delete(src)
                string file_path_src = this.textBox1.Text;
                if (is_file(file_path_src))
                {
                    string file_name = Path.GetFileName(file_path_src);
                    string file_path_dest = Path.Combine(this.textBox2.Text, file_name);
                    File.Copy(file_path_src, file_path_dest, true);
                    File.Delete(file_path_src);
                }
                else
                {
                    string dir_src = this.textBox1.Text;
                    string dir_dest = Path.Combine(this.textBox2.Text, Path.GetFileName(this.textBox1.Text));
                    DirectoryInfo source = new DirectoryInfo(dir_src);
                    DirectoryInfo destination = new DirectoryInfo(dir_dest);
                    copy_dir_recursive(source, destination);
                    Directory.Delete(file_path_src, true); // delete a directory & it's contents
                }
            }
            catch (Exception ex) // purely for debugging purposes
            {
                this.stoopid();
            }
        }
        private void button_delete_click(object sender, EventArgs e) // Del button
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
        private void button_rename_click(object sender, EventArgs e) // Rename button
        {
            try
            {
                string file_path_src = this.textBox1.Text;
                if (is_file(file_path_src))
                {
                    string dir_name = Path.GetDirectoryName(file_path_src);
                    string new_file_name = Path.GetFileName(this.textBox3.Text);
                    string file_path_dest = Path.Combine(dir_name, new_file_name);
                    File.Copy(file_path_src, file_path_dest, true);
                    File.Delete(file_path_src);
                }
                else
                {
                    string dir_name = Path.GetDirectoryName(file_path_src);
                    string new_dir_name = this.textBox3.Text;
                    string new_dir_dest = Path.Combine(dir_name, new_dir_name);
                    DirectoryInfo source = new DirectoryInfo(file_path_src);
                    DirectoryInfo destination = new DirectoryInfo(new_dir_dest);
                    copy_dir_recursive(source, destination);
                    Directory.Delete(file_path_src, true); // delete a directory & it's contents
                }
            }
            catch (Exception ex) // purely for debugging purposes
            {
                this.stoopid();
            }
        }
        private void button_file_1_click(object sender, EventArgs e) // Scr button
        {
            OpenFileDialog file_dialog = new OpenFileDialog();
            
            file_dialog.InitialDirectory = this.textBox1.Text;
            file_dialog.RestoreDirectory = true;
            
            if (file_dialog.ShowDialog() == DialogResult.OK)
            {
                this.textBox1.Text = file_dialog.FileName;
            }
        }
        private void button_file_2_click(object sender, EventArgs e) // Scr button
        {
            OpenFileDialog file_dialog = new OpenFileDialog();
            
            file_dialog.InitialDirectory = this.textBox2.Text;
            file_dialog.RestoreDirectory = true;
            
            if (file_dialog.ShowDialog() == DialogResult.OK)
            {
                this.textBox2.Text = file_dialog.FileName;
            }
        }
        private void button_folder_1_click(object sender, EventArgs e) // Dest button
        {
            FolderBrowserDialog folder_dialog = new FolderBrowserDialog();
            if (folder_dialog.ShowDialog() == DialogResult.OK)
            {
                this.textBox1.Text = folder_dialog.SelectedPath;
            }
        }
        private void button_folder_2_click(object sender, EventArgs e) // Dest button
        {
            FolderBrowserDialog folder_dialog = new FolderBrowserDialog();
            if (folder_dialog.ShowDialog() == DialogResult.OK)
            {
                this.textBox2.Text = folder_dialog.SelectedPath;
            }
        }
        private void button_exchange_click(object sender, EventArgs e) // switch paths
        {
            string temp = this.textBox1.Text;
            this.textBox1.Text = this.textBox2.Text;
            this.textBox2.Text = temp;
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
            string message = "Неправильный порядок действий";
            string caption = "Внимание!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, caption, buttons);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
