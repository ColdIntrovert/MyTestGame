using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyTestGame.Pages;
using MongoDB.Driver;
using MyTestGame.Classes;

namespace MyTestGame.MongoDB
{
    public class CRUD
    {
        public static UnitType GetUnit(string typeName)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("MyTestGame");
            var collection = database.GetCollection<UnitType>("UnitType");
            var unit = collection.Find(x => x.UnitTypes == typeName).FirstOrDefault();
            if (unit == null)
            {
                return null;
            }
            else
            {
                return unit;
            }

        }

        public static void CreateUser(UnitType unitType)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("MyTestGame");
            var collection = database.GetCollection<UnitType>("UnitTypeCollection");
            if (GetUnit(unitType.Name) == null)
            {
                collection.InsertOne(unitType);
            }
        }
        public static List<UnitType> GetBaseUsers()
        {
            List<UnitType> unitList = new List<UnitType>()
            {
                GetUnit("UserWarrior")
            };
            return unitList;
        }
    }   

            
}
