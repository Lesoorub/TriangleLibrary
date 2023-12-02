namespace Triangle.Tests
{
    /// <summary>
    /// ��������� ����� ������ �������������� ������������ ������ ������ 
    /// <see cref="Triangle.GetTypeBySides(float, float, float)"/> ������ 
    /// ������ �� ���� ������ ��������� �������������.
    /// </summary>
    [TestClass]
    public class TriangleGetTypeBySidesTests
    {
        /// <summary>
        /// �������� ������� <see cref="Triangle.GetTypeBySides(float, float, float)"/> 
        /// � �������� ����������� ��������������� ���� ������������ <see cref="TiangleType.Obtuse"/>.
        /// </summary>
        [TestMethod]
        public void TryGetTypeBySidesReturnsAcuteIfSidesEqual_1_1_1()
        {
            Assert.AreEqual(TiangleType.Acute, Triangle.GetTypeBySides(1, 1, 1));
        }

        /// <summary>
        /// �������� ������� <see cref="Triangle.GetTypeBySides(float, float, float)"/> 
        /// � �������� ����������� ��������������� ���� ������������ <see cref="TiangleType.Right"/>.
        /// </summary>
        [TestMethod]
        public void TryGetTypeBySidesReturnsRightIfSidesEqual_3_4_5()
        {
            Assert.AreEqual(TiangleType.Right, Triangle.GetTypeBySides(3, 4, 5));
        }

        /// <summary>
        /// �������� ������� <see cref="Triangle.GetTypeBySides(float, float, float)"/> 
        /// � �������� ����������� ��������������� ���� ������������ <see cref="TiangleType.Obtuse"/>.
        /// </summary>
        [TestMethod]
        public void TryGetTypeBySidesReturnsObtuseIfSidesEqual_3_4_6()
        {
            Assert.AreEqual(TiangleType.Obtuse, Triangle.GetTypeBySides(3, 4, 6));
        }
    }
}