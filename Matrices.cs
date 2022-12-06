public struct Matriz4
{
    float[] asArray = new float[16];

    public float _11, _12, _13, _14,
               _21, _22, _23, _24,
               _31, _32, _33, _34,
               _41, _42, _43, _44;

    public float this[int i]
    {
        get { return asArray[i * 4]; }
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

    public float[] tranpose(Matriz4 asArray)
    {
        float[] arrayT = new float[16];
        for (int i = 0; i < 16; i++)
        {
            int row = i / 4;
            int col = i % 4;
            arrayT[i] = asArray[col * 4 + row];
        }
        return arrayT;
    }
}