public class UnitFactory : IUnitFactory
{
    public IUnit CreateEnemy(float hp)
    {
        return new Enemy(hp);
    }
}
