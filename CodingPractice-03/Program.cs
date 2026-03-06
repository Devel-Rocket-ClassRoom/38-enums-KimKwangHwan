using System;

{
    Console.WriteLine((int)Animal.Horse);
    Console.WriteLine((int)Animal.Sheep);
    Console.WriteLine((int)Animal.Monkey);
}

{
    CharacterStatus status = CharacterStatus.Poison | CharacterStatus.Paralyzed;
    Console.WriteLine(status);
}

{
    CharacterStatus status = CharacterStatus.Poison | CharacterStatus.Confused;

    if ((status & CharacterStatus.Poison) != 0)
    {
        Console.WriteLine("캐릭터가 독에 걸렸습니다!");
    }
    if ((status & CharacterStatus.Paralyzed) != 0)
    {
        Console.WriteLine("캐릭터가 마비되었습니다!");
    }
    else
    {
        Console.WriteLine("마비 상태가 아닙니다.");
    }
}

{
    CharacterStatus status = CharacterStatus.Poison;
    Console.WriteLine($"초기 상태: {status}");

    status |= CharacterStatus.Confused;
    Console.WriteLine($"혼란 추가: {status}");

    status &= ~CharacterStatus.Poison;
    Console.WriteLine($"독 제거: {status}");

    status ^= CharacterStatus.Invisible;
    Console.WriteLine($"투명 토글: {status}");
}

{
    BuffStatus playerBuff = BuffStatus.None;
    void ApplyBuff(BuffStatus buff)
    {
        playerBuff |= buff;
    }
}

enum Animal
{
    Horse, Sheep = 5, Monkey
}

[Flags]
enum CharacterStatus
{
    None = 0,
    Poison = 1,
    Paralyzed = 1 << 1,
    Confused = 1 << 2,
    Invisible = 1 << 3
}

[Flags]
enum BuffStatus
{
    None = 0,
    AttackUp = 1,
    DefenseUp = 1 << 1,
    SpeedUp = 1 << 2,
    All = AttackUp | DefenseUp | SpeedUp
}

