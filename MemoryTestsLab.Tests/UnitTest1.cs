using MemoryTestsLab;

namespace MemoryTestsLab.Tests
{
    public class MemoryExamplesTests
    {
        [Fact]
        public void ValueTypeIsPassedByValue()
        {
            var memoryExamples = new MemoryExamples();
            var valueType = new ValueTypeExample { Value = 5 };

            memoryExamples.ModifyValueType(valueType);

            Assert.Equal(5, valueType.Value);
        }

        [Fact]
        public void ReferenceTypeIsPassedByReference()
        {
            var memoryExamples = new MemoryExamples();
            var referenceType = new ReferenceTypeExample { Value = 5 };

            memoryExamples.ModifyReferenceType(referenceType);

            Assert.Equal(10, referenceType.Value);
        }

        [Fact]
        public void ObjectIsCreatedOnHeap()
        {
            var memoryExamples = new MemoryExamples();
            memoryExamples.CreateObjectOnHeap();

           
        }

        [Fact]
        public void ObjectIsCreatedOnStack()
        {
            var memoryExamples = new MemoryExamples();
            memoryExamples.CreateObjectOnStack();

            
        }

        [Fact]
        public void GarbageCollectorWorks()
        {
            var memoryExamples = new MemoryExamples();
            memoryExamples.TriggerGarbageCollection();

          

        }
    }
}
