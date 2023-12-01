// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!"); // Sentencia de alto nivel
//Console.WriteLine("Y");
//Console.Beep(1345, 120);

//int edad = 22;
//int alturaEnCentimetros = 180;
//Console.WriteLine(alturaEnCentimetros);
//int distanciaDeLatierraAlSolEnLikometros = 15_000_000; // Es un separaor como una coma
//Console.WriteLine(distanciaDeLatierraAlSolEnLikometros);
//int numeroSuperGrande = int.MaxValue; // -2 mil millones a 2 mil millones
//Console.WriteLine(numeroSuperGrande);
//byte byte1 = 145; // 0 hasta 255
//Console.WriteLine(byte1);
//sbyte sbyte1 = 100; // -128 hasta 127
//short short1 = 30_000; // -32,768 hasta 32,767
//ushort ushort1 = 65_000; // 0 hasta 65,535
//uint uint1 = 3_000_000_000; // 0 hasta mas o menos 4 mil millones
//long long1 = 8_000_000_000_000; // -9,223,372,036,854,775,808 hasta 9,223,372,036,854,775,807
//ulong ulong1 = 16_000_000_000_000; // 0 hasta 18,446,744,073,709,551,615
//float float1 = 180.123456789f; // Ocupa 4 bytes con precision de 6 a 9 digitos
//double double1 = 180.123456789; // Puedo poner una 45.99d Ocupa 8 bytes con una precision de 15 a 17 digitos
//Console.WriteLine(float1);
//Console.WriteLine(double1);
//decimal decimal1 = 9.99m; // Ocupa 16 bytes precision de 28 a 29 y se recomienda en temas financieros
//Console.WriteLine(decimal1);

//string carta = @"A quien pueda interesar,

//Estimado cliente.
//Att: feliz"; // el @ es un verbatim
//Console.WriteLine(carta);
//// Podemos representar un día en el tiempo
//DateTime ahora = DateTime.Now;
//Console.WriteLine(ahora);
//DateTime primerDia = new DateTime(2022, 1, 1);
//Console.WriteLine(primerDia);
//DateTime mañana = DateTime.Now.AddDays(1);
//Console.WriteLine(mañana);
//Console.WriteLine(mañana.DayOfYear);
//Console.WriteLine(mañana.DayOfWeek);
//// variable Tipadas
//// Estas deben ser inicializadas
//var edades = 999;
//Console.WriteLine(edades);
//var apellido = "Cabb";
//var hoy = DateTime.Now;
//var float2 = 1.9m;
//// Valores por defecto
//int int2 = default;
//int int3 = default(int);
//int2 = 12;
//bool bool2 = default; //false
//Console.WriteLine(bool2);
//DateTime fecha = default;// todo con 0
//Console.WriteLine(fecha);
//string nombre = default;//da null
//// Los tipos de valor se guardan en stack y lo de referencia se guardan en heap
//int? int4 = null; // paso de un tipo de valor a uno de referencia
//// los string son tipos de referencia no nulos
//string? nombre2 = null;
////Console.WriteLine(nombre2.ToLower());
//// double y float generan aproximaciones
//var maximo = int.MaxValue;
//var suma = maximo + 1;
////var suma1 = checked(maximo + 1); devuelve un error
//Console.WriteLine(maximo);
//Console.WriteLine(suma);
////Console.WriteLine(suma1);
////checked
////{
////    var maximo1 = int.MaxValue;
////    var suma2 = maximo + 1;
////}
//// Operaciones unarios
//int cantidad = 7;
//var cantidadPormenos1 = -cantidad;
//cantidad++;
//cantidad--;
//++cantidad;
//--cantidad;

////for (int i = 0; i < 10; i++)
////{
////    if(i == 5)
////    {
////        //break;
////        //continue;
////        //return;
////    }
////}

//// bicle infinito
////for(; ; )
////{

////}

//while (true)
//{
//    Console.WriteLine("Bienvenido");
//    Console.WriteLine("Escriba el primer numero: ");
//    var num = Console.ReadLine();
//    if(num is null)
//    {
//        Console.WriteLine("Error, vuelva a comenzar");
//        continue;
//    }
//    var num1 = decimal.Parse(num);
//    Console.WriteLine("felicidades num");
//    num = Console.ReadLine();
//    if (num != "y")
//    {
//        break;
//    }
//}
//// Uso tryParse
//int numero;
//var pudoParsear = int.TryParse(apellido, out numero);
//if (pudoParsear)
//{
//    numero++;
//    Console.WriteLine(numero);
//}
//else
//{
//    Console.WriteLine($"El valor {apellido} no tiene el formato correcto");
//}

