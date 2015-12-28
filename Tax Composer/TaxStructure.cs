using System.Collections.Generic;

namespace Tax_Composer
{
    public class Specie
    {
        public bool custom { get; set; }       // true || false
        public int? id { get; set; }           // int || null // null if custom
        public string name { get; set; }       // string for visualization only

        public Specie(bool custom, int? id, string name)
        {
            this.custom = custom;
            this.id = id;
            this.name = name;
        }

        public static Specie toSpecie(object specieObject)
        {
            Specie specie = (Specie)specieObject;
            return specie;
        }
    }
}
