namespace OakTech.CelebrateWith.Data.Entities
{
    public record InviteeLink(
        Invitee Invitee1, 
        Invitee Invitee2
    ): Entity;
}
