namespace WF1
{
    public partial class FormConvert : Form
    {
        public FormConvert()
        {
            InitializeComponent();
        }

        Dictionary<string, double> lengthList = new Dictionary<string, double>();
        Dictionary<string, double> weightList = new Dictionary<string, double>();

        private void FormConvert_Load(object sender, EventArgs e)
        {

            //numericUpDown1.Maximum = Decimal.MaxValue;

            lengthList["m"] = 1;
            lengthList["in"] = 0.0254;
            lengthList["ft"] = 0.3048;
            lengthList["yd"] = 0.9144;

            weightList["g"] = 1000;
            weightList["kg"] = 1;

            string unit = weightList.getRefUnit();

            bool stop = true;

            comboBoxFrom.DataSource = lengthList.Keys.ToList();
            comboBoxTo.DataSource = lengthList.Keys.ToList();


        }

        private void comboBoxFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateResult();
        }

        private void comboBoxTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateResult();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            updateResult();
        }

        private void updateResult()
        {
            try
            {
                double result = (double)numericUpDown1.Value * lengthList[comboBoxFrom.Text] / lengthList[comboBoxTo.Text];
                textBoxResult.Text = result.ToString();
            }
            catch { }
        }


    }
}
