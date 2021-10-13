# Linked List - Kth

## kth from end

Write the following method for the Linked List class:

* kth from end
* argument: a number (**k**), as a parameter.

* Return the node’s value that is (**k**) places from the tail of the linked list.

* You have access to the Node class and all the properties on the Linked List class as well as the methods created in previous challenges.

---

### Problem Domain

Given a number (**k**), return the node's value that is that (**k**)'s # of places away from the tail end of the list.

---

### Inputs and Expected Outputs

| Input (**Linked List**) | Arg (**k**) | Expected Output |
| :----------- | :----------- | :----------- |
| [**head -> [1] -> [3] -> [8] -> [2] -> X**] | 0 | 2 |
| [**head -> [1] -> [3] -> [8] -> [2] -> X**] | 2 | 3 |

---

### Big O

| Time | Space |
| :----------- | :----------- |
| O(n) | O(1) |

---

## Unit Tests

Write tests for the following scenarios, and any other cases that help you ensure your code is working as expected.

1. Where k is greater than the length of the linked list
2. Where k and the length of the list are the same
3. Where k is not a positive integer
4. Where the linked list is of a size 1
5. “Happy Path” where k is not at the end, but somewhere in the middle of the linked list

---

### Whiteboard Visual

![whiteboard](linked-list-kth.jpg)

---

### Change Log

---

[Home](/README.md)