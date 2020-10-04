using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{

    
    //public sealed class Singleton
    //{
    //    private static int count = 0;
    //    private static Singleton instance = null;
    //    public static Singleton GetInstance { get { if (instance == null) { instance = new Singleton(); } return instance; } }

    //    public Singleton()
    //    {
    //        count++;
    //        Console.WriteLine("Count : " + count);
    //    }

    //    public void PrientDetals()
    //    {
    //        Console.WriteLine("I am from Singleton class");
    //    }

    //}
    //public class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Singleton sing = Singleton.GetInstance;
    //        sing.PrientDetals();
    //        Singleton sing2 = Singleton.GetInstance;
    //        sing2.PrientDetals();
    //        Singleton sing3 = Singleton.GetInstance;
    //        Singleton sing4 = Singleton.GetInstance;
    //        Console.Read();
    //    }
    //}
}
