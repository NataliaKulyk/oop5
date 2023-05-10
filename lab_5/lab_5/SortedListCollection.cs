using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5
{
    class SortedListCollection
    {
        SortedList sortedlist = new SortedList();
        int count = 0;
        public void addVehicles(Boolean rb1, Boolean rb2, Boolean rb3, int price, int speed, int grad_year, int count, string prt,int count_pass)
        {
            if (rb2)
            {
                sortedlist.Add(this.count,new Ship(price, speed, grad_year, prt, count));
                this.count++;
            }
            if (rb1)
            {
                sortedlist.Add(this.count,new Plain(price, speed, grad_year, count, count_pass));
                this.count++;
            }
            if (rb3)
            {
                sortedlist.Add(this.count, new Car(price, speed, grad_year));
                this.count++;
            }
        }
        public string getVehicles()
        {
            string str = "";
            for (int i = 0; i < sortedlist.Count; i++)
            {
                str += sortedlist[i].ToString() + " ,\n";
            }
            
            return str;
        }
        public string getById(int id)
        {
            string str = "";

            str=sortedlist[id].ToString();

            return str;
        }
    }
}
