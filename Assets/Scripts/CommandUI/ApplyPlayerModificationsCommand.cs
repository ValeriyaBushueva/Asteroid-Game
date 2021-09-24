public class ApplyPlayerModificationsCommand : Command
{
    private Player player;

    public ApplyPlayerModificationsCommand(Player player)
    {
        this.player = player;
    }

    public override void Do()
    {
        player.ApplyModifications();
    }

    public override void Undo()
    {
        player.DiscourageModifications();
    }
}