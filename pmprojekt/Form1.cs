using System;
using System.Collections.Generic;

using System.Windows.Forms;

namespace pmprojekt
{
    public partial class Form1 : Form
    {
        private readonly string[] imenaVarijabli = { "A", "B", "C", "D" };

        public Form1()
        {
            InitializeComponent();
            comboBoxVariables.SelectedIndex = 0;
            UcitajTablicuIstine();

        }

        private void comboBoxVariables_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajTablicuIstine();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            UcitajTablicuIstine();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            int brojVarijabli = int.Parse(comboBoxVariables.SelectedItem.ToString());
            bool[] rezultat = new bool[1 << brojVarijabli];

            for (int red = 0; red < dataGridView.Rows.Count; red++)
            {
                if (dataGridView.Rows[red].IsNewRow)
                {
                    continue;
                }

                object vrijednost = dataGridView.Rows[red].Cells[brojVarijabli].Value;
                rezultat[red] = vrijednost != null && Convert.ToBoolean(vrijednost);
            }

            string dnf = IzracunajDnf(brojVarijabli, rezultat);
            string cnf = IzracunajCnf(brojVarijabli, rezultat);

            textBoxDnf.Text = dnf;
            textBoxCnf.Text = cnf;
        }

        private void UcitajTablicuIstine()
        {
            int brojVarijabli = int.Parse(comboBoxVariables.SelectedItem.ToString());
            dataGridView.Columns.Clear();

            for (int i = 0; i < brojVarijabli; i++)
            {
                dataGridView.Columns.Add("Var" + i, imenaVarijabli[i]);
                dataGridView.Columns[i].ReadOnly = true;
                dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            DataGridViewCheckBoxColumn kolonaZaRezultat = new DataGridViewCheckBoxColumn();
            kolonaZaRezultat.Name = "Rezultat";
            kolonaZaRezultat.HeaderText = "F";
            kolonaZaRezultat.Width = 50;
            kolonaZaRezultat.TrueValue = true;
            kolonaZaRezultat.FalseValue = false;
            dataGridView.Columns.Add(kolonaZaRezultat);

            dataGridView.Rows.Clear();
            int ukupnoRedova = 1 << brojVarijabli;
            dataGridView.RowCount = ukupnoRedova;

            if (brojVarijabli == 2){
                dataGridView.Rows[0].SetValues("0", "0");
                dataGridView.Rows[1].SetValues("0", "1");
                dataGridView.Rows[2].SetValues("1", "0");
                dataGridView.Rows[3].SetValues("1", "1");
            } else if (brojVarijabli == 3)
            {
                dataGridView.Rows[0].SetValues("0", "0", "0");
                dataGridView.Rows[1].SetValues("0", "0", "1");
                dataGridView.Rows[2].SetValues("0", "1", "0");
                dataGridView.Rows[3].SetValues("0", "1", "1");
                dataGridView.Rows[4].SetValues("1", "0", "0");
                dataGridView.Rows[5].SetValues("1", "0", "1");
                dataGridView.Rows[6].SetValues("1", "1", "0");
                dataGridView.Rows[7].SetValues("1", "1", "1");

            }
            else if (brojVarijabli == 4)
            {
                dataGridView.Rows[0].SetValues("0", "0", "0", "0");
                dataGridView.Rows[1].SetValues("0", "0", "0", "1");
                dataGridView.Rows[2].SetValues("0", "0", "1", "0");
                dataGridView.Rows[3].SetValues("0", "0", "1", "1");
                dataGridView.Rows[4].SetValues("0", "1", "0", "0");
                dataGridView.Rows[5].SetValues("0", "1", "0", "1");
                dataGridView.Rows[6].SetValues("0", "1", "1", "0");
                dataGridView.Rows[7].SetValues("0", "1", "1", "1");
                dataGridView.Rows[8].SetValues("1", "0", "0", "0");
                dataGridView.Rows[9].SetValues("1", "0", "0", "1");
                dataGridView.Rows[10].SetValues("1", "0", "1", "0");
                dataGridView.Rows[11].SetValues("1", "0", "1", "1");
                dataGridView.Rows[12].SetValues("1", "1", "0", "0");
                dataGridView.Rows[13].SetValues("1", "1", "0", "1");
                dataGridView.Rows[14].SetValues("1", "1", "1", "0");
                dataGridView.Rows[15].SetValues("1", "1", "1", "1");
                
            }

            dataGridView.AutoResizeColumns();
        }

        private string IzracunajDnf(int brojVarijabli, bool[] rezultat)
        {
            List<string> mintermi = new List<string>();

            for (int red = 0; red < rezultat.Length; red++)
            {
                if (rezultat[red] == true)
                {
                    string jedanUslov = NapraviMinterm(red, brojVarijabli);
                    mintermi.Add(jedanUslov);
                }
            }

            if (mintermi.Count == 0)
            {
                return "0";
            }

            string gotov = "";
            for (int i = 0; i < mintermi.Count; i++)
            {
                if (i > 0)
                {
                    gotov += " + ";
                }

                gotov += mintermi[i];
            }

            return gotov;
        }

        private string IzracunajCnf(int brojVarijabli, bool[] rezultat)
        {
            List<string> maxtermi = new List<string>();

            for (int red = 0; red < rezultat.Length; red++)
            {
                if (rezultat[red] == false)
                {
                    string jedanUslov = NapraviMaxterm(red, brojVarijabli);
                    maxtermi.Add(jedanUslov);
                }
            }

            if (maxtermi.Count == 0)
            {
                return "1";
            }

            string gotov = "";
            for (int i = 0; i < maxtermi.Count; i++)
            {
                if (i > 0)
                {
                    gotov += " * ";
                }

                gotov += maxtermi[i];
            }

            return gotov;
        }

        private string NapraviMinterm(int red, int brojVarijabli)
        {
            List<string> dio = new List<string>();
            int bit;
            for (int i = 0; i < brojVarijabli; i++)
            {
                bit = (red >> (brojVarijabli - i - 1)) & 1;

                if (bit == 1)
                {
                    dio.Add(imenaVarijabli[i]);
                }
                else
                {
                    dio.Add("~" + imenaVarijabli[i]);
                }
            }

            return "(" + string.Join(" * ", dio) + ")";
        }

        private string NapraviMaxterm(int red, int brojVarijabli)
        {
            List<string> dio = new List<string>();

            for (int i = 0; i < brojVarijabli; i++)
            {
                int bit = (red >> (brojVarijabli - i - 1)) & 1;

                if (bit == 1)
                {
                    dio.Add("~" + imenaVarijabli[i]);
                }
                else
                {
                    dio.Add(imenaVarijabli[i]);
                }
            }

            return "(" + string.Join(" + ", dio) + ")";
        }
    }
}
