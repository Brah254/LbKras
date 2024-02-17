using Timer = System.Windows.Forms.Timer;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        Timer timer = new Timer();
        public Form1()
        {
            InitializeComponent();
            timer.Tick += TimerTick;
            timer.Interval = 1000;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            int temp = allDrives.Length;
            dataGridView1.Columns.Add("Drive", "Drive");
            dataGridView1.Columns.Add("Type", "Type");
            dataGridView1.Columns.Add("TotalSize", "Total Size");
            dataGridView1.Columns.Add("FreeSpace", "Free Space");

            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                string[] row = {
                    drive.Name,
                    drive.DriveType.ToString(),
                    drive.TotalSize.ToString(),
                    drive.TotalFreeSpace.ToString(),
                };

                dataGridView1.Rows.Add(row);
            }
            timer.Start();
        }
        private void TimerTick(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
                foreach (DriveInfo drive in DriveInfo.GetDrives())
                {
                    string[] row = {
                    drive.Name,
                    drive.DriveType.ToString(),
                    drive.TotalSize.ToString(),
                    drive.TotalFreeSpace.ToString(),
                    };

                    dataGridView1.Rows.Add(row);
                }
            
        }

    }
}