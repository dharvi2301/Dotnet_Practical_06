using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_06
{
    // Define a delegate for the event
    public delegate void ProcessCompletedHandler();
    public class ProcessBusinessLogic
    {
        // Declare the event using the delegate
        public event ProcessCompletedHandler ProcessCompleted;

        public void StartProcess()
        {
            Console.WriteLine("Process Started!");

            // Simulate some work
            System.Threading.Thread.Sleep(2000);

            // Invoke the event
            OnProcessCompleted();
        }

        protected virtual void OnProcessCompleted()
        {
            // Check if there are any subscribers, then invoke the event
            ProcessCompleted?.Invoke();
        }
    }
}
