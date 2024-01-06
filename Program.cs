// cast implicito , ocorre quando não declaramos no codigo que essa transformação deve ocorrer, se as variaveis forem compativeis entre si, a tranformação é feita automaticamente

// no exemplo abaiso, uma conversão implicita está acontecendo , onde a variavel do tipo long consegue, perfeitamente e sem perda de informação, acomodar o valor da variavel do tipo int.

// isso acontece porque uma variavel do tipo long é compativel com uma variavel do tipo int , pois int represesenta um numero inteiro em que cabem 32 bits.

// ja o tipo long representa um numero inteiro em que cabem 84 bits, com isso é possivel converter facilmente um tipo int em um tipo long sem perda de informação
// ----------------------------------------------------------------------------

// cast explicito, ao contrario do que ocorreu na transformação de int par long, tentar atribuir o valor de uma variavel do tipo long a uma do tipo inteiro nao pode ocorrer naturalmente, pois os espaços de memoria,agora, não são compativeis

//nesse caso, devemos reealizar a conversão explicita no código, temos varias formas de faze-lo. O mais importante é adicionar a sintaxe (int) para indicar que queremos transformar , mesmo que ocorra perda de informação.

// Outra opção é utilizar o Convert acompanhada do .ToInt32, indicando assim que desejamos realizar uma conversão explícita e, com o .ToInt32, indicamos o tipo para o qual desejamos que a variável seja convertida.

//Nesse caso, o Convert.ToInt32 vai nos avisar de que o número 516144564564654 não cabe em uma variável int, com o seguinte erro:
//Porém, se for possível converter o número, ele vai funcionar sem problemas.
//--------------------------------------------------------------------------

//Conversão de string para números
//podemos converter uma string para um numero inteiro. Essa conversão é bem util e comum em situações reais
//Entretanto, não podemos garantir sempre que uma string terá um conteúdo que possa ser convertido para um número. Se uma variável string for convertida para int, provocará um erro. Nesse caso, dentro da biblioteca Convert, podemos usar a função TryParse sobre os tipos de dados. Essa função tenta converter explicitamente e informa caso não consiga.
// Sua sintaxe é: bool canConvert = Int32.TryParse(userEntry, out valueConverted)
public class Program
{
  public static void Main()
  {
    // implicito
    int someIntNumber = 51;
    long longNumberCast = someIntNumber;

    // Console.WriteLine(longNumberCast);

    //explicito
    // long someLongNumber = 516144066604654; //error
    // int intNumber = someLongNumber;

    // long someLongNumber = 516144564564654;
    // int intNumber = (int)someLongNumber;

    // long someLongNumber = 516144564564654;
    // int intNumber = Convert.ToInt32(someLongNumber);

    long someLongNumber = 42;
    int intNumber = Convert.ToInt32(someLongNumber);

    //Conversão de string para números

    string someString = "42";
    int convertInt = Convert.ToInt32(someString);

  }
}