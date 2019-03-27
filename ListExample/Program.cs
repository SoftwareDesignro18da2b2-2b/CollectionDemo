using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace ListExample
{
    class Program
    {
        //Example with .NET Generics applied on an integer list

        //Set to true, if this exception type should be handled locally 
        const bool HandleNullReferenceExceptionLocally = false;

        //The best meaning of DoSomething is to demonstrate exception handling
        static void DoSomething()
        {
            //Print integer ranges to console for example
            Console.WriteLine("int min: {0}, int max: {1}", int.MinValue, int.MaxValue);
            Console.WriteLine("uint min: {0}, uint max: {1}", uint.MinValue, uint.MaxValue);
            
            //Correct list creation statement
            List<int> lst = new List<int>();

            //Wrong list creation statement - introduced to demonstrate exceptions
            //List<int> lst = null;

            //We need a file stream
            FileStream fs = null;
            
            try
            {
                //Open file stream - in order to demonstrate 'finally'
                fs = File.Open("C:\\Windows\\write.exe", FileMode.Open, FileAccess.Read, FileShare.None);

                //Add elements to list
                lst.Add(1);
                lst.Add(43);
                lst.Add(-1);

                //Print list to console
                foreach(int i in lst)
                {
                    Console.WriteLine("List item: {0}", i);
                }


            }

            catch (System.NullReferenceException e)
            {
                if (HandleNullReferenceExceptionLocally)
                {
                    //Handle it locally
                    Console.WriteLine("Caught an error: {0}", e.Message);
                }
                else
                {
                    //Throw it to a higher level
                    throw e;
                }
            }

            catch (Exception e)
            {
                //Handle it locally
                Console.WriteLine("Caught an error: {0}", e.Message);
            }

            finally
            {
                //Always dispose file stream on finish
                if (fs != null)
                {
                    fs.Dispose();
                }
            }
        }

        static void Main(string[] args)
        {
            //Try to DoSomeThing
            try
            {
                DoSomething();
            }
            catch (Exception e)
            {
                //Catch any unhandled exceptions here
                Console.WriteLine("Caught some exception: {0}", e.Message);
            }
           
            Console.ReadLine();

        }
    }
}
