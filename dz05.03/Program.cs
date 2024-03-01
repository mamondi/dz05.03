using System;

namespace dz05._03
{
    class City
    {
        public string cityName { get; set; }
        public string countryName { get; set; }
        public int population { get; set; }
        public int areaCode { get; set; }
        public string district { get; set; }
        public string[] districts { get; set; }

        public void SetData(string cityName, string countryName, int population, int areaCode, string district)
        {
            this.cityName = cityName;
            this.countryName = countryName;
            this.population = population;
            this.areaCode = areaCode;
            this.district = district;
        }

        public void AddDistrict(string newDistrict)
        {
            if (districts == null)
            {
                districts = new string[] { newDistrict };
            }
            else
            {
                string[] temp = new string[districts.Length + 1];
                for (int i = 0; i < districts.Length; i++)
                {
                    temp[i] = districts[i];
                }
                temp[temp.Length - 1] = newDistrict;
                districts = temp;
            }
        }

        public void RemoveDistrict(string removeDistrict)
        {
            if (districts != null)
            {
                int index = Array.IndexOf(districts, removeDistrict);
                if (index != -1)
                {
                    string[] temp = new string[districts.Length - 1];
                    for (int i = 0, j = 0; i < districts.Length; i++)
                    {
                        if (i != index)
                        {
                            temp[j++] = districts[i];
                        }
                    }
                    districts = temp;
                }
            }
        }

        public void PrintDistricts()
        {
            if (districts != null)
            {
                foreach (string dist in districts)
                {
                    Console.WriteLine(dist);
                }
            }
        }

        public void PrintCity()
        {
            Console.WriteLine("City name: " + cityName);
            Console.WriteLine("Country name: " + countryName);
            Console.WriteLine("Population: " + population);
            Console.WriteLine("Area code: " + areaCode);
            Console.WriteLine("Districts:");
            PrintDistricts();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            City city = new City();
            city.SetData("Sarajevo", "Bosnia and Herzegovina", 500000, 71000, "Centar");
            city.AddDistrict("Novo Sarajevo");
            city.AddDistrict("Stari Grad");
            city.AddDistrict("Novi Grad");
            city.PrintCity();
        }
    }
}