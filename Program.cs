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
        Matriz4 vCentro = m.vetorCentro(matriz);

        float [,] ar_mat = m.ArrayOfArray(matriz);
        float[,] ar_trans = m.ArrayOfArray(ArrayT);
        float[,] ar_vetor = m.ArrayOfArray(vCentro);

        float[,] resMulArr = m.dot(ar_mat, ar_trans);
        //m.PrintPrettyArray(resMulArr);
        float[,] resMulArrVetor = m.dot(resMulArr, ar_vetor);
        //m.PrintPrettyArray(resMulArrVetor);
        float norma = m.norma(resMulArrVetor);
        //Console.WriteLine(norma);
        float[,] a1 = m.mul(1/norma, resMulArrVetor);
        m.PrintPrettyVetor(a1);
    }
}