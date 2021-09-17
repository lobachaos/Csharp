using System;
namespace Csharp.MetodosEFuncoes{
    class DelegateFuncAnonima{
        delegate string StringOperacao (string s);

        public static void Executar(){

            
            StringOperacao inverter = delegate(string s){
                char[] charrArray = s.ToCharArray();
                Array.Reverse(charrArray);
                return new string(charrArray);
            };

            System.Console.WriteLine(inverter("C# É SHOW !! "));


        }
    }
}