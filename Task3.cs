namespace IfStatements
{
    public static class Task3
    {
        public static int DoSomething1(bool b, int i)
        {
            // TODO Implement the method.
            int res;
            if (b)
            {
                if (i <= -6)
                {
                    res = i - 10;
                }
                else
                {
                    res = i + 1;
                }
            }
            else
            {
                if (i < 8)
                {
                    res = i - 1;
                }
                else
                {
                    res = i + 10;
                }
            }

            return res;
        }

        public static int DoSomething2(bool b, int i)
        {
            // TODO Implement the method.
            int res;
            if (b)
            {
                if (i <= -6)
                {
                    res = i - 10;
                }
                else
                {
                    res = i + 1;
                }
            }
            else
            {
                if (i < 8)
                {
                    res = i - 1;
                }
                else
                {
                    res = i + 10;
                }
            }

            return res;
        }
    }
}
