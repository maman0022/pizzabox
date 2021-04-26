﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Models.Sizes;
using PizzaBox.Domain.Models.Stores;
using PizzaBox.Client.Singletons;
using System.Text;
using PizzaBox.Storing;

namespace PizzaBox.Client
{
  /// <summary>
  /// 
  /// </summary>
  public class Program
  {
    private static readonly PizzaSingleton _pizzaSingleton = PizzaSingleton.Instance;
    private static readonly StoreSingleton _storeSingleton = StoreSingleton.Instance;
    private static readonly CrustSingleton _crustSingleton = CrustSingleton.Instance;
    private static readonly SizeSingleton _sizeSingleton = SizeSingleton.Instance;
    private static readonly ToppingSingleton _toppingSingleton = ToppingSingleton.Instance;
    private static readonly PizzaBoxContext _contextSingleton = ContextSingleton.Instance;
    private static List<Order> CustomerOrders = new List<Order>();

    /// <summary>
    /// 
    /// </summary>
    private static void Main()
    {
      Run(true);
    }

    /// <summary>
    /// 
    /// </summary>
    private static void Run(bool firstRun)
    {
      var order = new Order();

      if (firstRun)
      {
        Console.WriteLine("Welcome to PizzaBox");

        var customerName = GetCustomerName();
        order.Customer = new Customer(customerName);
      }

      else order.Customer = CustomerOrders[0].Customer;

      PrintStoreList();
      order.Store = SelectStore();

      PrintPizzaList();
      order.Pizza = SelectPizza();

      if (order.Pizza.Name == "Custom Pizza")
      {
        PrintToppingList(order);
      }

      PrintSizeList();
      order.Pizza.Size = SelectSize();

      PrintCrustList();
      order.Pizza.Crust = SelectCrust();

      PrintOrder(order);
      SaveOrderToDatabase(order);
      CustomerOrders.Add(order);

      AskOrderAgain();
    }

