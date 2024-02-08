using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestGame.Classes
{
    [BsonIgnoreExtraElements]
    public class UnitType
    {
        
        public UnitType (int minDexterity, int maxDexterity, int minInteligence, int maxInteligence, int minStrength, int maxStrength, int minVitality, int maxVitality, string name, string unitTypes)
        {
            MinDexterity = minDexterity;
            MaxDexterity = maxDexterity;
            MinInteligence = minInteligence;
            MaxInteligence = maxInteligence;
            MaxStrength = maxStrength;
            MinStrength = minStrength;
           MinVitality = minVitality;
            MaxVitality = maxVitality;
            Name = name;
            UnitTypes = unitTypes;  


        }
        [BsonIgnore]
        public ObjectId _id;
        public string UnitTypes { get; set; }
        public string Name { get; set; }    
        public int MinDexterity { get; set; }
        public int MaxDexterity { get; set; }

        public int MinInteligence { get; set; }
        public int MaxInteligence { get; set; }
        public int MinStrength { get; set; }
        public int MaxStrength { get; set; }
        public int MinVitality { get; set; }
        public int MaxVitality { get; set; }

    }
}
