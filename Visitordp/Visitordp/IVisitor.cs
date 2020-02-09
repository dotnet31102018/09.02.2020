namespace Visitordp
{
    public interface IVisitor
    {
        double Visit(Liquor liquor);

        double Visit(Tabacco tabacco);

        double Visit(Chocolate chocolate);
    }
}