////Enums
//var estatusDeLaVentaDeUnaCamisa = EstatusVenta.PendienteDePago;
//switch (estatusDeLaVentaDeUnaCamisa)
//{
//    case EstatusVenta.Exitoso:
//        Console.WriteLine("La venta fue exitosa");
//        break;
//    case EstatusVenta.PendienteDePago:
//        Console.WriteLine("El cliente debe pagar");
//        break;
//    case EstatusVenta.Cancelada:
//        Console.WriteLine("¿Qué hice paramerecer esto?");
//        break;
//    default:
//        Console.WriteLine("Estatus desconocido");
//        break;
//}
//int estatus3 = 2;
//var estado = (EstatusVenta)estatus3;
//Console.WriteLine(estado);
//// Arreglos
//var primeros6Numeros = new int[] { 1, 2, 3, 4, 5, 6 };
//foreach (var item in primeros6Numeros)
//{
//    Console.WriteLine($"{item}");
//}
//var ultimoNumero = primeros6Numeros[^1]; // regresa el último
//var penultimoNumero = primeros6Numeros[^2]; // regresa el penultimo
//Console.WriteLine(ultimoNumero);
//Console.WriteLine(penultimoNumero);
//var dosPrimeras = primeros6Numeros[..2]; // regresa los primeros 2 en un arreglo
//var tresPrimeras = primeros6Numeros[..3]; // regresa los primeros 3 en un arreglo
//var tresUltimas = primeros6Numeros[3..]; // Lo mismo para los ultimos
//var tresMedias = primeros6Numeros[1..3]; // Lo mismo para los de en medio
//var tresMediasV2 = primeros6Numeros[1..^3]; // Lo mismo para los de en medio
//Console.WriteLine(dosPrimeras);
//Console.WriteLine(tresPrimeras);
//// Matriz bidimencional
//int[,] matriz = new int[2, 2];
//Console.WriteLine(matriz.Rank); // 2
//matriz[0,0] = 1;
//matriz[0,1] = 2;
//matriz[1,0] = 3;
//matriz[1,1] = 4;
//var elemento01 = matriz[0, 1]; // 2
//Console.WriteLine(elemento01);
//int[,] matriz2 = new int[,]
//{
//    {5,6 },
//    {7,-5 },
//    {8,9 }
//};
//for (int i = 0; i < matriz.GetLength(0); i++)
//{
//    for (int j = 0; j < matriz.GetLength(1); j++)
//    {
//        Console.Write($"{matriz[i,j]} ");
//    }
//    Console.WriteLine();
//}
//int[][] arregloDeArreglos =
//{
//    new int[]{1,2},
//    new int[]{3,4,5},
//    new int[]{6},
//    new int[]{7,8},
//};
//var segundoElemento = arregloDeArreglos[1];
//foreach (var item in segundoElemento)
//{
//    Console.Write($"{item} ");
//}
//arregloDeArreglos[3] = new int[] { 9, 10, 11 };
//var tercerElemento = arregloDeArreglos[3];
//Console.WriteLine();
//foreach (var item in tercerElemento)
//{
//    Console.Write($"{item} ");
//}
//Console.WriteLine();
//// Pasando un arreglo normal
//double Promedio(int[] numero)
//{
//    var suma = 0.0;
//    foreach (var item in numero)
//    {
//        suma += item;
//    }
//    return suma/numero.Length;
//}
//var promedio1 = Promedio(new int[] { 1, 5, 7, 2 });
//Console.WriteLine("Promedio1: " + promedio1);
//// Ahora usando params
//double Promedio2(params int[] numero)
//{
//    var suma = 0.0;
//    foreach (var item in numero)
//    {
//        suma += item;
//    }
//    return suma / numero.Length;
//}

//var promedio2 = Promedio2(1, 5, 7, 2);
//Console.WriteLine("Promedio2: " + promedio2);
//// Referencia
//void Duplicar(ref int n)
//{
//    n *= 2;
//    Console.WriteLine("El valor de la funcion es: " + n);
//}

