




    using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add items with different priorities, remove them
    // Expected: Dequeue should return highest priority item
    // Defect(s) Found: None
    public void TestPriorityQueue_EnqueueDequeue_HighestFirst()
    {
        var pq = new PriorityQueue<string>();
        pq.Enqueue("Low", 1);
        pq.Enqueue("Medium", 5);
        pq.Enqueue("High", 10);

        Assert.AreEqual("High", pq.Dequeue());
        Assert.AreEqual("Medium", pq.Dequeue());
        Assert.AreEqual("Low", pq.Dequeue());
    }

    [TestMethod]
    // Scenario: Multiple items with same priority
    // Expected: First-in item with highest priority should be dequeued first (FIFO within same priority)
    // Defect(s) Found: None
    public void TestPriorityQueue_TieBreakerFIFO()
    {
        var pq = new PriorityQueue<string>();
        pq.Enqueue("A", 5);
        pq.Enqueue("B", 5);
        pq.Enqueue("C", 5);

        Assert.AreEqual("A", pq.Dequeue());
        Assert.AreEqual("B", pq.Dequeue());
        Assert.AreEqual("C", pq.Dequeue());
    }

    [TestMethod]
    // Scenario: Try to dequeue from empty queue
    // Expected: Exception thrown with message
    // Defect(s) Found: None
    public void TestPriorityQueue_EmptyDequeue()
    {
        var pq = new PriorityQueue<int>();

        try
        {
            pq.Dequeue();
            Assert.Fail("Expected exception was not thrown.");
        }
        catch (InvalidOperationException ex)
        {
            Assert.AreEqual("The queue is empty.", ex.Message);
        }
    }
}
