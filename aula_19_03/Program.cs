using System.ComponentModel;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("\nEscreva um programa que identifique se uma pessoa é do sexo masculino ou feminino. Para isso, utilize 1 para Masculino e 2 para feminino.\n");

        int sex;
        Console.WriteLine("\n\ndigite 1 para o sexo masculino\ndigite2 para o sexo feminino\n");

        sex=Convert.ToInt32(Console.ReadLine());

        if(sex==1){
            Console.WriteLine("\nvocê é um homem\n");
        }else if(sex==2){
            Console.WriteLine("\nvocê é uma mulher\n");
        }else{
            Console.WriteLine("\nopção não reconhecida\n");
        }


        Console.WriteLine("Escreva um programa que receba três notas, N1, N2 e N3. Com base nessas três notas calcule a média simples e identifique que o aluno atingiu a nota mínima para passar ou reprovou. A nota mínima para passar é 6.\n");

        double n1,n2,n3,result;

        Console.WriteLine("\n\ndigite sua primeira nota");
        n1=Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\n\ndigite sua segunda nota");
        n2=Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\n\ndigite sua terceira nota");
        n3=Convert.ToDouble(Console.ReadLine());

        result=(n1+n2+n3)/3;
        if(result>=6){
            Console.WriteLine($"\nsua nota foi: {result}\nvocê passou\n");
        }else{
            Console.WriteLine($"\nsua nota foi: {result}\nvocê reprovou\n");
        }


        Console.WriteLine("Ler dois números inteiros e exibir o quociente e o resto da divisão inteira entre eles.\n");
        int number1,number2;

        Console.WriteLine("\ndigite um dividendo inteiro\n");
        number1=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\ndigite um divisor inteiro\n");
        number2=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"\nvocê dividiu {number1} por {number2}\no quociente foi: {number1/number2}\ne o resto foi: {number1%number2}\n");


        Console.WriteLine("Solicitar a idade de uma pessoa em dias e informar na tela a idade em anos, meses e dias.\n");
        int birth,years,mouths,days;

        Console.WriteLine("\ndigite quantos dias de vida você tem\n");
        birth=Convert.ToInt32(Console.ReadLine());

        years=birth/365;
        mouths=(birth%365)/30;
        days=(birth%365)%30;

        Console.WriteLine($"\nvocê tem {years} anos, {mouths} meses, {days} dias de idade\n");


        Console.WriteLine("Escreva um programa que faça a leitura de um valor inteiro (aceitar somente valores entre 1 e 10) e escrever a tabuada de 1 a 10 do valor lido.\n");

        int number;
        Console.WriteLine("\ndigite um número inteiro entre 1 e 10 para ver sua tabuada\n");
        number=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"\na tabuada de {number} é:\n");
        for(int i=1;i<=10;i++){
            Console.WriteLine(number*i);
        }


        Console.WriteLine("Faça um programa que faça a leitura de 10 números e imprimir quantos são pares e quantos são ímpares.\n");
        int pares=0;

        for(int i=0;i<10;i++){
            Console.WriteLine("\ndigite um número inteiro\n");
            number=Convert.ToInt32(Console.ReadLine());
            if((number%2)==0){
                pares++;
            }
        }
        
        Console.WriteLine($"\ndos 10 números que você digitou {pares} eram pares\n");


        Console.WriteLine("Escreva um programa que leia uma letra e mostre se ela é vogal ou consoante.\n");
        
        char letter;

        Console.WriteLine("\ndigite uma letra\n");
        letter=Convert.ToChar(Console.ReadLine());

        switch(letter){
            case 'a':
                Console.WriteLine("\na letra que você digitou é uma vogal\n");
                break;
            case 'e':
                Console.WriteLine("\na letra que você digitou é uma vogal\n");
                break;
            case 'i':
                Console.WriteLine("\na letra que você digitou é uma vogal\n");
                break;
            case 'o':
                Console.WriteLine("\na letra que você digitou é uma vogal\n");
                break;
            case 'u':
                Console.WriteLine("\na letra que você digitou é uma vogal\n");
                break;
            default:
                Console.WriteLine("\na letra que você digitou não é uma vogal\n");
                break;
        }

        Console.WriteLine("Escreva um programa que leia um número correspondente ao dia da semana e mostre o dia da semana. Sendo domingo 1 e sábado 7.\n");
        int dia;

        Console.WriteLine("\ndigite:\n1 para domingo\n2 para segunda\n3 para terça\n4 para quarta\n5 para quinta\n6 para sexta\n7 para sabado\n");
        dia=Convert.ToInt32(Console.ReadLine());

        switch(dia){
            case 1:
                Console.WriteLine("\nhoje é domingo\n");
                break;
            case 2:
                Console.WriteLine("\nhoje é segunda\n");
                break;
            case 3:
                Console.WriteLine("\nhoje é terça\n");
                break;
            case 4:
                Console.WriteLine("\nhoje é quarta\n");
                break;
            case 5:
                Console.WriteLine("\nhoje é quinta\n");
                break;
            case 6:
                Console.WriteLine("\nhoje é sexta\n");
                break;
            case 7:
                Console.WriteLine("\nhoje é sabado\n");
                break;
            default:
                Console.WriteLine("\nopção desconhecida\n");
                break;
        }
        

    }
}