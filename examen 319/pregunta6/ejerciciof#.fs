// Más información acerca de F# en http://fsharp.net
// Vea el proyecto "Tutorial de F#" para obtener más ayuda.
open System

let suma a b  = a + b

let resta a b = a - b

let multi a b = a * b

let div a b = a / b

[<EntryPoint>]
let main argumentos = 
    Console.WriteLine("Bienvenido a las operaciones basicas, por favor ingrese el primer numero:");
    let num1 = Console.ReadLine()
    Console.WriteLine("Ingrese el segundo numero:")
    let num2 = Console.ReadLine()
    let valor1 = Convert.ToInt32(num1)
    let valor2 = Convert.ToInt32(num2)
    Console.WriteLine();
    let s = suma valor1 valor2 
    Console.WriteLine("La suma es: "+ s.ToString());
    Console.WriteLine();
    let r = resta valor1 valor2
    Console.WriteLine("La resta es: "+r.ToString());
    Console.WriteLine();
    let m = multi valor1 valor2
    Console.WriteLine("La multiplicación es: "+m.ToString());
    Console.WriteLine();
    let d = div valor1 valor2
    Console.WriteLine("La división es: "+d.ToString());
    Console.WriteLine();
    let tecla = Console.ReadKey()
    0 // devolver un código de salida entero
