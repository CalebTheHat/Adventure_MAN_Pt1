namespace Adventure_MAN_Pt1
{
    public partial class Form1 : Form
    {
        private GameEngine _GameEngine;
        public Form1()
        {
            InitializeComponent();

            _GameEngine = new GameEngine(10);
            _displayEngine();
        }

        private void _displayEngine()
        {
            lblDisplay.Text = _GameEngine.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblDisplay_Click(object sender, EventArgs e)
        {

        }
    }
}