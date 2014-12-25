public string info = "In Euclidean plane geometry, a rectangle is any quadrilateral with four right angles. It can also be defined as an equiangular quadrilateral, since equiangular means that all of its angles are equal (360°/4 = 90°).";

        public double calculatearea(double a, double b)
        {
            return a * b; 
            
        }
        public double calculateenv(double a, double b)
        {
            return 2 * (a + b);
         
        }
        public void paint(double a, double b)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
