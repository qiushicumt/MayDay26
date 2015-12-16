using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10SuperMarket
{
    //  超市类，在超市类中，生成一个仓库类的实例对象，即生成一个超市类的实例对象时，自动生成一个仓库类对象
    //  在SuperMarket的构造函数中，将货物存入仓库中
    class SuperMarket
    {
        CangKu myCangKu = new CangKu();     //  生成一个仓库实例对象

        //  在SuperMarket中向仓库存货
        public SuperMarket()
        {
            myCangKu.GetInProduct(200, "Acer");
            myCangKu.GetInProduct(200, "SamSung");
            myCangKu.GetInProduct(200, "JiangYou");
            myCangKu.GetInProduct(200, "Banana");
        }

        //  询问购买
        public void AskBuying()
        {
            Console.WriteLine("我们仓库中有 Acer、SamSung、Banana、JiangYou，请输入想要购买的物品:");
            string proType = Console.ReadLine();
            Console.WriteLine("请输入购买的数量:");
            int count = Convert.ToInt32(Console.ReadLine());
            //  根据数量，从仓库中取货
            List<Product> list = myCangKu.GetOutProduct(count, proType);
            //  计算货物的价格
            double totalPrice = getTotalPrice(list);
            Console.WriteLine("应付{0}元", totalPrice);
            //  计算打折
            Console.WriteLine("请选择打折类型：1--不打折  2--打9折  3--打85折  4--满300减50  5--满500减100");
            string inputCal = Console.ReadLine();   //  接收打折的选择
            //  根据简单工厂设计模式，当子类的特征类型等等都不确定时，返回一个父类
            CalFather myCal = GetCal(inputCal);
            double realPrice = myCal.GetRealMoney(totalPrice);
            Console.WriteLine("打折后，最终应付{0}元", realPrice);
        }

        /// <summary>
        /// 得到打折折扣
        /// </summary>
        /// <param name="input">输入的选择的打折类型</param>
        /// <returns>返回打折折扣</returns>
        public CalFather GetCal(string input)
        {
            CalFather myCal = null;
            switch (input)
            {
                case "1":
                    myCal = new CalNormal();
                    break;
                case "2":
                    myCal = new CalRate(0.9);
                    break;
                case "3":
                    myCal = new CalRate(0.85);
                    break;
                case "4":
                    myCal = new CalMN(300, 50);
                    break;
                case "5":
                    myCal = new CalMN(500, 100);
                    break;
            }
            return myCal;
        }

        /// <summary>
        /// 计算所有物品的价格
        /// </summary>
        /// <param name="list">所有物品的集合</param>
        /// <returns>所有物品的价格</returns>
        public double getTotalPrice(List<Product> list)
        {
            return list[0].Price * list.Count;
        }

        /// <summary>
        /// 显示超市所有的物品信息
        /// </summary>
        public void SuperMarketShow()
        {
            myCangKu.ProShow();
        }
    }
}
