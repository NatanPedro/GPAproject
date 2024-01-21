using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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

        //declaração de notas

        //English
        Console.WriteLine("Write a note for English test");
        int eng1 = Convert.ToInt32(Console.ReadLine());
        /*if (eng1 <=10)
        {
            Console.WriteLine("Note cadastre");
        } else {
            Console.WriteLine("Note invalid!");
            Console.WriteLine("Write a valid note");
        }*/

        Console.WriteLine("Write a note for second English test");
        int eng2 = Convert.ToInt32(Console.ReadLine());

        //Algebra
        Console.WriteLine("Write a note for Algebra test");
        int alg1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Write a note for second Algebra test");
        int alg2 = Convert.ToInt32(Console.ReadLine());

        //Algorithm
        Console.WriteLine("Write a note for Algorithm test");
        int alr1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Write a note for second Algorithm test");
        int alr2 = Convert.ToInt32(Console.ReadLine());

        //Computer Science
        Console.WriteLine("Write a note for Computer Science test");
        int com1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Write a note for second Computer Science test");
        int com2 = Convert.ToInt32(Console.ReadLine());

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

        //boletim
        Console.WriteLine("\nGrade\n");
        Console.WriteLine("Studant: " + name + "\n");
        Console.WriteLine("Course:\t\t\tNotes:\tSituacion per note:");
        Console.WriteLine($"English\t\t\t{engm}\t{total1}");
        Console.WriteLine($"Algebra\t\t\t{algm}\t{total2}");
        Console.WriteLine($"Algorithm\t\t{alrm}\t{total3}");
        Console.WriteLine($"Computer Science\t{comm}\t{total4}");
    }
}