//cantidad = 5;
//Duplicar(ref cantidad);
//Console.WriteLine("El valor fuera de la funcion es: " + cantidad);
//// Tipos de referencia
//var numeros = new int[] { 1, 2, 3 };
//void DuplicarArreglo(int[] numeros)
//{
//    for (int i = 0; i < numeros.Length; i++)
//    {
//        numeros[i] *= 2;
//    }
//}

//void ImprimirArreglo(int[] numeros)
//{
//    foreach (var item in numeros)
//    {
//        Console.Write($"{item} ");
//    }
//}
//ImprimirArreglo(numeros);
//Console.WriteLine();
//DuplicarArreglo(numeros);
//ImprimirArreglo(numeros);
//Console.WriteLine();

//// Usando out
//void Duplucar(out int n, int operando = 2)
//{
//    operando *= 2;
//    n = operando;
//    Console.WriteLine("El valor dentro de la funcion es: " + n);
//}

//Duplucar(out cantidad);
//Console.WriteLine("El valor fuera de la funcion es " + cantidad);

//// tupla
////var tupla = (99, 45, "Fluffy");
//(int edad, int edadClaudia, string nombreGato) tupla = (99, 45, "Fluffy");
//Console.WriteLine(tupla);
//Console.WriteLine(tupla.Item1);
//Console.WriteLine(tupla.Item2);
//Console.WriteLine(tupla.Item3);
//Console.WriteLine(tupla.edad);
//Console.WriteLine(tupla.edadClaudia);
//Console.WriteLine(tupla.nombreGato);
//(int duplo, int triplo) DuplicarYTriplicar(int valor)
//{
//    return (valor*2,valor*3);
//}
//cantidad = 10;
//var resultado = DuplicarYTriplicar(cantidad);
//Console.WriteLine("La cantidad es " + cantidad);
//Console.WriteLine("Su duplo es " + resultado.duplo);
//Console.WriteLine("Su triplo es " + resultado.triplo);
//// Funcion local está dentro de una funcion
//void SumarEImprimir()
//{
//    var cantidad = 5;
//    ImprimirValor(cantidad);
//    cantidad++;
//    ImprimirValor(cantidad);
//    void ImprimirValor(int cantidad)
//    {
//        Console.WriteLine("El valor es "+ cantidad);
//    }
//}
//SumarEImprimir();

//// Expresión lambda
//int Sumar(int a, int b) => a + b;
//suma = Sumar(1, 2);

//// Delegados
//Action imprimeMensaje;
//void ImprimirFechaYHora()
//{
//    Console.WriteLine(DateTime.Now.ToString());
//}

//void ImprimirMiNombre()
//{
//    Console.WriteLine("Felipe");
//}
//imprimeMensaje = ImprimirFechaYHora;
//imprimeMensaje();
//imprimeMensaje = ImprimirMiNombre;
//imprimeMensaje();

//void Procesar(Action action)
//{
//    Console.WriteLine("Antes de ejecutar el action");
//    action();
//    Console.WriteLine("Despues de ejecutar el action");
//}
//imprimeMensaje = ImprimirFechaYHora;
//Procesar(imprimeMensaje);
//Console.WriteLine();
//Procesar(ImprimirMiNombre);
//// Funcion void que recibe un parametro
//Action<int> alterarNumero;

//void Sumar1(int valor)
//{
//    valor++;
//    Console.WriteLine("El valor + 1 es ", valor);
//}
//alterarNumero = Sumar1;
//alterarNumero(5); // Y se pone una coma si hay varios parametros de entradas
//// Func que no recibe parametros
//Func<string> retornaString;
//string ObtenerFechaYHoraActual()
//{
//    return DateTime.Now.ToString();
//}
//retornaString = ObtenerFechaYHoraActual;
//string resultado1 = retornaString();
//Console.WriteLine(resultado1);

//void Procesar1(Func<string> productorDeValor)
//{
//    Console.WriteLine("Linea anterior");
//    var valor = productorDeValor();
//    Console.WriteLine("El valor es " + valor);
//    Console.WriteLine("Linea posterior");
//}
//Procesar1(retornaString);
//Console.WriteLine();
//// Func que recibe parametros
//Func<int, string> recibeenteroRetornaString;

//string ObtenerNombreDelMes(int mes)
//{
//    var fecha = new DateTime(2022, mes, 1);
//    return fecha.ToString("MMMM");
//}
//recibeenteroRetornaString = ObtenerNombreDelMes;
//var mayo = recibeenteroRetornaString(5);
//Console.WriteLine(mayo);

