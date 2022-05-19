//@autor : Alex Gonzalez 
//fecha: 19-5-2022

//1) Generar un número secreto
//aleatorio con la siguiente instruccion:

//// Genera un numero entero aleatorio de 1 a 20
//int numeroSecreto = new
//Random(DateTime.Now.Millisecond).Next(1, 21);

//2) Pedir al usuario que ingrese un número y que
//intente adivinar el número que eligió la computadora.

//3) Si el numero ingresado por el usuario es mayor
//al número secreto, avisarle que es muy grande y que intente de nuevo y que
//vuelva al paso 2.

//4) Si el numero ingresado es menor al número
//secreto, avisarle que es muy chico, y que intente de nuevo volviendo al paso 2.

//5) Si el número ingresado coincide con el número
//secreto, sacar el siguiente mensaje:

//"Felicitaciones, has adivinado el número
//secreto que era:  [numeroSecreto] "
//"Lo has logrado en [n] intentos!!"

//Y finalizar el programa.

//Nota:
//Obviamente hay que hacer un bucle y crear un contador de intentos.
//Sean honestos con ustedes mismos y usen sus propias neuronas para resolver el problema, y aunque no lo terminen lo importante es intentarlo.

//tengo que hacer commit
//ggggggg

//Genera un numero entero aleatorio de 1 a 20
int numeroSecreto = new
Random(DateTime.Now.Millisecond).Next(1, 21);
int numIntentos = 0;
var numUser = 0;
var numeroAdiv = 0;
do
{
    numIntentos++;
    Console.WriteLine("Usuario ingrese un numero");
    numUser = int.Parse(Console.ReadLine());
    Console.WriteLine("Ahora Usuario intente adivinar el  numero de la computadora" + numeroSecreto);
    numeroAdiv = int.Parse(Console.ReadLine());

    if (numeroAdiv > numeroSecreto)
    {
        Console.WriteLine("Es un numero muy grande , intente de nuevo");
    }
    else if (numeroAdiv < numeroSecreto)
    {
        Console.WriteLine("Es un numero muy chico , intente de nuevo");
    }
    else if (numeroAdiv == numeroSecreto)
    {
        Console.WriteLine($"Felicitaciones, has adivinado el número secreto que era:  {numeroSecreto} Lo has logrado en {numIntentos} intentos!!");
    }
   
} while (numeroAdiv != numeroSecreto);
