using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersioningTask2
{

    abstract class BaseClass
    {
        protected abstract void Read();
        protected abstract void Write();

        public void ReadWrite()
        {
            Read();
            Write();
        }
    }

    class DerivedClassTXT : BaseClass
    {
        protected override void Read()
        {
            Console.WriteLine("Чтение из файла TXT");
        }
        protected override void Write()
        {
            Console.WriteLine("Запись в файл TXT");
        }
    }

    class DerivedClassXML : BaseClass
    {
        protected override void Read()
        {
            Console.WriteLine("Чтение из файла XML");
        }

        protected override void Write()
        {
            Console.WriteLine("Запись в файл XML");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<BaseClass> list = new List<BaseClass>() { new DerivedClassTXT(),new DerivedClassXML()};
            foreach (BaseClass c in list)
                c.ReadWrite();
            Console.ReadLine();
        }
    }
}
