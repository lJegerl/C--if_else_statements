namespace IfStatements
{
    public static class Task6
    {
        public static int DoSomething(int i)
        {
            // TODO Implement the method.
            if (i < -8)
            {
                return i * i;
            }
            else if (i >= 7)
            {
                return i * 2;
            }
            else if (i <= -2)
            {
                return i * 3;
            }
            else if (i > 3)
            {
                return i * (i - 1) * -1;
            }

            return (i * 2) + (i * i);
        }
    }
}
