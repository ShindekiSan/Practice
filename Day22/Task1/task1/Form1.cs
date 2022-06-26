namespace task1
{
    public partial class Form1 : Form
    {
        List<Button> buttons;
        Form appForm;
        public Form1()
        {
            InitializeComponent();
            appForm = new Form();
            buttons = new List<Button>();
            buttons.AddRange(new Button[4] { button1, button2, button3, button4 });
            button1.Click += button1_Click;
            button2.Click += button1_Click;
            button3.Click += button1_Click;
            button4.Click += button1_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            appForm.BackColor = System.Drawing.Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            appForm.BackColor = System.Drawing.Color.Green;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            appForm.BackColor = System.Drawing.Color.Blue;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            appForm.BackColor = System.Drawing.Color.Yellow;
        }
    }
}