// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int PlayerScore = 0;
int EnemyScore = 0;
Random random = new Random();
while(PlayerScore != 3 && EnemyScore != 3)
{
    Console.WriteLine("player score "+PlayerScore +"enemy socre " +EnemyScore);
    Console.WriteLine("choose r for rock ,p for paper,others for scissors");
    char choice=char.Parse(Console.ReadLine());
  int randomChoice= random.Next(0,3);
    if (randomChoice == 0)
    {
        Console.WriteLine("enemy chose rock");
        switch (choice) {
            case 'r':
                Console.WriteLine("tie!");
                break;
            case 'p':
                Console.WriteLine("you are winning");
                PlayerScore++;
                break;
                default:
                Console.WriteLine("you are losing");
                EnemyScore++;
                break;
        }  
    }
    if (randomChoice == 1)
    {
        Console.WriteLine("enemy chose paper");
        switch (choice)
        {
            case 'r':
                Console.WriteLine("you are losing");
                EnemyScore++;

                break;
            case 'p':
                Console.WriteLine("tie!");
                break;
            default:
                Console.WriteLine("you are winning");
                PlayerScore++;
                break;
        }
    }
    if(randomChoice == 2)
    {
        Console.WriteLine("enemy chose scissors");
        switch (choice)
        {
            case 'r':
                Console.WriteLine("you are winning");
                PlayerScore++;
                break;
            case 'p':
                Console.WriteLine("you are losing");
                EnemyScore++;
                break;
            default:
                Console.WriteLine("tie!");
                break;
        }
    }

}

if (PlayerScore == 3)
{
    Console.WriteLine("ypu have won");
}
else
{
    Console.WriteLine("you lost");
}