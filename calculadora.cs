using System;

class calculadora{

    static void Main(){

        float numero1, numero2, resultado;
        numero1 = numero2 = resultado = 0;
        string opcao;

        Console.WriteLine("\n\nPROJETO CALCULADORA!");
        
        Console.Write("\n");
        Console.WriteLine("***ESCOLHA QUAL OPERAÇÃO DESEJA***\n");

        Console.WriteLine(" [1] Soma \n [2] Subtração \n [3] Multiplicação \n [4] Divisão");
        Console.Write("\nEscolha: ");
        opcao = Console.ReadLine();

        switch(opcao){

            case "1":
                opcao ="Soma";
                Console.Write("\nDigite o numero 1: ");
                numero1 = float.Parse(Console.ReadLine());

                Console.Write("\nDigite o numero 2: ");
                numero2 = float.Parse(Console.ReadLine());

                resultado = numero1 + numero2;

                Console.Write("\n\n\n");
                Console.Write("Opção escolhida: {0} \n\nResultado: {1}\n\n",opcao, resultado);

                break;

            case "2":
                opcao ="Subtração";
                Console.Write("\nDigite o numero 1: ");
                numero1 = float.Parse(Console.ReadLine());

                Console.Write("\nDigite o numero 2: ");
                numero2 = float.Parse(Console.ReadLine());

                resultado = numero1 - numero2;

                Console.Write("\n\n\n");
                Console.Write("Opção escolhida: {0} \n\nResultado: {1}\n\n",opcao, resultado);

                break;

            case "3":
                opcao ="Multiplicação";
                Console.Write("\nDigite o numero 1: ");
                numero1 = float.Parse(Console.ReadLine());

                Console.Write("\nDigite o numero 2: ");
                numero2 = float.Parse(Console.ReadLine());

                resultado = numero1 * numero2;

                Console.Write("\n\n\n");
                Console.Write("Opção escolhida: {0} \n\nResultado: {1}\n\n",opcao, resultado);

                break;

            case "4":
                opcao ="Divisão";
                Console.Write("\nDigite o numero 1: ");
                numero1 = float.Parse(Console.ReadLine());

                Console.Write("\nDigite o numero 2: ");
                numero2 = float.Parse(Console.ReadLine());

                resultado = numero1 / numero2;

                Console.Write("\n\n\n");
                Console.Write("Opção escolhida: {0} \n\nResultado: {1}\n\n",opcao, resultado);

                break;

            default:
                Console.WriteLine("\n***OPERAÇÃO MATEMÁTICA INVÁLIDA***\n");
                break;

        }
        
    }

}