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
            Debug.Log($"{chList[i]}�� ü�� : {chList[i].GetHealth()}");
        }
    }

    void Start()
    {
        //���ӽ���
        // �÷��̾� ����
        Player player = new Player(1000, 100);

        //��������
        // ���� ���� - ������, ���, ���̷��� ����
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
        Debug.Log($"{ch}��(��) {this}�� {ch.GetAttackValue()}��������ŭ ���ȴ�!");
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

        totalAttack += 50; //���, ��ų����

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

    // �ȱ�, �����ϱ�, �ױ�... ������ �� ���
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

    // �ȱ�, �����ϱ�, �ױ�... ������ �� ���
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

    // �ȱ�, �����ϱ�, �ױ�... ������ �� ���
}
