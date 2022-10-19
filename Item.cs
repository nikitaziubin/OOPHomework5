
using System.Windows.Forms;

namespace Task5
{
    internal abstract class Item
    {
        private int price;
        private string countryOfOrigin;
        private string productName; // todo
        private string productDescription;
        private string description;
        protected DataGridView dataGridView1;
        
        public Item(DataGridView dataGridView1, int price, string countryOfOrigin,
            string productName, string productDescription, string description)
        {
            this.dataGridView1 = dataGridView1;
            this.price = price;
            this.countryOfOrigin = countryOfOrigin;
            this.productName = productDescription;
            this.productDescription = description;
        }
        public abstract List<Object> getList();
        
        public void getInformation()
        {
            List<Object> list = new List<Object>();
            
            list.Add(productName);
            list.Add(price);
            list.Add(countryOfOrigin);
            list.Add(productDescription);
            list.Add(description);
            list.AddRange(getList());
            dataGridView1.Rows.Add(list.ToArray());
        }

    }
}
