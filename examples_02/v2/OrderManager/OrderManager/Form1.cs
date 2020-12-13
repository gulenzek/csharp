using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderManager.Entity;
using OrderManager.Repository;

namespace OrderManager
{
    public partial class Form1 : Form
    {

        private IPersonRepository _personRepository;
        private IProductRepository _productRepository;
        private IOrderRepository _orderRepository;

        private BindingList<Person> _personBindingList;
        private BindingList<Product> _productBingindList;
        private BindingList<Order> _orderBindingList;


        public Form1()
        {
            InitializeComponent();
            InitializeGenderComboBox();

            productComboBox.DisplayMember = "Name";
            personComboBox.DisplayMember = "FirstName";
            

            _personRepository = new PersonRepository();
            _productRepository = new ProductRepository();
            _orderRepository = new OrderRepository();

            _personBindingList = new BindingList<Person>(_personRepository.FindAll());
            _productBingindList = new BindingList<Product>(_productRepository.FindAll());
            _orderBindingList = new BindingList<Order>(_orderRepository.FindAll());

            personsDataGridView.DataSource = _personBindingList;
            productsDataGridView.DataSource = _productBingindList;
            ordersDataGridView.DataSource = _orderBindingList;
            
        }

        private void InitializeGenderComboBox()
        {
            genderComboBox.DataSource = Enum.GetValues(typeof(Gender));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Person person = GetPersonFromInputs();
            person = _personRepository.Save(person);
            AddPersonToDataGridView(person);

            AddPersonToComboBox(person);
            ClearPersonInputs();
        }

        private void AddPersonToComboBox(Person person)
        {
            personComboBox.Items.Add(person);
        }

        private void ClearPersonInputs()
        {
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            genderComboBox.SelectedItem = Gender.Man;
        }

        private void AddPersonToDataGridView(Person person)
        {
        
            _personBindingList.ResetBindings();
        }

        private Person GetPersonFromInputs()
        {
            String firstName = firstNameTextBox.Text;
            String lastName = lastNameTextBox.Text;
            Gender gender = (Gender)genderComboBox.SelectedItem;


            Person person = new Person
            {
                FirstName = firstName,
                LastName = lastName,
                Gender = gender,
                Orders = new List<Order>()

            };

            return person;
        }

        private void personsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                int id = (int)personsDataGridView.Rows[e.RowIndex].Cells[0].Value;
                _personRepository.deleteById(id);
                personsDataGridView.Rows.RemoveAt(e.RowIndex);

            }
        }

        private void productSaveButton_Click(object sender, EventArgs e)
        {
            Product product = GetProductFromInputs();
            product = _productRepository.Save(product);
            AddProductToDataGridView(product);
            AddProductToComboBox(product);
            ClearProductInputs();
            
        }

        private void AddProductToComboBox(Product product)
        {
            productComboBox.Items.Add(product);
        }

        private void ClearProductInputs()
        {
            nameTextBox.Text = "";
            stockAmountTextBox.Text = "";
            unitPriceTextBox.Text = "";

        }

        private void AddProductToDataGridView(Product product)
        {
            _productBingindList.ResetBindings();
        }

        private Product GetProductFromInputs()
        {
            String name = nameTextBox.Text;
            int stockAmount = int.Parse(stockAmountTextBox.Text);
            double unitPrice = double.Parse(unitPriceTextBox.Text);

            Product product = new Product
            {
                Name = name,
                StockAmount = stockAmount,
                UnitPrice = unitPrice,
                Orders = new List<Order>()

            };

            return product;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Order order = GetOrderFromInputs();
            order = _orderRepository.Save(order);
            AddOrderToDataGridView(order);
            ClearOrderInputs();



        }

        private void ClearOrderInputs()
        {
            amountTextBox.Text = "";
            productComboBox.SelectedItem = null;
            personComboBox.SelectedItem = null;
        }

        private void AddOrderToDataGridView(Order order)
        {
            _orderBindingList.ResetBindings();
        }

        private Order GetOrderFromInputs()
        {
            int amount = int.Parse(amountTextBox.Text);
            Product product = (Product)productComboBox.SelectedItem;
            Person person = (Person)personComboBox.SelectedItem;

            Order order = new Order
            {
                Amount = amount,
                Person = person,
                Product = product
            };


            return order;

        }

        private void personsDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                int id = (int)personsDataGridView.Rows[e.RowIndex].Cells[0].Value;
                Person person = _personRepository.FindById(id);

                if(e.ColumnIndex == 1)
                {
                    person.FirstName = (String) personsDataGridView.Rows[e.RowIndex].Cells[1].Value;
                }
                else if(e.ColumnIndex == 2)
                {
                    person.LastName = (String)personsDataGridView.Rows[e.RowIndex].Cells[2].Value;

                }
            }
        }
    }
}
