using System;

namespace Lab_13_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Building MyBuilding = new Building();
            MultiBuilding MyBuilding = new MultiBuilding();
            MyBuilding.Print();
        }

        public class Building
        {
            private protected string pAddress;
            private protected double pLength;
            private protected double pWidth;
            private protected double pHeight;

            public Building()
            {
                Console.WriteLine("Введите параметры здания:");
                Console.WriteLine("адрес:");
                pAddress = Console.ReadLine();
                Console.WriteLine("длина:");
                pLength = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("ширина:");
                pWidth = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("высота:");
                pHeight = Convert.ToDouble(Console.ReadLine());
            }
            public void Print()
            {
                Console.WriteLine("\nПараметры здания" + "\n-адрес: " + pAddress + "\n-длина: " + pLength + "\n-ширина: " + pWidth + "\n-высота: " + pHeight);
            }

            public string Address
            {
                get
                {
                    return pAddress;
                }

                set
                {
                    pAddress = Address;
                }
            }

            public double Length
            {
                get
                {
                    return pLength;
                }

                set
                {
                    pLength = Length;
                }
            }

            public double Width
            {
                get
                {
                    return pWidth;
                }

                set
                {
                    pWidth = Width;
                }
            }

            public double Height
            {
                get
                {
                    return pHeight;
                }

                set
                {
                    pHeight = Height;
                }
            }

        }

        sealed class MultiBuilding : Building
        {
            private int pFloorsNumber;

            public MultiBuilding()
            {
                Console.WriteLine("этажность:");
                pFloorsNumber = Convert.ToInt16(Console.ReadLine());
            }

            public void Print()
            {
                base.Print();
                Console.WriteLine("-этажность: " + pFloorsNumber);
            }

            public int FloorsNumber
            {
                get
                {
                    return pFloorsNumber;
                }

                set
                {
                    pFloorsNumber = FloorsNumber;
                }
            }
        }
    }
}
