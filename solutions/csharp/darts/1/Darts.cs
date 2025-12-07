public static class Darts
{
    public static int Score(double x, double y)
    {
        double r=x*x+y*y;
        if(r>100)
            return 0;
        else if(r>25&&r<=100)
            return 1;
        else if(r>1&&r<=25)
            return 5;
        else 
            return 10;

    }
}
