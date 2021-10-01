namespace MultipleInstanceExample.Domain
{
    public class Thing2 : IThing
    {
        public int DoThing(int i) => i * 2;
    }
}