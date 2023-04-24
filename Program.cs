// Criar classe Aluno

// 	- Propriedades: Nome, Curso, Idade, RG,
// 	Bolsista (boolean), Média Final e Valor da Mensalidade. 

// 	- Metodos: VerMediaFinal() e VerMensalidade()

// 	- OUTRO METODO caso seja bolsista faremos o cálculo da mensalidade.

// No program

// Receber todos os dados do aluno por console e armazenar na classe.

// Usar if e else para fazer isso:
// 	- bolsista e média final maior ou igual a 8 conceder 50% de desconto na mensalidade
// 	- bolsista e média final maior que 6 e menor que 8 conceder 30% de desconto na mensalidade 
// 	- outros casos a mensalidade será integral
// ------------------------------------------------------------------------------------------------

using ExecicioMensalidade.Aluno;

Aluno aluno1 = new Aluno();

bool escolha2 = true;
double mensalidadeComDesconto;

Console.WriteLine($"Digite o nome do aluno:");
aluno1.nome = Console.ReadLine();

Console.WriteLine($"Digite o curso:");
aluno1.curso = Console.ReadLine();

Console.WriteLine($"Digite a idade do aluno:");
aluno1.idade = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite o RG do aluno:");
aluno1.RG = int.Parse(Console.ReadLine());

do
{
    Console.WriteLine($"O aluno é bolsista? (Digite 'S' para sim ou 'N' para nao)");
    char escolha1 = char.Parse(Console.ReadLine().ToUpper());

    switch (escolha1)
    {
        case 'S':
        aluno1.bolsista = true;
        escolha2 = true;
        break;

        case 'N':
        aluno1.bolsista = false;
        escolha2 = true;
        break;

        default:
        escolha2 = false;
        break;
    }
} while (escolha2 == false);

Console.WriteLine($"Insira a media final desse aluno:");
aluno1.mediaFinal = double.Parse(Console.ReadLine());

Console.WriteLine($"Insira o valor da mensalidade desse aluno:");
aluno1.valorMensalidade = double.Parse(Console.ReadLine());

if(aluno1.mediaFinal >= 8)
{
    mensalidadeComDesconto = aluno1.valorMensalidade - (aluno1.valorMensalidade*0.5);
    Console.WriteLine($"O valor da mensalidade com desconto: {mensalidadeComDesconto}");
    
}