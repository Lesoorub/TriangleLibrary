namespace Triangle.Tests
{
    /// <summary>
    /// Ремлизует набор тестов подтверждающих правильность работы функии 
    /// <see cref="Triangle.GetTypeBySides(float, float, float)"/> исходя 
    /// только из длин сторон возможных треугольников.
    /// </summary>
    [TestClass]
    public class TriangleGetTypeBySidesTests
    {
        /// <summary>
        /// Проверка функции <see cref="Triangle.GetTypeBySides(float, float, float)"/> 
        /// с входными параметрами соответствующие типу треугольника <see cref="TiangleType.Obtuse"/>.
        /// </summary>
        [TestMethod]
        public void TryGetTypeBySidesReturnsAcuteIfSidesEqual_1_1_1()
        {
            Assert.AreEqual(TiangleType.Acute, Triangle.GetTypeBySides(1, 1, 1));
        }

        /// <summary>
        /// Проверка функции <see cref="Triangle.GetTypeBySides(float, float, float)"/> 
        /// с входными параметрами соответствующие типу треугольника <see cref="TiangleType.Right"/>.
        /// </summary>
        [TestMethod]
        public void TryGetTypeBySidesReturnsRightIfSidesEqual_3_4_5()
        {
            Assert.AreEqual(TiangleType.Right, Triangle.GetTypeBySides(3, 4, 5));
        }

        /// <summary>
        /// Проверка функции <see cref="Triangle.GetTypeBySides(float, float, float)"/> 
        /// с входными параметрами соответствующие типу треугольника <see cref="TiangleType.Obtuse"/>.
        /// </summary>
        [TestMethod]
        public void TryGetTypeBySidesReturnsObtuseIfSidesEqual_3_4_6()
        {
            Assert.AreEqual(TiangleType.Obtuse, Triangle.GetTypeBySides(3, 4, 6));
        }
    }
}