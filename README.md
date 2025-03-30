# Event Handling in C#

This project demonstrates how to use events in C# with a `ProcessBusinessLogic` class that triggers an event when a process is completed.

## 📌 Concepts Covered
- Declaring and invoking events
- Using `EventHandler` delegates
- Subscribing to and handling events

## 📜 Code Explanation

### 1️⃣ Class: `ProcessBusinessLogic`
- Declares an event `ProcessCompleted` using the built-in `EventHandler` delegate.
- Defines a method `StartProcess()` that prints `"Process Started!"` and triggers the event.
- Implements `OnProcessCompleted()` to check if the event has subscribers before invoking it.

### 2️⃣ Event Subscription & Handling
- The `Main` method initializes an instance of `ProcessBusinessLogic`.
- The event handler method `Bl_ProcessCompleted` is registered with `ProcessCompleted`.
- When `StartProcess()` is called, it triggers the event, which executes `Bl_ProcessCompleted`.

## 💻 Code Implementation
```csharp
using System;

class ProcessBusinessLogic
{
    // Declare an event using EventHandler
    public event EventHandler ProcessCompleted;

    public void StartProcess()
    {
        Console.WriteLine("Process Started!");
        // Simulating some process
        OnProcessCompleted();
    }

    protected virtual void OnProcessCompleted()
    {
        // Invoke event if there are subscribers
        ProcessCompleted?.Invoke(this, EventArgs.Empty);
    }
}

class Program
{
    static void Main()
    {
        // Initialize the process class
        ProcessBusinessLogic process = new ProcessBusinessLogic();

        // Subscribe event handler
        process.ProcessCompleted += Bl_ProcessCompleted;

        // Start process
        process.StartProcess();
    }

    // Event handler method
    static void Bl_ProcessCompleted(object sender, EventArgs e)
    {
        Console.WriteLine("Method Invoked");
    }
}
```
## Below is the SS of the final output 
![image](https://github.com/user-attachments/assets/bc3ed4d7-437a-44a1-899c-b23fba5b0145)
