public class AV3
{
    public static void Main()
    {
        Matriz4 matriz = new Matriz4(0, 1, 1, 0
                            , 0, 0, 1, 0
                            , 1, 0, 0, 1
                            , 1, 0, 0, 0);

        Matrices m = new Matrices();
        m.PrintPrettyMatrix(matriz);
        float [,] ar_mat = m.ArrayOfArray(matriz);
        m.PrintPrettyArray(ar_mat);
        float[] ArrayT = m.tranpose(matriz);
        float[] vCentro = m.vetorCentro(matriz);
    }
}