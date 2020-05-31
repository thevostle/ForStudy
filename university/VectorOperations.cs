using System;

namespace Lab_Vector
{

    class Vector
    {
        public readonly float x;
        public readonly float y;
        public readonly float z;

        public Vector(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public float Lenght()
        {
            this.lenght = MathF.Sqrt(MathF.Pow(x, 2) + MathF.Pow(y, 2) + MathF.Pow(z, 2));
            return this.lenght;
        }

        public void PrintData()
        {
            Console.WriteLine("X: {0}, Y: {1}, Z: {2}", this.x, this.y, this.z);
        }

        public float lenght { get; set; }
    }

    class Calculate
    {
        public Vector VectorSum(Vector v1, Vector v2) // сложение векторов
        {
            return new Vector(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);
        }

        public Vector VectorSub(Vector v1, Vector v2) // вычетание векторов
        {
            return new Vector(v1.x - v2.x, v1.y - v2.y, v1.z - v2.z);
        }

        public float VectorScale(Vector v1, Vector v2) // скалярное произведение векторов
        {
            return v1.lenght * v2.lenght * VectorCos(v1, v2);
        }

        public float VectorCos(Vector v1, Vector v2) // косинус угла между векторами
        {
            float cos_1 = v1.x * v2.x + v1.y * v2.y + v1.z * v2.z;
            float cos_2 = MathF.Sqrt(MathF.Pow(v1.x, 2) + MathF.Pow(v1.y, 2) + MathF.Pow(v1.z, 2)) * MathF.Sqrt(MathF.Pow(v2.x, 2) + MathF.Pow(v2.y, 2) + MathF.Pow(v2.z, 2));

            return cos_1 / cos_2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Vector vector1 = new Vector(0, 1, 0);
            Vector vector2 = new Vector(0, 0, 1);

            Calculate calculate = new Calculate();

            Vector v_sum = calculate.VectorSum(vector1, vector2);
            v_sum.PrintData();

            Vector v_sub = calculate.VectorSub(vector1, vector2);
            v_sub.PrintData();

            Console.WriteLine(calculate.VectorCos(vector1, vector2));
            Console.WriteLine(calculate.VectorScale(vector1, vector2));
        }
    }
}
