
namespace AbstractClasses
{
    public interface IMovable
    {
        void Move();
    }

    public interface IAlive
    {
        int Age { get; set; }
    }
}
