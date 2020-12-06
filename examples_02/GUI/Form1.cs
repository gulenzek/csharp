using GUI.Entity;
using GUI.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        private IPersonRepository _personRepository;
        private IProductRepository _productRepository;
        private IOrderRepository _orderRepository;


        public Form1()
        {
            InitializeComponent();

            InitializePersonsListView();
            InitializeProductsListView();
            InitializeOrdersListView();

            InitializeGendersComboBox();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _personRepository = new PersonRepository();
            _productRepository = new ProductRepository();
            _orderRepository = new OrderRepository();



        }

        private void InitializeOrdersListView()
        {
            ordersListView.View = View.Details;

            ordersListView.Columns.Add("Id");
            ordersListView.Columns.Add("Amount");
            ordersListView.Columns.Add("Product id");
            ordersListView.Columns.Add("Person id");
        }

        private void InitializeProductsListView()
        {
            productsListView.View = View.Details;

            productsListView.Columns.Add("Id");
            productsListView.Columns.Add("Name");
            productsListView.Columns.Add("Stock Amount");
            productsListView.Columns.Add("Unit Price");
        }

        private void InitializeGendersComboBox()
        {
            foreach(var item in Enum.GetValues(typeof(Gender))){
                gendersComboBox.Items.Add(item);
            }
        }

        private void InitializePersonsListView()
        {
            personsListView.Columns.Add("Id");
            personsListView.Columns.Add("First Name");
            personsListView.Columns.Add("Last Name");
            personsListView.Columns.Add("Gender");

            personsListView.View = View.Details;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String firstName = firstNameTextBox.Text;
            String lastName = lastNameTextBox.Text;
            Gender? gender = GetGender();

            Person person = new Person()
            {
                FirstName = firstName,
                LastName = lastName,
                Gender = gender,
            };
            _personRepository.Save(person);
            RefreshPersonsListView(_personRepository.FindAll());
            AddPersonToComboBox(person);

            ClearPersonInputs();

        }

        private void AddPersonToComboBox(Person person)
        {
            personsComboBox.Items.Add(person);
        }

        private void AddPersonToListView(Person person)
        {
            ListViewItem lvi =  personsListView.Items.Add(person.Id.ToString());

            lvi.SubItems.Add(person.FirstName);
            lvi.SubItems.Add(person.LastName);
            lvi.SubItems.Add(person.Gender +  "");
        }

        private void AddProductToListView(Product product)
        {
            ListViewItem lvi = productsListView.Items.Add(product.Id.ToString());

            lvi.SubItems.Add(product.Name);
            lvi.SubItems.Add(product.StockAmount.ToString());
            lvi.SubItems.Add(product.UnitPrice.ToString());

        }

        private Gender? GetGender()
        {
            Gender? gender = null;
            if (gendersComboBox.SelectedItem != null)
                gender = (Gender)gendersComboBox.SelectedItem;

            return gender;
        }

        private void ClearPersonInputs()
        {
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            gendersComboBox.SelectedItem = null;
        }

        private void productSaveButton_Click(object sender, EventArgs e)
        {
            String name = nameTextBox.Text;
            int stockAmount = int.Parse(stockAmountTextBox.Text);
            double unitPrice = double.Parse(unitPriceTextBox.Text);

            Product product = ProductFactory.Create(name, unitPrice, stockAmount);
            _productRepository.Save(product);
            AddProductToListView(product);
            AddProductToComboBox(product);

            ClearProductInputs();
        }

        private void AddProductToComboBox(Product product)
        {
            productsComboBox.Items.Add(product);
        }

        private void ClearProductInputs()
        {
            nameTextBox.Text = "";
            stockAmountTextBox.Text = "";
            unitPriceTextBox.Text = "";
        }

        private void orderSaveButton_Click(object sender, EventArgs e)
        {

            try
            {
                ValidateOrderFormInputs();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning");
                return;
            }

            Product product = (Product) productsComboBox.SelectedItem;
            Person person = (Person)personsComboBox.SelectedItem;
            int amount = int.Parse(amountTextBox.Text);

            

            if(product.StockAmount >= amount) { 
                Order order = OrderFactory.Create(product, person, amount);
                _orderRepository.Save(order);
                AddOrderToListView(order);

                DecreaseProductStockAmount(order.Product, order.Amount);
                RefreshProductsListView(_productRepository.FindAll());
            }
            else
            {
                MessageBox.Show("Insufficient stock quantity", "Warning");
            }

            ClearOrderInputs();


        }

        

        private void ValidateOrderFormInputs() 
        {
            if (productsComboBox.SelectedItem == null)
                throw new ArgumentException("Products option must be selected");

            if(personsComboBox.SelectedItem == null)
                throw new ArgumentException("Persons option must be selected");

            try
            {
                int.Parse(amountTextBox.Text);
            }
            catch
            {
                throw new ArgumentException("Amount must be int format");
            }

        }

        private void DecreaseProductStockAmount(Product product, int amount)
        {
            product.StockAmount -= amount;
        }

        private void AddOrderToListView(Order order)
        {
            ListViewItem lvi = ordersListView.Items.Add(order.Id.ToString());

            lvi.SubItems.Add(order.Amount.ToString());
            lvi.SubItems.Add(order.Product.Id.ToString());
            lvi.SubItems.Add(order.Person.Id.ToString());
        }

        private void RefreshProductsListView(List<Product> products)
        {
            productsListView.Clear();
            InitializeProductsListView();

            foreach(Product product in products)
            {
                AddProductToListView(product);
            }
        }

        private void RefreshPersonsListView(List<Person> persons)
        {
            personsListView.Clear();
            InitializePersonsListView();

            foreach (Person person in persons)
            {
                AddPersonToListView(person);
            }
        }

        private void ClearOrderInputs()
        {
            productsComboBox.SelectedItem = null;
            personsComboBox.SelectedItem = null;
            amountTextBox.Text = "";
        }

        private void searchPersonButton_Click(object sender, EventArgs e)
        {
            String searchedKey = searchedPersonKeyTextBox.Text;

            Func<Person, bool> myFunc = delegate (Person person)
            {
                return person.FirstName.Contains(searchedKey) || person.LastName.Contains(searchedKey) || person.Gender.ToString().Contains(searchedKey);
            };

            List<Person> persons = _personRepository.FindWhere(myFunc);

            RefreshPersonsListView(persons);
            searchedPersonKeyTextBox.Text = "";
        }
    }
}
