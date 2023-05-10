using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5
{
    internal class Plain : Vehicle
    {

        int height;
        int count_pass;
        public int Height { get; set; }
        public int Count_pass { get; set; }
        public Plain(int price, int speed, int grad_year, int height, int count_pass) : base(price, speed, grad_year)
        {
            Height = height;
            Count_pass = count_pass;
        }
        public Plain(int price) : base(price) { }
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
            return "ЛІТАК" + "\nЦіна: " + Price + " $" + "\nШвидкість: " + Speed + " км/год" + "\nРік випуску: " + Grad_year +
                "\nВисота: " + Height + " м" + "\nК-ість пасажирів: " + Count_pass + "\n";
        }
        public override float cap(float c)
        {
            return c;
        }
        public override int CompareTo(object ob)
        {
            Vehicle p = ob as Vehicle;
            if (p != null)
            {
                /*
                if (this.Square > office.Square) return 1;
                else if (this.Square < office.Square) return -1;
                else return 0;*/
                return this.Grad_year.CompareTo(p.Grad_year);
            }
            else throw new InvalidCastException();
        }
        public override object Clone() => MemberwiseClone();
        public override string Print()
        {
            return base.Print() + "\nВисота: " + Height + "\nК-ість пасажирів: " + Count_pass + "\n----------------------------";
        }
        public override string ToString()
        {
            return "ЛІТАК" + "\nЦіна: " + Price + " $" + "\nШвидкість: " + Speed + " км/год" + "\nРік випуску: " + Grad_year +
                "\nВисота: " + Height + " м" + "\nК-ість пасажирів: " + Count_pass ;
        }
    }
}
