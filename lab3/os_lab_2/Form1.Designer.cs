using System.Windows.Forms;

namespace os_lab_2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.button_copy = new System.Windows.Forms.Button();
            this.button_move = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_file_1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_folder_1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_file_2 = new System.Windows.Forms.Button();
            this.button_folder_2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_rename = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_exchange = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Source";
            // 
            // button_copy
            // 
            this.button_copy.Location = new System.Drawing.Point(338, 187);
            this.button_copy.Name = "button_copy";
            this.button_copy.Size = new System.Drawing.Size(75, 23);
            this.button_copy.TabIndex = 5;
            this.button_copy.Text = "copy";
            this.button_copy.UseVisualStyleBackColor = true;
            this.button_copy.Click += new System.EventHandler(this.button_copy_click);
            // 
            // button_move
            // 
            this.button_move.Location = new System.Drawing.Point(338, 245);
            this.button_move.Name = "button_move";
            this.button_move.Size = new System.Drawing.Size(75, 23);
            this.button_move.TabIndex = 6;
            this.button_move.Text = "move";
            this.button_move.UseVisualStyleBackColor = true;
            this.button_move.Click += new System.EventHandler(this.button_move_click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(222, 276);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 23);
            this.button_delete.TabIndex = 7;
            this.button_delete.Text = "delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // button_file_1
            // 
            this.button_file_1.Location = new System.Drawing.Point(177, 5);
            this.button_file_1.Name = "button_file_1";
            this.button_file_1.Size = new System.Drawing.Size(75, 23);
            this.button_file_1.TabIndex = 9;
            this.button_file_1.Text = "Файл";
            this.button_file_1.UseVisualStyleBackColor = true;
            this.button_file_1.Click += new System.EventHandler(this.button_file_1_click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button_folder_1);
            this.panel1.Controls.Add(this.button_file_1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(77, 197);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 60);
            this.panel1.TabIndex = 10;
            // 
            // button_folder_1
            // 
            this.button_folder_1.Location = new System.Drawing.Point(177, 34);
            this.button_folder_1.Name = "button_folder_1";
            this.button_folder_1.Size = new System.Drawing.Size(75, 23);
            this.button_folder_1.TabIndex = 10;
            this.button_folder_1.Text = "Папка";
            this.button_folder_1.Click += new System.EventHandler(this.button_folder_1_click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button_file_2);
            this.panel2.Controls.Add(this.button_folder_2);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Location = new System.Drawing.Point(419, 197);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(255, 60);
            this.panel2.TabIndex = 11;
            // 
            // button_file_2
            // 
            this.button_file_2.Location = new System.Drawing.Point(177, 3);
            this.button_file_2.Name = "button_file_2";
            this.button_file_2.Size = new System.Drawing.Size(75, 23);
            this.button_file_2.TabIndex = 11;
            this.button_file_2.Text = "Файл";
            this.button_file_2.Click += new System.EventHandler(this.button_file_2_click);
            // 
            // button_folder_2
            // 
            this.button_folder_2.Location = new System.Drawing.Point(177, 32);
            this.button_folder_2.Name = "button_folder_2";
            this.button_folder_2.Size = new System.Drawing.Size(75, 23);
            this.button_folder_2.TabIndex = 9;
            this.button_folder_2.Text = "Папка";
            this.button_folder_2.UseVisualStyleBackColor = true;
            this.button_folder_2.Click += new System.EventHandler(this.button_folder_2_click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(3, 20);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(168, 20);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "C:\\Users\\nick\\Pictures\\Camera Roll";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(507, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Destination";
            // 
            // button_rename
            // 
            this.button_rename.Location = new System.Drawing.Point(117, 276);
            this.button_rename.Name = "button_rename";
            this.button_rename.Size = new System.Drawing.Size(75, 23);
            this.button_rename.TabIndex = 13;
            this.button_rename.Text = "rename";
            this.button_rename.Click += new System.EventHandler(this.button_rename_click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(432, 313);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(168, 20);
            this.textBox3.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(481, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "input name";
            // 
            // button_exchange
            // 
            this.button_exchange.Location = new System.Drawing.Point(339, 217);
            this.button_exchange.Name = "button_exchange";
            this.button_exchange.Size = new System.Drawing.Size(75, 23);
            this.button_exchange.TabIndex = 16;
            this.button_exchange.Text = "⇄";
            this.button_exchange.Click += new System.EventHandler(this.button_exchange_click);
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(77, 1);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(595, 168);
            this.textBox4.TabIndex = 18;
            this.textBox4.Text = resources.GetString("textBox4.Text");
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 427);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button_exchange);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button_rename);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_move);
            this.Controls.Add(this.button_copy);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private Button button_copy;
        private Button button_move;
        private Button button_delete;
        private Button button_file_1;
        private Button button_folder_2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Panel panel1;
        private Panel panel2;
        private Label label3;
        private Button button_rename;
        private Button button_folder_1;
        private Button button_file_2;
        private TextBox textBox3;
        private Label label1;
        private Button button_exchange;
        private TextBox textBox4;
    }
}