//// predicado
//bool EsPar(int n)
//{
//    return n % 2 == 0;
//}
//Predicate<int> predicado = EsPar;
//numero = 4;
//Console.WriteLine($"¿Es {numero} par? {predicado(numero)}");

//// Delegados
//Action action;
//Func<int> func;
//Predicate<int> predicate;

//bool TryParse2(string valor, out int resultaddo)
//{
//    return int.TryParse(valor, out resultaddo);
//}

//TryParseDelegado myTryParse = TryParse2;
//if (myTryParse("12", out cantidad))
//{
//    Console.WriteLine(cantidad);
//}
//delegate bool TryParseDelegado(string valor, out int resultaddo);

//// funciones anonimas ////////////////////////////////////////////////////////////////////
////Action imprimirmensaje2 = () =>
////{
////    Console.WriteLine(DateTime.Now.ToString());
////};
////imprimeMensaje2();

//void ProcesarAnonima(Action accion)
//{
//    Console.WriteLine("Antes de ejecutar la accion");
//    accion();
//    Console.WriteLine("Despues de ejecutar la accion");
//}

//ProcesarAnonima(() =>
//{
//    Console.WriteLine(DateTime.Now.ToString());
//});

//// Funcion anonima que recibe un parametro y retorna un valor
////Func<int, int> duplicar = a => 2 * a;
////var duplicarV2 = (int a) => 2 * a;
////Func<bool, string, int> ejemplo = (bool1, string1) =>
////{
////    return 42;
////};

//var ejemploV2 = (bool bool1, string string1) =>
//{
//    return 42;
//};
//Console.WriteLine(ejemploV2);

////var carro1 = new Carro();
////carro1._marca = "Toyota";
////carro1._año = 2003;

//var calculadora = new Calculadora();
//var resultadoDT = calculadora.CalcularDuploTriplo(5);
////// Ejemplo sin deconstructor
////Console.WriteLine("El valor es " + resultadoDT.Valor);
////Console.WriteLine("El resultado es " + resultadoDT.Duplo);
////Console.WriteLine("El resultado es " + resultadoDT.Triplo);

//// Ejemplo explícita
////int valor, duplo, triplo;
////resultadoDT.Deconstruct(out valor, out duplo, out triplo);
//// Ejemplo forma resumida
////Console.WriteLine("El valor es " + valor);
////Console.WriteLine("El resultado es " + duplo);
////Console.WriteLine("El resultado es " + triplo);
//// Sin usar Deconstruct directamente
////(var valor, var duplo, var triplo) = resultadoDT;
////Console.WriteLine("El valor es " + valor);
////Console.WriteLine("El resultado es " + duplo);
////Console.WriteLine("El resultado es " + triplo);
//// Lo mas resumido posible
//var (valor, duplo, triplo) = resultadoDT; // el _ es para descarte
//Console.WriteLine("El valor es " + valor);
//Console.WriteLine("El resultado es " + duplo);
//Console.WriteLine("El resultado es " + triplo);

//// metodos de extension
//var mensaje = @"Este es un mensaje,
//atentamente: Arturo";
//mensaje = null;
//// Usando metodo de extension
//var cantidadPalabras = mensaje.ContarPalabras(valorPorDefecto:-2);
//Console.WriteLine("Cantidad palabras " + cantidadPalabras);

//// sin usar metodo de extension
//var cantidadPalabrasV2 = ExtensionesString.ContarPalabras(mensaje);
//Console.WriteLine("Cantidad palabras " + cantidadPalabrasV2);

// Patrones simples
//var apellido = "Gavilan";
//if (apellido is { Length: 7})
//{
//    Console.WriteLine("La longitud del string es 7");
//} else if (apellido is { Length: > 7})
//{
//    Console.WriteLine("La longitud es mayor a 7");
//}
//// Patron con varias propiedades
//var carro = new Carro("Toyota");
//carro.Año = 2015;
//switch (carro)
//{
//    case
//    { Marca: "Toyota" or "Hyundai", Año: > 2010 }:
//        Console.WriteLine("Es un caro");
//        break;
//    case
//    { Año: < 2000 }:
//        Console.WriteLine("Te ha durado esa maquina");
//        break;
//}
//// propiedades de propiedades
//if (carro is { Marca.Length: >6})
//{
//    Console.WriteLine("Es un carro con un nombre largo");
//}
//else
//{
//    Console.WriteLine("Es un carro con un nombre corto");
//}

