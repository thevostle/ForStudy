using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StackProgram.Test
{
    [TestClass]
    public class UnitTest_Stack
    {

        [TestMethod]
        public void TestMethod_1() // проверка добавления элемента
        {
            ArrayStack<int> stack = new ArrayStack<int>();
            arrayStack.Push(1);
            arrayStack.Push(4);
            Assert.AreEqual(4, arrayStack.Peek());
        }

        [TestMethod]
        public void TestMethod_2() // проверка удаления элемента
        {
            ArrayStack<int> stack = new ArrayStack<int>();
            arrayStack.Push(1);
            arrayStack.Push(4);
            arrayStack.Pop();
            Assert.AreEqual(1, arrayStack.Peek());
        }

        [TestMethod]
        public void TestMethod_3() // проверка на другом типе данных
        {
            ArrayStack<float> stack = new ArrayStack<float>(2.5f, 3);
            arrayStack.Push(2.1f);
            arrayStack.Push(4.32f);
            arrayStack.Pop();
            Assert.AreEqual(2.1f, arrayStack.Peek());
        }
    }
}
