











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
        int index = -1;

        for (int i = 0; i < items.Count; i++)
        {
            if (items[i].Priority > highestPriority)
            {
                highestPriority = items[i].Priority;
                index = i;
            }
        }

        T result = items[index].Value;
        items.RemoveAt(index);
        return result;
    }
}