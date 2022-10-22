using System.Diagnostics;
using System.Windows.Forms;

namespace Task5
{
    internal class Book : Item
    {
        private int amountOfPages;
        private string publisher;
        private string authors;
        
        public Book(DataGridView dataGridView1,
            int price, string countryOfOrigin, string productName, string productDescription,
            string description, int amountOfPage, string publisher,
            string authors) : base(dataGridView1, price, countryOfOrigin, productName,
            productDescription, description)
        {  
            
            this.publisher = publisher;
            this.amountOfPages = amountOfPage;
            this.authors = authors;

        }
        public override List<Object> getList()
        {
            List<Object> listBook = new List<Object>();
            listBook.AddRange(base.getList());
            listBook.Add(amountOfPages);
            listBook.Add(publisher);
            listBook.Add(authors);
            return listBook;
        }
    }
}
