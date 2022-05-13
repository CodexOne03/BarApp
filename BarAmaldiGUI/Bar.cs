using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace BarAmaldiGUI
{
    public static class Bar
    {
        public static List<Food> AllFoods;
        public static Order Order;
        public static string message;

        public static string allFoodsPath
        {
            get
            {
                return Directory.GetCurrentDirectory() + @"\AllFoods.txt";
            }
        }

        public static string messagePath
        {
            get
            {
                return Directory.GetCurrentDirectory() + @"\message.txt";
            }
        }

        public static void Init()
        {
            //foods
            if (!File.Exists(allFoodsPath))
            {
                Console.WriteLine("You haven't created a food menu.");
                return;
            }
            else
            {
                AllFoods = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Food>>(File.ReadAllText(allFoodsPath));
            }
        }
    }

    public class Food
    {
        public int ID;
        public string Description;
        public string Price;
        public bool HasSauce;
        public bool IsHeatable;
        public Food(int ID, string description, string price, bool hasSauce)
        {
            this.ID = ID;
            this.Description = description;
            this.Price = price;
            this.HasSauce = hasSauce;
        }

        public override string ToString()
        {
            var sauce = this.HasSauce == true ? "con salse" : "senza salse";
            var heat = this.IsHeatable == true ? "riscaldabile" : "non riscaldabile";
            return $"{this.ID} {this.Description} {sauce} {heat} {this.Price}";
        }
    }

    public class Item
    {
        public int ID;
        public int Quantita;
        public bool Scaldato;
        public Salsa Salsa;
        public float totalPrice
        {
            get
            {
                return float.Parse(Bar.AllFoods.FirstOrDefault(i => i.ID == this.ID).Price, CultureInfo.InvariantCulture.NumberFormat) * this.Quantita;
            }
        }
        public Item(int ID, int quantita, bool scaldato, Salsa salsa)
        {
            this.ID = ID;
            this.Quantita = quantita;
            this.Scaldato = scaldato;
            this.Salsa = salsa;
        }
        public override bool Equals(object obj)
        {
            var item = obj as Item;
            if (item != null)
            {
                return this.ID == item.ID && this.Quantita == item.Quantita && this.Scaldato == item.Scaldato && this.Salsa == item.Salsa;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            var sus = this.Salsa != Salsa.None ? $" CON SALSA {this.Salsa.ToString()}" : "";
            var hot = this.Scaldato == true ? " RISCALDATO" : "";
            return $"{this.Quantita} {Bar.AllFoods.FirstOrDefault(i => i.ID == this.ID).Description}{sus}{hot}";
        }
    }

    public enum Salsa
    {
        None,
        SenzaSalsa,
        Ketchup,
        Mayo,
        Rosa
    }

    public class Order
    {
        public float TotalPrice
        {
            get
            {
                float totalPrice = 0;
                foreach (var food in this.Items)
                {
                    totalPrice += float.Parse(Bar.AllFoods.FirstOrDefault(i => i.ID == food.ID).Price, CultureInfo.InvariantCulture.NumberFormat) * food.Quantita;
                }
                return totalPrice;
            }
        }
        private List<Item> m_items;
        public List<Item> Items
        {
            get
            {
                return this.m_items;
            }
            set
            {
                this.m_items = value;
            }
        }
        public Order()
        {
            Items = new List<Item>();
        }
        public void Add(Item item)
        {

            if (this.Items.Contains(item))
            {
                int index = this.Items.IndexOf(item);
                this.Items[index].Quantita++;
            }
            else
            {
                this.Items.Add(item);
            }
            Console.WriteLine(item);
        }
    }
}
