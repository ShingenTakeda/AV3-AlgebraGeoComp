public class AV3
{
    public static void Main()
    {
        Matriz4 matriz = new Matriz4(0, 1, 1, 0
                                    ,0, 0, 1, 0
                                    ,1, 0, 0, 1
                                    ,1, 0, 0, 0);
        
        Matrices m = new Matrices();
        //m.PrintPrettyMatrix(matriz);
        Matriz4 ArrayT = m.tranpose(matriz);
        float[] vCentro = m.vetorCentro(matriz);

        float [,] ar_mat = m.ArrayOfArray(matriz);
        float[,] ar_trans = m.ArrayOfArray(ArrayT);
        float[,] resultado = m.dot(ar_mat, ar_trans);
        m.PrintPrettyArray(resultado);
    }
}