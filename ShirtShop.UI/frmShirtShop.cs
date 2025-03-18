using System;
using System.Windows.Forms;
using ShirtShop.Entities;

namespace ShirtShop.UI
{
    public partial class frmShirtShop : Form
    {
        public frmShirtShop()
        {
            InitializeComponent();
        }

        // wordt uitgevoerd bij opstarten form
        private void FrmShirtShop_Load(object sender, EventArgs e)
        {
            // vul de comboboxen met de enums

            // verzamel alle fabric types in een array
            // vergeet niet de nodige references/imports (using) te doen
            Array fabrics = Enum.GetValues(typeof(Fabric));
            // voeg alle fabrics toe aan de juiste combobox
            foreach (Fabric fabric in fabrics)
            {
                cbxFabric.Items.Add(fabric);
            }

            // alternatief
            // cbxFabric.DataSource = fabrics;

            Array sizes = Enum.GetValues(typeof(Size));
            foreach (Size size in sizes)
            {
                cbxSize.Items.Add(size);
            }

            Array colors = Enum.GetValues(typeof(Color));
            foreach (Color color in colors)
            {
                cbxColor.Items.Add(color);
            }

            Array sleeveLengths = Enum.GetValues(typeof(SleeveLength));
            foreach (SleeveLength sleeveLength in sleeveLengths)
            {
                cbxSleeveLength.Items.Add(sleeveLength);
            }

            Array brands = Enum.GetValues(typeof(Brand));
            foreach (Brand brand in brands)
            {
                cbxBrand.Items.Add(brand);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            // voor de enums moet ik telkens duidelijk maken
            // dat het geselecteerde item uit een combobox
            // effectief van een specifiek enum type is
            Shirt shirt = new Shirt(Guid.NewGuid(),
                txtName.Text, (Fabric)cbxFabric.SelectedItem,
                (Size)cbxSize.SelectedItem, (Color)cbxColor.SelectedItem,
                (SleeveLength)cbxSleeveLength.SelectedItem,
                (Brand)cbxBrand.SelectedItem, ckbEasyIroning.Checked,
                Convert.ToDecimal(txtPrice.Text));

            // als je de naam van de shirt in de listbox wil zien
            // moet je uiteraard nog een override van ToString()
            // maken in de Shirt class
            lbxShirts.Items.Add(shirt);
        }
    }
}
