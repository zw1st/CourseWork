namespace CourseWork
{
    public partial class FormStartParameters : Form
    {
        public delegate void _startParamtersDelegate(StartParameters startParameters);
        public event StartParametersDelegate StartParametersEvent;
        public FormStartParameters()
        {
            InitializeComponent();
            buttonCancel.Click += (sender, e) => Close();
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            Coin[] coins = {
                new Coin((int)numericUpDownFirstNominal.Value),
                new Coin((int)numericUpDownSecondNominal.Value),
                new Coin((int)numericUpDownThirdNominal.Value)
            };
            StartParameters startParameters = new StartParameters((int)numericUpDownSum.Value, coins);
            StartParametersEvent?.Invoke(startParameters);
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
