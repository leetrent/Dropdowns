namespace Dropdowns.Models
{
    public class Corporation
    {
        public int CorporationID        { get; set; }
        public string CorporationName   { get; set; }
        public int ContinentID          { get; set; }
        public Continent Continent      { get; set; }
        public int CountryID            {get; set;}
        public Country Country          { get; set; }

    }
}