using System;
using System.Collections.Generic;

public class Person
{
    public int PersonID;
    public string FirstName;
    public string LastName;
    public int Age;
    public double MoneyOwned;
    public List<string> productsOwned = new List<string>();

    public void Introduce()
    {
        Console.WriteLine("My name is " + FirstName + " " + LastName);
    }

    public bool PayForProduct(double productCost)
    {
        if (MoneyOwned >= productCost)
        {
            MoneyOwned -= productCost;
            return true;
        } else
        {
            return false;
        }
    }

    public void moneyRemaining()
    {
        Console.WriteLine("Money Remaining: £{0}", MoneyOwned);
    }

    public void PurchasedProducts()
    {
        Console.WriteLine("Products Purchased Today:");
        foreach (var item in productsOwned)
        {
            Console.WriteLine(item);
        }
    }
}
