/*2) Um empregado recebeu 30% de aumento em sem sálario,
faça um programa que leia o sálario atual, calcule o valor do acréscimo e 
o salário final, apresentando esses valores paro o usuario 



double salarioAtual;
double aumento;


Console.WriteLine("informe o seu atual salário:  ");
salarioAtual = double.Parse(Console.ReadLine());

//porcentagem = valor dividido por 100
// 30% = 30 / 100
aumento = salarioAtual * 30 / 100;


Console.WriteLine("Você obteve um aumento de: " + aumento);
Console.WriteLine( salarioAtual + aumento);

*/

/* 
5) Faça um programa para aprensentar os resultados 
de uma tabuada de um numero digitado. 
( a estrututa de repetição deve variar de 1 a 10)
*/

/*int numeroTabuada;
int contador;

Console.WriteLine("Digite a tabuada que você quer: ");
numeroTabuada = int.Parse(Console.ReadLine());
for(contador = 0; contador <= 10; contador++){
    Console.WriteLine("{0} x {1} = 2", numeroTabuada, contador, numeroTabuada * contador);
}
*/

//Pesquisar ERP

int opcao;

Console.WriteLine("Seja bem vindo ao sistema acadêmico!");
Console.WriteLine("Versão 1.0!");
Console.WriteLine("Desenvolvido pela Faculdade ViciT");
Console.Beep();

do
{

    Console.WriteLine("Digite a opção desejada: ");
    Console.WriteLine("1 - Cadastro de Alunos: ");
    Console.WriteLine("2 - Cadastro de Professores: ");
    Console.WriteLine("3 - Cadastro de Funcionarios: ");
    Console.WriteLine("99 - Sair do Programa: ");
    opcao = int.Parse(Console.ReadLine());



    if (opcao == 1)
    {
        CadastroAluno();

    }

    if (opcao == 2)
    {
        System.Console.WriteLine("Cadastro de Professores: ");
        System.Console.WriteLine("Nome: ");
        System.Console.WriteLine("Email: ");
    }

    if (opcao == 3)
    {
        System.Console.WriteLine("Cadastro de Funcionarios: ");
        System.Console.WriteLine("Nome: ");
        System.Console.WriteLine("Salário: ");
    }

} while (opcao != 99);


//Procedimento
static void CadastroAluno()
{

    string nome;
    string ra;
    string cidade;
    string uf;
    string datNascimento;
    string rg;
    string cpf;
    string email;
    string cep;
    string nomeMae;


    System.Console.WriteLine("Cadastro de Alunos: ");
    System.Console.WriteLine("Nome: ");
    nome = Console.ReadLine();
    System.Console.WriteLine("RA: ");
    ra = Console.ReadLine();
    System.Console.WriteLine("Cidade: ");
    cidade = Console.ReadLine();
    System.Console.WriteLine("UF: ");
    uf = Console.ReadLine();
    System.Console.WriteLine("Dat.Nascimento: ");
    datNascimento = Console.ReadLine();
    System.Console.WriteLine("RG: ");
    rg = Console.ReadLine();
    System.Console.WriteLine("CPF: ");
    cpf = Console.ReadLine();
    System.Console.WriteLine("Email: ");
    email = Console.ReadLine();
    System.Console.WriteLine("CEP: ");
    cep = Console.ReadLine();
    System.Console.WriteLine("Nome da Mãe: ");
    nomeMae = Console.ReadLine();
}

Console.ReadKey();

