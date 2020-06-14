using Microsoft.VisualStudio.TestTools.UnitTesting;
using StackProgram.Stack;

namespace CourseWork.Test
{
    [TestClass]
    public class UnitTest_Stack
    {

        [TestMethod]
        public void TestMethod_1() // проверка добавления элемента
        {
            ArrayStack<int> arrayStack = new ArrayStack<int>();
            arrayStack.Push(1);
            arrayStack.Push(4);
            Assert.AreEqual(4, arrayStack.Peek());
        }

        [TestMethod]
        public void TestMethod_2() // проверка удаления элемента
        {
            ArrayStack<int> arrayStack = new ArrayStack<int>();
            arrayStack.Push(1);
            arrayStack.Push(4);
            arrayStack.Pop();
            Assert.AreEqual(1, arrayStack.Peek());
        }

        [TestMethod]
        public void TestMethod_3() // проверка на символьном типе данных
        {
            ArrayStack<char> arrayStack = new ArrayStack<char>('h', 4);
            arrayStack.Push('g');
            arrayStack.Push('b');
            arrayStack.Pop();
            Assert.AreEqual('g', arrayStack.Peek());
        }

        [TestMethod]
        public void TestMethod_4() // проверка на вещественном типе данных
        {
            ArrayStack<float> arrayStack = new ArrayStack<float>(2.5f, 4);
            arrayStack.Push(2.1f);
            arrayStack.Push(4.32f);
            arrayStack.Pop();
            Assert.AreEqual(2.1f, arrayStack.Peek());
        }

    }
}
