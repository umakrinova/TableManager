﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableManagerData.Model;

namespace TableManagerData
{
    public interface ITablesRepository
    {
        /// <summary>
        /// Invoked for each table instance in GetTableInfo().
        /// Assign to get id and location for each table
        /// </summary>
        event Action<int, string> TableInfoHandler;

        /// <summary>
        /// Invoked in GetTableInfo(). 
        /// Assign to get collection of table statuses, SelectedValuePath (status id), and DisplayMemberPath (status descripion)
        /// </summary>
        event Action<IEnumerable<TableStatus>, string, string> TableStatusHandler;

        /// <summary>
        /// Use to get change table status
        /// <param name="tableId">table's id whose status is changed</param>
        /// <param name="statusId">id should be passed from earlier retrieved status collection. Use TableStatusHandler for this</param>  
        /// </summary>
        void ChangeStatus(int tableId, int statusId);

        /// <summary>
        /// Call for get all table related infromation. Invokes TableInfoHandler and TableStatusHandler
        /// </summary>
        void GetTableInfo();
    }
}
