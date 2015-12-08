namespace TradeCompany
{
    public class Article
    {
        public Article(long barcode, string vendor, string title, decimal price)
        {
            this.Barcode = barcode;

            this.Vendor = vendor;

            this.Title = title;

            this.Price = price;
        }

        long Barcode { get; set; }

        string Vendor { get; set; }

        string Title { get; set; }

        decimal Price { get; set; }
    }
}
