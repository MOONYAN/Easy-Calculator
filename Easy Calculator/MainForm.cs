using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Easy_Calculator
{
    public partial class MainForm : Form
    {
        Form _echoForm;
        Model _model = new Model();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CreateNumberButtons();
        }

        private void CreateNumberButtons()
        {
            for (int i = 0; i < 10; i++)
            {
                Button button = new Button()
                {
                    Margin = new Padding(20),
                    Dock = DockStyle.Fill,
                    Text = i + "",
                    AccessibleName = i + ""
                };
                button.Click += ClickNumberButton;
                _numbersTableLayoutPanel.Controls.Add(button);
            }
        }

        private void ClickNumberButton(object sender, EventArgs e)
        {
            Button button = sender as Button;
            _monitorLabel.Text = _monitorLabel.Text + button.Text;
        }

        private void ClickResultButton(object sender, EventArgs e)
        {
            int number = 0;
            int.TryParse(_monitorLabel.Text, out number);
            _model.DoOperation(number);
            int result = _model.GetResult();
            _monitorLabel.Text = result + "";
        }

        private void ClickPlusButton(object sender, EventArgs e)
        {
            int number = 0;
            int.TryParse(_monitorLabel.Text, out number);
            //int number = int.Parse(_monitorLabel.Text);
            _model.SetPlusMode(number);
            _monitorLabel.Text = "";
        }

        private void ClickMinusButton(object sender, EventArgs e)
        {
            int number = 0;
            int.TryParse(_monitorLabel.Text, out number);
            _model.SetMinusMode(number);
            _monitorLabel.Text = "";
        }

        private void ClickClearButton(object sender, EventArgs e)
        {
            _monitorLabel.Text = "";
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fuck", "Caption");
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _echoForm?.Close();
            _echoForm = new EchoForm();
            _echoForm.Show();
        }
    }
}
