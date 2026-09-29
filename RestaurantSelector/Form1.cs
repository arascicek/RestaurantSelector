namespace RestaurantSelector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            lstRestaurants.Items.Clear();

            // Joe's: no options, so only show it if nothing is checked
            if (!chkVegetarian.Checked && !chkVegan.Checked && !chkGluten.Checked)
                lstRestaurants.Items.Add("Joe's Gourmet Burgers");

            // Main Street: vegetarian + gluten-free, but NOT vegan
            if (!chkVegan.Checked)
                lstRestaurants.Items.Add("Main Street Pizza Company");

            // Corner Café: has everything, so it always shows
            lstRestaurants.Items.Add("Corner Café");

            // Mama's: vegetarian only, so no vegan and no gluten-free
            if (!chkVegan.Checked && !chkGluten.Checked)
                lstRestaurants.Items.Add("Mama's Fine Italian");

            // Chef's Kitchen: has everything, so it always shows
            lstRestaurants.Items.Add("The Chef's Kitchen");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
