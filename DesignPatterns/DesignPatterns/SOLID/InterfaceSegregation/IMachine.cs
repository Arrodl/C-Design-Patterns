
namespace DesignPatterns.SOLID.InterfaceSegregation {
    public interface IMachine {
        void Print(Document d);
        void Scan(Document d);
        void Fax(Document d);
    }
}