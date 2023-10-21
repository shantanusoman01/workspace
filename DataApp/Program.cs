using System.Data.SqlClient;
using System.Data;

using System;


internal class Program
{
     
public static void Add(){
    string connectionString = "User ID=sa;password=examlyMssql@123; server=localhost;Database=Shantanu;trusted_connection=false;Persist Security Info=False;Encrypt=False";
        string cmdtext="insert into product values (@id,@name,@price,@stock)";
        System.Console.WriteLine("Enter ID");
        int ID=Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter product Name");
        string name=Console.ReadLine();
        System.Console.WriteLine("Enter price");
        int price=Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter Stock");
        int stock=Convert.ToInt32(Console.ReadLine());
        SqlConnection con=null;
        SqlCommand command=null;
        
            con=new SqlConnection(connectionString);
        try{
            command=new SqlCommand(cmdtext,con);
            command.Parameters.AddWithValue("@ID",ID);
            command.Parameters.AddWithValue("@name",name);
            command.Parameters.AddWithValue("@price",price);
            command.Parameters.AddWithValue("@stock",stock);
            con.Open();
            command.ExecuteNonQuery();
            System.Console.WriteLine("Record Added");

        }
        catch(Exception e){
            System.Console.WriteLine(e.Message);
        }
        finally{
            con.Close();
        }

}
    
    // public static void Main()
    // {   .//Add();
    //     string connectionString = "User ID=sa;password=examlyMssql@123; server=localhost;Database=Shantanu;trusted_connection=false;Persist Security Info=False;Encrypt=False";
    //     string cmdtext="select * from product";
    //     try
    //     {
    //         SqlConnection com=new SqlConnection(connectionString);
    //         com.Open();
    //         System.Console.WriteLine("Connection Opened Successfully");
    //         SqlCommand command=new SqlCommand(cmdtext,com);
    //         SqlDataReader reader= command.ExecuteReader();
            
            
    //         while(reader.Read()){
    //             System.Console.WriteLine($"{reader["id"]}---{reader["name"]}---{reader["price"]}---{reader["stock"]}");
    //         }
    //         com.Close();

    //     }
    //     catch (Exception e)
    //     {
    //         System.Console.WriteLine(e.Message);
            
    //     }
    // }


public static void Main(){
AddDisc();
ShowDisconnect();

}
public static void ShowDisconnect(){
     string connectionString = "User ID=sa;password=examlyMssql@123; server=localhost;Database=Shantanu;trusted_connection=false;Persist Security Info=False;Encrypt=False";
    string cmdtxt = "insert into product values (@id,@name,@price,@stock)";
    SqlConnection connection=null;
    SqlDataAdapter adapter=null;
    DataSet ds=null;
    DataTable prodtable=null;
    try{

        ds=new DataSet();
        connection=new SqlConnection(connectionString);
        adapter=new SqlDataAdapter("select* from product",connection);
        adapter.Fill(ds,"Prods");
        prodtable=ds.Tables["Prods"];
        System.Console.WriteLine($"Rows = {prodtable.Rows.Count}");
        System.Console.WriteLine($"Colums = {prodtable.Columns.Count}");
        foreach(DataRow row in prodtable.Rows){
            System.Console.WriteLine($"{row["ID"]}---{row["name"]}---{row["price"]}-----{row["stock"]}");

        }
    }
    catch(Exception e){
        System.Console.WriteLine(e.Message);
    }

}
public static void AddDisc(){
    string connectionString = "User ID=sa;password=examlyMssql@123; server=localhost;Database=Shantanu;trusted_connection=false;Persist Security Info=False;Encrypt=False";

        System.Console.WriteLine("Enter ID");
        int ID=Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter product Name");
        string name=Console.ReadLine();
        System.Console.WriteLine("Enter price");
        int price=Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter Stock");
        int stock=Convert.ToInt32(Console.ReadLine());
    SqlConnection connection=null;
    SqlDataAdapter adapter=null;
    DataSet ds=null;
    DataTable prodtable=null;
    
     try{

        ds=new DataSet();
        connection=new SqlConnection(connectionString);
        adapter=new SqlDataAdapter("select* from product",connection);
        adapter.Fill(ds,"Prods");
        prodtable=ds.Tables["Prods"];
        DataRow prodrow=prodtable.NewRow();
    prodrow["ID"]=ID;
    prodrow["name"]=name;
    prodrow["price"]=price;
    prodrow["stock"]=stock;
    prodtable.Rows.Add(prodrow);
    
    SqlCommandBuilder scb=new SqlCommandBuilder(adapter);
    System.Console.WriteLine(scb.GetInsertCommand().CommandText);
       adapter.Update(prodtable);
        System.Console.WriteLine("Row Added");
     }
     catch(Exception e){
        System.Console.WriteLine(e.Message);
     }

}

}
    
