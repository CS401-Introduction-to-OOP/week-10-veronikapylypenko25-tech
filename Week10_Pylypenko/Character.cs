namespace Week10_Pylypenko;

public enum CharacterStatus
{
    Active, 
    Injured, 
    Dead
}

public class Character
{
    public string Name { get; set; }
    public string Role { get; set; }
    public int Level { get; set; }
    public int Welbeeing { get; set; }
    public int Gold { get; set; }
    public CharacterStatus Status { get; set; }

    public Character(string name, string role, int level, int welbeeing, int gold, CharacterStatus status)
    {
        Name = name;
        Role = role;
        Level = level;
        Welbeeing = welbeeing;
        Gold = gold;
        Status = status;
    }
    

    public void HpChange(int amount)
    {
        Welbeeing += amount;
        if (Welbeeing <= 0)
        {
            Welbeeing = 0;
            Status = CharacterStatus.Dead;
        }
        else if (Welbeeing <= 45)
        {
            Status = CharacterStatus.Injured;
        }
        else
        {
            Status = CharacterStatus.Active;
        }
    }

    public void GoldChange(int amount)
    {
        Gold += amount;
        if (Gold < 0)
        {
            Gold = 0;
        }
    }

    public override string ToString()
    {
        return $"Name: {Name}, role: {Role}, level: {Level}, HP: {Welbeeing}, gold: {Gold}, status: {Status}.";
    }
}