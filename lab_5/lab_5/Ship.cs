using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5
{
    internal class Ship : Vehicle 
    {
        string port;
        int count;
        public string Port { get; set; }
        public int Count { get; set; }
        public Ship(int price, int speed, int grad_year, string port, int count) : base(price, speed, grad_year)
        {
            Port = port;
            Count = count;
        }
        public Ship(int price) : base(price) { }
        public override int Change_price(int price)
        {
            return Price;
        }
        public override int Change_speed(int speed)
        {
            return Speed;
        }
        public override int Change_grad_year(int grad_year)
        {
            return Grad_year;
        }
        public override string show()
        {
            return "\nКОРАБЕЛЬ" + "\nЦіна: " + Price + " $" + "\nШвидкість: " + Speed + " км/год" +
                "\nРік випуску: " + Grad_year + "\nПорт прописки: " + Port + "\nК-ість пасажирів: " + Count + "\n";
        }
        public override float cap(float c)
        {
            return c;
        }
        public override string Print()
        {
            return base.Print() + "\nПорт: " + Port + "\nК-ість пасажирів: " + Count + "\n----------------------------";
        }
        public override int CompareTo(object ob)
        {
            Vehicle s = ob as Vehicle;
            if (s != null)
            {
                /*
                if (this.Square > office.Square) return 1;
                else if (this.Square < office.Square) return -1;
                else return 0;*/
                return this.Grad_year.CompareTo(s.Grad_year);
            }
            else throw new InvalidCastException();
        }
        public override object Clone() => MemberwiseClone();
        public override string ToString()
        {
            return "\nКОРАБЕЛЬ" + "\nЦіна: " + Price + " $" + "\nШвидкість: " + Speed + " км/год" +
                "\nРік випуску: " + Grad_year + "\nПорт прописки: " + Port + "\nК-ість пасажирів: " + Count + "\n";
        }
    }
}