//// Tipo anonimo (clase sin nombre) no se pueden modificar las propiedades
//var persona = new { Nombre = "Felipe", Apellido = "Gavilan", Edad = 999 };
//// Se pueden inferir nombres de propiedades
//var miVariable = "Un valor";
//var carroAnonimo = new { Nombre = "Felipe", Apellido = "Gavilan", Edad = 999, miVariable };
//// Mutacion no destructiva
//var personaMutada = persona with { Edad = 100 };
//Console.WriteLine(personaMutada);

// Implicitos que van en la properties del proyecto
//< ItemGroup >

//        < Using Include = "MiPrimeraApp" />

//    </ ItemGroup >
// y se usa global using MiPrimeraApp igualmente como alternativa

//var calculadora = new Calculadora();
//calculadora.CalcularPi();

//// Structs
//var puntoA = new Punto(3, 4);
//var puntoB = new Punto();
//Console.WriteLine($"La distancia entre el punto A y el punto B es: {puntoA.Distancia(puntoB)}");

//// Records
//var persona1 = new Persona("Felipe", "Gavilan");// { Nombre = " Felipe", Apellido = "Gavilan"};
//var persona2 = new Persona("Felipe", "Gavilan");// { Nombre = " Felipe", Apellido = "Gavilan" };
//var sonIguales = persona1 == persona2;
//Console.WriteLine("¿Son iguales? " + sonIguales);

//var empresa1 = new Empresa("Udemy", 2010);
//// No es inmutable al menos que se ponga struct
//// Para que vuelva a ser inmutable debe ser readonly

//// Mutacion no destructiva
//var empresa2 = empresa1 with { AñoFundacion = 2015 };
//var clase = new ClaseConPropiedadesInmutables()
//{
//    Propiedad1 = 42,
//    Propiedad2 = "Felipe",
//    propiedad3 = true
//};

// Coalescencia ??
//int[]? numeros = new int[] { 1, 2 };
////numeros = null;
//var conteo = numeros?.Length ?? 0; // al evaluar hace que regrese 0
//Console.WriteLine(conteo);
//// Cambiar el valor de una vaiable
//numeros ??= new int[] { };
//Console.WriteLine($"¿Es nulo? {numeros is null}");
//Console.WriteLine($"¿Es un arreglo vacio? {numeros?.Length == 0}");

//Perdonando el nulo
//Persona2.Procesar(null!);

//var carro = new Carro1();
//carro.Marca = "Toyota";
//carro.EncenderRadio();
//var camión = new Camión();
//camión.Marca = "Mercedes";
//var bicicleta = new Bicicleta();
//bicicleta.Marca = "Scott";
//LeerMarca(carro);
//LeerMarca(camión);
//carro.DarReversa();
//camión.DarReversa();
//bicicleta.DarReversa();

//void LeerMarca(Vehículo vehículo)
//{
//    var mensaje = $"Leyendo la marca {vehículo.Marca} del vehículo de tipo {vehículo}";
//    Console.WriteLine(mensaje);
//}

//carro.Acelerar(200);
//Console.WriteLine("La velocidad del carro es: " + carro.Velocidad);
//bicicleta.Acelerar(200);
//Console.WriteLine("La velocidad de la bicicleta es: " + bicicleta.Velocidad);

//var carroString = carro.ToString();
//Console.WriteLine("Carro ToString: " + carroString);

//AceptoCualquierParametro(carro);
//AceptoCualquierParametro(camión);
//AceptoCualquierParametro(42);

//void AceptoCualquierParametro(object objecto)
//{
//    Console.WriteLine("--- Inicio del método ---");

//    //var carro = (Carro)objecto;
//    // con esto hacemo que si falla devuelva nulo
//    //var carro = objecto as Carro;
//    //if (carro is not null) Console.WriteLine("El objeto es un carro");
//    //else Console.WriteLine("El objeto NO es un carro");

//    if (objecto is Carro1 carro)
//    {
//        Console.WriteLine("El objeto es un carro");
//        carro.SonarClaxon();
//    }
//    else if (objecto is Camión camion)
//    {
//        Console.WriteLine("El objeto es un camión");
//        camion.DarReversa();
//    }
//    else if (objecto is int entero)
//    {
//        Console.WriteLine("El objeto es un entero: " + entero);
//    }
//    else
//    {
//        Console.WriteLine("El objeto NO es un carro");
//    }

