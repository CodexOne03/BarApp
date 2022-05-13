using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarAmaldiGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bar.Init();
            foreach (var food in Bar.AllFoods)
            {
                ListViewItem item = new ListViewItem(new[] { food.ID.ToString(), food.Description, food.HasSauce == true ? "con salse" : "senza salse", food.IsHeatable == true ? "riscaldabile" : "non riscaldabile", food.Price });
                foodList.Items.Add(item);
            }
        }

        private void foodList_SelectedIndexChanged(object sender, EventArgs e)
        {
            sauceList.Items.Clear();
            if (foodList.SelectedIndices.Count != 0)
            {
                if (Bar.AllFoods.First(i => i.ID == foodList.SelectedIndices[0]).HasSauce)
                {
                    sauceList.Items.Add("Senza salse");
                    sauceList.Items.Add("Con Ketchup");
                    sauceList.Items.Add("Con maionese");
                    sauceList.Items.Add("Con salsa rosa");
                }
            }
            heatedList.Items.Clear();
            if (foodList.SelectedIndices.Count != 0)
            {
                if (Bar.AllFoods.First(i => i.ID == foodList.SelectedIndices[0]).IsHeatable)
                {
                    heatedList.Items.Add("Riscaldato");
                    heatedList.Items.Add("Non riscaldato");
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (foodList.SelectedIndices.Count != 0)
            {
                Salsa sauce = Salsa.None;
                bool heated = false;
                //string order = $"{quantityNumeric.Value} {food.Description} {foodSauce} {heatedFood}";
                string order = $"{quantityNumeric.Value}";
                if (Bar.AllFoods[foodList.SelectedIndices[0]].IsHeatable && heatedList.SelectedIndices.Count != 0)
                {
                    heated = heatedList.SelectedIndices[0] == 0 ? true : false;
                }
                else
                {

                }
                if (Bar.AllFoods[foodList.SelectedIndices[0]].HasSauce && sauceList.SelectedIndices.Count != 0)
                {
                    switch (sauceList.SelectedIndices[0])
                    {
                        case 0:
                            sauce = Salsa.SenzaSalsa;
                            break;
                        case 1:
                            sauce = Salsa.Ketchup;
                            break;
                        case 2:
                            sauce = Salsa.Mayo;
                            break;
                        case 3:
                            sauce = Salsa.Rosa;
                            break;
                    }
                }
                var item = new Item(foodList.SelectedIndices[0], (int)quantityNumeric.Value, heated, sauce);
                var heatedFood = item.Scaldato == true ? "riscaldato" : "";
                var food = Bar.AllFoods.First(i => i.ID == item.ID);
                var foodSauce = sauce != Salsa.SenzaSalsa ? $" con salsa {sauce}" : "senza salsa";
                foodSauce = sauce != Salsa.None ? foodSauce : "";
                order += $" {food.Description}{foodSauce} {heatedFood} ({food.ID})";
                if (Bar.Order == null)
                {
                    Bar.Order = new Order();
                }
                Bar.Order.Add(item);
                orderList.Items.Add(order);
                printButton.Enabled = true;
            }
            priceLabel.Text = "Prezzo totale: " + Bar.Order.TotalPrice.ToString();
        }

        private void orderList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (orderList.SelectedIndices.Count != 0)
            {
                removeButton.Enabled = true;
            }
            else
            {
                removeButton.Enabled = false;
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (Bar.Order.Items.Count >= orderList.SelectedIndices[0] + 1)
            {
                Bar.Order.Items.RemoveAt(orderList.SelectedIndices[0]);
            }
            else
            {
                string arrays = "Bar: { ";
                foreach (var item in Bar.Order.Items)
                {
                    arrays += item.ID + " ";
                }
                arrays += "}\nOrderList: { ";
                foreach (var item in orderList.Items)
                {
                    arrays += item.ToString() + " ";
                }
                arrays += "}";
                throw new Exception("OrderList and Bar.Order.Items aren't coincident\n" + arrays);
            }
            orderList.Items.RemoveAt(orderList.SelectedIndices[0]);
            if (orderList.Items.Count == 0)
            {
                printButton.Enabled = false;
            }
            priceLabel.Text = "Prezzo totale: " + Bar.Order.TotalPrice.ToString();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            string order = "\n";
            float price = 0f;
            foreach (var item in Bar.Order.Items)
            {
                Food food = Bar.AllFoods.First(i => i.ID == item.ID);
                string sauce = food.HasSauce && item.Salsa != Salsa.None ? $" con salsa {item.Salsa.ToString()}" : "";
                string heated = food.IsHeatable && item.Scaldato ? " riscaldato" : "";
                order += $"{item.Quantita} {food.Description}{sauce}{heated}";
                order += "\n";
                price += item.totalPrice;
            }
            Clipboard.SetText(order);

            order += $"Totale: {price}";
            MessageBox.Show(order, "Testo copiato nella Clipboard", MessageBoxButtons.OK);
        }
    }
}
