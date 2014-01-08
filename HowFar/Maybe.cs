using System;

namespace HowFar
{
    public abstract class Maybe<T>
    {
        public abstract bool IsNothing { get; }
        public abstract T Value { get; }
    }

    public class Nothing<T> : Maybe<T>
    {
        public override bool IsNothing
        {
            get
            {
                return true;
            }
        }

        public override T Value
        {
            get
            {
                throw new InvalidOperationException();
            }
        }
    }

    public class Just<T> : Maybe<T>
    {
        private T value;

        public Just(T Value)
        {
            this.value = Value;
        }

        public override bool IsNothing
        {
            get
            {
                return false;
            }
        }

        public override T Value
        {
            get
            {
                return this.value;
            }
        }
    }
}