//    Console.WriteLine("--- Fin del método ---");
//}

// Se puede realizar herencia siempre y cuando hereda de otro record de clase,
// un record no puede heredar de una clase,
// una clase no puede heredar de un record
// y un record struct no puede participar en una relacion de herencia
// Los struct no puede hacer herencia con otro struct

// protected el tipo solo puede ser accedido por codigo del mismo tipo o de un tipo derivado
// protected internal solo puede ser accedido por codigo del mismo proyecto o de una clase derivada del mismo proyecto
// private protected solo puede ser accedido por código del mismo proyecto del mismo tipo o derivado
// al ahcer referencia de biblioteca de clases puedo acceder a los metodos permitidos para ver
//var almacenadorArchivosAzure = new AlmacenadorArchivosAzure();
//var almacenadorArchivosAWS = new AlmaccenadorArchivosAWS();
//var controladorDePeliculas = new ControladorDePeliculas(almacenadorArchivosAzure);

//controladorDePeliculas.GuardarPoster("poster.jpg");
//controladorDePeliculas.BorrarPoster("poster.jpg");

// Laa inyeccion de dependencias nos permite delegar la tarea de instanciar las dependencias de una clase a un cliente de la clase

// Controlador de inversion de controles
//using Microsoft.Extensions.DependencyInjection;
//using Microsoft.Extensions.Hosting;

//var hostBuilder = Host.CreateDefaultBuilder(args);
//hostBuilder = hostBuilder.ConfigureServices(ConfigurarServicios);
//using var host = hostBuilder.Build(); // using aquí nos permite liberar recursos

//var controladorDePeliculas = host.Services.GetRequiredService<ControladorDePeliculas>();

//controladorDePeliculas.GuardarPoster("poster.jpg");
//controladorDePeliculas.BorrarPoster("poster.jpg");

//var otroLugar = host.Services.GetRequiredService<OtroLugar>();
//otroLugar.Procesar();

//void ConfigurarServicios(IServiceCollection services)
//{
//    // Esto hace que cada vez que se llame a IAlmacenadorArchivos se devuelva el AlmaccenadorArchivosAWS
//    services.AddTransient<IAlmacenadorArchivos, AlmaccenadorArchivosAWS>();
//    // Lo que hace es que centraliza y que cuando se pida una instancia de controlador
//    // de películas no solo se instancia el controlador, si no, tambien todas sus dependencias 
//    services.AddTransient<ControladorDePeliculas>();
//    services.AddTransient<OtroLugar>();
//}

// Implementacion por defecto en interfaces
//using Microsoft.Extensions.DependencyInjection;
//using Microsoft.Extensions.Hosting;

//var hostBuilder = Host.CreateDefaultBuilder(args);
//hostBuilder = hostBuilder.ConfigureServices(ConfigurarServicios);
//using var host = hostBuilder.Build(); // using aquí nos permite liberar recursos

//var almacenadorArchivos = host.Services.GetRequiredService<IAlmacenadorArchivos>();
//almacenadorArchivos.Editar("archivo anterior", "archivo nuevo");

//void ConfigurarServicios(IServiceCollection services)
//{
//    // Esto hace que cada vez que se llame a IAlmacenadorArchivos se devuelva el AlmaccenadorArchivosAWS
//    services.AddTransient<IAlmacenadorArchivos, AlmaccenadorArchivosAWS>();
//    // Lo que hace es que centraliza y que cuando se pida una instancia de controlador
//    // de películas no solo se instancia el controlador, si no, tambien todas sus dependencias 
//    services.AddTransient<ControladorDePeliculas>();
//    services.AddTransient<OtroLugar>();
//}

//var v1 = new Vector2D { X = 1, Y = 2 };
//var v2 = new Vector2D { X = 3, Y = 4 };
//var v3 = v1 + v2;
//Console.WriteLine($"Coordenadas del vector {v3.X} y {v3.Y}");

// Excepciones
//try
//{
//	throw new ExcepcionPersonalizada(TipoError.ErrorDelCliente, "Este es un mensaje nuevo de excepcion");
//}
//catch (ExcepcionPersonalizada ex) when (ex.TipoError == TipoError.ErrorDelCliente)
//{
//    Console.WriteLine("Yo puedo manejar nuestra exepcion");
//}

