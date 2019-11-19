namespace Advanced_Concepts
{
    public class Nullable<T> where T : struct
    {
        private readonly object _value;

        public Nullable()
        {
            
        }
        public Nullable(T value)
        {
            _value = value;
        }

        public bool HasValue => _value != null;

        public T GetValueOrDefault()
        {
            var result = HasValue  ? (T) _value : default;
            return result;

        }

    }
}