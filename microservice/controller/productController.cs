using System.Linq;
using Microsoft.AspNetCore.Mvc;
using microservice.models;

namespace microservice.controller
{
    public class productController
    {
        public productController()
        {
        }

        public async Task<IResult> GetProducts(){
            
            List<product> allprods = new List<product>();
            allprods.Add(new product{Id=1,Name="one",Prix=10,Prixachat=5});
            allprods.Add(new product{Id=2,Name="two",Prix=8,Prixachat=15});
            allprods.Add(new product{Id=3,Name="three",Prix=20,Prixachat=15});
            
            return Results.Ok(allprods.ToList());
        }
    }
}