using System.Runtime.CompilerServices;

namespace Triangle
{
    /// <summary>
    /// Предоставляет функции для работы с треугольниками.
    /// </summary>
    public static class Triangle
    {
        /// <summary>
        /// Определяет тип треугольника.
        /// </summary>
        /// <param name="a">Длина первой стороны.</param>
        /// <param name="b">Длина второй стороны.</param>
        /// <param name="c">Длина третей стороны.</param>
        /// <returns>Возвращает вычесленный тип треугольника.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static TiangleType GetTypeBySides(float a, float b, float c)
        {
            var aSqr = a * a;
            var bSqr = b * b;
            var cSqr = c * c;

            var t = bSqr + cSqr;
            if (aSqr >= t)
                return (aSqr == t) ? TiangleType.Right : TiangleType.Obtuse;

            t = aSqr + cSqr;
            if (bSqr >= t)
                return (bSqr == t) ? TiangleType.Right : TiangleType.Obtuse;

            t = bSqr + aSqr;
            if (cSqr >= t)
                return (cSqr == t) ? TiangleType.Right : TiangleType.Obtuse;

            return TiangleType.Acute;
        }
    }
}