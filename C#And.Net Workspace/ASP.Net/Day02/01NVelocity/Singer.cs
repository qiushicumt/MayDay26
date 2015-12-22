using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _01NVelocity
{
    public class Singer:Person
    {
        string _songName;

        public string SongName
        {
            get { return _songName; }
            set { _songName = value; }
        }

        public Singer(string name, int age, string songName)
        {
            this.Name = name;
            this.Age = age;
            this.SongName = songName;
        }
    }
}