public class AV3
{
    public static void PrintPrettyMatrix(Matriz4 m)
    {
        for(int i = 0; i < 16; i++)
        {
            if(i == 0 || i == 4 || i == 8 ||i == 12)
            {
                Console.Write("{ " + m[i] + ", ");
            }
            else if(i == 3 || i == 7 || i == 11 || i == 15)
            {
                Console.Write(m[i] + "}" + "\n");
            }
            else
            {
                Console.Write(m[i] + ", ");
            }
        }
    }

    public static void Main()
    {
        Matriz4 Matriz = new Matriz4(0, 1, 1, 0
                            , 0, 0, 1, 0
                            , 1, 0, 0, 1
                            , 1, 0, 0, 0);
        PrintPrettyMatrix(Matriz);
        
        Matrices m = new Matrices();
        float[] ArrayT = m.tranpose(Matriz);
        float[] vCentro = m.vetorCentro(Matriz);
    }
}