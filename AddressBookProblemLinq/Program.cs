using System;
using System.Data;

namespace AddressBookProblemLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to address book problem for linq");
            //Creating DataTable for addressbook problem UC1
            DataTable addressBookTable = new DataTable();

            //adding columns into address book table UC2
            DataColumn column;
            DataRow row;

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "firstName";
            addressBookTable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "lastName";
            addressBookTable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "address";
            addressBookTable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "city";
            addressBookTable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "state";
            addressBookTable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "zip";
            addressBookTable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Double");
            column.ColumnName = "phoneNumber";
            addressBookTable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "eMail";
            addressBookTable.Columns.Add(column);
            //UC9
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "addressBookName";
            addressBookTable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "type";
            addressBookTable.Columns.Add(column);

            // Make the first name and mobile no column the primary key column.
            DataColumn[] PrimaryKeyColumns = new DataColumn[2];
            PrimaryKeyColumns[0] = addressBookTable.Columns["firstName"];
            PrimaryKeyColumns[1] = addressBookTable.Columns["phoneNumber"];
            addressBookTable.PrimaryKey = PrimaryKeyColumns;

            //Inserting data into columns into datatable UC3
            addressBookTable.Rows.Add("Vishal", "Garg", "Barwala", "Hisar", "Haryana", 125121, 8570934858, "vishal.garg","Vishal","family");
            addressBookTable.Rows.Add("Akshay", "Poriya", "Goregaon", "Bangalore", "Karnataka", 125433, 8585858585, "akshay.a","Mahak","family");
            addressBookTable.Rows.Add("Kretika", "Arora", "Andheri", "Mumbai", "Maharashtra", 125445, 7575757575, "kretika.arora","Mahak","Business");
            addressBookTable.Rows.Add("Kamalakar", "Singh", "Thanesar", "Kurukshetra", "Haryana", 136119, 9595959595, "kamalakar.singh","Vishal","family");
            addressBookTable.Rows.Add("Praveen", "Kumar", "rohini", "Delhi", "Delhi", 435121, 7897897898, "praveen.kumar","Mahak","family");
            addressBookTable.Rows.Add("Apoorva", "Singh", "Andheri", "Mumbai", "Maharashtra", 125445, 8598598599, "apporva.singh","Mahak","Business");
            
            AddressBookManagement addressBookManagement = new AddressBookManagement();
            //UC4
            //addressBookTable = addressBookManagement.UpdatedContactDetails(addressBookTable);
            ////var book = addressBookTable.AsEnumerable().Select(r => r.Field<string>("state"));
            //Console.WriteLine("*******************Total data*****************");
            //foreach (var data in addressBookTable.AsEnumerable())
            //{
            //    Console.WriteLine("FirstName:- " + data.Field<string>("firstName"));
            //    Console.WriteLine("lastName:- " + data.Field<string>("lastName"));
            //    Console.WriteLine("Address:- " + data.Field<string>("address"));
            //    Console.WriteLine("City:- " + data.Field<string>("city"));
            //    Console.WriteLine("State:- " + data.Field<string>("state"));
            //    Console.WriteLine("zip:- " + Convert.ToInt32(data.Field<int>("zip")));
            //    Console.WriteLine("phoneNumber:- " + Convert.ToDouble(data.Field<Double>("phoneNumber")));
            //    Console.WriteLine("eMail:- " + data.Field<string>("eMail"));
            //    Console.WriteLine("***************");
            //}
            //deleting contacts from address book table UC5
            //addressBookTable= addressBookManagement.DeletingContactFromTable(addressBookTable);
            //checking if contact is deleted 
            //Console.WriteLine(addressBookTable.Rows);
            //var book = addressBookTable.AsEnumerable().Select(r => r.Field<string>("firstName"));
            //foreach (string element in book)
            //{
            //    Console.WriteLine(element);
            //}
            //UC6
            //addressBookManagement.RetrievingContactDetailsByStateOrCity(addressBookTable);
            //UC7
            //addressBookManagement.GetCountByCityAndState(addressBookTable);
            //UC8
            //addressBookManagement.GetSortedDataBasedOnPersonName(addressBookTable);
            //UC10
            addressBookManagement.GetCountByType(addressBookTable);
        }
    }
}
