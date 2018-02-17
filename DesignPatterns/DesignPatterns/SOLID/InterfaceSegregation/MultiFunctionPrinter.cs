namespace DesignPatterns.SOLID.InterfaceSegregation {
    public class MultiFunctionPrinter : IMultiFunctionDevice {
        public void Print(Document d) {
            throw new System.NotImplementedException();
        }

        public void Scan(Document d) {
            throw new System.NotImplementedException();
        }
    }
}