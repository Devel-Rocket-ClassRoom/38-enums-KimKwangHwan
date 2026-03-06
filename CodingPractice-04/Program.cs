using System;

{
    Animal animal = Animal.Dog;

    switch (animal)
    {
        case Animal.Chicken:
            Console.WriteLine("닭");
            break;
        case Animal.Dog:
            Console.WriteLine("개");
            break;
        case Animal.Pig:
            Console.WriteLine("돼지");
            break;
        default:
            Console.WriteLine("알 수 없는 동물");
            break;
    }
}

enum Animal
{
    Chicken, Dog, Pig
}