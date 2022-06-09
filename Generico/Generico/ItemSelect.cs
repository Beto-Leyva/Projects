using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace Generico
{
    public partial class ItemSelect : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4RHBB5N\MSSQLSERVER01;Initial Catalog=quotedata;Integrated Security=True");
        SqlDataAdapter da;

        Double pricing,cost,qty,sum,grossmargin=0.20;
        string id;

        public ItemSelect()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void ItemSelect_Load(object sender, EventArgs e)
        {
            tBoxPrice.Enabled = false;
            // TODO: esta línea de código carga datos en la tabla 'quotedataDataSet.tBomItems' Puede moverla o quitarla según sea necesario.
            this.tBomItemsTableAdapter.Fill(this.quotedataDataSet.tBomItems);
            da = new SqlDataAdapter("select * from tBomItems",con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow Item in dt.Rows)
            {

                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[1].Value = Item["Partnumber"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = Item["ComponentType"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = Item["ComponentCost"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = Item["Descrip"].ToString();
                dataGridView1.Rows[n].Cells[5].Value = Item["UOM"].ToString();
            }

            long ticks = DateTime.Now.Ticks;
            byte[] bytes = BitConverter.GetBytes(ticks);
            id = Convert.ToBase64String(bytes)
                                    .Replace('+', '_')
                                    .Replace('/', '-')
                                    .TrimEnd('=');
            
        }



        

        private void bAdd_Click(object sender, EventArgs e)
        {
            copydgv();

        }

        public void copydgv()
        {
     
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value) == true)
                {
                    int n = dataGridView2.Rows.Add();
                    dataGridView2.Rows[n].Cells[0].Value = dataGridView1.Rows[n].Cells[1].Value.ToString();
                    dataGridView2.Rows[n].Cells[1].Value = dataGridView1.Rows[n].Cells[2].Value.ToString();
                    dataGridView2.Rows[n].Cells[2].Value = dataGridView1.Rows[n].Cells[3].Value.ToString();
                    dataGridView2.Rows[n].Cells[3].Value = dataGridView1.Rows[n].Cells[4].Value.ToString();
                    dataGridView2.Rows[n].Cells[4].Value = dataGridView1.Rows[n].Cells[5].Value.ToString();
                }

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i= 0; i< dataGridView1.Rows.Count;i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = false;
            }


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
        }

        private void tBoxPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exportToExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

            excel.Application.Workbooks.Add(true);

            int IndiceColumna = 0;

            foreach (DataGridViewColumn col in dataGridView2.Columns) // Columnas
            {

                IndiceColumna++;

                excel.Cells[1, IndiceColumna] = col.Name;

            }

            int IndeceFila = 0;

            foreach (DataGridViewRow row in dataGridView2.Rows) // Filas
            {

                IndeceFila++;
                IndiceColumna = 0;

                foreach (DataGridViewColumn col in dataGridView2.Columns)
                {

                    IndiceColumna++;

                    excel.Cells[IndeceFila + 1, IndiceColumna] = row.Cells[col.Name].Value;

                }

            }

            excel.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("quote_entry", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@tprice", SqlDbType.Float).Value = tBoxPrice.Text.Trim();
            cmd.Parameters.AddWithValue("@fecha", SqlDbType.SmallDateTime).Value = label1.Text.Trim();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Saved, Quote ID:" + id);
            con.Close();
   

        }

        private void button8_Click(object sender, EventArgs e)
        {
            new Consultas().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView2.SelectedRows)
            {
                dataGridView2.Rows.RemoveAt(row.Index);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            quote();
            sum = 0;
        }

        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
         
            if(dataGridView2.Columns[e.ColumnIndex].Name == "compqty")
            {

                try
                {
                    qty = double.Parse(dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString());
                }

                catch (Exception)

                {
                    MessageBox.Show("Component Quantity must be entered to Continue !","Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

                }

                cost = double.Parse(dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString());       
                
                if (!(qty==0) && !(cost == 0))
                {
                    pricing = qty * cost;
                    dataGridView2.Rows[e.RowIndex].Cells[6].Value = pricing;
                    tBoxPrice.Enabled = true;
                }
                
               
            }
        }

        public void quote ()
        {
        
            for (int i=0; i < dataGridView2.Rows.Count; ++ i)
            {
                sum += Convert.ToDouble(dataGridView2.Rows[i].Cells[6].Value);
            }

            grossmargin = grossmargin * sum;
            sum = sum + grossmargin;
            tBoxPrice.Text = Convert.ToString(sum);
        }
    }
}
