namespace SpWinFormsThreadsApp
{
    public partial class Form1 : Form
    {
        class ThreadBox
        {
            public Brush Brush { get; set; }
            public bool Cancel { get; set; }
        }

        Random random = new Random();
        int size = 10;

        bool cancelRed;
        bool cancelBlue;

        ThreadBox redBox = new ThreadBox() { Brush = Brushes.Red, Cancel = false };
        ThreadBox blueBox = new ThreadBox() { Brush = Brushes.Blue, Cancel = false };

        public Form1()
        {
            InitializeComponent();
        }

        private void btnThreadRed_Click(object sender, EventArgs e)
        {
            redBox.Cancel = false;
            btnThreadRedStart.Enabled = false;
            btnThreadRedStop.Enabled = true;

            Task task = new Task(DrawRandomRectangle, redBox);
            task.Start();

            //Thread thread = new Thread(DrawRandomRectangle);
            //thread.IsBackground = true;
            //thread.Start(Brushes.Red);
        }

        private void btnThreadBlue_Click(object sender, EventArgs e)
        {
            cancelBlue = false;

            Task task = new Task(DrawRandomRectangle, Brushes.Blue);
            task.Start();

            //Thread thread = new Thread(DrawRandomRectangle);
            //thread.IsBackground = true;
            //thread.Start(Brushes.Blue);
        }

        private void DrawRandomRectangle(object obj)
        {
            Brush brush = (obj as ThreadBox).Brush;

            while (!(obj as ThreadBox).Cancel)
            {
                int x = random.Next(0, this.Width - 3 * size);
                int y = random.Next(55, this.Height - 3 * size);

                this.CreateGraphics()
                    .DrawRectangle(
                        new Pen(brush, 2),
                        new Rectangle(x, y, size, size));
                Thread.Sleep(100);
            }

            btnThreadRedStart.Enabled = true;
            btnThreadRedStop.Enabled = false;
        }

        private void btnThreadRedStop_Click(object sender, EventArgs e)
        {
            redBox.Cancel = true;
        }

        private void btnThreadBlueStop_Click(object sender, EventArgs e)
        {
            cancelBlue = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            redBox.Cancel = true;
            blueBox.Cancel = true;
        }
    }
}
