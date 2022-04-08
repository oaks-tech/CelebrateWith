using OakTech.CelebrateWith.Data.Entities.Food;

namespace OakTech.CelebrateWith.Data.Entities
{
    public record MealChoice(
        Guid InviteeId,
        Starter Starter, 
        Main Main,
        Desert Desert
    ): Entity;
}
