using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Uppg1BLL;
using Uppg1BLL.buildinfiles;

namespace Uppg1UI
{
    public partial class Form1 : Form
    {
        EstateManager Em = new EstateManager();
        string fileName = null;

        public Form1()

        {
            InitializeComponent();
            InitializeGUI();

        }
        private void InitializeGUI()
        {

            AddModBtn.Enabled = false;

            CategoryCB.DataSource = Enum.GetValues(typeof(Category));

            CountryCB.DataSource = Enum.GetValues(typeof(Countries));
        }

        private void Update()
        {
            CityTB.Clear();
            ZipTB.Clear();
            StreetTB.Clear();
            SpecTB.Clear();
            listBox1.DataSource = Em.ToStringArray();
        }

        private void CategoryCB_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (CategoryCB.SelectedIndex == 0)
            {
                TypeCB.DataSource = Enum.GetValues(typeof(ResType));

            }
            else if (CategoryCB.SelectedIndex == 1)
            {
                TypeCB.DataSource = Enum.GetValues(typeof(ComType));
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            string cat = CategoryCB.Text;
            string type = TypeCB.Text;
            string country = CountryCB.Text;
            string city = CityTB.Text;
            string street = StreetTB.Text;
            string zip = ZipTB.Text;
            string spec = SpecTB.Text;

            Adress Aobj = new Adress(city, street, zip, country);

            try
            {
                if (!string.IsNullOrEmpty(cat) && !string.IsNullOrEmpty(type) && !string.IsNullOrEmpty(country) && !string.IsNullOrEmpty(city) && !string.IsNullOrEmpty(street) && !string.IsNullOrEmpty(zip))
                {

                    if (type == "Appartment")
                    {
                        Appartment Bobj = new Appartment(cat, Aobj, spec, type);
                        Em.Add(Bobj);
                        MessageBox.Show("Added");
                        Update();
                    }
                    if (type == "House")
                    {
                        House Bobj = new House(cat, Aobj, spec, type);
                        Em.Add(Bobj);

                        MessageBox.Show("Added");

                        Update();
                    }
                    if (type == "Villa")
                    {
                        Villa Bobj = new Villa(cat, Aobj, spec, type);
                        Em.Add(Bobj);

                        MessageBox.Show("Added");

                        Update();
                    }
                    if (type == "Townhouse")
                    {
                        Townhouse Bobj = new Townhouse(cat, Aobj, spec, type);
                        Em.Add(Bobj);

                        MessageBox.Show("Added");

                        Update();
                    }
                    if (type == "Shop")
                    {
                        Shop Bobj = new Shop(cat, Aobj, spec, type);
                        Em.Add(Bobj);

                        MessageBox.Show("Added");

                        Update();
                    }
                    if (type == "Warehouse")
                    {
                        Warehouse Bobj = new Warehouse(cat, Aobj, spec, type);
                        Em.Add(Bobj);

                        MessageBox.Show("Added");

                        Update();
                    }
                }
                else
                {
                    MessageBox.Show("Please fill all the forms!!");
                }
            }

            catch (Exception exc)
            {
                throw exc;
            }
        }

