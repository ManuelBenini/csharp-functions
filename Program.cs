#region Functions


// using System;

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
    return 0;
}

int[] ElevaArrayAlQuadrato(int[] array)
{
    return new int[0];
}

int sommaElementiArray(int[] array)
{
    return 0;
}

#endregion

int[] numbers = {2, 6, 7, 5, 3, 9};

StampaArray(numbers);