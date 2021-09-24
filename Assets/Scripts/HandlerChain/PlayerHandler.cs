public abstract class PlayerHandler
{
    private Player player;
    public void Initialize(Player player) => this.player = player;

    public void Handle() => Handle(player);
    public void Unhandle() => Unhandle(player);
    protected abstract void Handle(Player player);

    protected abstract void Unhandle(Player player);
}