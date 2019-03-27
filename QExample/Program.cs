using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QExample
{
    //Example with .NET Generics applied on a queue of strings
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Create queue
                Queue<string> qstr = new Queue<string>();
                qstr.Enqueue("Zealand");
                qstr.Enqueue("RUC");
                qstr.Enqueue("ZBC");

                //Dequeue first element
                string dqs = qstr.Dequeue();
                Console.WriteLine("Dequeuing: {0}", dqs);

                //Peek next element in queue
                Console.WriteLine("Next in Q is: {0}", qstr.Peek());

                //Write queue to console
                foreach (string s in qstr)
                {
                    Console.WriteLine(s);
                }
            }

            catch
            {

            }
            Console.ReadLine();
        }
    }
}
