namespace InteractiveScottPlot
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ClickableScatterPlotButton_Click(object sender, EventArgs e) => new ClickableScatterPlotDemo().ShowDialog();
    }
}