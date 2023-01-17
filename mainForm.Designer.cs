namespace Supermercato
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.roundedPanel1 = new Supermercato.RoundedPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.cleanButton = new CustomControls.RJControls.RJButton();
            this.label1 = new System.Windows.Forms.Label();
            this.roundedPanel2 = new Supermercato.RoundedPanel();
            this.addButton = new CustomControls.RJControls.RJButton();
            this.priceTextBox = new CustomControls.RJControls.RJTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.descTextBox = new CustomControls.RJControls.RJTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.roundedPanel3 = new Supermercato.RoundedPanel();
            this.priceListBox = new System.Windows.Forms.ListBox();
            this.productListBox = new System.Windows.Forms.ListBox();
            this.removeprdButton = new CustomControls.RJControls.RJButton();
            this.addprdButton = new CustomControls.RJControls.RJButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.roundedPanel4 = new Supermercato.RoundedPanel();
            this.totaleLabel = new System.Windows.Forms.Label();
            this.prcScontrinoListBox = new System.Windows.Forms.ListBox();
            this.prdScontrinoListBox = new System.Windows.Forms.ListBox();
            this.rjButton3 = new CustomControls.RJControls.RJButton();
            this.rjButton4 = new CustomControls.RJControls.RJButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.roundedPanel1.SuspendLayout();
            this.roundedPanel2.SuspendLayout();
            this.roundedPanel3.SuspendLayout();
            this.roundedPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.White;
            this.roundedPanel1.BorderColor = System.Drawing.Color.White;
            this.roundedPanel1.Controls.Add(this.label3);
            this.roundedPanel1.Controls.Add(this.cleanButton);
            this.roundedPanel1.Controls.Add(this.label1);
            this.roundedPanel1.Edge = 20;
            this.roundedPanel1.Location = new System.Drawing.Point(12, 2);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(696, 48);
            this.roundedPanel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.label3.Location = new System.Drawing.Point(218, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gestione dei prodotti";
            // 
            // cleanButton
            // 
            this.cleanButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cleanButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.cleanButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.cleanButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cleanButton.BorderRadius = 17;
            this.cleanButton.BorderSize = 0;
            this.cleanButton.FlatAppearance.BorderSize = 0;
            this.cleanButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cleanButton.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cleanButton.ForeColor = System.Drawing.Color.White;
            this.cleanButton.Location = new System.Drawing.Point(576, 6);
            this.cleanButton.Name = "cleanButton";
            this.cleanButton.Padding = new System.Windows.Forms.Padding(1, 0, 0, 1);
            this.cleanButton.Size = new System.Drawing.Size(110, 35);
            this.cleanButton.TabIndex = 1;
            this.cleanButton.Text = "Pulisci";
            this.cleanButton.TextColor = System.Drawing.Color.White;
            this.cleanButton.UseVisualStyleBackColor = false;
            this.cleanButton.Click += new System.EventHandler(this.cleanButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label1.Location = new System.Drawing.Point(4, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Supermercato";
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BackColor = System.Drawing.Color.White;
            this.roundedPanel2.BorderColor = System.Drawing.Color.White;
            this.roundedPanel2.Controls.Add(this.addButton);
            this.roundedPanel2.Controls.Add(this.priceTextBox);
            this.roundedPanel2.Controls.Add(this.label5);
            this.roundedPanel2.Controls.Add(this.descTextBox);
            this.roundedPanel2.Controls.Add(this.label4);
            this.roundedPanel2.Controls.Add(this.label2);
            this.roundedPanel2.Edge = 20;
            this.roundedPanel2.Location = new System.Drawing.Point(12, 61);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Size = new System.Drawing.Size(342, 133);
            this.roundedPanel2.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(199)))), ((int)(((byte)(84)))));
            this.addButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(199)))), ((int)(((byte)(84)))));
            this.addButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.addButton.BorderRadius = 17;
            this.addButton.BorderSize = 0;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(222, 81);
            this.addButton.Name = "addButton";
            this.addButton.Padding = new System.Windows.Forms.Padding(1, 0, 0, 1);
            this.addButton.Size = new System.Drawing.Size(100, 35);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Inserisci";
            this.addButton.TextColor = System.Drawing.Color.White;
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // priceTextBox
            // 
            this.priceTextBox.BackColor = System.Drawing.Color.White;
            this.priceTextBox.BorderColor = System.Drawing.SystemColors.ScrollBar;
            this.priceTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.priceTextBox.BorderRadius = 17;
            this.priceTextBox.BorderSize = 1;
            this.priceTextBox.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.priceTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.priceTextBox.Location = new System.Drawing.Point(115, 82);
            this.priceTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.priceTextBox.Multiline = false;
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Padding = new System.Windows.Forms.Padding(20, 7, 20, 7);
            this.priceTextBox.PasswordChar = false;
            this.priceTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.priceTextBox.PlaceholderText = "-";
            this.priceTextBox.Size = new System.Drawing.Size(100, 33);
            this.priceTextBox.TabIndex = 6;
            this.priceTextBox.Texts = "";
            this.priceTextBox.UnderlinedStyle = false;
            this.priceTextBox._TextChanged += new System.EventHandler(this.priceTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label5.Location = new System.Drawing.Point(24, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Prezzo (€)";
            // 
            // descTextBox
            // 
            this.descTextBox.BackColor = System.Drawing.Color.White;
            this.descTextBox.BorderColor = System.Drawing.SystemColors.ScrollBar;
            this.descTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.descTextBox.BorderRadius = 17;
            this.descTextBox.BorderSize = 1;
            this.descTextBox.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.descTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.descTextBox.Location = new System.Drawing.Point(115, 41);
            this.descTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.descTextBox.Multiline = false;
            this.descTextBox.Name = "descTextBox";
            this.descTextBox.Padding = new System.Windows.Forms.Padding(20, 7, 20, 7);
            this.descTextBox.PasswordChar = false;
            this.descTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.descTextBox.PlaceholderText = "-";
            this.descTextBox.Size = new System.Drawing.Size(207, 33);
            this.descTextBox.TabIndex = 4;
            this.descTextBox.Texts = "";
            this.descTextBox.UnderlinedStyle = false;
            this.descTextBox._TextChanged += new System.EventHandler(this.descTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label4.Location = new System.Drawing.Point(19, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descrizione";
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(342, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Inserisci prodotto";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // roundedPanel3
            // 
            this.roundedPanel3.BackColor = System.Drawing.Color.White;
            this.roundedPanel3.BorderColor = System.Drawing.Color.White;
            this.roundedPanel3.Controls.Add(this.priceListBox);
            this.roundedPanel3.Controls.Add(this.productListBox);
            this.roundedPanel3.Controls.Add(this.removeprdButton);
            this.roundedPanel3.Controls.Add(this.addprdButton);
            this.roundedPanel3.Controls.Add(this.label6);
            this.roundedPanel3.Controls.Add(this.label7);
            this.roundedPanel3.Controls.Add(this.label8);
            this.roundedPanel3.Edge = 20;
            this.roundedPanel3.Location = new System.Drawing.Point(12, 207);
            this.roundedPanel3.Name = "roundedPanel3";
            this.roundedPanel3.Size = new System.Drawing.Size(342, 282);
            this.roundedPanel3.TabIndex = 7;
            // 
            // priceListBox
            // 
            this.priceListBox.BackColor = System.Drawing.Color.White;
            this.priceListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.priceListBox.Enabled = false;
            this.priceListBox.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.priceListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.priceListBox.FormattingEnabled = true;
            this.priceListBox.ItemHeight = 18;
            this.priceListBox.Items.AddRange(new object[] {
            "-"});
            this.priceListBox.Location = new System.Drawing.Point(170, 65);
            this.priceListBox.Margin = new System.Windows.Forms.Padding(0);
            this.priceListBox.Name = "priceListBox";
            this.priceListBox.Size = new System.Drawing.Size(152, 144);
            this.priceListBox.TabIndex = 10;
            this.priceListBox.SelectedIndexChanged += new System.EventHandler(this.priceListBox_SelectedIndexChanged);
            // 
            // productListBox
            // 
            this.productListBox.BackColor = System.Drawing.Color.White;
            this.productListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productListBox.Enabled = false;
            this.productListBox.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.productListBox.FormattingEnabled = true;
            this.productListBox.ItemHeight = 18;
            this.productListBox.Items.AddRange(new object[] {
            "-"});
            this.productListBox.Location = new System.Drawing.Point(20, 65);
            this.productListBox.Margin = new System.Windows.Forms.Padding(0);
            this.productListBox.Name = "productListBox";
            this.productListBox.Size = new System.Drawing.Size(150, 144);
            this.productListBox.TabIndex = 9;
            this.productListBox.SelectedIndexChanged += new System.EventHandler(this.productListBox_SelectedIndexChanged);
            // 
            // removeprdButton
            // 
            this.removeprdButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.removeprdButton.BackColor = System.Drawing.Color.Tomato;
            this.removeprdButton.BackgroundColor = System.Drawing.Color.Tomato;
            this.removeprdButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.removeprdButton.BorderRadius = 17;
            this.removeprdButton.BorderSize = 0;
            this.removeprdButton.FlatAppearance.BorderSize = 0;
            this.removeprdButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeprdButton.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.removeprdButton.ForeColor = System.Drawing.Color.White;
            this.removeprdButton.Location = new System.Drawing.Point(19, 233);
            this.removeprdButton.Name = "removeprdButton";
            this.removeprdButton.Padding = new System.Windows.Forms.Padding(1, 0, 0, 1);
            this.removeprdButton.Size = new System.Drawing.Size(110, 35);
            this.removeprdButton.TabIndex = 8;
            this.removeprdButton.Text = "Rimuovi";
            this.removeprdButton.TextColor = System.Drawing.Color.White;
            this.removeprdButton.UseVisualStyleBackColor = false;
            this.removeprdButton.Click += new System.EventHandler(this.removeprdButton_Click);
            // 
            // addprdButton
            // 
            this.addprdButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addprdButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(199)))), ((int)(((byte)(84)))));
            this.addprdButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(199)))), ((int)(((byte)(84)))));
            this.addprdButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.addprdButton.BorderRadius = 17;
            this.addprdButton.BorderSize = 0;
            this.addprdButton.FlatAppearance.BorderSize = 0;
            this.addprdButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addprdButton.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addprdButton.ForeColor = System.Drawing.Color.White;
            this.addprdButton.Location = new System.Drawing.Point(135, 233);
            this.addprdButton.Name = "addprdButton";
            this.addprdButton.Padding = new System.Windows.Forms.Padding(1, 0, 0, 1);
            this.addprdButton.Size = new System.Drawing.Size(187, 35);
            this.addprdButton.TabIndex = 3;
            this.addprdButton.Text = "Agg. allo scontrino";
            this.addprdButton.TextColor = System.Drawing.Color.White;
            this.addprdButton.UseVisualStyleBackColor = false;
            this.addprdButton.Click += new System.EventHandler(this.addprdButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label6.Location = new System.Drawing.Point(198, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Prezzo (€)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label7.Location = new System.Drawing.Point(45, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 18);
            this.label7.TabIndex = 3;
            this.label7.Text = "Descrizione";
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label8.Size = new System.Drawing.Size(342, 32);
            this.label8.TabIndex = 1;
            this.label8.Text = "Elenco prodotti";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // roundedPanel4
            // 
            this.roundedPanel4.BackColor = System.Drawing.Color.White;
            this.roundedPanel4.BorderColor = System.Drawing.Color.White;
            this.roundedPanel4.Controls.Add(this.totaleLabel);
            this.roundedPanel4.Controls.Add(this.prcScontrinoListBox);
            this.roundedPanel4.Controls.Add(this.prdScontrinoListBox);
            this.roundedPanel4.Controls.Add(this.rjButton3);
            this.roundedPanel4.Controls.Add(this.rjButton4);
            this.roundedPanel4.Controls.Add(this.label9);
            this.roundedPanel4.Controls.Add(this.label10);
            this.roundedPanel4.Controls.Add(this.label11);
            this.roundedPanel4.Edge = 20;
            this.roundedPanel4.Location = new System.Drawing.Point(366, 61);
            this.roundedPanel4.Name = "roundedPanel4";
            this.roundedPanel4.Size = new System.Drawing.Size(342, 428);
            this.roundedPanel4.TabIndex = 8;
            // 
            // totaleLabel
            // 
            this.totaleLabel.AutoSize = true;
            this.totaleLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totaleLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.totaleLabel.Location = new System.Drawing.Point(17, 385);
            this.totaleLabel.Name = "totaleLabel";
            this.totaleLabel.Size = new System.Drawing.Size(119, 22);
            this.totaleLabel.TabIndex = 13;
            this.totaleLabel.Text = "Totale: 0,00€";
            // 
            // prcScontrinoListBox
            // 
            this.prcScontrinoListBox.BackColor = System.Drawing.Color.White;
            this.prcScontrinoListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.prcScontrinoListBox.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prcScontrinoListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.prcScontrinoListBox.FormattingEnabled = true;
            this.prcScontrinoListBox.ItemHeight = 18;
            this.prcScontrinoListBox.Items.AddRange(new object[] {
            "-"});
            this.prcScontrinoListBox.Location = new System.Drawing.Point(170, 67);
            this.prcScontrinoListBox.Margin = new System.Windows.Forms.Padding(0);
            this.prcScontrinoListBox.Name = "prcScontrinoListBox";
            this.prcScontrinoListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.prcScontrinoListBox.Size = new System.Drawing.Size(152, 306);
            this.prcScontrinoListBox.TabIndex = 12;
            // 
            // prdScontrinoListBox
            // 
            this.prdScontrinoListBox.BackColor = System.Drawing.Color.White;
            this.prdScontrinoListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.prdScontrinoListBox.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prdScontrinoListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.prdScontrinoListBox.FormattingEnabled = true;
            this.prdScontrinoListBox.ItemHeight = 18;
            this.prdScontrinoListBox.Items.AddRange(new object[] {
            "-"});
            this.prdScontrinoListBox.Location = new System.Drawing.Point(20, 67);
            this.prdScontrinoListBox.Margin = new System.Windows.Forms.Padding(0);
            this.prdScontrinoListBox.Name = "prdScontrinoListBox";
            this.prdScontrinoListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.prdScontrinoListBox.Size = new System.Drawing.Size(150, 306);
            this.prdScontrinoListBox.TabIndex = 11;
            // 
            // rjButton3
            // 
            this.rjButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rjButton3.BackColor = System.Drawing.Color.Tomato;
            this.rjButton3.BackgroundColor = System.Drawing.Color.Tomato;
            this.rjButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton3.BorderRadius = 17;
            this.rjButton3.BorderSize = 0;
            this.rjButton3.FlatAppearance.BorderSize = 0;
            this.rjButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton3.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rjButton3.ForeColor = System.Drawing.Color.White;
            this.rjButton3.Location = new System.Drawing.Point(116, 531);
            this.rjButton3.Name = "rjButton3";
            this.rjButton3.Padding = new System.Windows.Forms.Padding(1, 0, 0, 1);
            this.rjButton3.Size = new System.Drawing.Size(100, 35);
            this.rjButton3.TabIndex = 8;
            this.rjButton3.Text = "Rimuovi";
            this.rjButton3.TextColor = System.Drawing.Color.White;
            this.rjButton3.UseVisualStyleBackColor = false;
            // 
            // rjButton4
            // 
            this.rjButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rjButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(199)))), ((int)(((byte)(84)))));
            this.rjButton4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(199)))), ((int)(((byte)(84)))));
            this.rjButton4.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton4.BorderRadius = 17;
            this.rjButton4.BorderSize = 0;
            this.rjButton4.FlatAppearance.BorderSize = 0;
            this.rjButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton4.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rjButton4.ForeColor = System.Drawing.Color.White;
            this.rjButton4.Location = new System.Drawing.Point(222, 531);
            this.rjButton4.Name = "rjButton4";
            this.rjButton4.Padding = new System.Windows.Forms.Padding(1, 0, 0, 1);
            this.rjButton4.Size = new System.Drawing.Size(100, 35);
            this.rjButton4.TabIndex = 3;
            this.rjButton4.Text = "Inserisci";
            this.rjButton4.TextColor = System.Drawing.Color.White;
            this.rjButton4.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label9.Location = new System.Drawing.Point(208, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 18);
            this.label9.TabIndex = 5;
            this.label9.Text = "Prezzo (€)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label10.Location = new System.Drawing.Point(27, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 18);
            this.label10.TabIndex = 3;
            this.label10.Text = "Prodotti acquistati";
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Top;
            this.label11.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label11.Size = new System.Drawing.Size(342, 32);
            this.label11.TabIndex = 1;
            this.label11.Text = "Scontrino";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(721, 501);
            this.Controls.Add(this.roundedPanel4);
            this.Controls.Add(this.roundedPanel3);
            this.Controls.Add(this.roundedPanel2);
            this.Controls.Add(this.roundedPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.roundedPanel2.ResumeLayout(false);
            this.roundedPanel2.PerformLayout();
            this.roundedPanel3.ResumeLayout(false);
            this.roundedPanel3.PerformLayout();
            this.roundedPanel4.ResumeLayout(false);
            this.roundedPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Supermercato.RoundedPanel roundedPanel1;
        private Label label1;
        private CustomControls.RJControls.RJButton cleanButton;
        private RoundedPanel roundedPanel2;
        private Label label2;
        private Label label3;
        private CustomControls.RJControls.RJTextBox descTextBox;
        private Label label4;
        private CustomControls.RJControls.RJButton addButton;
        private CustomControls.RJControls.RJTextBox priceTextBox;
        private Label label5;
        private RoundedPanel roundedPanel3;
        private CustomControls.RJControls.RJButton addprdButton;
        private Label label6;
        private Label label7;
        private Label label8;
        private CustomControls.RJControls.RJButton removeprdButton;
        private RoundedPanel roundedPanel4;
        private CustomControls.RJControls.RJButton rjButton3;
        private CustomControls.RJControls.RJButton rjButton4;
        private Label label9;
        private Label label10;
        private Label label11;
        private ListBox priceListBox;
        private ListBox productListBox;
        private Label totaleLabel;
        private ListBox prcScontrinoListBox;
        private ListBox prdScontrinoListBox;
    }
}