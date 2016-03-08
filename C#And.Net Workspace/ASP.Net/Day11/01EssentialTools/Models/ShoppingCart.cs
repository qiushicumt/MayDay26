using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _01EssentialTools.Models
{
    public class ShoppingCart
    {
        #region 以紧耦合的方式实现LinqValueCalculator类
        /*
        private LinqValueCalculator calc;                           //声明一个LinqValueCalculator类的实例对象，用于计算产品集合的Price总价
        public ShoppingCart(LinqValueCalculator calcParam)          //声明一个ShoppingCart的构造函数
        {
            this.calc = calcParam;
        }
        public IEnumerable<Product> Products { get; set; }          //定义一个Products集合的Products属性
        
        /// <summary>
        /// 定义计算总价的方法
        /// </summary>
        /// <returns>返回ShoppingCart中所有Product的总价</returns>
        public decimal CalculatorTotal()
        {
            return this.calc.ValueProducts(Products);
        }
        */
        #endregion

        #region 利用接口以松耦合的方式实现LinqValueCalculator
        private IValueCalculator calc;                              //声明一个IValueCalculator接口的实例对象，用于计算产品集合的Price总价
        public ShoppingCart(IValueCalculator calcParam)             //声明一个ShoppingCart的构造函数
        {
            calc = calcParam;
        }
        public IEnumerable<Product> Products { get; set; }          //定义一个Products集合的Products属性

        /// <summary>
        /// 定义计算总价的方法
        /// </summary>
        /// <returns>返回ShoppingCart中所有Product的总价</returns>
        public decimal CalculatorTotal()
        {
            return this.calc.ValueProducts(Products);
        }
        #endregion
        
    }
}