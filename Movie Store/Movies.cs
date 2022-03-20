using System;
using System.Collections.Generic;

    public class Movies
    {
        public int movieID;
        public string movieName;
        public string movieDescription;
        public string movieGenre;
        public int ageRating;
        public double movieCost;
        public int movieStock;

        public void GetMovie()
        {
            Console.WriteLine("ID: {0} Title: {1} Genre: {2} Description: {3} Cost: {4} In Stock {5}", movieID, movieName, movieGenre, movieDescription, movieCost, movieStock);
        }

        public void BuyMovie(int quantity, Person buyer)
        {
            if (ageRating <= buyer.Age)
            {
                movieStock -= quantity;
                double totalCost = movieCost * quantity;
                if (movieCost > 0 && buyer.PayForProduct(totalCost))
                {
                    Console.WriteLine("Title: {0} purchased. Total Cost: £{1}. {2} movies left in stock", movieName, totalCost, movieStock);
                    buyer.productsOwned.Add("Product: " + movieName + " Quantity: " + quantity);
                }
                else if (buyer.PayForProduct(totalCost) == false)
                {
                    int canPurchase = Convert.ToInt32(buyer.MoneyOwned / movieCost);
                    Console.WriteLine("You do not have enough money to purchase this product. You can purchase {0} of {1}.", canPurchase, movieName);
                    Console.WriteLine("How many would you like to purchase?");
                    int.TryParse(Console.ReadLine(), out int newQuantity);
                    BuyMovie(newQuantity, buyer);
                }
                else if (movieCost == 0)
                {
                    Console.WriteLine("Title: {0} purchased. {1} left in stock", movieName, movieStock);
                    buyer.productsOwned.Add("Product: " + movieName + " Quantity: " + quantity);
                }
            }
            else
            {
                Console.WriteLine("Sorry, you are too young to purchase this title.");
            }
            
            
        }
    }
