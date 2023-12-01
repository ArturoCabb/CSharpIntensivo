using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winformss
{
    public partial class Form1 : Form
    {
        private string apiURL;
        private HttpClient httpClient;
        private CancellationTokenSource cancellationTokenSource;

        public Form1()
        {
            InitializeComponent();
            apiURL = "https://localhost:7114/";
            httpClient = new HttpClient();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void btnIniciar_Click(object sender, EventArgs e)
        {
            cancellationTokenSource = new CancellationTokenSource();
            cancellationTokenSource.CancelAfter(TimeSpan.FromSeconds(30));
            loadingGIF.Visible = true;
            pgProcesamiento.Visible = true;
            var stopWatch = new Stopwatch();
            Console.WriteLine("Inicio");
            /*var token = cancellationTokenSource.Token;
            var nombres = new string[] { "Felipe", "Claudia", "Antonio", "Alexandria" };
            var tareasHTTP = nombres.Select(x => ObtenerSaludo(x, token));
            var tarea = await Task.WhenAny(tareasHTTP);
            var contenido = await tarea;
            Console.WriteLine(contenido.ToUpper());
            cancellationTokenSource.Cancel();
            var reportarprogreso = new Progress<int>(Reportarprogresotarjetas);
            stopWatch.Start();
            await Esperar();
            var nombre = txtInput.Text;
            try
            {
                var tarjetas = await ObtenerTarjetasDeCredito(250, cancellationTokenSource.Token);
                //var saludo = await ObtenerSaludoConDelay(nombre);
                //MessageBox.Show(saludo);
                await ProcesarTarjetas(tarjetas, reportarprogreso, cancellationTokenSource.Token);
            } catch (HttpRequestException ex)
            {
                MessageBox.Show(ex.Message);
            } catch (TaskCanceledException ex)
            {
                MessageBox.Show("La operación también ha sido cancelada");
            }
            MessageBox.Show($"Operacion finalizada en {stopWatch.ElapsedMilliseconds / 1000.0} segundos");
            */

            /*btnCancelar.Text = "antes";
            CheckForIllegalCrossThreadCalls = true;
            await Task.Delay(1000).ConfigureAwait(continueOnCapturedContext: false);
            var reintentos = 3;
            var tiempoEspera = 500;
            await Reintentar(ProcesarSaludo);
            try
            {
                var contenido = await Reintentar(async () =>
                {
                    using (var respuesta = await httpClient.GetAsync($"{apiURL}saludos/Arturo"))
                    {
                        respuesta.EnsureSuccessStatusCode();
                        return await respuesta.Content.ReadAsStringAsync();
                    }
                });
                Console.WriteLine(contenido);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Excepción atrapada");
            }*/

            /*var tareasHTTP = nombres.Select(x =>
            {
                Func<CancellationToken, Task<string>> funcion = (ct) => ObtenerSaludo(x, ct);
                return funcion;
            });
            var contenido = await EjecutarUno(tareasHTTP);
            Console.WriteLine(contenido.ToUpper());

            var contenido = await EjecutarUno(
                (ct) => ObtenerSaludo("Arturo", ct),
                (ct) => ObtenerAdios("Claudia", ct));
            Console.WriteLine(contenido.ToUpper());*/

            /*var tarea = EvaluarValor(txtInput.Text);
            Console.WriteLine($"Is completed: {tarea.IsCompleted}");
            Console.WriteLine($"Is canceled: {tarea.IsCanceled}");
            Console.WriteLine($"Is faulted: {tarea.IsFaulted}");
            try
            {
                await tarea;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Excepción: {ex.Message}");
                throw;
                }*/

            /*cancellationTokenSource = new CancellationTokenSource();
            try
            {
                var resultado = await task.run(async () =>
                {
                    await task.delay(5000);
                    return 7;
                }).withcancellation(cancellationtokensource.token);
                console.writeline(resultado);
            }
            catch (exception ex)
            {
                console.WriteLine(ex.Message);
            } finally { cancellationTokenSource.Dispose(); }*/

            /*try
            {
                await foreach (var nombre in GenerarNombres(cancellationTokenSource.Token))
                {
                    Console.WriteLine(nombre);
                }
            }
            catch (TaskCanceledException)
            {

                Console.WriteLine("Operación Cancelada");
            }
            finally
            {
                cancellationTokenSource?.Dispose();
            }*/

            /*var nombresEnumerable = GenerarNombres();
            await ProcesarNombres(nombresEnumerable);

            Anti - Patrón: Síncrono dentro de asíncrono
            var valor = ObtenerValor().Result; // Result está bloquendo el UI
            por lo que se tiene que usar la segunda solución
             Una solución
            var valor = await ObtenerValor(); // Solución ideal
            Console.WriteLine(valor);*/

            /*Se podría usar await await o
            var resultadosStartNew = await Task.Factory.StartNew(async () =>
            {
                await Task.Delay(1000);
                return 7;
            }).Unwrap();//.Unwrap();*/

            /*var resultadoRun = await Task.Run(async () =>
            {
                await Task.Delay(1000);
                return 7;
            });
            Console.WriteLine($"Resultado StartNew: {resultadosStartNew}");
            Console.WriteLine($"Resultado Task.Run: {resultadoRun}");*/

            /*var directorioActual = AppDomain.CurrentDomain.BaseDirectory;
            var destinoBaseSecuencial = Path.Combine(directorioActual, @"Images\resultado-secuencial");
            var destinoBaseParalelo = Path.Combine(directorioActual, @"imagenes\resultado-paralelo");
            PrepararEjecucion(destinoBaseSecuencial, destinoBaseParalelo);*/

            /*var IMAGENES = ObtenerImagenes();
            // Parte secuencial
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            foreach (var imagen in IMAGENES)
            {
                await ProcesarImagen(destinoBaseSecuencial, imagen);
            }
            var tiempoSecuencial = stopWatch.ElapsedMilliseconds / 1000.0;
            Console.WriteLine("Secuencial - duración en segundos: {0}", tiempoSecuencial);
            // Parte paralelo
            stopWatch.Restart();
            var tareasEnumerable = IMAGENES.Select(async imagen => await ProcesarImagen(destinoBaseParalelo, imagen));
            await Task.WhenAll(tareasEnumerable);
            var tiempoEnParalelo = stopWatch.ElapsedMilliseconds / 1000.0;
            Console.WriteLine("Paralelo - duración en segundos: {0}", tiempoEnParalelo);
            EscribirComparacion(tiempoSecuencial, tiempoEnParalelo);*/

            /*Console.WriteLine("Secuencial");
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("En paralelo");
            Parallel.For(0, 11, i => Console.WriteLine(i));*/

            /*// Voltear imagenes
            var directorioActual = AppDomain.CurrentDomain.BaseDirectory;
            var carpetaOrigen = Path.Combine(directorioActual, @"Imagenes\resultado-secuencial");
            var carpetaDestinoSecuencial = Path.Combine(directorioActual, @"Imagenes\foreach-secuencial");
            var carpetaDestinoParalelo = Path.Combine(directorioActual, @"Imagenes\foreach-paralelo");
            PrepararEjecucion(carpetaDestinoSecuencial, carpetaDestinoParalelo);
            var archivos = Directory.EnumerateFiles(carpetaOrigen);
            Action multiplicarMatrices = () => Matrices.MultiplicarMatricesSecuencial(matrizA, matrizB, resultado);
            Action voltearImagenes = () =>
            {
                foreach (var archivo in archivos)
                {
                    VoltearImagen(archivo, carpetaDestinoParalelo);
                }
            };
            Action[] acciones = new Action[] { multiplicarMatrices, voltearImagenes };
            // Comparar secuencial
            stopWatch.Restart();
            stopWatch.Start();
            foreach (var accion in acciones)
            {
                accion();
            }
            tiempoSecuencial = stopWatch.ElapsedMilliseconds / 1000.0;
            Console.WriteLine("Secuencial - duraión en segundos: {0}", tiempoSecuencial);
            PrepararEjecucion(carpetaDestinoSecuencial, carpetaDestinoParalelo);
            stopWatch.Restart();
            // En paralelo
            Parallel.Invoke(acciones);*/

            /*for (int i = 0; i < 17; i++)
            {
                await RealizarPruebaMatrices(i);
            }*/

            /*var valorSinInterlocked = 0;
            Parallel.For(0, 1000000, numero => valorSinInterlocked++);
            Console.WriteLine("Sumatoria sin interlocked: {0}", valorSinInterlocked);
            var valorConInterlocked = 0;
            Parallel.For(0, 1000000, numero => Interlocked.Increment(ref valorConInterlocked));
            Console.WriteLine("Sumatoria con interlocked: {0}", valorConInterlocked);*/

            /*var valorIncrementado = 0;
            var valorSumado = 0;
            var mutex = new object(); // permite que solo ese objeto pueda manipular las variables
            Parallel.For(0, 10000, numero =>
            {
                //Interlocked.Increment(ref valorIncrementado);
                //Interlocked.Add(ref valorSumado, valorIncrementado);// Ocurre el error porque ambas son atómicas
                lock (mutex)
                {
                    valorIncrementado++;
                    valorSumado += valorIncrementado;
                }
            });
            Console.WriteLine("----");
            Console.WriteLine($"Valor incrementado: {valorIncrementado}");
            Console.WriteLine($"Valor sumado: {valorSumado}");*/

            /*var fuente = Enumerable.Range(1, 10000);
            var elementosPares = fuente.AsParallel().AsOrdered().WithDegreeOfParallelism(2).WithCancellation(cancellationTokenSource.Token).Where(x => x % 2 == 0).ToList();
            foreach ( var numero in elementosPares)
            {
                Console.WriteLine(numero);
            }*/

            /*// Operaciones de agregado
            var fuente = Enumerable.Range(1, 1000);
            var suma = fuente.AsParallel().Sum();
            var promedio = fuente.AsParallel().Average();
            Console.WriteLine("La suma es: {0}\nEl promedio es: {1}", suma, promedio);*/

            // PLINQ
            /*var matrices = Enumerable.Range(1, 500).Select(x => Matrices.InicializarMatriz(1000, 1000)).ToList();
            Console.WriteLine("Matrices generadas");
            stopWatch.Start();
            var sumaMatricesSecuencial = matrices.Aggregate(Matrices.SumarMatricesSecuencial);
            var tiempoSecuencial = stopWatch.ElapsedMilliseconds / 1000.0;
            Console.WriteLine("Secuencial - duración en segundos: {0}", tiempoSecuencial);
            stopWatch.Restart();
            var sumaMatricesParalelo = matrices.AsParallel().Aggregate(Matrices.SumarMatricesSecuencial);
            var tiempoParalelo = stopWatch.ElapsedMilliseconds / 1000.0;
            Console.WriteLine("Paralelo - duración en segundos: {0}", tiempoParalelo);
            EscribirComparacion(tiempoSecuencial, tiempoParalelo);*/

            /*var queryParalelo = Enumerable.Range(1, 10).AsParallel().WithDegreeOfParallelism(2).Select(x => Matrices.InicializarMatriz(100, 100));
            //foreach (var matriz in queryParalelo)
            //{
            //    Console.WriteLine(matriz[0,0]);
            //}
            queryParalelo.ForAll(matriz => Console.WriteLine(matriz[0,0]));*/

            stopWatch.Stop();
            Console.WriteLine("Fin");
            Console.WriteLine();
            btnCancelar.Text = "despues";
            loadingGIF.Visible = false;
            pgProcesamiento.Visible = false;
            pgProcesamiento.Value = 0;
            cancellationTokenSource = null;
        }

        private async Task RealizarPruebaMatrices(int maximoGradoParalelismo)
        {
            var columnasMatrizA = 1100;
            var filas = 1000;
            var columnasMatrizB = 1750;
            var matrizA = Matrices.InicializarMatriz(filas, columnasMatrizA);
            var matrizB = Matrices.InicializarMatriz(columnasMatrizA, columnasMatrizB);
            var resultado = new double[filas, columnasMatrizB];
            cancellationTokenSource = new CancellationTokenSource();
            var stopWatch = new Stopwatch();
            //await Task.Run(() => Matrices.MultiplicarMatricesSecuencial(matrizA, matrizB, resultado));
            //var tiempoSecuencial = stopWatch.ElapsedMilliseconds / 1000.0;
            //Console.WriteLine("Secuencial - duración en segundos: {0}", tiempoSecuencial);
            //resultado = new double[filas, columnasMatrizB];
            stopWatch.Restart();
            // Esto es para cancelar paralelismo
            try
            {
                await Task.Run(() => Matrices.MultiplicarMatricesParalelo(matrizA, matrizB, resultado, cancellationTokenSource.Token, maximoGradoParalelismo));
                Console.WriteLine($"Maximo grado: {maximoGradoParalelismo}; tiempo: {stopWatch.ElapsedMilliseconds / 1000.0}");
            }
            catch (Exception)
            {
                Console.WriteLine("Operacion cancelada");
            }
            finally
            {
                cancellationTokenSource.Dispose();
            }
            //var tiempoEnParalelo = stopWatch.ElapsedMilliseconds / 1000.0;
            //Console.WriteLine("Paralelo - duracion en segundos: {0}", tiempoEnParalelo);
            //EscribirComparacion(tiempoSecuencial, tiempoEnParalelo);
        }

        private void VoltearImagen(string archivo, string carpetaDestino)
        {
            using (var image = new Bitmap(archivo))
            {
                image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                var nombreArchivo = Path.GetFileName(archivo);
                var destino = Path.Combine(carpetaDestino, nombreArchivo);
                image.Save(destino);
            }
        }

        private void EscribirComparacion(double tiempo1, double tiempo2)
        {
            var diferencia = tiempo2 - tiempo1;
            diferencia = Math.Round(diferencia, 2);
            var incrementoPorcentual = ((tiempo2 - tiempo1) / tiempo1) * 100;
            incrementoPorcentual = Math.Round(incrementoPorcentual, 2);
            Console.WriteLine($"Diferencia {diferencia} ({incrementoPorcentual}%)");
        }

        private async Task ProcesarImagen(string directorio, Imagen imagen)
        {
            var response = await httpClient.GetAsync(imagen.URL);
            var content = await response.Content.ReadAsByteArrayAsync();

            Bitmap bitmap;
            using (var ms = new MemoryStream(content))
            {
                bitmap = new Bitmap(ms);
            }

            bitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
            var destino = Path.Combine(directorio, imagen.Nombre);
            bitmap.Save(destino);
        }

        private static List<Imagen> ObtenerImagenes()
        {
            var imagenes = new List<Imagen>();
            for (int i = 0; i < 5; i++)
            {
                {
                    imagenes.Add(
                    new Imagen()
                    {
                        Nombre = $"Spider-Man Spider-Verse {i}.jpg",
                        URL = "https://m.media-amazon.com/images/M/MV5BMjMwNDkxMTgzOF5BMl5BanBnXkFtZTgwNTkwNTQ3NjM@._V1_UY863_.jpg"
                    });
                    imagenes.Add(

                    new Imagen()
                    {
                        Nombre = $"Spider-Man Far From Home {i}.jpg",
                        URL = "https://m.media-amazon.com/images/M/MV5BMGZlNTY1ZWUtYTMzNC00ZjUyLWE0MjQtMTMxN2E3ODYxMWVmXkEyXkFqcGdeQXVyMDM2NDM2MQ@@._V1_UY863_.jpg"
                    });
                    imagenes.Add(

                    new Imagen()
                    {
                        Nombre = $"Moana {i}.jpg",
                        URL = "https://lumiere-a.akamaihd.net/v1/images/r_moana_header_poststreet_mobile_bd574a31.jpeg?region=0,0,640,480"
                    });
                    imagenes.Add(

                    new Imagen()
                    {
                        Nombre = $"Avengers Infinity War {i}.jpg",
                        URL = "https://img.redbull.com/images/c_crop,x_143,y_0,h_1080,w_1620/c_fill,w_1500,h_1000/q_auto,f_auto/redbullcom/2018/04/23/e4a3d8a5-2c44-480a-b300-1b2b03e205a5/avengers-infinity-war-poster"
                    });
                    //imagenes.Add(

                    //new Imagen()
                    //{
                    //    Nombre = $"Avengers Endgame {i}.jpg",
                    //    URL = "https://hipertextual.com/files/2019/04/hipertextual-nuevo-trailer-avengers-endgame-agradece-fans-universo-marvel-2019351167.jpg"
                    //});
                }
            }

            return imagenes;
        }

        private void PrepararEjecucion(string destinoBaseParalelo, string destinoBaseSecuencial)
        {
            if (!Directory.Exists(destinoBaseParalelo))
            {
                Directory.CreateDirectory(destinoBaseParalelo);
            }

            if (!Directory.Exists(destinoBaseSecuencial))
            {
                Directory.CreateDirectory(destinoBaseSecuencial);
            }

            BorrarArchivos(destinoBaseSecuencial);
            BorrarArchivos(destinoBaseParalelo);
        }

        private void BorrarArchivos(string directorio)
        {
            var archivos = Directory.EnumerateFiles(directorio);
            foreach (var archivo in archivos)
            {
                File.Delete(archivo);
            }
        }

        private async Task<string> ObtenerValor()
        {
            //await Task.Delay(500);
            await Task.Delay(1000).ConfigureAwait(false); // Para la segunda solución
            return "Felipe";
        }

        private async Task ProcesarNombres(IAsyncEnumerable<string> nombresEnumerable)
        {
            cancellationTokenSource = new CancellationTokenSource();
            try
            {
                await foreach (var nombre in nombresEnumerable.WithCancellation(cancellationTokenSource.Token))
                {
                    Console.WriteLine(nombre);
                }
            }
            catch (TaskCanceledException)
            {

                Console.WriteLine("Operación Cancelada");
            }
            finally
            {
                cancellationTokenSource?.Dispose();
            }
        }

        private async IAsyncEnumerable<string> GenerarNombres([EnumeratorCancellation]CancellationToken token = default)
        {
            yield return "Felipe";
            await Task.Delay(2000, token);
            yield return "Claudia";
            yield return "Antonio";
        }
        
        public Task EvaluarValor(string valor)
        {
            var tcs = new TaskCompletionSource<object>(TaskCreationOptions.RunContinuationsAsynchronously);
            if (valor == "1")
            {
                tcs.SetResult(null);
            } else if (valor == "2")
            {
                tcs.SetCanceled();
            }
            else
            {
                tcs.SetException(new ApplicationException($"Valor inválido: {valor}"));
            }
            return tcs.Task;
        }

        private async Task<T> EjecutarUno<T>(IEnumerable<Func<CancellationToken, Task<T>>> funciones)
        {
            var cts = new CancellationTokenSource();
            var tareas = funciones.Select(funcion => funcion(cts.Token));
            var tarea = await Task.WhenAny(tareas);
            cts.Cancel();
            return await tarea;
        }

        private async Task<T> EjecutarUno<T>(params Func<CancellationToken, Task<T>>[] funciones)
        {
            var cts = new CancellationTokenSource();
            var tareas = funciones.Select(funcion => funcion(cts.Token));
            var tarea = await Task.WhenAny(tareas);
            cts.Cancel();
            return await tarea;
        }

        private async Task ProcesarSaludo()
        {
            using (var respuesta = await httpClient.GetAsync($"{apiURL}saludos2/Arturo"))
            {
                respuesta.EnsureSuccessStatusCode();
                var contenido = await respuesta.Content.ReadAsStringAsync();
                Console.WriteLine(contenido);
            }
        }

        private async Task Reintentar(Func<Task> f, int reintentos = 3, int tiempoEspera = 500)
        {
            for (int i = 0; i < reintentos; i++)
            {
                try
                {
                    await f();
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    await Task.Delay(tiempoEspera);
                }
            }
        }
        
        private async Task<T> Reintentar<T>(Func<Task<T>> f, int reintentos = 3, int tiempoEspera = 500)
        {
            for (int i = 0; i < reintentos - 1; i++)
            {
                try
                {
                    return await f();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    await Task.Delay(tiempoEspera);
                }
            }
            return await f();
        }

        private void Reportarprogresotarjetas(int porcentaje)
        {
            pgProcesamiento.Value = porcentaje;
        }

        private Task ProcesarTarjetasMock(List<string> tarjetas, IProgress<int> progress = null, CancellationToken cancellationToken = default)
        {
            return Task.CompletedTask;
        }

        private async Task ProcesarTarjetas(List<string> tarjetas, IProgress<int> progress = null, CancellationToken cancellationToken = default)
        {
            using var semaforo = new SemaphoreSlim(2);
            var tareas = new List<Task<HttpResponseMessage>>();
            var indice = 0;
            tareas = tarjetas.Select(async tarjeta =>
            {
                var json = JsonConvert.SerializeObject(tarjeta);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                await semaforo.WaitAsync();
                try
                {
                    var tareaInterna = await httpClient.PostAsync($"{apiURL}tarjetas", content, cancellationToken);
                    //if(progress != null)
                    //{
                    //    indice++;
                    //    var porcentaje = (double)indice / tarjetas.Count;
                    //    porcentaje = porcentaje * 100;
                    //    var porentajeInt = (int)Math.Round(porcentaje, 0);
                    //    progress.Report(porentajeInt);
                    //}
                    return tareaInterna;
                }
                finally
                {
                    semaforo.Release();
                }
            }).ToList();
            //await Task.Run(() =>
            //{
            //    foreach (var tarjeta in tarjetas)
            //    {
            //        var json = JsonConvert.SerializeObject(tarjeta);
            //        var content = new StringContent(json, Encoding.UTF8, "application/json");
            //        var respuestaTask = httpClient.PostAsync($"{apiURL}tarjetas", content);
            //        tareas.Add(respuestaTask);
            //    }
            //});
            Console.WriteLine("Llegamos");
            //var respuestas = await Task.WhenAll(tareas);
            var respuestasTareas = Task.WhenAll(tareas);
            var tarjetasRechazadas = new List<string>();
            if (progress != null)
            {
                while (await Task.WhenAny(respuestasTareas, Task.Delay(1000)) != respuestasTareas)
                {
                    var tareasCompletadas = tareas.Where(x => x.IsCompleted).Count();
                    var porcentaje = (double)tareasCompletadas / tarjetas.Count;
                    porcentaje = porcentaje * 100;
                    var porentajeInt = (int)Math.Round(porcentaje, 0);
                    progress.Report(porentajeInt);
                }
            }
            var respuestas = await respuestasTareas;
            foreach (var respuesta in respuestas)
            {
                var contenido = await respuesta.Content.ReadAsStringAsync();
                var respuestaTarjeta = JsonConvert.DeserializeObject<RespuestaTarjeta>(contenido);
                if (!respuestaTarjeta.Aprobada)
                {
                    tarjetasRechazadas.Add(respuestaTarjeta.Tarjeta);
                }
            }
            foreach (var tarjeta in tarjetasRechazadas)
            {
                Console.WriteLine(tarjeta);
            }
        }

        private Task<List<string>> ObtenerTarjetasDeCreditoMock(int cantidadDeTarjetas, CancellationToken cancellationToken = default)
        {
            var tarjetas = new List<string>();
            tarjetas.Add("000000001");
            return Task.FromResult(tarjetas);
        }

        private Task ObtenerTareaConError()
        {
            return Task.FromException(new ApplicationException());
        }

        private Task ObtenerTareaCancelada()
        {
            cancellationTokenSource = new CancellationTokenSource();
            return Task.FromCanceled(cancellationTokenSource.Token);
        }
        
        private async Task<List<string>> ObtenerTarjetasDeCredito(int cantidadDeTarjetas, CancellationToken cancellationToken = default)
        {
            return await Task.Run(() =>
            {
                var tarjetas = new List<string>();
                for (int i = 0; i < cantidadDeTarjetas; i++)
                {
                    // 000000000000001
                    tarjetas.Add(i.ToString().PadLeft(16, '0'));
                    Console.WriteLine($"Han sido generadas {tarjetas.Count} tarjetas");
                    if (cancellationToken.IsCancellationRequested)
                    {
                        throw new TaskCanceledException();
                    }
                }
                return tarjetas;
            });
        }

        private async Task Esperar()
        {
            await Task.Delay(TimeSpan.FromSeconds(0));
        }

        private async Task<string> ObtenerSaludo(string nombre)
        {
            using (var respuesta = await httpClient.GetAsync($"{apiURL}saludos/{nombre}"))
            {
                respuesta.EnsureSuccessStatusCode();
                var saludo = await respuesta.Content.ReadAsStringAsync();
                return saludo;
            }
        }
        
        private async Task<string> ObtenerSaludo(string nombre, CancellationToken cancellationToken)
        {
            using (var respuesta = await httpClient.GetAsync($"{apiURL}saludos/delay/{nombre}", cancellationToken))
            {
                var saludo = await respuesta.Content.ReadAsStringAsync();
                Console.WriteLine(saludo);
                return saludo;
            }
        }
        
        private async Task<string> ObtenerAdios(string nombre, CancellationToken cancellationToken)
        {
            using (var respuesta = await httpClient.GetAsync($"{apiURL}saludos/adios/{nombre}", cancellationToken))
            {
                var saludo = await respuesta.Content.ReadAsStringAsync();
                Console.WriteLine(saludo);
                return saludo;
            }
        }

        private async Task<string> ObtenerSaludoConDelay(string nombre)
        {
            using (var respuesta = await httpClient.GetAsync($"{apiURL}saludos/delay/{nombre}"))
            {
                respuesta.EnsureSuccessStatusCode();
                var saludo = await respuesta.Content.ReadAsStringAsync();
                return saludo;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cancellationTokenSource?.Cancel();
        }
    }
}
