using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5
{
    abstract class Vehicle : ICapacity, IComparable, ICloneable
    {
        int price;
        int speed;
        int grad_year;
        public Vehicle(int price, int speed, int grad_year)
        {
            Price = price;
            Speed = speed;
            Grad_year = grad_year;
        }
        public Vehicle(int price)
        {
            Price = price;
        }
        public int Price { get; set; }
        public int Speed { get; set; }
        public int Grad_year { get; set; }
        public string City { get; set; }
        public abstract int Change_price(int price);
        public abstract int Change_speed(int speed);
        public abstract int Change_grad_year(int grad_year);
        public abstract string show();
        public abstract float cap(float c);
        public virtual string Print()
        {
            return "\nЦіна: " + Price + "\nШвидкість: " + Speed + "\nРік випуску: " + Grad_year;
        }
        public abstract object Clone();
        public abstract int CompareTo(object ob);
        public string Sorted()
        {
            return "\nПосортований масив!";
        }
        public string Non_sorted()
        {
            return "\nПочатковий масив!";
        }
        public override string ToString()
        {
            return "\nЦіна: " + Price + "\nШвидкість: " + Speed + "\nРік випуску: " + Grad_year;
        }
    }

}
