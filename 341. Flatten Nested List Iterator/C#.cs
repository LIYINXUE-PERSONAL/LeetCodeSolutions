/*
 * @lc app=leetcode id=341 lang=csharp
 *
 * [341] Flatten Nested List Iterator
 */

// @lc code=start
/**
 * // This is the interface that allows for creating nested lists.
 * // You should not implement it, or speculate about its implementation
 * interface NestedInteger {
 *
 *     // @return true if this NestedInteger holds a single integer, rather than a nested list.
 *     bool IsInteger();
 *
 *     // @return the single integer that this NestedInteger holds, if it holds a single integer
 *     // Return null if this NestedInteger holds a nested list
 *     int GetInteger();
 *
 *     // @return the nested list that this NestedInteger holds, if it holds a nested list
 *     // Return null if this NestedInteger holds a single integer
 *     IList<NestedInteger> GetList();
 * }
 */
public class NestedIterator {
    private List<int> list;
    private int index;

    public NestedIterator(IList<NestedInteger> nestedList) {
        list = GetList(nestedList);
        index = 0;
    }

    private List<int> GetList(IList<NestedInteger> nestedList) {
        List<int> l = new();
        foreach (NestedInteger item in nestedList) {
            if (item.IsInteger()) {
                l.Add(item.GetInteger());
            } else {
                l.AddRange(GetList(item.GetList()));
            }
        }
        return l;
    }

    public bool HasNext() {
        return index < list.Count;
    }

    public int Next() {
        return list[index++];
    }
}

/**
 * Your NestedIterator will be called like this:
 * NestedIterator i = new NestedIterator(nestedList);
 * while (i.HasNext()) v[f()] = i.Next();
 */
// @lc code=end

