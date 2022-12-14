using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class Company
    {
        //Название компании
        public string title { get; }
        public Director director;
        public Accountant accountant;
        public Guard guard;
        public List<Employee> employees;
        public Company(string title, Director d, Accountant a, Guard g)
        {
            this.title = title;
            director = d;
            accountant = a;
            guard = g;
            employees = new List<Employee>();
        }
        public void AddEmployee(Employee employee) => this.employees.Add(employee);
        public void AddEmployee(List<Employee> employees) => this.employees.AddRange(employees);
        public void PrintListEmployees()
        {
            if (employees.Count == 0) { Console.WriteLine("В компании нет сотрудников"); return; }
            for (int i = 0; i < employees.Count; i++)
                Console.WriteLine((i+1)+") "+employees[i].ToString());
        }
        public void DeleteEmployee()
        {
            this.PrintListEmployees();
            Console.WriteLine("Введите номер сотрудника для увольнения:");
            int index = Convert.ToInt32(Console.ReadLine()); //проверку на индекс
            employees.RemoveAt(index);
        }
        public void ChangeDirector(Director directorNew) => this.director = directorNew;
        public void ChangeAccountant(Accountant accountantNew) => this.accountant = accountantNew;
        public void ChangeGuard(Guard guardNew) => this.guard = guardNew;
        public void PrintStructOfCompany()
        {
            Console.WriteLine("\tДиректор");
            Console.WriteLine(director.ToString());
            Console.WriteLine("\tБухгалтер");
            Console.WriteLine(accountant.ToString());
            Console.WriteLine("\tОхранник");
            Console.WriteLine(guard.ToString());
            Console.WriteLine("\tСотрудники");
            this.PrintListEmployees();
        }
    }
    public class Director : Person
    {
        public double experienceInManagent { get; }
        public int countOfOtherCompanies { get; }
        public Director(string name, string surname, string patronymic, int age, double experience, int salaty, double experienceInManagent, int countOfOtherCompanies) : base(name, surname, patronymic, age, experience, salaty)
        {
            this.experienceInManagent = experienceInManagent;
            this.countOfOtherCompanies = countOfOtherCompanies;
        }
        public override string ToString()
        {
            return (base.ToString() + $"Опыт в руководстве: {experienceInManagent} Кол-во других компаний: {countOfOtherCompanies}");
        }
    }
    public class Guard : Person
    {
        private string titleSecurityCompany;
        public Guard(string name, string surname, string patronymic, int age, double experience, int salaty, string titleSecurityCompany) : base(name, surname, patronymic, age, experience, salaty)
        {
            this.titleSecurityCompany = titleSecurityCompany;
        }
        public override string ToString()
        {
            return (base.ToString() + $"Название охранной компании: {titleSecurityCompany}");
        }
    }
    public class Employee : Person
    {
        public string department { get; }
        public string formerPlaceOfWork { get; }
        public Employee(string name, string surname, string patronymic, int age, double experience, int salaty, string department, string formerPlaceOfWork) : base(name, surname, patronymic, age, experience, salaty)
        {
            this.department = department;
            this.formerPlaceOfWork = formerPlaceOfWork;
        }
        public override string ToString()
        {
            return (base.ToString() + $"Отдел: {department} Бывшее место работы: {formerPlaceOfWork}");
        }
    }
    public class Accountant : Person
    {
        private double experienceUsing1С;
        public Accountant(string name, string surname, string patronymic, int age, double experience, int salaty, double experienceUsing1C) : base(name, surname, patronymic, age, experience, salaty)
        {
            this.experienceUsing1С = experienceUsing1C;
        }
        public override string ToString()
        {
            return (base.ToString() + $"Опыт использования 1С: {experienceUsing1С}");
        }
    }
    public class Person
    {
        private string name;
        private string surname;
        private string patronymic;
        public int age { get; } //проверку на возраст
        public string post { get; } //проверку на возраст
        public double experience { get; } //проверку на возраст
        public int salaty { get; } //проверку на возраст
        public Person (string name, string surname, string patronymic, int age, double experience, int salaty)
        {
            this.name = name;
            this.surname = surname;
            this.patronymic = patronymic;
            this.age = age;
            this.post = Convert.ToString(GetType()).Split('.')[1];
            this.experience = experience;
            this.salaty = salaty;
        }
        public string PrintFIO()
        {
            return ($"{surname} {name} {patronymic}");
        }
        public virtual string ToString()
        {
            return ($"Имя: {name} Фамилия: {surname} Отчество: {patronymic} Возраст: {age} Должность: {post} Стаж: {experience} Зарплата: {salaty} ");
        }
    }
}
