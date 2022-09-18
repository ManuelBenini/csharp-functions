﻿#region Functions

void StampaArray(int[] array)
{
    Console.Write("[");

    int i = 0;

    for (i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ",");
    }

    Console.Write(array[i]);

    Console.Write("]");
}

int Quadrato(int numero)
{
    int square = numero * numero;
    return square;
}

int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] arrayCopy = (int[])array.Clone();

    for (int i = 0; i < arrayCopy.Length; i++)
    {
        arrayCopy[i] = Quadrato(arrayCopy[i]);
    }
    return arrayCopy;
}

int sommaElementiArray(int[] array)
{

    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        sum = sum + array[i];
    }

    return sum;
}

#endregion

int[] numbers = {2, 6, 7, 5, 3, 9};

// StampaArray(numbers);

// int square = Quadrato(numbers[4]);

// Console.WriteLine(square);

// int[] squaredNumbers = ElevaArrayAlQuadrato(numbers);

// StampaArray(squaredNumbers);

int sum = sommaElementiArray(numbers);

Console.WriteLine(sum);