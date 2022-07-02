namespace IfStatements
{
    public static class Task4
    {
        public static int DoSomething(bool b1, bool b2, bool b3, bool b4)
        {
            if (b1)
            {
                if (b2)
                {
                    if (b4)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
                else
                {
                    if (b3)
                    {
                        if (b4)
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                    else
                    {
                        if (b4)
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
            else
            {
                if (b2)
                {
                    if (b3)
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
                else
                {
                    if (b3)
                    {
                        if (b4)
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                    else
                    {
                        if (b4)
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
