void matriz()
{
    //string[] nombre = new string[]
    //{
    //"Anderson","Brandon","Yeimi","Fatima","Vivian"
    //};

    ////for (int i=0;i<nombre.Length;++)
    ////{
    ////    Console.WriteLine("Elemento:"+nombre[i]);
    ////}
    //foreach (string n in nombre)
    //{
    //    Console.WriteLine("nombre: " + n);
    //}
    //int[] notas = new int[]
    //{
    //    50,90,85,73,95
    //};
    //int promedio = 0;
    //foreach (int n in notas)
    //{
    //    promedio = promedio + n;
    //}
    //promedio = promedio / notas.Length;
    //Console.WriteLine("El promedio es igual a: " + promedio);

    //Actualizacion 1

    int al;
    int[] notas1;
    string[] alumnos;

    Console.Write("Cuantos alumnos desea ingresar?: ");
    al = int.Parse(Console.ReadLine());
    string[] alumnos2 = new string[al];
    int[] notas2 = new int[al];

    for (int i = 0; i < al; i++)
    {
        Console.Write("Ingrese el nombre del alumno " + i + ": ");
        alumnos2[i] = Console.ReadLine();
        Console.Write("Ingrese las notas del alumno " + i + ": ");
        notas2[i] = int.Parse(Console.ReadLine());
    }

    int mayor = 0, d = 0, menor1 = 100, d2 = 0;
    int nose = -1, nose2 = -1;
    for (int i = 0; i < notas2.Length; i++)
    {
        if (notas2[i] > mayor)
        {
            mayor = notas2[i];
            nose = d;
        }
        d++;
    }
    for (int i = 0; i < notas2.Length; i++)
    {
        if (notas2[i] < menor1)
        {
            menor1 = notas2[i];
            nose2 = d2;
        }
        d2++;
    }
    Console.WriteLine("-------------------------------------------------------------");
    for (int i = 0; i < alumnos2.Length; i++)
    {
        Console.WriteLine(alumnos2[i] + ": " + notas2[i]);
    }
    Console.WriteLine("-------------------------------------------------------------");
    Console.WriteLine("La nota mas alta es " + mayor + " que le pertenece a " + alumnos2[nose]);
    Console.WriteLine("La nota menor es " + menor1 + " que le pertenece a " + alumnos2[nose2]);
    Console.WriteLine("-------------------------------------------------------------");
}
matriz();
