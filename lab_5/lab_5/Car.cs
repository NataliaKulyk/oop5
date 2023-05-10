using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5
{
    internal class Car : Vehicle
    {
        public Car(int price, int speed, int grad_year) : base(price, speed, grad_year) { }
        public Car(int price) : base(price) { }
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
            return "\nМАШИНА" + "\nЦіна: " + Price + " $" + "\nШвидкість: " + Speed + " км/год" +
                "\nРік випуску: " + Grad_year + "\n";
        }
        public override float cap(float c)
        {
            return c;
        }
        public override string Print()
        {
            return base.Print() + "\n----------------------------";
        }
        public override int CompareTo(object ob)
        {
            Vehicle v = ob as Vehicle;
            if (v != null)
            {
                /*
                if (this.Square > office.Square) return 1;
                else if (this.Square < office.Square) return -1;
                else return 0;*/
                return this.Speed.CompareTo(v.Speed);
            }
            else throw new InvalidCastException();
        }
        public override object Clone() => MemberwiseClone();
        public override string ToString()
        {
            return "\nМАШИНА" + "\nЦіна: " + Price + " $" + "\nШвидкість: " + Speed + " км/год" +
                "\nРік випуску: " + Grad_year + "\n ";
        }
    }
}
