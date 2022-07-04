using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDB =new List<PizzasModel>()
        {
            new PizzasModel(){
                ImageTitle="Margerita", 
                PizzaName ="Margerita", 
                BasePrice=2, 
                TomatoSauce=true, 
                Cheese=true, 
                FinalPrice=2},
            new PizzasModel(){
                ImageTitle="Bolognese",
                PizzaName ="Bolognese",
                BasePrice=5,
                Pineapple=true,
                TomatoSauce=true,
                Cheese=true,
                FinalPrice=5},
            new PizzasModel(){
                ImageTitle="Carbonara",
                PizzaName ="Carbonara",
                BasePrice=2,
                Peperoni=true,
                Cheese=true,
                FinalPrice=3},
            new PizzasModel(){
                ImageTitle="Hawaiian",
                PizzaName ="Hawaiian",
                BasePrice=4,
                Mushroom=true,
                Cheese=true,
                FinalPrice=7},
            new PizzasModel(){
                ImageTitle="MeatFeast",
                PizzaName ="MeatFeast",
                BasePrice=9,
                TomatoSauce=true,
                Beef=true,
                FinalPrice=1},
            new PizzasModel(){
                ImageTitle="Carbonara",
                PizzaName ="Carbonara",
                BasePrice=3,
                Pineapple=true,
                TomatoSauce=true,
                Cheese=true,
                FinalPrice=6},
            new PizzasModel(){
                ImageTitle="Mushroom",
                PizzaName ="Mushroom",
                BasePrice=7,
                Tuna=true,
                TomatoSauce=true,
                Cheese=true,
                FinalPrice=2},
            new PizzasModel(){
                ImageTitle="Pepperoni",
                PizzaName ="Pepperoni",
                BasePrice=6,
                TomatoSauce=true,
                Tuna=true,
                Cheese=true,
                FinalPrice=7},
            new PizzasModel(){
                ImageTitle="Seafood",
                PizzaName ="Seafood",
                BasePrice=3,
                TomatoSauce=true,
                Cheese=true,
                Ham=true,
                FinalPrice=4}
        };
        public void OnGet()
        {
        }
    }
}
