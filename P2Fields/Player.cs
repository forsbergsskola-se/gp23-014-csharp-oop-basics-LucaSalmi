namespace P2Fields;

public class Player
{
    public Player(string name, string emailAddress, int level, int gold, int wood, int stone, int experience, bool hasVipSubscription,
        bool hasPvpActive)
    {
        this.name = name;
        this.emailAddress = emailAddress;
        this.level = level;
        this.gold = gold;
        this.wood = wood;
        this.stone = stone;
        this.experience = experience;
        this.hasVipSubscription = hasVipSubscription;
        this.hasPvpActive = hasPvpActive;
    }

    public override string ToString()
    {
        return
            $"Player A has {gold} Gold, {stone} Stone, {wood} Wood. He is level {level} and has {experience} Experience. {(hasVipSubscription ? "He has an active VIP subscription" : "He does not have an active VIP subscription")}, {(hasPvpActive ? "Has PvP active" : "PvP is inactive")}. His display name is {name} and his e-mail address {emailAddress}";
    }

    public string name { get; set; }
    public string emailAddress { get; set; }
    public int level { get; set; }
    public int gold { get; set; }
    public int wood { get; set; }
    public int stone { get; set; }
    public int experience { get; set; }
    public bool hasVipSubscription { get; set; }
    public bool hasPvpActive { get; set; }
}