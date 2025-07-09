




















using System;
using System.Collections.Generic;

public class PriorityQueueItem<T>
{
    public T Value { get; set; }
    public int Priority { get; set; }

    public PriorityQueueItem(T value, int priority)
    {
        Value = value;
        Priority = priority;
    }
}

public class PriorityQueue<T>
{
    private List<PriorityQueueItem<T>> items = new List<PriorityQueueItem<T>>();

    public int Count => items.Count;

    public void Enqueue(T value, int priority)
    {
        items.Add(new PriorityQueueItem<T>(value, priority));
    }

    public T Dequeue()
    {
        if (items.Count == 0)
            throw new InvalidOperationException("The queue is empty.");

        int highestPriority = int.MinValue;

        // First: find the highest priority
        foreach (var item in items)
        {
            if (item.Priority > highestPriority)
            {
                highestPriority = item.Priority;
            }
        }

        // Second: return the first item with that priority (FIFO within same priority)
        for (int i = 0; i < items.Count; i++)
        {
            if (items[i].Priority == highestPriority)
            {
                T result = items[i].Value;
                items.RemoveAt(i);
                return result;
            }
        }

        // This point should never be reached
        throw new InvalidOperationException("Unexpected error during dequeue.");
    }
}