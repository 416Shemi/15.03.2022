using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18.Model
{
    class Veapon
    {
        public int BulledCapacity;
        public int NumberBulletsin;
        public int SecondsCombing;
        public string AtisMode;
        public Veapon(int bulledCapacity, int numberBulletsin, int secondsCombing , string mode)
        {
            this.BulledCapacity = bulledCapacity ;
            this.NumberBulletsin = numberBulletsin;
            this.SecondsCombing = secondsCombing;
            this.AtisMode = mode;
        }
        public void Shoot(int n)
        {
            if(n  > 0)
            {
                n = n - 1;
            }
            else
            {
                Console.WriteLine("Mermi yoxdur");
            }
        }
        public int Fire(int s)
        {
            while (NumberBulletsin >= 0)
            {
                int cont;
                if (n=0)
                {
                    cont= s;
                }

            }
            retur 0;

        }
        public int GetRemainBulletCount(int m)
        {
            int k = 0;
            if (NumberBulletsin < BulledCapacity)
            {
                BulledCapacity = NumberBulletsin + k;
            }
            return k;
        }
        public void Reload(string main)
        {
            if(NumberBulletsin< BulledCapacity)
            {
                int k = 0;
                BulledCapacity = NumberBulletsin + k;
            }
            else
            {
                BulledCapacity = NumberBulletsin;
            }
            Console.WriteLine("Darag dolduruldu");
        }
        public void ChangeFireMode(string mode)
        {

        }
        public void ChangeFireMode(string main)
        {
            
        }
        
    }
}
