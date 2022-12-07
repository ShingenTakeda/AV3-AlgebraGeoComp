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
        float norma0 = m.norma(ar_vetor);
        float[,] a0 = m.mul(1/norma0, ar_vetor);
        //m.PrintPrettyVetor(a0);

        float[,] resMulArr = m.dot(ar_mat, ar_trans);
        //A1 passo a passo formula
        #region A1
        float[,] resMulArrVetor1 = m.dot(resMulArr, a0);
        float norma1 = m.norma(resMulArrVetor1);
        float[,] a1 = m.mul(1/norma1, resMulArrVetor1);
        Console.WriteLine("A1: ");
        m.PrintPrettyVetor(a1);//Printa só o vetor tirando os 0's
        Console.WriteLine("\n");
        #endregion

        #region A2
        float[,] resMulArrVetor2 = m.dot(resMulArr, a1);
        float norma2 = m.norma(resMulArrVetor2);
        float[,] a2 = m.mul(1/norma2, resMulArrVetor2);
        Console.WriteLine("A2: ");
        m.PrintPrettyVetor(a2);
        Console.WriteLine("\n");
        #endregion

        #region A3
        float[,] resMulArrVetor3 = m.dot(resMulArr, a2);
        float norma3 = m.norma(resMulArrVetor3);
        float[,] a3 = m.mul(1/norma3, resMulArrVetor3);
        Console.WriteLine("A3: ");
        m.PrintPrettyVetor(a3);
        Console.WriteLine("\n");
        #endregion

        #region A4
        float[,] resMulArrVetor4 = m.dot(resMulArr, a3);
        float norma4 = m.norma(resMulArrVetor4);
        float[,] a4 = m.mul(1/norma4, resMulArrVetor4);
        Console.WriteLine("A4: ");
        m.PrintPrettyVetor(a4);
        Console.WriteLine("\n");
        #endregion

        #region A5
        float[,] resMulArrVetor5 = m.dot(resMulArr, a4);
        float norma5 = m.norma(resMulArrVetor5);
        float[,] a5 = m.mul(1/norma5, resMulArrVetor5);
        Console.WriteLine("A5: ");
        m.PrintPrettyVetor(a5);
        Console.WriteLine("\n");
        #endregion

        #region A6
        float[,] resMulArrVetor6 = m.dot(resMulArr, a5);
        float norma6 = m.norma(resMulArrVetor6);
        float[,] a6 = m.mul(1/norma6, resMulArrVetor6);
        Console.WriteLine("A6: ");
        m.PrintPrettyVetor(a6);
        Console.WriteLine("\n");
        #endregion

        #region Sorting
        float[,] ordenado = a6;
        float aux = 0;
         for(int i = 0; i < 3; i++)
        {
            for(int j = 0; j < 4; j++)
            {
                if(ordenado[i,j] != 0)
                {
                    if (ordenado[i,j] < ordenado[i+1,j])
                    {
                        aux = ordenado[i,j];
                        ordenado[i,j] = ordenado[i+1,j];
                        ordenado[i+1,j] = aux;
                    }
                }
            }
        }

        m.PrintPrettyVetor(ordenado, true);
        #endregion
    }
}