//Игра угадайка. Программа загадывает случайное число. Пользователь его угадывает.
//Если пользователь дает неправильный ответ, то программа сообщает, больше загаданное число или меньше.
//На отгадывание дается 3 попытки.

Console.Clear();

int randomNumber = new Random().Next(1,5);
int score = 0;
int attempts = 3;
int randomNumberUser =0;
while(score < attempts)
{
    Console.WriteLine("Попробуй угадать число от 1 до 4: ");
    randomNumberUser = Convert.ToInt32(Console.ReadLine());


    if(randomNumberUser != randomNumber)
    {
        if(randomNumberUser > randomNumber)
        {
            Console.WriteLine("Загаданное число меньше вашего!)");
        }
        else
        {
            Console.WriteLine("Загаданное число больше вашего!)");
            
        }
        if(score == 2)
            {
                    Console.WriteLine("Вы не угадали загаданное число,увы !(");
                    Console.WriteLine("Это было число - " + randomNumber);
            }
    }
    else{
        Console.WriteLine("Вы угадали число, отлично!)");
        score=3;
    }
    score++;

}