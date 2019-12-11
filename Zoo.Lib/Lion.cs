using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Lib
{
    public enum Sex { F, M };
    public class Lion
    {
        public int Age { get; set; }
        public Sex Sex { get; set; }
        public string Name { get; set; }

        public Lion(string name, Sex sex): this(name, sex, 0)
        {

        }
        public Lion(string name, Sex sex, int age)
        {
            Name = name;
            Sex = sex;
            Age = age;
        }
    }
}
