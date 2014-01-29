using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConversions
{
    public struct Fahrenheit
    {
        // Public field
        public float Temperature;
        // Constructor
        public Fahrenheit(float temperature)
        {
            Temperature = temperature;
        }
        // Implicit cast from float to Fahrenheit
        public static implicit operator Fahrenheit(float temperature)
        {
            return new Fahrenheit(temperature);
        }
        // Implicit cast from Celsius to Fahrenheit
        public static implicit operator Fahrenheit(Celsius celsius)
        {
            return new Fahrenheit((celsius.Temperature * (5.0F / 9.0F)) + 32.0F);
        }
        // Explicit cast from Fahrenheit to long

        // Implicit cast from Celsius to Fahrenheit
        public static implicit operator Fahrenheit(Kelvin kelvin)
        {
            return new Fahrenheit((kelvin.Temperature * (5.0F / 9.0F)) + 32.0F + 273.15F);
        }
        // Explicit cast from Fahrenheit to long

        public static explicit operator long(Fahrenheit fahrenheit)
        {
            return (long)Math.Round(fahrenheit.Temperature, 0);
        }
        // Method to return Fahrenheit to Celsius conversion
        public float Celsius()
        {
            return ((Temperature - 32.0F) * (5.0F / 9.0F));
        }

        public float Kelvin()
        {
            return ((Temperature - 32.0F) * (5.0F / 9.0F) + 273.15F);
        }
        // Display Fahrenheit value as a string
        public override string ToString()
        {
            return Temperature.ToString();
        }
    }

    public struct Celsius
    {
        // Public field
        public float Temperature;
        // Constructor
        public Celsius(float temperature)
        {
            Temperature = temperature;
        }
        // Implicit cast from float to Celsius
        public static implicit operator Celsius(float temperature)
        {
            return new Celsius(temperature);
        }
        // Implicit cast from Fahrenheit to Celsius
        public static implicit operator Celsius(Fahrenheit fahrenheit)
        {
            return new Celsius((fahrenheit.Temperature - 32.0F) * (5.0F / 9.0F));
        }
        // Implicit cast from Celsius to Fahrenheit
        public static implicit operator Celsius(Kelvin kelvin)
        {
            return new Celsius((kelvin.Temperature * (5.0F / 9.0F)) + 32.0F + 273.15F);
        }

        // Explicit cast from Celsius to long
        public static explicit operator long(Celsius celsius)
        {
            return (long)Math.Round(celsius.Temperature, 0);
        }
        // Method to return Celsius to Fahrenheit conversion
        public float Fahrenheit()
        {
            return ((Temperature * (9.0F / 5.0F)) + 32);
        }

        public float Kelvin()
        {
            return ((Temperature + 273.15F));
        }

        // Display Celsius value as a string
        public override string ToString()
        {
            return Temperature.ToString();
        }
    }

    public struct Kelvin
    {
        // Public field
        public float Temperature;
        // Constructor
        public Kelvin(float temperature)
        {
            Temperature = temperature;
        }
        // Implicit cast from float to Kelvin
        public static implicit operator Kelvin(float temperature)
        {
            return new Kelvin(temperature);
        }
        // Implicit cast from Fahrenheit to Kelvin
        public static implicit operator Kelvin(Fahrenheit fahrenheit)
        {
            return new Kelvin((fahrenheit.Temperature - 32.0F) * (5.0F / 9.0F) + 273.15F);
        }

        public static implicit operator Kelvin(Celsius celsius)
        {
            return new Kelvin((celsius.Temperature * (5.0F / 9.0F)) + 32.0F + 273.15F);
        }

        // Explicit cast from Kelvin to long
        public static explicit operator long(Kelvin Kelvin)
        {
            return (long)Math.Round(Kelvin.Temperature, 0);
        }
        // Method to return Kelvin to Fahrenheit conversion
        public float Fahrenheit()
        {
            return ((Temperature - 273.15F) * (9.0F / 5.0F) + 32F);
        }

        public float Celsius()
        {
            return ((Temperature - 273.15F));
        }

        // Display Kelvin value as a string
        public override string ToString()
        {
            return Temperature.ToString();
        }
    }
}
