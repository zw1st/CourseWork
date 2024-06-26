using System.Drawing;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class FormVisualizer : Form
    {
        private Drawing? _drawer;
        private StartParameters _parameters;
        private Container? _container;
        public FormVisualizer()
        {
            InitializeComponent();
            _drawer = new Drawing(pictureBoxVisualizer.Width, pictureBoxVisualizer.Height);
            _container = new();
            buttonMakeStepForward.Enabled = false;
            buttonMakeStepReverse.Enabled = false;
        }
        private void StartParametersEventHandler(StartParameters startParameters)
        {
            _parameters = startParameters;
            labelCoinAmout.Text = 0.ToString();
            labelCurrentRemain.Text = startParameters.Sum.ToString();
            buttonMakeStepForward.Enabled = true;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            FormStartParameters form = new();
            form.StartParametersEvent += StartParametersEventHandler;
            form.ShowDialog();
            if (_parameters != null)
            {
                Ruler ruler = new Ruler(_parameters);
                _container = ruler.Perform();
            }
        }

        public void DrawObject(Status status)
        {
            Bitmap bmp = new(pictureBoxVisualizer.Width, pictureBoxVisualizer.Height);
            Graphics gr = Graphics.FromImage(bmp);
            DrawStart(bmp, status);
            labelCoinAmout.Text = status.Amount.ToString();
            labelCurrentRemain.Text = status.Sum.ToString();
            _drawer?.DrawStatus(gr, status, _container.Get(_container.Length() - 1));
            pictureBoxVisualizer.Image = bmp;
        }
        public void DrawStart(Bitmap bmp, Status status)
        {
            Pen pen = new Pen(Color.Black, 3);
            Brush numberBrush = new SolidBrush(Color.Black);
            Brush brush = new SolidBrush(Color.Gold);
            Font font = new Font("Arial", 12);
            Graphics gr = Graphics.FromImage(bmp);
            gr.DrawRectangle(pen, 20, 20, 90, 230);
            for (int i = 0; i < 3; i++)
            {
                gr.DrawEllipse(pen, 40, 40 + i * 70, 50, 50);
                gr.FillEllipse(brush, 40, 40 + i * 70, 50, 50);
                gr.DrawString(status.GetNominal(i).ToString(), font, numberBrush, 40 + 12, 40 + 12 + i * 70);
            }
            pictureBoxVisualizer.Image = bmp;
        }

        private void buttonMakeStep_Click(object sender, EventArgs e)
        {
            try
            {
                if (_container != null)
                {

                    DrawObject(_container.Get(_container.ind));
                    _container.ind++;
                    buttonMakeStepReverse.Enabled = true;
                }
            }
            catch (ArgumentOutOfRangeException) 
            { 
                if (_container.ind >= _container.Length())
                {
                    FormFinish form = new FormFinish(labelCoinAmout.Text, labelCurrentRemain.Text);
                    
                    form.ShowDialog();
                    buttonMakeStepForward.Enabled = false;
                    _container.ind--;
                }
            }
        }

        private void buttonMakeStepReverse_Click(object sender, EventArgs e)
        {
            try
            {
                if (_container != null)
                {
                    _container.ind--;
                    DrawObject(_container.Get(_container.ind));
                    
                    buttonMakeStepForward.Enabled = true;
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                if (_container.ind < 0)
                {
                    
                    buttonMakeStepReverse.Enabled = false;
                    _container.ind++;
                }
                
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (_container.WriteFile(saveFileDialog.FileName))
                {
                    MessageBox.Show("Сохранение прошло успешно",
                    "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {
                    MessageBox.Show("Не сохранилось", "Результат",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (_container.ReadFile(openFileDialog.FileName))
                {
                    MessageBox.Show("Загрузка прошла успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    buttonMakeStepForward.Enabled = true;

                }
                else
                {
                    MessageBox.Show("Не удалось сохранить", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void InfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMenu form = new();
            form.Show();
        }
    }
}