//// Genéricos
//int[] enteros = { 1, 2, 3, 4, 5 };
//string[] nombres = { "Felipe", "Claudia", "Pedro", "Juana" };
//DateTime[] fechas = { DateTime.Today, DateTime.Today.AddDays(1) };

//Console.WriteLine($"Longitud de arreglo de enteros {CalcularLongitudDeArreglo(enteros)}");
//Console.WriteLine($"Longitud de arreglo de enteros {CalcularLongitudDeArreglo(nombres)}");
//Console.WriteLine($"Longitud de arreglo de enteros {CalcularLongitudDeArreglo(fechas)}");

//// La restriccion es con where T: struct/class/new()/notnull/ClaseMiClase, new()
//int CalcularLongitudDeArreglo<T>(T[] arreglo) where T : new()
//{
//    return arreglo.Length;
//}

//T? PrimerElementoOValorporDefecto<T>(T[] arreglo)
//{
//    if (arreglo.Length == 0) return default;

//    return arreglo[0];
//}

//List<int> enterosLista = new List<int> ();
//enterosLista.Add(1);
//enterosLista.Add(5);
//enterosLista.Add(15);
//List<int> enterosLista2 = new() { 1,5,15 };
//enterosLista2.Add(-8);
//var cantidad = enterosLista2.Count;
//enterosLista2[1] = 75;
//enterosLista2.Remove(15);
//enterosLista2.RemoveAt(0);
//enterosLista2.Clear();
//enterosLista2.Sort();

// Diccionario
//Dictionary<string, int> diccionario = new Dictionary<string, int>();
//diccionario.Add("Uo", 1);
//diccionario["Dos"] = 2;
//Console.WriteLine(diccionario["Dos"]);
//var diccionario2 = new Dictionary<string, int>()
//{
//    {"Uno", 1 },
//    {"Dos", 2 },
//};
//var diccionarioParImpar = new Dictionary<string, List<int>>();
//diccionarioParImpar.Add("par", new List<int>());
//diccionarioParImpar.Add("impar", new List<int>());

//for (int i = 1; i <= 10; i++)
//{
//    var llaves = i % 2 == 0 ? "par" : "impar";
//    diccionarioParImpar[llaves].Add(i);
//}
//foreach (var llave in diccionarioParImpar)
//{
//    Console.WriteLine(llave.Key);
//    foreach (var item in llave.Value)
//    {
//        Console.WriteLine($"- {item}");
//    }
//}

//IEnumerable me permite iterar una coleccion

// yield y ejecucion diferida
//var numeros = new List<int> { 1, 2, 3 };
//var numerosCasteadoAEnumerable = numeros.AsEnumerable();
//var enumerableDeNumeros = Primeros3Numeros();
//var primerNumero = enumerableDeNumeros.First();
//var primerosDosElementos = enumerableDeNumeros.Take(2);
//foreach (var valor in primerosDosElementos)
//{
//    Console.WriteLine(valor);
//}
//var todosLosNumeros = enumerableDeNumeros.ToList();
//Console.WriteLine();
//IEnumerable<int> Primeros3Numeros()
//{
//    yield return 1;
//    yield return 2;
//    yield return 3;
//}

//// Esto es para ejecuciones diferidas
//IEnumerable<int> conElValor2 = Sumar2(2).Take(12);
//foreach (var valor in conElValor2)
//{
//    Console.WriteLine(valor);
//}
//// Esto hace un bucle infinito
//IEnumerable<int> Sumar2(int valor)
//{
//    yield return valor;
//    for(; ;)
//    {
//        valor += 2;
//        yield return valor;
//    }
//}
//Comparar personas con IComparable y IComparer

//// LINQ es para realizar consultas
//int[] numeros = Enumerable.Range(1, 16).ToArray();
// esto es LINQ (sintaxis de métodos)
//var numerosPares = numeros.Where(n => n%2==0).ToList();
//var numerosPares2 = (from n in numeros where n % 2 == 0 select n).ToList();
//foreach (var n in numerosPares2)
//{
//    Console.WriteLine(n);
//}

// Ejecucion diferida
int[] numeros = Enumerable.Range(1, 5).ToArray();
var numerosPares = numeros.Where(n =>
{
    Console.WriteLine($"Evaluando si {n} es par");
    return n % 2 == 0;
}).ToList(); // Si pongo el ToList lo hace diferido
foreach (var numero in numerosPares)
{
    Console.WriteLine($"El número {numero} es par");
}
Console.WriteLine();


