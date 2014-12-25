class Ball
    {
       public string info ="A sphere (from Greek σφαῖρα — sphaira, globe, ball [1]) is a perfectly round geometrical and circular object in three-dimensional space that resembles the shape of a completely round ball.";

       public double pi=3.14159; 
       public double calculatevolume(int r)
        {
           double volume=4/3*(Math.Pow(r,3));

           return volume;
        }


    }
