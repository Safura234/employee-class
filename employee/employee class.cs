using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace employee
{
    internal class employee_class
    {
        private int _empID;
        private string _name;
        private int _salary;

    }
    class Department
    {
        private int _id;
        private string _name;
        private string _Employeelist;

    }
    private int AddEmployee(int _empID, string _name, int _salary)
    {
        _empID = 3;
        _name = "Safura";
        _salary = 800;
        string path = @"C:\Users\Spectre\OneDrive\Bureau\employee class\database_json";
        String dirpath = Directory.GetCurrentDirectory();
        StreamWriter file = new StreamWriter(_name);

        if (!File.Exists(dirpath + @"\" + _name))
            file.Write("FILE DOES NOT EXIST AND HAS BEEN CREATED");
        else
            file.Write("FILE EXISTS");

        file.Close();

    }
    public class Menu
    {
        public int emp_Id { get; set; }
        public string emp_Name { get; set; }
        public int emp_Salary { get; set; }
        public string emp_List { get; set; }
    }

}
    
}
