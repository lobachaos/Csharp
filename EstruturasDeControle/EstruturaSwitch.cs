namespace Csharp.EstruturasDeControle{
    class EstruturaSwitch{
        public static void Executar(){
            System.Console.WriteLine("Avalie meu atendimento de 1 a 5 : ");
            int.TryParse(System.Console.ReadLine(),out int nota);

            switch (nota)
            {
                case 0 :
                System.Console.WriteLine("Horrível");
                break;
                case 1 :
                System.Console.WriteLine("Pessímo");
                break;
                case 2 : 
                System.Console.WriteLine("Ruim");
                break;
                case 3:
                System.Console.WriteLine("Bom");
                break;
                case 4:
                case 5 :
                System.Console.WriteLine("Ótimo");
                break;
                default: System.Console.WriteLine("Nota inválida");
                break;
            }

        }



    }
}