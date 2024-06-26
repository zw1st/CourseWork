namespace CourseWork
{
    public partial class FormFinish : Form
    {
        public FormFinish(string coin, string sum)
        {
            InitializeComponent();
            labelCoin.Text += coin;
            labelSum.Text += sum;
        }
    }
}
