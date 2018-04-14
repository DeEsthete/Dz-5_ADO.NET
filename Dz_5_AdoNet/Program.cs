using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_5_AdoNet
{
    class Program
    {
        static void Main(string[] args)
        {
            DataSet shopDB = new DataSet();
            shopDB.ExtendedProperties.Add("developerName", "JeLion");

            DataTable orders = new DataTable("Orders");
            DataTable customers = new DataTable("Customers");
            DataTable employees = new DataTable("Employees");
            DataTable orderDetails = new DataTable("OrderDetails");
            DataTable products = new DataTable("Orders");

            DataColumn customers_idColumn = new DataColumn();
            customers_idColumn.ColumnName = "Id";
            customers_idColumn.DataType = typeof(int);
            customers_idColumn.AllowDBNull = false;
            customers_idColumn.AutoIncrement = true;
            customers_idColumn.AutoIncrementSeed = 0;
            customers_idColumn.AutoIncrementStep = 1;
            customers_idColumn.Unique = true;
            
            DataColumn nameColumn = new DataColumn("Name", Type.GetType("System.String"));
            DataColumn surnameColumn = new DataColumn("Surname", Type.GetType("System.String"));
            customers.Columns.Add(customers_idColumn);
            customers.Columns.Add(nameColumn);
            customers.Columns.Add(surnameColumn);
            customers.PrimaryKey = new DataColumn[] { customers.Columns["Id"] };

            DataColumn employees_idColumn = new DataColumn();
            employees_idColumn.ColumnName = "Id";
            employees_idColumn.DataType = typeof(int);
            employees_idColumn.AllowDBNull = false;
            employees_idColumn.AutoIncrement = true;
            employees_idColumn.AutoIncrementSeed = 0;
            employees_idColumn.AutoIncrementStep = 1;
            employees_idColumn.Unique = true;
            DataColumn e_nameColumn = new DataColumn("Name", Type.GetType("System.String"));
            DataColumn e_surnameColumn = new DataColumn("Surname", Type.GetType("System.String"));
            employees.Columns.Add(employees_idColumn);
            employees.Columns.Add(e_nameColumn);
            employees.Columns.Add(e_surnameColumn);
            employees.PrimaryKey = new DataColumn[] { employees.Columns["Id"] };


            DataColumn product_idColumn = new DataColumn();
            product_idColumn.ColumnName = "Id";
            product_idColumn.DataType = typeof(int);
            product_idColumn.AllowDBNull = false;
            product_idColumn.AutoIncrement = true;
            product_idColumn.AutoIncrementSeed = 0;
            product_idColumn.AutoIncrementStep = 1;
            product_idColumn.Unique = true;

            DataColumn p_priceColumn = new DataColumn("Price", Type.GetType("System.Decimal"));
            DataColumn p_nameColumn = new DataColumn("Name", Type.GetType("System.String"));
            products.Columns.Add(product_idColumn);
            products.Columns.Add(p_nameColumn);
            products.Columns.Add(p_priceColumn);
            products.PrimaryKey = new DataColumn[] { products.Columns["Id"] };

            DataColumn orders_idColumn = new DataColumn();
            orders_idColumn.ColumnName = "Id";
            orders_idColumn.DataType = typeof(int);
            orders_idColumn.AllowDBNull = false;
            orders_idColumn.AutoIncrement = true;
            orders_idColumn.AutoIncrementSeed = 0;
            orders_idColumn.AutoIncrementStep = 1;
            orders_idColumn.Unique = true;
            DataColumn customers_id_Column = new DataColumn();
            customers_id_Column.ColumnName = "Customers_id";
            customers_id_Column.DataType = typeof(int);
            DataColumn employees_id_Column = new DataColumn();
            employees_id_Column.ColumnName = "Employees_id";
            employees_id_Column.DataType = typeof(int);
            DataColumn product_id_Column = new DataColumn();
            product_id_Column.ColumnName = "Product_id";
            product_id_Column.DataType = typeof(int);
            DataColumn o_priceColumn = new DataColumn("Price", Type.GetType("System.Decimal"));
            o_priceColumn.ColumnName = "Price";
            o_priceColumn.DataType = typeof(int);
            orders.Columns.Add(orders_idColumn);
            orders.Columns.Add(customers_id_Column);
            orders.Columns.Add(employees_id_Column);
            orders.Columns.Add(product_id_Column);
            orders.Columns.Add(o_priceColumn);
            orders.PrimaryKey = new DataColumn[] { orders.Columns["Id"] };
            ForeignKeyConstraint orders_customers_FK = new ForeignKeyConstraint(orders.Columns["Customers_id"], customers.Columns["Id"]);
            ForeignKeyConstraint orders_employees_FK = new ForeignKeyConstraint(orders.Columns["Employees_id"], employees.Columns["Id"]);
            ForeignKeyConstraint orders_products_FK = new ForeignKeyConstraint(orders.Columns["Product_id"], customers.Columns["Id"]);


            shopDB.Tables.Add(customers);
            shopDB.Tables.Add(employees);
            shopDB.Tables.Add(products);
            shopDB.Tables.Add(orders);



            shopDB.AcceptChanges();
        }
    }
}
