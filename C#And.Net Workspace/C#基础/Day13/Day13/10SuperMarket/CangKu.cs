using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10SuperMarket
{
    //  1、分门别类存储货物
    //      通过建立集合来存储物品对象，Acer为一个List集合、SamSung为一个list集合、JiangYou为一个list集合、Banana为一个list集合
    //      为了取消4个类别的差异性，将每一个集合的类型设置为父类Product,方便通过循环进行赋值
    //  2、存货入库
    //  3、提货出库
    public class CangKu
    {
        List<List<Product>> productList = new List<List<Product>>();
        
        //  在声明一个CangKu的实例对象的时候，就直接初始化其中的list集合，所以在构造函数中赋值
        public CangKu()
        {
            // produstlist[0]--Acer productlist[1]--SamSung productlist[2]--Banana  product[3]--JiangYou
            for (int i = 0; i < 4; i++)
            {
                productList[i] = new List<Product>();
            }
        }
        
        //  存货入库的方法，即每一个实例对象调用此方法，将货物入库
        public void GetProduct(int count, string nameType)
        {
            //  根据存入对象的类型，添加不同的实例变量到相对应的集合中
            switch (nameType)
            {
                case "Acer":
                    productList[0].Add(new Acer(Guid.NewGuid().ToString(), 2800, 1, "Acer电脑"));
                    break;
                case "SamSung":
                    productList[1].Add(new SamSung(Guid.NewGuid().ToString(), 2100, 1, "SAMSUNG手机"));
                    break;
                case "Banana":
                    productList[2].Add(new Banana(Guid.NewGuid().ToString(), 5.4, 1, "海南Banana"));
                    break;
                case "JiangYou":
                    productList[3].Add(new JiangYou(Guid.NewGuid().ToString(), 8.2, 1, "老抽"));
                    break;
            }
        }
    }
}
