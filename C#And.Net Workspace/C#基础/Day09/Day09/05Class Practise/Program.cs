using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Class_Practise
{
    /*
     * 写一个Ticket类,有一个距离属性(本属性只读,在构造方法中赋值),不能为负数,有一个价格属性,价格属性只读,并且根据距离distance计算价格Price (1元/公里):        0-100公里        票价不打折        101-200公里    总额打9.5折        201-300公里    总额打9折        300公里以上    总额打8折        有一个方法,可以显示这张票的信息.90公里90块钱
     */
    class Program
    {
        static void Main(string[] args)
        {
            Ticket myTicket = new Ticket(400);
            myTicket.ShowPrice();
            Console.ReadKey();
        }
    }
}
