using System.Reflection;
using System.Windows.Forms;

namespace BakeTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Text += $" ({typeof(Form1).Assembly.GetName().Version})";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (labelSelectedAO.Text == "none")
                return;
            if (labelSelectedDirt.Text == "none")
                return;
            if (labelSelectedWear.Text == "none")
                return;

            var dialogResult = saveFileDialog1.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                MyClass.DoStuff(labelSelectedAO.Text, labelSelectedDirt.Text, labelSelectedWear.Text, saveFileDialog1.FileName);
            }
        }

        private void btnSelectAO_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Select AO";
            var dialogResult = openFileDialog1.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                labelSelectedAO.Text = openFileDialog1.FileName;
            }
            else
            {
                labelSelectedDirt.Text = "none";
            }
        }

        private void btnSelectDirt_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Select Dirt";
            var dialogResult = openFileDialog1.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                labelSelectedDirt.Text = openFileDialog1.FileName;
            }
            else
            {
                labelSelectedDirt.Text = "none";
            }
        }

        private void btnSelectWear_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Select Wear";
            var dialogResult = openFileDialog1.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                labelSelectedWear.Text = openFileDialog1.FileName;
            }
            else
            {
                labelSelectedWear.Text = "none";
            }
        }
    }
}