    private static string GetCustomerName()
    {
      Console.WriteLine("~~~~~~~~~~~~");
      Console.WriteLine("Please enter your name:");

      var input = Console.ReadLine();

      if (input.Trim().Length == 0)
      {
        Console.WriteLine("Your name cannot be empty");
        return GetCustomerName();
      }

      return input;
    }
    private static void PrintStoreList()
    {
      Console.WriteLine("~~~~~~~~~~~~");

      var index = 0;

      foreach (var item in _storeSingleton.Stores)
      {
        Console.WriteLine($"{++index} - {item}");
      }

      Console.WriteLine("Please enter the store number:");
    }
    private static AStore SelectStore()
    {
      var valid = int.TryParse(Console.ReadLine(), out int input);

      if (!valid || input > _storeSingleton.Stores.Count || input < 1)
      {
        Console.WriteLine($"Please enter a number from 1 to {_storeSingleton.Stores.Count}");
        return SelectStore();
      }

      return _storeSingleton.Stores[input - 1];
    }
    private static void PrintPizzaList()
    {
      Console.WriteLine("~~~~~~~~~~~~");
      var index = 0;

      foreach (var item in _pizzaSingleton.Pizzas)
      {
        Console.WriteLine($"{++index} - {item.Name}");
      }

      Console.WriteLine($"Please select a specialty pizza or a custom pizza.");
    }
    private static APizza SelectPizza()
    {
      var valid = int.TryParse(Console.ReadLine(), out int input);

      if (!valid || input > _pizzaSingleton.Pizzas.Count || input < 1)
      {
        Console.WriteLine($"Please enter a number from 1 to {_pizzaSingleton.Pizzas.Count}");
        return SelectPizza();
      }

      return _pizzaSingleton.Pizzas[input - 1];
    }
    private static void PrintToppingList(Order order)
    {
      Console.WriteLine("~~~~~~~~~~~~");

      var index = 0;

      foreach (var item in _toppingSingleton.Toppings)
      {
        Console.WriteLine($"{++index} - {item} = ${item.Price}");
      }

      Console.WriteLine("Please select your toppings:");
      Console.WriteLine("Enter the number for each topping in one line:");

      SelectToppings(order);
    }
    private static void SelectToppings(Order order)
    {
      var response = Console.ReadLine();
      var hashSet = new HashSet<char>();
      var toppingsList = new List<ATopping>();

      foreach (char character in response.ToCharArray())
      {
        var valid = int.TryParse(character.ToString(), out int input);

        var unique = hashSet.Add(character);

        if (!valid || input > _toppingSingleton.Toppings.Count || input < 1 || !unique)
        {
          Console.WriteLine($"Please enter numbers from 1 to {_toppingSingleton.Toppings.Count} without duplicating");
          SelectToppings(order);
          return;
        }

        toppingsList.Add(_toppingSingleton.Toppings[input - 1]);
      }

      order.Pizza.Toppings.AddRange(toppingsList);
    }
    private static void PrintSizeList()
    {
      Console.WriteLine("~~~~~~~~~~~~");

      var index = 0;

      foreach (var item in _sizeSingleton.Sizes)
      {
        Console.WriteLine($"{++index} - {item.Name} = ${item.Price}");
      }

      Console.WriteLine($"Please select a pizza size");
    }
    private static ASize SelectSize()
    {
      var valid = int.TryParse(Console.ReadLine(), out int input);

      if (!valid || input > _sizeSingleton.Sizes.Count || input < 1)
      {
        Console.WriteLine($"Please enter a number from 1 to {_sizeSingleton.Sizes.Count}");
        return SelectSize();
      }

      return _sizeSingleton.Sizes[input - 1];
    }
    private static void PrintCrustList()
    {
      Console.WriteLine("~~~~~~~~~~~~");

      var index = 0;

      foreach (var item in _crustSingleton.Crusts)
      {
        Console.WriteLine($"{++index} - {item.Name} = ${item.Price}");
      }

      Console.WriteLine($"Please select a crust");
    }
    private static ACrust SelectCrust()
    {
      var valid = int.TryParse(Console.ReadLine(), out int input);

      if (!valid || input > _crustSingleton.Crusts.Count || input < 1)
      {
        Console.WriteLine($"Please enter a number from 1 to {_crustSingleton.Crusts.Count}");
        return SelectCrust();
      }

      return _crustSingleton.Crusts[input - 1];
    }
    private static string GenerateToppingsList(Order order)
    {
      var stringBuilder = new StringBuilder();
      var toppingsString = "Toppings:";
      foreach (var topping in order.Pizza.Toppings)
      {
        toppingsString += $" {topping},";
      }
      return toppingsString.TrimEnd(',');
    }
    private static void PrintOrder(Order order)
    {
      Console.WriteLine("~~~~~~~~~~~~");
      Console.WriteLine($"{order.Customer}, Your order is as follows:");
      Console.WriteLine($"{order.Store}");
      Console.WriteLine($"{order.Pizza.Size}, {order.Pizza.Crust} Crust, {order.Pizza.Name}");
      Console.WriteLine(GenerateToppingsList(order));
      Console.WriteLine("~~~~~~~~~~~~");
      Console.WriteLine($"Your total is ${order.TotalCost}");
    }
    private static void SaveOrderToDatabase(Order order)
    {
      order.Pizza.Size = _contextSingleton.Sizes.FirstOrDefault(s => s.Name == order.Pizza.Size.Name);
      order.Pizza.Crust = _contextSingleton.Crusts.FirstOrDefault(s => s.Name == order.Pizza.Crust.Name);
      order.Store = _contextSingleton.Stores.FirstOrDefault(s => s.Name == order.Store.Name);
      _contextSingleton.Order.Add(order);
      _contextSingleton.SaveChanges();
    }
    private static void AskOrderAgain()
    {
      Console.WriteLine("~~~~~~~~~~~~");
      Console.WriteLine("Enter 1 to place another order.");
      Console.WriteLine("Enter 2 to view your orders.");

      var valid = int.TryParse(Console.ReadLine(), out int input);

      if (valid && input == 1)
      {
        Run(false);
      }

      if (valid && input == 2)
      {
        decimal total = 0.00m;
        foreach (var order in CustomerOrders)
        {
          Console.WriteLine("------------");
          Console.WriteLine($"{order.Pizza.Size}, {order.Pizza.Crust} Crust, {order.Pizza.Name}");
          Console.WriteLine(GenerateToppingsList(order));
          Console.WriteLine($"${order.TotalCost}");
          total += order.TotalCost;
        }
        Console.WriteLine("------------");
        Console.WriteLine($"Grand Total: ${total}");
        AskOrderAgain();
      }
      else AskOrderAgain();
    }
  }
}
