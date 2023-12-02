using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;

namespace TriangleGeometry.Tests
{
    /// <summary>
    /// Описывает бенчмарк функций определения типа триугольника.
    /// </summary>
    [SimpleJob(RuntimeMoniker.Net60)]
    [RPlotExporter]
    [TestClass]
    public class TriangleBenchmark
    {
        /// <summary>
        /// Тест запускающий бенчмарк.
        /// </summary>
        [TestMethod]
        public void Run()
        {
            BenchmarkRunner.Run<TriangleBenchmark>();
        }

        /// <summary>
        /// Бенчмарк функции <see cref="Triangle.GetTypeBySides(float, float, float)"/> 
        /// с входными параметрами соответствующие типу триугольника <see cref="TiangleType.Obtuse"/>.
        /// </summary>
        [Benchmark]
        public void GetTypeBySidesFromFloatsReturnsObtuse() =>
            Triangle.GetTypeBySides(3, 4, 6);

        /// <summary>
        /// Бенчмарк функции <see cref="Triangle.GetTypeBySides(float, float, float)"/> 
        /// с входными параметрами соответствующие типу триугольника <see cref="TiangleType.Right"/>.
        /// </summary>
        [Benchmark]
        public void GetTypeBySidesFromFloatsReturnsRight() =>
            Triangle.GetTypeBySides(3, 4, 5);

        /// <summary>
        /// Бенчмарк функции <see cref="Triangle.GetTypeBySides(float, float, float)"/> 
        /// с входными параметрами соответствующие типу триугольника <see cref="TiangleType.Acute"/>.
        /// </summary>
        [Benchmark]
        public void GetTypeBySidesFromFloatsReturnsAcute() =>
            Triangle.GetTypeBySides(1, 1, 1);
    }
}