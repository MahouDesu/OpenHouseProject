using System;
using System.Collections.Generic;
using System.Text;

namespace OpenHouseProject
{
    class realtor
    {
        public realtor(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public string Employer { get; set; }

        public void Speak(string message)
        {
            Console.WriteLine(message);
        }
    }
}
