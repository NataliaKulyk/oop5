using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5
{
    class SortedGenericCol
    {
        SortedList<int,Car> cars = new SortedList<int,Car>();
        SortedList<int, Plain> plains = new SortedList<int, Plain>();
        SortedList<int, Ship> ships = new SortedList<int, Ship>();
        
        int count_car = 0;
        int count_ship = 0;
        int count_plain = 0;
        public void addVehicles(Boolean rb1, Boolean rb2, Boolean rb3, int price, int speed, int grad_year, int count, string prt, int count_pass)
        {
            if (rb1)
            {
                plains.Add(this.count_plain, new Plain(price, speed, grad_year, count, count_pass));
                this.count_plain++;
            }
            if (rb2)
            {
                ships.Add(this.count_ship, new Ship(price, speed, grad_year, prt, count));
                this.count_ship++;
            }
            if (rb3)
            {
                cars.Add(this.count_car, new Car(price, speed, grad_year));
                this.count_car++;
            }
        }
        public string getVehicles()
        {
            string str = "";
            for (int i = 0; i < cars.Count; i++)
            {
                str += cars[i].ToString() + " ,\n";
            }
            for (int i = 0; i < plains.Count; i++)
            {
                str += plains[i].ToString() + " ,\n";
            }
            for (int i = 0; i < ships.Count; i++)
            {
                str += ships[i].ToString() + " ,\n";
            }
            return str;
        }
        public string getById(Boolean rb1, Boolean rb2, Boolean rb3, int id)
        {
            string str = "";
            if (rb1)
            {
                str = plains[id].ToString();
            }
            if (rb2)
            {
                str = ships[id].ToString();
            }
            if (rb3)
            {
                str = cars[id].ToString();
            }
            return str;
        }
    }
}
