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
        //  创建一个类型为List<Product>的List集合，即proList中的每一项为一个Product类型的List集合
        //  List<Product>分别存储每一个子类的实例对象
        //  proList[0]存储Acer类对象的List集合
        //  proList[1]存储SamSung类对象的List集合
        //  proList[2]存储Banana类对象的List集合
        //  proList[3]存储JiangYou类对象的List集合
        List<List<Product>> proList = new List<List<Product>>();

        //  通过构造函数，在创建CangKu类的实例对象时就将4个List
        public CangKu()
        {
            for (int i = 0; i < 4; i++)
            {
                proList.Add(new List<Product>());
            }
            /*
            proList[0] = new List<Product>();
            proList[1] = new List<Product>();
            proList[2] = new List<Product>();
            proList[3] = new List<Product>();
             * */
        }

        /// <summary>
        /// 获得商品的对象，商品入库
        /// </summary>
        /// <param name="count">数量</param>
        /// <param name="proType">类型</param>
        public void GetInProduct(int count, string proType)
        {
            for(int i = 0; i < count; i++)
            {
                switch (proType)
                {
                    case "Acer":
                        proList[0].Add(new Acer(Guid.NewGuid().ToString(), 2800, "Acer笔记本电脑"));
                        break;
                    case "SamSung":
                        proList[1].Add(new SamSung(Guid.NewGuid().ToString(), 2400, "Samsung手机"));
                        break;
                    case "Banana":
                        proList[2].Add(new Banana(Guid.NewGuid().ToString(), 5.2, "海南Banana"));
                        break;
                    case "JiangYou":
                        proList[3].Add(new JiangYou(Guid.NewGuid().ToString(), 8.3, "老抽酱油"));
                        break;
                }
            }            
        }

        /// <summary>
        /// 取出商品
        /// </summary>
        /// <param name="count">取出的数量</param>
        /// <param name="proType">商品类型</param>
        /// <returns>返回一个取出的商品的集合</returns>
        public List<Product> GetOutProduct(int count, string proType)
        {
            List<Product> list = new List<Product>();
            for(int i = 0; i < count; i++)
            {
                switch (proType)
                {
                    case "Acer":

                        //  错误写法：list[i] = proList[0][0];        //  将对象赋值给list
                        list.Add(proList[0][0]);
                        proList[0].RemoveAt(0);         //  将对象从原List中移除
                        break;
                    case "SamSung":
                        //  list[i] = proList[1][0];
                        list.Add(proList[1][0]);
                        proList[1].RemoveAt(0);
                        break;
                    case "Banana":
                        //  list[i] = proList[2][0];
                        list.Add(proList[2][0]);
                        proList[2].RemoveAt(0);
                        break;
                    case "JiangYou":
                        //  list[i] = proList[3][0];
                        list.Add(proList[3][0]);
                        proList[3].RemoveAt(0);
                        break;
                }
            }
            return list;          
        }

        //  仓库显示库存信息
        public void ProShow()
        {
            foreach (var item in proList)
            {
                Console.WriteLine("超市里面有{0}, 有{1}个，每个{2}元。", item[0].ProductName, item.Count, item[0].Price);
            }
        }

    }

    /*
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
    */
}
