namespace Common;

public interface IStackReader<out E>
{
    E Pop();
    bool Empty();
}