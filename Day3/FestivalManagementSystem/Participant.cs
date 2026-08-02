namespace FestivalManagementSystem;

public class Participant
{
    public string participantName;
    public bool isTeam;

    public Participant(string name , bool team = false)
    {
        participantName = name;
        isTeam = team;
    }
}

