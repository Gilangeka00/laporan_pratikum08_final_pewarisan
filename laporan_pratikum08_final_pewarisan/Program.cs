using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanjutan_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Person1 = new Person();
            Person1.Name = "Meysi";
            Person1.Age = 19;
            Person1.InfoPerson();

            Karyawan Karyawan1 = new Karyawan();
            Karyawan1.Name = "Gilang";
            Karyawan1.Age = 18;
            Karyawan1.InfoPerson();
            Karyawan1.InfoPerson("Dosen", "AA2002200400123AC0XB100");

            Console.ReadLine();
        }
    }
}