using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_Class
{
    class People
    {
        int _age;
        //  设置Age属性
        public int Age              
        {
            set
            {
                /*
                if(value <= 0)
                {
                    value = 0;
                }
                else if(value>100)
                {
                    value = 100;
                }
                */
                _age = value;              
            }
            get
            {
                if (_age < 0)
                    return _age = 0;
                else if (_age > 100)
                    return _age = 100;
                return _age;
            }
        }
        public string _name;
        public string _gender;

        public void Show()
        {
            Console.WriteLine("我是{0}，性别{1}，年龄{2}", this._name, this._gender, this.Age);
        }
    }
}
