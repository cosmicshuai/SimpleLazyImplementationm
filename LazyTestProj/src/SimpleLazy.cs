namespace SimpleLazy
{
    public class SimpleLazy<T> where T : new()
    {
        private object? internalValue;
        private Func<T>? func;
        public SimpleLazy()
        {
        }

        public SimpleLazy(Func<T> function)
        {
            this.func = function;
        }

        public bool isValueCreated()
        {
            return internalValue != null && internalValue is T;
        }

        public T Value { 
            get
            {
                if (internalValue == null)
                {
                    if (this.func != null)
                    {
                        internalValue = this.func();
                    }
                    else
                    {
                        //(T)Activator.CreateInstance(typeof(T)) does the same thing here
                        internalValue = new T();
                    }
                }

                return (T)internalValue;
            }
        }
    }
}
