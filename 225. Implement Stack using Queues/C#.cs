public class MyStack {
    private Queue<int> queue;

    public MyStack() {
        queue = new();
    }
    
    public void Push(int x) {
        queue.Enqueue(x);
        int c = queue.Count - 1;
        while (c --> 0) {
            queue.Enqueue(queue.Dequeue());
        }
    }
    
    public int Pop() {
        return queue.Dequeue();
    }
    
    public int Top() {
        return queue.Peek();
    }
    
    public bool Empty() {
        return queue.Count == 0;
    }
}