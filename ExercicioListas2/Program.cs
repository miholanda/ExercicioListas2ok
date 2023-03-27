using System;
using System.Globalization;
using System.Collections.Generic;
using ExercicioListas2;

Console.Write("How many employees will be registered? ");
//recebe a quantidade de employees
int n = int.Parse(Console.ReadLine());

//cria e instancia uma nova lista do tipo Employee
List<Employee> list = new List<Employee>();

//laço for para receber informações do employee
for(int i = 1; i <= n; i++)
{
    Console.WriteLine("Employee #" + i + ":");

    Console.Write("Id: ");
    int id = int.Parse(Console.ReadLine());

    Console.Write("Name: ");
    string name = Console.ReadLine();

    Console.Write("Salary: ");
    double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    list.Add(new Employee(id, name, salary));

    Console.Clear();
}

Console.Write("Enter the employee id that will have the salary increase: ");

int searchId = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Employee emplo = list.Find(x => x.Id == searchId);

    if (emplo != null)
    {
        Console.WriteLine("Employee found!");

        Console.Write("Enter the percentage: ");
        double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        emplo.IncreaseSalary(percentage);

        Console.WriteLine("Salary succesfully updated!");
        break;
    }
    else
    {
        Console.WriteLine("Id not found! ");

        Console.Write("Enter the employee id that will have the salary increase: ");

        searchId = int.Parse(Console.ReadLine());

        Console.Clear();
    }

}

Console.WriteLine("Updated employee list: ");

foreach(Employee obj in list)
{
    Console.WriteLine(obj);
}



