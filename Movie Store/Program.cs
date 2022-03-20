using System;
using System.Collections.Generic;

namespace MovieStore
{

    class Program
    {
        static void Main(string[] args)
        {
            var personOne = new Person()
            {
                PersonID = 1,
                FirstName = "Kennedy",
                LastName = "Scrace",
                Age = 26,
                MoneyOwned = 20.00
            };

            var fresh = new Movies()
            {
                movieID = 1,
                movieName = "Fresh",
                movieDescription = "Sebastian Stan plays a weirdo",
                movieGenre = "Thriller",
                ageRating = 24,
                movieCost = 0.00,
                movieStock = 10
            };

            var wolfOfWallStreet = new Movies()
            {
                movieID = 2,
                movieName = "Wolf of Wall Street",
                movieDescription = "Leonardo Di Capricorn is a slut",
                movieGenre = "Comedy",
                ageRating = 18,
                movieCost = 10.00,
                movieStock = 50
            };

            fresh.BuyMovie(5, personOne);
            wolfOfWallStreet.BuyMovie(5, personOne);
            personOne.moneyRemaining();
            personOne.PurchasedProducts();
           
        }
    }
}
