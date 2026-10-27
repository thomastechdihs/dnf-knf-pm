namespace pmprojekt
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox comboBoxVariables;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label labelVariables;
        private System.Windows.Forms.Label labelDnf;
        private System.Windows.Forms.Label labelCnf;
        private System.Windows.Forms.TextBox textBoxDnf;
        private System.Windows.Forms.TextBox textBoxCnf;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBoxVariables = new System.Windows.Forms.ComboBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.labelVariables = new System.Windows.Forms.Label();
            this.labelDnf = new System.Windows.Forms.Label();
            this.labelCnf = new System.Windows.Forms.Label();
            this.textBoxDnf = new System.Windows.Forms.TextBox();
            this.textBoxCnf = new System.Windows.Forms.TextBox();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();

            this.comboBoxVariables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVariables.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxVariables.Items.AddRange(new object[] { "2", "3", "4" });
            this.comboBoxVariables.Location = new System.Drawing.Point(120, 20);
            this.comboBoxVariables.Name = "comboBoxVariables";
            this.comboBoxVariables.Size = new System.Drawing.Size(120, 25);
            this.comboBoxVariables.SelectedIndexChanged += new System.EventHandler(this.comboBoxVariables_SelectedIndexChanged);

            this.labelVariables.AutoSize = true;
            this.labelVariables.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelVariables.Location = new System.Drawing.Point(20, 23);
            this.labelVariables.Name = "labelVariables";
            this.labelVariables.Size = new System.Drawing.Size(100, 17);
            this.labelVariables.Text = "Broj varijabli:";

            this.buttonGenerate.Location = new System.Drawing.Point(260, 18);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(130, 30);
            this.buttonGenerate.Text = "Izbrisi sve iz tablice";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);

            this.buttonCalculate.Location = new System.Drawing.Point(410, 18);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(130, 30);
            this.buttonCalculate.Text = "Izračunaj";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);

            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(20, 70);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.Size = new System.Drawing.Size(520, 220);
            this.dataGridView.TabIndex = 0;

            this.labelDnf.AutoSize = true;
            this.labelDnf.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelDnf.Location = new System.Drawing.Point(20, 310);
            this.labelDnf.Name = "labelDnf";
            this.labelDnf.Size = new System.Drawing.Size(140, 17);
            this.labelDnf.Text = "Disjunktivna forma:";

            this.textBoxDnf.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxDnf.Location = new System.Drawing.Point(180, 307);
            this.textBoxDnf.Name = "textBoxDnf";
            this.textBoxDnf.ReadOnly = true;
            this.textBoxDnf.Size = new System.Drawing.Size(360, 25);

            this.labelCnf.AutoSize = true;
            this.labelCnf.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelCnf.Location = new System.Drawing.Point(20, 350);
            this.labelCnf.Name = "labelCnf";
            this.labelCnf.Size = new System.Drawing.Size(140, 17);
            this.labelCnf.Text = "Konjunktivna forma:";

            this.textBoxCnf.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxCnf.Location = new System.Drawing.Point(180, 347);
            this.textBoxCnf.Name = "textBoxCnf";
            this.textBoxCnf.ReadOnly = true;
            this.textBoxCnf.Size = new System.Drawing.Size(360, 25);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(580, 420);
            this.Controls.Add(this.labelVariables);
            this.Controls.Add(this.comboBoxVariables);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.labelDnf);
            this.Controls.Add(this.textBoxDnf);
            this.Controls.Add(this.labelCnf);
            this.Controls.Add(this.textBoxCnf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Konjunktivna i disjunktivna normalna forma";

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}







































































































































































































































































































































































































































































































































































































































