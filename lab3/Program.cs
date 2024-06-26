namespace MemoryTestsLab
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello Tests!");
        }
    }
    public struct ValueTypeExample
    {
        public int Value;
    }

    public class ReferenceTypeExample
    {
        public int Value;
    }

    public class MemoryExamples
    {
        public void ModifyValueType(ValueTypeExample valueType)
        {
            valueType.Value = 10;
        }

        public void ModifyReferenceType(ReferenceTypeExample referenceType)
        {
            referenceType.Value = 10;
        }

        public void CreateObjectOnHeap()
        {
            var heapObject = new ReferenceTypeExample();
        }

        public void CreateObjectOnStack()
        {
            ValueTypeExample stackObject = new ValueTypeExample();
        }

        public void TriggerGarbageCollection()
        {
            GC.Collect();
        }
    }
}
