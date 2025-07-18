using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public CharacterClass charClass;
    public int hp = 1;
    public int atk = 1;
    public int intel = 1;
    public int def = 1;
    public string equipment = "";

    public int enemyHitPoint = 1;
    public Character hero = null;


    public void Start()
    {
        if (charClass == CharacterClass.Human)
            Human();
        else if (charClass == CharacterClass.Swordsman)
            Swordsman();
        else if (charClass == CharacterClass.Mage)
            Mage();
        else
            Tank();

        
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && charClass == CharacterClass.Human)
        {
            hero.enemyHitPoint = EnemyHit(enemyHitPoint, hero.hp);
        }
    }

    public enum CharacterClass
    {
        Human,
        Swordsman,
        Mage,
        Tank
    }

    void Human()
    {
        hp = 1;
        atk = 1;
        intel = 1;
        def = 1;
        equipment = "";
    }

    void Swordsman()
    {
        hp = 150;
        atk = 250;
        intel = 20;
        def = 30;
        equipment = "Sword";
    }

    void Mage()
    {
        hp = 90;
        atk = 15;
        intel = 150;
        def = 10;
        equipment = "Staff";
    }

    void Tank()
    {
        hp = 300;
        atk = 40;
        intel = 15;
        def = 200;
        equipment = "Shield";
    }

    int EnemyHit(int enemyHitPoint, int heroHp)
    {
        heroHp = heroHp - enemyHitPoint;
        return heroHp;
    }


}
