public struct Matriz4
{
    float[] asArray = new float[16];

    public float _11, _12, _13, _14,
               _21, _22, _23, _24,
               _31, _32, _33, _34,
               _41, _42, _43, _44;

    public float this[int i]
    {
        get {return asArray[i];}
    }

    public void SetasArray(int i, float valor)
    {
        asArray[i] = valor;
    }

    public Matriz4(float m11, float m12, float m13, float m14,
    float m21, float m22, float m23, float m24,
    float m31, float m32, float m33, float m34,
    float m41, float m42, float m43, float m44)
    {
        this._11 = m11;
        this._12 = m12;
        this._13 = m13;
        this._14 = m14;
        this._21 = m21;
        this._22 = m22;
        this._23 = m23;
        this._24 = m24;
        this._31 = m31;
        this._32 = m32;
        this._33 = m33;
        this._34 = m34;
        this._41 = m41;
        this._42 = m42;
        this._43 = m43;
        this._44 = m44;

        asArray[0] = this._11;
        asArray[1] = this._12;
        asArray[2] = this._13;
        asArray[3] = this._14;
        asArray[4] = this._21;
        asArray[5] = this._22;
        asArray[6] = this._23;
        asArray[7] = this._24;
        asArray[8] = this._31;
        asArray[9] = this._32;
        asArray[10] = this._33;
        asArray[11] = this._34;
        asArray[12] = this._41;
        asArray[13] = this._42;
        asArray[14] = this._43;
        asArray[15] = this._44;
    }
}

class Matrices
{

    public float[,] dot(float[,] m1, float[,] m2)
    {
        float[,] result = new float[4,4];
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                result[i, j] = 0;
                for (int k = 0; k < 4; k++)
                {
                    result[i, j] += m1[i, k] * m2[k, j];
                }
            }
        }
        return result;
    }
    public Matriz4 tranpose(Matriz4 asArray)
        {
            Matriz4 m = new Matriz4{};
            for (int i = 0; i < 16; i++)
            {
                int row = i / 4;
                int col = i % 4;
                m.SetasArray(i, asArray[col * 4 + row]);
            }
            return m;
        }

    public float[] vetorCentro(Matriz4 asArray)
    {
        float[] vetorCentro = new float[4];
        vetorCentro[0] = (asArray._11 + asArray._12 + asArray._13 + asArray._14);
        vetorCentro[1] = (asArray._21 + asArray._22 + asArray._23 + asArray._24);
        vetorCentro[2] = (asArray._31 + asArray._32 + asArray._33 + asArray._34);
        vetorCentro[3] = (asArray._41 + asArray._42 + asArray._43 + asArray._44);
        return vetorCentro;
    }

    public void PrintPrettyMatrix(Matriz4 m)
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

    public float [,]ArrayOfArray(Matriz4 m)
    {
        float [,]array = new float[4, 4];
        int counter = 0;
        for(int i = 0; i < 4; i++)
        {
            for(int j = 0; j < 4; j++)
            {
                array[i, j] = m[counter];
                counter++;
            }
        }
        return array;
    }

    public void PrintPrettyArray(float [,]ar)
    {
        for(int i = 0; i < 4; i++)
        {
            for(int j = 0; j < 4; j++)
            {
                if(j == 0)
                {
                    Console.Write("{" + ar[i,j] + ", ");
                }
                else if(j == 3)
                {
                    Console.Write(ar[i,j] + "} " + "\n");
                }
                else
                {
                    Console.Write(ar[i,j] + ", ");
                }
            }
        }
    }
}