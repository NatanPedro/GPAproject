using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("GPA Project");

        //declaração de nome do estudante
        Console.WriteLine("Write a student name: ");
        string? name = Console.ReadLine();

        while (name == "")
        {
            Console.WriteLine("ERROR! enter the name again: ");
            name = Console.ReadLine();
            continue;
        }

        Console.WriteLine("Write a student surname: ");
        string? surname = Console.ReadLine();

        while (surname == "")
        {
            Console.WriteLine("ERROR! enter the surname again: ");
            surname = Console.ReadLine();
            continue;
        }
        
        //declaração de notas

        //English
        Console.WriteLine("Write a note for English test: ");
        int eng1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Write a note for second English test: ");
        int eng2 = Convert.ToInt32(Console.ReadLine());

        //Algebra
        Console.WriteLine("Write a note for Algebra test: ");
        int alg1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Write a note for second Algebra test: ");
        int alg2 = Convert.ToInt32(Console.ReadLine());

        //Algorithm
        Console.WriteLine("Write a note for Algorithm test: ");
        int alr1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Write a note for second Algorithm test: ");
        int alr2 = Convert.ToInt32(Console.ReadLine());

        //Computer Science
        Console.WriteLine("Write a note for Computer Science test: ");
        int com1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Write a note for second Computer Science test: ");
        int com2 = Convert.ToInt32(Console.ReadLine());

        //frequencia
        int english_classes = 20;
        int algebra_classes = 40;
        int algorithm_classes = 40;
        int computer_classes = 20;

        //english frequences
        Console.WriteLine("How many absences the student had in the English subject:");
        int engf = Convert.ToInt32(Console.ReadLine());

        //algebra frequences
        Console.WriteLine("How many absences the student had in the Algebra subject:");
        int algf = Convert.ToInt32(Console.ReadLine());

        //algorithm frequences
        Console.WriteLine("How many absences the student had in the Algorithm subject:");
        int alrf = Convert.ToInt32(Console.ReadLine());

        //computer science frequences
        Console.WriteLine("How many absences the student had in the Computer Science subject:");
        int comf = Convert.ToInt32(Console.ReadLine());

        //presenças do estudante
        //English
        int fre1 = english_classes - engf;
        int fre2 = algebra_classes - algf;
        int fre3 = algorithm_classes - alrf;
        int fre4 = computer_classes - comf;

        //Situação do estudante por presenças
        string totalf1 = "Approved";
        if (fre1 <20)
        {
            totalf1 = "Disapproved";
        } else {
            totalf1 = "Approved";
        }

        string totalf2 = "Approved";
        if (fre2 <40)
        {
            totalf2 = "Disapproved";
        } else {
            totalf2 = "Approved";
        }

        string totalf3 = "Approved";
        if (fre3 <40)
        {
            totalf3 = "Disapproved";
        } else {
            totalf3 = "Approved";
        }

        string totalf4 = "Approved";
        if (fre4 <20)
        {
            totalf4 = "Disapproved";
        } else {
            totalf4 = "Approved";
        }

        //calculo das medias
        decimal engm = (eng1 + eng2) / 2m;
        decimal algm = (alg1 + alg2) / 2m;
        decimal alrm = (alr1 + alr2) / 2m;
        decimal comm = (com1 + com2) / 2m;
        
        //Situação do estudante por nota
        string total1 = "Approved";
        if (engm <6m)
        {
            total1 = "Disapproved";
        } else {
            total1 = "Approved";
        }

        string total2 = "Approved";
        if (algm <6m)
        {
            total2 = "Disapproved";
        } else {
            total2 = "Approved";
        }

        string total3 = "Approved";
        if (alrm <6m)
        {
            total3 = "Disapproved";
        } else {
            total3 = "Approved";
        }

        string total4 = "Approved";
        if (comm <6m)
        {
            total4 = "Disapproved";
        } else {
            total4 = "Approved";
        }

        //Situação final do estudante
        string final1 = "Approved";
        if (total1 == "Approved" && totalf1 == "Approved")
        {
            final1 = "Approved by grade and attendance";
        } else if (total1 == "Approved" && totalf1 == "Disapproved")
        {
            final1 = "Failed due to absence";
        } else if (total1 == "Disapproved" && totalf1 == "Approved")
        {
            final1 = "Failed by grade";
        } else {
            final1 = "Failed due to grade and absence";
        }

        string final2 = "Approved";
        if (total2 == "Approved" && totalf2 == "Approved")
        {
            final2 = "Approved by grade and attendance";
        } else if (total2 == "Approved" && totalf2 == "Disapproved")
        {
            final2 = "Failed due to absence";
        } else if (total2 == "Disapproved" && totalf2 == "Approved")
        {
            final2 = "Failed by grade";
        } else {
            final2 = "Failed due to grade and absence";
        }

        string final3 = "Approved";
        if (total3 == "Approved" && totalf3 == "Approved")
        {
            final3 = "Approved by grade and attendance";
        } else if (total3 == "Approved" && totalf3 == "Disapproved")
        {
            final3 = "Failed due to absence";
        } else if (total3 == "Disapproved" && totalf3 == "Approved")
        {
            final3 = "Failed by grade";
        } else {
            final3 = "Failed due to grade and absence";
        }

        string final4 = "Approved";
        if (total4 == "Approved" && totalf4 == "Approved")
        {
            final4 = "Approved by grade and attendance";
        } else if (total1 == "Approved" && totalf1 == "Disapproved")
        {
            final4 = "Failed due to absence";
        } else if (total4 == "Disapproved" && totalf4 == "Approved")
        {
            final4 = "Failed by grade";
        } else {
            final4 = "Failed due to grade and absence";
        }

        //boletim
        Console.WriteLine("\nGrade\n");
        Console.WriteLine($"Studant: {name} {surname}\n");
        Console.WriteLine("Course:\t\t\tGrade:\tSituacion by grade:\tPresences:\tSituacion by presence:\t\tFinal situacion:\n");
        Console.WriteLine($"English\t\t\t{engm}\t{total1}\t\t{fre1}\t\t{totalf1}\t\t\t{final1}");
        Console.WriteLine($"Algebra\t\t\t{algm}\t{total2}\t\t{fre2}\t\t{totalf2}\t\t\t{final2}");
        Console.WriteLine($"Algorithm\t\t{alrm}\t{total3}\t\t{fre3}\t\t{totalf3}\t\t\t{final3}");
        Console.WriteLine($"Computer Science\t{comm}\t{total4}\t\t{fre4}\t\t{totalf4}\t\t\t{final4}\n");
    }
}