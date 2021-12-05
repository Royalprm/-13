using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Упражнение_13
{
   
  // Класс Building - базовый класс
  class Building
    {
        string address;
        double length; 
        double width;
        double height;

        // 2. Конструктор с 4 параметрами
        public Building(string _address, double _length, double _width, double _height)
        {
            address = _address;
            length = _length;
            width = _width;
            height = _height;
         }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public double Length
        {
            get { return length; }
            set { length = value; }
        }

        public double Width
        {
            get { return width; }
            set { width = value; }
        }
        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public void Print()
        {
            Console.WriteLine("address = {0}, length = {1:f2}, width = {2:f2}, height = = {3:f2}", address, length, width, height);
        }
    }

    // Класс, который наследует класс Building - добавляет этажность к зданию.
    sealed class MultiBuilding : Building
    {
        int floor;

        // 2. Конструктор с 5 параметрами.
        public MultiBuilding(string _address, double _length, double _width, double _height, int _floor) 
            : base(_address, _length, _width, _height)
        {
            floor = _floor;
        }

        // 3. Свойство доступа к полю floor
        public int Floor
        {
            get { return floor; }
            set { floor = value; }
        }

        // 4. Метод Print() - вызывает метод базового класса
        
        public new void Print()
        {
            base.Print(); // 
            Console.WriteLine("этаж = {0}", floor);
        }
    }
      
    class Program
    {
        static void Main(string[] args)
        {
            Building b1 = new Building("Адрес - ул. Ленина, 65", 60, 18, 15);

            b1.Print();

            MultiBuilding bg1 = new MultiBuilding("Адрес - ул. Ленина, 70", 60, 18, 15, 3);

            Console.WriteLine("-------------------");
            bg1.Print();

            Console.WriteLine();
            Console.Write("Для завершения нажмите любую клавишу на клавиатуре");
            Console.ReadKey();
        }
    }
}
     

