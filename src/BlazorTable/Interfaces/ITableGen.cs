﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace BlazorTable
{
    /// <summary>
    /// BlazorTable Interface
    /// </summary>
    /// <typeparam name="TableItem"></typeparam>
    public interface ITable<TableItem> : ITable
    {
        /// <summary>
        /// List of All Available Columns
        /// </summary>
        List<IColumn<TableItem>> Columns { get; }

        /// <summary>
        /// Adds a Column to the Table
        /// </summary>
        /// <param name="column"></param>
        void AddColumn(IColumn<TableItem> column);

        /// <summary>
        /// Removes a Column from the Table
        /// </summary>
        /// <param name="column"></param>
        void RemoveColumn(IColumn<TableItem> column);

        /// <summary>
        /// IQueryable data source to display in the table
        /// </summary>
        IQueryable<TableItem> ItemsQueryable { get; set; }

        /// <summary>
        /// Collection to display in the table
        /// </summary>
        IEnumerable<TableItem> Items { get; set; }
    }
}