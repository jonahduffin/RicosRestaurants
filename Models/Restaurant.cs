using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace RicosRestaurants.Models
{
    public class Restaurant
    {
        public int rank { get; }
        public string restaurantName { get; set; }
        public string? favoriteDish { get; set; }
        public string address { get; set; }
        public string? restaurantPhone { get; set; }
        public string? websiteLink { get; set; } = "Coming soon.";
        public Restaurant(int newRank)
        {
            rank = newRank;
        }
        

        public static Restaurant[] GetRestaurants()
        {
            Restaurant r1 = new Restaurant(1)
            {
                restaurantName = "Wingstop",
                favoriteDish = "Hickory Smoked BBQ 3 Piece Tenders w/ Bleu Cheese",
                address = "1826 W 9000 S, West Jordan, UT 84088",
                restaurantPhone = "(801) 561-9464",
                websiteLink = "https://www.wingstop.com/"
            };
            Restaurant r2 = new Restaurant(2)
            {
                restaurantName = "Jimmy Johns",
                favoriteDish = "#8, Extra Tomatoes, Hot Peppers, Jimmy Mustard",
                address = "2308 N University Pkwy, Provo, UT 846045",
                restaurantPhone = "(801) 410-4355",
                websiteLink = "https://www.jimmyjohns.com/"
            };
            Restaurant r3 = new Restaurant(3)
            {
                restaurantName = "Villaggio Pizzeria",
                favoriteDish = "Jumbo House Slice of pizza",
                address = "3144 S State St suite 1, South Salt Lake, UT 84115",
                restaurantPhone = "(801) 410-4355",
                websiteLink = "https://www.villaggio-slc.com"
            };
            Restaurant r4 = new Restaurant(4)
            {
                restaurantName = "Din Tai Fung",
                favoriteDish = "Pork Soup Dumplings",
                address = "177 Caruso Ave, Glendale, CA 91210",
                restaurantPhone = "(818) 551-5561",
                websiteLink = "https://dintaifungusa.com/"
            };
            Restaurant r5 = new Restaurant(5)
            {
                restaurantName = "Cafe Rio",
                favoriteDish = "Pork Salad",
                address = "2244 N University Pkwy, Provo, UT 84604",
                restaurantPhone = "(801) 375-5133",
                websiteLink = "https://www.caferio.com/"
            };



            return new Restaurant[] { r1, r2, r3, r4, r5 };
        }
    }
}
