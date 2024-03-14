// TDE c#
using System;

class Program
{
    static void Main()
    {
        // Crie uma variável chamada idade e atribua a ela o valor 35 e exiba o seu valor
        int idade = 35;

        // Exibindo o valor da variável idade
        Console.WriteLine("Minha idade é " + idade);

        //Crie uma variável chamada nome e atribua o valor "Maria" e exiba o seu valor.
        string nome = "Maria";

        // Exibindo o valor da variável nome
        Console.WriteLine("meu nome é " + nome);

        //Crie uma variável chamada altura e atribua a ela o valor 3.45.
        double altura = 3.45;

        // Exibindo o valor da variável altura
        Console.WriteLine("minha altura é " + altura);

        //Crie uma constante chamada ano e atribua a ela o valor 12 e exiba o seu valor
        const int ano = 12;

        // Exibindo o valor da variável ano
        Console.WriteLine("o ano é " + ano);

        //Declare uma variável nota do tipo double como sendo do tipo Nullable type e atribua o valor 7.80 e exiba o seu valor
        double? nota = 7.80;

        //Exibindo o valor da variável ano
        Console.WriteLine("o valor da nota é " + nota);

        //Quais as diferenças entre os tipos por valor e os tipos por referência ?
        //Tipos por valor: Armazenam diretamente seus dados na memória, geralmente na pilha de execução.
        //Tipos por referência: Armazenam uma referência (endereço de memória) para onde os dados estão localizados, geralmente na heap.

        //O que é um nullable type e qual a sua utilidade ?
        //Em C#, um nullable type é representado pela adição de um ponto de interrogação (?) após o tipo de dados normal. Por exemplo, int?, double?, DateTime?, etc.

        //O que é Camel Case ? Dê um exemplo de sua aplicação.
        //Camel Case é uma convenção de nomenclatura de identificadores em que múltiplas palavras são unidas sem espaços, e cada palavra subsequente além da primeira começa com uma letra maiúscula. O nome "Camel Case" deriva do fato de que as letras maiúsculas no meio da identificação se assemelham às corcovas de um camelo.
        //Por exemplo, em Camel Case, "nomeDaVariavel", "idadeDoUsuario", "totalDeProdutos" são todos exemplos válidos, enquanto "Nome da Variavel", "idade do usuario", "total_de_produtos" não seguem a convenção Camel Case.
        //A aplicação do Camel Case é comum na programação, especialmente em linguagens como C#, Java, JavaScript, Python, entre outras. Ele é usado para nomes de variáveis, nomes de métodos, nomes de propriedades e outros identificadores em código fonte.

        //O que é Pascal Case ? Dê um exemplo de sua aplicação
        //Pascal Case é uma convenção de nomenclatura de identificadores em que múltiplas palavras são unidas sem espaços e cada palavra subsequente começa com uma letra maiúscula, incluindo a primeira palavra. O nome "Pascal Case" é uma referência ao fato de que essa convenção é comumente usada em linguagens de programação como Pascal.
        //Por exemplo, em Pascal Case, "NomeDaVariavel", "IdadeDoUsuario", "TotalDeProdutos" são todos exemplos válidos, enquanto "nomeDaVariavel", "idadeDoUsuario", "total_de_produtos" não seguem a convenção Pascal Case.
        //A aplicação do Pascal Case também é comum na programação, principalmente em linguagens como C#, Java, C++, entre outras. Ele é frequentemente utilizado para nomes de classes, métodos públicos, propriedades públicas e outros identificadores que representam elementos de alto nível em um código fonte.

        //Declare duas variáveis x e y como sendo do tipo int e atribua a ela os valores 77 e 66 e a
        //seguir imprima o valor da soma de x com y. (Use o operador aritmético + para realizar a
        //operação de soma)

        int x = 77;
        int y = 66;

        int soma = x + y;

        Console.WriteLine("a soma de x+y é " + soma);

        //Quais os valores padrões dos tipos de dados bool, char, int, double, float, decimal e string.

        // bool: O valor padrão para o tipo bool é false.
        // char: O valor padrão para o tipo char é o caractere Unicode com código 0, que é o caractere nulo '\0'.
        // int: O valor padrão para o tipo int é 0.
        // double: O valor padrão para o tipo double é 0.0.
        // float: O valor padrão para o tipo float é 0.0f.
        // decimal: O valor padrão para o tipo decimal é 0.0m.
        // string: O valor padrão para o tipo string é null.

    }
}


