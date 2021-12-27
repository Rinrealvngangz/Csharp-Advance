using System;

namespace NullableType
{
    partial class Person
    {
        private DateTime birth;
        private DateTime? death;
        private string name;

        public TimeSpan Age
        {
            get
            {
              DateTime lastAlive =  death ?? DateTime.Now   ;
              return lastAlive - birth;
            }

        }

        public Person(string name, DateTime birth, DateTime? death)
        {
            this.name = name;
            this.birth = birth;
            this.death = death;
        }
        
        
        
    }
}