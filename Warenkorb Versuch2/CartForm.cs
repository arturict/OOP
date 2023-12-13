public partial class CartForm : Form
{
    private double gesamtsumme = 0;
    private List<OrderItem> orderedItems = new List<OrderItem>();

    public CartForm(List<OrderItem> orderedItems)
    {
        InitializeComponent();
        this.orderedItems = orderedItems;
        LoadOrderedItems();
    }

    private void LoadOrderedItems()
    {
        foreach (OrderItem item in orderedItems)
        {
            ListViewItem listViewItem = new ListViewItem(item.Product.Name);
            listViewItem.SubItems.Add(item.Quantity.ToString());
            listViewItem.SubItems.Add(item.Product.Price.ToString("C2"));
            listViewWarenkorb.Items.Add(listViewItem);
        }
    }

    public List<OrderItem> GetOrderedItems()
    {
        return orderedItems;
    }

    public void AddItemToListView(Product product, int menge)
    {
        ListViewItem listViewItem = new ListViewItem(menge.ToString());
        listViewItem.SubItems.Add(product.Name);
        listViewItem.SubItems.Add(product.Price.ToString("C2"));
        listViewWarenkorb.Items.Add(listViewItem);

        UpdateGesamtsumme(menge * product.Price);
    }

    private void buttonAbbrechen_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void UpdateGesamtsumme(double produktSumme)
    {
        gesamtsumme += produktSumme;
        // Update your total sum display here
    }
}
