using FluentAssertions;

namespace DemoTDD.DataStructures.Tests
{
    public class StackTests
    {
        private readonly Stack _stack;
        private const int X = 0;
        private const int Y = 99;

        public StackTests()
        {
            _stack = new Stack();
        }

        [Fact]
        public void IsEmpty_NewStack_ShouldReturnTrue()
        {
            bool isEmpty = _stack.IsEmpty();

            isEmpty
                .Should()
                .BeTrue();
        }

        [Fact]
        public void IsEmpty_StackWithOneElement_ShouldBeFalse()
        {
            _stack.Push(X);

            bool isEmpty = _stack.IsEmpty();

            isEmpty
                .Should()
                .BeFalse();
        }

        [Fact]
        public void IsEmpty_OnePushOnePop_ShouldReturnTrue()
        {
            _stack.Push(X);
            _stack.Pop();

            bool isEmpty = _stack.IsEmpty();

            isEmpty
                .Should()
                .BeTrue();
        }

        [Fact]
        public void Pop_EmptyStack_ShouldThrow()
        {
            Action popHandler = () => _stack.Pop();

            popHandler
                .Should()
                .ThrowExactly<InvalidOperationException>();
        }

        [Fact]
        public void Pop_OnePushedElement_ShouldReturnCorrectElement()
        {
            _stack.Push(X);

            int element = _stack.Pop();

            element
                .Should()
                .Be(X);
        }

        [Fact]
        public void IsEmpty_TwoPushesOnePop_ShouldReturnFalse()
        {
            _stack.Push(X);
            _stack.Push(Y);
            _stack.Pop();

            bool isEmpty = _stack.IsEmpty();

            isEmpty
                .Should()
                .BeFalse();
        }

        [Fact]
        public void Pop_TwoPushesOnTheSecondPop_ShouldReturnTheFirstPushedElement()
        {
            _stack.Push(X);
            _stack.Push(Y);
            _stack.Pop();

            int element = _stack.Pop();

            element
                .Should()
                .Be(X);
        }
    }
}