        private void TypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TypeCB.Text == "Appartment")
            {
                SpecLabel.Text = "Floor";
            }
            if (TypeCB.Text == "House")
            {
                SpecLabel.Text = "Pool-Size";
            }
            if (TypeCB.Text == "Villa")
            {
                SpecLabel.Text = "Number of rooms";
            }
            if (TypeCB.Text == "Townhouse")
            {
                SpecLabel.Text = "Number of neighbors";
            }
            if (TypeCB.Text == "Shop")
            {
                SpecLabel.Text = "Number of registers";
            }
            if (TypeCB.Text == "Warehouse")
            {
                SpecLabel.Text = "Height of warehouse in meters";
            }

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.SelectedItems.Count == 1)
                {
                    Em.DeleteAt(listBox1.SelectedIndex);
                    Update();
                }
                else
                {
                    MessageBox.Show("Please select only one item!");
                }
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count == 1)
            {
                if (listBox1.SelectedIndex >= 0)
                {
                    MessageBox.Show(Em.GetAt(listBox1.SelectedIndex).ToString());
                }
                else
                {
                    MessageBox.Show("Please select a listing!");
                }
            }
            else
            {
                MessageBox.Show("Please select only one item!");
            }
        }

        private void ModifyBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count == 1)
            {

                if (listBox1.SelectedIndex >= 0)
                {
                    AddModBtn.Enabled = true;
                    AddBtn.Enabled = false;

                    CategoryCB.Text = Em.GetAt(listBox1.SelectedIndex).Cat;
                    CountryCB.Text = Em.GetAt(listBox1.SelectedIndex).Adress.Country;
                    CityTB.Text = Em.GetAt(listBox1.SelectedIndex).Adress.City;
                    StreetTB.Text = Em.GetAt(listBox1.SelectedIndex).Adress.Street;
                    ZipTB.Text = Em.GetAt(listBox1.SelectedIndex).Adress.Zip;
                }
                else
                {
                    MessageBox.Show("Please select a listing!");
                }
            }
            else
            {
                MessageBox.Show("Please select only one item!");
            }

        }

        private void AddModBtn_Click(object sender, EventArgs e)
        {
            string cat = CategoryCB.Text;
            string type = TypeCB.Text;
            string country = CountryCB.Text;
            string city = CityTB.Text;
            string street = StreetTB.Text;
            string zip = ZipTB.Text;
            string spec = SpecTB.Text;

            Adress Aobj = new Adress(city, street, zip, country);
            try
            {

                if (!string.IsNullOrEmpty(cat) && !string.IsNullOrEmpty(type) && !string.IsNullOrEmpty(country) && !string.IsNullOrEmpty(city) && !string.IsNullOrEmpty(street) && !string.IsNullOrEmpty(zip))
                {
                    if (type == "Appartment")
                    {
                        Appartment Bobj = new Appartment(cat, Aobj, spec, type);
                        Em.ChangeAt(Bobj, listBox1.SelectedIndex);

                        AddModBtn.Enabled = false;
                        AddBtn.Enabled = true;
                        Update();

                    }
                    if (type == "House")
                    {
                        House Bobj = new House(cat, Aobj, spec, type);
                        Em.ChangeAt(Bobj, listBox1.SelectedIndex);

                        AddModBtn.Enabled = false;
                        AddBtn.Enabled = true;
                        Update();
                    }
                    if (type == "Villa")
                    {
                        Villa Bobj = new Villa(cat, Aobj, spec, type);
                        Em.ChangeAt(Bobj, listBox1.SelectedIndex);

                        AddModBtn.Enabled = false;
                        AddBtn.Enabled = true;
                        Update();
                    }
                    if (type == "Townhouse")
                    {
                        Townhouse Bobj = new Townhouse(cat, Aobj, spec, type);
                        Em.ChangeAt(Bobj, listBox1.SelectedIndex);

                        AddModBtn.Enabled = false;
                        AddBtn.Enabled = true;
                        Update();
                    }
                    if (type == "Shop")
                    {
                        Shop Bobj = new Shop(cat, Aobj, spec, type);
                        Em.ChangeAt(Bobj, listBox1.SelectedIndex);

                        AddModBtn.Enabled = false;
                        AddBtn.Enabled = true;
                        Update();
                    }
                    if (type == "Warehouse")
                    {
                        Warehouse Bobj = new Warehouse(cat, Aobj, spec, type);
                        Em.ChangeAt(Bobj, listBox1.SelectedIndex);

                        AddModBtn.Enabled = false;
                        AddBtn.Enabled = true;
                        Update();
                    }
                }
                else
                {
                    MessageBox.Show("Please fill all the forms!!");
                }
            }
            catch(Exception exc)
            {
                throw exc;
            }
        }

        private void mnuNew_Click(object sender, EventArgs e)
        {
            DialogResult NewDialog = MessageBox.Show("Are u sure u want to do this?", "New", MessageBoxButtons.OK);
            if(NewDialog == DialogResult.OK)
            {
          
                Em.DeleteAll();
                fileName = null;
                Update();
            }
            else
            {
                Update();
            }
            
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            listBox1.SelectedItems.Clear();
            for(int i=0; i<listBox1.Items.Count; i++)
            {
                if (listBox1.Items[i].ToString().ToLower().Contains(SearchCityTB.Text.ToLower()) && listBox1.Items[i].ToString().ToLower().Contains(SearchTypeTB.Text.ToLower()))
                {
                    listBox1.SetSelected(i, true);
                }
            }
        }

        private void mnuSaveAs_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Txt File |*.txt";
                saveFileDialog1.Title = "Save a file";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Em.SaveFile(saveFileDialog1.FileName);
                    MessageBox.Show("Saved!");
                }
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Txt File |*.txt";
                openFileDialog1.Title = "select a file";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    fileName = openFileDialog1.FileName;
                    Em.OpenFile(fileName);
                    Update();
                }
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            if (fileName == null)
            {
                mnuSaveAs.PerformClick();
            }

            else
            {
                try
                {
                    Em.SaveFile(fileName);
                    MessageBox.Show("Saved!");
                }
                catch (Exception exc)
                {
                    throw exc;
                }
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            DialogResult NewDialog1 = MessageBox.Show("Are u sure u want to exit?", "New", MessageBoxButtons.YesNo);
            if (NewDialog1 == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if(NewDialog1 == DialogResult.No)
            {
                Update();
            }
        }
    }
}
