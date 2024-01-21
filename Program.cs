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
        Console.WriteLine("Write a note for English test: ");
        int eng1 = Convert.ToInt32(Console.ReadLine());
        /*if (eng1 <=10)
        {
            Console.WriteLine("Note cadastre");
        } else {
            Console.WriteLine("Note invalid!");
            Console.WriteLine("Write a valid note");
        }*/

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
        int english_classes = 40;
        int algebra_classes = 80;
        int algorithm_classes = 80;
        int computer_classes = 40;

        //english frequences
        Console.WriteLine("Write how amny classes the English subject had:");
        int engf = Convert.ToInt32(Console.ReadLine());

        //algebra frequences
        Console.WriteLine("Write how amny classes the Algebra subject had:");
        int algf = Convert.ToInt32(Console.ReadLine());

        //algorithm frequences
        Console.WriteLine("Write how amny classes the Algorithm subject had:");
        int alrf = Convert.ToInt32(Console.ReadLine());

        //computer science frequences
        Console.WriteLine("Write how amny classes the Computer Science subject had:");
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

        //boletim
        Console.WriteLine("\nGrade\n");
        Console.WriteLine("Studant: " + name + "\n");
        Console.WriteLine("Course:\t\t\tGrade:\tSituacion per grade:\tPresences:\tSituacion per presence");
        Console.WriteLine($"English\t\t\t{engm}\t{total1}\t\t{fre1}\t\t{totalf1}");
        Console.WriteLine($"Algebra\t\t\t{algm}\t{total2}\t\t{fre2}\t\t{totalf2}");
        Console.WriteLine($"Algorithm\t\t{alrm}\t{total3}\t\t{fre3}\t\t{totalf3}");
        Console.WriteLine($"Computer Science\t{comm}\t{total4}\t\t{fre4}\t\t{totalf4}");
    }
}