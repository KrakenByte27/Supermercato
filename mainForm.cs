namespace Supermercato
{
    public partial class mainForm : Form
    {
        decimal totale;

        public mainForm()
        {
            InitializeComponent();
        }
        private void mainForm_Load(object sender, EventArgs e)
        {
            #region Preparazione elementi

            addButton.Enabled = false;
            addButton.BackColor = Color.FromArgb(200, 200, 200);

            removeprdButton.Enabled = false;
            removeprdButton.BackColor = Color.FromArgb(200, 200, 200);

            addprdButton.Enabled = false;
            addprdButton.BackColor = Color.FromArgb(200, 200, 200);

            #endregion
        }

        #region Bottoni

        private void cleanButton_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Vuoi pulire tutti i campi?", "Avviso",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Application.Restart();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if ((string)productListBox.Items[0] == "-" || (string)priceListBox.Items[0] == "-")
            {
                priceListBox.Enabled = true;
                productListBox.Enabled = true;

                productListBox.Items.Clear();
                priceListBox.Items.Clear();

                productListBox.Items.Add(descTextBox.Texts);
                priceListBox.Items.Add(priceTextBox.Texts);

                priceTextBox.Texts = "";
                descTextBox.Texts = "";
                descTextBox.Enabled = false;
                descTextBox.Enabled = true;
                descTextBox.Focus();
            }
            else
            {
                priceListBox.Enabled = true;
                productListBox.Enabled = true;

                productListBox.Items.Add(descTextBox.Texts);
                priceListBox.Items.Add(priceTextBox.Texts);

                priceTextBox.Texts = "";
                descTextBox.Texts = "";
                descTextBox.Enabled = false;
                descTextBox.Enabled = true;
                descTextBox.Focus();
            }
        }

        private void removeprdButton_Click(object sender, EventArgs e)
        {
            if (productListBox.Items.Count == 1|| priceListBox.Items.Count == 1)
            {
                productListBox.Enabled = false;
                priceListBox.Enabled = false;

                productListBox.Items.Clear();
                priceListBox.Items.Clear();

                productListBox.Items.Add("-");
                priceListBox.Items.Add("-");
            }
            else
            {
                int selected1 = productListBox.SelectedIndex, selected2 = priceListBox.SelectedIndex;
                productListBox.Items.RemoveAt(selected1);
                priceListBox.Items.RemoveAt(selected2);

                productListBox.Enabled = true;
                priceListBox.Enabled = true;
            }

            removeprdButton.Enabled = false;
            removeprdButton.BackColor = Color.FromArgb(200, 200, 200);

            addprdButton.Enabled = false;
            addprdButton.BackColor = Color.FromArgb(200, 200, 200);
        }

        private void addprdButton_Click(object sender, EventArgs e)
        {
            if ((string)prdScontrinoListBox.Items[0] == "-" || (string)prcScontrinoListBox.Items[0] == "-")
            {
                prdScontrinoListBox.Items.Clear();
                prcScontrinoListBox.Items.Clear();

                prdScontrinoListBox.Items.Add(productListBox.SelectedItem);
                prcScontrinoListBox.Items.Add(priceListBox.SelectedItem);
                totale += Convert.ToDecimal(priceListBox.SelectedItem);
                totaleLabel.Text = "Totale: " + totale + "€";
            }
            else
            {
                prdScontrinoListBox.Items.Add(productListBox.SelectedItem);
                prcScontrinoListBox.Items.Add(priceListBox.SelectedItem);
                totale += Convert.ToDecimal(priceListBox.SelectedItem);
                totaleLabel.Text = "Totale: " + totale + "€";
            }
        }

        #endregion

        #region TextBox

        private void descTextBox_TextChanged(object sender, EventArgs e)
        {
            if (descTextBox.Texts.Length == 0 || priceTextBox.Texts.Length == 0)
            {
                addButton.Enabled = false;
                addButton.BackColor = Color.FromArgb(200, 200, 200);
            }
            else
            {
                addButton.Enabled = true;
                addButton.BackColor = Color.FromArgb(56, 199, 84);
            }
        }

        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {
            if (descTextBox.Texts.Length == 0 || priceTextBox.Texts.Length == 0)
            {
                addButton.Enabled = false;
                addButton.BackColor = Color.FromArgb(200, 200, 200);
            }
            else
            {
                if (decimal.TryParse(priceTextBox.Texts, out decimal test))
                {
                    addButton.Enabled = true;
                    addButton.BackColor = Color.FromArgb(56, 199, 84);
                }
                else
                {
                    addButton.Enabled = false;
                    addButton.BackColor = Color.FromArgb(200, 200, 200);
                }
            }
        }

        #endregion

        #region ListBox

        private void productListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            priceListBox.SelectedIndex = productListBox.SelectedIndex;

            if (productListBox.SelectedIndex == -1 || priceListBox.SelectedIndex == -1)
            {

            }
            else
            {
                removeprdButton.Enabled = true;
                removeprdButton.BackColor = Color.Tomato;

                addprdButton.Enabled = true;
                addprdButton.BackColor = Color.FromArgb(56, 199, 84);
            }
        }

        private void priceListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            productListBox.SelectedIndex = priceListBox.SelectedIndex;

            if (productListBox.SelectedIndex == -1 || priceListBox.SelectedIndex == -1)
            {

            }
            else
            {
                removeprdButton.Enabled = true;
                removeprdButton.BackColor = Color.Tomato;

                addprdButton.Enabled = true;
                addprdButton.BackColor = Color.FromArgb(56, 199, 84);
            }
        }

        #endregion
    }
}