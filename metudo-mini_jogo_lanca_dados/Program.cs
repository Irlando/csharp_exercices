/*
Desafio de mini-jogo de dados
Seu desafio é projetar um mini-jogo. O jogo deve selecionar um número alvo que seja um número aleatório entre 
um e cinco (inclusive). O jogador deve lançar um dado de seis lados. Para ganhar, o jogador deve rolar 
um número maior do que o número alvo. No final de cada rodada, o jogador deve ser perguntado se 
gostaria de jogar novamente, e o jogo deve continuar ou terminar de acordo.
Neste desafio, você recebe um código inicial. Você deve determinar quais métodos criar, seus parâmetros e seus tipos de retorno.
*/

Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay())
{
    PlayGame();
}

bool ShouldPlay()
{
    string response = Console.ReadLine();
    return response.ToLower().Equals("y");
}

void PlayGame()
{
    var play = true;

    while (play)
    {
        var target = GetTarget();
        var roll = RollDice();

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(roll, target));
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}

int GetTarget()
{
    return random.Next(1, 6);
}

int RollDice()
{
    return random.Next(1, 7);
}

string WinOrLose(int roll, int target)
{
    if (roll > target)
    {
        return "You win!";
    }
    return "You lose!";
}