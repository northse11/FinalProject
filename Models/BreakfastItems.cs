using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class BreakfastItems
    {
        [Key]
        public int? breakfastID { get; set; }
        public string breakfastItemName { get; set; }
        public string breakfastItemDescription { get; set; }
        public int breakfastItemPrice { get; set; }

        public int breakfastItemQuantity { get; set; }
        public DateTime breakfastTime { get; set; }

        public BreakfastItems() { }
        public BreakfastItems(int? BreakfastID, string BreakfastItemName, string BreakfastItemDescription, int BreakfastItemPrice, int BreakfastItemQuantity, DateTime BreakfastTime)
        {
            breakfastID = BreakfastID;
            breakfastItemName = BreakfastItemName;
            breakfastItemDescription = BreakfastItemDescription;
            breakfastItemPrice = BreakfastItemPrice;
            breakfastItemQuantity = BreakfastItemQuantity;
            breakfastTime = BreakfastTime;

        }
    }
}
