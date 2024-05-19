namespace RepeticionesWhile.Repeticiones
{
    public class BucleWhile
    {
        public void SumaPromedio() 
        {
            int suma = 0;
            double promedio;
            int contador = 0;

            try
            {
                Console.WriteLine("Por favor, ingrese 10 números:");

                while (contador < 10)
                {
                    Console.Write("Ingrese el número {0}: ", contador + 1);
                    int numero = Convert.ToInt32(Console.ReadLine());
                    suma += numero;
                    contador++;
                }

                promedio = suma / 10.0;

                Console.WriteLine("\nLa suma de los números ingresados es: " + suma);
                Console.WriteLine("El promedio de los números ingresados es: " + promedio);

            }
            catch (Exception ex)
            {

                Console.WriteLine($"Ha ocurrido un error al ingresar los números {ex.Message}");
            }
            
        }
       
        public void FabricaLotes()
        {
            int contador = 0;
            int piezasAptas = 0;
            try
            {
                Console.Write("Por favor, ingrese la cantidad de piezas a procesar: ");
                int cantidadPiezas = Convert.ToInt32(Console.ReadLine());

                while (contador < cantidadPiezas)
                {
                    Console.Write("Ingrese la longitud de la pieza {0}: ", contador + 1);
                    double longitud = Convert.ToDouble(Console.ReadLine());

                    if (longitud >= 1.20 && longitud <= 1.30)
                    {
                        piezasAptas++;
                    }

                    contador++;
                }

                Console.WriteLine("\nLa cantidad de piezas aptas en el lote es: " + piezasAptas);
                Console.ReadLine();
            }
            catch (Exception ex ) 
            {

                Console.WriteLine($"Ha ocurrido un error al ingresar los números {ex.Message}");
            }
            
        }
        
        public void Notas()
        {
            int contador = 0;
            int notasMayores = 0;
            int notasMenores = 0;

            Console.WriteLine("Por favor, ingrese las notas de 10 alumnos:");

            try
            {
                while (contador < 10)
                {
                    Console.Write("Ingrese la nota del alumno {0}: ", contador + 1);
                    double nota = Convert.ToDouble(Console.ReadLine());

                    if (nota >= 7)
                    {
                        notasMayores++;
                    }
                    else
                    {
                        notasMenores++;
                    }

                    contador++;
                }

                Console.WriteLine("\nLa cantidad de alumnos con notas mayores o iguales a 7 es: " + notasMayores);
                Console.WriteLine("La cantidad de alumnos con notas menores a 7 es: " + notasMenores);

            }
            catch (Exception ex)
            {

                Console.WriteLine($"Ha ocurrido un error al ingresar las notas {ex.Message}");
            }
            
        }

        public void Salarios()
        {
            int contador = 0;
            int empleadosEntre100Y300 = 0;
            int empleadosMasDe300 = 0;
            double gastoTotal = 0;

            try
            {
                Console.Write("Por favor, ingrese la cantidad de empleados: ");
                int cantidadEmpleados = Convert.ToInt32(Console.ReadLine());

                while (contador < cantidadEmpleados)
                {
                    Console.Write("Ingrese el sueldo del empleado {0}: ", contador + 1);
                    double sueldo = Convert.ToDouble(Console.ReadLine());

                    if (sueldo >= 100 && sueldo <= 300)
                    {
                        empleadosEntre100Y300++;
                    }
                    else if (sueldo > 300)
                    {
                        empleadosMasDe300++;
                    }

                    gastoTotal += sueldo;
                    contador++;
                }

                Console.WriteLine("\nLa cantidad de empleados que ganan entre $100 y $300 es: " + empleadosEntre100Y300);
                Console.WriteLine("La cantidad de empleados que ganan más de $300 es: " + empleadosMasDe300);
                Console.WriteLine("El gasto total de la empresa en sueldos es: $" + gastoTotal);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Ha ocurrido un error al ingresar los salarios {ex.Message}");

            }
            

        }

    }
}
