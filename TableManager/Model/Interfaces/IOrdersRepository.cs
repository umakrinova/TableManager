﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableManageData;

namespace TableManagerData
{
    public interface IOrdersRepository
    {
        /// <summary>
        /// Adds passed order to a database
        /// </summary>
        /// <param name="order">Order to be added</param>
        void AddOrder(Order order);

        /// <summary>
        /// Submits update to an existing order
        /// </summary>
        /// <param name="order">Updated order</param>
        void UpdateOrder(Order orderNew, Order orderOld);

        /// <summary>
        /// Gets information about available dishes from a database
        /// </summary>
        /// <returns>Untracked dish instances with id, name, price and cost</returns>
        IEnumerable<Dish> GetDishes();

        /// <summary>
        /// Returns active orders for specified table from a database
        /// </summary>
        /// <param name="tablesId">Id of the table to look up active orders for</param>
        /// <returns>Untracked collection of orders for specified table</returns>
        IEnumerable<Order> GetActiveOrders(int tablesId);

        /// <summary>
        /// Completes an order
        /// </summary>
        /// <param name="orderId">Id of the order to be completed</param>
        void OrderComplete(int orderId);

        /// <summary>
        /// Canceles an order, which was added, but not completed
        /// </summary>
        /// <param name="orderId"></param>
        void CancelOrder(int orderId);
    }
}
