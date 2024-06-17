using System;
using System.Collections.Generic;

public class Candidato
{   
    public string nome;
    public float red;
    public float mat;
    public float lin;

    public float notamedia; 

    public Candidato(string nome,float red, float mat, float lin)
    {
        this.nome= nome;
        this.red = red;
        this.mat = mat;
        this.lin = lin;
        this.notamedia = CalcularMedia();
    }

    private float CalcularMedia()
    {
        return (this.mat + this.lin + this.red) / 3;
    }
}

public class Program
{
    public static int Comparar(Candidato x, Candidato y)
    {
        int resultado = y.notamedia.CompareTo(x.notamedia);
        if (resultado == 0)
        {
            resultado = y.red.CompareTo(x.red);
            if (resultado == 0)
            {
                resultado = y.mat.CompareTo(x.mat);
                if (resultado == 0)
                {
                    resultado = y.lin.CompareTo(x.lin);
                }
            }
        }
        return resultado;
    }

    public static void Main(string[] args)
    {
        // Criando uma lista de candidatos
        List<Candidato> candidatos = new List<Candidato>
        {
            new Candidato("Samuel",800,851 ,800),
            new Candidato("Sergio",850,800,800),
            new Candidato("Antonieta",800,800 ,850)
        };

        // Ordenando a lista de candidatos usando a função Comparar
        candidatos.Sort(Comparar);

        // Imprimindo a lista ordenada
        Console.WriteLine("Lista de candidatos ordenada pela maior média de notas:");
        foreach (var candidato in candidatos)
        {
            Console.WriteLine($"Nome:{candidato.nome} \nMat: {candidato.mat}, Lin: {candidato.lin}, Red: {candidato.red}, Média: {candidato.notamedia}");
        }
    }
}
