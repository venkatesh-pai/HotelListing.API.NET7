﻿namespace HotelListing.API.Data
{
    public class Country
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public virtual IList<Hotel> Hotels { get; set; }
    }
}
