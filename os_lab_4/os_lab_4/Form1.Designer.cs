using System;
using System.Drawing;
using System.Threading;

namespace os_lab_4
{
    partial class Form1
    {
        // define threads as class fields
        private Thread thread1;
        private Thread thread2;
        

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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 40);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(706, 410);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "label1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += this.change_pannel1_thread_priority;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "label2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += this.change_pannel2_thread_priority;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(13, 185);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(74, 253);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(13, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(787, 27);
            this.panel2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Thread 1 priority";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Thread 2 priority";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Normal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Normal";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

            // launch timer thread
            ThreadStart thread_something1 = new ThreadStart(discoteque1);                   // turn function to thread function (?)
            ThreadStart thread_something2 = new ThreadStart(discoteque2);
            this.thread1 = new Thread(thread_something1);                                 // create thread
            this.thread2 = new Thread(thread_something2);
            this.thread1.IsBackground = true;                                                    // turn thread to daemon
            this.thread2.IsBackground = true;
            this.thread1.Start();                                                                // start thread
            this.thread2.Start();
//            Thread.CurrentThread.Priority = ThreadPriority.Highest;                         // set main thread priority
        }

        #endregion


        Color[] colors = { Color.AliceBlue, Color.Aqua, Color.Coral, Color.Cyan, Color.DarkOrchid };
        int i = 0;
        int j = 0;
        ThreadPriority[] priorities = {ThreadPriority.Lowest, ThreadPriority.BelowNormal, ThreadPriority.Normal, ThreadPriority.AboveNormal, ThreadPriority.Highest};
        String[] prioritiy_names = {"Lowest", "BelowNormal", "Normal", "AboveNormal", "Highest"};
        int panel1_priority = 3;
        int panel2_priority = 3;
        int delay1 = 800;
        int delay2 = 700;
        void change_pannel1_thread_priority(object sender, EventArgs e)
        {
            this.thread1.Priority = this.priorities[this.panel1_priority];      // set thread priority
            this.label3.Text = this.prioritiy_names[this.panel1_priority];      // set lable text
            this.panel1_priority = (this.panel1_priority + 1) % this.priorities.Length;
        }
        void change_pannel2_thread_priority(object sender, EventArgs e)
        {
            this.thread2.Priority = this.priorities[this.panel2_priority];      // set thread priority
            this.label4.Text = this.prioritiy_names[this.panel2_priority];      // set lable text
            this.panel2_priority = (this.panel2_priority + 1) % this.priorities.Length;
        }
        public void discoteque1()
        {
           while (true)
            {
                this.panel1.BackColor = this.colors[i];
                this.i = (this.i + 1) % this.colors.Length;
                Thread.Sleep(this.delay1);
            }
        }
        public void discoteque2()
        {
           while (true)
            {
                this.panel2.BackColor = this.colors[j];
                this.j = (this.j + 1) % this.colors.Length;
                Thread.Sleep(this.delay2);
            }
        }
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

