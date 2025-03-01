﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using static OnlineShop.Models.Order;

namespace OnlineShop.Models
{
    public class Order
    {
        public Order()
        {
            // 預設為 "未出貨" 狀態
            isShipped = false;
        }
     
        public int Id { get; set; }
        public DateTime? OrderDate { get; set; }        //訂單建立時間

        public string UserId { get; set; }             //付款者ID
        public string UserName { get; set; }           //付款者帳號

        public string ReceiverName { get; set; }       //收貨者姓名
        public string ReceiverAddress { get; set; }     //收貨者地址
        public string ReceiverPhone { get; set; }      //收貨者電話

        public int Total { get; set; }                 //訂單總額
        public List<OrderItem> OrderItem { get; set; } //訂單內容
        public bool isPaid { get; set; }               //付款狀態
        private bool? _isShipped; // 將原始的布林值屬性改為可空的布林值
        public bool? isShipped
        {
            get { return _isShipped; }
            set { _isShipped = value; }
        }
       
        public DateTime? ShippingDate { get; set; } // 出貨日期

        public OrderStatus OrderStatus { get; set; } // 訂單狀態屬性



    }
    public enum OrderStatus
    {
        Pending,
        Confirmed,
        Shipped,
        Delivered,
        Cancelled
    }

    public class OrderItem
    {
       
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Amount { get; set; }
        public int SubTotal { get; set; }
        public bool IsReturned { get; set; }
      



    }

    public class CartItem : OrderItem
    {
        public CartItem() { }
        public CartItem(OrderItem order)
        {
            this.OrderId = order.OrderId;
            this.ProductId = order.ProductId;
            this.Amount = order.Amount;
            this.SubTotal = order.SubTotal;
        }

        public Product Product { get; set; }
        public string imageSrc { get; set; }

    }
}
