using OpenCover.Framework.Model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class StInterface : MonoBehaviour
{
    public void DrawHealth(Character ch, Character chc = null, Character chch = null, Character chchc = null)
    {
        Character[] chList = { ch, chc, chch, chchc };
        for (int i = 0; i < chList.Length; i++)
        {
            if (chList[i] == null) break;
            Debug.Log($"{chList[i]}의 체력 : {chList[i].GetHealth()}");
        }
    }

    void Start()
    {
        //게임시작
        // 플레이어 생성
        Player player = new Player(1000, 100);

        //던전입장
        // 몬스터 생성 - 슬라임, 고블린, 스켈레통 스폰
        Character slime = new Slime(200, 20);
        Goblin goblin = new Goblin(400, 350);
        Skeleton skeleton = new Skeleton(150, 150);

        DrawHealth(player);

        player.TakeDamage(slime);
        slime.TakeDamage(player);
        DrawHealth(player, slime);

        player.TakeDamage(goblin);
        goblin.TakeDamage(player);
        DrawHealth(player, slime, goblin);

        player.TakeDamage(skeleton);
        skeleton.TakeDamage(player);
        DrawHealth(player, slime, goblin, skeleton);

    }
}

public abstract class Character
{
    protected int health;
    protected int baseAttack;

    protected abstract int GetAttackValue();

    public int GetHealth()
    {
        return health;
    }
    public void TakeDamage(Character ch)
    {
        health -= ch.GetAttackValue();
        Debug.Log($"{ch}이(가) {this}를 {ch.GetAttackValue()}데미지만큼 때렸다!");
    }
}

public class Player : Character
{
    public Player(int _health, int _attack)
    {
        health = _health;
        baseAttack = _attack;
    }

    protected override int GetAttackValue()
    {
        int totalAttack = baseAttack;

        totalAttack += 50; //장비, 스킬연산

        return totalAttack;
    }
}

public class Monster : Character
{
    public Monster(int _health, int _attack)
    {
        health = _health;
        baseAttack = _attack;
    }

    protected override int GetAttackValue()
    {
        int totalAttack = baseAttack;
        totalAttack += 50;
        return baseAttack;
    }
}

public class Slime : Monster
{
    public Slime(int _health, int _attack) : base(_health, _attack) { }

    protected override int GetAttackValue()
    {
        int totalAttack = baseAttack;
        totalAttack += 50;

        return totalAttack;
    }

    // 걷기, 공격하기, 죽기... 재정의 후 사용
}

public class Goblin : Monster
{
    public Goblin(int _health, int _attack) : base(_health, _attack) { }

    protected override int GetAttackValue()
    {
        int totalAttack = baseAttack;
        totalAttack += 50;

        return totalAttack;
    }

    // 걷기, 공격하기, 죽기... 재정의 후 사용
}

public class Skeleton : Monster
{
    public Skeleton(int _health, int _attack) : base(_health, _attack) { }

    protected override int GetAttackValue()
    {
        int totalAttack = baseAttack;
        totalAttack += 50;

        return totalAttack;
    }

    // 걷기, 공격하기, 죽기... 재정의 후 사용
}
