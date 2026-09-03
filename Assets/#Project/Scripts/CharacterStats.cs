using System;

[Serializable]
public struct CharacterStats
{
    public int attack;
    public int defense;
    public int willpower;
    public int charisma;
}


// CharacterStats stat1 = new();
// stat1.charisma = 10;
// CharacterStats stat2;
// stat2 = stat1;
// stat2.charisma = 50000;
// Debug.Log(stat1.charisma);