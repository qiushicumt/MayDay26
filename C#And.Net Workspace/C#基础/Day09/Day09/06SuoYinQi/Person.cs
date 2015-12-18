using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06SuoYinQi
{
    public class Person
    {
        int _age;
        string _firstName;
        string _middleName;
        string _lastName;

        //  定义一个Age属性
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        //  定义一个索引器
        //  索引器返回的类型为string，然后分别在set方法和get方法中进行赋值和取值操作
        public string this[int index]
        {
            set
            {
                switch (index)
                {
                    case 0:
                        _firstName = value;
                        break;
                    case 1:
                        _middleName = value;
                        break;
                    case 2:
                        _lastName = value;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException("index");
                }
            }

            get
            {
                switch (index)
                {
                    case 0:
                        return _firstName;                       
                    case 1:
                        return _middleName;
                    case 2:
                        return _lastName;
                    default:
                        throw new ArgumentOutOfRangeException("index");     //  超出索引器范围时抛出一个异常
                }
            }
        }
    }
}
