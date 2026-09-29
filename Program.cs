using System.Collections;

class Program
{
    public static int tornillos = 0;
    public static int engranajes = 0;
    public static int cables = 0;
    public static int chatarra = 0;
    public static int carbon = 0;
    public static int motor = 0;
    public static int placas = 0;
    public static int torreta = 0;

    /*public static int faltanTornillosMotor= 10-tornillos;
    public static int faltanCablesMotor = 3-cables;
    public static int faltanEngranajesMotor = 5 - engranajes;
    public static int faltanPlacasTorreta = 5 - placas;
    public static int faltanMotoresTorreta = 2 - motor;
    public static int faltanCablesTorreta = 10 - cables;
    public static int faltaChatarraPlaca = 4 - chatarra;
    public static int faltaCarbonPlaca = 2 - carbon;*/
    static void Main()
    {
        while (true) {
            Console.WriteLine("Bienvenido al Sistema de ensamblaje");
            Console.WriteLine("1. Ensamblar");
            Console.WriteLine("2. Obtener piezas");
            Console.WriteLine("3. Ver piezas");
            Console.WriteLine("4. Salir");
            Console.WriteLine("Elija una opcion por favor.");

            int opcion = int.Parse(Console.ReadLine());


            switch (opcion)
            {
                case 1:
                    Ensamblar();
                    break;
                case 2: Obtener(); 
                    break;
                case 3: Ver();
                    break;
                case 4:
                    return;
            }
        }
    }
    static void Ensamblar()
    { 
      
        while (true)
        {
            Console.WriteLine("¿Que deseas ensamblar?");
            Console.WriteLine("1. Motor");
            Console.WriteLine("2. Placa de Acero");
            Console.WriteLine("3. Torreta");
            Console.WriteLine("4. Volver");

            int opcion1 = int.Parse(Console.ReadLine());

            switch (opcion1)
            {
                case 1:
                    if (tornillos >= 10 && engranajes >= 5 && cables >= 3)
                    {
                        Console.WriteLine("Ha creado un motor!");
                        motor++;
                        tornillos -= 10;
                        engranajes -= 5;
                        cables -= 3;
                    }
                    else
                    {
                        int faltanTornillosMotor = 10 - tornillos;
                        int faltanCablesMotor = 3 - cables;
                        int faltanEngranajesMotor = 5 - engranajes;

                        if (faltanTornillosMotor>0)
                            {
                            Console.WriteLine("Faltan: " + faltanTornillosMotor +" Tornillos");
                        }
                        if(faltanCablesMotor>0)
                            {
                            Console.WriteLine("Faltan: " + faltanCablesMotor + " Cables");
                        }
                        if (faltanEngranajesMotor > 0) 
                        {
                            Console.WriteLine("Faltan: " + faltanEngranajesMotor + " Engrajanes");
                        }
                    }
                    break;

                case 2:
                    if (chatarra >= 4 && carbon >= 2)
                    {
                        Console.WriteLine("Ha creado una placa de acero");
                        placas++;
                        chatarra -= 4;
                        carbon -= 2;
                    }
                    else {
                        int faltaChatarraPlaca = 4 - chatarra;
                        int faltaCarbonPlaca = 2 - carbon;
                        if (faltaChatarraPlaca > 0)
                        {
                            Console.WriteLine("Falta: " + faltaChatarraPlaca + " de Chatarra");
                        }
                        if (faltaCarbonPlaca > 0) {
                            Console.WriteLine("Falta: " + faltaCarbonPlaca + " de Carbon");
                        }
                    }
                    break;

                     case 3:
                    if (motor >= 2 && placas >= 5 && cables >= 10)
                    {
                        Console.WriteLine("Ha creado una torreta de defensa");
                        torreta++;
                        motor -= 2;
                        placas -= 5;
                        cables -= 10;
                    }
                    else
                    {
                        int faltanPlacasTorreta = 5 - placas;
                        int faltanMotoresTorreta = 2 - motor;
                        int faltanCablesTorreta = 10 - cables;
                        if (faltanPlacasTorreta > 0)
                        {
                            Console.WriteLine("Falta: " + faltanPlacasTorreta + " Placas");
                        }
                        if (faltanMotoresTorreta > 0)
                        {
                            Console.WriteLine("Faltan: " + faltanMotoresTorreta + " Motores");

                        }
                        if (faltanCablesTorreta > 0)
                        {
                            Console.WriteLine("Faltan: " + faltanCablesTorreta + " Cables");

                        }
                    }
                        break;
                        
                        case 4:
                    
                        return;
            }
        }
            
    }

    static void Obtener()
        {
            while (true)
            {
                Console.WriteLine("¿Que pieza desea obtener?");
                Console.WriteLine("1. Tornillo");
                Console.WriteLine("2. Engranaje");
                Console.WriteLine("3. Cable");
                Console.WriteLine("4. Chatarra");
                Console.WriteLine("5. Carbon");
                Console.WriteLine("6. Volver");

                int opcion2 = int.Parse(Console.ReadLine());

            switch (opcion2)
            {
                case 1:
                    Console.WriteLine("Se ha añadido 1 tornillo al inventario");
                    tornillos++;
                    break;
                case 2:
                    Console.WriteLine("Se ha añadido 1 engranaje al inventario");
                    engranajes++;
                    break;
                case 3:
                    Console.WriteLine("Se ha añadido 1 cable al inventario");
                    cables++;
                    break;
                case 4:
                    Console.WriteLine("Se ha añadido 1 de chatarra al inventario");
                    chatarra++;
                    break;
                case 5:
                    Console.WriteLine("Se ha añadido 1 de carbon al inventario");
                    carbon++;
                    break;

                case 6:
                    return;
            }
            }

        }

    static void Ver()
    {
        Console.WriteLine("Tienes:\n" +
            "Motores: " + motor + "\n"+
            "Placas de acero: " + placas + "\n"+
            "Torretas Creadas: " + torreta + "\n"+
            "Cables: " + cables + "\n"+
            "Tornillos: " + tornillos + "\n"+
            "Engranajes: " + engranajes + "\n"+
            "Carbon: " + carbon + "\n"+
            "Chatarra: " + chatarra);
        Console.WriteLine("Pulsa 4 para regresar al menu");
        
        int opcionSalir = int.Parse(Console.ReadLine());

        switch (opcionSalir)
        {
            case 4:
                
                return;
        }
    }
}


