namespace Jarp.FiniteStateGenerator
{
    public class Terminal<T>
    {
        public T Input { get; private set; }

        public T Output { get; private set; }

        public Terminal(T input, T output)
        {
            Input = input;
            Output = output;
        }

        public override string ToString()
        {
            return string.Format("[{0}] Input:{1} Output:{2}"
                , GetType().Name, Input, Output);
        }
    }
}
