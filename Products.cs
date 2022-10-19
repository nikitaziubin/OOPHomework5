using System.Windows.Forms;

namespace Task5
{
    internal class Product : Item
    {
        private string term;
        private int quantity;
        private string unitOfMeasure;
        
        public Product(DataGridView dataGridView1, int price, string countryOfOrigin, 
            string productName, string productDescription,
            string description, string term, int quantity, string unitOfMeasure) : base(dataGridView1, price, countryOfOrigin, 
            productName, productDescription, description)
        {
            
            this.term = term;
            this.quantity = quantity;
            this.unitOfMeasure = unitOfMeasure;
        }
        
    public override List<Object> getList()
            {
            List<Object> listProduct = new List<Object>();
            listProduct.Add(" ");
            listProduct.Add(" ");
            listProduct.Add(" ");
            listProduct.Add(term);
            listProduct.Add(quantity);
            listProduct.Add(unitOfMeasure);
            return listProduct;
       }
        }
}
