using PROYECTO_11_11.Controllers;
using System;

namespace PROYECTO_11_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables empleados
            int opcion = 0;
            int idEmpleado = 0;
            string nombreEmpleado = string.Empty;
            string apellidoEmpleado = string.Empty;
            string direccion = string.Empty;
            int telefono = 0;
            DateTime fecha = DateTime.Now;
            int idAreaEmpleado = 0;

            //varibales area 
            int idArea = 0;
            string nombreArea = string.Empty;

            //variables nomina
            int idNomina = 0;
            DateTime fechaNomina = DateTime.Now;
            int idEmpleadoNomina = 0;
            int sueldo = 0;
            int diasTrabajados = 0;
            int totalBasico = 0;
            int otros = 0;
            int devengado = 0;

            NominaControllers NC = new NominaControllers();
            EmpleadosControllers EC = new EmpleadosControllers();
            AreasControllers AC = new AreasControllers();


            do
            {
                Console.WriteLine("Entrar a empleados: 1 | Entrar a las areas: 2 | Entrar a nomina: 3 | Salir: 4");
                opcion = Convert.ToInt32(Console.ReadLine());
                if(opcion == 4)
                {
                    Console.Write(" Salió del programa");
                    Console.ReadKey();
                    return;
                }
                
                switch (opcion)
                {
                    #region CASO EMPLEADOS
                    // CASO EMPLEADOS
                    case 1:
                        int opcionEmpleado = 0;
                        Console.WriteLine("Mostrar empleados: 1 | Buscar por id: 2 | Agregar empleado: 3 | Actualizar empleado: 4 | Eliminar empleado: 5");
                        opcionEmpleado = Convert.ToInt32(Console.ReadLine());
                        if (opcionEmpleado == 1)
                        {
                            //TRAER TODA LA LISTA
                            Console.WriteLine("Mostrar empleados");
                            Console.ReadKey();
                            EC.get();
                        }
                        if (opcionEmpleado==2)
                        {
                            //BUSCAR X ID
                            Console.WriteLine("Buscar empleados por Id: ");
                            idEmpleado = Convert.ToInt32(Console.ReadLine());
                            EC.getbyId(idEmpleado);
                        }
                        if (opcionEmpleado == 3)
                        {
                            //AGREGAR UN REGISTRO
                            Console.WriteLine("Presione una tecla para continuar...");
                            Console.ReadKey(true);
                            Console.Clear();
                            Console.WriteLine("Agregar empleado: ");
                            Console.Write("Introduzca Id: ");
                            idEmpleado = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Introduzca Nombre: ");
                            nombreEmpleado = (Console.ReadLine());
                            Console.Write("Introduzca Apellido: ");
                            apellidoEmpleado = (Console.ReadLine());
                            Console.Write("Introduzca Direccion: ");
                            direccion = (Console.ReadLine());
                            Console.Write("Digite telefono: ");
                            telefono = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Digite id area: ");
                            idAreaEmpleado = Convert.ToInt32(Console.ReadLine());
                            EC.post(idEmpleado, nombreEmpleado, apellidoEmpleado, direccion, telefono, fecha, idAreaEmpleado);
                            EC.get();
                        }
                        if (opcionEmpleado == 4)
                        {
                            //ACTUALIZAR
                            Console.WriteLine("Presione una tecla para continuar...");
                            Console.ReadKey(true);
                            Console.Clear();
                            Console.WriteLine("Eliminar empleado: ");
                            Console.Write("Introduzca Id: ");
                            idEmpleado = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Introduzca Nombre: ");
                            nombreEmpleado = (Console.ReadLine());
                            Console.Write("Introduzca Apellido: ");
                            apellidoEmpleado = (Console.ReadLine());
                            Console.Write("Introduzca Direccion: ");
                            direccion = (Console.ReadLine());
                            Console.Write("Digite telefono: ");
                            telefono = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Digite id area: ");
                            idAreaEmpleado = Convert.ToInt32(Console.ReadLine());
                            EC.update(idEmpleado, nombreEmpleado, apellidoEmpleado, direccion, telefono, fecha, idAreaEmpleado);
                            EC.get();
                        }
                        if (opcionEmpleado == 5)
                        {
                            //ELIMINAR
                            Console.WriteLine("Eliminar empleado: ");
                            Console.Write("Introduzca Id: ");
                            idEmpleado = Convert.ToInt32(Console.ReadLine());
                            EC.DeletexId(idEmpleado);
                            EC.get();
                            Console.ReadKey();
                        }
                        break;
                    //FIN CASO EMPLEADOS
                    #endregion

                    #region CASO AREAS
                    //CASO DE AREAS
                    case 2:
                        int opcionAreas = 0;
                        Console.WriteLine("Mostrar areas: 1 | Buscar por id: 2 | Agregar area: 3 | Actualizar area: 4 | Eliminar area: 5");
                        opcionAreas = Convert.ToInt32(Console.ReadLine());
                        if (opcionAreas == 1)
                        {
                            //TRAER TODA LA LISTA
                            Console.WriteLine("Mostrar areas:");
                            Console.ReadKey();
                            AC.get();
                        }
                        if (opcionAreas == 2)
                        {
                            //BUSCAR X ID
                            Console.WriteLine("Buscar area por Id: ");
                            idArea = Convert.ToInt32(Console.ReadLine());
                            AC.getbyId(idArea);
                        }
                        if (opcionAreas == 3)
                        {
                            //AGREGAR UN AREA
                            Console.WriteLine("Presione una tecla para continuar...");
                            Console.ReadKey(true);
                            Console.Clear();
                            Console.WriteLine("Agregar area: ");
                            Console.Write("Introduzca Id: ");
                            idArea = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Introduzca nombre del area: ");
                            nombreArea = (Console.ReadLine());
                            AC.post(idArea, nombreArea);
                            AC.get();
                        }
                        if (opcionAreas == 4)
                        {
                            //ACTUALIZAR UN AREA
                            Console.WriteLine("Presione una tecla para continuar...");
                            Console.ReadKey(true);
                            Console.Clear();
                            Console.WriteLine("Actualizar area: ");
                            Console.Write("Introduzca Id: ");
                            idArea = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Introduzca nombre del area: ");
                            nombreArea = (Console.ReadLine());
                            AC.update(idArea, nombreArea);
                            AC.get();
                        }
                        if(opcionAreas == 5)
                        {
                            //ELIMINAR AREA
                            Console.WriteLine("Eliminar area: ");
                            Console.Write("Introduzca Id: ");
                            idArea = Convert.ToInt32(Console.ReadLine());
                            AC.DeletexId(idArea);
                            AC.get();
                            Console.ReadKey();
                        }
                        break;
                    //FIN CASO DE AREAS
                    #endregion

                    #region CASO NOMINA
                    //CASO DE NOMINA
                    case 3:
                        int opcionNomina = 0;
                        Console.WriteLine("Mostrar nominas: 1 | Buscar por id: 2 | Agregar nomina: 3 | Actualizar nomina: 4 | Eliminar nomina: 5");
                        opcionNomina = Convert.ToInt32(Console.ReadLine());
                        if (opcionNomina == 1)
                        {
                            //TRAER TODA LA LISTA
                            Console.WriteLine("Mostrar nominas:");
                            Console.ReadKey();
                            NC.get();
                        }
                        if (opcionNomina == 2)
                        {
                            //BUSCAR X ID
                            Console.WriteLine("Buscar nomina por Id: ");
                            idNomina = Convert.ToInt32(Console.ReadLine());
                            NC.getbyId(idNomina);
                        }
                        if (opcionNomina == 3)
                        {
                            //AGREGAR UNA NOMINA
                            Console.WriteLine("Presione una tecla para continuar...");
                            Console.ReadKey(true);
                            Console.Clear();
                            Console.WriteLine("Agregar nomina: ");
                            Console.Write("Introduzca Id: ");
                            idNomina = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Introduzca Id empleado: ");
                            idEmpleadoNomina = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Introduzca sueldo: ");
                            sueldo = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Introduzca dias trabajados: ");
                            diasTrabajados = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Introduzca otros ingresos: ");
                            otros = Convert.ToInt32(Console.ReadLine());
                            NC.post(idNomina,fecha, idEmpleadoNomina,sueldo,diasTrabajados,totalBasico,otros,devengado);
                            NC.get();
                        }
                        if (opcionNomina == 4)
                        {
                            //ACTUALIZAR UNA NOMINA
                            Console.WriteLine("Presione una tecla para continuar...");
                            Console.ReadKey(true);
                            Console.Clear();
                            Console.WriteLine("Agregar nomina: ");
                            Console.Write("Introduzca Id: ");
                            idNomina = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Introduzca Id empleado: ");
                            idEmpleadoNomina = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Introduzca sueldo: ");
                            sueldo = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Introduzca dias trabajados: ");
                            diasTrabajados = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Introduzca otros ingresos: ");
                            otros = Convert.ToInt32(Console.ReadLine());
                            NC.update(idNomina, fecha, idEmpleadoNomina, sueldo, diasTrabajados, totalBasico, otros, devengado);
                            NC.get();
                        }
                        if (opcionNomina == 5)
                        {
                            //ELIMINAR AREA
                            Console.WriteLine("Eliminar nomina: ");
                            Console.Write("Introduzca Id: ");
                            idArea = Convert.ToInt32(Console.ReadLine());
                            NC.DeletexId(idNomina);
                            NC.get();
                            Console.ReadKey();
                        }
                        break;
                    //FIN CASO NOMINA
                    #endregion
                }

            } while(opcion!=4);
        }
    }
}
