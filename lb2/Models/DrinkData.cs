using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace lb2.Models
{
    public enum DrinkType
    {
        Tea,
        Coffe,
        Juice,
        Alcohol
    }
    public class DrinkData
    {
        public DrinkType drinkType { get; set; }
        [Required(ErrorMessage = "Пожалуйства, введите молоко")]
        public int milk { get; set; }
        [Required(ErrorMessage = "Пожалуйста, введите сахар")]
        public int sugar { get; set; }

        public double getPrice()
        {
            double price = 0;
            switch (drinkType)
            {
                case DrinkType.Tea:
                    price += 10;
                    break;
                case DrinkType.Coffe:
                    price += 15;
                    break;
                case DrinkType.Juice:
                    price += 20;
                    break;
                case DrinkType.Alcohol:
                    price += 30;
                    break;
                default:
                    break;
            }
            price += 0.5 * milk;
            price += 0.2 * sugar;
            return price;
        }
    }
}