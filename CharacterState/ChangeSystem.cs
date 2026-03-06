using System;
using System.Collections.Generic;
using System.Text;
using static Character;

public class ChangeSystem
{
    private Character main_character;

    public ChangeSystem()
    {
        this.main_character = new Character();
    }

    public ChangeSystem(Character character)
    {
        this.main_character = character; 
    }
    public void StateInfo()
    {
        Console.WriteLine("=== 상태 목록 ===");
        string[] stateNames = Enum.GetNames(typeof(CharacterState));

        for (int i = 0; i < stateNames.Length; i++)
        {
            CharacterState state = (CharacterState)Enum.Parse(typeof(CharacterState), stateNames[i]);
            Console.WriteLine($"{stateNames[i]} = {(int)state}");
        }
    }

    public void CurrentState()
    {
        Console.WriteLine($"현재 상태: {main_character.State}");
    }

    public void ChangeState(CharacterState state)
    {
        main_character.State = state;
        Console.WriteLine($"상태가 {main_character.State}로 변경되었습니다.");
    }

    public void Behavior()
    {
        switch (main_character.State)
        {
            case CharacterState.Idle:
                Console.WriteLine("[행동] 대기 중입니다.");
                break;
            case CharacterState.Walking:
                Console.WriteLine("[행동] 걷고 있습니다.");
                break;
            case CharacterState.Running:
                Console.WriteLine("[행동] 달리고 있습니다.");
                break;
            case CharacterState.Jumping:
                Console.WriteLine("[행동] 점프하고 있습니다.");
                break;
            case CharacterState.Attacking:
                Console.WriteLine("[행동] 적을 공격합니다!");
                break;
            case CharacterState.Dead:
                Console.WriteLine("[행동] 사망 상태입니다. 행동할 수 없습니다.");
                break;
        }
    }

    public void CharacterManage()
    {
        Console.WriteLine("=== 캐릭터 상태 관리 ===");
        bool loop = true;
        while (loop)
        {
            CurrentState();
            Console.WriteLine();
            Console.WriteLine("1. 상태 변경");
            Console.WriteLine("2. 상태 목록 보기");
            Console.WriteLine("3. 현재 행동 보기");
            Console.WriteLine("4. 종료");
            Console.Write("선택: ");
            int collect;
            if (Int32.TryParse(Console.ReadLine(), out collect))
            {
                if (1 > collect || 4 < collect) continue;
            }
            else continue;
            Console.WriteLine();
            switch (collect)
            {
                case 1:
                    Console.Write("변경할 상태 번호 입력 (0-5): ");
                    int stateNum;
                    if (Int32.TryParse(Console.ReadLine(), out stateNum))
                    {
                        if ((int)CharacterState.Idle > stateNum || (int)CharacterState.Dead < stateNum) continue;
                    }
                    else continue;
                    Console.WriteLine();
                    ChangeState((CharacterState)stateNum);
                    break;
                case 2:
                    StateInfo();
                    break;
                case 3:
                    Behavior();
                    break;
                case 4:
                    loop = false;
                    break;
            }
            Console.WriteLine();
        }
    }
}