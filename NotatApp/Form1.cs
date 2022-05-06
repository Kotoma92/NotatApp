namespace NotatApp
{
    public partial class Form1 : Form
    {
        System.Data.DataTable table;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table = new System.Data.DataTable();
            table.Columns.Add("Tittel", typeof(String));
            table.Columns.Add("Meldinger", typeof (String));

            dataGridView1.DataSource = table;

            dataGridView1.Columns["Meldinger"].Visible = false;
            dataGridView1.Columns["Tittel"].Width = 237;
        }

        private void Ny_Click(object sender, EventArgs e)
        {
            tittelTekst.Clear();
            meldingTekst.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            table.Rows.Add(tittelTekst.Text, meldingTekst.Text);

            tittelTekst.Clear();
            meldingTekst.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            if (index > -1)
            {
                tittelTekst.Text = table.Rows[index].ItemArray[0].ToString();
                meldingTekst.Text = table.Rows[index].ItemArray[1].ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            table.Rows[index].Delete();
        }
    }
}