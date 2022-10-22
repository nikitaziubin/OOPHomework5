using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace Task5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            List<Item> itemList = new List<Item>();
            //itemList.Add(new Book(dataGridView1, new Random().Next(1, 10), "Ukraine", "Book", "20.05.2022", "This is Book", new Random().Next(1, 10), "UkrKniga", "Franko"));
            //itemList.Add(new Book(dataGridView1, new Random().Next(1, 10), "Ukraine", "Book", "20.05.2022", "This is Book", new Random().Next(1, 10), "UkrKniga", "Franko"));
            //itemList.Add(new Product(dataGridView1, new Random().Next(1, 10), "Ukraine", "Milk", "19.07.2022", "This is Product", "30.07.2022", new Random().Next(1, 10), "L"));
            //itemList.Add(new Product(dataGridView1, new Random().Next(1, 10), "Ukraine", "Milk", "19.07.2022", "This is Product", "30.07.2022", new Random().Next(1, 10), "L"));
            itemList.Add(new Book(dataGridView1, new Random().Next(1, 10), "Ukraine", "Book", "20.05.2022", "This is Book", new Random().Next(1, 10), "UkrKniga", "Franko"));
            itemList.Add(new Product(dataGridView1, new Random().Next(1, 10), "Ukraine", "Milk", "19.07.2022", "This is Product", "30.07.2022", new Random().Next(1, 10), "L"));
            foreach (var item in itemList)
            {
                item.getInformation();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            new Book(dataGridView1, new Random().Next(50, 120), "Ukraine", "Book", "20.05.2022", "This is Book", new Random().Next(100, 300), "UkrKniga", "Franko").getInformation();
            
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 1)
            {
                dataGridView1.Rows.RemoveAt(0);
            }
            
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            new Product(dataGridView1, new Random().Next(20, 50), "Ukraine", "Milk", "19.07.2022", "This is Product", "30.07.2022", new Random().Next(1, 10), "L").getInformation();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }
    }
}