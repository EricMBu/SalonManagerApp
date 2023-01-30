/*
 * assignment4.sln
 * Description: Beatuy shop inventory form
 * 
 * Revision History
 *      Eric Buchanan, 2022-04-04: Created
 *      Eric Buchanan, 2022-04-07: Product and Procedure objects
 *      Eric Buchanan, 2022-04-08: Added error handling and appstates
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory;

namespace assignment4
{
    public partial class Form1 : Form
    {
        //initialize product manager, constructed in onload function
        private ProductManager manager;

        //error message
        private string errorMessage = "";

        //enumeration for appstates
        private enum AppState { AwaitingInput, AddProduct, AddProcedure, EditProduct, EditProcedure };
        private AppState _currentAppState = AppState.AwaitingInput;

        //updates the app state
        private void UpdateState(AppState setState)
        {
            ResetTextColours();

            _currentAppState = setState;
            //enable and disables certain fields depending on set state
            switch (_currentAppState)
            {
                case AppState.AwaitingInput:
                    listInventory.SelectedIndex = -1;

                    txtProductName.Text = "";
                    txtProductPrice.Text = "";
                    rtbProductDescription.Text = "";

                    txtProcedureName.Text = "";
                    txtProcedurePrice.Text = "";
                    txtProcedureMinutes.Text = "";
                    rtbProcedureDescription.Text = "";

                    btnAddProcedure.Enabled = true;
                    btnAddProduct.Enabled = true;
                    btnAddProduct.Text = "Add new";
                    btnAddProcedure.Text = "Add new";

                    btnUpdateProcedure.Enabled = false;
                    btnUpdateProduct.Enabled = false;

                    btnDeleteProcedure.Enabled = false;
                    btnDeleteProduct.Enabled = false;

                    txtProductName.Enabled = false;
                    txtProductPrice.Enabled = false;
                    rtbProductDescription.Enabled = false;

                    txtProcedureName.Enabled = false;
                    txtProcedurePrice.Enabled = false;
                    txtProcedureMinutes.Enabled = false;
                    rtbProcedureDescription.Enabled = false;
                    break;

                case AppState.AddProduct:
                    txtProductName.Text = "";
                    txtProductPrice.Text = "";
                    rtbProductDescription.Text = "";

                    txtProcedureName.Text = "";
                    txtProcedurePrice.Text = "";
                    txtProcedureMinutes.Text = "";
                    rtbProcedureDescription.Text = "";

                    btnAddProcedure.Enabled = false;
                    btnAddProduct.Enabled = true;
                    btnAddProduct.Text = "Save new";
                    btnAddProcedure.Text = "Add new";

                    btnDeleteProcedure.Enabled = false;
                    btnDeleteProduct.Enabled = false;

                    btnUpdateProcedure.Enabled = false;
                    btnUpdateProduct.Enabled = false;

                    txtProductName.Enabled = true;
                    txtProductPrice.Enabled = true;
                    rtbProductDescription.Enabled = true;

                    txtProcedureName.Enabled = false;
                    txtProcedurePrice.Enabled = false;
                    txtProcedureMinutes.Enabled = false;
                    rtbProcedureDescription.Enabled = false;
                    break;

                case AppState.AddProcedure:
                    txtProductName.Text = "";
                    txtProductPrice.Text = "";
                    rtbProductDescription.Text = "";

                    txtProcedureName.Text = "";
                    txtProcedurePrice.Text = "";
                    txtProcedureMinutes.Text = "";
                    rtbProcedureDescription.Text = "";

                    btnAddProcedure.Enabled = true;
                    btnAddProduct.Enabled = false;
                    btnAddProduct.Text = "Add new";
                    btnAddProcedure.Text = "Save new";

                    btnDeleteProcedure.Enabled = false;
                    btnDeleteProduct.Enabled = false;

                    btnUpdateProcedure.Enabled = false;
                    btnUpdateProduct.Enabled = false;

                    txtProductName.Enabled = false;
                    txtProductPrice.Enabled = false;
                    rtbProductDescription.Enabled = false;

                    txtProcedureName.Enabled = true;
                    txtProcedurePrice.Enabled = true;
                    txtProcedureMinutes.Enabled = true;
                    rtbProcedureDescription.Enabled = true;
                    break;

                case AppState.EditProduct:
                    btnAddProcedure.Enabled = true;
                    btnAddProduct.Enabled = true;
                    btnAddProduct.Text = "Add new";
                    btnAddProcedure.Text = "Add new";

                    btnDeleteProcedure.Enabled = false;
                    btnDeleteProduct.Enabled = true;

                    btnUpdateProcedure.Enabled = false;
                    btnUpdateProduct.Enabled = true;

                    txtProductName.Enabled = false;
                    txtProductPrice.Enabled = true;
                    rtbProductDescription.Enabled = true;

                    txtProcedureName.Enabled = false;
                    txtProcedurePrice.Enabled = false;
                    txtProcedureMinutes.Enabled = false;
                    rtbProcedureDescription.Enabled = false;
                    break;

                case AppState.EditProcedure:
                    btnAddProcedure.Enabled = true;
                    btnAddProduct.Enabled = true;
                    btnAddProduct.Text = "Add new";
                    btnAddProcedure.Text = "Add new";

                    btnDeleteProcedure.Enabled = true;
                    btnDeleteProduct.Enabled = false;

                    btnUpdateProcedure.Enabled = true;
                    btnUpdateProduct.Enabled = false;

                    txtProductName.Enabled = false;
                    txtProductPrice.Enabled = false;
                    rtbProductDescription.Enabled = false;

                    txtProcedureName.Enabled = false;
                    txtProcedurePrice.Enabled = true;
                    txtProcedureMinutes.Enabled = true;
                    rtbProcedureDescription.Enabled = true;
                    break;
            }
        }

        //resets background colours
        private void ResetTextColours()
        {
            txtProductName.BackColor = default(Color);
            rtbProductDescription.BackColor = default(Color);
            txtProductPrice.BackColor = default(Color);

            txtProcedureName.BackColor = default(Color);
            rtbProcedureDescription.BackColor = default(Color);
            txtProcedurePrice.BackColor = default(Color);
            txtProcedureMinutes.BackColor = default(Color);
        }
        //validates text input for product
        private void ValidateProduct()
        {
            //boolean for setting first field with error to focus
            Boolean setFocus = false;
            //if empty
            if (string.IsNullOrEmpty(txtProductName.Text))
            {
                //add specific error to error message
                errorMessage += "Error: please enter valid name \n";
                txtProductName.BackColor = Color.LightPink;
                if (!setFocus)
                {
                    txtProductName.Focus();
                    setFocus = true;
                }
            }
            if (string.IsNullOrEmpty(rtbProductDescription.Text))
            {
                errorMessage += "Error: please enter description \n";
                rtbProductDescription.BackColor = Color.LightPink;
                if (!setFocus)
                {
                    rtbProductDescription.Focus();
                    setFocus = true;
                }
            }
            //if not double, or less than 0
            double price;
            if(!double.TryParse(txtProductPrice.Text, out price) || price < 0)
            {
                errorMessage += "Error: invalid price \n";
                txtProductPrice.BackColor = Color.LightPink;
                if (!setFocus)
                {
                    txtProductPrice.Focus();
                    setFocus = true;
                }
            }
        }

        //validates text input for procedure
        private void ValidateProcedure()
        {
            Boolean setFocus = false;
            //if empty
            if (string.IsNullOrEmpty(txtProcedureName.Text))
            {
                errorMessage += "Error: please enter valid name \n";
                txtProcedureName.BackColor = Color.LightPink;
                if (!setFocus)
                {
                    txtProcedureName.Focus();
                    setFocus = true;
                }
            }
            if (string.IsNullOrEmpty(rtbProcedureDescription.Text))
            {
                errorMessage += "Error: please enter description \n";
                rtbProcedureDescription.BackColor = Color.LightPink;
                if (!setFocus)
                {
                    rtbProcedureDescription.Focus();
                    setFocus = true;
                }
            }
            double price;
            if (!double.TryParse(txtProcedurePrice.Text, out price) || price < 0)
            {
                errorMessage += "Error: invalid price \n";
                txtProcedurePrice.BackColor = Color.LightPink;
                if (!setFocus)
                {
                    txtProcedurePrice.Focus();
                    setFocus = true;
                }
            }
            //if not int or less than or equal to 0
            int minutes;
            if (!int.TryParse(txtProcedureMinutes.Text, out minutes) || minutes <= 0)
            {
                errorMessage += "Error: invalid minutes \n";
                txtProcedureMinutes.BackColor = Color.LightPink;
                if (!setFocus)
                {
                    txtProcedureMinutes.Focus();
                    setFocus = true;
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }
       
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //reset status update
            lblStatus.Text = "";
            //if nothing is selected, set appropriate state
            if(listInventory.SelectedIndex == -1)
            {
                UpdateState(AppState.AwaitingInput);
            }
            else
            {
                //initialize product data to fill form
                Product currentProduct = manager.GetItemByName(listInventory.SelectedItem.ToString());
                if(currentProduct.GetType() == typeof(Procedure))
                {
                    //switch state depending on object type
                    UpdateState(AppState.EditProcedure);
                    Procedure procedure = (Procedure)currentProduct;
                    txtProductName.Text = "";
                    txtProductPrice.Text = "";
                    rtbProductDescription.Text = "";

                    //fill form with procedure data
                    txtProcedureName.Text = procedure._name;
                    txtProcedurePrice.Text = procedure._price.ToString();
                    txtProcedureMinutes.Text = procedure._minutes.ToString();
                    rtbProcedureDescription.Text = procedure._description;
                }
                else
                {
                    UpdateState(AppState.EditProduct);
                    txtProcedureMinutes.Text = "";
                    txtProcedureName.Text = "";
                    txtProcedurePrice.Text = "";
                    rtbProcedureDescription.Text = "";

                    //fill from with product data
                    txtProductName.Text = currentProduct._name;
                    txtProductPrice.Text = currentProduct._price.ToString();
                    rtbProductDescription.Text = currentProduct._description;
                }
            }
        }

        //onload function
        private void Form1_Load(object sender, EventArgs e)
        {
            //reset error and status messages
            lblProcedureError.Text = "";
            lblProductError.Text = "";
            lblStatus.Text = "";

            //construct product manager
            manager = new ProductManager();
            //fill listbox from manager product list
            if(manager.GetAllItems() != null)
            {
                foreach (Product product in manager.GetAllItems())
                {
                    listInventory.Items.Add(product._name);
                }
            }
            //switch state and unselect listbox
            UpdateState(AppState.AwaitingInput);
            listInventory.SelectedIndex = -1;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            //switch app state to AddProduct if not already
            if(_currentAppState != AppState.AddProduct)
            {
                UpdateState(AppState.AddProduct);
            }
            //button saves form instead of adding new record
            else
            {
                errorMessage = "";
                lblProductError.Text = "";
                ValidateProduct();
                //if succeeded
                if(errorMessage.Length == 0)
                {
                    //trim text fields
                    txtProductName.Text = txtProductName.Text.Trim();
                    rtbProductDescription.Text = rtbProductDescription.Text.Trim();
                    txtProductPrice.Text = txtProductPrice.Text.Trim();

                    //assign variables from text fields
                    string name = txtProductName.Text;
                    string description = rtbProductDescription.Text;
                    double price = Convert.ToDouble(txtProductPrice.Text);
                    //update product in list
                    Product newProduct = new Product(name, description, price);
                    UpdateState(AppState.EditProduct);

                    try
                    {
                        //AddNewItem throws exception if item already exists
                        manager.AddNewItem(newProduct);
                        listInventory.Items.Add(newProduct._name);
                        UpdateState(AppState.EditProduct);

                        //select the new item in listbox after adding
                        int index = -1;
                        for (int i = 0; i < listInventory.Items.Count; i++)
                        {
                            if (listInventory.Items[i].ToString() == name)
                            {
                                index = i;
                                break;
                            }
                        }
                        listInventory.SelectedIndex = index;
                        lblStatus.Text = name + " successfully added";
                    }
                    catch (Exception ex)
                    {
                        errorMessage = ex.Message;
                        lblProductError.Text = errorMessage;
                    }
                }
                else
                {
                    lblProductError.Text = errorMessage;
                }
            }

        }
        private void btnAddProcedure_Click(object sender, EventArgs e)
        {
            //switch app state to AddProcedure if not already
            if (_currentAppState != AppState.AddProcedure)
            {
                UpdateState(AppState.AddProcedure);
            }
            else
            {
                errorMessage = "";
                lblProcedureError.Text = "";
                ValidateProcedure();
                if (errorMessage.Length == 0)
                {
                    //trim text fields
                    txtProcedureName.Text = txtProcedureName.Text.Trim();
                    rtbProcedureDescription.Text = rtbProcedureDescription.Text.Trim();
                    txtProcedurePrice.Text = txtProcedurePrice.Text.Trim();
                    txtProcedureMinutes.Text = txtProcedureMinutes.Text.Trim();

                    //assign variables
                    string name = txtProcedureName.Text;
                    string description = rtbProcedureDescription.Text;
                    double price = Convert.ToDouble(txtProcedurePrice.Text);
                    int minutes = Convert.ToInt32(txtProcedureMinutes.Text);
                    Procedure newProcedure = new Procedure(name, description, price, minutes);

                    try
                    {
                        //throws exception if procedure already exists
                        manager.AddNewItem(newProcedure);
                        listInventory.Items.Add(newProcedure._name);
                        UpdateState(AppState.EditProcedure);

                        int index = -1;
                        for (int i = 0; i < listInventory.Items.Count; i++)
                        {
                            if (listInventory.Items[i] == name)
                            {
                                index = i;
                                break;
                            }
                        }
                        listInventory.SelectedIndex = index;
                        lblStatus.Text = name + " successfully added";
                    }
                    catch (Exception ex)
                    {
                        errorMessage = ex.Message;
                        lblProcedureError.Text = errorMessage;
                    }
                    
                }
                else
                {
                    lblProcedureError.Text = errorMessage;
                }
            }
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            //reset error message
            errorMessage = "";
            ValidateProduct();
            if(errorMessage.Length == 0)
            {
                lblProductError.Text = "";
                //initialize vairables
                string name = listInventory.SelectedItem.ToString();
                string description = rtbProductDescription.Text;
                double price = Convert.ToDouble(txtProductPrice.Text);
                Product product = new Product(name, description, price);
                manager.UpdateItem(product);

                lblStatus.Text = name + " successfully updated";
            }
            //error message if failed validation
            else
            {
                lblProductError.Text = errorMessage;
            }
            
        }

        private void btnUpdateProcedure_Click(object sender, EventArgs e)
        {
            errorMessage = "";
            ValidateProcedure();
            if (errorMessage.Length == 0)
            {
                lblProductError.Text = "";
                string name = listInventory.SelectedItem.ToString();
                string description = rtbProcedureDescription.Text;
                double price = Convert.ToDouble(txtProcedurePrice.Text);
                int minutes = Convert.ToInt32(txtProcedureMinutes.Text);
                Procedure procedure = new Procedure(name, description, price, minutes);
                manager.UpdateItem(procedure);

                lblStatus.Text = name + " successfully updated";
            }
            //error message if failed validation
            else
            {
                lblProcedureError.Text = errorMessage;
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            //save name and index
            string name = listInventory.SelectedItem.ToString();
            int index = listInventory.SelectedIndex;
            //set selected index of list to first item if last is deleted
            if(index == listInventory.Items.Count - 1)
            {
                listInventory.SelectedIndex = 0;
            }
            //set index to next item after the one deleted
            else
            {
                listInventory.SelectedIndex = index + 1;
            }
            //delete items from listbox and list
            listInventory.Items.RemoveAt(index);
            manager.DeleteItem(name);
            lblStatus.Text = name + " successfully deleted";

        }

        private void btnDeleteProcedure_Click(object sender, EventArgs e)
        {
            //save name and index
            string name = listInventory.SelectedItem.ToString();
            int index = listInventory.SelectedIndex;
            //set selected index of list to first item if last is deleted
            if (index == listInventory.Items.Count - 1)
            {
                listInventory.SelectedIndex = 0;
            }
            //set index to next item after the one deleted
            else
            {
                listInventory.SelectedIndex = index + 1;
            }
            //delete items from listbox and list
            listInventory.Items.RemoveAt(index);
            manager.DeleteItem(name);
            lblStatus.Text = name + " successfully deleted";
        }
        //Reset textbox background colors when text is changed
        private void txtProductName_TextChanged(object sender, EventArgs e)
        {
            ResetTextColours();
        }

        private void rtbProductDescription_TextChanged(object sender, EventArgs e)
        {
            ResetTextColours();
        }

        private void txtProductPrice_TextChanged(object sender, EventArgs e)
        {
            ResetTextColours();
        }

        private void txtProcedureName_TextChanged(object sender, EventArgs e)
        {
            ResetTextColours();
        }

        private void rtbProcedureDescription_TextChanged(object sender, EventArgs e)
        {
            ResetTextColours();
        }

        private void txtProcedurePrice_TextChanged(object sender, EventArgs e)
        {
            ResetTextColours();
        }

        private void txtProcedureMinutes_TextChanged(object sender, EventArgs e)
        {
            ResetTextColours();
        }

        
    }
}
