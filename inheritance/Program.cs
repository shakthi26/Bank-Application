﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    interface Bank
    {
        
       void GetBranchinfo();
        
        void displayinfo();

        
    }

    interface emp
    {

        void Empdata();
        
    }

    interface ATM 
    {

         void cash();
    }
    class A : Bank,emp,ATM
    {
        string branchcode, branchname, branchaddress;
        int n;
        int empid;
        string empname;
        public void Empdata()
        {
            Console.WriteLine("Enter Employee Details :");
            Console.WriteLine("===============================");
            Console.WriteLine("Enter Employee ID :");
            empid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name :");
            empname = Console.ReadLine();

        }
        public void GetBranchinfo()
        {
            Console.WriteLine("Enter Branch Details :");
            Console.WriteLine("==========================");
            Console.WriteLine("Enter Branch Name :");
            branchname = Console.ReadLine();
            Console.WriteLine("Enter Branch Address :");
            branchaddress = Console.ReadLine();
            Console.WriteLine("Enter Branch Code :");
            branchcode = Console.ReadLine();
        }
        public void displayinfo()

        {

            Console.WriteLine(" Branch Code : {0}, Branch Name : {1}, Branch Address : {2} ", branchcode, branchname, branchaddress);

        }
        public void cash()
        {
            Console.WriteLine("Deposit - 1 / Withdrawal - 2 ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n == 1)
            {
                Console.WriteLine("Amount Deposited");
            }
            if (n == 2)
            {
                Console.WriteLine("Amount Withdrawed");
            }
        }
    }
    class Program 
    {
        static void Main(string[] args)
        {
            A obj = new A();
           
            obj.Empdata();
            
            obj.GetBranchinfo();
            
            obj.displayinfo();
            
            obj.cash();
            Console.ReadKey();
        }
    }
}
