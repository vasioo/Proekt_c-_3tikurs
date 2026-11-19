using System.Globalization;

namespace Proekt
{
    public partial class Form1 : Form
    {

        private readonly List<ConversionRecord> history = new();

        private class ConversionRecord{
            public int Category { get; set; }
            public string Description { get; set; } = "";
        }


        public Form1()
        {
            InitializeComponent();

            comboDropdown.SelectedIndex = 0;
            rbMetricImperial.Checked= true;

            UpdateUnitLabels();
            UpdateStats();
        }

        private void UpdateUnitLabels()
        {
            int category = comboDropdown.SelectedIndex;
            if (category < 0)
            {
                return;
            }

            bool metric = rbMetricImperial.Checked;
            lblRes.Text = "-";

        }

        private void UpdateStats()
        {
            int[] counts = new int[4];

            foreach (ConversionRecord record in history)
            {
                if (record.Category >= 0 && record.Category < counts.Length)
                {
                    counts[record.Category]++;
                }
            }

            lblLength.Text = $"Дължина: {counts[0]}";
            lblWeight.Text = $"Маса: {counts[1]}";
            lblVolume.Text = $"Обем: {counts[2]}";
            lblTemperature.Text = $"Температура: {counts[3]}";

        }

        private bool ValidateInput(out double value)
        {
            value = 0;

            string input = txtEntryData.Text.Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Моля въведете стойност.",
                    "Невалидни данни",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtEntryData.Focus();
                return false;
            }

            bool valid = double.TryParse(
                input, 
                System.Globalization.NumberStyles.Float,
                CultureInfo.CurrentCulture,
                out value);

            if (!valid)
            {
                MessageBox.Show("Моля въведете валидно число.",
                    "Невалидни данни",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtEntryData.Focus();
                return false;
            }

            if (double.IsNaN(value) || double.IsInfinity(value))
            {
                MessageBox.Show("Стойността трябва да е крайно число.",
                    "Невалидни данни",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }

            if (comboDropdown.SelectedIndex < 0)
            {
                MessageBox.Show("Моля изберете категория.",
                    "Невалидни данни",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }

            if(comboDropdown.SelectedIndex!=3 && value < 0)
            {
                MessageBox.Show("Дължината, масата и обема не може да са отрицатени.",
                    "Невалидни данни",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtEntryData.Focus();
                return false;
            }
            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if(!ValidateInput(out double value))
            {
                return;
            }

            int category = comboDropdown.SelectedIndex;
            bool metric = rbMetricImperial.Checked;

            double result = ConversionHelper.ConvertValue(
                category, metric, value);

            if (double.IsNaN(result) || double.IsInfinity(result))
            {
                MessageBox.Show(
                    "Резултата е извън допустимия диапазон",
                    "Грешка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return;
            }

            string format = chckFourAfterDecimal.Checked ? "F4" : "F2";

            string inputUnit = ConversionHelper.GetUnit(category, metric);
            string outputUnit = ConversionHelper.GetUnit(category, !metric);

            string inputText = value.ToString(format);
            string resultText = result.ToString(format);

            lblRes.Text = resultText;

            string description = $"{inputText} {inputUnit} = {resultText} {outputUnit}";

            history.Add(new ConversionRecord
            {
                Category = category,
                Description = description
            });

            listBoxHistory.Items.Add(description);

            UpdateStats();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = listBoxHistory.SelectedIndex;

            if (index < 0)
            {
                MessageBox.Show("Трябва да изберете запис за изтриване",
                    "Няма избран запис",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            history.RemoveAt(index);

            listBoxHistory.Items.RemoveAt(index);

            UpdateStats();

        }
    }
}
