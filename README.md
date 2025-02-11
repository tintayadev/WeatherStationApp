
# Weather Station App

This is a C# Console Application that demonstrates:

- Events and Delegates
- Multicast Delegates
- Anonymous Methods
- Event Handling in C#

## 🚀 Getting Started

### Prerequisites
- .NET SDK installed
- Visual Studio or VS Code

### 🔧 Setup

1. Build the project:
    ```sh
    dotnet build
    ```
2. Run the project:
    ```sh
    dotnet run
    ```


## ** Topics Covered in This Project**
This project was designed to **practice and understand key C# concepts** related to **delegates, events, and event handling**. Below is a summary of the topics implemented:

### ** 1. Delegates**
A **delegate** is a type that holds a reference to a method. It allows methods to be passed as parameters.
- **Example Used:**
  ```csharp
  public delegate void WeatherUpdateHandler(object sender, WeatherEventArgs e);
  ```
- **Why?** We used delegates to define event handlers for weather updates.



### ** 2. Events**
An **event** is a special delegate that allows a class to notify subscribers when something happens.
- **Example Used:**
  ```csharp
  public event EventHandler<WeatherEventArgs> WeatherUpdated;
  ```
- **Why?** The `WeatherStation` triggers an event when weather updates occur, and multiple classes (subscribers) listen for changes.

---

### ** 3. Event Args (`EventArgs` Class)**
An **EventArgs class** is used to pass **custom data** when raising an event.
- **Example Used:**
  ```csharp
  public class WeatherEventArgs : EventArgs
  {
      public string WeatherCondition { get; }
      public double Temperature { get; }

      public WeatherEventArgs(string condition, double temperature)
      {
          WeatherCondition = condition;
          Temperature = temperature;
      }
  }
  ```
- **Why?** This allows us to include **weather details** in each event notification.



### ** 4. Multicast Delegates**
A **multicast delegate** allows **multiple methods to be called** when an event is triggered.
- **Example Used:**
  ```csharp
  station.WeatherUpdated += LogWeather;
  station.WeatherUpdated += NotifyMobileApp;
  ```
- **Why?** Our event system notifies multiple subscribers (ConsoleLogger, MobileApp, Lambda Expression).



### ** 5. Anonymous Methods**
An **anonymous method** is an unnamed function assigned to a delegate.
- **Example Used:**
  ```csharp
  station.WeatherUpdated += delegate(object sender, WeatherEventArgs e) 
  {
      Console.WriteLine($"[MobileApp] Weather Alert! {e.WeatherCondition}, {e.Temperature}°C");
  };
  ```
- **Why?** This allowed us to **handle events inline**, without needing separate named methods.



### ** 6. Lambda Expressions**
A **lambda expression** is a short way to define an anonymous function.
- **Example Used:**
  ```csharp
  station.WeatherUpdated += (sender, e) => 
      Console.WriteLine($"[Lambda] Quick Update: {e.WeatherCondition}, {e.Temperature}°C");
  ```
- **Why?** It makes the **event subscription cleaner and more readable**.


### ** 7. Delegate Inference (`+=` Operator)**
Delegate inference allows us to **attach methods to an event using `+=`**.
- **Example Used:**
  ```csharp
  station.WeatherUpdated += LogWeather;
  ```
- **Why?** This makes it easy to **attach event handlers dynamically**.


## ** Key Takeaways**
✅ **Events & Delegates** allow us to build **flexible, event-driven applications**.  
✅ **Multicast Delegates** allow multiple methods to respond to an event.  
✅ **Anonymous Methods & Lambda Expressions** make code **cleaner and more concise**.  
✅ **EventArgs** help **pass custom data** when raising an event.  

