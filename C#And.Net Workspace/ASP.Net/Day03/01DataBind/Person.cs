using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01DataBind
{
    //  INotifyPropertyChanged接口用于在属性值发生改变时向客户端发出通知
    class Person:INotifyPropertyChanged
    {
        string _name;
        int _age;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set 
            { 
                _age = value;
                if (PropertyChanged != null)    //  在事件触发前与null进行比较，查看是否包含事件处理程序，如果==null，不包含，则不触发事件
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Age"));     // new PropertyChangedEventArgs(属性名)，表示当哪个属性改变时发出通知
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
