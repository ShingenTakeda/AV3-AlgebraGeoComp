public class AV3
{
    public static void Main()
    {
        Matriz4 matriz = new Matriz4(0, 1, 1, 0
                            , 0, 0, 1, 0
                            , 1, 0, 0, 1
                            , 1, 0, 0, 0);
        
        Matrices m = new Matrices();
        //m.PrintPrettyMatrix(matriz);
        Matriz4 ArrayT = m.tranpose(matriz);
        Matriz4 vCentro = m.vetorCentro(matriz);

        float [,] ar_mat = m.ArrayOfArray(matriz);
        float[,] ar_trans = m.ArrayOfArray(ArrayT);
        float[,] resultado = m.dot(ar_mat, ar_trans);
        //m.PrintPrettyArray(resultado);

        float[,] ar_vetor = m.ArrayOfArray(vCentro);
        //m.PrintPrettyArray(ar_vetor);
        float[,] resultado2 = m.dot(resultado, ar_vetor);
        //m.PrintPrettyArray(resultado2);

        float[,] resultado3 = m.mul(2 , resultado2);
        m.PrintPrettyArray(resultado3);
    }
}