using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_06
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Initialize the class
            ProcessBusinessLogic bl = new ProcessBusinessLogic();

            // Subscribe to the event
            bl.ProcessCompleted += Bl_ProcessCompleted;

            // Start the process
            bl.StartProcess();
            Console.ReadLine();
        }
        // Event handler method
        static void Bl_ProcessCompleted()
        {
            Console.WriteLine("Method Invoked");
        }
    }
}
