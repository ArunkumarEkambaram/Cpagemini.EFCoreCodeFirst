using System;
using System.Collections.Generic;
using System.Linq;
using Capgemini.EFCoreDataFirst.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Capgemini.EFCoreDataFirst
{
    internal class Program
    {
        private readonly HRContext _context;

        public Program()
        {
            _context = new HRContext();
        }

        public List<Position> UsingLinq()
        {
            return _context.Positions.ToList();
        }

        //Raw SQL
        public List<Position> UsingRawSql()
        {
            return _context.Positions.FromSqlRaw("Select * from Position").ToList();
        }

        //Call Stored Procedure
        public List<Position> CallSqlStoredProcedure(int budgetedStrength)
        {
            SqlParameter bStr = new SqlParameter()
            {
                ParameterName = "@iBudgetedStrength",
                DbType = System.Data.DbType.Int32,
                Value = budgetedStrength,
                Direction = System.Data.ParameterDirection.Input
            };

            return _context.Positions.FromSqlRaw("usp_GetPositionByYear @iBudgetedStrength", bStr).ToList();
        }

        static void Main(string[] args)
        {
            Program p1 = new();
            //var linq = p1.UsingLinq();
            //Console.WriteLine("Using LINQ");
            //foreach (var p in linq)
            //{
            //    Console.WriteLine($"Code :{p.CPositionCode}\tDescription :{p.VDescription}");
            //}

            //Console.WriteLine();
            //Console.WriteLine("Using SqlRaw");
            //var sql = p1.UsingRawSql();
            //foreach (var p in sql)
            //{
            //    Console.WriteLine($"Code :{p.CPositionCode}\tDescription :{p.VDescription}");
            //}

            int bStr = 40;
            var result = p1.CallSqlStoredProcedure(bStr);
            foreach (var p in result)
            {
                Console.WriteLine($"Code :{p.CPositionCode}\tDescription :{p.VDescription}\tBudgeted Strength :{p.IBudgetedStrength}");
            }
        }
    }
}
