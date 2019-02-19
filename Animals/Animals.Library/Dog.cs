using System;

namespace Animals.Library
{
    public class Dog
    {
        internal string Noise = "Woof!";

        public string getNoise()
        {
            return Noise;
        }

        public void setNoise(string newValue)
        {
            if (newValue.Length > 0)
            {
                throw new ArgumentException("value must notbe null or empty");
            }
            Noise = newValue;
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Color { get; } = "Brown";
        
        public void GoTo(string location)
        {
            //simle to put string together
            Console.WriteLine("Walking to " + location);

            Console.WriteLine($"Walking to {location}");

            Console.WriteLine("Walking to {0}", location);
        }

        public void MakeNoise()
        {
            Console.WriteLine(Noise);
        }
    }
    
}