namespace DesignPatterns.SOLID.OpenClosed {
    public class AndSpecification<T> : ISpecification<T> {
        ISpecification<T> _first, _second;
        public AndSpecification(ISpecification<T> first, ISpecification<T> second) {
            _first = first ?? throw new System.ArgumentNullException(paramName: nameof(first));
            _second = second ?? throw new System.ArgumentNullException(paramName: nameof(second));
        }
        public bool isSatisfied(T t) => _first.isSatisfied(t) && _second.isSatisfied(t);
    }
}