static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        if(speed==0){
            return 0;
        }else if(speed>=1&&speed<=4){
            return 1;
        }else if(speed>=5&&speed<=8){
            return 0.9;            
        }else if(speed==9){
            return 0.8;           
        }else{
            return 0.77;
        }

    }
    
    public static double ProductionRatePerHour(int speed)
    {
        int _speed=speed*221;
        if(speed==0){
            return 0;
        }else if(speed>=1&&speed<=4){
            return 1*_speed;
        }else if(speed>=5&&speed<=8){
            return 0.9*_speed;            
        }else if(speed==9){
            return 0.8*_speed;           
        }else{
            return 0.77*_speed;
        }
        

    }

    public static int WorkingItemsPerMinute(int speed)
    {
        int _speed=speed*221;
        if(speed==0){
            return 0;
        }else if(speed>=1&&speed<=4){
            return (int)(1*_speed/60);
        }else if(speed>=5&&speed<=8){
            return (int)(0.9*_speed/60);            
        }else if(speed==9){
            return (int)(0.8*_speed/60);           
        }else{
            return (int)(0.77*_speed/60);
        }
        
    }
}
