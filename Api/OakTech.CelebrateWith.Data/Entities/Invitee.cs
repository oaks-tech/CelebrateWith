namespace OakTech.CelebrateWith.Data.Entities
{
    public record Invitee(
      string FirstName,
      string LastName,
      string EmailAddress,
      bool EveningOnly,
      Guid EmailLink
    ): Entity;
}
