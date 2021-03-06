﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace SerializationTask
{
    [Serializable]
    class Person : IDeserializationCallback
    {
        string name;
        [NonSerialized]int age;
        int dateOfBirth;

        public Person(string name, int age, int dateOfBirth)
        {
            this.name = name;
            this.age = age;
            this.dateOfBirth = dateOfBirth;
        }

        public Person()
        {
            
        }

        public override string ToString()
        {
            return $"Name: {name}\tAge: {age}";
        }

        public void OnDeserialization(object sender)
        {
           
        }
    }
}
