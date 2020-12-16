using System;
using System.Collections.Generic;
namespace TravelDiary.Models
{
  public class Place
  {
    public string CityName {get;set;}
    public string Description {get;set;}

    // public Image Photo {get;set;}
    // public Image image {get;set;}
    public int Id {get;}
    public static List<Place> _instances = new List<Place>{};
    public Place(string cityName)
    {
      CityName = cityName;
      _instances.Add(this);
      Id = _instances.Count;

    }

    public Place(string cityName, string description)
    : this(cityName)
    {
      Description = description;

    }
    // public Place(string cityName, string description, Image photo)
    // : this(cityName, description)
    // {
    //   Photo = photo;
    // }

    public static List<Place> GetAll()
    {
      return _instances;
    }
    public static Place Find(int searchId)
    {
      return _instances[searchId - 1];
    }
  }
}